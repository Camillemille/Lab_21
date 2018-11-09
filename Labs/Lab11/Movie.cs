using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movie
    {
        private string title;
        private string category;

        public string getTitle
        {
            get
            {
                return title;
            }

            set
            {
                title = value; 
            }


        }


        public string getCategory
        {
            get
            {
                return category;
            }


            set
            {
                category = value; 
            }


        }


        public Movie(string userTitle , string userCategory ) //This is for what the user puts in
        {
            userTitle = getTitle;
            userCategory = getCategory; 

        }









































    }
}
