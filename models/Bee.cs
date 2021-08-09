using System;
using System.Collections.Generic;
using System.Text;

namespace GameConOng.models
{
    class Bee
    {
        public int Health;
        public String Name;
        public Boolean Status;

        public Bee()
        {
            Health = 100;
            Name = "Bee";
            Status = true;
        }

        public virtual void TakeDamage()
        {
            if(Status == true)
            {
                Random r = new Random();
                int damage = r.Next(80);
                Health -= damage;
            }
        }

        public void Show()
        {
            Console.WriteLine("Name: {0} Status: {1} Health: {2}", Name, Status ? "Alive":"Dead" , this.Health);
        }
    }
}
