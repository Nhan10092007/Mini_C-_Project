using System;
using System.Diagnostics.Contracts;

namespace LibraryManagentSystem.Models
{
    class BorrowRecord
    {
        private string _id = "";
        private string _bookId = "";
        private string _memberId = "";
        private DateTime _borrowDate;
        private DateTime? _returnDate;

        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Invalid value for borrow record's id!");
                }
                _id = value;
            }
        }
        public string BookId
        {
            get
            {
                return _bookId;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Invalid value for book's id!");
                }
                _bookId = value;
            }
        }
        public string MemberId
        {
            get
            {
                return _memberId;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Invalid value for member's id!");
                }
                _memberId = value;
            }
        }
        public DateTime BorrowDate
        {
            get
            {
                return _borrowDate;
            }
            set
            {
                _borrowDate = value;
            }
        }
        public DateTime? ReturnDate
        {
            get
            {
                return _returnDate;
            }
            set
            {
                _returnDate = value;
            }
        }
        public BorrowRecord(string id, string bookId, string memberId, DateTime borrowDate, DateTime returnDate){
            Id = id;
            BookId = bookId;
            MemberId = memberId;
            BorrowDate = borrowDate;
            ReturnDate = returnDate;
        }
    }
}