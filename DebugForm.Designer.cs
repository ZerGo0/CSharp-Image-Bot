using System.Drawing;
using System.Windows.Forms;

namespace DebugPlugin
{
    partial class DebugForm
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
            this.DebugImageBox = new System.Windows.Forms.PictureBox();
            this.BotLog = new System.Windows.Forms.RichTextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.FarmAdvMan = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.ClickAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ClickYCoord = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ClickXCoord = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EmuListInstanButton = new System.Windows.Forms.Button();
            this.StartEmuButton = new System.Windows.Forms.Button();
            this.CheckEmulatorButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DWMCapButton = new System.Windows.Forms.Button();
            this.GDICapButton = new System.Windows.Forms.Button();
            this.ScreenCapButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ClickSendMSGButton = new System.Windows.Forms.Button();
            this.ClickMouseButton = new System.Windows.Forms.Button();
            this.ClickPostMSGButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CSharpISButton = new System.Windows.Forms.Button();
            this.AutoItISButton = new System.Windows.Forms.Button();
            this.ImagePathBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EMGUISButton = new System.Windows.Forms.Button();
            this.ControlNameBox = new System.Windows.Forms.TextBox();
            this.WindowNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.EmulatorInstComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DebugImageBox)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DebugImageBox
            // 
            this.DebugImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DebugImageBox.Location = new System.Drawing.Point(584, 34);
            this.DebugImageBox.Name = "DebugImageBox";
            this.DebugImageBox.Size = new System.Drawing.Size(479, 431);
            this.DebugImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DebugImageBox.TabIndex = 3;
            this.DebugImageBox.TabStop = false;
            // 
            // BotLog
            // 
            this.BotLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BotLog.Location = new System.Drawing.Point(12, 12);
            this.BotLog.Name = "BotLog";
            this.BotLog.Size = new System.Drawing.Size(270, 424);
            this.BotLog.TabIndex = 6;
            this.BotLog.Text = "";
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartButton.Location = new System.Drawing.Point(12, 442);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Start Bot";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PauseButton.Location = new System.Drawing.Point(108, 442);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(75, 23);
            this.PauseButton.TabIndex = 8;
            this.PauseButton.Text = "Pause Bot";
            this.PauseButton.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StopButton.Location = new System.Drawing.Point(207, 442);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 9;
            this.StopButton.Text = "Stop Bot";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.FarmAdvMan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(282, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Tab";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(72, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(60, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Farm Adventure Auto";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FarmAdvMan
            // 
            this.FarmAdvMan.AutoSize = true;
            this.FarmAdvMan.Location = new System.Drawing.Point(6, 6);
            this.FarmAdvMan.Name = "FarmAdvMan";
            this.FarmAdvMan.Size = new System.Drawing.Size(146, 17);
            this.FarmAdvMan.TabIndex = 0;
            this.FarmAdvMan.Text = "Farm Adventure Manually";
            this.FarmAdvMan.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(288, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(290, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.ClickAmount);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.ClickYCoord);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.ClickXCoord);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.DWMCapButton);
            this.tabPage2.Controls.Add(this.GDICapButton);
            this.tabPage2.Controls.Add(this.ScreenCapButton);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.ClickSendMSGButton);
            this.tabPage2.Controls.Add(this.ClickMouseButton);
            this.tabPage2.Controls.Add(this.ClickPostMSGButton);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.CSharpISButton);
            this.tabPage2.Controls.Add(this.AutoItISButton);
            this.tabPage2.Controls.Add(this.ImagePathBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.EMGUISButton);
            this.tabPage2.Controls.Add(this.ControlNameBox);
            this.tabPage2.Controls.Add(this.WindowNameBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(282, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Debug";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(194, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "n:";
            // 
            // ClickAmount
            // 
            this.ClickAmount.Location = new System.Drawing.Point(216, 185);
            this.ClickAmount.Name = "ClickAmount";
            this.ClickAmount.Size = new System.Drawing.Size(60, 20);
            this.ClickAmount.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(92, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Y:";
            // 
            // ClickYCoord
            // 
            this.ClickYCoord.Location = new System.Drawing.Point(115, 185);
            this.ClickYCoord.Name = "ClickYCoord";
            this.ClickYCoord.Size = new System.Drawing.Size(60, 20);
            this.ClickYCoord.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "X:";
            // 
            // ClickXCoord
            // 
            this.ClickXCoord.Location = new System.Drawing.Point(29, 185);
            this.ClickXCoord.Name = "ClickXCoord";
            this.ClickXCoord.Size = new System.Drawing.Size(57, 20);
            this.ClickXCoord.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Emulator Test:";
            // 
            // EmuListInstanButton
            // 
            this.EmuListInstanButton.Location = new System.Drawing.Point(196, 46);
            this.EmuListInstanButton.Name = "EmuListInstanButton";
            this.EmuListInstanButton.Size = new System.Drawing.Size(80, 23);
            this.EmuListInstanButton.TabIndex = 28;
            this.EmuListInstanButton.Text = "List Instances";
            this.EmuListInstanButton.UseVisualStyleBackColor = true;
            this.EmuListInstanButton.Click += new System.EventHandler(this.EmuListInstanButton_Click);
            // 
            // StartEmuButton
            // 
            this.StartEmuButton.Location = new System.Drawing.Point(95, 46);
            this.StartEmuButton.Name = "StartEmuButton";
            this.StartEmuButton.Size = new System.Drawing.Size(95, 23);
            this.StartEmuButton.TabIndex = 27;
            this.StartEmuButton.Text = "Start Emu";
            this.StartEmuButton.UseVisualStyleBackColor = true;
            this.StartEmuButton.Click += new System.EventHandler(this.StartEmuButton_Click);
            // 
            // CheckEmulatorButton
            // 
            this.CheckEmulatorButton.Location = new System.Drawing.Point(9, 46);
            this.CheckEmulatorButton.Name = "CheckEmulatorButton";
            this.CheckEmulatorButton.Size = new System.Drawing.Size(80, 23);
            this.CheckEmulatorButton.TabIndex = 26;
            this.CheckEmulatorButton.Text = "Check Emu";
            this.CheckEmulatorButton.UseVisualStyleBackColor = true;
            this.CheckEmulatorButton.Click += new System.EventHandler(this.CheckEmulatorButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Window Capture Test:";
            // 
            // DWMCapButton
            // 
            this.DWMCapButton.Location = new System.Drawing.Point(196, 101);
            this.DWMCapButton.Name = "DWMCapButton";
            this.DWMCapButton.Size = new System.Drawing.Size(80, 23);
            this.DWMCapButton.TabIndex = 24;
            this.DWMCapButton.Text = "DWM";
            this.DWMCapButton.UseVisualStyleBackColor = true;
            this.DWMCapButton.Click += new System.EventHandler(this.DWMCapButton_Click);
            // 
            // GDICapButton
            // 
            this.GDICapButton.Location = new System.Drawing.Point(95, 101);
            this.GDICapButton.Name = "GDICapButton";
            this.GDICapButton.Size = new System.Drawing.Size(95, 23);
            this.GDICapButton.TabIndex = 23;
            this.GDICapButton.Text = "GDI Cap";
            this.GDICapButton.UseVisualStyleBackColor = true;
            this.GDICapButton.Click += new System.EventHandler(this.GDICapButton_Click);
            // 
            // ScreenCapButton
            // 
            this.ScreenCapButton.Location = new System.Drawing.Point(9, 101);
            this.ScreenCapButton.Name = "ScreenCapButton";
            this.ScreenCapButton.Size = new System.Drawing.Size(80, 23);
            this.ScreenCapButton.TabIndex = 22;
            this.ScreenCapButton.Text = "Screen Cap";
            this.ScreenCapButton.UseVisualStyleBackColor = true;
            this.ScreenCapButton.Click += new System.EventHandler(this.ScreenCapButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Click Test:";
            // 
            // ClickSendMSGButton
            // 
            this.ClickSendMSGButton.Location = new System.Drawing.Point(196, 211);
            this.ClickSendMSGButton.Name = "ClickSendMSGButton";
            this.ClickSendMSGButton.Size = new System.Drawing.Size(80, 23);
            this.ClickSendMSGButton.TabIndex = 20;
            this.ClickSendMSGButton.Text = "SendMSG";
            this.ClickSendMSGButton.UseVisualStyleBackColor = true;
            this.ClickSendMSGButton.Click += new System.EventHandler(this.ClickSendMSGButton_Click);
            // 
            // ClickMouseButton
            // 
            this.ClickMouseButton.Location = new System.Drawing.Point(95, 211);
            this.ClickMouseButton.Name = "ClickMouseButton";
            this.ClickMouseButton.Size = new System.Drawing.Size(95, 23);
            this.ClickMouseButton.TabIndex = 19;
            this.ClickMouseButton.Text = "Mouse";
            this.ClickMouseButton.UseVisualStyleBackColor = true;
            this.ClickMouseButton.Click += new System.EventHandler(this.ClickMouseButton_Click);
            // 
            // ClickPostMSGButton
            // 
            this.ClickPostMSGButton.Location = new System.Drawing.Point(9, 211);
            this.ClickPostMSGButton.Name = "ClickPostMSGButton";
            this.ClickPostMSGButton.Size = new System.Drawing.Size(80, 23);
            this.ClickPostMSGButton.TabIndex = 18;
            this.ClickPostMSGButton.Text = "PostMSG";
            this.ClickPostMSGButton.UseVisualStyleBackColor = true;
            this.ClickPostMSGButton.Click += new System.EventHandler(this.ClickPostMSGButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "ImageSearch Test:";
            // 
            // CSharpISButton
            // 
            this.CSharpISButton.Location = new System.Drawing.Point(196, 143);
            this.CSharpISButton.Name = "CSharpISButton";
            this.CSharpISButton.Size = new System.Drawing.Size(80, 23);
            this.CSharpISButton.TabIndex = 16;
            this.CSharpISButton.Text = "C# IS";
            this.CSharpISButton.UseVisualStyleBackColor = true;
            this.CSharpISButton.Click += new System.EventHandler(this.CSharpISButton_Click);
            // 
            // AutoItISButton
            // 
            this.AutoItISButton.Location = new System.Drawing.Point(95, 143);
            this.AutoItISButton.Name = "AutoItISButton";
            this.AutoItISButton.Size = new System.Drawing.Size(95, 23);
            this.AutoItISButton.TabIndex = 14;
            this.AutoItISButton.Text = "AutoIt IS";
            this.AutoItISButton.UseVisualStyleBackColor = true;
            this.AutoItISButton.Click += new System.EventHandler(this.AutoItISButton_Click);
            // 
            // ImagePathBox
            // 
            this.ImagePathBox.Location = new System.Drawing.Point(89, 62);
            this.ImagePathBox.Name = "ImagePathBox";
            this.ImagePathBox.Size = new System.Drawing.Size(187, 20);
            this.ImagePathBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Image Path:";
            // 
            // EMGUISButton
            // 
            this.EMGUISButton.Location = new System.Drawing.Point(9, 143);
            this.EMGUISButton.Name = "EMGUISButton";
            this.EMGUISButton.Size = new System.Drawing.Size(80, 23);
            this.EMGUISButton.TabIndex = 11;
            this.EMGUISButton.Text = "EMGU IS";
            this.EMGUISButton.UseVisualStyleBackColor = true;
            this.EMGUISButton.Click += new System.EventHandler(this.EMGUISButton_Click);
            // 
            // ControlNameBox
            // 
            this.ControlNameBox.Location = new System.Drawing.Point(89, 36);
            this.ControlNameBox.Name = "ControlNameBox";
            this.ControlNameBox.Size = new System.Drawing.Size(187, 20);
            this.ControlNameBox.TabIndex = 3;
            // 
            // WindowNameBox
            // 
            this.WindowNameBox.Location = new System.Drawing.Point(89, 10);
            this.WindowNameBox.Name = "WindowNameBox";
            this.WindowNameBox.Size = new System.Drawing.Size(187, 20);
            this.WindowNameBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Control Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Window Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Debug ImageSearch:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.EmulatorInstComboBox);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.CheckEmulatorButton);
            this.tabPage3.Controls.Add(this.StartEmuButton);
            this.tabPage3.Controls.Add(this.EmuListInstanButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(282, 430);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Emu Debug";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // EmulatorInstComboBox
            // 
            this.EmulatorInstComboBox.FormattingEnabled = true;
            this.EmulatorInstComboBox.Location = new System.Drawing.Point(9, 6);
            this.EmulatorInstComboBox.Name = "EmulatorInstComboBox";
            this.EmulatorInstComboBox.Size = new System.Drawing.Size(83, 21);
            this.EmulatorInstComboBox.TabIndex = 30;
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.BotLog);
            this.Controls.Add(this.DebugImageBox);
            this.Name = "DebugForm";
            this.Text = "ZerGo0\'s Private Test Bot";
            this.Load += new System.EventHandler(this.MainBotForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DebugImageBox)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox DebugImageBox;
        private System.Windows.Forms.RichTextBox BotLog;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox FarmAdvMan;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ClickSendMSGButton;
        private System.Windows.Forms.Button ClickMouseButton;
        private System.Windows.Forms.Button ClickPostMSGButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CSharpISButton;
        private System.Windows.Forms.Button AutoItISButton;
        private System.Windows.Forms.TextBox ImagePathBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EMGUISButton;
        private System.Windows.Forms.TextBox ControlNameBox;
        private System.Windows.Forms.TextBox WindowNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DWMCapButton;
        private System.Windows.Forms.Button GDICapButton;
        private System.Windows.Forms.Button ScreenCapButton;
        private Label label8;
        private Button EmuListInstanButton;
        private Button StartEmuButton;
        private Button CheckEmulatorButton;
        private Label label11;
        private TextBox ClickAmount;
        private Label label10;
        private TextBox ClickYCoord;
        private Label label9;
        private TextBox ClickXCoord;
        private TabPage tabPage3;
        private ComboBox EmulatorInstComboBox;
    }
}