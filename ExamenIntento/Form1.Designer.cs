namespace ExamenIntento
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombreTienda = new System.Windows.Forms.Label();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.lblCod_id = new System.Windows.Forms.Label();
            this.lblNomVendedor = new System.Windows.Forms.Label();
            this.grupoTipoPrenda = new System.Windows.Forms.GroupBox();
            this.radioPantalon = new System.Windows.Forms.RadioButton();
            this.radioCamisa = new System.Windows.Forms.RadioButton();
            this.grupoTipoCamisa = new System.Windows.Forms.GroupBox();
            this.checkCuelloMao = new System.Windows.Forms.CheckBox();
            this.checkMangaCorta = new System.Windows.Forms.CheckBox();
            this.grupoTipoPantalon = new System.Windows.Forms.GroupBox();
            this.checkChupin = new System.Windows.Forms.CheckBox();
            this.grupoStockDispo = new System.Windows.Forms.GroupBox();
            this.lblUnidadesDispo = new System.Windows.Forms.Label();
            this.lblStockDispo = new System.Windows.Forms.Label();
            this.lblLeyendaStock = new System.Windows.Forms.Label();
            this.grupoCalidad = new System.Windows.Forms.GroupBox();
            this.radioPremium = new System.Windows.Forms.RadioButton();
            this.radioStandar = new System.Windows.Forms.RadioButton();
            this.groupPrecio = new System.Windows.Forms.GroupBox();
            this.txtCantidadSolicitada = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grupoTipoPrenda.SuspendLayout();
            this.grupoTipoCamisa.SuspendLayout();
            this.grupoTipoPantalon.SuspendLayout();
            this.grupoStockDispo.SuspendLayout();
            this.grupoCalidad.SuspendLayout();
            this.groupPrecio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(112, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(178, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cotizador";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(14, 59);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblDireccion);
            this.splitContainer1.Panel1.Controls.Add(this.lblNombreTienda);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnHistorial);
            this.splitContainer1.Panel2.Controls.Add(this.lblCod_id);
            this.splitContainer1.Panel2.Controls.Add(this.lblNomVendedor);
            this.splitContainer1.Size = new System.Drawing.Size(383, 74);
            this.splitContainer1.SplitterDistance = 37;
            this.splitContainer1.TabIndex = 1;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(277, 11);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(84, 13);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion tienda";
            // 
            // lblNombreTienda
            // 
            this.lblNombreTienda.AutoSize = true;
            this.lblNombreTienda.Location = new System.Drawing.Point(8, 11);
            this.lblNombreTienda.Name = "lblNombreTienda";
            this.lblNombreTienda.Size = new System.Drawing.Size(80, 13);
            this.lblNombreTienda.TabIndex = 0;
            this.lblNombreTienda.Text = "Nombre Tienda";
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(280, 5);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(93, 22);
            this.btnHistorial.TabIndex = 2;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // lblCod_id
            // 
            this.lblCod_id.AutoSize = true;
            this.lblCod_id.Location = new System.Drawing.Point(193, 10);
            this.lblCod_id.Name = "lblCod_id";
            this.lblCod_id.Size = new System.Drawing.Size(38, 13);
            this.lblCod_id.TabIndex = 1;
            this.lblCod_id.Text = "Cod Id";
            // 
            // lblNomVendedor
            // 
            this.lblNomVendedor.AutoSize = true;
            this.lblNomVendedor.Location = new System.Drawing.Point(17, 10);
            this.lblNomVendedor.Name = "lblNomVendedor";
            this.lblNomVendedor.Size = new System.Drawing.Size(72, 13);
            this.lblNomVendedor.TabIndex = 0;
            this.lblNomVendedor.Text = "Nombre Vend";
            // 
            // grupoTipoPrenda
            // 
            this.grupoTipoPrenda.Controls.Add(this.radioPantalon);
            this.grupoTipoPrenda.Controls.Add(this.radioCamisa);
            this.grupoTipoPrenda.Location = new System.Drawing.Point(12, 152);
            this.grupoTipoPrenda.Name = "grupoTipoPrenda";
            this.grupoTipoPrenda.Size = new System.Drawing.Size(384, 51);
            this.grupoTipoPrenda.TabIndex = 2;
            this.grupoTipoPrenda.TabStop = false;
            this.grupoTipoPrenda.Text = "Tipo de Prenda";
            // 
            // radioPantalon
            // 
            this.radioPantalon.AutoSize = true;
            this.radioPantalon.Location = new System.Drawing.Point(245, 19);
            this.radioPantalon.Name = "radioPantalon";
            this.radioPantalon.Size = new System.Drawing.Size(67, 17);
            this.radioPantalon.TabIndex = 1;
            this.radioPantalon.TabStop = true;
            this.radioPantalon.Text = "Pantalón";
            this.radioPantalon.UseVisualStyleBackColor = true;
            this.radioPantalon.CheckedChanged += new System.EventHandler(this.radioPantalon_CheckedChanged);
            // 
            // radioCamisa
            // 
            this.radioCamisa.AutoSize = true;
            this.radioCamisa.Checked = true;
            this.radioCamisa.Location = new System.Drawing.Point(50, 19);
            this.radioCamisa.Name = "radioCamisa";
            this.radioCamisa.Size = new System.Drawing.Size(59, 17);
            this.radioCamisa.TabIndex = 0;
            this.radioCamisa.TabStop = true;
            this.radioCamisa.Text = "Camisa";
            this.radioCamisa.UseVisualStyleBackColor = true;
            this.radioCamisa.CheckedChanged += new System.EventHandler(this.radioCamisa_CheckedChanged);
            // 
            // grupoTipoCamisa
            // 
            this.grupoTipoCamisa.Controls.Add(this.checkCuelloMao);
            this.grupoTipoCamisa.Controls.Add(this.checkMangaCorta);
            this.grupoTipoCamisa.Location = new System.Drawing.Point(14, 209);
            this.grupoTipoCamisa.Name = "grupoTipoCamisa";
            this.grupoTipoCamisa.Size = new System.Drawing.Size(170, 80);
            this.grupoTipoCamisa.TabIndex = 3;
            this.grupoTipoCamisa.TabStop = false;
            this.grupoTipoCamisa.Text = "Tipo Camisa";
            // 
            // checkCuelloMao
            // 
            this.checkCuelloMao.AutoSize = true;
            this.checkCuelloMao.Location = new System.Drawing.Point(17, 42);
            this.checkCuelloMao.Name = "checkCuelloMao";
            this.checkCuelloMao.Size = new System.Drawing.Size(79, 17);
            this.checkCuelloMao.TabIndex = 1;
            this.checkCuelloMao.Text = "Cuello Mao";
            this.checkCuelloMao.UseVisualStyleBackColor = true;
            this.checkCuelloMao.CheckedChanged += new System.EventHandler(this.checkCuelloMao_CheckedChanged);
            // 
            // checkMangaCorta
            // 
            this.checkMangaCorta.AutoSize = true;
            this.checkMangaCorta.Location = new System.Drawing.Point(17, 19);
            this.checkMangaCorta.Name = "checkMangaCorta";
            this.checkMangaCorta.Size = new System.Drawing.Size(87, 17);
            this.checkMangaCorta.TabIndex = 0;
            this.checkMangaCorta.Text = "Manga Corta";
            this.checkMangaCorta.UseVisualStyleBackColor = true;
            this.checkMangaCorta.CheckedChanged += new System.EventHandler(this.checkMangaCorta_CheckedChanged);
            // 
            // grupoTipoPantalon
            // 
            this.grupoTipoPantalon.Controls.Add(this.checkChupin);
            this.grupoTipoPantalon.Enabled = false;
            this.grupoTipoPantalon.Location = new System.Drawing.Point(214, 209);
            this.grupoTipoPantalon.Name = "grupoTipoPantalon";
            this.grupoTipoPantalon.Size = new System.Drawing.Size(182, 80);
            this.grupoTipoPantalon.TabIndex = 4;
            this.grupoTipoPantalon.TabStop = false;
            this.grupoTipoPantalon.Text = "Tipo Pantalón";
            // 
            // checkChupin
            // 
            this.checkChupin.AutoSize = true;
            this.checkChupin.Location = new System.Drawing.Point(24, 20);
            this.checkChupin.Name = "checkChupin";
            this.checkChupin.Size = new System.Drawing.Size(61, 17);
            this.checkChupin.TabIndex = 0;
            this.checkChupin.Text = "Chupín";
            this.checkChupin.UseVisualStyleBackColor = true;
            this.checkChupin.CheckedChanged += new System.EventHandler(this.checkChupin_CheckedChanged);
            // 
            // grupoStockDispo
            // 
            this.grupoStockDispo.Controls.Add(this.lblUnidadesDispo);
            this.grupoStockDispo.Controls.Add(this.lblStockDispo);
            this.grupoStockDispo.Controls.Add(this.lblLeyendaStock);
            this.grupoStockDispo.Location = new System.Drawing.Point(16, 366);
            this.grupoStockDispo.Name = "grupoStockDispo";
            this.grupoStockDispo.Size = new System.Drawing.Size(181, 78);
            this.grupoStockDispo.TabIndex = 5;
            this.grupoStockDispo.TabStop = false;
            this.grupoStockDispo.Text = "Unidades Disponibles";
            // 
            // lblUnidadesDispo
            // 
            this.lblUnidadesDispo.AutoSize = true;
            this.lblUnidadesDispo.Location = new System.Drawing.Point(125, 33);
            this.lblUnidadesDispo.Name = "lblUnidadesDispo";
            this.lblUnidadesDispo.Size = new System.Drawing.Size(0, 13);
            this.lblUnidadesDispo.TabIndex = 2;
            // 
            // lblStockDispo
            // 
            this.lblStockDispo.AutoSize = true;
            this.lblStockDispo.Location = new System.Drawing.Point(195, 26);
            this.lblStockDispo.Name = "lblStockDispo";
            this.lblStockDispo.Size = new System.Drawing.Size(157, 13);
            this.lblStockDispo.TabIndex = 1;
            this.lblStockDispo.Text = "_________________________";
            // 
            // lblLeyendaStock
            // 
            this.lblLeyendaStock.AutoSize = true;
            this.lblLeyendaStock.Location = new System.Drawing.Point(17, 33);
            this.lblLeyendaStock.Name = "lblLeyendaStock";
            this.lblLeyendaStock.Size = new System.Drawing.Size(96, 13);
            this.lblLeyendaStock.TabIndex = 0;
            this.lblLeyendaStock.Text = "Stock Disponible:  ";
            // 
            // grupoCalidad
            // 
            this.grupoCalidad.Controls.Add(this.radioPremium);
            this.grupoCalidad.Controls.Add(this.radioStandar);
            this.grupoCalidad.Location = new System.Drawing.Point(16, 295);
            this.grupoCalidad.Name = "grupoCalidad";
            this.grupoCalidad.Size = new System.Drawing.Size(381, 52);
            this.grupoCalidad.TabIndex = 6;
            this.grupoCalidad.TabStop = false;
            this.grupoCalidad.Text = "Calidad ";
            // 
            // radioPremium
            // 
            this.radioPremium.AutoSize = true;
            this.radioPremium.Location = new System.Drawing.Point(223, 20);
            this.radioPremium.Name = "radioPremium";
            this.radioPremium.Size = new System.Drawing.Size(65, 17);
            this.radioPremium.TabIndex = 1;
            this.radioPremium.TabStop = true;
            this.radioPremium.Text = "Premium";
            this.radioPremium.UseVisualStyleBackColor = true;
            this.radioPremium.CheckedChanged += new System.EventHandler(this.radioPremium_CheckedChanged);
            // 
            // radioStandar
            // 
            this.radioStandar.AutoSize = true;
            this.radioStandar.Checked = true;
            this.radioStandar.Location = new System.Drawing.Point(70, 20);
            this.radioStandar.Name = "radioStandar";
            this.radioStandar.Size = new System.Drawing.Size(62, 17);
            this.radioStandar.TabIndex = 0;
            this.radioStandar.TabStop = true;
            this.radioStandar.Text = "Standar";
            this.radioStandar.UseVisualStyleBackColor = true;
            this.radioStandar.CheckedChanged += new System.EventHandler(this.radioStandar_CheckedChanged);
            // 
            // groupPrecio
            // 
            this.groupPrecio.Controls.Add(this.txtCantidadSolicitada);
            this.groupPrecio.Controls.Add(this.lblCantidad);
            this.groupPrecio.Location = new System.Drawing.Point(216, 366);
            this.groupPrecio.Name = "groupPrecio";
            this.groupPrecio.Size = new System.Drawing.Size(181, 78);
            this.groupPrecio.TabIndex = 7;
            this.groupPrecio.TabStop = false;
            this.groupPrecio.Text = "Cantidad";
            // 
            // txtCantidadSolicitada
            // 
            this.txtCantidadSolicitada.Location = new System.Drawing.Point(91, 30);
            this.txtCantidadSolicitada.Name = "txtCantidadSolicitada";
            this.txtCantidadSolicitada.Size = new System.Drawing.Size(44, 20);
            this.txtCantidadSolicitada.TabIndex = 3;
            this.txtCantidadSolicitada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadSolicitada_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(19, 33);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad";
            // 
            // btnCotizar
            // 
            this.btnCotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizar.Location = new System.Drawing.Point(45, 461);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(116, 42);
            this.btnCotizar.TabIndex = 8;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AllowDrop = true;
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(204, 467);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(134, 31);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "$_______";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 525);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.grupoCalidad);
            this.Controls.Add(this.groupPrecio);
            this.Controls.Add(this.grupoStockDispo);
            this.Controls.Add(this.grupoTipoPantalon);
            this.Controls.Add(this.grupoTipoCamisa);
            this.Controls.Add(this.grupoTipoPrenda);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grupoTipoPrenda.ResumeLayout(false);
            this.grupoTipoPrenda.PerformLayout();
            this.grupoTipoCamisa.ResumeLayout(false);
            this.grupoTipoCamisa.PerformLayout();
            this.grupoTipoPantalon.ResumeLayout(false);
            this.grupoTipoPantalon.PerformLayout();
            this.grupoStockDispo.ResumeLayout(false);
            this.grupoStockDispo.PerformLayout();
            this.grupoCalidad.ResumeLayout(false);
            this.grupoCalidad.PerformLayout();
            this.groupPrecio.ResumeLayout(false);
            this.groupPrecio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombreTienda;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Label lblCod_id;
        private System.Windows.Forms.Label lblNomVendedor;
        private System.Windows.Forms.GroupBox grupoTipoPrenda;
        private System.Windows.Forms.RadioButton radioPantalon;
        private System.Windows.Forms.RadioButton radioCamisa;
        private System.Windows.Forms.GroupBox grupoTipoCamisa;
        private System.Windows.Forms.CheckBox checkCuelloMao;
        private System.Windows.Forms.CheckBox checkMangaCorta;
        private System.Windows.Forms.GroupBox grupoTipoPantalon;
        private System.Windows.Forms.CheckBox checkChupin;
        private System.Windows.Forms.GroupBox grupoStockDispo;
        private System.Windows.Forms.Label lblStockDispo;
        private System.Windows.Forms.Label lblLeyendaStock;
        private System.Windows.Forms.GroupBox grupoCalidad;
        private System.Windows.Forms.RadioButton radioPremium;
        private System.Windows.Forms.RadioButton radioStandar;
        private System.Windows.Forms.GroupBox groupPrecio;
        private System.Windows.Forms.TextBox txtCantidadSolicitada;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblUnidadesDispo;
    }
}

