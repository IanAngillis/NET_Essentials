using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace predator
{
    public abstract class Insect
    {
        //Variables
        private double xCoord;
        private double yCoord;
        private int age;

        //Constructor
        public Insect()
        {
            this.age = 0;
        }

        public Insect(double x, double y)
        {
            this.age = 0;
            XCoord = x;
            YCoord = y;
        }

        //Methods
        public void MoveForward()
        {
            this.yCoord++;
        }

        public void MoveBack()
        {
            this.yCoord--;
        }

        public void MoveLeft()
        {
            this.xCoord--;
        }

        public void MoveRight()
        {
            this.xCoord++;
        }

        //Properties
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        
        public double YCoord
        {
            get { return yCoord; }
            set
            {
                if (value < 0)
                {
                    yCoord = 0;
                }
                else if(value > 15)
                {
                    yCoord = 15;
                }
                else
                {
                    yCoord = value;
                }



            }
        }

        public double XCoord
        {
            get { return xCoord; }
            set
            {
                if(value < 0 || value > 15)
                {
                    xCoord = 0;
                }
                else if(value > 15)
                {
                    xCoord = 15;
                }
                else
                {
                    xCoord = value;
                }

            }
        }

    }
}
