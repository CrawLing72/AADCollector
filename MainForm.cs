using System.IO.Ports;
using NAudio.Wave;

namespace AADCollector
{
    public partial class MainForm : Form
    {
        /* 
         WARNING : All the buffer sizes are set to 20ms, which means 50Hz sampling rate.
         */

        int time_index = 0; // 0:5sec, 1:10sec, 2:20sec
        int attribute_index = 0; // 0:Forward-Back, 1:Left-Right, 2:FL-BR, 3:FR-BL, 4:Circling, 5:Chaos

        SerialPort serial = new SerialPort(); // Serial Port Variable
        bool isSerialOpen = false; // Serial Port Open Check

        readonly double[] AudioValues; // Audio Values : 44100, 16bit, 1channel
        NAudio.Wave.WaveInEvent? Wave;
        System.Windows.Forms.Timer uiTimer;

        public MainForm()
        {
            // Init UI Properties
            InitializeComponent();
            this.Text = "Audio-Acceleration Data Collector";
            attributeCombo.DataSource = new string[] { "Forward-Back", "Left-Right", "FL-BR", "FR-BL", "Circling", "Chaos" };
            uiTimer = new System.Windows.Forms.Timer();
            uiTimer.Interval = 50;
            uiTimer.Tick += new EventHandler((sender, e) =>
            {
                AudioGraph.Refresh();
            });

            // Init Serial Properties
            baudCombo.DataSource = new string[] { "921600", "9600", "14400", "19200", "38400", "57600", "115200", "230400", "460800" };

            // Init Audio Properties
            AudioValues = new double[44100 * 20 / 1000];
            AudioGraph.Plot.Add.Signal(AudioValues, 44100 / 1000);
            AudioGraph.Plot.Title("Audio Data");
            AudioGraph.Refresh();
        }

        // Under : Main Functions

        public void serialReceive(object sender, SerialDataReceivedEventArgs e)
        {

        }

        public void SerialOpen(string PortName, string Baud) // ONLY FOR Databit 8, stopbit 1, parity none
        {
            try
            {
                serial.PortName = serialCombo.Text;
                serial.BaudRate = int.Parse(Baud);
                serial.DataBits = 8;
                serial.StopBits = StopBits.One;
                serial.Parity = Parity.None;
                serial.DataReceived += new SerialDataReceivedEventHandler(serialReceive);
                serial.Open();
                isSerialOpen = true;
            }
            catch
            {
                MessageBox.Show("Serial Port Open Error");
                return;
            }
        }

        public void SerialClose()
        {
            try
            {
                serial.Close();
            }
            catch
            {
                MessageBox.Show("Serial Port Close Error");
                return;
            }
        }

        public void SerialWrite(string data)
        {
            try
            {
                serial.Write(data);
            }
            catch
            {
                MessageBox.Show("Serial Write Error");
                return;
            }
        }

        public void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            for (int i = 0; i < e.Buffer.Length / 2; i++)
                AudioValues[i] = BitConverter.ToInt16(e.Buffer, i * 2);

            Console.WriteLine($"First Sample: {AudioValues[0]}, Last Sample: {AudioValues[AudioValues.Length - 1]}");
        }



        // Under : Form Load



        private void Form1_Load(object sender, EventArgs e)
        {
            serialCombo.DataSource = SerialPort.GetPortNames();

            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
            {
                micCombo.Items.Add(NAudio.Wave.WaveIn.GetCapabilities(i).ProductName);
            }
        }



        // Under : UI Interactions



        private void button1_Click(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void PathSelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FilePathText.Text = dialog.SelectedPath;
            }

        }

        private void micCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Wave is not null)
            {
                Wave.StopRecording();
                Wave.Dispose();

                for (int i = 0; i < micCombo.Items.Count; i++) AudioValues[i] = 0;
                AudioGraph.Plot.Axes.AutoScale();

                if (micCombo.SelectedIndex == -1) return;

                Wave = new NAudio.Wave.WaveInEvent()
                {
                    DeviceNumber = micCombo.SelectedIndex,
                    WaveFormat = new NAudio.Wave.WaveFormat(44100, 16, 1),
                    BufferMilliseconds = 20
                };
                Wave.DataAvailable += WaveIn_DataAvailable;
                Wave.StartRecording();

                System.Diagnostics.Debug.WriteLine("디버그 출력 테스트");
            }
        }

        private void fiveSec_CheckedChanged(object sender, EventArgs e)
        {
            if (time_index != 0) // Force user not to choose multiple time options
            {
                time_index = 0;
                fiveSec.Checked = true;
                tenSec.Checked = false;
                twentySec.Checked = false;
            }
        }

        private void tenSec_CheckedChanged(object sender, EventArgs e)
        {
            if (time_index != 1)
            {
                time_index = 1;
                fiveSec.Checked = false;
                tenSec.Checked = true;
                twentySec.Checked = false;
            }
        }

        private void twentySec_CheckedChanged(object sender, EventArgs e)
        {
            if (time_index != 2)
            {
                time_index = 2;
                fiveSec.Checked = false;
                tenSec.Checked = false;
                twentySec.Checked = true;
            }
        }

        private void ACCC_Click(object sender, EventArgs e)
        {
            if (isSerialOpen == false)
            {
                MessageBox.Show("Serial Port is not open");
                return;
            }
            else
            {
                SerialWrite("<cas>");
                MessageBox.Show("Acceleration Calibration Instruction is transmitted");
            }
        }

        private void serialButton_Click(object sender, EventArgs e)
        {
            if (isSerialOpen == false)
            {
                SerialOpen(serialCombo.Text, baudCombo.Text);
                serialButton.Text = "Close";
                isSerialOpen = true;
            }
            else
            {
                SerialClose();
                serialButton.Text = "Open";
                isSerialOpen = false;
            }
        }

        private void IMUCal_Click(object sender, EventArgs e)
        {
            if (isSerialOpen == false)
            {
                MessageBox.Show("Serial Port is not open");
                return;
            }
            else
            {
                SerialWrite("<cal>");
                MessageBox.Show("IMU Calibration Instruction is transmitted");
            }
        }
    }
}
