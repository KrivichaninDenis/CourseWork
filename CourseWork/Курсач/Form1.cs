﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Xml.Serialization;
using System.IO;



namespace TaskManager
{
    public partial class Taskmanager : Form
    {
        public Taskmanager()
        {
            InitializeComponent();   
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            MakeDataGridView();
            dataGridView1.Font = new Font("Rockwell", 9);
            outToolStripMenuItem.Visible = false;
            removeTaskToolStripMenuItem.Visible = false;
            editToolStripMenuItem.Visible = false;
        }

        public void MakeDataGridView()
        {
            dataGridView1.ColumnCount = 7;

            dataGridView1.Columns[0].Name = "Data";
            dataGridView1.Columns[1].Name = "Title";
            dataGridView1.Columns[2].Name = "Description";
            dataGridView1.Columns[3].Name = "Performer";
            dataGridView1.Columns[4].Name = "Status";
            dataGridView1.Columns[5].Name = "Tags";

            dataGridView1.Columns[6].Name = "Count";
            dataGridView1.Columns[6].Visible = false;



        }


       List<Task> Tasks = new List<Task>();


        private void addTaskToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            outToolStripMenuItem.Visible = true;
            removeTaskToolStripMenuItem.Visible = true;

            AllFunctions.AddElement(Tasks);
        }

        private void outToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AllFunctions.OutElements(dataGridView1, Tasks);
        }


        private void removeTaskToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AllFunctions.RemoveElements(dataGridView1, Tasks);

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AllFunctions.EditElements(dataGridView1, Tasks);

        }



        //SEARCH
        private void button1_Click(object sender, EventArgs e)
        {
            AllFunctions.ReturnVisible(dataGridView1);


            if (tbData.Text.Length != 0)
            {
                string str1 = tbData.Text.ToString();
                AllFunctions.SearchForData(dataGridView1, Tasks, str1);
            }

            if (tbTitle.Text.Length != 0)
            {
                string str2 = tbTitle.Text.ToString();
                AllFunctions.SearchForTitle(dataGridView1, Tasks, str2);
            }

            if (tbPerformer.Text.Length != 0)
            {
                string str3 = tbPerformer.Text.ToString();
                AllFunctions.SearchForPerformer(dataGridView1, Tasks, str3);
            }

            if (tbTags.Text.Length != 0)
            {
                string str4 = tbTags.Text.ToString();

                AllFunctions.SearchForTegs(dataGridView1, Tasks, str4);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in groupBox1.Controls.OfType<TextBox>())
            {
                tb.Clear();
            }
            outToolStripMenuItem.PerformClick();
        }



        // Save and Read 
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllFunctions.SaveTasks(Tasks);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tasks = AllFunctions.ReadTasks(Tasks);

            outToolStripMenuItem.Visible = true;
            outToolStripMenuItem.PerformClick();
            removeTaskToolStripMenuItem.Visible = true;
        }


        //Event
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != ' ' && (e.KeyChar < 48 || e.KeyChar > 58) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editToolStripMenuItem.Visible = true;
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            AllFunctions.OutElements(dataGridView1, Tasks);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Want to close the program?", "Exit", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

       

        


    }
}
