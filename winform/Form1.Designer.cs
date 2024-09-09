namespace winform
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
            addbutton = new Button();
            deletebutton = new Button();
            updatebutton = new Button();
            dataGridView1 = new DataGridView();
            patientid = new TextBox();
            name = new TextBox();
            birthdate = new TextBox();
            sex = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            mob = new TextBox();
            birthplace = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // addbutton
            // 
            addbutton.BackColor = Color.Green;
            addbutton.Location = new Point(129, 291);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(75, 23);
            addbutton.TabIndex = 0;
            addbutton.Text = "add\r\n";
            addbutton.UseVisualStyleBackColor = false;
            addbutton.Click += button1_Click;
            // 
            // deletebutton
            // 
            deletebutton.BackColor = SystemColors.ControlDark;
            deletebutton.BackgroundImageLayout = ImageLayout.None;
            deletebutton.Location = new Point(433, 291);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(88, 23);
            deletebutton.TabIndex = 2;
            deletebutton.Text = "delete";
            deletebutton.UseVisualStyleBackColor = false;
            deletebutton.Click += deletebutton_Click;
            // 
            // updatebutton
            // 
            updatebutton.BackColor = Color.FromArgb(128, 64, 0);
            updatebutton.Location = new Point(276, 291);
            updatebutton.Name = "updatebutton";
            updatebutton.Size = new Size(75, 23);
            updatebutton.TabIndex = 3;
            updatebutton.Text = "update";
            updatebutton.UseVisualStyleBackColor = false;
            updatebutton.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 329);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(935, 282);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // patientid
            // 
            patientid.Location = new Point(295, 22);
            patientid.Name = "patientid";
            patientid.Size = new Size(100, 23);
            patientid.TabIndex = 5;
            
            // 
            // name
            // 
            name.Location = new Point(295, 72);
            name.Name = "name";
            name.Size = new Size(100, 23);
            name.TabIndex = 5;
            // 
            // birthdate
            // 
            birthdate.Location = new Point(295, 120);
            birthdate.Name = "birthdate";
            birthdate.Size = new Size(100, 23);
            birthdate.TabIndex = 5;
            
            // 
            // sex
            // 
            sex.Location = new Point(295, 169);
            sex.Name = "sex";
            sex.Size = new Size(100, 23);
            sex.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 25);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 6;
            label1.Text = "patient id";
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 72);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 6;
            label2.Text = "name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 120);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 6;
            label3.Text = "birth of date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 169);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 6;
            label4.Text = "gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(143, 215);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 7;
            label5.Text = "mobile number";
            
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(143, 262);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 7;
            label6.Text = "address";
          
            // 
            // mob
            // 
            mob.Location = new Point(295, 215);
            mob.Name = "mob";
            mob.Size = new Size(100, 23);
            mob.TabIndex = 5;
            // 
            // birthplace
            // 
            birthplace.Location = new Point(295, 262);
            birthplace.Name = "birthplace";
            birthplace.Size = new Size(100, 23);
            birthplace.TabIndex = 5;
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 640);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(birthplace);
            Controls.Add(mob);
            Controls.Add(sex);
            Controls.Add(birthdate);
            Controls.Add(name);
            Controls.Add(patientid);
            Controls.Add(dataGridView1);
            Controls.Add(updatebutton);
            Controls.Add(deletebutton);
            Controls.Add(addbutton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addbutton;
        private Button deletebutton;
        private Button updatebutton;
        private DataGridView dataGridView1;
        private TextBox patientid;
        private TextBox name;
        private TextBox birthdate;
        private TextBox sex;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox mob;
        private TextBox birthplace;
    }
}
