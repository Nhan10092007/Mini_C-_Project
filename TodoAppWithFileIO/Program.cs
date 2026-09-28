using System;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Application app = new Application();
                Console.WriteLine("TODO APPLICATION");
                int choice = 0;
                while (true)
                {
                    app.PrintMenu();
                    Console.Write("Enter your choice: ");
                    if(!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Invalid value for choice, please enter again!");
                        continue;
                    }
                    if(choice == 7)
                    {
                        Console.WriteLine("EXITED PROGRAM!");
                        break;
                    }
                    switch (choice)
                    {
                        case 1:{
                            string title = "";
                            string id = "";
                            while (true)
                            {
                                Console.Write("Enter Todo's ID: ");
                                id = Console.ReadLine();
                                if(string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
                                {
                                    Console.WriteLine("Invalid format for ID, please enter again");
                                    continue;
                                }
                                break;
                            }
                            while (true)
                            {
                                Console.Write("Enter Todo's title: ");
                                title = Console.ReadLine();
                                if(string.IsNullOrEmpty(title) || string.IsNullOrWhiteSpace(title))
                                {
                                    Console.WriteLine("Invalid format for title, please enter again");
                                    continue;
                                }
                                break;
                            }
                            Todo newItem = new Todo(id, title);
                            app.AddTodo(newItem);
                            app.SaveData();
                            break;}
                        case 2:
                            app.ShowTodo();
                            break;
                        case 3:{
                            string id = "";
                            while (true)
                            {
                                Console.Write("Enter Todo's ID: ");
                                id = Console.ReadLine();
                                if(string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
                                {
                                    Console.WriteLine("Invalid format for ID, please enter again");
                                    continue;
                                }
                                break;
                            }
                            Console.WriteLine(app.FindTodo(id));
                            break;}
                        case 4:
                            {
                                string id = "";
                                while (true)
                                {
                                    Console.Write("Enter Todo's ID: ");
                                    id = Console.ReadLine();
                                    if(string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
                                    {
                                        Console.WriteLine("Invalid format for ID, please enter again");
                                        continue;
                                    }
                                    break;
                                }
                                app.UpdateTodo(id);
                                app.SaveData();
                                break;
                            }
                        case 5:
                            {
                                string id = "";
                                while (true)
                                {
                                    Console.Write("Enter Todo's ID: ");
                                    id = Console.ReadLine();
                                    if(string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
                                    {
                                        Console.WriteLine("Invalid format for ID, please enter again");
                                        continue;
                                    }
                                    break;
                                }
                                app.DeleteTodo(id);
                                app.SaveData();
                                break;
                            }
                        case 6:
                            {
                                string id = "";
                                while (true)
                                {
                                    Console.Write("Enter Todo's ID: ");
                                    id = Console.ReadLine();
                                    if(string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
                                    {
                                        Console.WriteLine("Invalid format for ID, please enter again");
                                        continue;
                                    }
                                    break;
                                }
                                app.MarkAsCompleted(id);
                                app.SaveData();
                                break;
                            }
                        default:
                            Console.WriteLine("Your choice is not in menu, please try again!");
                            continue;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An I/O error occurred: {ex.Message}");
            }
            
        }
    }
}