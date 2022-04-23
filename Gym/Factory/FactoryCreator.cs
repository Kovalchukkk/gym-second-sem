using System.Configuration;
using System.Collections.Specialized;
using System.IO;
using System;

namespace Gym
{
    static public class FactoryCreator
    {
        /*[Obsolete("This method is wrong. Use another method")]*/ public static IFactory GetFactory()
        {
            string FactoryType = ConfigurationManager.AppSettings.Get("FactoryType"); /*ConfigurationSettings.AppSettings.Get("FactoryType");*/
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
