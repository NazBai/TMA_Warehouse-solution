using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMA
{
    internal class User
    {
        public int accesLevel { get; set; }
        public string name { get; set; }
        public string surmane { get; set; }

        public User(int accesLevel, string name, string surmane)
        {
            this.accesLevel = accesLevel;
            this.name = name;
            this.surmane = surmane; 
        }


    }
}
