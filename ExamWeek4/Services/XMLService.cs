using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using ExamWeek4.Model;

namespace ExamWeek4.Services
{
    internal class XMLService
    {
        private readonly string _path;
        private XDocument _activeDoc;
        public XMLService(string path)
        {
            _path = path;
            if (!File.Exists(path))
            {
                var root = new XDocument(new XElement("Quaries"));
                root.Save(_path);
            }
            _activeDoc = XDocument.Load(path);
        }

        

        public void addItem(Quary item)
        {

            XElement t = new XElement("Quary",
                new XElement("Day", item.Day),
                new XElement("DayMonth", item.DayMonth),
                new XElement("Month", item.Month),
                new XElement("Year", item.Year),
                new XElement("Result", item.Result)
                );
            _activeDoc.Root.Add(t);
            _activeDoc.Save(_path);
        }
    }
}
