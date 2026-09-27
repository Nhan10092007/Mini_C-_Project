using System;
using System.Data;

namespace TodoApp
{
    class Application
    {
        private List<Todo> _todoList;
        
        public Application()
        {
            _todoList = new List<Todo>();
        }
        public void PrintMenu()
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Add Todo");
            Console.WriteLine("2. Show Todos");
            Console.WriteLine("3. Find Todo");
            Console.WriteLine("4. Update Todo");
            Console.WriteLine("5. Delete Todo");
            Console.WriteLine("6. Mark as completed");
            Console.WriteLine("7. Exit");
        }
        public void AddTodo(Todo item)
        {
            foreach(Todo i in _todoList)
            {
                if(i.ID == item.ID)
                {
                    Console.WriteLine($"The ID: {item.ID} is aldready in the list!");
                    return;
                }
            }
            _todoList.Add(item);
            Console.WriteLine("You have added successfully!");
        }
        public void ShowTodo()
        {
            if(_todoList.Count <= 0)
            {
                Console.WriteLine("Empty List!");
                return;
            }
            Console.WriteLine("TODO LIST:");
            foreach(Todo item in _todoList)
            {
                Console.WriteLine($"ID: {item.ID}, Title: {item.Title}, Completed: {item.IsCompleted}");
            }
        }
        public string FindTodo(string id)
        {
            if(_todoList.Count <= 0)
            {
                return "Empty List!";
            }
            foreach(Todo item in _todoList)
            {
                if(item.ID == id)
                {
                    return $"ID: {item.ID}, Title: {item.Title}, Completed: {item.IsCompleted}";
                }
            }
            return $"Can't find Todo with ID: {id}";
        }
        private void PrintUpdateMenu()
        {
            Console.WriteLine("Choose one of these options for update: ");
            Console.WriteLine("1. Update title");
            Console.WriteLine("2. Change completed state");
        }
        public void UpdateTodo(string id)
        {
            if(_todoList.Count() <= 0)
            {
                Console.WriteLine("Empty list!");
                return;
            }
            for(int i = 0; i < _todoList.Count(); ++i)
            {
                if(_todoList[i].ID == id)
                {
                    int choice = 0;
                    while (true)
                    {
                        PrintUpdateMenu();
                        Console.Write("Please enter your choice: ");
                        if(!int.TryParse(Console.ReadLine(), out choice))
                        {
                            Console.WriteLine("Invalid value for choice, please enter again!");
                            continue;
                        }
                        if(choice <= 0 || choice > 2)
                        {
                            Console.WriteLine("Your choice doesn't available in menu, please enter again!");
                            continue;
                        }
                        break;
                    }
                    if(choice == 1)
                    {
                        string newTitle = "";
                        while (true)
                        {
                            Console.Write("Please enter new title: ");
                            newTitle = Console.ReadLine();
                            if(string.IsNullOrEmpty(newTitle) || string.IsNullOrWhiteSpace(newTitle))
                            {
                                Console.WriteLine("Inavlid value for title, please enter again!");
                                continue;
                            }
                            break;
                        }
                        _todoList[i].Title = newTitle;
                        Console.WriteLine($"You have updated the new title for Todo's id: {id} successfully!");
                    }
                    else if(choice == 2)
                    {
                        if (_todoList[i].IsCompleted)
                        {
                            _todoList[i].IsCompleted = false;
                            return;
                        }
                        _todoList[i].IsCompleted = true;
                        Console.WriteLine($"You have updated completed state for Todo's id: {id} successfully!");
                    }
                    return;
                }
            }
            Console.WriteLine($"Can't find Todo with ID: {id}");
        }
        public void DeleteTodo(string id)
        {
            if(_todoList.Count() <= 0)
            {
                Console.WriteLine("Empty list!");
                return;
            }
            for(int i = 0; i < _todoList.Count(); ++i)
            {
                if(_todoList[i].ID == id)
                {
                    Console.WriteLine($"You have successfully deleted Todo: {_todoList[i].ID} - {_todoList[i].Title}");
                    _todoList.RemoveAt(i);
                    return;
                }
            }
            Console.WriteLine($"Can't find Todo with ID: {id}");
        }
        public void MarkAsCompleted(string id)
        {
            if(_todoList.Count() <= 0)
            {
                Console.WriteLine("Empty list!");
                return;
            }
            for(int i = 0; i < _todoList.Count(); ++i)
            {
                if(_todoList[i].ID == id)
                {
                    _todoList[i].IsCompleted = true;
                    Console.WriteLine($"{_todoList[i].ID} - {_todoList[i].Title} is completed!");
                    return;
                }
            }
            Console.WriteLine($"Can't find Todo with ID: {id}");
        }
    }
}