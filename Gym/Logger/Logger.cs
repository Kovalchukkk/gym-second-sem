using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gym
{
    public sealed class Logger : ILogger
    {
        public void Exception(string log)
        {
            string path = @"D:\Навчальна практика 2 курс\gym-second-sem\Gym\Errors\Exception.txt";
          
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(DateTime.Now.ToString());
                    sw.WriteLine(log);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

    }
    
}
