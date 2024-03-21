using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHazardNotifier = apbd_tutorial3.interfaces.IHazardNotifier;

namespace apbd_tutorial3.Containers
{
    internal class LiquidContainer : Container, IHazardNotifier
    {
        public bool hasHazardousCargo { get; set; }
        protected LiquidContainer(double cargoMass) : base(cargoMass)
        {
        }

        public virtual void Load(double cargoMass)
        {
            base.Load(cargoMass);
            if((this.MaximumPayload/100*this.CargoMass>50 && hasHazardousCargo==true)
                || (this.MaximumPayload / 100 * this.CargoMass > 90 && hasHazardousCargo==false))
            {
                NotifyAboutHazard();
            }
        }
        public virtual void Unload()
        {
            base.Unload();
        }

        public void NotifyAboutHazard()
        {
            Console.WriteLine("Dangerous operation. Overload of hazardous cargo. Notification about "+
                this.Number);
        }
    }
}
