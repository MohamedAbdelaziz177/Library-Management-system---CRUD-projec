using EF_core_demo.Data;
using EF_core_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_demo.ControlIntLayer
{
    public class MemberServiceConfig
    {
 
        // Intializing the appDbContext.
        private appDbContext con;
        public MemberServiceConfig(appDbContext con)
        {
            this.con = con;
        }

        // Adding new member to the libarary.
        public bool addNewMember(Member member)
        {
            var checkMemberExist = con.members.Contains(member);

            if(!checkMemberExist)
            {
                con.members.Add(member);

                con.SaveChanges();

                return true;
            }

            return false;
        }

        // Removing existed member from the libarary.
        public bool removeMember(Member member)
        {
            var checkMemberExist = con.members.Contains(member);

            if(checkMemberExist)
            {
                con.members.Remove(member);

                con.SaveChanges();

                return true;
            }

            return false;
        }


        // Displaying All Members
        public List<Member> ShowAllMembers()
        {
            return con.members.ToList();
        }
    }
}
