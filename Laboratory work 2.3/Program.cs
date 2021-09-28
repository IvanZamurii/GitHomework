using System;

namespace Laboratory_work_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Title t = new Title();
            Author a = new Author();
            Content c = new Content();
            Book.Show();
            Console.ReadKey();
        }
    }
    class Book
    {
        static public void Show()
        {
            Title.Show();
            Author.Show();
            Content.Show();
        }
    }
    class Title
    {
        static public string title;
        static Title()
        {
            Console.WriteLine("Назвіть книгу: ");
            title = Convert.ToString(Console.ReadLine());
        }
        static public void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Назва книги: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(title);
        }
    }
    class Author
    {
        static public string author;
        static Author()
        {
            Console.WriteLine("Назвіть автора книги: ");
            author = Convert.ToString(Console.ReadLine());
        }
        static public void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Автор книги: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(author);
        }
    }
    class Content
    {
        static public string content;
        static Content()
        {
            Console.WriteLine("Який зміст цієї книги?");
            content = Convert.ToString(Console.ReadLine());
        }
        static public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Зміст цієї книги: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(content);
        }
    }
}
