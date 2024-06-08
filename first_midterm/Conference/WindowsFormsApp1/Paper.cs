using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Paper
    {
        public string Title { get; set; }
        public List<string> Keywords { get; set; }
        public List<string> Authors { get; set; }

        public Paper(string title, List<string> keywords, List<string> authors) {
            Title = title;
            Keywords = keywords;
            Authors = authors;
        }

        public override string ToString()
        {
            if (Authors.Count == 1)
            {
                List<string> parts = Authors[0].Split(' ').ToList();
                string surname = parts[0];
                string name = parts[1];
                return String.Format($"{surname} {name.ToCharArray()[0]}. - {Title}");
            }
            else if (Authors.Count == 2)
            {
                List<string> parts1 = Authors[0].Split(' ').ToList();
                string surname1 = parts1[0];
                string name1 = parts1[1];
                List<string> parts2 = Authors[1].Split(' ').ToList();
                string surname2 = parts1[0];
                string name2 = parts1[1];
                return String.Format($"{surname1} {name1.ToCharArray()[0]}., {surname2} {name2.ToCharArray()[0]}. - {Title}");
            }
            else
            {
                List<string> parts = Authors[0].Split(' ').ToList();
                string surname = parts[0];
                string name = parts[1];
                return String.Format($"{surname} {name.ToCharArray()[0]}., et al. - {Title}");
            }
        }
    }
}
