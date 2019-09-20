namespace WindowsFormsApp7
{
    public class TvDevice : Device
    {
        public TvDevice()
            : base("Tv")
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
            if (this.Volume < 10) this.Volume++;
        }
    }
}