using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFIJOAPOSFIJO
{
    class menu
    {
        public int menus()
        {
            int option;
            Console.WriteLine("buenas tardes profe :3");
            Console.WriteLine("1) INSERTAR");
            Console.WriteLine("2) MOSTRAR");
            Console.WriteLine("3) CREDITOS");
            Console.WriteLine("");
            Console.WriteLine("escoge option");
            option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
    }
}
