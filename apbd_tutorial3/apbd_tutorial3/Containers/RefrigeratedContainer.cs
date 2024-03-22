using apbd_tutorial3.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apbd_tutorial3.Containers
{
    class RefrigeratedContainer: Container
    {
        public Dictionary<PossibleProducts, double> productsTypeTemp = new Dictionary<PossibleProducts, double>()
        {
            { PossibleProducts.Bananas, 13.3 },
            {PossibleProducts.Chocolate, 18.0 },
            {PossibleProducts.Fish, 2 },
            {PossibleProducts.Meat , -15 },
            {PossibleProducts.IceCream , -18 },
            {PossibleProducts.FrozenPizza , -30 },
            {PossibleProducts.Cheese , 7.2 },
            {PossibleProducts.Sausages , 5 },
            {PossibleProducts.Butter , 20.5 },
            {PossibleProducts.Eggs , 19 }
        };
        public PossibleProducts productsType { get; set; }
        public double currentTemperature { get; set; }

        public RefrigeratedContainer(PossibleProducts productsType, global::System.Double currentTemperature, double cargo): base(cargo)
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
        public void setProductsType (PossibleProducts e)
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
            base.Unload();
        }
    }
}
