namespace U4_P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int _numer1;
        private int _numer2;

        public int Numer1 { get => _numer1; set => _numer1 = value; }
        public int Numer2 { get => _numer2; set => _numer2 = value; }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private int sumar(int num1, int num2)
        {
            int resultado;
            resultado = num1 + num2;
            return resultado;
        }
        private Double operaciones(int num1, int num2, string op)
        {
            Double resultado;
            if (op == "s")
            {
                resultado = num1 + num2;
            }
            else if (op == "r")
            {
                resultado = num1 - num2;
            }
            else if (op == "m")
            {
                resultado = num1 * num2;
            }
            else
            {
                resultado = num1 / num2;
            }
            return resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            numero1 = Convert.ToInt32(textBox1.Text);
            numero2 = Convert.ToInt32(textBox2.Text);
            int suma;
            suma = sumar(numero1, numero2);
            textBox3.Text = Convert.ToString(suma);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            Double resultado;
            numero1 = Convert.ToInt32(textBox1.Text);
            numero2 = Convert.ToInt32(textBox2.Text);
            resultado = operaciones(numero1, numero2, "r");
            textBox3.Text = Convert.ToString(resultado);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            Double resultado;
            numero1 = Convert.ToInt32(textBox1.Text);
            numero2 = Convert.ToInt32(textBox2.Text);
            resultado = operaciones(numero1, numero2, "m");
            textBox3.Text = Convert.ToString(resultado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            Double resultado;
            numero1 = Convert.ToInt32(textBox1.Text);
            numero2 = Convert.ToInt32(textBox2.Text);
            resultado = operaciones(numero1, numero2, "d");
            textBox3.Text = Convert.ToString(resultado);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Numer1 = 10;
            Numer2 = 30;
            int suma;
            suma = Numer1 + Numer2;
            textBox3.Text = Convert.ToString(suma);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cliente cliente1;
            cliente1.nombre = "Juan Carlos";
            cliente1.apellidos = "Arcilla";
            cliente1.telefono = "8991596153";

        }

        struct cliente
        {
            public string nombre;
            public string apellidos;
            public string telefono;
        }
    }
}