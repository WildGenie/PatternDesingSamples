namespace WindowsFormsApp7
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.tvDevice1.VolUp();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.tvDevice1.VolDown();
        }

        private void commandButton6_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.vDownAllCommand.command = new VolDownCommand();
            this.vDownAllCommand.devices.AddRange(new Device[] { this.tvDevice1, this.radioDevice1 });
            this.vUpAllCommand.command = new VolUpCommand();
            this.vUpAllCommand.devices.AddRange(new Device[] { this.tvDevice1, this.radioDevice1 });
        }
    }
}