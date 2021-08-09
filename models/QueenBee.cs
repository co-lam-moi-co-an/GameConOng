using System;
using System.Collections.Generic;
using System.Text;

namespace GameConOng.models
{
    class QueenBee : Bee
    {
        public QueenBee()
        {

        }

        public QueenBee(String name)
        {
            base.Name =name;
        }


        public override void TakeDamage()
        {
            base.TakeDamage();
            if (Health < 70)
            {
                Status = false;
            }
        }
    }
}
