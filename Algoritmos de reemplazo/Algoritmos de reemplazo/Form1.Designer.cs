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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TamPagina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tratarCadenaDeReferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.Cantpaginas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CadenaRef = new System.Windows.Forms.DataGridView();
            this.Idproceso = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DireccionL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirFisica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FPC = new System.Windows.Forms.Label();
            this.MenuCreferencia = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verMapaDeMemoriaEnEsteInstanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTablasDePaginasEnEsteInstatnteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FPE = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CadenaRef)).BeginInit();
            this.MenuCreferencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // TamPagina
            // 
            this.TamPagina.Location = new System.Drawing.Point(171, 34);
            this.TamPagina.Name = "TamPagina";
            this.TamPagina.Size = new System.Drawing.Size(100, 20);
            this.TamPagina.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(42, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tamaño de cada pagina";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Orange;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.datosEjecucionToolStripMenuItem,
            this.meotodToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.iniciarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tratarCadenaDeReferenciasToolStripMenuItem});
            this.iniciarToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            // 
            // tratarCadenaDeReferenciasToolStripMenuItem
            // 
            this.tratarCadenaDeReferenciasToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.tratarCadenaDeReferenciasToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.tratarCadenaDeReferenciasToolStripMenuItem.Name = "tratarCadenaDeReferenciasToolStripMenuItem";
            this.tratarCadenaDeReferenciasToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.tratarCadenaDeReferenciasToolStripMenuItem.Text = "Tratar Cadena de Referencias";
            this.tratarCadenaDeReferenciasToolStripMenuItem.Click += new System.EventHandler(this.tratarCadenaDeReferenciasToolStripMenuItem_Click);
            // 
            // datosEjecucionToolStripMenuItem
            // 
            this.datosEjecucionToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.datosEjecucionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantidadDeProcesosToolStripMenuItem});
            this.datosEjecucionToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.datosEjecucionToolStripMenuItem.Name = "datosEjecucionToolStripMenuItem";
            this.datosEjecucionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.datosEjecucionToolStripMenuItem.Text = "Configuracion";
            // 
            // cantidadDeProcesosToolStripMenuItem
            // 
            this.cantidadDeProcesosToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.cantidadDeProcesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Aprocesos,
            this.Adirecciones});
            this.cantidadDeProcesosToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.cantidadDeProcesosToolStripMenuItem.Name = "cantidadDeProcesosToolStripMenuItem";
            this.cantidadDeProcesosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cantidadDeProcesosToolStripMenuItem.Text = "Tipo de referencias";
            // 
            // Aprocesos
            // 
            this.Aprocesos.BackColor = System.Drawing.Color.Orange;
            this.Aprocesos.Checked = true;
            this.Aprocesos.CheckOnClick = true;
            this.Aprocesos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Aprocesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aUnoProc,
            this.aVariosProc,
            this.definirTablasDePaginasToolStripMenuItem});
            this.Aprocesos.ForeColor = System.Drawing.Color.Navy;
            this.Aprocesos.Name = "Aprocesos";
            this.Aprocesos.Size = new System.Drawing.Size(185, 22);
            this.Aprocesos.Text = "A procesos";
            this.Aprocesos.Click += new System.EventHandler(this.TipoRef_CLICK);
            // 
            // aUnoProc
            // 
            this.aUnoProc.BackColor = System.Drawing.Color.Orange;
            this.aUnoProc.CheckOnClick = true;
            this.aUnoProc.ForeColor = System.Drawing.Color.Navy;
            this.aUnoProc.Name = "aUnoProc";
            this.aUnoProc.Size = new System.Drawing.Size(203, 22);
            this.aUnoProc.Text = "A uno";
            this.aUnoProc.Click += new System.EventHandler(this.CantProcR_Click);
            // 
            // aVariosProc
            // 
            this.aVariosProc.BackColor = System.Drawing.Color.Orange;
            this.aVariosProc.Checked = true;
            this.aVariosProc.CheckOnClick = true;
            this.aVariosProc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aVariosProc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CantidadPr,
            this.definirCantidadDePaginasToolStripMenuItem,
            this.ambitoDeReemplazoToolStripMenuItem});
            this.aVariosProc.ForeColor = System.Drawing.Color.Navy;
            this.aVariosProc.Name = "aVariosProc";
            this.aVariosProc.Size = new System.Drawing.Size(203, 22);
            this.aVariosProc.Text = "A varios";
            this.aVariosProc.Click += new System.EventHandler(this.CantProcR_Click);
            // 
            // CantidadPr
            // 
            this.CantidadPr.Name = "CantidadPr";
            this.CantidadPr.Size = new System.Drawing.Size(100, 23);
            this.CantidadPr.TextChanged += new System.EventHandler(this.CantidadPr_TextChanged);
            // 
            // definirCantidadDePaginasToolStripMenuItem
            // 
            this.definirCantidadDePaginasToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.definirCantidadDePaginasToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.definirCantidadDePaginasToolStripMenuItem.Name = "definirCantidadDePaginasToolStripMenuItem";
            this.definirCantidadDePaginasToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.definirCantidadDePaginasToolStripMenuItem.Text = "Definir cantidad de paginas";
            this.definirCantidadDePaginasToolStripMenuItem.Visible = false;
            // 
            // ambitoDeReemplazoToolStripMenuItem
            // 
            this.ambitoDeReemplazoToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.ambitoDeReemplazoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AmRglobal,
            this.AmRlocal});
            this.ambitoDeReemplazoToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.ambitoDeReemplazoToolStripMenuItem.Name = "ambitoDeReemplazoToolStripMenuItem";
            this.ambitoDeReemplazoToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.ambitoDeReemplazoToolStripMenuItem.Text = "Ambito de reemplazo";
            // 
            // AmRglobal
            // 
            this.AmRglobal.BackColor = System.Drawing.Color.Orange;
            this.AmRglobal.Checked = true;
            this.AmRglobal.CheckOnClick = true;
            this.AmRglobal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AmRglobal.ForeColor = System.Drawing.Color.Navy;
            this.AmRglobal.Name = "AmRglobal";
            this.AmRglobal.Size = new System.Drawing.Size(108, 22);
            this.AmRglobal.Text = "Global";
            this.AmRglobal.Click += new System.EventHandler(this.AmREEM_Click);
            // 
            // AmRlocal
            // 
            this.AmRlocal.BackColor = System.Drawing.Color.Orange;
            this.AmRlocal.CheckOnClick = true;
            this.AmRlocal.ForeColor = System.Drawing.Color.Navy;
            this.AmRlocal.Name = "AmRlocal";
            this.AmRlocal.Size = new System.Drawing.Size(108, 22);
            this.AmRlocal.Text = "Local";
            this.AmRlocal.Click += new System.EventHandler(this.AmREEM_Click);
            // 
            // definirTablasDePaginasToolStripMenuItem
            // 
            this.definirTablasDePaginasToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.definirTablasDePaginasToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.definirTablasDePaginasToolStripMenuItem.Name = "definirTablasDePaginasToolStripMenuItem";
            this.definirTablasDePaginasToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.definirTablasDePaginasToolStripMenuItem.Text = "Definir tablas de paginas";
            this.definirTablasDePaginasToolStripMenuItem.Visible = false;
            this.definirTablasDePaginasToolStripMenuItem.Click += new System.EventHandler(this.definirTablasDePaginasToolStripMenuItem_Click);
            // 
            // Adirecciones
            // 
            this.Adirecciones.BackColor = System.Drawing.Color.Orange;
            this.Adirecciones.CheckOnClick = true;
            this.Adirecciones.ForeColor = System.Drawing.Color.Navy;
            this.Adirecciones.Name = "Adirecciones";
            this.Adirecciones.Size = new System.Drawing.Size(185, 22);
            this.Adirecciones.Text = "A direcciones logicas";
            this.Adirecciones.Click += new System.EventHandler(this.TipoRef_CLICK);
            // 
            // meotodToolStripMenuItem
            // 
            this.meotodToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.meotodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIFOTM,
            this.optimoTm,
            this.lRUTM,
            this.segundaOTM});
            this.meotodToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.meotodToolStripMenuItem.Name = "meotodToolStripMenuItem";
            this.meotodToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.meotodToolStripMenuItem.Text = "Algoritmo de reemplazo";
            this.meotodToolStripMenuItem.Click += new System.EventHandler(this.meotodToolStripMenuItem_Click);
            // 
            // fIFOTM
            // 
            this.fIFOTM.BackColor = System.Drawing.Color.Orange;
            this.fIFOTM.CheckOnClick = true;
            this.fIFOTM.ForeColor = System.Drawing.Color.Navy;
            this.fIFOTM.Name = "fIFOTM";
            this.fIFOTM.Size = new System.Drawing.Size(189, 22);
            this.fIFOTM.Text = "FIFO";
            this.fIFOTM.ToolTipText = "Primera en entrar, Primera en salir";
            this.fIFOTM.Click += new System.EventHandler(this.MetodoReemp_Click);
            // 
            // optimoTm
            // 
            this.optimoTm.BackColor = System.Drawing.Color.Orange;
            this.optimoTm.CheckOnClick = true;
            this.optimoTm.ForeColor = System.Drawing.Color.Navy;
            this.optimoTm.Name = "optimoTm";
            this.optimoTm.Size = new System.Drawing.Size(189, 22);
            this.optimoTm.Text = "Optimo";
            this.optimoTm.ToolTipText = "Se reemplaza la página que no será usada por el mayor período";
            this.optimoTm.Click += new System.EventHandler(this.MetodoReemp_Click);
            // 
            // lRUTM
            // 
            this.lRUTM.BackColor = System.Drawing.Color.Orange;
            this.lRUTM.Checked = true;
            this.lRUTM.CheckOnClick = true;
            this.lRUTM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lRUTM.ForeColor = System.Drawing.Color.Navy;
            this.lRUTM.Name = "lRUTM";
            this.lRUTM.Size = new System.Drawing.Size(189, 22);
            this.lRUTM.Text = "LRU";
            this.lRUTM.ToolTipText = "Selecciona como candidata la pagina que no fue usada por mas tiempo";
            this.lRUTM.Click += new System.EventHandler(this.MetodoReemp_Click);
            // 
            // segundaOTM
            // 
            this.segundaOTM.BackColor = System.Drawing.Color.Orange;
            this.segundaOTM.CheckOnClick = true;
            this.segundaOTM.ForeColor = System.Drawing.Color.Navy;
            this.segundaOTM.Name = "segundaOTM";
            this.segundaOTM.Size = new System.Drawing.Size(189, 22);
            this.segundaOTM.Text = "Segunda oportunidad";
            this.segundaOTM.Visible = false;
            this.segundaOTM.Click += new System.EventHandler(this.MetodoReemp_Click);
            // 
            // Cantpaginas
            // 
            this.Cantpaginas.Location = new System.Drawing.Point(171, 70);
            this.Cantpaginas.Name = "Cantpaginas";
            this.Cantpaginas.Size = new System.Drawing.Size(100, 20);
            this.Cantpaginas.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(61, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad de paginas";
            // 
            // CadenaRef
            // 
            this.CadenaRef.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CadenaRef.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.CadenaRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CadenaRef.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idproceso,
            this.DireccionL,
            this.DirFisica});
            this.CadenaRef.Location = new System.Drawing.Point(21, 159);
            this.CadenaRef.Name = "CadenaRef";
            this.CadenaRef.Size = new System.Drawing.Size(271, 180);
            this.CadenaRef.TabIndex = 5;
            // 
            // Idproceso
            // 
            this.Idproceso.HeaderText = "Idproceso";
            this.Idproceso.Items.AddRange(new object[] {
            "1"});
            this.Idproceso.Name = "Idproceso";
            this.Idproceso.Width = 60;
            // 
            // DireccionL
            // 
            this.DireccionL.HeaderText = "Direccion Logica";
            this.DireccionL.Name = "DireccionL";
            this.DireccionL.Width = 103;
            // 
            // DirFisica
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Aqua;
            this.DirFisica.DefaultCellStyle = dataGridViewCellStyle2;
            this.DirFisica.HeaderText = "Direccion Fisica";
            this.DirFisica.Name = "DirFisica";
            this.DirFisica.ReadOnly = true;
            this.DirFisica.Width = 98;
            // 
            // FPC
            // 
            this.FPC.AutoSize = true;
            this.FPC.BackColor = System.Drawing.Color.OrangeRed;
            this.FPC.ForeColor = System.Drawing.Color.White;
            this.FPC.Location = new System.Drawing.Point(42, 102);
            this.FPC.Name = "FPC";
            this.FPC.Size = new System.Drawing.Size(136, 13);
            this.FPC.TabIndex = 7;
            this.FPC.Text = "Fallos de pagina comunes: ";
            // 
            // MenuCreferencia
            // 
            this.MenuCreferencia.BackColor = System.Drawing.Color.Navy;
            this.MenuCreferencia.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verMapaDeMemoriaEnEsteInstanteToolStripMenuItem,
            this.verTablasDePaginasEnEsteInstatnteToolStripMenuItem});
            this.MenuCreferencia.Name = "MenuCreferencia";
            this.MenuCreferencia.Size = new System.Drawing.Size(276, 48);
            // 
            // verMapaDeMemoriaEnEsteInstanteToolStripMenuItem
            // 
            this.verMapaDeMemoriaEnEsteInstanteToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
            this.verMapaDeMemoriaEnEsteInstanteToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.verMapaDeMemoriaEnEsteInstanteToolStripMenuItem.Name = "verMapaDeMemoriaEnEsteInstanteToolStripMenuItem";
            this.verMapaDeMemoriaEnEsteInstanteToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.verMapaDeMemoriaEnEsteInstanteToolStripMenuItem.Text = "Ver mapa de memoria en este instante";
            this.verMapaDeMemoriaEnEsteInstanteToolStripMenuItem.Click += new System.EventHandler(this.verMapaDeMemoriaEnEsteInstanteToolStripMenuItem_Click);
            // 
            // verTablasDePaginasEnEsteInstatnteToolStripMenuItem
            // 
            this.verTablasDePaginasEnEsteInstatnteToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.verTablasDePaginasEnEsteInstatnteToolStripMenuItem.Name = "verTablasDePaginasEnEsteInstatnteToolStripMenuItem";
            this.verTablasDePaginasEnEsteInstatnteToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.verTablasDePaginasEnEsteInstatnteToolStripMenuItem.Text = "Ver tablas de paginas en este instante";
            this.verTablasDePaginasEnEsteInstatnteToolStripMenuItem.Click += new System.EventHandler(this.verTablasDePaginasEnEsteInstatnteToolStripMenuItem_Click);
            // 
            // FPE
            // 
            this.FPE.AutoSize = true;
            this.FPE.BackColor = System.Drawing.Color.IndianRed;
            this.FPE.ForeColor = System.Drawing.Color.White;
            this.FPE.Location = new System.Drawing.Point(42, 129);
            this.FPE.Name = "FPE";
            this.FPE.Size = new System.Drawing.Size(196, 13);
            this.FPE.TabIndex = 8;
            this.FPE.Text = "Fallos de pagina atribuibles al algoritmo: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(304, 351);
            this.Controls.Add(this.FPE);
            this.Controls.Add(this.FPC);
            this.Controls.Add(this.CadenaRef);
            this.Controls.Add(this.Cantpaginas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TamPagina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Algoritmos de reemplazo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CadenaRef)).EndInit();
            this.MenuCreferencia.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TamPagina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosEjecucionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeProcesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Aprocesos;
        private System.Windows.Forms.ToolStripMenuItem aUnoProc;
        private System.Windows.Forms.ToolStripMenuItem aVariosProc;
        private System.Windows.Forms.ToolStripMenuItem Adirecciones;
        private System.Windows.Forms.TextBox Cantpaginas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripTextBox CantidadPr;
        private System.Windows.Forms.ToolStripMenuItem definirTablasDePaginasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem definirCantidadDePaginasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meotodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fIFOTM;
        private System.Windows.Forms.ToolStripMenuItem optimoTm;
        private System.Windows.Forms.ToolStripMenuItem lRUTM;
        private System.Windows.Forms.ToolStripMenuItem segundaOTM;
        private System.Windows.Forms.Label FPC;
        private System.Windows.Forms.ContextMenuStrip MenuCreferencia;
        private System.Windows.Forms.ToolStripMenuItem verMapaDeMemoriaEnEsteInstanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTablasDePaginasEnEsteInstatnteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ambitoDeReemplazoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AmRglobal;
        private System.Windows.Forms.ToolStripMenuItem AmRlocal;
        private System.Windows.Forms.ToolStripMenuItem tratarCadenaDeReferenciasToolStripMenuItem;
        private System.Windows.Forms.DataGridViewComboBoxColumn Idproceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirFisica;
        private System.Windows.Forms.Label FPE;
        public System.Windows.Forms.DataGridView CadenaRef;
    }
}

