namespace SistemaBiblioteca.BIBLIOGRAFIA.INVENTARIO
{
    partial class frmBuscar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btBuscar = new System.Windows.Forms.ToolStripButton();
            this.btBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btReporte = new System.Windows.Forms.ToolStripButton();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.elGroupBox1 = new Klik.Windows.Forms.v1.EntryLib.ELGroupBox();
            this.txtAutor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtSignatura = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtTitulo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.crvReporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dtRegistro = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.kFormManager1 = new Klik.Windows.Forms.v1.Common.KFormManager(this.components);
            this.toolStrip1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elGroupBox1)).BeginInit();
            this.elGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kFormManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btBuscar,
            this.btBorrar,
            this.toolStripSeparator1,
            this.btReporte});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(626, 52);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btBuscar
            // 
            this.btBuscar.Image = global::SistemaBiblioteca.Properties.Resources.AplicarFiltro;
            this.btBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(74, 49);
            this.btBuscar.Text = "Filtrar Datos";
            this.btBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btBuscar.ToolTipText = "Buscar";
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Image = global::SistemaBiblioteca.Properties.Resources.BorrarFiltro;
            this.btBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(78, 49);
            this.btBorrar.Text = "Borrar Filtros";
            this.btBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btBorrar.ToolTipText = "Buscar";
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // btReporte
            // 
            this.btReporte.Image = global::SistemaBiblioteca.Properties.Resources.Reporte;
            this.btReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btReporte.Name = "btReporte";
            this.btReporte.Size = new System.Drawing.Size(80, 49);
            this.btReporte.Text = "Vista Reporte";
            this.btReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btReporte.ToolTipText = "Buscar";
            this.btReporte.Click += new System.EventHandler(this.btReporte_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.elGroupBox1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx1.Location = new System.Drawing.Point(0, 52);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(262, 436);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 2;
            // 
            // elGroupBox1
            // 
            this.elGroupBox1.BackgroundStyle.GradientAngle = 45F;
            this.elGroupBox1.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.elGroupBox1.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.elGroupBox1.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaption;
            this.elGroupBox1.CaptionStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.elGroupBox1.CaptionStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.elGroupBox1.CaptionStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.elGroupBox1.CaptionStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.elGroupBox1.CaptionStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.elGroupBox1.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.elGroupBox1.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.elGroupBox1.CaptionStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elGroupBox1.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlue;
            this.elGroupBox1.CaptionStyle.TextStyle.Text = "Bibliografía";
            this.elGroupBox1.CaptionStyle.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elGroupBox1.Controls.Add(this.txtAutor);
            this.elGroupBox1.Controls.Add(this.labelX3);
            this.elGroupBox1.Controls.Add(this.txtSignatura);
            this.elGroupBox1.Controls.Add(this.labelX2);
            this.elGroupBox1.Controls.Add(this.txtTitulo);
            this.elGroupBox1.Controls.Add(this.labelX1);
            this.elGroupBox1.Location = new System.Drawing.Point(9, 8);
            this.elGroupBox1.Name = "elGroupBox1";
            this.elGroupBox1.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlue;
            this.elGroupBox1.Padding = new System.Windows.Forms.Padding(4, 27, 4, 3);
            this.elGroupBox1.Size = new System.Drawing.Size(243, 117);
            this.elGroupBox1.TabIndex = 0;
            // 
            // txtAutor
            // 
            // 
            // 
            // 
            this.txtAutor.Border.Class = "TextBoxBorder";
            this.txtAutor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAutor.Location = new System.Drawing.Point(69, 84);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(166, 20);
            this.txtAutor.TabIndex = 4;
            this.txtAutor.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(8, 81);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(87, 23);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Autor:";
            // 
            // txtSignatura
            // 
            // 
            // 
            // 
            this.txtSignatura.Border.Class = "TextBoxBorder";
            this.txtSignatura.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSignatura.Location = new System.Drawing.Point(69, 58);
            this.txtSignatura.Name = "txtSignatura";
            this.txtSignatura.Size = new System.Drawing.Size(166, 20);
            this.txtSignatura.TabIndex = 4;
            this.txtSignatura.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(8, 55);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(87, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Signatura:";
            // 
            // txtTitulo
            // 
            // 
            // 
            // 
            this.txtTitulo.Border.Class = "TextBoxBorder";
            this.txtTitulo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTitulo.Location = new System.Drawing.Point(69, 33);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(166, 20);
            this.txtTitulo.TabIndex = 2;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(8, 30);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(87, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Título:";
            // 
            // crvReporte
            // 
            this.crvReporte.ActiveViewIndex = -1;
            this.crvReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReporte.Location = new System.Drawing.Point(262, 52);
            this.crvReporte.Name = "crvReporte";
            this.crvReporte.Size = new System.Drawing.Size(364, 436);
            this.crvReporte.TabIndex = 3;
            this.crvReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvReporte.Visible = false;
            // 
            // dtRegistro
            // 
            this.dtRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtRegistro.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtRegistro.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtRegistro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtRegistro.Location = new System.Drawing.Point(262, 52);
            this.dtRegistro.Name = "dtRegistro";
            this.dtRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtRegistro.Size = new System.Drawing.Size(364, 436);
            this.dtRegistro.TabIndex = 4;
            this.dtRegistro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtRegistro_CellDoubleClick);
            // 
            // kFormManager1
            // 
            this.kFormManager1.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.kFormManager1.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.kFormManager1.MainContainer = this;
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 488);
            this.Controls.Add(this.dtRegistro);
            this.Controls.Add(this.crvReporte);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(606, 523);
            this.Name = "frmBuscar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Libros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBuscar_FormClosing);
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elGroupBox1)).EndInit();
            this.elGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kFormManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btBuscar;
        private System.Windows.Forms.ToolStripButton btBorrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btReporte;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporte;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtRegistro;
        private Klik.Windows.Forms.v1.EntryLib.ELGroupBox elGroupBox1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTitulo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSignatura;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAutor;
        private DevComponents.DotNetBar.LabelX labelX3;
        private Klik.Windows.Forms.v1.Common.KFormManager kFormManager1;
    }
}