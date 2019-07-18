using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggChickenProblem
{
    public class Egg
    {
        private readonly Func<IBird> _createBird;
        private bool _chocado;

        public Egg(Func<IBird> createBird)
        {
            _createBird = createBird;
        }

        public IBird Chocar()
        {
            if (_chocado)
                throw new InvalidOperationException("Ovo já chocado.");

            _chocado = true;
            return _createBird();
        }
    }

}
