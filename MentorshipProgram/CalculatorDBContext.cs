using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MentorshipProgram.Models;

namespace MentorshipProgram
{
    public class CalculatorDBContext : DbContext
    {
        public DbSet<Calculator> Calculators { get; set; }
    }
}