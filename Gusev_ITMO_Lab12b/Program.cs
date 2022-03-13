using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_Lab12b
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Building
    {
        public string AdressOfBuilding{get; set;}
        public double LengthOfBuilding { get; set; }
        public double WidthOfBuilding { get; set; }
        public double HeightOfBuilding { get; set; }

        public Building()
        { }

        public Building(string adrb, double lenb, double widb, double heib)
        {
            AdressOfBuilding = adrb;
            LengthOfBuilding = lenb;
            WidthOfBuilding = widb;
            HeightOfBuilding = heib;
        }

        public virtual void PrintBuidingData()
        {
            Console.WriteLine("Информация о здании:");
            Console.WriteLine("Адрес здания: {0}", this.AdressOfBuilding);
            Console.WriteLine("Длина здания по адресу \"{1}\": {0}", this.LengthOfBuilding, this.AdressOfBuilding);
            Console.WriteLine("Ширина здания по адресу \"{1}\": {0}", this.LengthOfBuilding, this.AdressOfBuilding);
            Console.WriteLine("Высота здания по адресу \"{1}\": {0}", this.LengthOfBuilding, this.AdressOfBuilding);
        }
    }

    sealed class Multibuilding:Building
    {
        public int NumberOfStoreys { get; set; }

        public Multibuilding(string adrb, double lenb, double widb, double heib, int Nuos)
            : base (adrb, lenb, widb, heib)
        {
            NumberOfStoreys = Nuos;
        }

        public override void PrintBuidingData()
        {
            base.PrintBuidingData();
            Console.WriteLine("Число этажей в здании по адресу \"{1}\": {0}", this.NumberOfStoreys, this.AdressOfBuilding);
        }


    }
}
