namespace SistemaBiblioteca.PRESTAMO.SALIDA
{
    partial class frmSalida
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
            this.kFormManager1 = new Klik.Windows.Forms.v1.Common.KFormManager(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btNuevo = new System.Windows.Forms.ToolStripButton();
            this.btGuardar = new System.Windows.Forms.ToolStripButton();
            this.btEditar = new System.Windows.Forms.ToolStripButton();
            this.btEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btBuscar = new System.Windows.Forms.ToolStripButton();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.elGroupBox2 = new Klik.Windows.Forms.v1.EntryLib.ELGroupBox();
            this.txtIdUsuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btCargarEstudiante = new DevComponents.DotNetBar.ButtonX();
            this.btCargarVisitante = new DevComponents.DotNetBar.ButtonX();
            this.txtApellidos = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.txtNombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txtTipoUsuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtIdentificacion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.elGroupBox1 = new Klik.Windows.Forms.v1.EntryLib.ELGroupBox();
            this.txtObservacion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.cmbTipoPrestamo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.dtpFecha = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtNPrestamo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx8 = new DevComponents.DotNetBar.PanelEx();
            this.dtRegistro = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panelEx11 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx10 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx9 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx7 = new DevComponents.DotNetBar.PanelEx();
            this.btActualizar = new DevComponents.DotNetBar.ButtonX();
            this.btCargarLibros = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panelEx5 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx6 = new DevComponents.DotNetBar.PanelEx();
            ((System.ComponentModel.ISupportInitialize)(this.kFormManager1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elGroupBox2)).BeginInit();
            this.elGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elGroupBox1)).BeginInit();
            this.elGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.panelEx8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtRegistro)).BeginInit();
            this.panelEx7.SuspendLayout();
            this.SuspendLayout();
            // 
            // kFormManager1
            // 
            this.kFormManager1.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.kFormManager1.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.kFormManager1.MainContainer = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btNuevo,
            this.btGuardar,
            this.btEditar,
            this.btEliminar,
            this.toolStripSeparator1,
            this.btBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(569, 52);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btNuevo
            // 
            this.btNuevo.Image = global::SistemaBiblioteca.Properties.Resources.Nuevo;
            this.btNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(44, 49);
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Image = global::SistemaBiblioteca.Properties.Resources.Guardar;
            this.btGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(53, 49);
            this.btGuardar.Text = "Guardar";
            this.btGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btEditar
            // 
            this.btEditar.Enabled = false;
            this.btEditar.Image = global::SistemaBiblioteca.Properties.Resources.Editar;
            this.btEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(41, 49);
            this.btEditar.Text = "Editar";
            this.btEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btEliminar
            // 
            this.btEliminar.Enabled = false;
            this.btEliminar.Image = global::SistemaBiblioteca.Properties.Resources.Eliminar;
            this.btEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(63, 49);
            this.btEliminar.Text = "Desactivar";
            this.btEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // btBuscar
            // 
            this.btBuscar.Image = global::SistemaBiblioteca.Properties.Resources.Buscar;
            this.btBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(45, 49);
            this.btBuscar.Text = "Buscar";
            this.btBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btBuscar.ToolTipText = "Buscar";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.elGroupBox2);
            this.panelEx1.Controls.Add(this.elGroupBox1);
            this.panelEx1.Controls.Add(this.panelEx4);
            this.panelEx1.Controls.Add(this.panelEx3);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx1.Location = new System.Drawing.Point(0, 52);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(204, 412);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 6;
            // 
            // elGroupBox2
            // 
            this.elGroupBox2.BackgroundStyle.GradientAngle = 45F;
            this.elGroupBox2.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.elGroupBox2.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.elGroupBox2.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaption;
            this.elGroupBox2.CaptionStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.elGroupBox2.CaptionStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.elGroupBox2.CaptionStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.elGroupBox2.CaptionStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.elGroupBox2.CaptionStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.elGroupBox2.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.elGroupBox2.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.elGroupBox2.CaptionStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elGroupBox2.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlue;
            this.elGroupBox2.CaptionStyle.TextStyle.Text = "Visitante";
            this.elGroupBox2.CaptionStyle.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elGroupBox2.Controls.Add(this.txtIdUsuario);
            this.elGroupBox2.Controls.Add(this.btCargarEstudiante);
            this.elGroupBox2.Controls.Add(this.btCargarVisitante);
            this.elGroupBox2.Controls.Add(this.txtApellidos);
            this.elGroupBox2.Controls.Add(this.labelX10);
            this.elGroupBox2.Controls.Add(this.txtNombre);
            this.elGroupBox2.Controls.Add(this.labelX9);
            this.elGroupBox2.Controls.Add(this.txtTipoUsuario);
            this.elGroupBox2.Controls.Add(this.labelX8);
            this.elGroupBox2.Controls.Add(this.txtIdentificacion);
            this.elGroupBox2.Controls.Add(this.labelX7);
            this.elGroupBox2.Location = new System.Drawing.Point(6, 258);
            this.elGroupBox2.Name = "elGroupBox2";
            this.elGroupBox2.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlue;
            this.elGroupBox2.Padding = new System.Windows.Forms.Padding(4, 27, 4, 3);
            this.elGroupBox2.Size = new System.Drawing.Size(191, 147);
            this.elGroupBox2.TabIndex = 4;
            // 
            // txtIdUsuario
            // 
            // 
            // 
            // 
            this.txtIdUsuario.Border.Class = "TextBoxBorder";
            this.txtIdUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdUsuario.Location = new System.Drawing.Point(-16, -17);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(18, 20);
            this.txtIdUsuario.TabIndex = 24;
            this.txtIdUsuario.Visible = false;
            // 
            // btCargarEstudiante
            // 
            this.btCargarEstudiante.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCargarEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.btCargarEstudiante.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btCargarEstudiante.Image = global::SistemaBiblioteca.Properties.Resources.btn_agregar;
            this.btCargarEstudiante.Location = new System.Drawing.Point(155, 43);
            this.btCargarEstudiante.Name = "btCargarEstudiante";
            this.btCargarEstudiante.Size = new System.Drawing.Size(29, 22);
            this.btCargarEstudiante.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCargarEstudiante.TabIndex = 22;
            // 
            // btCargarVisitante
            // 
            this.btCargarVisitante.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCargarVisitante.BackColor = System.Drawing.Color.Transparent;
            this.btCargarVisitante.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btCargarVisitante.Image = global::SistemaBiblioteca.Properties.Resources.btn_buscar;
            this.btCargarVisitante.Location = new System.Drawing.Point(126, 43);
            this.btCargarVisitante.Name = "btCargarVisitante";
            this.btCargarVisitante.Size = new System.Drawing.Size(29, 22);
            this.btCargarVisitante.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCargarVisitante.TabIndex = 23;
            this.btCargarVisitante.Click += new System.EventHandler(this.btCargarVisitante_Click);
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtApellidos.Border.Class = "TextBoxBorder";
            this.txtApellidos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtApellidos.Location = new System.Drawing.Point(84, 119);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 10;
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(7, 116);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(71, 23);
            this.labelX10.TabIndex = 9;
            this.labelX10.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNombre.Border.Class = "TextBoxBorder";
            this.txtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNombre.Location = new System.Drawing.Point(84, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(7, 91);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(71, 23);
            this.labelX9.TabIndex = 7;
            this.labelX9.Text = "Nombres:";
            // 
            // txtTipoUsuario
            // 
            this.txtTipoUsuario.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTipoUsuario.Border.Class = "TextBoxBorder";
            this.txtTipoUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTipoUsuario.Location = new System.Drawing.Point(84, 69);
            this.txtTipoUsuario.Name = "txtTipoUsuario";
            this.txtTipoUsuario.ReadOnly = true;
            this.txtTipoUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtTipoUsuario.TabIndex = 6;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(7, 66);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(71, 23);
            this.labelX8.TabIndex = 5;
            this.labelX8.Text = "Tipo Usuario:";
            // 
            // txtIdentificacion
            // 
            // 
            // 
            // 
            this.txtIdentificacion.Border.Class = "TextBoxBorder";
            this.txtIdentificacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdentificacion.FocusHighlightEnabled = true;
            this.txtIdentificacion.Location = new System.Drawing.Point(7, 44);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(123, 20);
            this.txtIdentificacion.TabIndex = 4;
            this.txtIdentificacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdentificacion_KeyDown);
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(7, 20);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(184, 23);
            this.labelX7.TabIndex = 3;
            this.labelX7.Text = "Ingresar Identificación Visitante";
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
            this.elGroupBox1.CaptionStyle.TextStyle.Text = "Información";
            this.elGroupBox1.CaptionStyle.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elGroupBox1.Controls.Add(this.txtObservacion);
            this.elGroupBox1.Controls.Add(this.labelX6);
            this.elGroupBox1.Controls.Add(this.cmbTipoPrestamo);
            this.elGroupBox1.Controls.Add(this.labelX5);
            this.elGroupBox1.Controls.Add(this.dtpFecha);
            this.elGroupBox1.Controls.Add(this.labelX4);
            this.elGroupBox1.Controls.Add(this.txtNPrestamo);
            this.elGroupBox1.Controls.Add(this.labelX3);
            this.elGroupBox1.Location = new System.Drawing.Point(6, 44);
            this.elGroupBox1.Name = "elGroupBox1";
            this.elGroupBox1.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlue;
            this.elGroupBox1.Padding = new System.Windows.Forms.Padding(4, 27, 4, 3);
            this.elGroupBox1.Size = new System.Drawing.Size(191, 208);
            this.elGroupBox1.TabIndex = 3;
            // 
            // txtObservacion
            // 
            // 
            // 
            // 
            this.txtObservacion.Border.Class = "TextBoxBorder";
            this.txtObservacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtObservacion.FocusHighlightEnabled = true;
            this.txtObservacion.Location = new System.Drawing.Point(7, 129);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(177, 70);
            this.txtObservacion.TabIndex = 8;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(7, 105);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(71, 23);
            this.labelX6.TabIndex = 7;
            this.labelX6.Text = "Observación:";
            // 
            // cmbTipoPrestamo
            // 
            this.cmbTipoPrestamo.DisplayMember = "Text";
            this.cmbTipoPrestamo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPrestamo.FocusHighlightEnabled = true;
            this.cmbTipoPrestamo.FormattingEnabled = true;
            this.cmbTipoPrestamo.ItemHeight = 14;
            this.cmbTipoPrestamo.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cmbTipoPrestamo.Location = new System.Drawing.Point(84, 83);
            this.cmbTipoPrestamo.Name = "cmbTipoPrestamo";
            this.cmbTipoPrestamo.Size = new System.Drawing.Size(100, 20);
            this.cmbTipoPrestamo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbTipoPrestamo.TabIndex = 6;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Prestamo en Sala";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Prestamo Externo";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(7, 80);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(71, 23);
            this.labelX5.TabIndex = 5;
            this.labelX5.Text = "Tipo de Pre.:";
            // 
            // dtpFecha
            // 
            // 
            // 
            // 
            this.dtpFecha.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFecha.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpFecha.ButtonDropDown.Visible = true;
            this.dtpFecha.FocusHighlightEnabled = true;
            this.dtpFecha.Location = new System.Drawing.Point(84, 58);
            // 
            // 
            // 
            this.dtpFecha.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpFecha.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpFecha.MonthCalendar.BackgroundStyle.Class = "";
            this.dtpFecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFecha.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpFecha.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtpFecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFecha.MonthCalendar.DisplayMonth = new System.DateTime(2015, 2, 1, 0, 0, 0, 0);
            this.dtpFecha.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtpFecha.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpFecha.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpFecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpFecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpFecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpFecha.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtpFecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFecha.MonthCalendar.TodayButtonVisible = true;
            this.dtpFecha.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpFecha.TabIndex = 4;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(7, 55);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(71, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Fecha:";
            // 
            // txtNPrestamo
            // 
            // 
            // 
            // 
            this.txtNPrestamo.Border.Class = "TextBoxBorder";
            this.txtNPrestamo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNPrestamo.FocusHighlightEnabled = true;
            this.txtNPrestamo.Font = new System.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNPrestamo.Location = new System.Drawing.Point(84, 33);
            this.txtNPrestamo.Name = "txtNPrestamo";
            this.txtNPrestamo.Size = new System.Drawing.Size(100, 19);
            this.txtNPrestamo.TabIndex = 2;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(7, 30);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(71, 23);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Nº Prestamo:";
            // 
            // panelEx4
            // 
            this.panelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx4.Location = new System.Drawing.Point(6, 35);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Size = new System.Drawing.Size(191, 3);
            this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx4.Style.GradientAngle = 90;
            this.panelEx4.TabIndex = 2;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Location = new System.Drawing.Point(6, 31);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(191, 3);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(6, 5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(191, 24);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "<font color=\"#C0504D\"><b>I</b></font>nformación del <font color=\"#C0504D\"><b>P</b" +
    "></font>réstamo";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.panelEx8);
            this.panelEx2.Controls.Add(this.panelEx7);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(204, 52);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(365, 412);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 7;
            // 
            // panelEx8
            // 
            this.panelEx8.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx8.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx8.Controls.Add(this.dtRegistro);
            this.panelEx8.Controls.Add(this.panelEx11);
            this.panelEx8.Controls.Add(this.panelEx10);
            this.panelEx8.Controls.Add(this.panelEx9);
            this.panelEx8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx8.Location = new System.Drawing.Point(0, 46);
            this.panelEx8.Name = "panelEx8";
            this.panelEx8.Size = new System.Drawing.Size(365, 366);
            this.panelEx8.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx8.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx8.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx8.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx8.Style.GradientAngle = 90;
            this.panelEx8.TabIndex = 10;
            // 
            // dtRegistro
            // 
            this.dtRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtRegistro.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtRegistro.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtRegistro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtRegistro.Location = new System.Drawing.Point(8, 0);
            this.dtRegistro.Name = "dtRegistro";
            this.dtRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtRegistro.Size = new System.Drawing.Size(349, 358);
            this.dtRegistro.TabIndex = 9;
            this.dtRegistro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtRegistro_KeyDown);
            // 
            // panelEx11
            // 
            this.panelEx11.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx11.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx11.Location = new System.Drawing.Point(8, 358);
            this.panelEx11.Name = "panelEx11";
            this.panelEx11.Size = new System.Drawing.Size(349, 8);
            this.panelEx11.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx11.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx11.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx11.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx11.Style.GradientAngle = 90;
            this.panelEx11.TabIndex = 8;
            // 
            // panelEx10
            // 
            this.panelEx10.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx10.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx10.Location = new System.Drawing.Point(357, 0);
            this.panelEx10.Name = "panelEx10";
            this.panelEx10.Size = new System.Drawing.Size(8, 366);
            this.panelEx10.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx10.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx10.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx10.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx10.Style.GradientAngle = 90;
            this.panelEx10.TabIndex = 7;
            // 
            // panelEx9
            // 
            this.panelEx9.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx9.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx9.Location = new System.Drawing.Point(0, 0);
            this.panelEx9.Name = "panelEx9";
            this.panelEx9.Size = new System.Drawing.Size(8, 366);
            this.panelEx9.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx9.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx9.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx9.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx9.Style.GradientAngle = 90;
            this.panelEx9.TabIndex = 6;
            // 
            // panelEx7
            // 
            this.panelEx7.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx7.Controls.Add(this.btActualizar);
            this.panelEx7.Controls.Add(this.btCargarLibros);
            this.panelEx7.Controls.Add(this.labelX2);
            this.panelEx7.Controls.Add(this.panelEx5);
            this.panelEx7.Controls.Add(this.panelEx6);
            this.panelEx7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx7.Location = new System.Drawing.Point(0, 0);
            this.panelEx7.Name = "panelEx7";
            this.panelEx7.Size = new System.Drawing.Size(365, 46);
            this.panelEx7.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx7.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx7.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx7.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx7.Style.GradientAngle = 90;
            this.panelEx7.TabIndex = 9;
            // 
            // btActualizar
            // 
            this.btActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btActualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btActualizar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActualizar.Image = global::SistemaBiblioteca.Properties.Resources.Actualizar_24_24;
            this.btActualizar.Location = new System.Drawing.Point(186, 3);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(86, 26);
            this.btActualizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btActualizar.TabIndex = 14;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btCargarLibros
            // 
            this.btCargarLibros.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCargarLibros.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btCargarLibros.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCargarLibros.Image = global::SistemaBiblioteca.Properties.Resources.Cargar_24_24;
            this.btCargarLibros.Location = new System.Drawing.Point(278, 3);
            this.btCargarLibros.Name = "btCargarLibros";
            this.btCargarLibros.Size = new System.Drawing.Size(75, 26);
            this.btCargarLibros.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCargarLibros.TabIndex = 14;
            this.btCargarLibros.Text = "Cargar";
            this.btCargarLibros.Click += new System.EventHandler(this.btCargarLibros_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(8, 5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(162, 24);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "<font color=\"#C0504D\"><b>D</b></font>etalle del <font color=\"#C0504D\"><b>P</b></f" +
    "ont>réstamo";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // panelEx5
            // 
            this.panelEx5.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx5.Location = new System.Drawing.Point(8, 35);
            this.panelEx5.Name = "panelEx5";
            this.panelEx5.Size = new System.Drawing.Size(345, 3);
            this.panelEx5.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx5.Style.GradientAngle = 90;
            this.panelEx5.TabIndex = 8;
            // 
            // panelEx6
            // 
            this.panelEx6.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx6.Location = new System.Drawing.Point(8, 31);
            this.panelEx6.Name = "panelEx6";
            this.panelEx6.Size = new System.Drawing.Size(345, 3);
            this.panelEx6.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx6.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx6.Style.GradientAngle = 90;
            this.panelEx6.TabIndex = 7;
            // 
            // frmSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 464);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(585, 502);
            this.Name = "frmSalida";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos de Bibliografía";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSalida_FormClosing);
            this.Load += new System.EventHandler(this.frmSalida_Load);
            this.Resize += new System.EventHandler(this.frmSalida_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.kFormManager1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elGroupBox2)).EndInit();
            this.elGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elGroupBox1)).EndInit();
            this.elGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtRegistro)).EndInit();
            this.panelEx7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Klik.Windows.Forms.v1.Common.KFormManager kFormManager1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton btNuevo;
        public System.Windows.Forms.ToolStripButton btGuardar;
        public System.Windows.Forms.ToolStripButton btEditar;
        public System.Windows.Forms.ToolStripButton btEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton btBuscar;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.PanelEx panelEx4;
        private DevComponents.DotNetBar.PanelEx panelEx5;
        private DevComponents.DotNetBar.PanelEx panelEx6;
        private Klik.Windows.Forms.v1.EntryLib.ELGroupBox elGroupBox1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.LabelX labelX6;
        private Klik.Windows.Forms.v1.EntryLib.ELGroupBox elGroupBox2;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.PanelEx panelEx7;
        private DevComponents.DotNetBar.PanelEx panelEx8;
        private DevComponents.DotNetBar.PanelEx panelEx11;
        private DevComponents.DotNetBar.PanelEx panelEx10;
        private DevComponents.DotNetBar.PanelEx panelEx9;
        internal DevComponents.DotNetBar.ButtonX btCargarEstudiante;
        internal DevComponents.DotNetBar.ButtonX btCargarVisitante;
        internal DevComponents.DotNetBar.ButtonX btCargarLibros;
        public DevComponents.DotNetBar.Controls.TextBoxX txtNPrestamo;
        public DevComponents.Editors.DateTimeAdv.DateTimeInput dtpFecha;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmbTipoPrestamo;
        public DevComponents.DotNetBar.Controls.TextBoxX txtObservacion;
        public DevComponents.DotNetBar.Controls.TextBoxX txtIdentificacion;
        public DevComponents.DotNetBar.Controls.TextBoxX txtTipoUsuario;
        public DevComponents.DotNetBar.Controls.TextBoxX txtNombre;
        public DevComponents.DotNetBar.Controls.TextBoxX txtApellidos;
        public DevComponents.DotNetBar.Controls.TextBoxX txtIdUsuario;
        internal DevComponents.DotNetBar.ButtonX btActualizar;
        public DevComponents.DotNetBar.Controls.DataGridViewX dtRegistro;
    }
}