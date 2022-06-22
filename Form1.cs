using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao3
{
    public partial class frmMovimento : Form
    {
        static List<contaBancaria> _listConta = new List<contaBancaria>();
        private contaBancaria _contaAtual = null;
        private int operacao = 0;
        public static int c = 0;

        public frmMovimento()
        {
            InitializeComponent();
            this.Size = new Size(685, 255);
            _listConta = contaBancaria.geraContas();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMovimento_Load(object sender, EventArgs e)
        {
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(685, 365);
            txtConta.Enabled = false;
            operacao = 1;
            gprMovimento.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void etxtBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            if (operacao == 1)
            {
                double saldo = Convert.ToDouble(txtSaldo.Text);
                saldo += Convert.ToDouble(txtValor.Text);
                txtSaldo.Text = Convert.ToString(saldo);
                txtSaldo.Enabled = true;
                txtLimite.Enabled = true;
                grpSuperior.Enabled = true;
                gprMovimento.Enabled = false;
                this.Size = new Size(685, 255);
                txtConta.Enabled = true;
                btnDepositar.Enabled = true;
                btnSacar.Enabled = true;
                btnSair.Enabled = true;

            }
            else if (operacao == 2)
            {
                double valorTotal = 0;
                valorTotal += Convert.ToDouble(txtSaldo.Text);
                if (rdEspecial.Checked)
                {
                    valorTotal += Convert.ToDouble(txtLimite.Text);
                }

                double lancamento = 0;
                lancamento = Convert.ToDouble(txtValor.Text);

                if (lancamento > valorTotal)
                {
                    MessageBox.Show("O valor inserido não é permitido!", "Lançamento superior ao saldo total!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtValor.Focus();
                }
                else
                {
                    double saldo = Convert.ToDouble(txtSaldo.Text);
                    saldo -= Convert.ToDouble(txtValor.Text);
                    txtSaldo.Text = Convert.ToString(saldo);
                    txtSaldo.Enabled = true;
                    txtLimite.Enabled = true;
                    grpSuperior.Enabled = true;
                    gprMovimento.Enabled = false;
                    this.Size = new Size(685, 255);
                    txtConta.Enabled = true;
                    btnDepositar.Enabled = true;
                    btnSacar.Enabled = true;
                    btnSair.Enabled = true;

                }
            }
        }

        private void rdComum_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            rdComum.Enabled = false;
            rdEspecial.Enabled = false;
            txtLimite.Enabled = false;
            txtSaldo.Enabled = false;
            lbLimite.Enabled = false;
            lbSaldo.Enabled = false;
        }

        private void Leave_numConta(object sender, LayoutEventArgs e)
        {
            
   
        }

        private void txtConta_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void txtConta_Leave(object sender, EventArgs e)
        {
            Boolean flag = false;
            foreach (contaBancaria lista in _listConta)
            {
                if (lista.CodigoConta.Equals(txtConta.Text.Trim()))
                {
                    if (lista.Tipo == 0)
                    {
                        rdComum.Checked = true;
                    }
                    else
                    {
                        rdEspecial.Checked = true;
                    }
                    txtLimite.Text = lista.Limite.ToString();
                    txtSaldo.Text = lista.Saldo.ToString();
                    flag = true;
                } 
            }
            if (flag == false)
            {
                MessageBox.Show("O número da conta não existe!", "Aviso do sistema");
                txtConta.Focus();
            }

            
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(685, 365);
            txtConta.Enabled = false;
            btnLancar.Enabled = true;
            operacao = 2;
            gprMovimento.Enabled = true;
        }

        private void dtMovimento_Leave(object sender, EventArgs e)
        {
            if ((dtMovimento.Value.DayOfWeek == DayOfWeek.Sunday) ||
                (dtMovimento.Value.DayOfWeek == DayOfWeek.Saturday))
            {
                MessageBox.Show("Data Inválida!");
                dtMovimento.Focus();
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            int Valor = int.Parse(txtValor.Text);
            if (Valor < 0)
            {
                MessageBox.Show("Valor Inválido!");
                txtValor.Focus();
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
