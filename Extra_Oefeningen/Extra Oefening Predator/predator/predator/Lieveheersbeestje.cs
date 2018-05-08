using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace predator
{
    class Lieveheersbeestje : Insect, IPredator
    {

        public bool starvejaja = false;
        public bool Starve => this.starvejaja;
        private int roundsWithoutFood = 0;

        //Default constructor
        public Lieveheersbeestje(double x, double y)
            :base(x, y)
        {
        
        }

        public IPredator Breed()
        {
            if (this.Age % 5 == 0)
            {
                return new Lieveheersbeestje(this.XCoord, this.YCoord);
            }

            return null;
        }

        public Luis[] Chase(Luis[] prey)
        {
            Luis[] caught = new Luis[20];
            int index = 0;

            for(int i = 0; i < prey.Length; i++)
            {
                if(Distance(prey[i]) <= 2)
                {
                    caught[index] = prey[i];
                    index++;

                    if(index >= 20)
                    {
                        return caught;
                    }
                }
            }

            return caught;
        }

        public double Distance(IPrey prey)
        {
            return Math.Sqrt(((prey.XPosition - this.XCoord) * (prey.XPosition - this.XCoord)) + ((prey.YPosition - this.YCoord) * (prey.YPosition - this.YCoord)));
        }

        public void Eat(Luis[] food)
        {
            for(int i = 0; i < food.Length; i++)
            {
                if(food[i] != null)
                {
                    roundsWithoutFood = 0;
                    return;
                }
            }

            roundsWithoutFood++;

            if(roundsWithoutFood == 3)
            {
                this.starvejaja = true;
            }
        
        }
    }
}
