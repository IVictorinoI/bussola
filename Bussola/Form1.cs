using Bussola.Direcoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bussola
{
    public partial class Form1 : Form
    {
        private EnumPontosCardeais pontoAtual;
        public Form1()
        {
            InitializeComponent();
            this.Resetar();
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            if(textBoxInput.Text == "")
            {
                return;
            }
            this.TrataPontoDigitado(textBoxInput.Text);
            textBoxInput.Clear();
        }

        private void TrataPontoDigitado(string textoDigitado)
        {
            var pontoCriado = new FabricaPontoCardeal().Criar(pontoAtual);
            var direcao = new FabricaDirecao().Criar(textoDigitado);

            pontoAtual = pontoCriado.Virar(direcao);

            this.ImprimePontoAtual();
        }

        private void ImprimePontoAtual()
        {
            textBoxOutput.Text += pontoAtual.ToString().Substring(0,1);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.Resetar();
        }

        public void Resetar()
        {
            pontoAtual = EnumPontosCardeais.Norte;
            textBoxOutput.Text = string.Empty;
            textBoxInput.Text = string.Empty;
        }
    }
}
