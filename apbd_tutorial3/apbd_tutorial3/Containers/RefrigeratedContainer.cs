using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apbd_tutorial3.Containers
{
    class RefrigeratedContainer: Container
    {
        public PossibleProducts productsType { get; }
        public double currentTemperature { get; set; }

        public RefrigeratedContainer(PossibleProducts productsType, global::System.Double currentTemperature)
        {
            this.productsType = productsType;
            if ((double)productsType > currentTemperature)
            {
                throw new TooLowTemperature();
            }
            else {
                        this.currentTemperature = currentTemperature;
                    }
        }
        public setProductsType (PossibleProducts e)
        {
            if ((double)e > currentTemperature)
            {
                throw new TooLowTemperature();
            }
            else
            {
                this.productsType = e;
            }
        }

        public virtual void Load(double cargoMass)
        {
            base.Load(cargoMass); //OverloadException is already included in the parent's class Container
        }
        public virtual void Unload()
        {
            base.Load();
        }
    }
}
