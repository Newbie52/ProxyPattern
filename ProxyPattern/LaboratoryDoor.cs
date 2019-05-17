using System;

namespace ProxyPattern
{
    public class LaboratoryDoor : IDoor
    {
        public void Open(object _)
        {
            Console.WriteLine("Открытие двери лаборатории");
        }

        public void Close()
        {
            Console.WriteLine("Закрытие двери лаборатории");
        }
    }
}
