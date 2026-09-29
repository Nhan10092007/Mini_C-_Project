using System;
using System.Data.Common;

namespace LibraryManagentSystem.Models
{
    class Book
    {
        private string _id = "";
        private string _title = "";
        private string _author = "";
        private bool _isBorrowed;

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
                    throw new Exception("Invalid value for book's id?");
                }
                _id = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Invalid value for book's title?");
                }
                _title = value;
            }
        }

        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Invalid value for book's author?");
                }
                _author = value;
            }
        }

        public bool IsBorrowed
        {
            get;
            set;
        }

        public Book(string id, string title, string author, bool isBorrowed)
        {
            Id = id;
            Title = title;
            Author = author;
            IsBorrowed = isBorrowed;
        }
    }
}