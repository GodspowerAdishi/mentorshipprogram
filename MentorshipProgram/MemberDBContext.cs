using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MentorshipProgram
{
    public class MemberDBContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}