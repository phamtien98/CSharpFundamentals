using System;
using System.Collections.Generic;
using System.Linq;

namespace Day2
{
    class MembersUntils
    {
        public List<Member> ListFemales(List<Member> members)
        {
            return members.Where(m => m.Gender.Equals(Gender.Female)).ToList();
        }

        public Member OldestAge(List<Member> members)
        {
            return members.Where(m => m.Age == members.Max(m => m.Age)).FirstOrDefault();
        }

        public List<string> FullNames(List<Member> members)
        {
            return members.Select(mem => mem.FullName).ToList();
        }

        public Member MemberHN(List<Member> members)
        {
            return members.Where(m => m.BirthPlace == "HN").FirstOrDefault();
        }

        public Tuple<List<Member>, List<Member>, List<Member>> ThreeLists(List<Member> members)
        {
            List<Member> mem2k = members.Where(m=>m.DateOfBirth.Year == 2000).ToList();
            List<Member> memGreater2k = members.Where(m=>m.DateOfBirth.Year > 2000).ToList();
            List<Member> memLess2k = members.Where(m=>m.DateOfBirth.Year < 2000).ToList();
            
            var tuple = new Tuple<List<Member>, List<Member>, List<Member>>(mem2k, memGreater2k, memLess2k);

            return tuple;
        }
    }
}
