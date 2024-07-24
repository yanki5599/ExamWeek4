
using ExamWeek4.Model;
using ExamWeek4.Services;

namespace ExamWeek4
{
    public partial class Form1 : Form
    {
        XMLService xmlService = new XMLService(".\\quaries.xml");
        private Dictionary<int, string> _daysOfMonth;
        public Form1()
        {
            InitializeComponent();
            InitDictionaries();
            InitComboBoxes();
        }

        private void InitDictionaries()
        {
            
        }

        private void InitComboBoxes()
        {
            comboBox_dayInWeek.DataSource = new List<string>()
            {"ראשון","שני","שלישי","רביעי","חמישי","ששי"};

            comboBox_dayInMonth.DataSource = Enumerable.Range(1, 30).ToList();

            comboBox_Month.DataSource = new List<string>()
            { "תשרי","מרחשון","כסלו","טבת","שבט","אדר",
                "אדר הראשון","אדר השני","ניסן","אייר","סיון",
                "תמוז","אב","אלול"};

            comboBox_year.DataSource = new List<string>()
            {"תשפ\"ד","תשפ\"ה","תשפ\"ג","תשפ\"ד","תשפ\"ה","תשפ\"ו",
                "תשפ\"ז","תשפ\"ח","תשפ\"ט","תש\"צ","תשצ\"א","תשצ\"ב"
                ,"תשצ\"ג","תשצ\"ד"
            };
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            string result = CalculateDate();
            MessageBox.Show(result);

            Quary quary = new Quary(
                comboBox_dayInWeek.Text,
                int.Parse(comboBox_dayInMonth.Text),
                comboBox_Month.Text,
                comboBox_year.Text,
                result
                );
            xmlService.addItem(quary);
        }

        private string CalculateDate()
        {
            string dayInWeek = comboBox_dayInWeek.Text;
            string dayWeekHebrew = dayInWeek != "ראשון" ? $"ב{dayInWeek} בשבת " : $"באחד בשבת ";

            string dayInMonth = comboBox_dayInMonth.Text;
            int dayInMonthInt = int.Parse(dayInMonth);
            string dayInMonthHebrew = calculateDayMonth(dayInMonthInt);

            string month = comboBox_Month.Text;
            string monthHebrew = dayInMonthInt != 30 
                ? $" לירח {month} " 
                : $" לחדש {month} שהוא ראש חודש {NextMonth(month)} ";

            string year = comboBox_year.Text;
            string yearHebrew = calculateYear(year);
            //string yearHebrew = $" שנת {year} לבריאת העולם ";

            return dayWeekHebrew + dayInMonthHebrew + monthHebrew + yearHebrew;
        }

        private object NextMonth(string month)
        {
            string next;
            if (month != "אדר") // if shvat need some more calcu...
            {
                var mi = comboBox_Month.SelectedIndex;
                next = comboBox_Month.Items[(mi+1) % 14].ToString();
            }
            else
            {
                next = "ניסן";
            }
            return next;
        }

        private string calculateYear(string year)
        {
            string res = "חמשת אלפים ושבע מאות";


            if (year.Contains("פ"))
                res += " ושמנים ";
            if (year.Contains("צ"))
                res += " ותשעים ";

            var last = year[year.Length - 1];

            var single = last switch
            {
                'א' => "אחד",
                'ב' => "שתיים",
                'ג' => "שלש",
                'ד' => "ארבע",
                'ה' => "חמש",
                'ו' => "שש",
                'ז' => "שבע",
                'ח' => "שמנה",
                'ט' => "תשע",
                _ => throw new NotImplementedException()
            };
            
            res += "ו" + single.ToString();
            res += " לבריאת העולם ";

            return res;
        }

        private string calculateDayMonth(int dayInMonth) => dayInMonth switch
        {
            1 => "יום אחד",
            2 => "שני ימים",
            3 => "שלשה ימים",
            4 => "ארבעה ימים",
            5 => "חמשה ימים",
            6 => "ששה ימים",
            7 => "שבעה ימים",
            8 => "שמנה ימים",
            9 => "תשעה ימים",
            10 => "עשרה ימים",
            11 => "אחד עשר יום",
            12 => "שנים עשר יום",
            13 => "שלשה עשר יום",
            14 => "ארבעה עשר יום",
            15 => "חמשה עשר יום",
            16 => "ששה עשר יום",
            17 => "שבעה עשר יום",
            18 => "שמנה עשר יום",
            19 => "תשעה עשר יום",
            20 => "עשרים יום",
            21 => "אחד ועשרים יום",
            22 => "שנים ועשרים יום",
            23 => "שלשה ועשרים יום",
            24 => "ארבעה ועשרים יום",
            25 => "חמשה ועשרים יום",
            26 => "ששה ועשרים יום",
            27 => "שבעה ועשרים יום",
            28 => "שמנה ועשרים יום",
            29 => "תשעה ועשרים יום",
            30 => "יום שלשים",
            _ => throw new InvalidDataException(),
        };
        

        
    }
}
