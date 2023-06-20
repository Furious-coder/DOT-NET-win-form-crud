namespace library
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
            name = new Label();
            id = new Label();
            book = new Label();
            n = new TextBox();
            i = new TextBox();
            b = new TextBox();
            add = new Button();
            update = new Button();
            delete = new Button();
            grid = new DataGridView();
            view = new Button();
            clear = new Button();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(83, 49);
            name.Name = "name";
            name.Size = new Size(59, 25);
            name.TabIndex = 0;
            name.Text = "Name";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(83, 115);
            id.Name = "id";
            id.Size = new Size(30, 25);
            id.TabIndex = 1;
            id.Text = "ID";
            // 
            // book
            // 
            book.AutoSize = true;
            book.Location = new Point(83, 188);
            book.Name = "book";
            book.Size = new Size(53, 25);
            book.TabIndex = 2;
            book.Text = "Book";
            // 
            // n
            // 
            n.Location = new Point(148, 46);
            n.Name = "n";
            n.Size = new Size(359, 31);
            n.TabIndex = 3;
            // 
            // i
            // 
            i.Location = new Point(148, 115);
            i.Name = "i";
            i.Size = new Size(188, 31);
            i.TabIndex = 4;
            // 
            // b
            // 
            b.Location = new Point(148, 188);
            b.Name = "b";
            b.Size = new Size(359, 31);
            b.TabIndex = 5;
            // 
            // add
            // 
            add.Location = new Point(596, 40);
            add.Name = "add";
            add.Size = new Size(168, 43);
            add.TabIndex = 6;
            add.Text = "ADD";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // update
            // 
            update.Location = new Point(596, 115);
            update.Name = "update";
            update.Size = new Size(168, 43);
            update.TabIndex = 7;
            update.Text = "UPDATE";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.Location = new Point(596, 188);
            delete.Name = "delete";
            delete.Size = new Size(168, 43);
            delete.TabIndex = 8;
            delete.Text = "DELETE";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // grid
            // 
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Location = new Point(25, 249);
            grid.Name = "grid";
            grid.RowHeadersWidth = 62;
            grid.RowTemplate.Height = 33;
            grid.Size = new Size(532, 198);
            grid.TabIndex = 9;
            // 
            // view
            // 
            view.Location = new Point(596, 268);
            view.Name = "view";
            view.Size = new Size(168, 43);
            view.TabIndex = 10;
            view.Text = "VIEW";
            view.UseVisualStyleBackColor = true;
            view.Click += view_Click;
            // 
            // clear
            // 
            clear.Location = new Point(596, 344);
            clear.Name = "clear";
            clear.Size = new Size(168, 43);
            clear.TabIndex = 11;
            clear.Text = "CLEAR ALL";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(clear);
            Controls.Add(view);
            Controls.Add(grid);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(add);
            Controls.Add(b);
            Controls.Add(i);
            Controls.Add(n);
            Controls.Add(book);
            Controls.Add(id);
            Controls.Add(name);
            Name = "Form1";
            Text = "Library Entries";
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Label id;
        private Label book;
        private TextBox n;
        private TextBox i;
        private TextBox b;
        private Button add;
        private Button update;
        private Button delete;
        private DataGridView grid;
        private Button view;
        private Button clear;
    }
}