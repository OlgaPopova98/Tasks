using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_OOP
{
    class Dog : Animal

    {
        float speed;
        public Dog(float speed, string name) : base(name)
        {
            this.speed = speed;
            Console.WriteLine("Speed: " + speed);

        }
    }

}
