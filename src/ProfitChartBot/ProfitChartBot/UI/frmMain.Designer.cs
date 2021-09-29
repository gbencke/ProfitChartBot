
namespace ProfitChartBot
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabConfiguracao = new System.Windows.Forms.TabPage();
            this.btnValorPosicaoAberta = new System.Windows.Forms.Button();
            this.lblValorPosicaoAberta = new System.Windows.Forms.Label();
            this.btnNumeroContratosAbertos = new System.Windows.Forms.Button();
            this.lblNumeroDeContratos = new System.Windows.Forms.Label();
            this.lblMostrarPosicoesNaTela = new System.Windows.Forms.Label();
            this.btnMostrarPosicoes = new System.Windows.Forms.Button();
            this.btnTomarPosicao = new System.Windows.Forms.Button();
            this.lblIndicadorParaTomarPosicao = new System.Windows.Forms.Label();
            this.btnZerarMercado = new System.Windows.Forms.Button();
            this.lblBotaoZerarPosicao = new System.Windows.Forms.Label();
            this.btnVendaMercado = new System.Windows.Forms.Button();
            this.lblBotaoVendaMercado = new System.Windows.Forms.Label();
            this.btnCompraMercado = new System.Windows.Forms.Button();
            this.lblBotaoCompraMercado = new System.Windows.Forms.Label();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnLimparConfiguracao = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabConfiguracao.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabConfiguracao);
            this.tabControl1.Controls.Add(this.tabLog);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(733, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // tabConfiguracao
            // 
            this.tabConfiguracao.Controls.Add(this.btnValorPosicaoAberta);
            this.tabConfiguracao.Controls.Add(this.lblValorPosicaoAberta);
            this.tabConfiguracao.Controls.Add(this.btnNumeroContratosAbertos);
            this.tabConfiguracao.Controls.Add(this.lblNumeroDeContratos);
            this.tabConfiguracao.Controls.Add(this.lblMostrarPosicoesNaTela);
            this.tabConfiguracao.Controls.Add(this.btnMostrarPosicoes);
            this.tabConfiguracao.Controls.Add(this.btnTomarPosicao);
            this.tabConfiguracao.Controls.Add(this.lblIndicadorParaTomarPosicao);
            this.tabConfiguracao.Controls.Add(this.btnZerarMercado);
            this.tabConfiguracao.Controls.Add(this.lblBotaoZerarPosicao);
            this.tabConfiguracao.Controls.Add(this.btnVendaMercado);
            this.tabConfiguracao.Controls.Add(this.lblBotaoVendaMercado);
            this.tabConfiguracao.Controls.Add(this.btnCompraMercado);
            this.tabConfiguracao.Controls.Add(this.lblBotaoCompraMercado);
            this.tabConfiguracao.Location = new System.Drawing.Point(4, 29);
            this.tabConfiguracao.Name = "tabConfiguracao";
            this.tabConfiguracao.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfiguracao.Size = new System.Drawing.Size(725, 359);
            this.tabConfiguracao.TabIndex = 0;
            this.tabConfiguracao.Text = "Configuracao";
            this.tabConfiguracao.UseVisualStyleBackColor = true;
            // 
            // btnValorPosicaoAberta
            // 
            this.btnValorPosicaoAberta.Image = global::ProfitChartBot.Properties.Resources.crosshair_icon_173899;
            this.btnValorPosicaoAberta.Location = new System.Drawing.Point(19, 108);
            this.btnValorPosicaoAberta.Name = "btnValorPosicaoAberta";
            this.btnValorPosicaoAberta.Size = new System.Drawing.Size(32, 32);
            this.btnValorPosicaoAberta.TabIndex = 13;
            this.btnValorPosicaoAberta.UseVisualStyleBackColor = true;
            this.btnValorPosicaoAberta.Click += new System.EventHandler(this.btnValorPosicaoAberta_Click);
            // 
            // lblValorPosicaoAberta
            // 
            this.lblValorPosicaoAberta.AutoSize = true;
            this.lblValorPosicaoAberta.ForeColor = System.Drawing.Color.Red;
            this.lblValorPosicaoAberta.Location = new System.Drawing.Point(57, 114);
            this.lblValorPosicaoAberta.Name = "lblValorPosicaoAberta";
            this.lblValorPosicaoAberta.Size = new System.Drawing.Size(213, 20);
            this.lblValorPosicaoAberta.TabIndex = 12;
            this.lblValorPosicaoAberta.Text = "Valor em R$, Posicao Aberta";
            // 
            // btnNumeroContratosAbertos
            // 
            this.btnNumeroContratosAbertos.Image = global::ProfitChartBot.Properties.Resources.crosshair_icon_173899;
            this.btnNumeroContratosAbertos.Location = new System.Drawing.Point(286, 108);
            this.btnNumeroContratosAbertos.Name = "btnNumeroContratosAbertos";
            this.btnNumeroContratosAbertos.Size = new System.Drawing.Size(32, 32);
            this.btnNumeroContratosAbertos.TabIndex = 11;
            this.btnNumeroContratosAbertos.UseVisualStyleBackColor = true;
            this.btnNumeroContratosAbertos.Click += new System.EventHandler(this.btnNumeroContratosAbertos_Click);
            // 
            // lblNumeroDeContratos
            // 
            this.lblNumeroDeContratos.AutoSize = true;
            this.lblNumeroDeContratos.ForeColor = System.Drawing.Color.Red;
            this.lblNumeroDeContratos.Location = new System.Drawing.Point(324, 114);
            this.lblNumeroDeContratos.Name = "lblNumeroDeContratos";
            this.lblNumeroDeContratos.Size = new System.Drawing.Size(221, 20);
            this.lblNumeroDeContratos.TabIndex = 10;
            this.lblNumeroDeContratos.Text = "Numero de Contratos Abertos";
            // 
            // lblMostrarPosicoesNaTela
            // 
            this.lblMostrarPosicoesNaTela.AutoSize = true;
            this.lblMostrarPosicoesNaTela.ForeColor = System.Drawing.Color.Black;
            this.lblMostrarPosicoesNaTela.Location = new System.Drawing.Point(57, 161);
            this.lblMostrarPosicoesNaTela.Name = "lblMostrarPosicoesNaTela";
            this.lblMostrarPosicoesNaTela.Size = new System.Drawing.Size(187, 20);
            this.lblMostrarPosicoesNaTela.TabIndex = 9;
            this.lblMostrarPosicoesNaTela.Text = "Mostrar Posicoes na Tela";
            // 
            // btnMostrarPosicoes
            // 
            this.btnMostrarPosicoes.Image = global::ProfitChartBot.Properties.Resources.fullscreen_12_32;
            this.btnMostrarPosicoes.Location = new System.Drawing.Point(19, 155);
            this.btnMostrarPosicoes.Name = "btnMostrarPosicoes";
            this.btnMostrarPosicoes.Size = new System.Drawing.Size(32, 32);
            this.btnMostrarPosicoes.TabIndex = 8;
            this.btnMostrarPosicoes.UseVisualStyleBackColor = true;
            this.btnMostrarPosicoes.Click += new System.EventHandler(this.btnMostrarPosicoes_Click);
            // 
            // btnTomarPosicao
            // 
            this.btnTomarPosicao.Image = global::ProfitChartBot.Properties.Resources.crosshair_icon_173899;
            this.btnTomarPosicao.Location = new System.Drawing.Point(19, 57);
            this.btnTomarPosicao.Name = "btnTomarPosicao";
            this.btnTomarPosicao.Size = new System.Drawing.Size(32, 32);
            this.btnTomarPosicao.TabIndex = 7;
            this.btnTomarPosicao.UseVisualStyleBackColor = true;
            this.btnTomarPosicao.Click += new System.EventHandler(this.btnTomarPosicao_Click);
            // 
            // lblIndicadorParaTomarPosicao
            // 
            this.lblIndicadorParaTomarPosicao.AutoSize = true;
            this.lblIndicadorParaTomarPosicao.ForeColor = System.Drawing.Color.Red;
            this.lblIndicadorParaTomarPosicao.Location = new System.Drawing.Point(57, 63);
            this.lblIndicadorParaTomarPosicao.Name = "lblIndicadorParaTomarPosicao";
            this.lblIndicadorParaTomarPosicao.Size = new System.Drawing.Size(220, 20);
            this.lblIndicadorParaTomarPosicao.TabIndex = 6;
            this.lblIndicadorParaTomarPosicao.Text = "Indicador para Tomar Posicao";
            // 
            // btnZerarMercado
            // 
            this.btnZerarMercado.Image = global::ProfitChartBot.Properties.Resources.crosshair_icon_173899;
            this.btnZerarMercado.Location = new System.Drawing.Point(286, 57);
            this.btnZerarMercado.Name = "btnZerarMercado";
            this.btnZerarMercado.Size = new System.Drawing.Size(32, 32);
            this.btnZerarMercado.TabIndex = 5;
            this.btnZerarMercado.UseVisualStyleBackColor = true;
            this.btnZerarMercado.Click += new System.EventHandler(this.btnZerarMercado_Click);
            // 
            // lblBotaoZerarPosicao
            // 
            this.lblBotaoZerarPosicao.AutoSize = true;
            this.lblBotaoZerarPosicao.ForeColor = System.Drawing.Color.Red;
            this.lblBotaoZerarPosicao.Location = new System.Drawing.Point(324, 63);
            this.lblBotaoZerarPosicao.Name = "lblBotaoZerarPosicao";
            this.lblBotaoZerarPosicao.Size = new System.Drawing.Size(176, 20);
            this.lblBotaoZerarPosicao.TabIndex = 4;
            this.lblBotaoZerarPosicao.Text = "Botao de Zerar Posicao";
            // 
            // btnVendaMercado
            // 
            this.btnVendaMercado.Image = global::ProfitChartBot.Properties.Resources.crosshair_icon_173899;
            this.btnVendaMercado.Location = new System.Drawing.Point(286, 12);
            this.btnVendaMercado.Name = "btnVendaMercado";
            this.btnVendaMercado.Size = new System.Drawing.Size(32, 32);
            this.btnVendaMercado.TabIndex = 3;
            this.btnVendaMercado.UseVisualStyleBackColor = true;
            this.btnVendaMercado.Click += new System.EventHandler(this.btnVendaMercado_Click);
            // 
            // lblBotaoVendaMercado
            // 
            this.lblBotaoVendaMercado.AutoSize = true;
            this.lblBotaoVendaMercado.ForeColor = System.Drawing.Color.Red;
            this.lblBotaoVendaMercado.Location = new System.Drawing.Point(324, 18);
            this.lblBotaoVendaMercado.Name = "lblBotaoVendaMercado";
            this.lblBotaoVendaMercado.Size = new System.Drawing.Size(191, 20);
            this.lblBotaoVendaMercado.TabIndex = 2;
            this.lblBotaoVendaMercado.Text = "Botao de Venda Mercado";
            // 
            // btnCompraMercado
            // 
            this.btnCompraMercado.Image = global::ProfitChartBot.Properties.Resources.crosshair_icon_173899;
            this.btnCompraMercado.Location = new System.Drawing.Point(19, 12);
            this.btnCompraMercado.Name = "btnCompraMercado";
            this.btnCompraMercado.Size = new System.Drawing.Size(32, 32);
            this.btnCompraMercado.TabIndex = 1;
            this.btnCompraMercado.UseVisualStyleBackColor = true;
            this.btnCompraMercado.Click += new System.EventHandler(this.btnCompraMercado_Click);
            // 
            // lblBotaoCompraMercado
            // 
            this.lblBotaoCompraMercado.AutoSize = true;
            this.lblBotaoCompraMercado.ForeColor = System.Drawing.Color.Red;
            this.lblBotaoCompraMercado.Location = new System.Drawing.Point(57, 18);
            this.lblBotaoCompraMercado.Name = "lblBotaoCompraMercado";
            this.lblBotaoCompraMercado.Size = new System.Drawing.Size(200, 20);
            this.lblBotaoCompraMercado.TabIndex = 0;
            this.lblBotaoCompraMercado.Text = "Botao de Compra Mercado";
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.listView1);
            this.tabLog.Location = new System.Drawing.Point(4, 29);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(725, 359);
            this.tabLog.TabIndex = 1;
            this.tabLog.Text = "Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(719, 353);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(631, 410);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(114, 37);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Enabled = false;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(489, 410);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(120, 37);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnLimparConfiguracao
            // 
            this.btnLimparConfiguracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparConfiguracao.Location = new System.Drawing.Point(16, 411);
            this.btnLimparConfiguracao.Name = "btnLimparConfiguracao";
            this.btnLimparConfiguracao.Size = new System.Drawing.Size(185, 37);
            this.btnLimparConfiguracao.TabIndex = 3;
            this.btnLimparConfiguracao.Text = "Limpar Configuracao";
            this.btnLimparConfiguracao.UseVisualStyleBackColor = true;
            this.btnLimparConfiguracao.Click += new System.EventHandler(this.btnLimparConfiguracao_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 460);
            this.Controls.Add(this.btnLimparConfiguracao);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfitChartPro";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabConfiguracao.ResumeLayout(false);
            this.tabConfiguracao.PerformLayout();
            this.tabLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConfiguracao;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblBotaoCompraMercado;
        private System.Windows.Forms.Button btnCompraMercado;
        private System.Windows.Forms.Button btnTomarPosicao;
        private System.Windows.Forms.Label lblIndicadorParaTomarPosicao;
        private System.Windows.Forms.Button btnZerarMercado;
        private System.Windows.Forms.Label lblBotaoZerarPosicao;
        private System.Windows.Forms.Button btnVendaMercado;
        private System.Windows.Forms.Label lblBotaoVendaMercado;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblMostrarPosicoesNaTela;
        private System.Windows.Forms.Button btnMostrarPosicoes;
        private System.Windows.Forms.Button btnValorPosicaoAberta;
        private System.Windows.Forms.Label lblValorPosicaoAberta;
        private System.Windows.Forms.Button btnNumeroContratosAbertos;
        private System.Windows.Forms.Label lblNumeroDeContratos;
        private System.Windows.Forms.Button btnLimparConfiguracao;
    }
}

