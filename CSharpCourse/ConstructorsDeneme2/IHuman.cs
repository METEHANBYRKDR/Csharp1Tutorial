using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsDeneme2
{
    public interface IHuman
    {
        void Work();
    }
    class Bayrakdar : IHuman
    {
        public void Work()
        {
            Console.WriteLine("Work +");
        }
    }
    class Metehan : IHuman
    {
        public void Work()
        {
            Console.WriteLine("Work -");
        }
    }
    public class Son
    {
        private IHuman _human;

        public Son(IHuman human)
        {
            _human = human;

        }
        public void Work()
        {
            _human.Work();
            Console.WriteLine("WORK +-");
        }
    }
}
