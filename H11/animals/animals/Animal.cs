using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals
{
    public abstract class Animal
    {
        protected string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public abstract string Sound();
       

        public override string ToString()
        {
            return "ik ben " + name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
