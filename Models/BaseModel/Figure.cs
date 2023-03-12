using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsyimProject.Models.BaseModel
{
    internal abstract class Figure
    {
        public string Name { get; set; }

        public Figure(string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return this.Name;
        }

        public virtual void Calculate()
        {
            Console.WriteLine("Figure is calculating...");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Information about: " + GetName());
        }


    }
}
