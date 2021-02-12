using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.API;
using System.Threading.Tasks;

namespace MQS
{
    
    public class Config : IRocketPluginConfiguration

    {
        public string MessageColor { get; set; }
        public void LoadDefaults()
        {
            MessageColor = "red"; 
        }
    }
}


