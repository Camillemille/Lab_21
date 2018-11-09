using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningaboutModels.Models
{
    public class Product
    {
        public string Name{get; set;}
        public double Cost { get; set; }
        public string Description { get; set; }

        public Product()
        {
            //normally I don't need a constructor for Model stuffs, but I'm 
            //doing some special stuff here, and I don't want an error.
        }
        public Product(string name, double cost, string description)
        {
            Name = name; // setting capital Name to lowercase name. 
            Cost = cost;
            Description = description; 
        }
    }
}