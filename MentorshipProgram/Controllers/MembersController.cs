using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MentorshipProgram.Controllers
{
    public class MembersController : ApiController

    {
        // Saves mentees on the database
        public void Post(Member member)
        {
            using (MemberDBContext entities = new MemberDBContext())
            {
                entities.Members.Add(member);
                entities.SaveChanges();
            }
        }


        // Gets enrolled mentees from the database
        [System.Web.Http.Authorize]
        public IEnumerable<Member> Get()
        {
            using (MemberDBContext entities = new MemberDBContext())
            {
                return entities.Members.ToList();
            }
        }
    }
}