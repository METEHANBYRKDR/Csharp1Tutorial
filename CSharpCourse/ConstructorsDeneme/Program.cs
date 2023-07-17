using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsDeneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();
            Console.ReadLine();
        }
    }
    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()

        {
            Console.WriteLine("Logged to File");
        }
    }
    class EmployeeManager
    {
        private ILogger _logger;


        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
            
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }
}

