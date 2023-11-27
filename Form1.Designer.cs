namespace U4_P1
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button6 = new Button();
            button7 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 63);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 1;
            label2.Text = "Numero 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 118);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 2;
            label3.Text = "Numero 2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(252, 31);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 56);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(252, 31);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 62);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 6;
            label4.Text = "Resultado";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(29, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(648, 216);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresar Datos";
            // 
            // button5
            // 
            button5.Location = new Point(41, 164);
            button5.Name = "button5";
            button5.Size = new Size(162, 34);
            button5.TabIndex = 13;
            button5.Text = "Limpiar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(450, 164);
            button4.Name = "button4";
            button4.Size = new Size(162, 34);
            button4.TabIndex = 12;
            button4.Text = "Dividir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(450, 124);
            button3.Name = "button3";
            button3.Size = new Size(162, 34);
            button3.TabIndex = 11;
            button3.Text = "Multiplicar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(450, 84);
            button2.Name = "button2";
            button2.Size = new Size(162, 34);
            button2.TabIndex = 10;
            button2.Text = "Restar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(450, 44);
            button1.Name = "button1";
            button1.Size = new Size(162, 34);
            button1.TabIndex = 9;
            button1.Text = "Sumar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Location = new Point(29, 245);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(648, 114);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // button6
            // 
            button6.Location = new Point(450, 30);
            button6.Name = "button6";
            button6.Size = new Size(162, 34);
            button6.TabIndex = 7;
            button6.Text = "Propiedades";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(450, 70);
            button7.Name = "button7";
            button7.Size = new Size(162, 34);
            button7.TabIndex = 8;
            button7.Text = "Estructura";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 384);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button6;
        private Button button7;
    }
}