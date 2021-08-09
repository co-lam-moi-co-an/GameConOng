using System;
using System.Collections.Generic;
using System.Text;

namespace GameConOng.models
{
    class WorkerBee: Bee
    {
        public WorkerBee()
        {

        }
        public WorkerBee(String name)
        {
            base.Name = name;
        }
        public override void TakeDamage()
        {
            base.TakeDamage();
            if (Health < 50)
            {
                Status = false;
            }
        }
    }
}
