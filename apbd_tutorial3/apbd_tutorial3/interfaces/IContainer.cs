using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apbd_tutorial3.interfaces
{
    internal interface IContainer
    {
        void Unload();
        void Load(double cargoMass);
    }
}
