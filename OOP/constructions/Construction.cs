using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP.constractions
{
    internal class Construction
    {

        public Construction() { }
        public Construction(float height, float width, int Entrances, int HumanCapacity, string BuildMaterialstring)
        {
            
        }
        public Construction()
        {
            
        }

        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances  { get; set; }
        public int HumanCapacity { get; set; }
        public string BuildMaterial { get; set; }

    }
}
//Height typu zmiennoprzecinkowego
//2. Width typu zmiennoprzecinkowego
//3. Entrances typu liczba całkowita
//4. HumanCapacity typu liczba całkowita
//5. BuildMaterial typu tekstowego
//Zdefiniuj publiczny konstruktor, który zainicjalizuje poszczególne właściwości.