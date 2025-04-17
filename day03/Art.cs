using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day03
{
    internal class Art
    {
        public string? Logo {  get; set; }
        public string? Vs { get; set; }

        public Art()
        {
            Logo = @"
                    __  ___       __             
                   / / / (_)___ _/ /_  ___  _____
                  / /_/ / / __ `/ __ \/ _ \/ ___/
                 / __  / / /_/ / / / /  __/ /    
                /_/ ///_/\__, /_/ /_/\___/_/     
                   / /  /____/_      _____  ___
                  / /   / __ \ | /| / / _ \/ ___/
                 / /___/ /_/ / |/ |/ /  __/ /    
                /_____/\____/|__/|__/\___/_/     
                ";
            Vs = @"
                 _    __    
                | |  / /____
                | | / / ___/
                | |/ (__  ) 
                |___/____(_)
                ";
        }
        public void DisplayLogo()
        {
            Console.WriteLine(Logo);
        }
        public void DisplayVs()
        {
            Console.WriteLine(Vs);
        }
    }
}
