namespace Actividad_2___SumaPropiedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            Sumar suma = new Sumar();
            suma.Num1 = int.Parse(Valor1.Text);
            suma.Num2 = int.Parse(Valor2.Text);

            Resultado.Text = suma.sumar().ToString();
        }
    }
}