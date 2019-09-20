namespace WindowsFormsApp7
{
    public interface ICommand
    {
        void Execute(Device device);

        void Undo(Device device);
    }
}