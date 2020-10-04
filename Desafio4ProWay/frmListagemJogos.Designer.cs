namespace Desafio4ProWay
{
    partial class frmListagemJogos
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
            this.btnAdicionarJogo = new System.Windows.Forms.Button();
            this.dgJogos = new System.Windows.Forms.DataGridView();
            this.Jogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MínimoDaTemporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MáximoDaTemporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuebraRecordeMínimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuebraRecordeMáximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgJogos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionarJogo
            // 
            this.btnAdicionarJogo.Location = new System.Drawing.Point(552, 54);
            this.btnAdicionarJogo.Name = "btnAdicionarJogo";
            this.btnAdicionarJogo.Size = new System.Drawing.Size(137, 23);
            this.btnAdicionarJogo.TabIndex = 0;
            this.btnAdicionarJogo.Text = "Adicionar Jogo";
            this.btnAdicionarJogo.UseVisualStyleBackColor = true;
            this.btnAdicionarJogo.Click += new System.EventHandler(this.btnAdicionarJogo_Click);
            // 
            // dgJogos
            // 
            this.dgJogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgJogos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jogo,
            this.Placar,
            this.MínimoDaTemporada,
            this.MáximoDaTemporada,
            this.QuebraRecordeMínimo,
            this.QuebraRecordeMáximo});
            this.dgJogos.Location = new System.Drawing.Point(45, 142);
            this.dgJogos.Name = "dgJogos";
            this.dgJogos.Size = new System.Drawing.Size(644, 270);
            this.dgJogos.TabIndex = 1;
            // 
            // Jogo
            // 
            this.Jogo.DataPropertyName = "Codigo";
            this.Jogo.HeaderText = "Jogo";
            this.Jogo.Name = "Jogo";
            // 
            // Placar
            // 
            this.Placar.DataPropertyName = "Placar";
            this.Placar.HeaderText = "Placar";
            this.Placar.Name = "Placar";
            // 
            // MínimoDaTemporada
            // 
            this.MínimoDaTemporada.DataPropertyName = "MinimoTemporada";
            this.MínimoDaTemporada.HeaderText = "Mínimo da temporada";
            this.MínimoDaTemporada.Name = "MínimoDaTemporada";
            // 
            // MáximoDaTemporada
            // 
            this.MáximoDaTemporada.DataPropertyName = "MaximoTemporada";
            this.MáximoDaTemporada.HeaderText = "Máximo da temporada";
            this.MáximoDaTemporada.Name = "MáximoDaTemporada";
            // 
            // QuebraRecordeMínimo
            // 
            this.QuebraRecordeMínimo.DataPropertyName = "QuebraRecordeMinimo";
            this.QuebraRecordeMínimo.HeaderText = "Quebra recorde min.";
            this.QuebraRecordeMínimo.Name = "QuebraRecordeMínimo";
            // 
            // QuebraRecordeMáximo
            // 
            this.QuebraRecordeMáximo.DataPropertyName = "QuebraRecordeMaximo";
            this.QuebraRecordeMáximo.HeaderText = "Quebra recorde máx.";
            this.QuebraRecordeMáximo.Name = "QuebraRecordeMáximo";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(552, 99);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(137, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmListagemJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 436);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgJogos);
            this.Controls.Add(this.btnAdicionarJogo);
            this.Name = "frmListagemJogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem Jogos";
            this.Load += new System.EventHandler(this.frmListagemJogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgJogos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarJogo;
        private System.Windows.Forms.DataGridView dgJogos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placar;
        private System.Windows.Forms.DataGridViewTextBoxColumn MínimoDaTemporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn MáximoDaTemporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuebraRecordeMínimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuebraRecordeMáximo;
        private System.Windows.Forms.Button btnReset;
    }
}