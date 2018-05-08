using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalWar
{
    public abstract class GameObject
    {
        //Static properties
        private static int count;

        //Class properties
        private int id;
        private EnumObject typeOfObject;

        public GameObject(EnumObject typeOfObject)
        {
            id = count;
            count++;
            
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public EnumObject TypeOfObject
        {
            get { return typeOfObject; }
            set { typeOfObject = value; }
        }

    }
}
