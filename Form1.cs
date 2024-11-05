namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dia = 05;
        int mes = 05;
        int año = 2024;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelguion1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSpinTop_Click(object sender, EventArgs e)
        {
            if (dia < 31)
            {
                dia = dia + 1;
                labelDia.Text = dia.ToString();
            }
            else
            {
                dia = 1;
                labelDia.Text = dia.ToString();
                mes = mes + 1;
                labelMes.Text = mes.ToString("");
                if (mes > 12)
                {
                    mes = 1;
                    labelMes.Text = mes.ToString("");
                    año = año + 1;
                    labelAño.Text = año.ToString();
                }
            }


        }

        private void buttonSpinDown_Click(object sender, EventArgs e)
        {
            if ((dia == 05) && (mes == 05) && (año == 2024))
            {
                dia = 5;
            }
            else
            {
                if (dia > 1)
                {
                    dia = dia - 1;
                    labelDia.Text = dia.ToString();
                }
                else
                {
                    dia = 31;
                    labelDia.Text = dia.ToString();
                    mes = mes - 1;
                    labelMes.Text = mes.ToString();
                    if (mes < 1)
                    {
                        mes = 12;
                        labelMes.Text = mes.ToString();
                        año = año - 1;
                        labelAño.Text = año.ToString();
                    }
                }
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //no se mirar que solo sea un numero lo siento profe no me bajes mucho porque lo he pensado pero no puedo buscar por google como se hace perdoooon
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label8.Enabled = true;
                textBox3.Enabled = true;
                checkBox1.Enabled = true;
            }
            else
            {
                label8.Enabled = false;
                textBox3.Enabled = false;
                checkBox1.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label10.Enabled = true;
                label11.Enabled = true;
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
            }
            else
            {
                label10.Enabled = false;
                label11.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
