namespace Algoritmos_de_reemplazo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosEjecucionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeProcesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Aprocesos = new System.Windows.Forms.ToolStripMenuItem();
            this.aUnoProc = new System.Windows.Forms.ToolStripMenuItem();
            this.aVariosProc = new System.Windows.Forms.ToolStripMenuItem();
            this.CantidadPr = new System.Windows.Forms.ToolStripTextBox();
            this.definirCantidadDePaginasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ambitoDeReemplazoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AmRglobal = new System.Windows.Forms.ToolStripMenuItem();
            this.AmRlocal = new System.Windows.Forms.ToolStripMenuItem();
            this.definirTablasDePaginasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Adirecciones = new System.Windows.Forms.ToolStripMenuItem();
            this.meotodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fIFOTM = new System.Windows.Forms.ToolStripMenuItem();
            this.optimoTm = new System.Windows.Forms.ToolStripMenuItem();
            this.lRUTM = new System.Windows.Forms.ToolStripMenuItem();
            this.segundaOTM = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Idproceso = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DireccionL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngrCadena = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuCreferencia = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verMapaDeMemoriaEnEsteInstanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTablasDePaginasEnEsteInstatnteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MenuCreferencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tamaño de cada pagina";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.datosEjecucionToolStripMenuItem,
            this.meotodToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(300, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.iniciarVirtual);
            // 
            // datosEjecucionToolStripMenuItem
            // 
            this.datosEjecucionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantidadDeProcesosToolStripMenuItem});
            this.datosEjecucionToolStripMenuItem.Name = "datosEjecucionToolStripMenuItem";
            this.datosEjecucionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.datosEjecucionToolStripMenuItem.Text = "Configuracion";
            // 
            // cantidadDeProcesosToolStripMenuItem
            // 
            this.cantidadDeProcesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Aprocesos,
            this.Adirecciones});
            this.cantidadDeProcesosToolStripMenuItem.Name = "cantidadDeProcesosToolStripMenuItem";
            this.cantidadDeProcesosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cantidadDeProcesosToolStripMenuItem.Text = "Tipo de referencias";
            // 
            // Aprocesos
            // 
            this.Aprocesos.Checked = true;
            this.Aprocesos.CheckOnClick = true;
            this.Aprocesos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Aprocesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aUnoProc,
            this.aVariosProc,
            this.definirTablasDePaginasToolStripMenuItem});
            this.Aprocesos.Name = "Aprocesos";
            this.Aprocesos.Size = new System.Drawing.Size(185, 22);
            this.Aprocesos.Text = "A procesos";
            this.Aprocesos.Click += new System.EventHandler(this.TipoRef_CLICK);
            // 
            // aUnoProc
            // 
            this.aUnoProc.CheckOnClick = true;
            this.aUnoProc.Name = "aUnoProc";
            this.aUnoProc.Size = new System.Drawing.Size(203, 22);
            this.aUnoProc.Text = "A uno";
            this.aUnoProc.Click += new System.EventHandler(this.CantProcR_Click);
            // 
            // aVariosProc
            // 
            this.aVariosProc.CheckOnClick = true;
            this.aVariosProc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CantidadPr,
            this.definirCantidadDePaginasToolStripMenuItem,
            this.ambitoDeReemplazoToolStripMenuItem});
            this.aVariosProc.Name = "aVariosProc";
            this.aVariosProc.Size = new System.Drawing.Size(203, 22);
            this.aVariosProc.Text = "A varios";
            this.aVariosProc.Click += new System.EventHandler(this.CantProcR_Click);
            // 
            // CantidadPr
            // 
            this.CantidadPr.Name = "CantidadPr";
            this.CantidadPr.Size = new System.Drawing.Size(100, 23);
            // 
            // definirCantidadDePaginasToolStripMenuItem
            // 
            this.definirCantidadDePaginasToolStripMenuItem.Name = "definirCantidadDePaginasToolStripMenuItem";
            this.definirCantidadDePaginasToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.definirCantidadDePaginasToolStripMenuItem.Text = "Definir cantidad de paginas";
            // 
            // ambitoDeReemplazoToolStripMenuItem
            // 
            this.ambitoDeReemplazoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AmRglobal,
            this.AmRlocal});
            this.ambitoDeReemplazoToolStripMenuItem.Name = "ambitoDeReemplazoToolStripMenuItem";
            this.ambitoDeReemplazoToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.ambitoDeReemplazoToolStripMenuItem.Text = "Ambito de reemplazo";
            // 
            // AmRglobal
            // 
            this.AmRglobal.Checked = true;
            this.AmRglobal.CheckOnClick = true;
            this.AmRglobal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AmRglobal.Name = "AmRglobal";
            this.AmRglobal.Size = new System.Drawing.Size(152, 22);
            this.AmRglobal.Text = "Global";
            this.AmRglobal.Click += new System.EventHandler(this.AmREEM_Click);
            // 
            // AmRlocal
            // 
            this.AmRlocal.CheckOnClick = true;
            this.AmRlocal.Name = "AmRlocal";
            this.AmRlocal.Size = new System.Drawing.Size(152, 22);
            this.AmRlocal.Text = "Local";
            this.AmRlocal.Click += new System.EventHandler(this.AmREEM_Click);
            // 
            // definirTablasDePaginasToolStripMenuItem
            // 
            this.definirTablasDePaginasToolStripMenuItem.Name = "definirTablasDePaginasToolStripMenuItem";
            this.definirTablasDePaginasToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.definirTablasDePaginasToolStripMenuItem.Text = "Definir tablas de paginas";
            // 
            // Adirecciones
            // 
            this.Adirecciones.CheckOnClick = true;
            this.Adirecciones.Name = "Adirecciones";
            this.Adirecciones.Size = new System.Drawing.Size(185, 22);
            this.Adirecciones.Text = "A direcciones logicas";
            this.Adirecciones.Click += new System.EventHandler(this.TipoRef_CLICK);
            // 
            // meotodToolStripMenuItem
            // 
            this.meotodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIFOTM,
            this.optimoTm,
            this.lRUTM,
            this.segundaOTM});
            this.meotodToolStripMenuItem.Name = "meotodToolStripMenuItem";
            this.meotodToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.meotodToolStripMenuItem.Text = "Algoritmo de reemplazo";
            // 
            // fIFOTM
            // 
            this.fIFOTM.CheckOnClick = true;
            this.fIFOTM.Name = "fIFOTM";
            this.fIFOTM.Size = new System.Drawing.Size(189, 22);
            this.fIFOTM.Text = "FIFO";
            this.fIFOTM.Click += new System.EventHandler(this.MetodoReemp_Click);
            // 
            // optimoTm
            // 
            this.optimoTm.CheckOnClick = true;
            this.optimoTm.Name = "optimoTm";
            this.optimoTm.Size = new System.Drawing.Size(189, 22);
            this.optimoTm.Text = "Optimo";
            this.optimoTm.Click += new System.EventHandler(this.MetodoReemp_Click);
            // 
            // lRUTM
            // 
            this.lRUTM.Checked = true;
            this.lRUTM.CheckOnClick = true;
            this.lRUTM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lRUTM.Name = "lRUTM";
            this.lRUTM.Size = new System.Drawing.Size(189, 22);
            this.lRUTM.Text = "LRU";
            this.lRUTM.Click += new System.EventHandler(this.MetodoReemp_Click);
            // 
            // segundaOTM
            // 
            this.segundaOTM.CheckOnClick = true;
            this.segundaOTM.Name = "segundaOTM";
            this.segundaOTM.Size = new System.Drawing.Size(189, 22);
            this.segundaOTM.Text = "Segunda oportunidad";
            this.segundaOTM.Click += new System.EventHandler(this.MetodoReemp_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad de paginas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idproceso,
            this.DireccionL});
            this.dataGridView1.Location = new System.Drawing.Point(16, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(271, 180);
            this.dataGridView1.TabIndex = 5;
            // 
            // Idproceso
            // 
            this.Idproceso.HeaderText = "Idproceso";
            this.Idproceso.Name = "Idproceso";
            // 
            // DireccionL
            // 
            this.DireccionL.HeaderText = "Direccion Logica";
            this.DireccionL.Name = "DireccionL";
            // 
            // IngrCadena
            // 
            this.IngrCadena.Location = new System.Drawing.Point(61, 129);
            this.IngrCadena.Name = "IngrCadena";
            this.IngrCadena.Size = new System.Drawing.Size(181, 23);
            this.IngrCadena.TabIndex = 6;
            this.IngrCadena.Text = "Ingresar cadena de referencias";
            this.IngrCadena.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad de fallos de pagina";
            // 
            // MenuCreferencia
            // 
            this.MenuCreferencia.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verMapaDeMemoriaEnEsteInstanteToolStripMenuItem,
            this.verTablasDePaginasEnEsteInstatnteToolStripMenuItem});
            this.MenuCreferencia.Name = "MenuCreferencia";
            this.MenuCreferencia.Size = new System.Drawing.Size(276, 48);
            // 
            // verMapaDeMemoriaEnEsteInstanteToolStripMenuItem
            // 
            this.verMapaDeMemoriaEnEsteInstanteToolStripMenuItem.Name = "verMapaDeMemoriaEnEsteInstanteToolStripMenuItem";
            this.verMapaDeMemoriaEnEsteInstanteToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.verMapaDeMemoriaEnEsteInstanteToolStripMenuItem.Text = "Ver mapa de memoria en este instante";
            // 
            // verTablasDePaginasEnEsteInstatnteToolStripMenuItem
            // 
            this.verTablasDePaginasEnEsteInstatnteToolStripMenuItem.Name = "verTablasDePaginasEnEsteInstatnteToolStripMenuItem";
            this.verTablasDePaginasEnEsteInstatnteToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.verTablasDePaginasEnEsteInstatnteToolStripMenuItem.Text = "Ver tablas de paginas en este instatnte";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tratar cadena de referencias";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Tratar cadena de referencias";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 428);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IngrCadena);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Algoritmos de reemplazo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MenuCreferencia.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosEjecucionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeProcesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Aprocesos;
        private System.Windows.Forms.ToolStripMenuItem aUnoProc;
        private System.Windows.Forms.ToolStripMenuItem aVariosProc;
        private System.Windows.Forms.ToolStripMenuItem Adirecciones;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripTextBox CantidadPr;
        private System.Windows.Forms.ToolStripMenuItem definirTablasDePaginasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem definirCantidadDePaginasToolStripMenuItem;
        private System.Windows.Forms.Button IngrCadena;
        private System.Windows.Forms.ToolStripMenuItem meotodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fIFOTM;
        private System.Windows.Forms.ToolStripMenuItem optimoTm;
        private System.Windows.Forms.ToolStripMenuItem lRUTM;
        private System.Windows.Forms.ToolStripMenuItem segundaOTM;
        private System.Windows.Forms.DataGridViewComboBoxColumn Idproceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip MenuCreferencia;
        private System.Windows.Forms.ToolStripMenuItem verMapaDeMemoriaEnEsteInstanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTablasDePaginasEnEsteInstatnteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ambitoDeReemplazoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AmRglobal;
        private System.Windows.Forms.ToolStripMenuItem AmRlocal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

