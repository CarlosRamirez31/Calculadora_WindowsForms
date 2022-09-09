using NCalc;
using System.Runtime.CompilerServices;

namespace tarea3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cero_Click(object sender, EventArgs e)
        {
            if(this.resultado.Text.Length < 12)
            {
                this.resultado.Text += 0;
            }
        }

        private void uno_Click(object sender, EventArgs e)
        {
            if (this.resultado.Text.Length < 12)
            {
                this.resultado.Text += 1;
            }
        }

        private void dos_Click(object sender, EventArgs e)
        {
            if (this.resultado.Text.Length < 12)
            {
                this.resultado.Text += 2;
            }
        }

        private void tres_Click(object sender, EventArgs e)
        {
            if (this.resultado.Text.Length < 12)
            {
                this.resultado.Text += 3;
            }
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            if (this.resultado.Text.Length < 12)
            {
                this.resultado.Text += 4;
            }
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            if (this.resultado.Text.Length < 12)
            {
                this.resultado.Text += 5;
            }
        }

        private void seis_Click(object sender, EventArgs e)
        {
            if (this.resultado.Text.Length < 12)
            {
                this.resultado.Text += 6;
            }
        }

        private void siete_Click(object sender, EventArgs e)
        {
            if (this.resultado.Text.Length < 12)
            {
                this.resultado.Text += 7;
            }
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            if (this.resultado.Text.Length < 12)
            {
                this.resultado.Text += 8;
            }
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            if (this.resultado.Text.Length < 12)
            {
                this.resultado.Text += 9;
            }
        }

        private void ce_Click(object sender, EventArgs e)
        {
            this.resultado.Clear();
        }

        private void c_Click(object sender, EventArgs e)
        {
            string resultado = this.resultado.Text;
            if(resultado.Length > 0)
            {
                this.resultado.Text = resultado.Substring(0, resultado.Length - 1);
            }
        }

        private void punto_Click(object sender, EventArgs e)
        {
            if (this.resultado.Text.Length < 12)
            {
                this.resultado.Text += ".";
            }
        }

        private void mas_Click(object sender, EventArgs e)
        {
            if (this.resultado.Text.Length < 12)
            {
                this.resultado.Text += "+";
            }
        }

        private void menos_Click(object sender, EventArgs e)
        {
            if (this.resultado.Text.Length < 12)
            {
                this.resultado.Text += "-";
            }
        }

        private void por_Click(object? sender, EventArgs e)
        {
            if (this.resultado.Text.Length < 12)
            {
                this.resultado.Text += "*";
            }
        }

        private void entre_Click(object sender, EventArgs e)
        {
            if (this.resultado.Text.Length < 12)
            {
                this.resultado.Text += "/";
            }
        }

        private void igual_Click(object sender, EventArgs e)
        {
            Expression operacion = new Expression(string.Format(this.resultado.Text)); 
            this.resultado.Text = operacion.Evaluate().ToString();
        }
    }
}