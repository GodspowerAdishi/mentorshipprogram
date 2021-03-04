using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MentorshipProgram.Controllers
{
    
    public class MembersController : ApiController

    {
        public void Post(Member member)
        {
            using (MemberDBContext entities = new MemberDBContext())
            {
                entities.Members.Add(member);
                entities.SaveChanges();
            }
        }
        [Authorize]
        public IEnumerable<Member> Get()
        {
            using (MemberDBContext entities = new MemberDBContext())
            {
                return entities.Members.ToList();
            }
        }
    }
}