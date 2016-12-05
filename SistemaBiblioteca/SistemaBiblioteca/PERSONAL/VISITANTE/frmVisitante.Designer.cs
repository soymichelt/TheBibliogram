namespace SistemaBiblioteca.PERSONAL.VISITANTE
{
    partial class frmVisitante
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btNuevo = new System.Windows.Forms.ToolStripButton();
            this.btGuardar = new System.Windows.Forms.ToolStripButton();
            this.btEditar = new System.Windows.Forms.ToolStripButton();
            this.btEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btBuscar = new System.Windows.Forms.ToolStripButton();
            this.kFormManager1 = new Klik.Windows.Forms.v1.Common.KFormManager(this.components);
            this.elGroupBox1 = new Klik.Windows.Forms.v1.EntryLib.ELGroupBox();
            this.btAgregarCiudad = new DevComponents.DotNetBar.ButtonX();
            this.btActualizarCiudad = new DevComponents.DotNetBar.ButtonX();
            this.txtArea = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNInss = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtIdentificacion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbUsuario = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.comboItem8 = new DevComponents.Editors.ComboItem();
            this.comboItem9 = new DevComponents.Editors.ComboItem();
            this.comboItem10 = new DevComponents.Editors.ComboItem();
            this.cmbDepartamento = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.cmbCiudad = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txtObservacion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtDomicilio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtTelefono = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.dtpFechaNacimiento = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtApellidos = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtNombres = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbTipo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kFormManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elGroupBox1)).BeginInit();
            this.elGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaNacimiento)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(538, 51);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btNuevo
            // 
            this.btNuevo.Image = global::SistemaBiblioteca.Properties.Resources.Nuevo;
            this.btNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(36, 48);
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
            this.btGuardar.Size = new System.Drawing.Size(41, 48);
            this.btGuardar.Text = "Guardar";
            this.btGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Enabled = false;
            this.btEditar.Image = global::SistemaBiblioteca.Properties.Resources.Editar;
            this.btEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(36, 48);
            this.btEditar.Text = "Editar";
            this.btEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Enabled = false;
            this.btEliminar.Image = global::SistemaBiblioteca.Properties.Resources.Eliminar;
            this.btEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(50, 48);
            this.btEliminar.Text = "Desactivar";
            this.btEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 51);
            // 
            // btBuscar
            // 
            this.btBuscar.Image = global::SistemaBiblioteca.Properties.Resources.Buscar;
            this.btBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(36, 48);
            this.btBuscar.Text = "Buscar";
            this.btBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btBuscar.ToolTipText = "Buscar";
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // kFormManager1
            // 
            this.kFormManager1.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.kFormManager1.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.kFormManager1.MainContainer = this;
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
            this.elGroupBox1.CaptionStyle.TextStyle.Text = "Visitantes";
            this.elGroupBox1.CaptionStyle.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elGroupBox1.Controls.Add(this.btAgregarCiudad);
            this.elGroupBox1.Controls.Add(this.btActualizarCiudad);
            this.elGroupBox1.Controls.Add(this.txtArea);
            this.elGroupBox1.Controls.Add(this.txtNInss);
            this.elGroupBox1.Controls.Add(this.txtIdentificacion);
            this.elGroupBox1.Controls.Add(this.cmbUsuario);
            this.elGroupBox1.Controls.Add(this.cmbDepartamento);
            this.elGroupBox1.Controls.Add(this.cmbCiudad);
            this.elGroupBox1.Controls.Add(this.labelX11);
            this.elGroupBox1.Controls.Add(this.labelX10);
            this.elGroupBox1.Controls.Add(this.labelX9);
            this.elGroupBox1.Controls.Add(this.txtObservacion);
            this.elGroupBox1.Controls.Add(this.labelX8);
            this.elGroupBox1.Controls.Add(this.txtDomicilio);
            this.elGroupBox1.Controls.Add(this.labelX7);
            this.elGroupBox1.Controls.Add(this.txtTelefono);
            this.elGroupBox1.Controls.Add(this.labelX6);
            this.elGroupBox1.Controls.Add(this.dtpFechaNacimiento);
            this.elGroupBox1.Controls.Add(this.labelX5);
            this.elGroupBox1.Controls.Add(this.txtApellidos);
            this.elGroupBox1.Controls.Add(this.labelX4);
            this.elGroupBox1.Controls.Add(this.txtNombres);
            this.elGroupBox1.Controls.Add(this.labelX3);
            this.elGroupBox1.Controls.Add(this.labelX13);
            this.elGroupBox1.Controls.Add(this.labelX12);
            this.elGroupBox1.Controls.Add(this.labelX2);
            this.elGroupBox1.Controls.Add(this.cmbTipo);
            this.elGroupBox1.Controls.Add(this.labelX1);
            this.elGroupBox1.Location = new System.Drawing.Point(12, 58);
            this.elGroupBox1.Name = "elGroupBox1";
            this.elGroupBox1.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlue;
            this.elGroupBox1.Padding = new System.Windows.Forms.Padding(4, 27, 4, 3);
            this.elGroupBox1.Size = new System.Drawing.Size(515, 321);
            this.elGroupBox1.TabIndex = 1;
            // 
            // btAgregarCiudad
            // 
            this.btAgregarCiudad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btAgregarCiudad.BackColor = System.Drawing.Color.Transparent;
            this.btAgregarCiudad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btAgregarCiudad.Image = global::SistemaBiblioteca.Properties.Resources.btn_agregar;
            this.btAgregarCiudad.Location = new System.Drawing.Point(282, 287);
            this.btAgregarCiudad.Name = "btAgregarCiudad";
            this.btAgregarCiudad.Size = new System.Drawing.Size(29, 22);
            this.btAgregarCiudad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btAgregarCiudad.TabIndex = 21;
            // 
            // btActualizarCiudad
            // 
            this.btActualizarCiudad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btActualizarCiudad.BackColor = System.Drawing.Color.Transparent;
            this.btActualizarCiudad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btActualizarCiudad.Image = global::SistemaBiblioteca.Properties.Resources.Actualizar_16_16;
            this.btActualizarCiudad.Location = new System.Drawing.Point(253, 287);
            this.btActualizarCiudad.Name = "btActualizarCiudad";
            this.btActualizarCiudad.Size = new System.Drawing.Size(29, 22);
            this.btActualizarCiudad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btActualizarCiudad.TabIndex = 21;
            this.btActualizarCiudad.Click += new System.EventHandler(this.btActualizarCiudad_Click);
            // 
            // txtArea
            // 
            // 
            // 
            // 
            this.txtArea.Border.Class = "TextBoxBorder";
            this.txtArea.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtArea.Enabled = false;
            this.txtArea.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(342, 86);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(159, 20);
            this.txtArea.TabIndex = 6;
            // 
            // txtNInss
            // 
            // 
            // 
            // 
            this.txtNInss.Border.Class = "TextBoxBorder";
            this.txtNInss.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNInss.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNInss.Location = new System.Drawing.Point(329, 59);
            this.txtNInss.Name = "txtNInss";
            this.txtNInss.Size = new System.Drawing.Size(172, 20);
            this.txtNInss.TabIndex = 4;
            // 
            // txtIdentificacion
            // 
            // 
            // 
            // 
            this.txtIdentificacion.Border.Class = "TextBoxBorder";
            this.txtIdentificacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdentificacion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(342, 31);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(159, 20);
            this.txtIdentificacion.TabIndex = 2;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DisplayMember = "Text";
            this.cmbUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.ItemHeight = 14;
            this.cmbUsuario.Items.AddRange(new object[] {
            this.comboItem6,
            this.comboItem8,
            this.comboItem9,
            this.comboItem10});
            this.cmbUsuario.Location = new System.Drawing.Point(102, 59);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(152, 20);
            this.cmbUsuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbUsuario.TabIndex = 3;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "EXTERNO";
            // 
            // comboItem8
            // 
            this.comboItem8.Text = "DOCENTE HORARIO";
            // 
            // comboItem9
            // 
            this.comboItem9.Text = "DOCENTE FIJO";
            // 
            // comboItem10
            // 
            this.comboItem10.Text = "TRABAJADOR ADMINISTRATIVO";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DisplayMember = "Text";
            this.cmbDepartamento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.Enabled = false;
            this.cmbDepartamento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.ItemHeight = 14;
            this.cmbDepartamento.Items.AddRange(new object[] {
            this.comboItem3,
            this.comboItem4,
            this.comboItem5});
            this.cmbDepartamento.Location = new System.Drawing.Point(102, 86);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(152, 20);
            this.cmbDepartamento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbDepartamento.TabIndex = 5;
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "CIENCIA TECNOLOGÍA Y SALUD";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "CIENCIAS ECONÓMICAS Y ADMINISTRATIVAS";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "CIENCIAS DE LA EDUCACIÓN Y HUMANIDADES";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DisplayMember = "Text";
            this.cmbCiudad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.ItemHeight = 14;
            this.cmbCiudad.Location = new System.Drawing.Point(57, 288);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(196, 20);
            this.cmbCiudad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbCiudad.TabIndex = 19;
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.Class = "";
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(12, 58);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(129, 21);
            this.labelX11.TabIndex = 3;
            this.labelX11.Text = "Tipo de Usuario:";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(12, 85);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(129, 21);
            this.labelX10.TabIndex = 5;
            this.labelX10.Text = "Dpt. Académico:";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(11, 287);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(129, 21);
            this.labelX9.TabIndex = 18;
            this.labelX9.Text = "Ciudad:";
            // 
            // txtObservacion
            // 
            // 
            // 
            // 
            this.txtObservacion.Border.Class = "TextBoxBorder";
            this.txtObservacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtObservacion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(85, 228);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(416, 53);
            this.txtObservacion.TabIndex = 12;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(11, 227);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(97, 21);
            this.labelX8.TabIndex = 12;
            this.labelX8.Text = "Observación:";
            // 
            // txtDomicilio
            // 
            // 
            // 
            // 
            this.txtDomicilio.Border.Class = "TextBoxBorder";
            this.txtDomicilio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDomicilio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.Location = new System.Drawing.Point(69, 168);
            this.txtDomicilio.Multiline = true;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(432, 53);
            this.txtDomicilio.TabIndex = 11;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(11, 167);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(97, 21);
            this.labelX7.TabIndex = 11;
            this.labelX7.Text = "Domicilio:";
            // 
            // txtTelefono
            // 
            // 
            // 
            // 
            this.txtTelefono.BackgroundStyle.Class = "TextBoxBorder";
            this.txtTelefono.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTelefono.ButtonClear.Visible = true;
            this.txtTelefono.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(362, 141);
            this.txtTelefono.Mask = "0000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(139, 20);
            this.txtTelefono.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtTelefono.TabIndex = 10;
            this.txtTelefono.Text = "";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(259, 140);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(97, 21);
            this.labelX6.TabIndex = 10;
            this.labelX6.Text = "Teléfono:";
            // 
            // dtpFechaNacimiento
            // 
            // 
            // 
            // 
            this.dtpFechaNacimiento.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpFechaNacimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaNacimiento.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpFechaNacimiento.ButtonDropDown.Visible = true;
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(146, 141);
            // 
            // 
            // 
            this.dtpFechaNacimiento.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpFechaNacimiento.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpFechaNacimiento.MonthCalendar.BackgroundStyle.Class = "";
            this.dtpFechaNacimiento.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaNacimiento.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtpFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaNacimiento.MonthCalendar.DisplayMonth = new System.DateTime(2015, 2, 1, 0, 0, 0, 0);
            this.dtpFechaNacimiento.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtpFechaNacimiento.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpFechaNacimiento.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpFechaNacimiento.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpFechaNacimiento.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpFechaNacimiento.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpFechaNacimiento.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtpFechaNacimiento.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaNacimiento.MonthCalendar.TodayButtonVisible = true;
            this.dtpFechaNacimiento.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(107, 20);
            this.dtpFechaNacimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpFechaNacimiento.TabIndex = 9;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(11, 140);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(129, 21);
            this.labelX5.TabIndex = 9;
            this.labelX5.Text = "Fecha de Nacimiento:";
            // 
            // txtApellidos
            // 
            // 
            // 
            // 
            this.txtApellidos.Border.Class = "TextBoxBorder";
            this.txtApellidos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtApellidos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(329, 113);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(172, 20);
            this.txtApellidos.TabIndex = 8;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(259, 112);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(97, 21);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "Apellidos:";
            // 
            // txtNombres
            // 
            // 
            // 
            // 
            this.txtNombres.Border.Class = "TextBoxBorder";
            this.txtNombres.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNombres.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(69, 114);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(184, 20);
            this.txtNombres.TabIndex = 7;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(11, 113);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(97, 21);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "Nombres:";
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.Class = "";
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(260, 85);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(97, 21);
            this.labelX13.TabIndex = 6;
            this.labelX13.Text = "Área Laboral:";
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.Class = "";
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(260, 58);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(97, 21);
            this.labelX12.TabIndex = 4;
            this.labelX12.Text = "Nº de INSS:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(260, 30);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(97, 21);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Identificación:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DisplayMember = "Text";
            this.cmbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.ItemHeight = 14;
            this.cmbTipo.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cmbTipo.Location = new System.Drawing.Point(135, 31);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(119, 20);
            this.cmbTipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbTipo.TabIndex = 1;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "CÉDULA";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "PASAPORTE";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 30);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(129, 21);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Tipo de Identificación:";
            // 
            // frmVisitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 394);
            this.Controls.Add(this.elGroupBox1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVisitante";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición de Visitantes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVisitante_FormClosing);
            this.Load += new System.EventHandler(this.frmVisitante_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kFormManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elGroupBox1)).EndInit();
            this.elGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaNacimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Klik.Windows.Forms.v1.Common.KFormManager kFormManager1;
        private Klik.Windows.Forms.v1.EntryLib.ELGroupBox elGroupBox1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.LabelX labelX1;
        public DevComponents.DotNetBar.Controls.TextBoxX txtNombres;
        public DevComponents.DotNetBar.Controls.TextBoxX txtApellidos;
        public DevComponents.Editors.DateTimeAdv.DateTimeInput dtpFechaNacimiento;
        public DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtTelefono;
        public DevComponents.DotNetBar.Controls.TextBoxX txtDomicilio;
        public DevComponents.DotNetBar.Controls.TextBoxX txtObservacion;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmbCiudad;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmbTipo;
        public DevComponents.DotNetBar.Controls.TextBoxX txtIdentificacion;
        public System.Windows.Forms.ToolStripButton btNuevo;
        public System.Windows.Forms.ToolStripButton btGuardar;
        public System.Windows.Forms.ToolStripButton btEditar;
        public System.Windows.Forms.ToolStripButton btEliminar;
        public System.Windows.Forms.ToolStripButton btBuscar;
        internal DevComponents.DotNetBar.ButtonX btActualizarCiudad;
        internal DevComponents.DotNetBar.ButtonX btAgregarCiudad;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmbDepartamento;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmbUsuario;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.Editors.ComboItem comboItem8;
        private DevComponents.Editors.ComboItem comboItem9;
        private DevComponents.Editors.ComboItem comboItem10;
        public DevComponents.DotNetBar.Controls.TextBoxX txtNInss;
        private DevComponents.DotNetBar.LabelX labelX12;
        public DevComponents.DotNetBar.Controls.TextBoxX txtArea;
        private DevComponents.DotNetBar.LabelX labelX13;
    }
}