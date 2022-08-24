namespace CalculadoraForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_somar_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = Convert.ToDouble(txt_valor1.Text.Replace(".",","));
            valor2 = Convert.ToDouble(txt_valor2.Text.Replace(".",","));

            resultado = valor1 + valor2;

            txt_resultado.Text = resultado.ToString();
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = Convert.ToDouble(txt_valor1.Text.Replace(".",","));
            valor2 = Convert.ToDouble(txt_valor2.Text.Replace(".",","));

            resultado = valor1 / valor2;

            txt_resultado.Text = resultado.ToString();
        }

        private void btn_subtrair_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = Convert.ToDouble(txt_valor1.Text.Replace(".",","));
            valor2 = Convert.ToInt32(txt_valor2.Text);

            resultado = valor1 - valor2;

            txt_resultado.Text = resultado.ToString();
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = Convert.ToDouble(txt_valor1.Text.Replace(".",","));
            valor2 = Convert.ToDouble(txt_valor2.Text.Replace(".",","));

            resultado = valor1 * valor2;

            txt_resultado.Text = resultado.ToString();
        }
    }
}