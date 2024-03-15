using apbd_tutorial3.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IContainer = apbd_tutorial3.interfaces.IContainer;

namespace apbd_tutorial3.Containers
{
    public class Container : IContainer
    {
        public double CargoMass { get; set; }

        protected Container(double cargoMass)
        {
            CargoMass = cargoMass;
        }

        public void Load(double cargoMass)
        {
            throw new NotImplementedException();
        }

        public void Unload()
        {
            throw new NotImplementedException();
        }
    }
}
