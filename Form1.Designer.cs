
namespace Avaliacao3
{
    partial class frmMovimento
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
            this.txtConta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdComum = new System.Windows.Forms.RadioButton();
            this.rdEspecial = new System.Windows.Forms.RadioButton();
            this.lbLimite = new System.Windows.Forms.Label();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.grpSuperior = new System.Windows.Forms.GroupBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gprMovimento = new System.Windows.Forms.GroupBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtMovimento = new System.Windows.Forms.DateTimePicker();
            this.grpSuperior.SuspendLayout();
            this.gprMovimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(11, 53);
            this.txtConta.MaxLength = 10;
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(100, 23);
            this.txtConta.TabIndex = 0;
            this.txtConta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtConta.Layout += new System.Windows.Forms.LayoutEventHandler(this.Leave_numConta);
            this.txtConta.Leave += new System.EventHandler(this.txtConta_Leave);
            this.txtConta.MouseLeave += new System.EventHandler(this.txtConta_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nr. Conta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdComum
            // 
            this.rdComum.AutoSize = true;
            this.rdComum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdComum.Location = new System.Drawing.Point(157, 25);
            this.rdComum.Name = "rdComum";
            this.rdComum.Size = new System.Drawing.Size(129, 25);
            this.rdComum.TabIndex = 2;
            this.rdComum.TabStop = true;
            this.rdComum.Text = "Conta Comum";
            this.rdComum.UseVisualStyleBackColor = true;
            this.rdComum.CheckedChanged += new System.EventHandler(this.rdComum_CheckedChanged);
            // 
            // rdEspecial
            // 
            this.rdEspecial.AutoSize = true;
            this.rdEspecial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdEspecial.Location = new System.Drawing.Point(157, 57);
            this.rdEspecial.Name = "rdEspecial";
            this.rdEspecial.Size = new System.Drawing.Size(128, 25);
            this.rdEspecial.TabIndex = 3;
            this.rdEspecial.TabStop = true;
            this.rdEspecial.Text = "Conta Especial";
            this.rdEspecial.UseVisualStyleBackColor = true;
            this.rdEspecial.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lbLimite
            // 
            this.lbLimite.AutoSize = true;
            this.lbLimite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLimite.Location = new System.Drawing.Point(335, 32);
            this.lbLimite.Name = "lbLimite";
            this.lbLimite.Size = new System.Drawing.Size(53, 21);
            this.lbLimite.TabIndex = 4;
            this.lbLimite.Text = "Limite";
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSaldo.Location = new System.Drawing.Point(499, 32);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(49, 21);
            this.lbSaldo.TabIndex = 5;
            this.lbSaldo.Text = "Saldo";
            this.lbSaldo.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(335, 56);
            this.txtLimite.MaxLength = 10;
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(100, 23);
            this.txtLimite.TabIndex = 6;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(499, 56);
            this.txtSaldo.MaxLength = 10;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 23);
            this.txtSaldo.TabIndex = 7;
            // 
            // grpSuperior
            // 
            this.grpSuperior.Controls.Add(this.rdEspecial);
            this.grpSuperior.Controls.Add(this.txtSaldo);
            this.grpSuperior.Controls.Add(this.txtConta);
            this.grpSuperior.Controls.Add(this.txtLimite);
            this.grpSuperior.Controls.Add(this.label1);
            this.grpSuperior.Controls.Add(this.lbSaldo);
            this.grpSuperior.Controls.Add(this.rdComum);
            this.grpSuperior.Controls.Add(this.lbLimite);
            this.grpSuperior.Location = new System.Drawing.Point(12, 12);
            this.grpSuperior.Name = "grpSuperior";
            this.grpSuperior.Size = new System.Drawing.Size(645, 100);
            this.grpSuperior.TabIndex = 8;
            this.grpSuperior.TabStop = false;
            this.grpSuperior.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDepositar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDepositar.Location = new System.Drawing.Point(12, 131);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(184, 64);
            this.btnDepositar.TabIndex = 9;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSacar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSacar.Location = new System.Drawing.Point(202, 131);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(184, 64);
            this.btnSacar.TabIndex = 10;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = false;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(482, 131);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(166, 64);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button3_Click);
            // 
            // gprMovimento
            // 
            this.gprMovimento.Controls.Add(this.btnLancar);
            this.gprMovimento.Controls.Add(this.label5);
            this.gprMovimento.Controls.Add(this.txtValor);
            this.gprMovimento.Controls.Add(this.label4);
            this.gprMovimento.Controls.Add(this.dtMovimento);
            this.gprMovimento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gprMovimento.Location = new System.Drawing.Point(13, 213);
            this.gprMovimento.Name = "gprMovimento";
            this.gprMovimento.Size = new System.Drawing.Size(644, 104);
            this.gprMovimento.TabIndex = 12;
            this.gprMovimento.TabStop = false;
            this.gprMovimento.Text = "MOVIMENTO:";
            this.gprMovimento.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnLancar
            // 
            this.btnLancar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLancar.Location = new System.Drawing.Point(487, 50);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(134, 40);
            this.btnLancar.TabIndex = 13;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(240, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(240, 67);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(119, 23);
            this.txtValor.TabIndex = 8;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtMovimento
            // 
            this.dtMovimento.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtMovimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtMovimento.Location = new System.Drawing.Point(10, 59);
            this.dtMovimento.Name = "dtMovimento";
            this.dtMovimento.Size = new System.Drawing.Size(135, 31);
            this.dtMovimento.TabIndex = 0;
            this.dtMovimento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dtMovimento.Leave += new System.EventHandler(this.dtMovimento_Leave);
            // 
            // frmMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 326);
            this.Controls.Add(this.gprMovimento);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.grpSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovimento";
            this.Text = "Movimento de Conta";
            this.Load += new System.EventHandler(this.frmMovimento_Load);
            this.grpSuperior.ResumeLayout(false);
            this.grpSuperior.PerformLayout();
            this.gprMovimento.ResumeLayout(false);
            this.gprMovimento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdComum;
        private System.Windows.Forms.RadioButton rdEspecial;
        private System.Windows.Forms.Label lbLimite;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.GroupBox grpSuperior;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gprMovimento;
        private System.Windows.Forms.DateTimePicker dtMovimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.Label label5;
    }
}

