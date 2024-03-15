using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apbd_tutorial3.Containers
{
    internal class LiquidContainer : Container
    {
        protected LiquidContainer(double cargoMass) : base(cargoMass)
        {
        }

        public virtual void Load(double cargoMass)
        {
            base.Load(cargoMass);
        }
    }
}
