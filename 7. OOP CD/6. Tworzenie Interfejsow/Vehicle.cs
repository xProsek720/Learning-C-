using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._Tworzenie_Interfejsow
{
    internal class Vehicle
    {
        private static int currentId;
        public int Id { get; set; }
        public string Brand { get; set; }
        public float TopSpeed { get; set; }

        public Vehicle() 
        {
            this.Id = ReturnNextId();
            this.Brand = "Unknown";
            this.TopSpeed = -1;
        }
        public Vehicle(string Brand, float TopSpeed)
        {
            this.Id = ReturnNextId();
            this.Brand = Brand;
            this.TopSpeed = TopSpeed;
        }

        public override string ToString() 
        {
            return $"Vehicle ID: {this.Id}\tBrand: {this.Brand}\tTop Speed: {this.TopSpeed}";
        }
        public void Start()
        {
            Console.WriteLine($"Vehicle with ID {this.Id} has been turned on.");
        }
        public void Stop()
        {
            Console.WriteLine($"Vehicle with ID {this.Id} has been turned off.");
        }
        public int ReturnNextId() 
        {
            return currentId++;
        }
    }
}
