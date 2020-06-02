using System;
using AdapterPattern.Adapters;
using AdapterPattern.Interfaces;
using AdapterPattern.Services;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GetBooks();
            Console.ReadLine();
        }

        private static void GetBooks(){
            var bookService = new BookService();
            ITarget target = new AdapterBookXML(bookService);

            Console.WriteLine("Json ---");

            Console.WriteLine(target.GetRequesJson());

            Console.WriteLine("Json ---");
        }
    }
}
