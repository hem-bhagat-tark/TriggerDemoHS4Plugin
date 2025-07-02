namespace HSPI_TriggerDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var hspi = new HSPI();
            hspi.Connect(args);
        }
    }
}
