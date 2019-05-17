using System;

namespace ProxyPattern
{
    public class LaboratoryDoor : IDoor
    {
        public void Open(object _)
        {
            Console.WriteLine("Дверь открылась");
        }

        public void Close()
        {
            Console.WriteLine("Дверь закрылась");
        }
    }
}
