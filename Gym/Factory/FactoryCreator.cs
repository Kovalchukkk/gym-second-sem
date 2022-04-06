using System.Configuration;
using System.Collections.Specialized;
using System.IO;

namespace Gym
{
    static public class FactoryCreator
    {
        public static IFactory GetFactory()
        {
            string FactoryType = ConfigurationSettings.AppSettings.Get("FactoryType");
            if (FactoryType == "File")
            {
                return new FileFactory();
            }
            else 
            {
                return new MemoryFactory();
            }
            
        }
    }
}
