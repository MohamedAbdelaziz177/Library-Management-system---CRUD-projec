using EF_core_demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_demo.Data
{
    internal class MemberModelValidations : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.HasKey(e => e.MemberId);
            builder.Property(e => e.MemberName).IsRequired();
            builder.Property(e => e.MemberEmail).IsRequired(false);
            builder.HasData(AddMembers());

        }
     
            private List<Member> AddMembers()
            {
               var lstOfMembers = new List<Member>
               {
                   new Member { MemberId = 1, MemberName = "Alice Johnson", MemberEmail = "alice.johnson@example.com" },
                   new Member { MemberId = 2, MemberName = "Bob Smith", MemberEmail = "bob.smith@example.com" },
                   new Member { MemberId = 3, MemberName = "Charlie Brown", MemberEmail = "charlie.brown@example.com" },
                   new Member { MemberId = 4, MemberName = "Diana Prince", MemberEmail = "diana.prince@example.com" },
                   new Member { MemberId = 5, MemberName = "Ethan Hunt", MemberEmail = "ethan.hunt@example.com" },
                   new Member { MemberId = 6, MemberName = "Fiona Gallagher", MemberEmail = "fiona.gallagher@example.com" },
                   new Member { MemberId = 7, MemberName = "George Clooney", MemberEmail = "george.clooney@example.com" }
               };

                return lstOfMembers;
            }
        

    }
}
