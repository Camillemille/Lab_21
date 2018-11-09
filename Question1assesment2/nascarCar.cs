using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1assesment2
{
    public class nascarCar
    {
        private string teamName;
        public string TeamName
        {
            get
            {
                return  teamName;
            }
            set
            {
                teamName = value; 
            }
        }
        public nascarCar()
        {
            teamName = "Hello Kitties";
        }
        public override string ToString()
        {
            return $" Congradulations your team is {teamName}";
        }
























    }

}
