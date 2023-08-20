using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._Tworzenie_Interfejsow
{
    internal interface IDestroyable
    {
        string DestroySound { get; set; }

        void Destroy();
    }
}
