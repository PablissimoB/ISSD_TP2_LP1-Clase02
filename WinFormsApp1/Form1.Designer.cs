namespace WinFormsApp1
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
            lblSaludo = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            lblContador = new Label();
            button4 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Location = new Point(206, 80);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(63, 32);
            lblSaludo.TabIndex = 0;
            lblSaludo.Text = "Hola";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(442, 162);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 2;
            button1.Text = "Evaluar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(392, 12);
            button2.Name = "button2";
            button2.Size = new Size(200, 66);
            button2.TabIndex = 3;
            button2.Text = "Cambiar Titulo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(466, 280);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 4;
            button3.Text = "Sumar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(72, 294);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(200, 39);
            txtNumero1.TabIndex = 5;
            txtNumero1.KeyPress += txtNumero1_KeyPress;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(73, 371);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(200, 39);
            txtNumero2.TabIndex = 6;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(480, 385);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(0, 32);
            lblContador.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(472, 340);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 8;
            button4.Text = "Dividir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(948, 301);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 9;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(73, 495);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(403, 491);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 570);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 12;
            // 
            // button5
            // 
            button5.Location = new Point(677, 495);
            button5.Name = "button5";
            button5.Size = new Size(150, 46);
            button5.TabIndex = 13;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 666);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(lblContador);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(lblSaludo);
            Name = "Form1";
            Text = "Formulario Prueba";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaludo;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Label lblContador;
        private Button button4;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Button button5;
    }
}