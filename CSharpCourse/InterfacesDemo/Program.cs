using System;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Boss(),
                new Robot(),
                new Manager()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Boss(),
                new Manager()
        };
            foreach (var eat in eats)
            {
                eat.Eat();
            }



            ISalary[] salarys = new ISalary[2]
            {
                new Boss(),
            new Manager()

        };
            foreach (var salary in salarys)
            {
                salary.GetSalary();
            }

        Console.ReadLine();






        }
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();

    }
    class Boss : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Eat1");
        }

            public void GetSalary()
            {
                Console.WriteLine("Salary1");
            }

        public void Work()
        {
            Console.WriteLine("Work");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("work1");
        }
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Eat2");
        }

        public void GetSalary()
        {
                Console.WriteLine("Salary2");
        }

        public void Work()
        {
            Console.WriteLine("work2");
        }
    }
}
}
