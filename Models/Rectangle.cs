using PolymorphsyimProject.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsyimProject.Models
{
    internal class Rectangle:Figure
    {   

        public int Eni { get; set; }
        public int Uzunu { get; set; }

        public Rectangle(string name, int eni, int uzunu) : base(name)
        {
            this.Eni = eni;
            this.Uzunu = uzunu;
        }

        public override void Calculate()
        {
            base.Calculate();
            Console.WriteLine(GetName() + " whole area is : " + (Eni * Uzunu));
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Figure name is : " + GetName());
            Console.WriteLine(GetName() + " width is : " + this.Eni);
            Console.WriteLine(GetName() + " length is : " + this.Uzunu);

        }


    }
}
