namespace TO_Do_List
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TitleTextbox = new TextBox();
            DescriptionTextbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            newButton = new Button();
            Savebutton = new Button();
            Deletebutton = new Button();
            Editbutton = new Button();
            ToDoListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ToDoListView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1234, 127);
            label1.TabIndex = 0;
            label1.Text = "To Do List";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // TitleTextbox
            // 
            TitleTextbox.Location = new Point(12, 110);
            TitleTextbox.Name = "TitleTextbox";
            TitleTextbox.Size = new Size(1278, 23);
            TitleTextbox.TabIndex = 1;
            // 
            // DescriptionTextbox
            // 
            DescriptionTextbox.Location = new Point(12, 162);
            DescriptionTextbox.Name = "DescriptionTextbox";
            DescriptionTextbox.Size = new Size(1278, 23);
            DescriptionTextbox.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(12, 136);
            label2.Name = "label2";
            label2.Size = new Size(776, 23);
            label2.TabIndex = 3;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(776, 23);
            label3.TabIndex = 4;
            label3.Text = "Title:";
            // 
            // newButton
            // 
            newButton.Location = new Point(12, 191);
            newButton.Name = "newButton";
            newButton.Size = new Size(315, 39);
            newButton.TabIndex = 5;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // Savebutton
            // 
            Savebutton.Location = new Point(975, 191);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(315, 39);
            Savebutton.TabIndex = 6;
            Savebutton.Text = "Save";
            Savebutton.UseVisualStyleBackColor = true;
            Savebutton.Click += Savebutton_Click;
            // 
            // Deletebutton
            // 
            Deletebutton.Location = new Point(654, 191);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(315, 39);
            Deletebutton.TabIndex = 7;
            Deletebutton.Text = "delete";
            Deletebutton.UseVisualStyleBackColor = true;
            Deletebutton.Click += Deletebutton_Click;
            // 
            // Editbutton
            // 
            Editbutton.Location = new Point(333, 191);
            Editbutton.Name = "Editbutton";
            Editbutton.Size = new Size(315, 39);
            Editbutton.TabIndex = 8;
            Editbutton.Text = "Edit";
            Editbutton.UseVisualStyleBackColor = true;
            Editbutton.Click += Editbutton_Click;
            // 
            // ToDoListView
            // 
            ToDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ToDoListView.BackgroundColor = Color.White;
            ToDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ToDoListView.Location = new Point(12, 236);
            ToDoListView.Name = "ToDoListView";
            ToDoListView.RowHeadersWidth = 62;
            ToDoListView.RowTemplate.Height = 25;
            ToDoListView.Size = new Size(1278, 401);
            ToDoListView.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1198, 629);
            Controls.Add(ToDoListView);
            Controls.Add(Editbutton);
            Controls.Add(Deletebutton);
            Controls.Add(Savebutton);
            Controls.Add(newButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DescriptionTextbox);
            Controls.Add(TitleTextbox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "To-Do List";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ToDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private TextBox TitleTextbox;
        private TextBox DescriptionTextbox;
        private Label label2;
        private Label label3;
        private Button newButton;
        private Button Savebutton;
        private Button Deletebutton;
        private Button Editbutton;
        private DataGridView ToDoListView;
    }
}