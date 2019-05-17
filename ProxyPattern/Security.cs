using System;

namespace ProxyPattern
{
    public class SecurityDoorProxy : IDoor
    {
        private readonly IDoor _door;

        public SecurityDoorProxy(IDoor door)
        {
            _door = door;
        }

        public void Open(object password)
        {
            var doorPassword = (string) password;
            if (Authenticate(doorPassword))
                _door.Open(null);
            else
                Console.WriteLine("Дверь не открывается без ввода верного пароля");
        }

        public void Close() => _door.Close();

        public bool Authenticate(string password) => password == "password";
    }
}
