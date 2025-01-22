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
            comboBox1 = new ComboBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
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
            nameBox.Size = new Size(300, 31);
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
            dateTimePicker1.Size = new Size(300, 28);
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(596, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 33);
            comboBox1.TabIndex = 10;
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(813, 101);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(397, 33);
            comboBox2.TabIndex = 12;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1234, 798);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(comboBox1);
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
        private ComboBox comboBox1;
        private Label label5;
        private ComboBox comboBox2;
    }
}
