using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MentorshipProgram.Models;
using Microsoft.AspNet.Identity;
using System.Security.Principal;

namespace MentorshipProgram.Controllers
{
    public class CalculatorController : Controller
    {
        // Calculator 
        [Authorize]
        public ActionResult Calculator()
        {
            return View(new Calculator());
        }

        
        // GET: Calculator log
        [Authorize]
        public ActionResult GetCalculator()
        {
            CalculatorDBContext calculatorDBContext = new CalculatorDBContext();
            List<Calculator> calculator = calculatorDBContext.Calculators.ToList();
            return View(calculator);
        }


        // performs the operation on the calculator
        [HttpPost]
        public ActionResult Calculator(Calculator c, string calculate)
        {
            if (calculate == "add")
            {
                c.total = c.number1 + c.number2;
            }

            else if (calculate == "subtract")
            {
                c.total = c.number1 - c.number2;
            }

            else if (calculate == "multiply")
            {
                c.total = c.number1 * c.number2;
            }

            else
            {
                c.total = c.number1 / c.number2;
            }

            // saves username and fullnames of the user that performs the operation(s) on the calculator
            {
                c.username = User.Identity.Name;
                c.fullnames = User.Identity.GetFirstName() + ' ' + User.Identity.GetLastName();
            }


            // saves the operator in the database
            using (CalculatorDBContext calculator = new CalculatorDBContext())
            {
                if (calculate == "add")
                {
                    c.operation = "+";
                }

                else if (calculate == "subtract")
                {
                    c.operation = "–";
                }

                else if (calculate == "multiply")
                {
                    c.operation = "x";
                }

                else
                {
                    c.operation = "÷";
                }

                // saves the result of every operation in the database
                {
                    using (CalculatorDBContext entities = new CalculatorDBContext())
                    {
                        entities.Calculators.Add(c);
                        entities.SaveChanges();
                    }
                }

                return View(c);

            }

        }
    }
}