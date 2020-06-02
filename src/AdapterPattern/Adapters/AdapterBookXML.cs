using System;
using AdapterPattern.Interfaces;
using AdapterPattern.Services;

namespace AdapterPattern.Adapters
{
    public class AdapterBookXML : ITarget
    {
        private readonly BookService _bookService;

        public AdapterBookXML(BookService bookService)
        {
            this._bookService = bookService;
        }

        public string GetRequesJson()
        {
            return this._bookService.GetBooksXML();
        }
    }
} 