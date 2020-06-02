using System;
using System.Xml;
using AdapterPattern.Interfaces;
using AdapterPattern.Services;
using Newtonsoft.Json;

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
            XmlDocument booksXML = this._bookService.GetBooksXML();
            return JsonConvert.SerializeXmlNode(booksXML);
        }
    }
} 