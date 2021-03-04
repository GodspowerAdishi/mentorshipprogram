using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MentorshipProgram
{
    public class MemberRepository
    {
        public List<Member> GetMembers()
        {
            MemberDBContext memberDBContext = new MemberDBContext();
            return memberDBContext.Members.ToList();
        }
    }
}