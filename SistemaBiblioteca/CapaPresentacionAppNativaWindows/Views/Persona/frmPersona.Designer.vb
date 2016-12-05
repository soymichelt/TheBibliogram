<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersona
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
        Me.ElGroupBox3 = New Klik.Windows.Forms.v1.EntryLib.ELGroupBox()
        Me.txtObservacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ElGroupBox2 = New Klik.Windows.Forms.v1.EntryLib.ELGroupBox()
        Me.txtArea = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ElGroupBox1 = New Klik.Windows.Forms.v1.EntryLib.ELGroupBox()
        Me.txtMunicipio = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDepartamento = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbTipoPersona = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpFechaNacimiento = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rdFemenino = New System.Windows.Forms.RadioButton()
        Me.rdMasculino = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbDepartamentoDocente = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtId = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmbCarrera = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbDepartamentoEstudiante = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbTurno = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNCarnet = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApellidos = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombres = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbId = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdCiudad = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCiudad = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNCiudad = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btEditar = New System.Windows.Forms.ToolStripButton()
        Me.btEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btBuscar = New System.Windows.Forms.ToolStripButton()
        Me.KFormManager1 = New Klik.Windows.Forms.v1.Common.KFormManager(Me.components)
        CType(Me.ElGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElGroupBox3.SuspendLayout()
        CType(Me.ElGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElGroupBox2.SuspendLayout()
        CType(Me.ElGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElGroupBox1.SuspendLayout()
        CType(Me.dtpFechaNacimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElGroupBox3
        '
        Me.ElGroupBox3.BackgroundStyle.GradientAngle = 45.0!
        Me.ElGroupBox3.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox3.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox3.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaption
        Me.ElGroupBox3.CaptionStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox3.CaptionStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox3.CaptionStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox3.CaptionStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox3.CaptionStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox3.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox3.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElGroupBox3.CaptionStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox3.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack
        Me.ElGroupBox3.CaptionStyle.Size = New System.Drawing.Size(120, 24)
        Me.ElGroupBox3.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.White
        Me.ElGroupBox3.CaptionStyle.TextStyle.Text = "Otros Detalles"
        Me.ElGroupBox3.CaptionStyle.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox3.Controls.Add(Me.txtObservacion)
        Me.ElGroupBox3.Controls.Add(Me.Label9)
        Me.ElGroupBox3.Location = New System.Drawing.Point(408, 132)
        Me.ElGroupBox3.Name = "ElGroupBox3"
        Me.ElGroupBox3.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack
        Me.ElGroupBox3.Padding = New System.Windows.Forms.Padding(4, 27, 4, 3)
        Me.ElGroupBox3.Size = New System.Drawing.Size(385, 209)
        Me.ElGroupBox3.TabIndex = 6
        '
        'txtObservacion
        '
        '
        '
        '
        Me.txtObservacion.Border.Class = "TextBoxBorder"
        Me.txtObservacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtObservacion.Location = New System.Drawing.Point(92, 36)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(279, 165)
        Me.txtObservacion.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Observación:"
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
        Me.ElGroupBox2.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack
        Me.ElGroupBox2.CaptionStyle.Size = New System.Drawing.Size(120, 24)
        Me.ElGroupBox2.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.White
        Me.ElGroupBox2.CaptionStyle.TextStyle.Text = "Administrativo"
        Me.ElGroupBox2.CaptionStyle.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox2.Controls.Add(Me.txtArea)
        Me.ElGroupBox2.Controls.Add(Me.Label8)
        Me.ElGroupBox2.Location = New System.Drawing.Point(408, 52)
        Me.ElGroupBox2.Name = "ElGroupBox2"
        Me.ElGroupBox2.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack
        Me.ElGroupBox2.Padding = New System.Windows.Forms.Padding(4, 27, 4, 3)
        Me.ElGroupBox2.Size = New System.Drawing.Size(385, 74)
        Me.ElGroupBox2.TabIndex = 5
        '
        'txtArea
        '
        '
        '
        '
        Me.txtArea.Border.Class = "TextBoxBorder"
        Me.txtArea.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtArea.Location = New System.Drawing.Point(92, 36)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(279, 20)
        Me.txtArea.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Área Laboral:"
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
        Me.ElGroupBox1.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack
        Me.ElGroupBox1.CaptionStyle.Size = New System.Drawing.Size(120, 24)
        Me.ElGroupBox1.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.White
        Me.ElGroupBox1.CaptionStyle.TextStyle.Text = "Datos Personales"
        Me.ElGroupBox1.CaptionStyle.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox1.Controls.Add(Me.txtMunicipio)
        Me.ElGroupBox1.Controls.Add(Me.Label16)
        Me.ElGroupBox1.Controls.Add(Me.txtDepartamento)
        Me.ElGroupBox1.Controls.Add(Me.Panel1)
        Me.ElGroupBox1.Controls.Add(Me.cmbTipoPersona)
        Me.ElGroupBox1.Controls.Add(Me.Label14)
        Me.ElGroupBox1.Controls.Add(Me.dtpFechaNacimiento)
        Me.ElGroupBox1.Controls.Add(Me.Label12)
        Me.ElGroupBox1.Controls.Add(Me.rdFemenino)
        Me.ElGroupBox1.Controls.Add(Me.rdMasculino)
        Me.ElGroupBox1.Controls.Add(Me.Label11)
        Me.ElGroupBox1.Controls.Add(Me.cmbDepartamentoDocente)
        Me.ElGroupBox1.Controls.Add(Me.Label15)
        Me.ElGroupBox1.Controls.Add(Me.Label10)
        Me.ElGroupBox1.Controls.Add(Me.txtId)
        Me.ElGroupBox1.Controls.Add(Me.cmbCarrera)
        Me.ElGroupBox1.Controls.Add(Me.Label7)
        Me.ElGroupBox1.Controls.Add(Me.cmbDepartamentoEstudiante)
        Me.ElGroupBox1.Controls.Add(Me.Label6)
        Me.ElGroupBox1.Controls.Add(Me.cmbTurno)
        Me.ElGroupBox1.Controls.Add(Me.Label2)
        Me.ElGroupBox1.Controls.Add(Me.txtNCarnet)
        Me.ElGroupBox1.Controls.Add(Me.Label5)
        Me.ElGroupBox1.Controls.Add(Me.txtApellidos)
        Me.ElGroupBox1.Controls.Add(Me.Label4)
        Me.ElGroupBox1.Controls.Add(Me.txtNombres)
        Me.ElGroupBox1.Controls.Add(Me.Label3)
        Me.ElGroupBox1.Controls.Add(Me.cmbId)
        Me.ElGroupBox1.Controls.Add(Me.Label1)
        Me.ElGroupBox1.Location = New System.Drawing.Point(17, 52)
        Me.ElGroupBox1.Name = "ElGroupBox1"
        Me.ElGroupBox1.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack
        Me.ElGroupBox1.Padding = New System.Windows.Forms.Padding(4, 27, 4, 3)
        Me.ElGroupBox1.Size = New System.Drawing.Size(385, 289)
        Me.ElGroupBox1.TabIndex = 4
        '
        'txtMunicipio
        '
        '
        '
        '
        Me.txtMunicipio.Border.Class = "TextBoxBorder"
        Me.txtMunicipio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMunicipio.Location = New System.Drawing.Point(276, 261)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(96, 20)
        Me.txtMunicipio.TabIndex = 28
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(219, 263)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Municipio:"
        '
        'txtDepartamento
        '
        '
        '
        '
        Me.txtDepartamento.Border.Class = "TextBoxBorder"
        Me.txtDepartamento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDepartamento.Location = New System.Drawing.Point(92, 261)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(96, 20)
        Me.txtDepartamento.TabIndex = 26
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Location = New System.Drawing.Point(12, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(359, 4)
        Me.Panel1.TabIndex = 55
        '
        'cmbTipoPersona
        '
        Me.cmbTipoPersona.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipoPersona.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoPersona.DisplayMember = "Text"
        Me.cmbTipoPersona.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTipoPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoPersona.FormattingEnabled = True
        Me.cmbTipoPersona.ItemHeight = 14
        Me.cmbTipoPersona.Location = New System.Drawing.Point(89, 30)
        Me.cmbTipoPersona.Name = "cmbTipoPersona"
        Me.cmbTipoPersona.Size = New System.Drawing.Size(283, 20)
        Me.cmbTipoPersona.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbTipoPersona.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 14)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Tipo Persona:"
        '
        'dtpFechaNacimiento
        '
        '
        '
        '
        Me.dtpFechaNacimiento.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpFechaNacimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpFechaNacimiento.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtpFechaNacimiento.ButtonDropDown.Visible = True
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(292, 151)
        '
        '
        '
        Me.dtpFechaNacimiento.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpFechaNacimiento.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaNacimiento.MonthCalendar.BackgroundStyle.Class = ""
        Me.dtpFechaNacimiento.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpFechaNacimiento.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.dtpFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpFechaNacimiento.MonthCalendar.DisplayMonth = New Date(2015, 6, 1, 0, 0, 0, 0)
        Me.dtpFechaNacimiento.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtpFechaNacimiento.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtpFechaNacimiento.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpFechaNacimiento.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpFechaNacimiento.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpFechaNacimiento.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpFechaNacimiento.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.dtpFechaNacimiento.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpFechaNacimiento.MonthCalendar.TodayButtonVisible = True
        Me.dtpFechaNacimiento.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(79, 20)
        Me.dtpFechaNacimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtpFechaNacimiento.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(261, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "F / N:"
        '
        'rdFemenino
        '
        Me.rdFemenino.AutoSize = True
        Me.rdFemenino.Location = New System.Drawing.Point(229, 151)
        Me.rdFemenino.Name = "rdFemenino"
        Me.rdFemenino.Size = New System.Drawing.Size(31, 17)
        Me.rdFemenino.TabIndex = 16
        Me.rdFemenino.Text = "F"
        Me.rdFemenino.UseVisualStyleBackColor = True
        '
        'rdMasculino
        '
        Me.rdMasculino.AutoSize = True
        Me.rdMasculino.Checked = True
        Me.rdMasculino.Location = New System.Drawing.Point(200, 151)
        Me.rdMasculino.Name = "rdMasculino"
        Me.rdMasculino.Size = New System.Drawing.Size(34, 17)
        Me.rdMasculino.TabIndex = 15
        Me.rdMasculino.TabStop = True
        Me.rdMasculino.Text = "M"
        Me.rdMasculino.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(167, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Sexo:"
        '
        'cmbDepartamentoDocente
        '
        Me.cmbDepartamentoDocente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDepartamentoDocente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDepartamentoDocente.DisplayMember = "Text"
        Me.cmbDepartamentoDocente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDepartamentoDocente.FormattingEnabled = True
        Me.cmbDepartamentoDocente.ItemHeight = 14
        Me.cmbDepartamentoDocente.Location = New System.Drawing.Point(92, 233)
        Me.cmbDepartamentoDocente.Name = "cmbDepartamentoDocente"
        Me.cmbDepartamentoDocente.Size = New System.Drawing.Size(279, 20)
        Me.cmbDepartamentoDocente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbDepartamentoDocente.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 263)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Departamento:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 235)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Dpt. Docente:"
        '
        'txtId
        '
        '
        '
        '
        Me.txtId.Border.Class = "TextBoxBorder"
        Me.txtId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtId.Location = New System.Drawing.Point(281, 74)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(90, 20)
        Me.txtId.TabIndex = 7
        '
        'cmbCarrera
        '
        Me.cmbCarrera.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCarrera.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCarrera.DisplayMember = "Text"
        Me.cmbCarrera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCarrera.FormattingEnabled = True
        Me.cmbCarrera.ItemHeight = 14
        Me.cmbCarrera.Location = New System.Drawing.Point(68, 178)
        Me.cmbCarrera.Name = "cmbCarrera"
        Me.cmbCarrera.Size = New System.Drawing.Size(303, 20)
        Me.cmbCarrera.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbCarrera.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Carrera:"
        '
        'cmbDepartamentoEstudiante
        '
        Me.cmbDepartamentoEstudiante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDepartamentoEstudiante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDepartamentoEstudiante.DisplayMember = "Text"
        Me.cmbDepartamentoEstudiante.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDepartamentoEstudiante.FormattingEnabled = True
        Me.cmbDepartamentoEstudiante.ItemHeight = 14
        Me.cmbDepartamentoEstudiante.Location = New System.Drawing.Point(92, 205)
        Me.cmbDepartamentoEstudiante.Name = "cmbDepartamentoEstudiante"
        Me.cmbDepartamentoEstudiante.Size = New System.Drawing.Size(279, 20)
        Me.cmbDepartamentoEstudiante.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbDepartamentoEstudiante.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Dpt. Estudiante:"
        '
        'cmbTurno
        '
        Me.cmbTurno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTurno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTurno.DisplayMember = "Text"
        Me.cmbTurno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTurno.FormattingEnabled = True
        Me.cmbTurno.ItemHeight = 14
        Me.cmbTurno.Location = New System.Drawing.Point(68, 151)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Size = New System.Drawing.Size(97, 20)
        Me.cmbTurno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbTurno.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Turno:"
        '
        'txtNCarnet
        '
        '
        '
        '
        Me.txtNCarnet.Border.Class = "TextBoxBorder"
        Me.txtNCarnet.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNCarnet.Location = New System.Drawing.Point(68, 74)
        Me.txtNCarnet.Name = "txtNCarnet"
        Me.txtNCarnet.Size = New System.Drawing.Size(120, 20)
        Me.txtNCarnet.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nº Carnet:"
        '
        'txtApellidos
        '
        '
        '
        '
        Me.txtApellidos.Border.Class = "TextBoxBorder"
        Me.txtApellidos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtApellidos.Location = New System.Drawing.Point(68, 125)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(303, 20)
        Me.txtApellidos.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Apellidos:"
        '
        'txtNombres
        '
        '
        '
        '
        Me.txtNombres.Border.Class = "TextBoxBorder"
        Me.txtNombres.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombres.Location = New System.Drawing.Point(68, 99)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(303, 20)
        Me.txtNombres.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nombres:"
        '
        'cmbId
        '
        Me.cmbId.DisplayMember = "Text"
        Me.cmbId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbId.FormattingEnabled = True
        Me.cmbId.ItemHeight = 14
        Me.cmbId.Location = New System.Drawing.Point(216, 74)
        Me.cmbId.Name = "cmbId"
        Me.cmbId.Size = New System.Drawing.Size(65, 20)
        Me.cmbId.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbId.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Id.:"
        '
        'txtIdCiudad
        '
        '
        '
        '
        Me.txtIdCiudad.Border.Class = "TextBoxBorder"
        Me.txtIdCiudad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdCiudad.Location = New System.Drawing.Point(86, 573)
        Me.txtIdCiudad.Name = "txtIdCiudad"
        Me.txtIdCiudad.Size = New System.Drawing.Size(10, 20)
        Me.txtIdCiudad.TabIndex = 26
        Me.txtIdCiudad.Visible = False
        '
        'txtCiudad
        '
        '
        '
        '
        Me.txtCiudad.Border.Class = "TextBoxBorder"
        Me.txtCiudad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCiudad.Location = New System.Drawing.Point(170, 573)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(206, 20)
        Me.txtCiudad.TabIndex = 28
        '
        'txtNCiudad
        '
        '
        '
        '
        Me.txtNCiudad.Border.Class = "TextBoxBorder"
        Me.txtNCiudad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNCiudad.Location = New System.Drawing.Point(97, 573)
        Me.txtNCiudad.Name = "txtNCiudad"
        Me.txtNCiudad.Size = New System.Drawing.Size(73, 20)
        Me.txtNCiudad.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 575)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Ciudad / País:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btNuevo, Me.btGuardar, Me.btEditar, Me.btEliminar, Me.ToolStripSeparator1, Me.btBuscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(811, 39)
        Me.ToolStrip1.TabIndex = 7
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
        Me.btEliminar.Text = "F5 - Eliminar"
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
        Me.btBuscar.Text = "F6 - Buscar"
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
        'frmPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 348)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ElGroupBox3)
        Me.Controls.Add(Me.ElGroupBox2)
        Me.Controls.Add(Me.txtIdCiudad)
        Me.Controls.Add(Me.ElGroupBox1)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtNCiudad)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPersona"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Usuarios"
        CType(Me.ElGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElGroupBox3.ResumeLayout(False)
        Me.ElGroupBox3.PerformLayout()
        CType(Me.ElGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElGroupBox2.ResumeLayout(False)
        Me.ElGroupBox2.PerformLayout()
        CType(Me.ElGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElGroupBox1.ResumeLayout(False)
        Me.ElGroupBox1.PerformLayout()
        CType(Me.dtpFechaNacimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ElGroupBox3 As Klik.Windows.Forms.v1.EntryLib.ELGroupBox
    Friend WithEvents txtObservacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ElGroupBox2 As Klik.Windows.Forms.v1.EntryLib.ELGroupBox
    Friend WithEvents txtArea As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ElGroupBox1 As Klik.Windows.Forms.v1.EntryLib.ELGroupBox
    Friend WithEvents dtpFechaNacimiento As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents rdFemenino As System.Windows.Forms.RadioButton
    Friend WithEvents rdMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbDepartamentoDocente As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmbCarrera As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbDepartamentoEstudiante As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbTurno As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNCarnet As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtApellidos As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNombres As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbId As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KFormManager1 As Klik.Windows.Forms.v1.Common.KFormManager
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtNCiudad As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCiudad As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtIdCiudad As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmbTipoPersona As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtDepartamento As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtMunicipio As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
