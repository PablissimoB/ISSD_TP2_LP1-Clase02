namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(textBox1.Text);
            if (edad < 18)
            {
                lblSaludo.Text = "Es menor";
            }
            else
            {
                lblSaludo.Text = "Es mayor";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = "Hola Mundo";
        }

        public int contarBotonPresionado(int x)
        {
            return x + 1;
        }

        public string sumar(int n1, int n2)
        {
            return (n1 + n2).ToString();
        }
        public string sumar(float n1, float n2)
        {
            return (n1 + n2).ToString();
        }
        public string sumar(int n1, int n2, int n3)
        {
            return (n1 + n2 + n3).ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string resultado = sumar(int.Parse(txtNumero1.Text), int.Parse(txtNumero2.Text), 10);

                MessageBox.Show("El resultado es: " + resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("no ingreso valores validos");
            }
            finally
            {
                contador = contarBotonPresionado(contador);
                lblContador.Text = contador.ToString();
            }
        }
        public class MiExcepcion : Exception
        {
            public MiExcepcion() { }

            public MiExcepcion(string mensaje) : base(mensaje) { }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int resultado = int.Parse(txtNumero1.Text) / int.Parse(txtNumero2.Text);
                if (resultado == 1)
                {
                    throw new MiExcepcion("Excepcion Personalizada: El resultado es 1");
                }
                else
                {
                    MessageBox.Show(resultado.ToString());
                }
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dividir por 0");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Valor ingresado no se puede operar");

            }
            catch (MiExcepcion ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            MessageBox.Show(random.Next(1, 6).ToString());
        }

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten valores numericos");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "\n" + textBox2.Text + " - " + textBox3.Text;
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}