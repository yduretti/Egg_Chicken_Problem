using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggChickenProblem
{
    public class NewBird : IBird
    {
        public NewBird()
        {
        }

        public Egg Lay()
        {
            var egg = new Egg(() => new NewBird());
            return egg;
        }
    }
}
