namespace Algoritmos_de_reemplazo
{
    partial class VisualizadorTP
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
            this.TablaPA = new System.Windows.Forms.DataGridView();
            this.Idpagina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BValido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListaProc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPA)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaPA
            // 
            this.TablaPA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TablaPA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablaPA.BackgroundColor = System.Drawing.Color.Navy;
            this.TablaPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaPA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idpagina,
            this.Marco,
            this.IntCarga,
            this.BValido,
            this.Contador,
            this.BitR,
            this.BitM});
            this.TablaPA.Location = new System.Drawing.Point(12, 62);
            this.TablaPA.Name = "TablaPA";
            this.TablaPA.Size = new System.Drawing.Size(503, 150);
            this.TablaPA.TabIndex = 0;
            // 
            // Idpagina
            // 
            this.Idpagina.HeaderText = "Idpagina";
            this.Idpagina.Name = "Idpagina";
            this.Idpagina.Width = 73;
            // 
            // Marco
            // 
            this.Marco.HeaderText = "Marco";
            this.Marco.Name = "Marco";
            this.Marco.Width = 62;
            // 
            // IntCarga
            // 
            this.IntCarga.HeaderText = "Inst. Carga";
            this.IntCarga.Name = "IntCarga";
            this.IntCarga.Width = 83;
            // 
            // BValido
            // 
            this.BValido.HeaderText = "Bit Valido";
            this.BValido.Name = "BValido";
            this.BValido.Width = 76;
            // 
            // Contador
            // 
            this.Contador.HeaderText = "Contador";
            this.Contador.Name = "Contador";
            this.Contador.Width = 75;
            // 
            // BitR
            // 
            this.BitR.HeaderText = "R";
            this.BitR.Name = "BitR";
            this.BitR.Width = 40;
            // 
            // BitM
            // 
            this.BitM.HeaderText = "M";
            this.BitM.Name = "BitM";
            this.BitM.Width = 41;
            // 
            // ListaProc
            // 
            this.ListaProc.BackColor = System.Drawing.Color.Navy;
            this.ListaProc.ForeColor = System.Drawing.Color.Orange;
            this.ListaProc.FormattingEnabled = true;
            this.ListaProc.Location = new System.Drawing.Point(249, 23);
            this.ListaProc.Name = "ListaProc";
            this.ListaProc.Size = new System.Drawing.Size(121, 21);
            this.ListaProc.TabIndex = 1;
            this.ListaProc.SelectedIndexChanged += new System.EventHandler(this.ListaProc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proceso";
            // 
            // VisualizadorTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(524, 224);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListaProc);
            this.Controls.Add(this.TablaPA);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "VisualizadorTP";
            this.Text = "Tabla de pagina";
            this.Load += new System.EventHandler(this.TablasPaginascs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaPA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaPA;
        private System.Windows.Forms.ComboBox ListaProc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idpagina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marco;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn BValido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contador;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitR;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitM;
    }
}