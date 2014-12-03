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
        public Add()
        {
            InitializeComponent();           
        }
        public Task tsk1 = new Task();

        public Add(Task task1)
        {
            InitializeComponent();
            textBox1.Text = task1.Title;
            textBox2.Text = task1.Description;
            textBox3.Text = task1.Performer;
            textBox5.Text = task1.hour.ToString();
            textBox6.Text = task1.minutes.ToString();
            textBox4.Text=task1.ToString();


            richTextBox1.Text = tsk1.TegsToString(task1.Tags);
            
            tsk1.Tags.Clear();
            tsk1 = task1;
        }

        private void Add_Load(object sender, EventArgs e)
        {
            foreach (TextBox tx in this.Controls.OfType<TextBox>())
            {
                tx.BackColor = Color.White;
            }
            BackColor = Color.White;
        }

        
        
        private  void button1_Click(object sender, EventArgs e)
        {
            
            
            if (textBox5.Text.Length > 0 && textBox6.Text.Length > 0)
            {
                tsk1.hour = int.Parse(textBox5.Text);
                tsk1.minutes = int.Parse(textBox6.Text);
            }
            tsk1.Title = textBox1.Text;
            tsk1.Description = textBox2.Text;
            tsk1.Performer = textBox3.Text;
            
            tsk1.day = monthCalendar1.SelectionRange.End.Day.ToString();
            tsk1.month = monthCalendar1.SelectionRange.End.Month.ToString();
            tsk1.year = monthCalendar1.SelectionRange.End.Year.ToString();

            string TegsString = richTextBox1.Text;
            string[] split = TegsString.Split(new Char[] { '\n','#',' ' });

            tsk1.Tags.Clear();
            foreach (string s in split)
            {
                tsk1.Tags.Add(s);
            }
        
            textBox4.Text = tsk1.ToString();

            tsk1.Status = CheckStatus(tsk1);

            if (CheckTask(tsk1))
            {                
                
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
            richTextBox1.Clear();
        }

      
       


       private bool CheckTask(Task tsk)
        {
            bool CheckElement = true;
            foreach(TextBox tb in this.Controls.OfType<TextBox>())
            {   
                if( tb.Text.Length==0) {CheckElement=false;}
            }
            if (richTextBox1.Text.Length == 0) { CheckElement = false; }
            if (textBox5.Text.Length > 0 && textBox6.Text.Length > 0)
            {
                if (!(int.Parse(textBox5.Text) >= 0 && int.Parse(textBox5.Text) < 24) || !(int.Parse(textBox6.Text) >= 0 && int.Parse(textBox6.Text) < 60)) { CheckElement = false; }
            }
            else { CheckElement = false; }
            return CheckElement;
        }

       private string CheckStatus(Task tsk)
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
               return tsk1;                    
       }



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

       
        
    }
}













