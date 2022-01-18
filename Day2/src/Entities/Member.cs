using System;

namespace Day2
{
    internal class Member
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String PhoneNum { get; set; }
        public String BirthPlace { get; set; }
        public int Age { get; set; }
        public bool IsGranduated { get; set; }
        
        public Member() {}
        
        public string FullName
        {
            get
            {
                return String.Format("Full Name: {0} {1} ", FirstName, LastName);
            }
        }

        public String ShowInfo
        {
            get
            {
                return String.Format("First Name: {0} | Last Name: {1} ", FirstName, LastName);
            }
        }
    }
}