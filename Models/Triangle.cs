using PolymorphsyimProject.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsyimProject.Models
{
    internal class Triangle:Figure
    {
        public int Weigth { get; set; }
        public int Heigth { get; set; }

        public Triangle(string name, int weigth, int heigth):base(name)
        {
            this.Weigth = weigth;
            this.Heigth = heigth;
        }

        public override void Calculate()
        {
            base.Calculate();
            Console.WriteLine($"Whole are of {GetName()} is {(Weigth * Heigth)/2}");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Figure name is : " + GetName());
            Console.WriteLine(GetName() + " weigth is : " + this.Weigth);
            Console.WriteLine(GetName() + " heigth is: " + this.Heigth);
        }

    }
}
