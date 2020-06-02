using System;
using System.Xml;

namespace AdapterPattern.Services
{
    public class BookService
    {
        public XmlDocument GetBooksXML() =>
            GenerateBooksXML();

        private XmlDocument GenerateBooksXML(){
            string xml = @"<?xml version='1.0' encoding='UTF-8'?>
            <root>
            <element>
                <Name>book1</Name>
                <author>Jonas 1</author>
            </element>
            <element>
                <Name>book2</Name>
                <author>Jonas 2</author>
            </element>
            </root>";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            return doc;
        }
    }
}