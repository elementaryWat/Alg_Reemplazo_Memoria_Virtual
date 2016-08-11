namespace Algoritmos_de_reemplazo
{
    partial class Datos_procesos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_paginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_proceso,
            this.Cantidad_paginas});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(230, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // Id_proceso
            // 
            this.Id_proceso.HeaderText = "Id_proceso";
            this.Id_proceso.Name = "Id_proceso";
            // 
            // Cantidad_paginas
            // 
            this.Cantidad_paginas.HeaderText = "Cantidad de paginas";
            this.Cantidad_paginas.Name = "Cantidad_paginas";
            // 
            // Datos_procesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 171);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Datos_procesos";
            this.Text = "Datos_procesos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_paginas;
    }
}