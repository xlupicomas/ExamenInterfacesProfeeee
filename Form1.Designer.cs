namespace Examen
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
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            labelAño = new Label();
            labelguion1 = new Label();
            labelMes = new Label();
            label6 = new Label();
            labelDia = new Label();
            buttonSpinDown = new Button();
            buttonSpinTop = new Button();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            checkBox1 = new CheckBox();
            textBox3 = new TextBox();
            label9 = new Label();
            comboBox2 = new ComboBox();
            label10 = new Label();
            comboBox3 = new ComboBox();
            label11 = new Label();
            comboBox4 = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(267, 32);
            label1.TabIndex = 0;
            label1.Text = "Salón Habana - Alquiler";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 100);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 139);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 3;
            label3.Text = "Teléfono";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(84, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 241);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 5;
            label4.Text = "Fecha";
            label4.Click += label4_Click;
            // 
            // labelAño
            // 
            labelAño.AutoSize = true;
            labelAño.Location = new Point(81, 241);
            labelAño.Name = "labelAño";
            labelAño.Size = new Size(31, 15);
            labelAño.TabIndex = 6;
            labelAño.Text = "2024";
            labelAño.Click += label5_Click;
            // 
            // labelguion1
            // 
            labelguion1.AutoSize = true;
            labelguion1.Location = new Point(111, 241);
            labelguion1.Name = "labelguion1";
            labelguion1.Size = new Size(12, 15);
            labelguion1.TabIndex = 7;
            labelguion1.Text = "-";
            labelguion1.Click += labelguion1_Click;
            // 
            // labelMes
            // 
            labelMes.AutoSize = true;
            labelMes.Location = new Point(118, 241);
            labelMes.Name = "labelMes";
            labelMes.Size = new Size(19, 15);
            labelMes.TabIndex = 8;
            labelMes.Text = "05";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(133, 241);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 9;
            label6.Text = "-";
            // 
            // labelDia
            // 
            labelDia.AutoSize = true;
            labelDia.Location = new Point(143, 241);
            labelDia.Name = "labelDia";
            labelDia.Size = new Size(19, 15);
            labelDia.TabIndex = 10;
            labelDia.Text = "05";
            // 
            // buttonSpinDown
            // 
            buttonSpinDown.Location = new Point(168, 251);
            buttonSpinDown.Name = "buttonSpinDown";
            buttonSpinDown.Size = new Size(24, 22);
            buttonSpinDown.TabIndex = 12;
            buttonSpinDown.Text = "-";
            buttonSpinDown.UseVisualStyleBackColor = true;
            buttonSpinDown.Click += buttonSpinDown_Click;
            // 
            // buttonSpinTop
            // 
            buttonSpinTop.Location = new Point(168, 225);
            buttonSpinTop.Name = "buttonSpinTop";
            buttonSpinTop.Size = new Size(24, 22);
            buttonSpinTop.TabIndex = 13;
            buttonSpinTop.Text = "+";
            buttonSpinTop.UseVisualStyleBackColor = true;
            buttonSpinTop.Click += buttonSpinTop_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 288);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 14;
            label5.Text = "Tipo";
            label5.Click += label5_Click_1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(68, 286);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 19);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "banquete";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(144, 286);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 19);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "jornada";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(208, 286);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(74, 19);
            radioButton3.TabIndex = 17;
            radioButton3.TabStop = true;
            radioButton3.Text = "congreso";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bufé", "Carta", "Cita con el chef", "No precisa" });
            comboBox1.Location = new Point(158, 349);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 356);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 19;
            label7.Text = "Cocina";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Enabled = false;
            label8.Location = new Point(329, 55);
            label8.Name = "label8";
            label8.Size = new Size(115, 15);
            label8.TabIndex = 20;
            label8.Text = "Número de jornadas";
            label8.Click += label8_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(329, 82);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(166, 19);
            checkBox1.TabIndex = 21;
            checkBox1.Text = "Se requieres Habitaciones?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(450, 52);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(24, 23);
            textBox3.TabIndex = 22;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 323);
            label9.Name = "label9";
            label9.Size = new Size(118, 15);
            label9.TabIndex = 23;
            label9.Text = "Número De Personas";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "0-10", "10-25", "25-50", "50-100", "+100" });
            comboBox2.Location = new Point(158, 320);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Enabled = false;
            label10.Location = new Point(329, 123);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 25;
            label10.Text = "Tipo De Mesa";
            label10.Click += label10_Click;
            // 
            // comboBox3
            // 
            comboBox3.Enabled = false;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Mesa redonda", "Mesa Rectangular" });
            comboBox3.Location = new Point(521, 115);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Enabled = false;
            label11.Location = new Point(329, 153);
            label11.Name = "label11";
            label11.Size = new Size(186, 15);
            label11.TabIndex = 27;
            label11.Text = "Número de Comensales Por Mesa";
            // 
            // comboBox4
            // 
            comboBox4.Enabled = false;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "5", "10", "15", "20", "25" });
            comboBox4.Location = new Point(521, 148);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(28, 65);
            label12.Name = "label12";
            label12.Size = new Size(177, 20);
            label12.TabIndex = 29;
            label12.Text = "Información de Contacto";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(25, 188);
            label13.Name = "label13";
            label13.Size = new Size(187, 20);
            label13.TabIndex = 30;
            label13.Text = "Información de la Reserva";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(comboBox4);
            Controls.Add(label11);
            Controls.Add(comboBox3);
            Controls.Add(label10);
            Controls.Add(comboBox2);
            Controls.Add(label9);
            Controls.Add(textBox3);
            Controls.Add(checkBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(buttonSpinTop);
            Controls.Add(buttonSpinDown);
            Controls.Add(labelDia);
            Controls.Add(label6);
            Controls.Add(labelMes);
            Controls.Add(labelguion1);
            Controls.Add(labelAño);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label labelAño;
        private Label labelguion1;
        private Label labelMes;
        private Label label6;
        private Label labelDia;
        private Button buttonSpinDown;
        private Button buttonSpinTop;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private ComboBox comboBox1;
        private Label label7;
        private Label label8;
        private CheckBox checkBox1;
        private TextBox textBox3;
        private Label label9;
        private ComboBox comboBox2;
        private Label label10;
        private ComboBox comboBox3;
        private Label label11;
        private ComboBox comboBox4;
        private Label label12;
        private Label label13;
    }
}
