namespace FormsPetLove
{
    partial class CadastroPet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtRaça = new System.Windows.Forms.TextBox();
            this.lblRaça = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.btnAcoes = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAjuste = new System.Windows.Forms.Button();
            this.btnObterDados = new System.Windows.Forms.Button();
            this.lboDados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(12, 68);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(164, 20);
            this.txtIdade.TabIndex = 22;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(164, 20);
            this.txtNome.TabIndex = 21;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(12, 52);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 20;
            this.lblIdade.Text = "Idade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tipo";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(71, 13);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome Do Pet";
            // 
            // txtRaça
            // 
            this.txtRaça.Location = new System.Drawing.Point(274, 32);
            this.txtRaça.Name = "txtRaça";
            this.txtRaça.Size = new System.Drawing.Size(164, 20);
            this.txtRaça.TabIndex = 23;
            // 
            // lblRaça
            // 
            this.lblRaça.AutoSize = true;
            this.lblRaça.Location = new System.Drawing.Point(271, 15);
            this.lblRaça.Name = "lblRaça";
            this.lblRaça.Size = new System.Drawing.Size(33, 13);
            this.lblRaça.TabIndex = 24;
            this.lblRaça.Text = "Raça";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(274, 68);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(164, 20);
            this.txtTipo.TabIndex = 25;
            // 
            // btnAcoes
            // 
            this.btnAcoes.Location = new System.Drawing.Point(15, 266);
            this.btnAcoes.Name = "btnAcoes";
            this.btnAcoes.Size = new System.Drawing.Size(134, 27);
            this.btnAcoes.TabIndex = 30;
            this.btnAcoes.Text = "Atualizar Lista";
            this.btnAcoes.UseVisualStyleBackColor = true;
            this.btnAcoes.Click += new System.EventHandler(this.btnAcoes_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(155, 266);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(283, 27);
            this.btnLimpar.TabIndex = 29;
            this.btnLimpar.Text = "Limpar Seleção";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnAjuste
            // 
            this.btnAjuste.Location = new System.Drawing.Point(155, 224);
            this.btnAjuste.Name = "btnAjuste";
            this.btnAjuste.Size = new System.Drawing.Size(283, 26);
            this.btnAjuste.TabIndex = 28;
            this.btnAjuste.Text = "Cadastrar";
            this.btnAjuste.UseVisualStyleBackColor = true;
            this.btnAjuste.Click += new System.EventHandler(this.btnAjuste_Click);
            // 
            // btnObterDados
            // 
            this.btnObterDados.Location = new System.Drawing.Point(15, 224);
            this.btnObterDados.Name = "btnObterDados";
            this.btnObterDados.Size = new System.Drawing.Size(134, 26);
            this.btnObterDados.TabIndex = 27;
            this.btnObterDados.Text = "Extrair Dados";
            this.btnObterDados.UseVisualStyleBackColor = true;
            this.btnObterDados.Click += new System.EventHandler(this.btnObterDados_Click);
            // 
            // lboDados
            // 
            this.lboDados.BackColor = System.Drawing.Color.Gray;
            this.lboDados.FormattingEnabled = true;
            this.lboDados.Location = new System.Drawing.Point(12, 95);
            this.lboDados.Name = "lboDados";
            this.lboDados.Size = new System.Drawing.Size(426, 121);
            this.lboDados.TabIndex = 26;
            this.lboDados.SelectedIndexChanged += new System.EventHandler(this.lboDados_SelectedIndexChanged);
            // 
            // CadastroPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 322);
            this.Controls.Add(this.btnAcoes);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAjuste);
            this.Controls.Add(this.btnObterDados);
            this.Controls.Add(this.lboDados);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblRaça);
            this.Controls.Add(this.txtRaça);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastroPet";
            this.Text = "CadastroPet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtRaça;
        private System.Windows.Forms.Label lblRaça;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Button btnAcoes;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAjuste;
        private System.Windows.Forms.Button btnObterDados;
        private System.Windows.Forms.ListBox lboDados;
    }
}