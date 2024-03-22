using apbd_tutorial3.Exceptions;
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
        public double Height { get; set; }
        public double TareWeight { get; set; }
        public double Depth { get; set; }
        public static int Id { get; }
        //public SerialNumber Number { get; set; }

        public double MaximumPayload { get; set; }
        protected Container(double cargoMass)
        {
            CargoMass = cargoMass;
        }

        public void Load(double cargoMass)
        {
            if (cargoMass + this.CargoMass > MaximumPayload)
                throw new OverfillException();
            else
                this.CargoMass += cargoMass;
        }

        public void Unload()
        {
            CargoMass = 0;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
