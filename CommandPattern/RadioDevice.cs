namespace WindowsFormsApp7
{
    public class RadioDevice : Device
    {
        public RadioDevice()
            : base("Radio")
        {
        }

        public override void Off()
        {
            this.State = false;
        }

        public override void On()
        {
            this.State = true;
        }

        public override void VolDown()
        {
            if (this.Volume > 0) this.Volume--;
        }

        public override void VolUp()
        {
            if (this.Volume < 12) this.Volume++;
        }
    }
}