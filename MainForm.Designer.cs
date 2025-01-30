namespace AADCollector
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            recordingBox = new Button();
            label1 = new Label();
            nameBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            IMUCal = new Button();
            ACCC = new Button();
            label4 = new Label();
            serialCombo = new ComboBox();
            label5 = new Label();
            micCombo = new ComboBox();
            ACCGraph = new ScottPlot.WinForms.FormsPlot();
            label6 = new Label();
            AudioGraph = new ScottPlot.WinForms.FormsPlot();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            FilePathText = new TextBox();
            PathSelectButton = new Button();
            attributeCombo = new ComboBox();
            fiveSec = new CheckBox();
            tenSec = new CheckBox();
            twentySec = new CheckBox();
            label10 = new Label();
            label11 = new Label();
            baudCombo = new ComboBox();
            serialButton = new Button();
            SuspendLayout();
            // 
            // recordingBox
            // 
            recordingBox.BackColor = Color.FromArgb(255, 128, 128);
            recordingBox.Font = new Font("나눔스퀘어 Light", 11F);
            recordingBox.Location = new Point(989, 21);
            recordingBox.Name = "recordingBox";
            recordingBox.Size = new Size(221, 74);
            recordingBox.TabIndex = 0;
            recordingBox.Text = "Start Recording";
            recordingBox.UseVisualStyleBackColor = false;
            recordingBox.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("나눔스퀘어 Light", 9F);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(287, 20);
            label1.TabIndex = 1;
            label1.Text = "Audio-Acceleration Data Collerctor";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(83, 59);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(323, 31);
            nameBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 3;
            label2.Text = "이름";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 4;
            label3.Text = "날짜";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("나눔스퀘어 Light", 9F);
            dateTimePicker1.Location = new Point(83, 102);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(323, 28);
            dateTimePicker1.TabIndex = 6;
            // 
            // IMUCal
            // 
            IMUCal.BackColor = SystemColors.ActiveCaption;
            IMUCal.Font = new Font("나눔스퀘어 Light", 11F);
            IMUCal.Location = new Point(762, 21);
            IMUCal.Name = "IMUCal";
            IMUCal.Size = new Size(221, 74);
            IMUCal.TabIndex = 7;
            IMUCal.Text = "IMU Calibration";
            IMUCal.UseVisualStyleBackColor = false;
            IMUCal.Click += IMUCal_Click;
            // 
            // ACCC
            // 
            ACCC.BackColor = SystemColors.ActiveCaption;
            ACCC.Font = new Font("나눔스퀘어 Light", 11F);
            ACCC.Location = new Point(535, 21);
            ACCC.Name = "ACCC";
            ACCC.Size = new Size(221, 74);
            ACCC.TabIndex = 8;
            ACCC.Text = "ACC Calibration";
            ACCC.UseVisualStyleBackColor = false;
            ACCC.Click += ACCC_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(535, 104);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 9;
            label4.Text = "Serial";
            // 
            // serialCombo
            // 
            serialCombo.FormattingEnabled = true;
            serialCombo.Location = new Point(596, 103);
            serialCombo.Name = "serialCombo";
            serialCombo.Size = new Size(150, 33);
            serialCombo.TabIndex = 10;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(762, 103);
            label5.Name = "label5";
            label5.Size = new Size(45, 25);
            label5.TabIndex = 11;
            label5.Text = "MIC";
            // 
            // micCombo
            // 
            micCombo.FormattingEnabled = true;
            micCombo.Location = new Point(813, 101);
            micCombo.Name = "micCombo";
            micCombo.Size = new Size(397, 33);
            micCombo.TabIndex = 12;
            micCombo.SelectedIndexChanged += micCombo_SelectedIndexChanged;
            // 
            // ACCGraph
            // 
            ACCGraph.DisplayScale = 1.5F;
            ACCGraph.Location = new Point(19, 579);
            ACCGraph.Name = "ACCGraph";
            ACCGraph.Size = new Size(1191, 194);
            ACCGraph.TabIndex = 13;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(19, 551);
            label6.Name = "label6";
            label6.Size = new Size(155, 25);
            label6.TabIndex = 14;
            label6.Text = "Acceleration Data";
            // 
            // AudioGraph
            // 
            AudioGraph.DisplayScale = 1.5F;
            AudioGraph.Location = new Point(12, 252);
            AudioGraph.Name = "AudioGraph";
            AudioGraph.Size = new Size(1191, 279);
            AudioGraph.TabIndex = 15;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(12, 224);
            label7.Name = "label7";
            label7.Size = new Size(103, 25);
            label7.TabIndex = 16;
            label7.Text = "Audio Data";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(12, 142);
            label8.Name = "label8";
            label8.Size = new Size(48, 25);
            label8.TabIndex = 17;
            label8.Text = "속성";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(535, 142);
            label9.Name = "label9";
            label9.Size = new Size(47, 25);
            label9.TabIndex = 19;
            label9.Text = "Path";
            // 
            // FilePathText
            // 
            FilePathText.Enabled = false;
            FilePathText.Location = new Point(596, 142);
            FilePathText.Name = "FilePathText";
            FilePathText.Size = new Size(494, 31);
            FilePathText.TabIndex = 20;
            // 
            // PathSelectButton
            // 
            PathSelectButton.Location = new Point(1096, 142);
            PathSelectButton.Name = "PathSelectButton";
            PathSelectButton.Size = new Size(112, 34);
            PathSelectButton.TabIndex = 21;
            PathSelectButton.Text = "Select";
            PathSelectButton.UseVisualStyleBackColor = true;
            PathSelectButton.Click += PathSelectButton_Click;
            // 
            // attributeCombo
            // 
            attributeCombo.FormattingEnabled = true;
            attributeCombo.Location = new Point(83, 139);
            attributeCombo.Name = "attributeCombo";
            attributeCombo.Size = new Size(323, 33);
            attributeCombo.TabIndex = 22;
            // 
            // fiveSec
            // 
            fiveSec.AutoSize = true;
            fiveSec.Checked = true;
            fiveSec.CheckState = CheckState.Checked;
            fiveSec.Location = new Point(83, 178);
            fiveSec.Name = "fiveSec";
            fiveSec.Size = new Size(87, 29);
            fiveSec.TabIndex = 25;
            fiveSec.Text = "5 Sec.";
            fiveSec.UseVisualStyleBackColor = true;
            fiveSec.CheckedChanged += fiveSec_CheckedChanged;
            // 
            // tenSec
            // 
            tenSec.AutoSize = true;
            tenSec.Location = new Point(191, 178);
            tenSec.Name = "tenSec";
            tenSec.Size = new Size(97, 29);
            tenSec.TabIndex = 26;
            tenSec.Text = "10 Sec.";
            tenSec.UseVisualStyleBackColor = true;
            tenSec.CheckedChanged += tenSec_CheckedChanged;
            // 
            // twentySec
            // 
            twentySec.AutoSize = true;
            twentySec.Location = new Point(309, 178);
            twentySec.Name = "twentySec";
            twentySec.Size = new Size(97, 29);
            twentySec.TabIndex = 27;
            twentySec.Text = "20 Sec.";
            twentySec.UseVisualStyleBackColor = true;
            twentySec.CheckedChanged += twentySec_CheckedChanged;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(12, 178);
            label10.Name = "label10";
            label10.Size = new Size(48, 25);
            label10.TabIndex = 28;
            label10.Text = "시간";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(535, 182);
            label11.Name = "label11";
            label11.Size = new Size(84, 25);
            label11.TabIndex = 29;
            label11.Text = "Baudrate";
            // 
            // baudCombo
            // 
            baudCombo.FormattingEnabled = true;
            baudCombo.Location = new Point(625, 179);
            baudCombo.Name = "baudCombo";
            baudCombo.Size = new Size(220, 33);
            baudCombo.TabIndex = 30;
            // 
            // serialButton
            // 
            serialButton.Location = new Point(861, 178);
            serialButton.Name = "serialButton";
            serialButton.Size = new Size(347, 34);
            serialButton.TabIndex = 31;
            serialButton.Text = "Serial Port Open";
            serialButton.UseVisualStyleBackColor = true;
            serialButton.Click += serialButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1234, 798);
            Controls.Add(serialButton);
            Controls.Add(baudCombo);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(twentySec);
            Controls.Add(tenSec);
            Controls.Add(fiveSec);
            Controls.Add(attributeCombo);
            Controls.Add(PathSelectButton);
            Controls.Add(FilePathText);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(AudioGraph);
            Controls.Add(label6);
            Controls.Add(ACCGraph);
            Controls.Add(micCombo);
            Controls.Add(label5);
            Controls.Add(serialCombo);
            Controls.Add(label4);
            Controls.Add(ACCC);
            Controls.Add(IMUCal);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nameBox);
            Controls.Add(label1);
            Controls.Add(recordingBox);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button recordingBox;
        private Label label1;
        private TextBox nameBox;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button IMUCal;
        private Button ACCC;
        private Label label4;
        private ComboBox serialCombo;
        private Label label5;
        private ComboBox micCombo;
        private ScottPlot.WinForms.FormsPlot ACCGraph;
        private Label label6;
        private ScottPlot.WinForms.FormsPlot AudioGraph;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox FilePathText;
        private Button PathSelectButton;
        private ComboBox attributeCombo;
        private CheckBox fiveSec;
        private CheckBox tenSec;
        private CheckBox twentySec;
        private Label label10;
        private Label label11;
        private ComboBox baudCombo;
        private Button serialButton;
    }
}
