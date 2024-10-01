using System.Linq.Expressions;

namespace calculadora_decasa_forms
{
    public partial class Form1 : Form
    {
        double val1 = 0, val2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            Painel.Text += btn.Text;

        }

        private void btnOperacao_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            val1 = double.Parse(Painel.Text);

            operacao = btnUm.Text;
            Painel.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            val2 = double.Parse(Painel.Text);

            switch (operacao)
            {
                case "+":
                    Painel.Text = (val1 + val2).ToString();
                    break;

                case "-":
                    Painel.Text= (val1 - val2).ToString();
                    break;

                case "x":
                    Painel.Text = (val1 * val2).ToString();
                    break;

                case "/":
                    Painel.Text=(val1 / val2).ToString();

                    if (val1 == 0 && val2 == 0)
                    {

                    }
                    break;
            }


        }

    }
}
