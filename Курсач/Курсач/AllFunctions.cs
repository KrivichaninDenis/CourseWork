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

            Tasks1.Add(AddForm.Retrun_task());

            return Tasks1;
        }

        public static DataGridView OutElements(DataGridView v1, List<Task> ts1)
        {
            v1.Rows.Clear();

            if (ts1.Count != 0)
            {
                GiveID(ts1);
                foreach (Task tsk in ts1)
                {
                    string[] row = { tsk.ToString(), tsk.Title, tsk.Description, tsk.Performer, tsk.Status, tsk.TegsToString(tsk.Tags), tsk.id.ToString() };
                    v1.Rows.Add(row);
                }
            }           
            return v1;
        }

        public static List<Task> GiveID(List<Task> Tasks1)
        {
            int count = 0;
            foreach (Task tsk1 in Tasks1)
            {
                tsk1.id = count;
                count++;
            }
            return Tasks1;
        }

        public static List<Task> RemoveElements(DataGridView v1, List<Task> ts1)
        {
            if (v1.SelectedRows.Count == ts1.Count)
            {
                ts1.Clear();
                OutElements(v1,ts1);
            }
            else
            {
                foreach (DataGridViewRow rw1 in v1.SelectedRows)
                {
                    ts1.RemoveAt(int.Parse(rw1.Cells[6].Value.ToString())); v1.Rows.RemoveAt(rw1.Index);
                }
            }
            return ts1;
        }

        public static List<Task> EditElements(DataGridView v1, List<Task> TaskList1)
        {
            Add AddForm = new Add(TaskList1[int.Parse(v1.CurrentRow.Cells[6].Value.ToString())]);
            AddForm.Show();
            TaskList1[int.Parse(v1.CurrentRow.Cells[6].Value.ToString())] = AddForm.Retrun_task();
            return TaskList1;
        }

        public static DataGridView ReturnVisible(DataGridView v1)
        {
            foreach (DataGridViewRow row in v1.Rows)
            {
                row.Visible = true;
            }
            return v1;
        }

        public static DataGridView SearchForData(DataGridView v1, List<Task> TaskList1, string data)
        {
            foreach (Task tsk2 in TaskList1)
            {
                if (tsk2.ToString() != data) { v1.Rows[TaskList1.IndexOf(tsk2)].Visible = false; }
            }
            return v1;
        }

        public static DataGridView SearchForTitle(DataGridView v1, List<Task> TaskList1, string Title)
        {
            foreach (Task tsk2 in TaskList1)
            {
                if (tsk2.Title != Title) { v1.Rows[TaskList1.IndexOf(tsk2)].Visible = false; }
            }
            return v1;
        }

        public static DataGridView SearchForPerformer(DataGridView v1, List<Task> TaskList1, string Performer)
        {
            foreach (Task tsk2 in TaskList1)
            {
                if (tsk2.Performer != Performer) { v1.Rows[TaskList1.IndexOf(tsk2)].Visible = false; }
            }
            return v1;
        }

        public static DataGridView SearchForTegs(DataGridView v1, List<Task> TaskList1, string StrTegs)
        {
            List<string> StrTegslist = new List<string>();

            string[] split = StrTegs.Split(new Char[] { ' ', '#' });

            foreach (string s in split)
            {
                StrTegslist.Add(s);
            }
            bool check = false;
            foreach (string StrTgsList in StrTegslist)
            {
                foreach (Task tsk2 in TaskList1)
                {
                    foreach (string s in tsk2.Tags)
                    {
                        if (s == StrTgsList) { check = true; }
                    }
                    if (check == false) { v1.Rows[TaskList1.IndexOf(tsk2)].Visible = false; }
                    check = false;
                }

            }
            return v1;
        }

        public static void SaveTasks(List<Task> TasksList)
        {
            using (var writer = new FileStream("XmlSave.xml", FileMode.Create))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Task>), new XmlRootAttribute("XmlSave"));
                ser.Serialize(writer, TasksList);
                MessageBox.Show("Saved successfully", "Save");
            }
        }

        public static List<Task> ReadTasks(List<Task> TasksList)
        {
            try
            {
                using (var reader = new StreamReader("XmlSave.xml"))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(List<Task>), new XmlRootAttribute("XmlSave"));
                    TasksList = (List<Task>)deserializer.Deserialize(reader);
                    MessageBox.Show("Successfully read", "Read");
                }
                
                
                
            }
            catch (Exception)
            {
                MessageBox.Show("File is emty", "Error");
            }
            return TasksList;
            
        }

    }
}


