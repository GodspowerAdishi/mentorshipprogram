using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MentorshipProgram.Models
{
    public class Calculator
    {
        private DateTime _date = DateTime.Now;
        public int Id { get; set; }
        public string username { get; set; }
        public string fullnames { get; set; }
        public decimal number1 { get; set; }
        public string operation {get; set;}
        public decimal number2 { get; set; }
        public decimal total { get; set; }
        public DateTime DateCreated
        {
            get { return _date; }
            set { _date = value; }
        }
    }
}