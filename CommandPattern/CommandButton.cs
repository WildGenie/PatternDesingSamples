namespace WindowsFormsApp7
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class CommandButton : Button
    {
        public ICommand command;

        public List<Device> devices = new List<Device>();

        public CommandButton()
        {
            this.InitializeComponent();
            this.Click += this.OnClick;
        }

        private void OnClick(object sender, EventArgs e)
        {
            foreach (var device in this.devices) this.command?.Execute(device);
        }
    }
}