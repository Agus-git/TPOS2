using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace InfectionSimulation
{
    class Person : GameObject
    {
        public bool Infected { get; set; }

        public override void UpdateOn(World world)
        {
            if (Infected)
            {
                IEnumerable<Person> near = world.ObjectsAt(Position).Cast<Person>();
                Color = Color.Red;
                foreach (Person p in near)
                {
                    p.Infected = true;
                }
            }
            else
            {
                Color = Color.Blue;
                /*
                if (near.Any(p => p.Infected))
                {
                    Infected = true;
                }*/
            }

            Forward(world.Random(1, 2));
            Turn(world.Random(-25, 25));
        }
        
    }
}
