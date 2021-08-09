using GameConOng.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameConOng
{
    class Game
    {
        List<Bee> Bees;

        public Game()
        {
            Bees = new List<Bee>();

            for (int i = 0; i < 30; i++)
            {
                String name = "Queen Bee " + i;
                Bee bee = new QueenBee(name);
                Bees.Add(bee);
            }

            for (int i = 0; i < 30; i++)
            {
                String name = "Worker Bee " + i;
                Bee bee = new WorkerBee(name);
                Bees.Add(bee);
            }

            for (int i = 0; i < 30; i++)
            {
                String name = "Drone Bee " + i;
                Bee bee = new DroneBee(name);
                Bees.Add(bee);
            }
        }

        public void StartGame()
        {
            do
            {
                Console.WriteLine("============= MENU ============");
                Console.WriteLine("\t1. Attack");
                Console.WriteLine("\t2. Show Status");
                Console.WriteLine("\t0. Exit");
                Console.Write("\tSelect: ");
                int select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        Console.WriteLine("============ Attack ===========");
                        Attack();
                        break;
                    case 2:
                        Console.WriteLine("========= Show Status =========");
                        ShowStatus();
                        break;
                    case 0:
                        Console.WriteLine("============= Exist ===========");
                        return;
                    default:
                        break;
                }
            } while (true);
        }

        public void Attack()
        {
            foreach(Bee bee in Bees)
            {
                bee.TakeDamage();
            }
        }

        public void ShowStatus()
        {
            IEnumerable<QueenBee> QueenBees = Bees.OfType<QueenBee>();
            IEnumerable<WorkerBee> WorkerBees = Bees.OfType<WorkerBee>();
            IEnumerable<DroneBee> DroneBees = Bees.OfType<DroneBee>();

            Console.WriteLine("------- Show Status Queen Bees --------");
            foreach(Bee Bee in QueenBees)
            {
                Bee.Show();
            }

            Console.WriteLine("------- Show Status Worker Bees --------");
            foreach (Bee Bee in WorkerBees)
            {
                Bee.Show();
            }

            Console.WriteLine("------- Show Status Drone Bees --------");
            foreach (Bee Bee in DroneBees)
            {
                Bee.Show();
            }

        }
    }
}
