using DemoExample.Models;
using System;

//https://code-maze.com/adapter/

namespace DemoExample
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var xmlConverter = new XmlConverter();
            var adapter = new XmlToJsonAdapter(xmlConverter);
            adapter.ConvertXmlToJson();
        }
    }
}
