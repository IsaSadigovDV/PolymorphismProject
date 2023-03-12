using PolymorphsyimProject.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsyimProject.Models
{
    internal class Quad:Figure
    {
        public int Part { get; set; }

        public Quad(string name, int part):base(name)
        {
            this.Part = part;
        }

        public override void Calculate()
        {
            base.Calculate();
            Console.WriteLine($"Whole area of {GetName()} is {(this.Part * this.Part)}");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Figure name is: {GetName()}");
            Console.WriteLine($"A part of {GetName()} is : {Part}");
        }
    }
}
