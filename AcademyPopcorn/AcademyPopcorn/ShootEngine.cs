using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    //Problem Four - Inherit class Engine and create method ShootPlayerRacket()
    public class ShootEngine : Engine
    {
        public ShootEngine(IRenderer renderer, IUserInterface userInterface) : base (renderer, userInterface)
        {
        }

        public ShootEngine(IRenderer renderer, IUserInterface userInterface, int sleep)
            : base(renderer, userInterface, sleep)
        {
        }

        public void ShootPlayerRacket()
        {
        }
    }
}
