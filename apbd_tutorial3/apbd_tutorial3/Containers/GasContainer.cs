using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHazardNotifier = apbd_tutorial3.interfaces.IHazardNotifier;

namespace apbd_tutorial3.Containers
{
    class GasContainer: Container, IHazardNotifier
    {
        public double Pressure { get; set; }
        protected GasContainer(double cargoMass) : base(cargoMass)
        {
        }
        public virtual void Load(double cargoMass)
        {
            base.Load(cargoMass); //OverloadException is already included in the parent's class Container
        }
        public virtual void Unload()
        {
            this.CargoMass = (this.MaximumPayload / 100) * 5;
        }
    }
}
