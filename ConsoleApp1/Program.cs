using System.Collections;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList bookshelf = new ArrayList();
            Console.WriteLine("title / author");
            string command;
            while (true)
            {
                command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] token = command.Split(" / ");
                bookshelf.Add(token[0]);
                bookshelf.Add(token[1]);



            }

            command = Console.ReadLine();
            switch (command)
            {
                case "add":
                {
                    string[] token = command.Split(" / ");
                    command = Console.ReadLine();
                    token = command.Split(" / ");
                    bookshelf.Add(token[0]);
                    bookshelf.Add(token[1]);

                    break;
                }
                case "remove":
                {
                    Console.Write("which book you want to remove: ");
                    string book = Console.ReadLine();
                    for (int i = 0; i < bookshelf.Count; i++)
                    {
                        if ((string)bookshelf[i] == book)
                            {
                            bookshelf.RemoveAt(i);
                            bookshelf.RemoveAt(i + 1);
                            break;
                        }
                    }

                    break;
                }
                case "find":
                {
                    Console.Write("What book you are looking for: ");
                    string book = Console.ReadLine();
                    bool check = false;
                    for (int i = 0; i < bookshelf.Count; i++)
                    {
                        if ((string)bookshelf[i] == book)
                        {
                            Console.WriteLine(bookshelf[i] + " / " + bookshelf[i + 1]);
                            return;
                            check = true;
                        }
                    }

                    if (check == false)
                    {
                        Console.WriteLine("Book not found.");
                    }


                    break;
                }
            }
            Console.WriteLine("=============================================");
            for (int i = 0; i < bookshelf.Count; i += 2)
            {
                Console.WriteLine(bookshelf[i] + " / " + bookshelf[i + 1]);
            }
            Console.WriteLine("=============================================");


        }
    }
}

