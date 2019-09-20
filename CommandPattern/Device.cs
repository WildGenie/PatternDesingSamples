namespace WindowsFormsApp7
{
    using System.Drawing;
    using System.Windows.Forms;

    public abstract class Device : Control
    {
        private string deviceName;

        private Label nameLabel;

        private bool state;

        private Label stateLabel;

        private int volume;

        private Label volumeLabel;

        protected Device(string name)
        {
            this.Initialize();
            this.State = false;
            this.Volume = 5;
            this.DeviceName = name;
        }

        public string DeviceName
        {
            get => this.deviceName;

            set
            {
                this.deviceName = value;
                this.nameLabel.Text = $"Device Name is {value}";
            }
        }

        public bool State
        {
            get => this.state;
            set
            {
                this.state = value;
                this.stateLabel.Text = $"Device is {(value ? "On" : "Off")}";
            }
        }

        public int Volume
        {
            get => this.volume;
            set
            {
                this.volume = value;
                this.volumeLabel.Text = $"Volume is {value}";
            }
        }

        public void Initialize()
        {
            this.Size = new Size(200, 200);
            this.BackColor = Color.AliceBlue;
            var layout = new TableLayoutPanel { Dock = DockStyle.Fill };
            this.Controls.Add(layout);
            this.nameLabel = new Label { AutoSize = false, Size = new Size(190, 20), Text = "N/A" };
            this.stateLabel = new Label { AutoSize = false, Size = new Size(100, 20), Text = "N/A" };
            this.volumeLabel = new Label { AutoSize = false, Size = new Size(100, 20), Text = "N/A" };
            layout.Controls.Add(this.nameLabel);
            layout.Controls.Add(this.stateLabel);
            layout.Controls.Add(this.volumeLabel);
        }

        public abstract void Off();

        public abstract void On();

        public abstract void VolDown();

        public abstract void VolUp();
    }
}