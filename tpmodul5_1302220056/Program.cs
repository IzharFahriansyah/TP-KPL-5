using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302220056
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T userName)
        {
            Console.WriteLine($"Halo user {userName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();


            string namaPanggilan = "Izhar";
            halo.SapaUser(namaPanggilan);
            Console.Read();
        }
    }
}