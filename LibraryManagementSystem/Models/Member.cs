using System;
using System.Collections;

namespace LibraryManagentSystem.Models
{
    class Member
    {
        private string _id = "";
        private string _name = "";
        private string _email = "";

        public string Id
        {
            get
            {
                return _id;
            }
            set
                {
                    if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Invalid value for member's id?");
                }
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Invalid value for member's name?");
                }
                _name = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Invalid value for member's email?");
                }
                _email = value;
            }
        }

        public Member(string id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }        
    }
}