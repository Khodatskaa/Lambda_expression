using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_expression
{
    public class Backpack
    {
        public string Color { get; private set; }
        public string Brand { get; private set; }
        public string Fabric { get; private set; }
        public double Weight { get; private set; }
        public double Volume { get; private set; }
        public List<string> Contents { get; private set; }

        public event EventHandler<string> ObjectAdded;

        public Backpack(string color, string brand, string fabric, double weight, double volume)
        {
            Color = color;
            Brand = brand;
            Fabric = fabric;
            Weight = weight;
            Volume = volume;
            Contents = new List<string>();
        }

        public void AddObject(string objName, double objVolume)
        {
            if (Volume - objVolume < 0)
            {
                throw new InvalidOperationException("Volume exceeded. Cannot add object to the backpack.");
            }

            Contents.Add(objName);
            Volume -= objVolume;

            OnObjectAdded(objName);
        }

        public void PopulateProperties(string color, string brand, string fabric, double weight, double volume)
        {
            Color = color;
            Brand = brand;
            Fabric = fabric;
            Weight = weight;
            Volume = volume;
        }

        protected virtual void OnObjectAdded(string objName)
        {
            ObjectAdded?.Invoke(this, objName);
        }

        public void SubscribeToAddObjectEvent()
        {
            ObjectAdded += (sender, objName) =>
            {
                Console.WriteLine($"Object '{objName}' added to the backpack.");
            };
        }
    }
}
