namespace Algoritmos_de_reemplazo
{
    partial class MapaMemoria
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
            this.MapaMemT = new System.Windows.Forms.DataGridView();
            this.IdMarco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MapaMemT)).BeginInit();
            this.SuspendLayout();
            // 
            // MapaMemT
            // 
            this.MapaMemT.BackgroundColor = System.Drawing.Color.Navy;
            this.MapaMemT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MapaMemT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMarco,
            this.Proceso});
            this.MapaMemT.Location = new System.Drawing.Point(12, 12);
            this.MapaMemT.Name = "MapaMemT";
            this.MapaMemT.Size = new System.Drawing.Size(257, 186);
            this.MapaMemT.TabIndex = 0;
            // 
            // IdMarco
            // 
            this.IdMarco.HeaderText = "Marco";
            this.IdMarco.Name = "IdMarco";
            // 
            // Proceso
            // 
            this.Proceso.HeaderText = "Proceso";
            this.Proceso.Name = "Proceso";
            // 
            // MapaMemoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(281, 212);
            this.Controls.Add(this.MapaMemT);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "MapaMemoria";
            this.Text = "Mapa de Memoria";
            ((System.ComponentModel.ISupportInitialize)(this.MapaMemT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMarco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proceso;
        public System.Windows.Forms.DataGridView MapaMemT;
    }
}