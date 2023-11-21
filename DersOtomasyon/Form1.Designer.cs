namespace DersOtomasyon
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
            button1 = new Button();
            groupBox1 = new GroupBox();
            textClass = new TextBox();
            textLesson = new TextBox();
            textDerslik = new TextBox();
            textTeacher = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(6, 262);
            button1.Name = "button1";
            button1.Size = new Size(104, 27);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textTeacher);
            groupBox1.Controls.Add(textDerslik);
            groupBox1.Controls.Add(textLesson);
            groupBox1.Controls.Add(textClass);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(30, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 295);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textClass
            // 
            textClass.Location = new Point(172, 26);
            textClass.Name = "textClass";
            textClass.Size = new Size(125, 27);
            textClass.TabIndex = 1;
            // 
            // textLesson
            // 
            textLesson.Location = new Point(172, 77);
            textLesson.Name = "textLesson";
            textLesson.Size = new Size(125, 27);
            textLesson.TabIndex = 2;
            // 
            // textDerslik
            // 
            textDerslik.Location = new Point(172, 136);
            textDerslik.Name = "textDerslik";
            textDerslik.Size = new Size(125, 27);
            textDerslik.TabIndex = 3;
            // 
            // textTeacher
            // 
            textTeacher.Location = new Point(172, 193);
            textTeacher.Name = "textTeacher";
            textTeacher.Size = new Size(125, 27);
            textTeacher.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 29);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 5;
            label1.Text = "classes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 77);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "lesson";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 143);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 7;
            label3.Text = "derslik";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 193);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 8;
            label4.Text = "teacher";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 551);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textTeacher;
        private TextBox textDerslik;
        private TextBox textLesson;
        private TextBox textClass;
    }
}