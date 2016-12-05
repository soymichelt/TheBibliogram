<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLibro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btEditar = New System.Windows.Forms.ToolStripButton()
        Me.btEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ElGroupBox7 = New Klik.Windows.Forms.v1.EntryLib.ELGroupBox()
        Me.dtEncabezados = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.btActualizarEncabezado = New DevComponents.DotNetBar.ButtonX()
        Me.cmbEncabezado = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ElGroupBox6 = New Klik.Windows.Forms.v1.EntryLib.ELGroupBox()
        Me.txtIdTutor = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btAgregarTutor = New DevComponents.DotNetBar.ButtonX()
        Me.btBuscarTutor = New DevComponents.DotNetBar.ButtonX()
        Me.txtTutor = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btActualizarGrado = New DevComponents.DotNetBar.ButtonX()
        Me.cmbGrado = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbTipoInvestigacion = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ElGroupBox5 = New Klik.Windows.Forms.v1.EntryLib.ELGroupBox()
        Me.txtIdCiudad = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btAgregarCiudad = New DevComponents.DotNetBar.ButtonX()
        Me.btBuscarCiudad = New DevComponents.DotNetBar.ButtonX()
        Me.txtCiudad = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtEdicion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtFechaPublicacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btActualizarEditor = New DevComponents.DotNetBar.ButtonX()
        Me.cmbEditor = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ElGroupBox4 = New Klik.Windows.Forms.v1.EntryLib.ELGroupBox()
        Me.txtColacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtResumen = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNotas = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtOtroCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtIsbn = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btActualizarIdioma = New DevComponents.DotNetBar.ButtonX()
        Me.cmbIdioma = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSignatura = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbAutorInstitucional = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ElGroupBox2 = New Klik.Windows.Forms.v1.EntryLib.ELGroupBox()
        Me.btActualizarInstitucion = New DevComponents.DotNetBar.ButtonX()
        Me.txtAutor3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAutor2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAutor1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ElGroupBox1 = New Klik.Windows.Forms.v1.EntryLib.ELGroupBox()
        Me.txtOtroTitulo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTitulo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTipoRegistro = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTipoDocumento = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KFormManager1 = New Klik.Windows.Forms.v1.Common.KFormManager(Me.components)
        Me.ElGroupBox8 = New Klik.Windows.Forms.v1.EntryLib.ELGroupBox()
        Me.txtNRegistro = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.chkInventarioInicial = New System.Windows.Forms.CheckBox()
        Me.dtCopias = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.btAgregarRegistro = New DevComponents.DotNetBar.ButtonX()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel()
        Me.ElGroupBox10 = New Klik.Windows.Forms.v1.EntryLib.ELGroupBox()
        Me.txtCita = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtEstilo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtNorma = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.ElGroupBox9 = New Klik.Windows.Forms.v1.EntryLib.ELGroupBox()
        Me.picImagenLibro = New System.Windows.Forms.PictureBox()
        Me.btBorrarImagen = New DevComponents.DotNetBar.ButtonX()
        Me.btExaminar = New DevComponents.DotNetBar.ButtonX()
        Me.txtImagen = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TabItem3 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.opExaminar = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ElGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElGroupBox7.SuspendLayout()
        CType(Me.dtEncabezados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElGroupBox6.SuspendLayout()
        CType(Me.ElGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElGroupBox5.SuspendLayout()
        CType(Me.ElGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElGroupBox4.SuspendLayout()
        CType(Me.ElGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElGroupBox2.SuspendLayout()
        CType(Me.ElGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElGroupBox1.SuspendLayout()
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElGroupBox8.SuspendLayout()
        CType(Me.dtCopias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel3.SuspendLayout()
        CType(Me.ElGroupBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElGroupBox10.SuspendLayout()
        CType(Me.ElGroupBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElGroupBox9.SuspendLayout()
        CType(Me.picImagenLibro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel1.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btNuevo, Me.btGuardar, Me.btEditar, Me.btEliminar, Me.ToolStripSeparator1, Me.btBuscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(659, 39)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btNuevo
        '
        Me.btNuevo.ForeColor = System.Drawing.Color.Black
        Me.btNuevo.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.Nuevo
        Me.btNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(101, 36)
        Me.btNuevo.Text = "F1 - Nuevo"
        '
        'btGuardar
        '
        Me.btGuardar.ForeColor = System.Drawing.Color.Black
        Me.btGuardar.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.Guardar
        Me.btGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(108, 36)
        Me.btGuardar.Text = "F2 - Guardar"
        '
        'btEditar
        '
        Me.btEditar.Enabled = False
        Me.btEditar.ForeColor = System.Drawing.Color.Black
        Me.btEditar.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.Editar
        Me.btEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(96, 36)
        Me.btEditar.Text = "F3 - Editar"
        '
        'btEliminar
        '
        Me.btEliminar.Enabled = False
        Me.btEliminar.ForeColor = System.Drawing.Color.Black
        Me.btEliminar.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.Eliminar
        Me.btEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(109, 36)
        Me.btEliminar.Text = "F4 - Eliminar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btBuscar
        '
        Me.btBuscar.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.Buscar
        Me.btBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(101, 36)
        Me.btBuscar.Text = "F5 - Buscar"
        '
        'ElGroupBox7
        '
        Me.ElGroupBox7.BackgroundStyle.GradientAngle = 45.0!
        Me.ElGroupBox7.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox7.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox7.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaption
        Me.ElGroupBox7.CaptionStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox7.CaptionStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox7.CaptionStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox7.CaptionStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox7.CaptionStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox7.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox7.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElGroupBox7.CaptionStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox7.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.ElGroupBox7.CaptionStyle.TextStyle.Text = "Encabezados"
        Me.ElGroupBox7.CaptionStyle.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox7.Controls.Add(Me.dtEncabezados)
        Me.ElGroupBox7.Controls.Add(Me.btActualizarEncabezado)
        Me.ElGroupBox7.Controls.Add(Me.cmbEncabezado)
        Me.ElGroupBox7.Controls.Add(Me.Label21)
        Me.ElGroupBox7.Location = New System.Drawing.Point(12, 159)
        Me.ElGroupBox7.Name = "ElGroupBox7"
        Me.ElGroupBox7.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.ElGroupBox7.Padding = New System.Windows.Forms.Padding(4, 27, 4, 3)
        Me.ElGroupBox7.Size = New System.Drawing.Size(313, 182)
        Me.ElGroupBox7.TabIndex = 7
        '
        'dtEncabezados
        '
        Me.dtEncabezados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtEncabezados.DefaultCellStyle = DataGridViewCellStyle9
        Me.dtEncabezados.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dtEncabezados.Location = New System.Drawing.Point(12, 61)
        Me.dtEncabezados.Name = "dtEncabezados"
        Me.dtEncabezados.Size = New System.Drawing.Size(291, 107)
        Me.dtEncabezados.TabIndex = 56
        '
        'btActualizarEncabezado
        '
        Me.btActualizarEncabezado.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btActualizarEncabezado.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btActualizarEncabezado.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.Actualizar_16_16
        Me.btActualizarEncabezado.Location = New System.Drawing.Point(280, 33)
        Me.btActualizarEncabezado.Name = "btActualizarEncabezado"
        Me.btActualizarEncabezado.Size = New System.Drawing.Size(23, 25)
        Me.btActualizarEncabezado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btActualizarEncabezado.TabIndex = 55
        '
        'cmbEncabezado
        '
        Me.cmbEncabezado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEncabezado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEncabezado.DisplayMember = "Text"
        Me.cmbEncabezado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbEncabezado.FormattingEnabled = True
        Me.cmbEncabezado.ItemHeight = 14
        Me.cmbEncabezado.Location = New System.Drawing.Point(53, 35)
        Me.cmbEncabezado.Name = "cmbEncabezado"
        Me.cmbEncabezado.Size = New System.Drawing.Size(244, 20)
        Me.cmbEncabezado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbEncabezado.TabIndex = 54
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(9, 36)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(38, 14)
        Me.Label21.TabIndex = 52
        Me.Label21.Text = " Tema:"
        '
        'ElGroupBox6
        '
        Me.ElGroupBox6.BackgroundStyle.GradientAngle = 45.0!
        Me.ElGroupBox6.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox6.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox6.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaption
        Me.ElGroupBox6.CaptionStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox6.CaptionStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox6.CaptionStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox6.CaptionStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox6.CaptionStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox6.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox6.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElGroupBox6.CaptionStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox6.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.ElGroupBox6.CaptionStyle.TextStyle.Text = "Investigación"
        Me.ElGroupBox6.CaptionStyle.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox6.Controls.Add(Me.txtIdTutor)
        Me.ElGroupBox6.Controls.Add(Me.btAgregarTutor)
        Me.ElGroupBox6.Controls.Add(Me.btBuscarTutor)
        Me.ElGroupBox6.Controls.Add(Me.txtTutor)
        Me.ElGroupBox6.Controls.Add(Me.Label20)
        Me.ElGroupBox6.Controls.Add(Me.btActualizarGrado)
        Me.ElGroupBox6.Controls.Add(Me.cmbGrado)
        Me.ElGroupBox6.Controls.Add(Me.Label22)
        Me.ElGroupBox6.Controls.Add(Me.cmbTipoInvestigacion)
        Me.ElGroupBox6.Controls.Add(Me.Label23)
        Me.ElGroupBox6.Location = New System.Drawing.Point(331, 4)
        Me.ElGroupBox6.Name = "ElGroupBox6"
        Me.ElGroupBox6.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.ElGroupBox6.Padding = New System.Windows.Forms.Padding(4, 27, 4, 3)
        Me.ElGroupBox6.Size = New System.Drawing.Size(313, 149)
        Me.ElGroupBox6.TabIndex = 6
        '
        'txtIdTutor
        '
        '
        '
        '
        Me.txtIdTutor.Border.Class = "TextBoxBorder"
        Me.txtIdTutor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdTutor.Location = New System.Drawing.Point(47, 92)
        Me.txtIdTutor.Name = "txtIdTutor"
        Me.txtIdTutor.Size = New System.Drawing.Size(10, 20)
        Me.txtIdTutor.TabIndex = 33
        Me.txtIdTutor.Visible = False
        '
        'btAgregarTutor
        '
        Me.btAgregarTutor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAgregarTutor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAgregarTutor.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.btn_agregar
        Me.btAgregarTutor.Location = New System.Drawing.Point(280, 89)
        Me.btAgregarTutor.Name = "btAgregarTutor"
        Me.btAgregarTutor.Size = New System.Drawing.Size(23, 25)
        Me.btAgregarTutor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btAgregarTutor.TabIndex = 52
        '
        'btBuscarTutor
        '
        Me.btBuscarTutor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btBuscarTutor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btBuscarTutor.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.btn_buscar
        Me.btBuscarTutor.Location = New System.Drawing.Point(257, 89)
        Me.btBuscarTutor.Name = "btBuscarTutor"
        Me.btBuscarTutor.Size = New System.Drawing.Size(23, 25)
        Me.btBuscarTutor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btBuscarTutor.TabIndex = 51
        '
        'txtTutor
        '
        '
        '
        '
        Me.txtTutor.Border.Class = "TextBoxBorder"
        Me.txtTutor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTutor.Enabled = False
        Me.txtTutor.Location = New System.Drawing.Point(59, 92)
        Me.txtTutor.Name = "txtTutor"
        Me.txtTutor.Size = New System.Drawing.Size(199, 20)
        Me.txtTutor.TabIndex = 50
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 94)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(35, 14)
        Me.Label20.TabIndex = 49
        Me.Label20.Text = "Tutor:"
        '
        'btActualizarGrado
        '
        Me.btActualizarGrado.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btActualizarGrado.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btActualizarGrado.Enabled = False
        Me.btActualizarGrado.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.Actualizar_16_16
        Me.btActualizarGrado.Location = New System.Drawing.Point(280, 61)
        Me.btActualizarGrado.Name = "btActualizarGrado"
        Me.btActualizarGrado.Size = New System.Drawing.Size(23, 25)
        Me.btActualizarGrado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btActualizarGrado.TabIndex = 48
        '
        'cmbGrado
        '
        Me.cmbGrado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbGrado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbGrado.DisplayMember = "Text"
        Me.cmbGrado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbGrado.Enabled = False
        Me.cmbGrado.FormattingEnabled = True
        Me.cmbGrado.ItemHeight = 14
        Me.cmbGrado.Location = New System.Drawing.Point(111, 64)
        Me.cmbGrado.Name = "cmbGrado"
        Me.cmbGrado.Size = New System.Drawing.Size(186, 20)
        Me.cmbGrado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbGrado.TabIndex = 47
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(9, 65)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 14)
        Me.Label22.TabIndex = 46
        Me.Label22.Text = "Grado Acádemico:"
        '
        'cmbTipoInvestigacion
        '
        Me.cmbTipoInvestigacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipoInvestigacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoInvestigacion.DisplayMember = "Text"
        Me.cmbTipoInvestigacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTipoInvestigacion.Enabled = False
        Me.cmbTipoInvestigacion.FormattingEnabled = True
        Me.cmbTipoInvestigacion.ItemHeight = 14
        Me.cmbTipoInvestigacion.Location = New System.Drawing.Point(126, 36)
        Me.cmbTipoInvestigacion.Name = "cmbTipoInvestigacion"
        Me.cmbTipoInvestigacion.Size = New System.Drawing.Size(177, 20)
        Me.cmbTipoInvestigacion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbTipoInvestigacion.TabIndex = 45
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(9, 37)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(111, 14)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "Tipo de Investigación:"
        '
        'ElGroupBox5
        '
        Me.ElGroupBox5.BackgroundStyle.GradientAngle = 45.0!
        Me.ElGroupBox5.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox5.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox5.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaption
        Me.ElGroupBox5.CaptionStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox5.CaptionStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox5.CaptionStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox5.CaptionStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox5.CaptionStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox5.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox5.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElGroupBox5.CaptionStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox5.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.ElGroupBox5.CaptionStyle.TextStyle.Text = "Editorial"
        Me.ElGroupBox5.CaptionStyle.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox5.Controls.Add(Me.txtIdCiudad)
        Me.ElGroupBox5.Controls.Add(Me.btAgregarCiudad)
        Me.ElGroupBox5.Controls.Add(Me.btBuscarCiudad)
        Me.ElGroupBox5.Controls.Add(Me.txtCiudad)
        Me.ElGroupBox5.Controls.Add(Me.txtEdicion)
        Me.ElGroupBox5.Controls.Add(Me.Label19)
        Me.ElGroupBox5.Controls.Add(Me.txtFechaPublicacion)
        Me.ElGroupBox5.Controls.Add(Me.Label18)
        Me.ElGroupBox5.Controls.Add(Me.btActualizarEditor)
        Me.ElGroupBox5.Controls.Add(Me.cmbEditor)
        Me.ElGroupBox5.Controls.Add(Me.Label17)
        Me.ElGroupBox5.Controls.Add(Me.Label16)
        Me.ElGroupBox5.Location = New System.Drawing.Point(12, 4)
        Me.ElGroupBox5.Name = "ElGroupBox5"
        Me.ElGroupBox5.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.ElGroupBox5.Padding = New System.Windows.Forms.Padding(4, 27, 4, 3)
        Me.ElGroupBox5.Size = New System.Drawing.Size(313, 149)
        Me.ElGroupBox5.TabIndex = 5
        '
        'txtIdCiudad
        '
        '
        '
        '
        Me.txtIdCiudad.Border.Class = "TextBoxBorder"
        Me.txtIdCiudad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdCiudad.Location = New System.Drawing.Point(52, 35)
        Me.txtIdCiudad.Name = "txtIdCiudad"
        Me.txtIdCiudad.Size = New System.Drawing.Size(5, 20)
        Me.txtIdCiudad.TabIndex = 30
        Me.txtIdCiudad.Visible = False
        '
        'btAgregarCiudad
        '
        Me.btAgregarCiudad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAgregarCiudad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAgregarCiudad.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.btn_agregar
        Me.btAgregarCiudad.Location = New System.Drawing.Point(280, 32)
        Me.btAgregarCiudad.Name = "btAgregarCiudad"
        Me.btAgregarCiudad.Size = New System.Drawing.Size(23, 25)
        Me.btAgregarCiudad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btAgregarCiudad.TabIndex = 36
        '
        'btBuscarCiudad
        '
        Me.btBuscarCiudad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btBuscarCiudad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btBuscarCiudad.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.btn_buscar
        Me.btBuscarCiudad.Location = New System.Drawing.Point(257, 32)
        Me.btBuscarCiudad.Name = "btBuscarCiudad"
        Me.btBuscarCiudad.Size = New System.Drawing.Size(23, 25)
        Me.btBuscarCiudad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btBuscarCiudad.TabIndex = 35
        '
        'txtCiudad
        '
        '
        '
        '
        Me.txtCiudad.Border.Class = "TextBoxBorder"
        Me.txtCiudad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCiudad.Location = New System.Drawing.Point(59, 35)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(199, 20)
        Me.txtCiudad.TabIndex = 34
        '
        'txtEdicion
        '
        '
        '
        '
        Me.txtEdicion.Border.Class = "TextBoxBorder"
        Me.txtEdicion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEdicion.Location = New System.Drawing.Point(59, 114)
        Me.txtEdicion.Name = "txtEdicion"
        Me.txtEdicion.Size = New System.Drawing.Size(244, 20)
        Me.txtEdicion.TabIndex = 43
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 116)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 14)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Edición:"
        '
        'txtFechaPublicacion
        '
        '
        '
        '
        Me.txtFechaPublicacion.Border.Class = "TextBoxBorder"
        Me.txtFechaPublicacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFechaPublicacion.Location = New System.Drawing.Point(86, 89)
        Me.txtFechaPublicacion.Name = "txtFechaPublicacion"
        Me.txtFechaPublicacion.Size = New System.Drawing.Size(217, 20)
        Me.txtFechaPublicacion.TabIndex = 41
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 91)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 14)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Publicado el:"
        '
        'btActualizarEditor
        '
        Me.btActualizarEditor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btActualizarEditor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btActualizarEditor.Enabled = False
        Me.btActualizarEditor.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.Actualizar_16_16
        Me.btActualizarEditor.Location = New System.Drawing.Point(280, 62)
        Me.btActualizarEditor.Name = "btActualizarEditor"
        Me.btActualizarEditor.Size = New System.Drawing.Size(23, 25)
        Me.btActualizarEditor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btActualizarEditor.TabIndex = 39
        '
        'cmbEditor
        '
        Me.cmbEditor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEditor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEditor.DisplayMember = "Text"
        Me.cmbEditor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbEditor.FormattingEnabled = True
        Me.cmbEditor.ItemHeight = 14
        Me.cmbEditor.Location = New System.Drawing.Point(59, 64)
        Me.cmbEditor.Name = "cmbEditor"
        Me.cmbEditor.Size = New System.Drawing.Size(238, 20)
        Me.cmbEditor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbEditor.TabIndex = 38
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 65)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 14)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Editor:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 37)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 14)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Ciudad:"
        '
        'ElGroupBox4
        '
        Me.ElGroupBox4.BackgroundStyle.GradientAngle = 45.0!
        Me.ElGroupBox4.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox4.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox4.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaption
        Me.ElGroupBox4.CaptionStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox4.CaptionStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox4.CaptionStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox4.CaptionStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox4.CaptionStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox4.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox4.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElGroupBox4.CaptionStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox4.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.ElGroupBox4.CaptionStyle.TextStyle.Text = "Registros"
        Me.ElGroupBox4.CaptionStyle.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox4.Controls.Add(Me.txtColacion)
        Me.ElGroupBox4.Controls.Add(Me.txtResumen)
        Me.ElGroupBox4.Controls.Add(Me.Label15)
        Me.ElGroupBox4.Controls.Add(Me.txtNotas)
        Me.ElGroupBox4.Controls.Add(Me.Label14)
        Me.ElGroupBox4.Controls.Add(Me.txtOtroCodigo)
        Me.ElGroupBox4.Controls.Add(Me.Label13)
        Me.ElGroupBox4.Controls.Add(Me.txtIsbn)
        Me.ElGroupBox4.Controls.Add(Me.Label11)
        Me.ElGroupBox4.Controls.Add(Me.Label9)
        Me.ElGroupBox4.Controls.Add(Me.btActualizarIdioma)
        Me.ElGroupBox4.Controls.Add(Me.cmbIdioma)
        Me.ElGroupBox4.Controls.Add(Me.Label8)
        Me.ElGroupBox4.Location = New System.Drawing.Point(12, 161)
        Me.ElGroupBox4.Name = "ElGroupBox4"
        Me.ElGroupBox4.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.ElGroupBox4.Padding = New System.Windows.Forms.Padding(4, 27, 4, 3)
        Me.ElGroupBox4.Size = New System.Drawing.Size(633, 180)
        Me.ElGroupBox4.TabIndex = 4
        '
        'txtColacion
        '
        '
        '
        '
        Me.txtColacion.Border.Class = "TextBoxBorder"
        Me.txtColacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtColacion.Location = New System.Drawing.Point(440, 37)
        Me.txtColacion.Name = "txtColacion"
        Me.txtColacion.Size = New System.Drawing.Size(176, 20)
        Me.txtColacion.TabIndex = 24
        '
        'txtResumen
        '
        '
        '
        '
        Me.txtResumen.Border.Class = "TextBoxBorder"
        Me.txtResumen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtResumen.Location = New System.Drawing.Point(72, 134)
        Me.txtResumen.Multiline = True
        Me.txtResumen.Name = "txtResumen"
        Me.txtResumen.Size = New System.Drawing.Size(544, 35)
        Me.txtResumen.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 14)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Resumen:"
        '
        'txtNotas
        '
        '
        '
        '
        Me.txtNotas.Border.Class = "TextBoxBorder"
        Me.txtNotas.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNotas.Location = New System.Drawing.Point(57, 92)
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.Size = New System.Drawing.Size(559, 35)
        Me.txtNotas.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 14)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Notas:"
        '
        'txtOtroCodigo
        '
        '
        '
        '
        Me.txtOtroCodigo.Border.Class = "TextBoxBorder"
        Me.txtOtroCodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtOtroCodigo.Location = New System.Drawing.Point(440, 65)
        Me.txtOtroCodigo.Name = "txtOtroCodigo"
        Me.txtOtroCodigo.Size = New System.Drawing.Size(176, 20)
        Me.txtOtroCodigo.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(367, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 14)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Otro Código:"
        '
        'txtIsbn
        '
        '
        '
        '
        Me.txtIsbn.Border.Class = "TextBoxBorder"
        Me.txtIsbn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIsbn.Location = New System.Drawing.Point(65, 65)
        Me.txtIsbn.Name = "txtIsbn"
        Me.txtIsbn.Size = New System.Drawing.Size(176, 20)
        Me.txtIsbn.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 14)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Nº ISBN:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(383, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 14)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Colación:"
        '
        'btActualizarIdioma
        '
        Me.btActualizarIdioma.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btActualizarIdioma.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btActualizarIdioma.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.Actualizar_16_16
        Me.btActualizarIdioma.Location = New System.Drawing.Point(217, 34)
        Me.btActualizarIdioma.Name = "btActualizarIdioma"
        Me.btActualizarIdioma.Size = New System.Drawing.Size(23, 25)
        Me.btActualizarIdioma.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btActualizarIdioma.TabIndex = 22
        '
        'cmbIdioma
        '
        Me.cmbIdioma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbIdioma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbIdioma.DisplayMember = "Text"
        Me.cmbIdioma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbIdioma.FormattingEnabled = True
        Me.cmbIdioma.ItemHeight = 14
        Me.cmbIdioma.Location = New System.Drawing.Point(57, 37)
        Me.cmbIdioma.Name = "cmbIdioma"
        Me.cmbIdioma.Size = New System.Drawing.Size(177, 20)
        Me.cmbIdioma.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbIdioma.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 14)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Idioma:"
        '
        'txtSignatura
        '
        '
        '
        '
        Me.txtSignatura.Border.Class = "TextBoxBorder"
        Me.txtSignatura.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSignatura.Location = New System.Drawing.Point(64, 64)
        Me.txtSignatura.Name = "txtSignatura"
        Me.txtSignatura.Size = New System.Drawing.Size(113, 20)
        Me.txtSignatura.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 14)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Sig. Top.:"
        '
        'cmbAutorInstitucional
        '
        Me.cmbAutorInstitucional.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAutorInstitucional.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAutorInstitucional.DisplayMember = "Text"
        Me.cmbAutorInstitucional.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbAutorInstitucional.Enabled = False
        Me.cmbAutorInstitucional.FormattingEnabled = True
        Me.cmbAutorInstitucional.ItemHeight = 14
        Me.cmbAutorInstitucional.Location = New System.Drawing.Point(113, 120)
        Me.cmbAutorInstitucional.Name = "cmbAutorInstitucional"
        Me.cmbAutorInstitucional.Size = New System.Drawing.Size(158, 20)
        Me.cmbAutorInstitucional.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbAutorInstitucional.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 14)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Autor Institucional:"
        '
        'ElGroupBox2
        '
        Me.ElGroupBox2.BackgroundStyle.GradientAngle = 45.0!
        Me.ElGroupBox2.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox2.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox2.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaption
        Me.ElGroupBox2.CaptionStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox2.CaptionStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox2.CaptionStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox2.CaptionStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox2.CaptionStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox2.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox2.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElGroupBox2.CaptionStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox2.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.ElGroupBox2.CaptionStyle.TextStyle.Text = "Autor Personal"
        Me.ElGroupBox2.CaptionStyle.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox2.Controls.Add(Me.btActualizarInstitucion)
        Me.ElGroupBox2.Controls.Add(Me.txtAutor3)
        Me.ElGroupBox2.Controls.Add(Me.cmbAutorInstitucional)
        Me.ElGroupBox2.Controls.Add(Me.txtAutor2)
        Me.ElGroupBox2.Controls.Add(Me.Label10)
        Me.ElGroupBox2.Controls.Add(Me.txtAutor1)
        Me.ElGroupBox2.Controls.Add(Me.Label7)
        Me.ElGroupBox2.Controls.Add(Me.Label6)
        Me.ElGroupBox2.Controls.Add(Me.Label5)
        Me.ElGroupBox2.Location = New System.Drawing.Point(351, 4)
        Me.ElGroupBox2.Name = "ElGroupBox2"
        Me.ElGroupBox2.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.ElGroupBox2.Padding = New System.Windows.Forms.Padding(4, 27, 4, 3)
        Me.ElGroupBox2.Size = New System.Drawing.Size(294, 151)
        Me.ElGroupBox2.TabIndex = 2
        '
        'btActualizarInstitucion
        '
        Me.btActualizarInstitucion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btActualizarInstitucion.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btActualizarInstitucion.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.Actualizar_16_16
        Me.btActualizarInstitucion.Location = New System.Drawing.Point(254, 117)
        Me.btActualizarInstitucion.Name = "btActualizarInstitucion"
        Me.btActualizarInstitucion.Size = New System.Drawing.Size(23, 25)
        Me.btActualizarInstitucion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btActualizarInstitucion.TabIndex = 23
        '
        'txtAutor3
        '
        '
        '
        '
        Me.txtAutor3.Border.Class = "TextBoxBorder"
        Me.txtAutor3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAutor3.Enabled = False
        Me.txtAutor3.Location = New System.Drawing.Point(99, 92)
        Me.txtAutor3.Name = "txtAutor3"
        Me.txtAutor3.Size = New System.Drawing.Size(178, 20)
        Me.txtAutor3.TabIndex = 16
        '
        'txtAutor2
        '
        '
        '
        '
        Me.txtAutor2.Border.Class = "TextBoxBorder"
        Me.txtAutor2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAutor2.Enabled = False
        Me.txtAutor2.Location = New System.Drawing.Point(99, 64)
        Me.txtAutor2.Name = "txtAutor2"
        Me.txtAutor2.Size = New System.Drawing.Size(178, 20)
        Me.txtAutor2.TabIndex = 14
        '
        'txtAutor1
        '
        '
        '
        '
        Me.txtAutor1.Border.Class = "TextBoxBorder"
        Me.txtAutor1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAutor1.Enabled = False
        Me.txtAutor1.Location = New System.Drawing.Point(99, 36)
        Me.txtAutor1.Name = "txtAutor1"
        Me.txtAutor1.Size = New System.Drawing.Size(178, 20)
        Me.txtAutor1.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 14)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Tercer Autor:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 14)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Segundo Autor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 14)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Primer Autor:"
        '
        'ElGroupBox1
        '
        Me.ElGroupBox1.BackgroundStyle.GradientAngle = 45.0!
        Me.ElGroupBox1.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox1.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox1.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaption
        Me.ElGroupBox1.CaptionStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox1.CaptionStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox1.CaptionStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox1.CaptionStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox1.CaptionStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox1.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox1.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElGroupBox1.CaptionStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox1.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.ElGroupBox1.CaptionStyle.TextStyle.Text = "Bibliográficos"
        Me.ElGroupBox1.CaptionStyle.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox1.Controls.Add(Me.txtOtroTitulo)
        Me.ElGroupBox1.Controls.Add(Me.Label4)
        Me.ElGroupBox1.Controls.Add(Me.txtTitulo)
        Me.ElGroupBox1.Controls.Add(Me.Label3)
        Me.ElGroupBox1.Controls.Add(Me.cmbTipoRegistro)
        Me.ElGroupBox1.Controls.Add(Me.Label2)
        Me.ElGroupBox1.Controls.Add(Me.cmbTipoDocumento)
        Me.ElGroupBox1.Controls.Add(Me.txtSignatura)
        Me.ElGroupBox1.Controls.Add(Me.Label1)
        Me.ElGroupBox1.Controls.Add(Me.Label12)
        Me.ElGroupBox1.Location = New System.Drawing.Point(12, 4)
        Me.ElGroupBox1.Name = "ElGroupBox1"
        Me.ElGroupBox1.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.ElGroupBox1.Padding = New System.Windows.Forms.Padding(4, 27, 4, 3)
        Me.ElGroupBox1.Size = New System.Drawing.Size(333, 151)
        Me.ElGroupBox1.TabIndex = 1
        '
        'txtOtroTitulo
        '
        '
        '
        '
        Me.txtOtroTitulo.Border.Class = "TextBoxBorder"
        Me.txtOtroTitulo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtOtroTitulo.Location = New System.Drawing.Point(72, 120)
        Me.txtOtroTitulo.Name = "txtOtroTitulo"
        Me.txtOtroTitulo.Size = New System.Drawing.Size(247, 20)
        Me.txtOtroTitulo.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Otro Título:"
        '
        'txtTitulo
        '
        '
        '
        '
        Me.txtTitulo.Border.Class = "TextBoxBorder"
        Me.txtTitulo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTitulo.Location = New System.Drawing.Point(51, 92)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(268, 20)
        Me.txtTitulo.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Título:"
        '
        'cmbTipoRegistro
        '
        Me.cmbTipoRegistro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipoRegistro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoRegistro.DisplayMember = "Text"
        Me.cmbTipoRegistro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTipoRegistro.FormattingEnabled = True
        Me.cmbTipoRegistro.ItemHeight = 14
        Me.cmbTipoRegistro.Location = New System.Drawing.Point(276, 35)
        Me.cmbTipoRegistro.Name = "cmbTipoRegistro"
        Me.cmbTipoRegistro.Size = New System.Drawing.Size(45, 20)
        Me.cmbTipoRegistro.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbTipoRegistro.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(201, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo Registro:"
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipoDocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoDocumento.DisplayMember = "Text"
        Me.cmbTipoDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTipoDocumento.FormattingEnabled = True
        Me.cmbTipoDocumento.ItemHeight = 14
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(98, 35)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(86, 20)
        Me.cmbTipoDocumento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbTipoDocumento.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo Documento:"
        '
        'KFormManager1
        '
        Me.KFormManager1.BackgroundImageStyle.Alpha = 100
        Me.KFormManager1.BackgroundImageStyle.ImageEffect = Klik.Windows.Forms.v1.Common.ImageEffect.Mirror
        Me.KFormManager1.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle
        Me.KFormManager1.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle
        Me.KFormManager1.FormOffice2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack
        Me.KFormManager1.MainContainer = Me
        Me.KFormManager1.ToolStripOffice2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack
        '
        'ElGroupBox8
        '
        Me.ElGroupBox8.BackgroundStyle.GradientAngle = 45.0!
        Me.ElGroupBox8.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox8.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox8.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaption
        Me.ElGroupBox8.CaptionStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox8.CaptionStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox8.CaptionStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox8.CaptionStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox8.CaptionStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox8.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox8.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElGroupBox8.CaptionStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox8.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.ElGroupBox8.CaptionStyle.TextStyle.Text = "Copias"
        Me.ElGroupBox8.CaptionStyle.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox8.Controls.Add(Me.txtNRegistro)
        Me.ElGroupBox8.Controls.Add(Me.chkInventarioInicial)
        Me.ElGroupBox8.Controls.Add(Me.dtCopias)
        Me.ElGroupBox8.Controls.Add(Me.btAgregarRegistro)
        Me.ElGroupBox8.Controls.Add(Me.Label24)
        Me.ElGroupBox8.Location = New System.Drawing.Point(331, 159)
        Me.ElGroupBox8.Name = "ElGroupBox8"
        Me.ElGroupBox8.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.ElGroupBox8.Padding = New System.Windows.Forms.Padding(4, 27, 4, 3)
        Me.ElGroupBox8.Size = New System.Drawing.Size(313, 182)
        Me.ElGroupBox8.TabIndex = 8
        '
        'txtNRegistro
        '
        '
        '
        '
        Me.txtNRegistro.Border.Class = "TextBoxBorder"
        Me.txtNRegistro.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNRegistro.Enabled = False
        Me.txtNRegistro.Location = New System.Drawing.Point(151, 35)
        Me.txtNRegistro.Name = "txtNRegistro"
        Me.txtNRegistro.Size = New System.Drawing.Size(72, 20)
        Me.txtNRegistro.TabIndex = 59
        '
        'chkInventarioInicial
        '
        Me.chkInventarioInicial.AutoSize = True
        Me.chkInventarioInicial.Location = New System.Drawing.Point(12, 36)
        Me.chkInventarioInicial.Name = "chkInventarioInicial"
        Me.chkInventarioInicial.Size = New System.Drawing.Size(102, 18)
        Me.chkInventarioInicial.TabIndex = 57
        Me.chkInventarioInicial.Text = "Inventario Inicial"
        Me.chkInventarioInicial.UseVisualStyleBackColor = True
        '
        'dtCopias
        '
        Me.dtCopias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtCopias.DefaultCellStyle = DataGridViewCellStyle10
        Me.dtCopias.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dtCopias.Location = New System.Drawing.Point(12, 61)
        Me.dtCopias.Name = "dtCopias"
        Me.dtCopias.Size = New System.Drawing.Size(291, 107)
        Me.dtCopias.TabIndex = 61
        '
        'btAgregarRegistro
        '
        Me.btAgregarRegistro.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAgregarRegistro.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAgregarRegistro.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.btn_agregar
        Me.btAgregarRegistro.Location = New System.Drawing.Point(222, 32)
        Me.btAgregarRegistro.Name = "btAgregarRegistro"
        Me.btAgregarRegistro.Size = New System.Drawing.Size(23, 25)
        Me.btAgregarRegistro.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btAgregarRegistro.TabIndex = 60
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(123, 37)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(29, 14)
        Me.Label24.TabIndex = 58
        Me.Label24.Text = "Reg:"
        '
        'TabControl1
        '
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Controls.Add(Me.TabControlPanel3)
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(659, 375)
        Me.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
        Me.TabControl1.TabIndex = 9
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Tabs.Add(Me.TabItem2)
        Me.TabControl1.Tabs.Add(Me.TabItem3)
        Me.TabControl1.Text = "Otros Datos"
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.AutoScroll = True
        Me.TabControlPanel3.Controls.Add(Me.ElGroupBox10)
        Me.TabControlPanel3.Controls.Add(Me.ElGroupBox9)
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(659, 353)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 3
        Me.TabControlPanel3.TabItem = Me.TabItem3
        '
        'ElGroupBox10
        '
        Me.ElGroupBox10.BackgroundStyle.GradientAngle = 45.0!
        Me.ElGroupBox10.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox10.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox10.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaption
        Me.ElGroupBox10.CaptionStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox10.CaptionStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox10.CaptionStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox10.CaptionStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox10.CaptionStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox10.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox10.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElGroupBox10.CaptionStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox10.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.ElGroupBox10.CaptionStyle.TextStyle.Text = "Cita Biliográfica"
        Me.ElGroupBox10.CaptionStyle.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox10.Controls.Add(Me.txtCita)
        Me.ElGroupBox10.Controls.Add(Me.txtEstilo)
        Me.ElGroupBox10.Controls.Add(Me.Label26)
        Me.ElGroupBox10.Controls.Add(Me.Label25)
        Me.ElGroupBox10.Controls.Add(Me.txtNorma)
        Me.ElGroupBox10.Controls.Add(Me.Label29)
        Me.ElGroupBox10.Location = New System.Drawing.Point(12, 271)
        Me.ElGroupBox10.Name = "ElGroupBox10"
        Me.ElGroupBox10.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.ElGroupBox10.Padding = New System.Windows.Forms.Padding(4, 27, 4, 3)
        Me.ElGroupBox10.Size = New System.Drawing.Size(635, 68)
        Me.ElGroupBox10.TabIndex = 7
        '
        'txtCita
        '
        '
        '
        '
        Me.txtCita.Border.Class = "TextBoxBorder"
        Me.txtCita.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCita.Location = New System.Drawing.Point(235, 35)
        Me.txtCita.Name = "txtCita"
        Me.txtCita.Size = New System.Drawing.Size(390, 20)
        Me.txtCita.TabIndex = 38
        '
        'txtEstilo
        '
        '
        '
        '
        Me.txtEstilo.Border.Class = "TextBoxBorder"
        Me.txtEstilo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEstilo.Location = New System.Drawing.Point(145, 35)
        Me.txtEstilo.Name = "txtEstilo"
        Me.txtEstilo.Size = New System.Drawing.Size(50, 20)
        Me.txtEstilo.TabIndex = 36
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(201, 37)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(28, 14)
        Me.Label26.TabIndex = 37
        Me.Label26.Text = "Cita:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(108, 37)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(35, 14)
        Me.Label25.TabIndex = 35
        Me.Label25.Text = "Estilo:"
        '
        'txtNorma
        '
        '
        '
        '
        Me.txtNorma.Border.Class = "TextBoxBorder"
        Me.txtNorma.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNorma.Location = New System.Drawing.Point(52, 35)
        Me.txtNorma.Name = "txtNorma"
        Me.txtNorma.Size = New System.Drawing.Size(50, 20)
        Me.txtNorma.TabIndex = 34
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(9, 37)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(41, 14)
        Me.Label29.TabIndex = 33
        Me.Label29.Text = "Norma:"
        '
        'ElGroupBox9
        '
        Me.ElGroupBox9.BackgroundStyle.GradientAngle = 45.0!
        Me.ElGroupBox9.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox9.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox9.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaption
        Me.ElGroupBox9.CaptionStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox9.CaptionStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox9.CaptionStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox9.CaptionStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox9.CaptionStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox9.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox9.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElGroupBox9.CaptionStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox9.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.ElGroupBox9.CaptionStyle.TextStyle.Text = "Imagen"
        Me.ElGroupBox9.CaptionStyle.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox9.Controls.Add(Me.picImagenLibro)
        Me.ElGroupBox9.Controls.Add(Me.btBorrarImagen)
        Me.ElGroupBox9.Controls.Add(Me.btExaminar)
        Me.ElGroupBox9.Controls.Add(Me.txtImagen)
        Me.ElGroupBox9.Controls.Add(Me.Label28)
        Me.ElGroupBox9.Location = New System.Drawing.Point(12, 4)
        Me.ElGroupBox9.Name = "ElGroupBox9"
        Me.ElGroupBox9.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.ElGroupBox9.Padding = New System.Windows.Forms.Padding(4, 27, 4, 3)
        Me.ElGroupBox9.Size = New System.Drawing.Size(635, 261)
        Me.ElGroupBox9.TabIndex = 6
        '
        'picImagenLibro
        '
        Me.picImagenLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImagenLibro.Location = New System.Drawing.Point(12, 62)
        Me.picImagenLibro.Name = "picImagenLibro"
        Me.picImagenLibro.Size = New System.Drawing.Size(187, 187)
        Me.picImagenLibro.TabIndex = 45
        Me.picImagenLibro.TabStop = False
        '
        'btBorrarImagen
        '
        Me.btBorrarImagen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btBorrarImagen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btBorrarImagen.Enabled = False
        Me.btBorrarImagen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBorrarImagen.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.Cancelar
        Me.btBorrarImagen.Location = New System.Drawing.Point(579, 30)
        Me.btBorrarImagen.Name = "btBorrarImagen"
        Me.btBorrarImagen.Size = New System.Drawing.Size(23, 25)
        Me.btBorrarImagen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btBorrarImagen.TabIndex = 36
        Me.btBorrarImagen.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btExaminar
        '
        Me.btExaminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btExaminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btExaminar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExaminar.Location = New System.Drawing.Point(602, 30)
        Me.btExaminar.Name = "btExaminar"
        Me.btExaminar.Size = New System.Drawing.Size(23, 25)
        Me.btExaminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btExaminar.TabIndex = 36
        Me.btExaminar.Text = "..."
        '
        'txtImagen
        '
        Me.txtImagen.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtImagen.Border.Class = "TextBoxBorder"
        Me.txtImagen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtImagen.Location = New System.Drawing.Point(59, 35)
        Me.txtImagen.Name = "txtImagen"
        Me.txtImagen.ReadOnly = True
        Me.txtImagen.Size = New System.Drawing.Size(522, 20)
        Me.txtImagen.TabIndex = 34
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(9, 37)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(44, 14)
        Me.Label28.TabIndex = 33
        Me.Label28.Text = "Imagen:"
        '
        'TabItem3
        '
        Me.TabItem3.AttachedControl = Me.TabControlPanel3
        Me.TabItem3.Name = "TabItem3"
        Me.TabItem3.Text = "Otros Datos"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.AutoScroll = True
        Me.TabControlPanel1.CanvasColor = System.Drawing.Color.Transparent
        Me.TabControlPanel1.Controls.Add(Me.ElGroupBox1)
        Me.TabControlPanel1.Controls.Add(Me.ElGroupBox2)
        Me.TabControlPanel1.Controls.Add(Me.ElGroupBox4)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(659, 353)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Información Bibliográfica"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.AutoScroll = True
        Me.TabControlPanel2.Controls.Add(Me.ElGroupBox5)
        Me.TabControlPanel2.Controls.Add(Me.ElGroupBox8)
        Me.TabControlPanel2.Controls.Add(Me.ElGroupBox6)
        Me.TabControlPanel2.Controls.Add(Me.ElGroupBox7)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(659, 366)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.TabItem2
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "Datos Relacionados"
        '
        'opExaminar
        '
        Me.opExaminar.FileName = "Seleccionar una Imagen para el Perfil de esta Bibliografía"
        Me.opExaminar.Filter = "Imagenes (.jpg, .jpeg, .png, .gif)|*.jpg;*.jpeg;*.png;*.gif"
        '
        'frmLibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(659, 414)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "frmLibro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registros de Acervo Bibliográfico"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ElGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElGroupBox7.ResumeLayout(False)
        Me.ElGroupBox7.PerformLayout()
        CType(Me.dtEncabezados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElGroupBox6.ResumeLayout(False)
        Me.ElGroupBox6.PerformLayout()
        CType(Me.ElGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElGroupBox5.ResumeLayout(False)
        Me.ElGroupBox5.PerformLayout()
        CType(Me.ElGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElGroupBox4.ResumeLayout(False)
        Me.ElGroupBox4.PerformLayout()
        CType(Me.ElGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElGroupBox2.ResumeLayout(False)
        Me.ElGroupBox2.PerformLayout()
        CType(Me.ElGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElGroupBox1.ResumeLayout(False)
        Me.ElGroupBox1.PerformLayout()
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElGroupBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElGroupBox8.ResumeLayout(False)
        Me.ElGroupBox8.PerformLayout()
        CType(Me.dtCopias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel3.ResumeLayout(False)
        CType(Me.ElGroupBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElGroupBox10.ResumeLayout(False)
        Me.ElGroupBox10.PerformLayout()
        CType(Me.ElGroupBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElGroupBox9.ResumeLayout(False)
        Me.ElGroupBox9.PerformLayout()
        CType(Me.picImagenLibro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ElGroupBox7 As Klik.Windows.Forms.v1.EntryLib.ELGroupBox
    Friend WithEvents dtEncabezados As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btActualizarEncabezado As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbEncabezado As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ElGroupBox6 As Klik.Windows.Forms.v1.EntryLib.ELGroupBox
    Friend WithEvents btAgregarTutor As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btBuscarTutor As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtTutor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btActualizarGrado As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbGrado As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoInvestigacion As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents ElGroupBox5 As Klik.Windows.Forms.v1.EntryLib.ELGroupBox
    Friend WithEvents btAgregarCiudad As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btBuscarCiudad As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtCiudad As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtEdicion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtFechaPublicacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btActualizarEditor As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbEditor As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ElGroupBox4 As Klik.Windows.Forms.v1.EntryLib.ELGroupBox
    Friend WithEvents txtColacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtResumen As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtNotas As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtOtroCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSignatura As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtIsbn As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btActualizarIdioma As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbIdioma As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbAutorInstitucional As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ElGroupBox2 As Klik.Windows.Forms.v1.EntryLib.ELGroupBox
    Friend WithEvents txtAutor3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtAutor2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtAutor1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ElGroupBox1 As Klik.Windows.Forms.v1.EntryLib.ELGroupBox
    Friend WithEvents txtOtroTitulo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTitulo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoRegistro As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoDocumento As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KFormManager1 As Klik.Windows.Forms.v1.Common.KFormManager
    Friend WithEvents txtIdCiudad As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtIdTutor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ElGroupBox8 As Klik.Windows.Forms.v1.EntryLib.ELGroupBox
    Friend WithEvents dtCopias As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btAgregarRegistro As DevComponents.DotNetBar.ButtonX
    Friend WithEvents chkInventarioInicial As System.Windows.Forms.CheckBox
    Friend WithEvents txtNRegistro As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem3 As DevComponents.DotNetBar.TabItem
    Friend WithEvents ElGroupBox9 As Klik.Windows.Forms.v1.EntryLib.ELGroupBox
    Friend WithEvents txtImagen As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents btExaminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents picImagenLibro As System.Windows.Forms.PictureBox
    Friend WithEvents ElGroupBox10 As Klik.Windows.Forms.v1.EntryLib.ELGroupBox
    Friend WithEvents txtNorma As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtEstilo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtCita As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents btEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents opExaminar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btBorrarImagen As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btActualizarInstitucion As DevComponents.DotNetBar.ButtonX
End Class
