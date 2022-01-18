using System;
using System.Collections.Generic;
namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> listMembers = new List<Member>()
            {
                new Member()
                {
                    FirstName = "Tien",
                    LastName = "Pham",
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(1998,03,26),
                    PhoneNum = "0963164813",
                    BirthPlace = "TB",
                    Age = DateTime.Now.Year-new DateTime(1998,03,26).Year,
                    IsGranduated = true,
                },
                new Member()
                {
                    FirstName = "Thu",
                    LastName = "Tran",
                    Gender = Gender.Female,
                    DateOfBirth = new DateTime(2000,03,26),
                    PhoneNum = "0963164813",
                    BirthPlace = "TB",
                    Age = DateTime.Now.Year-new DateTime(2000,03,26).Year,
                    IsGranduated = true,
                },
              new Member()
                {
                    FirstName = "Tien",
                    LastName = "Pham",
                    Gender = Gender.Other,
                    DateOfBirth = new DateTime(2002,03,26),
                    PhoneNum = "0963164813",
                    BirthPlace = "TB",
                    Age = DateTime.Now.Year-new DateTime(2002,03,26).Year,
                    IsGranduated = true,
                }
            };

            MembersUntils membersUntils = new MembersUntils();
            List<Member> female = membersUntils.ListFemales(listMembers);
            Console.WriteLine("List female: ");
            female.ForEach(m => { Console.WriteLine(m.ShowInfo); });
            Console.WriteLine("----------------------");

            Member oldestMember = membersUntils.OldestAge(listMembers);
            Console.WriteLine("Oldest person:");
            Console.WriteLine(oldestMember.ShowInfo);
            Console.WriteLine("----------------------");

            List<String> fullNames = membersUntils.FullNames(listMembers);
            Console.WriteLine("List fullname");
            fullNames.ForEach(m => { Console.WriteLine(m); });
            Console.WriteLine("----------------------");

            Member memberAtHN = membersUntils.MemberHN(listMembers);
            Console.WriteLine("Member in HN: \n" + memberAtHN.ShowInfo);
            Console.WriteLine("----------------------");

            var result = membersUntils.ThreeLists(listMembers);
            Console.WriteLine("2k");
            result.Item1.ForEach(m => { Console.WriteLine(m.ShowInfo); });
            Console.WriteLine("Greater than 2k");
            result.Item2.ForEach(m => { Console.WriteLine(m.ShowInfo); });
            Console.WriteLine("Less than 2k");
            result.Item2.ForEach(m => { Console.WriteLine(m.ShowInfo); });
            Console.WriteLine("----------------------");
        }
    }
}
