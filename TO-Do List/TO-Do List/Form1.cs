using System;
using System.Data;

namespace TO_Do_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable todoList = new DataTable();
        bool isEditing = false;
        private object descriptionTextbox;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create columns
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            //Point our datagridview to out datasource
            ToDoListView.DataSource = todoList;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            TitleTextbox.Text = "";
            DescriptionTextbox.Text = "";
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            isEditing = true;
            // Fill text fields with data from table
            TitleTextbox.Text = ToDoListView.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[0]ToString();
            descriptionTextbox.Text = todoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[ToDoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex);
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if(isEditing)
            {
                todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Title"] = TitleTextbox.Text;
                todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Description"] = DescriptionTextbox.Text;
            }
            else 
            {
                todoList.Rows.Add(TitleTextbox.Text, descriptionTextbox.Text);
            }
            // Clear fields
            TitleTextbox.Text = "";
            descriptionTextbox.Text = "";
            isEditing = false;
        }
    }
}