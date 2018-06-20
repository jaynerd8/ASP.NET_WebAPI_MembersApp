using MembersApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MembersApp.Controllers
{
    public class MembersController : ApiController
    {
        private Members members = Members.GetMembers();

        public IEnumerable<Member> GetMembers()
        {
            return members.GetMember();
        }

        public Member GetMember(string id)
        {
            return members.FindById(id);
        }

        public bool AddMember(Member m)
        {
            return members.AddMember(m);
        }

        public bool RemoveMember(string id)
        {
            return members.RemoveMember(id);
        }

        public bool ModifyMemeber(Member m)
        {
            return members.ModifyMember(m);
        }
    }
}
