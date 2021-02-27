using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaAPILibrary;

namespace Tests
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            MegaCraft.API.User user = new MegaCraft.API.User("Jadesen", CheckLicense: true);
            string done = "Последный выход с сервера: " + user.Lastlogin.Days + "д. " + user.Lastlogin.Hours + "ч. " + user.Lastlogin.Minutes + "м. " + user.Lastlogin.Seconds + "с. назад" + "\n";
            Console.WriteLine(done);
            Console.ReadLine();
        }
    }
}
