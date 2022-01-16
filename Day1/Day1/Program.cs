using System;
using System.Collections.Generic;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> listMem = new List<Member>();
            DateTime DateMember1 = new DateTime(2003, 03, 26);
            Member member1 = new Member("Tien","Pham","Female",DateMember1,"0963164813","TB",DateTime.Now.Year-DateMember1.Year,true);
            listMem.Add(member1);
            DateTime DateMember3 = new DateTime(2000, 03, 26);
            Member member3 = new Member("Cuong", "Nguyen", "Male", DateMember3, "0963164813", "HN", DateTime.Now.Year - DateMember3.Year, true);
            listMem.Add(member3);
            DateTime DateMember2 = new DateTime(1998, 03, 26);
            Member member2 = new Member("Thu", "Pham", "Female", DateMember2, "0963164813", "HN", DateTime.Now.Year - DateMember2.Year, true);
            listMem.Add(member2);

            ClassMember pr = new ClassMember();

            List<Member> female = pr.ListFemales(listMem);
            Console.WriteLine("List female: ");
            foreach(var item in female)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.WriteLine("----------------------");

            Member old = pr.OldestAge(listMem);
            Console.WriteLine("Oldest person:");
            Console.WriteLine(old.FirstName);
            Console.WriteLine("----------------------");

            List<String> fullNames = pr.FullNames(listMem);
            Console.WriteLine("List fullname");
            foreach (var item in fullNames)
            {
                Console.WriteLine("Full name :" + item.ToString());
            }
            Console.WriteLine("----------------------");

            Member HNMem = pr.MemberHN(listMem);
            Console.WriteLine("Member in HN:" + HNMem.FirstName);
            Console.WriteLine("----------------------");

            var result = pr.ThreeList(listMem);
            Console.WriteLine("2k:");
            foreach (var mem in result.Item1)
            {
                Console.WriteLine(mem.FirstName);
            }
            Console.WriteLine("greater 2k:");
            foreach (var mem in result.Item2)
            {
                Console.WriteLine(mem.FirstName);
            }
            Console.WriteLine("less 2k:");
            foreach (var mem in result.Item3)
            {
                Console.WriteLine(mem.FirstName);
            }
            Console.WriteLine("----------------------");

        }
    }
}
