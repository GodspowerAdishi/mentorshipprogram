using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Principal;
using System.Security.Claims;
using Microsoft.AspNet.Identity;

namespace MentorshipProgram.Models
{
    public static class IdentityExtensions
    {

        // Extension for the first name
        public static string GetFirstName(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("FirstName");

            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }


        // Extension for the last name
        public static string GetLastName(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("LastName");

            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }
    }
}