namespace WindowsFormsApp7
{
    public class VolDownCommand : ICommand
    {
        public void Execute(Device device)
        {
            device.VolDown();
        }

        public override string ToString()
        {
            return "Volume -";
        }

        public void Undo(Device device)
        {
            device.VolUp();
        }
    }
}