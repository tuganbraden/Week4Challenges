using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Dragon harold = new Dragon(10, "Harold", true);
            GelCube squelch = new GelCube(4, "*squelch*", false);
        }
    }


    abstract class Monster
    {
        public int Toughness { get; set; }
        public string Name { get; set; }
        public bool IsIntelligent { get; set; }

        abstract public void Roar();
    }

    class Dragon : Monster
    {
        public Dragon() { }

        public Dragon(int toughness, string name, bool intelligent)
        {
            Toughness = toughness;
            Name = name;
            IsIntelligent = intelligent;
        }

        public override void Roar()
        {
            Console.WriteLine("ROOOOOOOOAR");
        }
    }

    class GelCube : Monster
    {
        public GelCube() { }
        public GelCube(int toughness, string name, bool intelligent)
        {
            Toughness = toughness;
            Name = name;
            IsIntelligent = intelligent;
        }

        public override void Roar()
        {
            Console.WriteLine("*squishing sounds*");
        }
    }
}
