namespace NMEA_Simulator
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.cboMagDir = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.magneticVariation = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.CourseMadeGood = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.speedOverGround = new System.Windows.Forms.TextBox();
			this.cboLongHemisphere = new System.Windows.Forms.ComboBox();
			this.cboLatHemisphere = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.longMinutes = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.latMinutes = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.longDegrees = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.latDegrees = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.satsInUse = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.satsInUse)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(591, 261);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.cboMagDir);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.magneticVariation);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.CourseMadeGood);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.speedOverGround);
			this.tabPage1.Controls.Add(this.cboLongHemisphere);
			this.tabPage1.Controls.Add(this.cboLatHemisphere);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.longMinutes);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.latMinutes);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.longDegrees);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.latDegrees);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(583, 235);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "GPSRMC (Recommended Minimum GPS)";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// cboMagDir
			// 
			this.cboMagDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMagDir.FormattingEnabled = true;
			this.cboMagDir.Items.AddRange(new object[] {
            "W",
            "E"});
			this.cboMagDir.Location = new System.Drawing.Point(236, 106);
			this.cboMagDir.Name = "cboMagDir";
			this.cboMagDir.Size = new System.Drawing.Size(37, 21);
			this.cboMagDir.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(112, 91);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(144, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Magnetic Variation (Degrees)";
			// 
			// magneticVariation
			// 
			this.magneticVariation.Location = new System.Drawing.Point(115, 107);
			this.magneticVariation.Name = "magneticVariation";
			this.magneticVariation.Size = new System.Drawing.Size(115, 20);
			this.magneticVariation.TabIndex = 15;
			this.magneticVariation.Text = "6.46";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(141, 140);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(130, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Course Made Good (True)";
			// 
			// CourseMadeGood
			// 
			this.CourseMadeGood.Location = new System.Drawing.Point(144, 156);
			this.CourseMadeGood.Name = "CourseMadeGood";
			this.CourseMadeGood.Size = new System.Drawing.Size(129, 20);
			this.CourseMadeGood.TabIndex = 13;
			this.CourseMadeGood.Text = "92";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 140);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(132, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Speed Over Ground (KTS)";
			// 
			// speedOverGround
			// 
			this.speedOverGround.Location = new System.Drawing.Point(9, 156);
			this.speedOverGround.Name = "speedOverGround";
			this.speedOverGround.Size = new System.Drawing.Size(129, 20);
			this.speedOverGround.TabIndex = 11;
			this.speedOverGround.Text = "3.9";
			// 
			// cboLongHemisphere
			// 
			this.cboLongHemisphere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboLongHemisphere.FormattingEnabled = true;
			this.cboLongHemisphere.Items.AddRange(new object[] {
            "W",
            "E"});
			this.cboLongHemisphere.Location = new System.Drawing.Point(236, 61);
			this.cboLongHemisphere.Name = "cboLongHemisphere";
			this.cboLongHemisphere.Size = new System.Drawing.Size(37, 21);
			this.cboLongHemisphere.TabIndex = 10;
			// 
			// cboLatHemisphere
			// 
			this.cboLatHemisphere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboLatHemisphere.FormattingEnabled = true;
			this.cboLatHemisphere.Items.AddRange(new object[] {
            "N",
            "S"});
			this.cboLatHemisphere.Location = new System.Drawing.Point(236, 19);
			this.cboLatHemisphere.Name = "cboLatHemisphere";
			this.cboLatHemisphere.Size = new System.Drawing.Size(37, 21);
			this.cboLatHemisphere.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(112, 46);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Minutes";
			// 
			// longMinutes
			// 
			this.longMinutes.Location = new System.Drawing.Point(115, 62);
			this.longMinutes.Name = "longMinutes";
			this.longMinutes.Size = new System.Drawing.Size(115, 20);
			this.longMinutes.TabIndex = 7;
			this.longMinutes.Text = "02.9845";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(112, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Minutes";
			// 
			// latMinutes
			// 
			this.latMinutes.Location = new System.Drawing.Point(115, 19);
			this.latMinutes.Name = "latMinutes";
			this.latMinutes.Size = new System.Drawing.Size(115, 20);
			this.latMinutes.TabIndex = 5;
			this.latMinutes.Text = "32.7733";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Longitude Degrees";
			// 
			// longDegrees
			// 
			this.longDegrees.Location = new System.Drawing.Point(9, 62);
			this.longDegrees.Name = "longDegrees";
			this.longDegrees.Size = new System.Drawing.Size(94, 20);
			this.longDegrees.TabIndex = 3;
			this.longDegrees.Text = "080";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Latitude Degrees";
			// 
			// latDegrees
			// 
			this.latDegrees.Location = new System.Drawing.Point(9, 19);
			this.latDegrees.Name = "latDegrees";
			this.latDegrees.Size = new System.Drawing.Size(94, 20);
			this.latDegrees.TabIndex = 1;
			this.latDegrees.Text = "26";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.satsInUse);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(583, 235);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "GPS System Fix Data";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// satsInUse
			// 
			this.satsInUse.Location = new System.Drawing.Point(8, 31);
			this.satsInUse.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
			this.satsInUse.Name = "satsInUse";
			this.satsInUse.Size = new System.Drawing.Size(120, 20);
			this.satsInUse.TabIndex = 0;
			this.satsInUse.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(8, 15);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 13);
			this.label8.TabIndex = 1;
			this.label8.Text = "Satellites in use";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 291);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "NMEA Simulator";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.satsInUse)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox latDegrees;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ComboBox cboLongHemisphere;
		private System.Windows.Forms.ComboBox cboLatHemisphere;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox longMinutes;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox latMinutes;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox longDegrees;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox CourseMadeGood;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox speedOverGround;
		private System.Windows.Forms.ComboBox cboMagDir;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox magneticVariation;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown satsInUse;
	}
}

