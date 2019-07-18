using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggChickenProblem
{
    public class Chicken : IBird
    {
        public Chicken()
        {
        }

        public Egg Lay()
        {
            var egg = new Egg(() => new Chicken());
            return egg;
        }
    }
}
