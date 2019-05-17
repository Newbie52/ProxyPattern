using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var door = new SecurityDoorProxy(new LaboratoryDoor());

            door.Open("kek");
            door.Open("password");
            door.Close();

            Console.ReadLine();
        }
    }
}
