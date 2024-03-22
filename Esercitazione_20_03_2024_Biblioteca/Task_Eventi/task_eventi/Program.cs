using task_eventi.Models;

namespace task_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuUtente menuUtente = MenuUtente.getIstanza();
            menuUtente.AddEvento();
        }
    }
}
