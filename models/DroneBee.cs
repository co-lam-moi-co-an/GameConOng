using System;
using System.Collections.Generic;
using System.Text;

namespace GameConOng.models
{
    class DroneBee:Bee
    {
        public DroneBee()
        {
        }
        public DroneBee(String name)
        {
            base.Name = name;
        }
        public override void TakeDamage()
        {
            base.TakeDamage();
            if (Health < 20)
            {
                Status = false;
            }
        }
    }
}
