using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TaskManager
{
   public  class Task
    {
        public int id;
        public int minutes;
        public int hour;
        public string day;
        public string month;
        public string year;
        public string Title;
        public string Description;
        public string Performer;
        public string Status;
        public List<string> Tags;
        public Task()
        {
            Tags=new List<string>();
        }
        public string TegsToString(List<string> TegsLists)
        {
            string MainString = string.Empty;

            foreach(string s in TegsLists)
            {
                MainString+=s+" ";
            }
            return MainString;
        }

        public override string ToString()
        {
            return String.Format(hour + ":" + minutes + " " + day + "." + month + "." + year);
        }
    }
}
