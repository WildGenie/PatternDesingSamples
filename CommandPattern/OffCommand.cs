namespace WindowsFormsApp7
{
    public class OffCommand : ICommand
    {
        public void Execute(Device device)
        {
            device.Off();
        }

        public override string ToString()
        {
            return "Power Off";
        }

        public void Undo(Device device)
        {
            device.On();
        }
    }
}