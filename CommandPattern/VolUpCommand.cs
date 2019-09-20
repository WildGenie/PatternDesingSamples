namespace WindowsFormsApp7
{
    public class VolUpCommand : ICommand
    {
        public void Execute(Device device)
        {
            device.VolUp();
        }

        public override string ToString()
        {
            return "Volume +";
        }

        public void Undo(Device device)
        {
            device.VolDown();
        }
    }
}