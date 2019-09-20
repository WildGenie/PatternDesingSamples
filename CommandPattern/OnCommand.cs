namespace WindowsFormsApp7
{
    public class OnCommand : ICommand
    {
        public void Execute(Device device)
        {
            device.On();
        }

        public override string ToString()
        {
            return "Power On";
        }

        public void Undo(Device device)
        {
            device.Off();
        }
    }
}