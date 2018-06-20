using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MembersApp.Models
{
    public class Members
    {
        private static Members Instance = new Members();

        public static Members GetMembers()
        {
            return Instance;
        }

        private List<Member> MemberList = new List<Member> {
             new Member { Id = "client_01", Name = "Bryan", Level = 5 },
             new Member { Id = "client_02", Name = "Emily", Level = 99 },
             new Member { Id = "client_03", Name = "Hannah", Level = 50 },
             new Member { Id = "client_04", Name = "Oliver", Level = 77 },
             new Member { Id = "client_05", Name = "Kate", Level = 3 }
        };

        public IEnumerable<Member> GetMember()
        {
            return MemberList;
        }
    }
}