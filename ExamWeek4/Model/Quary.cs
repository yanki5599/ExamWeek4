using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExamWeek4.Model
{
    public class Quary
    {
        [XmlElement]
        public string Day {  get; set; }

        [XmlElement]
        public int DayMonth { get; set; }

        [XmlElement]
        public string Month { get; set; }

        [XmlElement]
        public string Year { get; set; }

        [XmlElement]
        public string Result { get; set; }

        public Quary(string day, int dayMonth, string month, string year, string result)
        {
            Day = day;
            DayMonth = dayMonth;
            Month = month;
            Year = year;
            Result = result;
        }

        public Quary() { }
    }
}
