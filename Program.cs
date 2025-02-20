using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_practicum
{
    class Program
    {
        static void Main(string[] args)
        {
            var avto1 = new Avto();
            avto1.Model = "";
            avto1.Color = "";
            avto1.Skor = 60;
            var avto2 = new Avto("Volkswagen", "", 50);

            Console.WriteLine(avto1.ToString());
            Console.WriteLine(avto2.ToString());

            Console.Write("введите модель авто: ");
            string userBrand = Console.ReadLine();
            Console.Write("введите цвет авто: ");
            string userColor = Console.ReadLine();
            Console.Write("введите скорость авто: ");
            int userSkor = int.Parse(Console.ReadLine());
            var userAvto = new Avto(userBrand, userColor, userSkor);
            Console.WriteLine(userAvto.ToString());
        }
    }
}
