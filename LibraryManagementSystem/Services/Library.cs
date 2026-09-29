using System;
using System.Collections;
using LibraryManagentSystem.Models;

namespace LibraryManagentSystem.Services
{
    class Library
    {
        private List<Book> _books = new();
        private List<Book> _members = new();
        private List<Book> _borrowRecords = new();
        
        public void PrintLibraryMenu()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("       LIBRARY MANAGEMENT SYSTEM        ");
            Console.WriteLine("========================================");

            Console.WriteLine("1. Book Management");
            Console.WriteLine("2. Member Management");
            Console.WriteLine("3. Borrow Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Borrowing History");
            Console.WriteLine("6. View Currently Borrowed Bookst");
            Console.WriteLine("7. Exit");

            Console.WriteLine("========================================");
        }
        public void PrintBookManagementMenu()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("             BOOK MANAGEMENT            ");
            Console.WriteLine("========================================");

            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. Find Book by ID");
            Console.WriteLine("4. Display All Books");
            Console.WriteLine("5. Back to Main Menu");

            Console.WriteLine("========================================");
        }
        public void PrintMemberManagementMenu()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("             MEMBER MANAGEMENT          ");
            Console.WriteLine("========================================");

            Console.WriteLine("1. Add Member");
            Console.WriteLine("2. Remove Member");
            Console.WriteLine("3. Find Member by ID");
            Console.WriteLine("4. Display All Members");
            Console.WriteLine("5. Back to Main Menu");

            Console.WriteLine("========================================");
        }
        
    }
}