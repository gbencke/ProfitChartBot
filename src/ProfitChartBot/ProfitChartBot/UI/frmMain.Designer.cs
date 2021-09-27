
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBotaoCompraMercado = new System.Windows.Forms.Label();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMostrarPosicoes = new System.Windows.Forms.Button();
            this.btnTomarPosicao = new System.Windows.Forms.Button();
            this.btnZerarMercado = new System.Windows.Forms.Button();
            this.btnVendaMercado = new System.Windows.Forms.Button();
            this.btnCompraMercado = new System.Windows.Forms.Button();
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
            this.tabConfiguracao.Controls.Add(this.label4);
            this.tabConfiguracao.Controls.Add(this.btnMostrarPosicoes);
            this.tabConfiguracao.Controls.Add(this.btnTomarPosicao);
            this.tabConfiguracao.Controls.Add(this.label3);
            this.tabConfiguracao.Controls.Add(this.btnZerarMercado);
            this.tabConfiguracao.Controls.Add(this.label2);
            this.tabConfiguracao.Controls.Add(this.btnVendaMercado);
            this.tabConfiguracao.Controls.Add(this.label1);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(57, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Indicador para Tomar Posicao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(324, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Botao de Zerar Posicao";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(324, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Botao de Venda Mercado";
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
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(489, 410);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(120, 37);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(57, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mostrar Posicoes na Tela";
            // 
            // btnMostrarPosicoes
            // 
            this.btnMostrarPosicoes.Image = global::ProfitChartBot.Properties.Resources.fullscreen_12_32;
            this.btnMostrarPosicoes.Location = new System.Drawing.Point(19, 106);
            this.btnMostrarPosicoes.Name = "btnMostrarPosicoes";
            this.btnMostrarPosicoes.Size = new System.Drawing.Size(32, 32);
            this.btnMostrarPosicoes.TabIndex = 8;
            this.btnMostrarPosicoes.UseVisualStyleBackColor = true;
            // 
            // btnTomarPosicao
            // 
            this.btnTomarPosicao.Image = global::ProfitChartBot.Properties.Resources.crosshair_icon_173899;
            this.btnTomarPosicao.Location = new System.Drawing.Point(19, 57);
            this.btnTomarPosicao.Name = "btnTomarPosicao";
            this.btnTomarPosicao.Size = new System.Drawing.Size(32, 32);
            this.btnTomarPosicao.TabIndex = 7;
            this.btnTomarPosicao.UseVisualStyleBackColor = true;
            // 
            // btnZerarMercado
            // 
            this.btnZerarMercado.Image = global::ProfitChartBot.Properties.Resources.crosshair_icon_173899;
            this.btnZerarMercado.Location = new System.Drawing.Point(286, 57);
            this.btnZerarMercado.Name = "btnZerarMercado";
            this.btnZerarMercado.Size = new System.Drawing.Size(32, 32);
            this.btnZerarMercado.TabIndex = 5;
            this.btnZerarMercado.UseVisualStyleBackColor = true;
            // 
            // btnVendaMercado
            // 
            this.btnVendaMercado.Image = global::ProfitChartBot.Properties.Resources.crosshair_icon_173899;
            this.btnVendaMercado.Location = new System.Drawing.Point(286, 12);
            this.btnVendaMercado.Name = "btnVendaMercado";
            this.btnVendaMercado.Size = new System.Drawing.Size(32, 32);
            this.btnVendaMercado.TabIndex = 3;
            this.btnVendaMercado.UseVisualStyleBackColor = true;
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 460);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnZerarMercado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVendaMercado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMostrarPosicoes;
    }
}

