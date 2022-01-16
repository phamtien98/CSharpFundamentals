using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Member
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String PhoneNum { get; set; }
        public String BirthPlace { get; set; }
        public int Age { get; set; }
        public bool IsGranduated { get; set; }
        public Member (String firstname , String lastname, String gender , DateTime dob, String phone, String birthplace, int age , bool isgranduated)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Gender = gender;
            this.DateOfBirth = dob;
            this.PhoneNum = phone;
            this.BirthPlace = birthplace;
            this.Age = age;
            this.IsGranduated = isgranduated;
        }
        public Member() { }
    }
}
