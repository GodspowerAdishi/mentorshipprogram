using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MentorshipProgram.Models;

namespace MentorshipProgram
{
    public class CalculatorRepository
    {
        public List<Calculator> GetCalculators()
        {
            CalculatorDBContext calculatorDBContext = new CalculatorDBContext();
            return calculatorDBContext.Calculators.ToList();
        }
    }
}