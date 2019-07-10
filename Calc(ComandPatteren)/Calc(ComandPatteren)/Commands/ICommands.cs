namespace Calc_ComandPatteren_.Commands
{
    public interface ICommands
    {
        double Execute(string str);
        void UnDo();
    }
}
