using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MadhuMVC.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int salary { get; set; }

        public override string ToString()
        {
            string phani = $"Name:{name} and id : {id} and Address: {address} and Salary: {salary}";
            return phani;
        }
    }
}