using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Add : Form
    {
        public bool IsAdded { get; protected set; }
        public Add()
        {
            InitializeComponent();
            IsAdded = false;
        }
        public Task task1 = new Task();

        public Add(Task task)
        {
            InitializeComponent();
            tbTitle.Text = task.Title;
            tbDescription.Text = task.Description;
            tbPerformer.Text = task.Performer;
            tbHour.Text = task.hour.ToString();
            tbMinutes.Text = task.minutes.ToString();
            tbData.Text=task.ToString();


            rtbTags.Text = task.TegsToString(task.Tags);
            task.Tags.Clear();

            task1 = task;
        }

        private void Add_Load(object sender, EventArgs e)
        {
            foreach (TextBox tx in this.Controls.OfType<TextBox>())
            {
                tx.BackColor = Color.White;
            }
            BackColor = Color.White;
        }

        
        //Buttons
        private  void button1_Click(object sender, EventArgs e)
        {
           
            
            if (tbHour.Text.Length > 0 && tbMinutes.Text.Length > 0)
            {
                task1.hour = int.Parse(tbHour.Text);
                task1.minutes = int.Parse(tbMinutes.Text);
            }
            task1.Title = tbTitle.Text;
            task1.Description = tbDescription.Text;
            task1.Performer = tbPerformer.Text;
            
            task1.day = monthCalendar1.SelectionRange.End.Day.ToString();
            task1.month = monthCalendar1.SelectionRange.End.Month.ToString();
            task1.year = monthCalendar1.SelectionRange.End.Year.ToString();

            string TegsString = rtbTags.Text;
            string[] split = TegsString.Split(new Char[] {'#'});

            task1.Tags.Clear();
            foreach (string s in split)
            {
                task1.Tags.Add(s);
            }
        
            tbData.Text = task1.ToString();

            task1.Status = CheckStatus(task1);

            if (CheckTask(task1))
            {
                IsAdded = true;
                button2.PerformClick();
                this.Close();
                
               
            }
            else MessageBox.Show("Не корректно заполнены", "Error");
                        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Clear();
            }
            rtbTags.Clear();
        }
      
 

       private bool CheckTask(Task tsk)
        {
            bool CheckElement = true;
            foreach(TextBox tb in this.Controls.OfType<TextBox>())
            {   
                if( tb.Text.Length==0) {CheckElement=false;}
            }
            if (rtbTags.Text.Length == 0) { CheckElement = false; }
            if (tbHour.Text.Length > 0 && tbMinutes.Text.Length > 0)
            {
                if (!(int.Parse(tbHour.Text) >= 0 && int.Parse(tbHour.Text) < 24) || !(int.Parse(tbMinutes.Text) >= 0 && int.Parse(tbMinutes.Text) < 60)) { CheckElement = false; }
            }
            else { CheckElement = false; }
            return CheckElement;
        }

       public string CheckStatus(Task tsk)
        { 
           string StatusTask="Lost";
            if (Int32.Parse(tsk.year) > monthCalendar1.TodayDate.Year ||
                 Int32.Parse(tsk.month) > monthCalendar1.TodayDate.Month ||
                 Int32.Parse(tsk.day) > monthCalendar1.TodayDate.Day)
            { StatusTask = "Planned"; }
            
            return StatusTask;
        }

       public Task Retrun_task()
       {
               return task1;                    
       }


       //Event
       private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (e.KeyChar != ' ' && (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
           {
               e.Handled = true;
           }
       }

       private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (e.KeyChar != ' ' && (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
           {
               e.Handled = true;
           }
       }

       private void Add_FormClosing(object sender, FormClosingEventArgs e)
       {
           if (MessageBox.Show("Close panel add a task??", "Close", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == DialogResult.No)
               e.Cancel = true;
                
       }

      
        
    }
}













