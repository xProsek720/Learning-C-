using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._Tworzenie_Interfejsow
{
    internal class Car : Vehicle, IDestroyable
    {

        public string Model { get; set; }
        public string Type { get; set; }
        public string DestroySound { get; set; }
        public List<IDestroyable> Destroyables { get; set; }


        public Car() :base() 
        {
            this.Model = "Unknown";
            this.Type = "Unknown";
            this.Destroyables = new List<IDestroyable>();
        }
        public Car(string Brand, float TopSpeed) : base(Brand, TopSpeed)
        {
            this.Model = "Unknown";
            this.Type = "Unknown";
            this.Destroyables = new List<IDestroyable>();
        }

        public Car(string Brand, float TopSpeed, string Model, string Type) : base(Brand, TopSpeed)
        {
            this.Model = Model;
            this.Type = Type;
            this.Destroyables = new List<IDestroyable>();
        }
        public Car(string Brand, float TopSpeed, string Model, string Type, string DestroySound) : base(Brand, TopSpeed)
        {
            this.Model = Model;
            this.Type = Type;
            this.DestroySound = DestroySound;
            this.Destroyables = new List<IDestroyable>();
        }
        public void Destroy()
        {
            Console.WriteLine($"Car: [{this.Id}, {this.Brand}, {this.Model}] has been destroyed.");
            Console.WriteLine($"Playing sound: {this.DestroySound}");
            foreach (IDestroyable chain in this.Destroyables) 
            {
                chain.Destroy();
            }
            
        }


        public override string ToString()
        {
            return base.ToString() + $"\tType: {this.Type}\tModel: {this.Model}";
        }


    }
}
