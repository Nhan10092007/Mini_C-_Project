using System;

namespace TodoApp
{
    class Todo
    {
        private string _id = "";
        private string _title = "";
        private bool _isCompledted = false;

        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Inavlid format for ID!");
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
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Inavlid format for title!");
                }
                _title = value;
            }
        }
        public bool IsCompleted
        {
            get
            {
                return _isCompledted;
            }
            set
            {
                _isCompledted = value;
            }
        }
        public Todo(string id, string title)
        {
            ID = id;
            Title = title;
        }
        
    }
}