using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMEA_Simulator
{
	public partial class MainForm : Form
	{
		private const int UDP_PORT = 10110;
		private readonly UdpClient _udpClient = new UdpClient();
		private readonly IPEndPoint _ip = new IPEndPoint(IPAddress.Broadcast, UDP_PORT);

		public MainForm()
		{
			InitializeComponent();
		}

		~MainForm()
		{
			_udpClient.Close();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			SetupValidation();
			SetDefaultValues();

			var gpsRMC = new System.Timers.Timer
			{
				AutoReset = true,
				Enabled = false,
				Interval = 2000,
				SynchronizingObject = this
			};

			var gpsGGA = new System.Timers.Timer
			{
				AutoReset = true,
				Enabled = false,
				Interval = 10000,
				SynchronizingObject = this
			};

			gpsRMC.Elapsed += GpsRMC_Elapsed;
			gpsRMC.Start();

			gpsGGA.Elapsed += GpsGGA_Elapsed;
			gpsGGA.Start();
		}

		private void GpsGGA_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			var sentence = BuildGgaSentence(
				DateTime.UtcNow,
				Convert.ToInt32(latDegrees.Text),
				Convert.ToDecimal(latMinutes.Text),
				Convert.ToInt32(longDegrees.Text),
				Convert.ToDecimal(longMinutes.Text),
				cboLongHemisphere.SelectedItem.ToString().First(),
				cboLatHemisphere.SelectedItem.ToString().First(),
				(int)satsInUse.Value
				);

			SendNmea0183Broadcast(sentence);

		}

		private void SetDefaultValues()
		{
			cboLatHemisphere.Invoke((Action)(() => cboLatHemisphere.SelectedIndex = 0));
			cboLongHemisphere.Invoke((Action)(() => cboLongHemisphere.SelectedIndex = 0));
			cboMagDir.Invoke((Action)(() => cboMagDir.SelectedIndex = 0));
		}

		#region validation
		private void SetupValidation()
		{
			latDegrees.Validating += LatDegrees_Validating;
			longDegrees.Validating += LongDegrees_Validating;
			latMinutes.Validating += Minutes_Validating;
			longMinutes.Validating += Minutes_Validating;
			magneticVariation.Validating += MagneticVariation_Validating;
			speedOverGround.Validating += PositiveDecimal_Validating;
			CourseMadeGood.Validating += PositiveDecimal_Validating;
		}

		private void PositiveDecimal_Validating(object sender, CancelEventArgs e)
		{
			decimal value;
			var obj = (TextBox)sender;
			if (!decimal.TryParse(obj.Text, out value))
			{
				e.Cancel = true;
			}
		}

		private void MagneticVariation_Validating(object sender, CancelEventArgs e)
		{
			int mag;
			if (!int.TryParse(magneticVariation.Text, out mag) || mag < 0 || mag > 180)
			{
				e.Cancel = true;
			}
		}

		private void LongDegrees_Validating(object sender, CancelEventArgs e)
		{
			int lng;
			if (!int.TryParse(longDegrees.Text, out lng) || lng < 0 || lng > 180)
			{
				e.Cancel = true;
			}
		}

		private void Minutes_Validating(object sender, CancelEventArgs e)
		{
			decimal minutes;
			var obj = (TextBox)sender;
			if (!decimal.TryParse(obj.Text, out minutes) || minutes < 0 || minutes >= 60)
			{
				e.Cancel = true;
			}
		}

		private void LatDegrees_Validating(object sender, CancelEventArgs e)
		{
			int lat;
			if (!int.TryParse(latDegrees.Text, out lat) || lat < 0 || lat > 90)
			{
				e.Cancel = true;
			}
		}
		#endregion validation

		private void GpsRMC_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			var sentence = BuildRmcSentence(
				DateTime.UtcNow,
				Convert.ToInt32(latDegrees.Text),
				Convert.ToDecimal(latMinutes.Text),
				Convert.ToInt32(longDegrees.Text),
				Convert.ToDecimal(longMinutes.Text),
				cboLongHemisphere.SelectedItem.ToString().First(),
				cboLatHemisphere.SelectedItem.ToString().First(),
				Convert.ToDecimal(speedOverGround.Text),
				Convert.ToDecimal(CourseMadeGood.Text),
				Convert.ToDecimal(magneticVariation.Text),
				cboMagDir.SelectedItem.ToString().First()
				);

			SendNmea0183Broadcast(sentence);

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="timestamp"></param>
		/// <param name="latitudeDegrees"></param>
		/// <param name="longitudeDegrees"></param>
		/// <param name="longitudeHemisphere">W or E</param>
		/// <param name="latitudeHemisphere">N or S</param>
		/// <param name="speedInKnots"></param>
		/// <param name="trueCourse"></param>
		/// <param name="magneticVariation"></param>
		/// <param name="magneticVariationDirection">W or E</param>
		/// <returns></returns>
		private string BuildRmcSentence(
			DateTime timestamp,
			int latitudeDegrees,
			decimal latitudeMinutes,
			int longitudeDegrees,
			decimal longitudeMinutes,
			char longitudeHemisphere,
			char latitudeHemisphere,
			decimal speedInKnots,
			decimal trueCourse,
			decimal magneticVariation,
			char magneticVariationDirection)
		{
			var data = $"GPRMC,{timestamp:HHmmss},A,{latitudeDegrees:D2}{latitudeMinutes:00.000000},{latitudeHemisphere},{longitudeDegrees:D3}{longitudeMinutes:00.000000},{longitudeHemisphere},{speedInKnots},{trueCourse},{timestamp:ddMMyy},{magneticVariation},{magneticVariationDirection}";
			var sentence = WrapWithChecksum(data);
			return sentence;
		}

		private string BuildGgaSentence(
			DateTime timestamp,
			int latitudeDegrees,
			decimal latitudeMinutes,
			int longitudeDegrees,
			decimal longitudeMinutes,
			char longitudeHemisphere,
			char latitudeHemisphere,
			int satellitesInUse
)
		{
			var data = $"GPGGA,{timestamp:HHmmss},{latitudeDegrees:D2}{latitudeMinutes:00.000000},{latitudeHemisphere},{longitudeDegrees:D3}{longitudeMinutes:00.000000},{longitudeHemisphere},1,{satellitesInUse:00},1.5,4,M,-1.0,M,,";
			var sentence = WrapWithChecksum(data);
			return sentence;
		}

		private void SendNmea0183Broadcast(string sentence)
		{
			var packet = Encoding.ASCII.GetBytes(sentence);
			_udpClient.Send(packet, packet.Length, _ip);
		}

		private string WrapWithChecksum(string dataPackage)
		{
			var checksum = 0;
			foreach (var c in dataPackage)
			{
				checksum ^= Convert.ToByte(c);
			}
			return $"${dataPackage}*{checksum:X2}";
		}

	}
}
