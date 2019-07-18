using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggChickenProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var chicken1 = new Chicken();
            var egg = chicken1.Lay();

            var newbird = new NewBird();
            var eggnewbird = newbird.Lay();

            //2 especies diferentes
            var childChicken = egg.Chocar();
            var childnewbird = eggnewbird.Chocar();

            //Exception
            var childChicken1 = egg.Chocar();

            Console.ReadKey();
        }
    }
}
