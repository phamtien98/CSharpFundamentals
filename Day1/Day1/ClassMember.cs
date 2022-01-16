using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class ClassMember
    {
        public List<Member> ListFemales(List<Member> members)
        {
            List<Member> female = new();

            foreach (var item in members)
            {
                if (item.Gender == "Female")
                {
                    female.Add(item);
                }
            }

            return female;
        }
        public Member OldestAge(List<Member> members)
        {
            Member obj = new Member();

            int max = 0;
            foreach ( var age in members)
            {
                if(age.Age >= max)
                {
                    max = age.Age;
                }
            }

            foreach(var item in members)
            {
                if(item.Age == max)
                {
                    obj = item;
                    break;
                }
            }
            return obj;
        }
        public List<string> FullNames(List<Member> members)
        {
            List<string> fullNames = new List<string>();

            foreach (var item in members)
            {
                string name = item.FirstName + " " + item.LastName;
                fullNames.Add(name);
            }

            return fullNames;
        }
        public Member MemberHN(List<Member> members)
        {
            Member member = new Member();

            int i = 0;
            while(true)
            {
                    if(members[i].BirthPlace == "HN")
                    {
                        member = members[i];
                        break;
                    }
                i++;
            }

            return member;          
        }
        public Tuple<List<Member>, List<Member>, List<Member>> ThreeList(List<Member> members)
        {
            List<Member> mem2k = new List<Member>();
            List<Member> memgreater2k = new List<Member>();
            List<Member> memless2k = new List<Member>();
            var tuple = new Tuple<List<Member>, List<Member>, List<Member>>(mem2k, memgreater2k, memless2k);

            foreach (var item in members)
            {
                switch (item.DateOfBirth.Year)
                {
                    case 2000:
                        mem2k.Add(item);
                        break;
                    case > 2000:
                        memgreater2k.Add(item);
                        break;
                    case < 2000:
                        memless2k.Add(item);
                        break;
                }
            }

            return tuple;
        }
    }
}
