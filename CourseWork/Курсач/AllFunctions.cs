using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Xml.Serialization;
using System.IO;

namespace TaskManager
{
    public class AllFunctions
    {
        public static List<Task> AddElement(List<Task> Tasks1)
        {
            Add AddForm = new Add();
            AddForm.Show();            
            Tasks1.Add(AddForm.Return_task());
            
            return Tasks1;
        }

        public static DataGridView OutElements(DataGridView dgv, List<Task> tasks)
        {
            dgv.Rows.Clear();           
            if (tasks.Count != 0)
            {
                GiveID(tasks);
                foreach (Task tsk in tasks)
                {                   
                        string[] row = { tsk.ToString(), tsk.Title, tsk.Description, tsk.Performer, tsk.Status, tsk.TegsToString(tsk.Tags), tsk.id.ToString() };
                        dgv.Rows.Add(row);                   
                }
                
            }           
            return dgv;
        }

        public static List<Task> GiveID(List<Task> tasks)
        {
            int count = 0;
            foreach (Task tsk1 in tasks)
            {
                tsk1.id = count;
                count++;
            }
            return tasks;
        }

        public static List<Task> RemoveElements(DataGridView dgv, List<Task> tasks)
        {
            if (dgv.SelectedRows.Count == tasks.Count)
            {
                tasks.Clear();
                OutElements(dgv, tasks);
            }
            else
            {
                foreach (DataGridViewRow rw1 in dgv.SelectedRows)
                {
                    tasks.RemoveAt(int.Parse(rw1.Cells[6].Value.ToString())); dgv.Rows.RemoveAt(rw1.Index);
                }
            }
            return tasks;
        }

        public static List<Task> EditElements(DataGridView dgv, List<Task> tasks)
        {
            Add AddForm = new Add(tasks[int.Parse(dgv.CurrentRow.Cells[6].Value.ToString())]);
            AddForm.Show();
            tasks[int.Parse(dgv.CurrentRow.Cells[6].Value.ToString())] = AddForm.Return_task();
            return tasks;
        }

        public static DataGridView ReturnVisible(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Visible = true;
            }
            return dgv;
        }

        public static DataGridView SearchForData(DataGridView dgv, List<Task> tasks, string data)
        {
            foreach (Task tsk2 in tasks)
            {
                if (tsk2.ToString() != data) { dgv.Rows[tasks.IndexOf(tsk2)].Visible = false; }
            }
            return dgv;
        }

        public static DataGridView SearchForTitle(DataGridView dgv, List<Task> tasks, string Title)
        {
            foreach (Task tsk2 in tasks)
            {
                if (tsk2.Title != Title) { dgv.Rows[tasks.IndexOf(tsk2)].Visible = false; }
            }
            return dgv;
        }

        public static DataGridView SearchForPerformer(DataGridView dgv, List<Task> tasks, string Performer)
        {
            foreach (Task tsk2 in tasks)
            {
                if (tsk2.Performer != Performer) { dgv.Rows[tasks.IndexOf(tsk2)].Visible = false; }
            }
            return dgv;
        }

        public static DataGridView SearchForTegs(DataGridView dgv, List<Task> tasks, string StringTegs)
        {
            List<string> StrTegslist = new List<string>();

            string[] split = StringTegs.Split(' ');
            
            foreach (string s in split)
            {
                StrTegslist.Add(s);
            }
             
            bool check = false;
            foreach (string StrTgsList in StrTegslist)
            {
                foreach (Task tsk2 in tasks)
                {
                    foreach (string s in tsk2.Tags)
                    {
                        if (s == StrTgsList) { check = true; }
                    }
                    if (check == false) { dgv.Rows[tasks.IndexOf(tsk2)].Visible = false; }
                    check = false;
                }

            }
            return dgv;
        }

        public static void SaveTasks(List<Task> tasks)
        {         
                using (var writer = new FileStream("XmlSave.xml", FileMode.Create))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Task>), new XmlRootAttribute("XmlSave"));
                    ser.Serialize(writer, tasks);
                    MessageBox.Show("Saved successfully", "Save");
                }            
        }

        public static List<Task> ReadTasks(List<Task> tasks)
        {
            try
            {
                using (var reader = new StreamReader("XmlSave.xml"))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(List<Task>), new XmlRootAttribute("XmlSave"));
                    tasks = (List<Task>)deserializer.Deserialize(reader);
                    
                    MessageBox.Show("Successfully read", "Read");
                }
                
                
                
            }
            catch (Exception)
            {
                MessageBox.Show("File is emty", "Error");
            }
            return tasks;
            
        }
      

    }
}


