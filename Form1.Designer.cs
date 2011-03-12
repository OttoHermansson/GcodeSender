namespace GrblOutput {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.BrowseBtn = new System.Windows.Forms.Button();
			this.StartBtn = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.StopBtn = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.PrintBtn = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.rowsInFileLbl = new System.Windows.Forms.Label();
			this.sentRowsLbl = new System.Windows.Forms.Label();
			this.stopPrintBtn = new System.Windows.Forms.Button();
			this.serialResponseList = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ReloadBtn = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// serialPort1
			// 
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// BrowseBtn
			// 
			this.BrowseBtn.Location = new System.Drawing.Point(231, 32);
			this.BrowseBtn.Name = "BrowseBtn";
			this.BrowseBtn.Size = new System.Drawing.Size(75, 24);
			this.BrowseBtn.TabIndex = 0;
			this.BrowseBtn.Text = "Browse";
			this.BrowseBtn.UseVisualStyleBackColor = true;
			this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
			// 
			// StartBtn
			// 
			this.StartBtn.Location = new System.Drawing.Point(102, 61);
			this.StartBtn.Name = "StartBtn";
			this.StartBtn.Size = new System.Drawing.Size(75, 24);
			this.StartBtn.TabIndex = 1;
			this.StartBtn.Text = "Open";
			this.StartBtn.UseVisualStyleBackColor = true;
			this.StartBtn.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 34);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(219, 20);
			this.textBox1.TabIndex = 2;
			// 
			// StopBtn
			// 
			this.StopBtn.Enabled = false;
			this.StopBtn.Location = new System.Drawing.Point(183, 61);
			this.StopBtn.Name = "StopBtn";
			this.StopBtn.Size = new System.Drawing.Size(75, 24);
			this.StopBtn.TabIndex = 5;
			this.StopBtn.Text = "Close";
			this.StopBtn.UseVisualStyleBackColor = true;
			this.StopBtn.Click += new System.EventHandler(this.buttonStop_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(6, 35);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(252, 20);
			this.textBox3.TabIndex = 7;
			this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// PrintBtn
			// 
			this.PrintBtn.Location = new System.Drawing.Point(150, 60);
			this.PrintBtn.Name = "PrintBtn";
			this.PrintBtn.Size = new System.Drawing.Size(75, 24);
			this.PrintBtn.TabIndex = 8;
			this.PrintBtn.Text = "Print";
			this.PrintBtn.UseVisualStyleBackColor = true;
			this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(6, 62);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(62, 21);
			this.comboBox1.TabIndex = 10;
			// 
			// rowsInFileLbl
			// 
			this.rowsInFileLbl.AutoSize = true;
			this.rowsInFileLbl.Location = new System.Drawing.Point(6, 57);
			this.rowsInFileLbl.Name = "rowsInFileLbl";
			this.rowsInFileLbl.Size = new System.Drawing.Size(46, 13);
			this.rowsInFileLbl.TabIndex = 12;
			this.rowsInFileLbl.Text = "Rows: 0";
			// 
			// sentRowsLbl
			// 
			this.sentRowsLbl.AutoSize = true;
			this.sentRowsLbl.Location = new System.Drawing.Point(6, 73);
			this.sentRowsLbl.Name = "sentRowsLbl";
			this.sentRowsLbl.Size = new System.Drawing.Size(66, 13);
			this.sentRowsLbl.TabIndex = 13;
			this.sentRowsLbl.Text = "Sent rows: 0";
			// 
			// stopPrintBtn
			// 
			this.stopPrintBtn.Enabled = false;
			this.stopPrintBtn.Location = new System.Drawing.Point(231, 60);
			this.stopPrintBtn.Name = "stopPrintBtn";
			this.stopPrintBtn.Size = new System.Drawing.Size(75, 24);
			this.stopPrintBtn.TabIndex = 14;
			this.stopPrintBtn.Text = "Stop";
			this.stopPrintBtn.UseVisualStyleBackColor = true;
			this.stopPrintBtn.Click += new System.EventHandler(this.stopPrintBtn_Click);
			// 
			// serialResponseList
			// 
			this.serialResponseList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.serialResponseList.FormattingEnabled = true;
			this.serialResponseList.Location = new System.Drawing.Point(12, 109);
			this.serialResponseList.Name = "serialResponseList";
			this.serialResponseList.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.serialResponseList.Size = new System.Drawing.Size(584, 277);
			this.serialResponseList.TabIndex = 15;
			this.serialResponseList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.serialResponseList_DrawItem);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.StartBtn);
			this.groupBox1.Controls.Add(this.StopBtn);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.ReloadBtn);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(265, 91);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Serial";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Command";
			// 
			// ReloadBtn
			// 
			this.ReloadBtn.Image = global::GrblOutput.Properties.Resources.reload_icon1;
			this.ReloadBtn.Location = new System.Drawing.Point(73, 61);
			this.ReloadBtn.Name = "ReloadBtn";
			this.ReloadBtn.Size = new System.Drawing.Size(24, 24);
			this.ReloadBtn.TabIndex = 11;
			this.ReloadBtn.UseVisualStyleBackColor = true;
			this.ReloadBtn.Click += new System.EventHandler(this.ReloadBtn_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.BrowseBtn);
			this.groupBox2.Controls.Add(this.PrintBtn);
			this.groupBox2.Controls.Add(this.stopPrintBtn);
			this.groupBox2.Controls.Add(this.rowsInFileLbl);
			this.groupBox2.Controls.Add(this.sentRowsLbl);
			this.groupBox2.Location = new System.Drawing.Point(283, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(313, 91);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "File transfer";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "File";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(164, 17);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(44, 17);
			this.radioButton1.TabIndex = 17;
			this.radioButton1.Text = "\\n\\r";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Checked = true;
			this.radioButton2.Location = new System.Drawing.Point(214, 17);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(44, 17);
			this.radioButton2.TabIndex = 18;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "\\r\\n";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(609, 397);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.serialResponseList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "G-code sender";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button BrowseBtn;
		private System.Windows.Forms.Button StartBtn;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button StopBtn;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button PrintBtn;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button ReloadBtn;
		private System.Windows.Forms.Label rowsInFileLbl;
		private System.Windows.Forms.Label sentRowsLbl;
		private System.Windows.Forms.Button stopPrintBtn;
		private System.Windows.Forms.ListBox serialResponseList;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
	}
}

