using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Container = Containers.Container;

namespace apbd_tutorial3
{
    class Ship
    {
        public int MaxContainerNumber { get; set; }
        public List<Container> Containers { get; set; }
        public int MaxSpeed { get; set; }
        public double MaxContainersWeight { get; set; } // in tons
        public double CurrentLoad { get; set; }
        public double CurrentContainerNumber { get; set; }

        public void LoadContainer(Container c)
        {
            if (CurrentLoad + c.CargoLoad * 0.001 > MaxContainersWeight)
                throw new OverloadException();
            if (CurrentContainerNumber == MaxContainerNumber)
                Console.WriteLine("No place left.");
            List.Add(c);
            CurrentLoad += c.CargoLoad * 0.001;
            CurrentContainerNumber++;
        }
        public void LoadContainers(List<Container> cs)
        {
            double sumWeight = 0;
            foreach (Container c in cs)
                sumWeight+=c;
            if (CurrentLoad + sumWeight * 0.001 > MaxContainersWeight)
                throw new OverloadException();
            if (CurrentContainerNumber+cs.Count > MaxContainerNumber)
                Console.WriteLine("Not enough place left.");
            Containers.AddRange(cs);
            CurrentLoad += sumWeight * 0.001;
            CurrentContainerNumber++;
        }
        public void RemoveContainer(Container c)
        {
            UnloadContainer(c);
            Containers.Remove(c);
        }
         public void UnloadContainer(Container c)
        {
            int idx = Containers.IndexOf(c);
            if (idx > 0)
            {
                this.CurrentLoad -= idx.CargoLoad;
                idx.Unload();                
            }

        }
        public void ReplaceWithContainers(Container c, List<Container> cs)
        {
            RemoveContainer(c);
            LoadContainers(cs);
        }
        public static TranferContainer(Container c, Ship from, Ship to)
        {
            from.RemoveContainer(c);
            to.LoadContainer(c);
        }

        public virtual string? ToString()
        {
            foreach (Container c in Containers)
                Console.WriteLine(c);
        }
    }
}
