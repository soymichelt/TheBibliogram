<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignin
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
        Dim GradientBlend1 As Klik.Windows.Forms.v1.Common.GradientBlend = New Klik.Windows.Forms.v1.Common.GradientBlend()
        Dim GradientBlend2 As Klik.Windows.Forms.v1.Common.GradientBlend = New Klik.Windows.Forms.v1.Common.GradientBlend()
        Dim GradientBlend3 As Klik.Windows.Forms.v1.Common.GradientBlend = New Klik.Windows.Forms.v1.Common.GradientBlend()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSignin))
        Me.gbIniciarSesion = New Klik.Windows.Forms.v1.EntryLib.ELGroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btSalir = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btEntrar = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picUsuario = New System.Windows.Forms.PictureBox()
        Me.picPass = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.KFormManager1 = New Klik.Windows.Forms.v1.Common.KFormManager(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.gbIniciarSesion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbIniciarSesion.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btEntrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbIniciarSesion
        '
        Me.gbIniciarSesion.BackgroundStyle.GradientAngle = 45.0!
        Me.gbIniciarSesion.BackgroundStyle.SolidColor = System.Drawing.Color.Transparent
        Me.gbIniciarSesion.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.gbIniciarSesion.CaptionStyle.Align = System.Drawing.ContentAlignment.MiddleCenter
        Me.gbIniciarSesion.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.gbIniciarSesion.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbIniciarSesion.CaptionStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.gbIniciarSesion.CaptionStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.gbIniciarSesion.CaptionStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.gbIniciarSesion.CaptionStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.gbIniciarSesion.CaptionStyle.BorderStyle.EdgeRadius = 100
        Me.gbIniciarSesion.CaptionStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.gbIniciarSesion.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.gbIniciarSesion.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.gbIniciarSesion.CaptionStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.gbIniciarSesion.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernSilver
        Me.gbIniciarSesion.CaptionStyle.Size = New System.Drawing.Size(170, 30)
        Me.gbIniciarSesion.CaptionStyle.TextStyle.Text = "Autentificación de Usuarios"
        Me.gbIniciarSesion.CaptionStyle.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.gbIniciarSesion.Controls.Add(Me.PictureBox2)
        Me.gbIniciarSesion.Controls.Add(Me.txtContraseña)
        Me.gbIniciarSesion.Controls.Add(Me.txtUsuario)
        Me.gbIniciarSesion.Controls.Add(Me.btSalir)
        Me.gbIniciarSesion.Controls.Add(Me.btEntrar)
        Me.gbIniciarSesion.Controls.Add(Me.Label2)
        Me.gbIniciarSesion.Controls.Add(Me.Label1)
        Me.gbIniciarSesion.Controls.Add(Me.picUsuario)
        Me.gbIniciarSesion.Controls.Add(Me.picPass)
        Me.gbIniciarSesion.Location = New System.Drawing.Point(45, 71)
        Me.gbIniciarSesion.Name = "gbIniciarSesion"
        Me.gbIniciarSesion.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.gbIniciarSesion.Padding = New System.Windows.Forms.Padding(4, 33, 4, 3)
        Me.gbIniciarSesion.Size = New System.Drawing.Size(305, 235)
        Me.gbIniciarSesion.TabIndex = 0
        Me.gbIniciarSesion.TransparentStyle.BackColor = System.Drawing.Color.Transparent
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(21, 165)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(264, 3)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'txtContraseña
        '
        Me.txtContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContraseña.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.Color.Black
        Me.txtContraseña.Location = New System.Drawing.Point(100, 118)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtContraseña.Size = New System.Drawing.Size(145, 13)
        Me.txtContraseña.TabIndex = 4
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.Black
        Me.txtUsuario.Location = New System.Drawing.Point(100, 68)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(145, 13)
        Me.txtUsuario.TabIndex = 2
        '
        'btSalir
        '
        Me.btSalir.BackgroundImageStyle.Alpha = 100
        Me.btSalir.BackgroundImageStyle.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.Signout
        Me.btSalir.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSalir.BackgroundStyle.GradientEndColor = System.Drawing.Color.BurlyWood
        Me.btSalir.BackgroundStyle.GradientStartColor = System.Drawing.Color.NavajoWhite
        Me.btSalir.BorderStyle.EdgeRadius = 502
        Me.btSalir.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btSalir.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btSalir.Cursor = System.Windows.Forms.Cursors.Default
        Me.btSalir.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btSalir.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btSalir.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btSalir.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btSalir.Location = New System.Drawing.Point(179, 184)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(108, 35)
        Me.btSalir.StateStyles.FocusStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btSalir.StateStyles.FocusStyle.BackgroundSolidColor = System.Drawing.Color.BurlyWood
        GradientBlend1.Factor = 0.0!
        GradientBlend1.Position = 0.0!
        GradientBlend2.Factor = 0.0!
        GradientBlend2.Position = 0.5!
        GradientBlend3.Factor = 1.0!
        GradientBlend3.Position = 1.0!
        Me.btSalir.StateStyles.HoverStyle.BackgroundGradientBlend.Add(GradientBlend1)
        Me.btSalir.StateStyles.HoverStyle.BackgroundGradientBlend.Add(GradientBlend2)
        Me.btSalir.StateStyles.HoverStyle.BackgroundGradientBlend.Add(GradientBlend3)
        Me.btSalir.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.NavajoWhite
        Me.btSalir.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.BurlyWood
        Me.btSalir.TabIndex = 6
        Me.btSalir.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btSalir.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btSalir.TextStyle.Text = "Cerrar Sistema"
        Me.btSalir.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'btEntrar
        '
        Me.btEntrar.BackgroundImageStyle.Alpha = 100
        Me.btEntrar.BackgroundImageStyle.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.Signin
        Me.btEntrar.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btEntrar.BorderStyle.EdgeRadius = 50
        Me.btEntrar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btEntrar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btEntrar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btEntrar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btEntrar.Location = New System.Drawing.Point(20, 184)
        Me.btEntrar.Name = "btEntrar"
        Me.btEntrar.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack
        Me.btEntrar.Size = New System.Drawing.Size(108, 35)
        Me.btEntrar.TabIndex = 5
        Me.btEntrar.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btEntrar.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.btEntrar.TextStyle.Text = "Iniciar Sesión"
        Me.btEntrar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario:"
        '
        'picUsuario
        '
        Me.picUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.picUsuario.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.FondoSesion
        Me.picUsuario.Location = New System.Drawing.Point(91, 53)
        Me.picUsuario.Name = "picUsuario"
        Me.picUsuario.Size = New System.Drawing.Size(196, 45)
        Me.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picUsuario.TabIndex = 7
        Me.picUsuario.TabStop = False
        '
        'picPass
        '
        Me.picPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.picPass.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.FondoSesionPass
        Me.picPass.Location = New System.Drawing.Point(91, 104)
        Me.picPass.Name = "picPass"
        Me.picPass.Size = New System.Drawing.Size(196, 45)
        Me.picPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picPass.TabIndex = 7
        Me.picPass.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.CapaPresentacionAppNativaWindows.My.Resources.Resources.FondoInicioSesion
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(394, 381)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'KFormManager1
        '
        Me.KFormManager1.BackgroundImageStyle.Alpha = 100
        Me.KFormManager1.BackgroundImageStyle.ImageEffect = Klik.Windows.Forms.v1.Common.ImageEffect.Mirror
        Me.KFormManager1.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle
        Me.KFormManager1.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle
        Me.KFormManager1.FormOffice2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernSilver
        Me.KFormManager1.MainContainer = Me
        Me.KFormManager1.ToolStripOffice2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernSilver
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmSignin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 381)
        Me.Controls.Add(Me.gbIniciarSesion)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSignin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesión"
        CType(Me.gbIniciarSesion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbIniciarSesion.ResumeLayout(False)
        Me.gbIniciarSesion.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btEntrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbIniciarSesion As Klik.Windows.Forms.v1.EntryLib.ELGroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btEntrar As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btSalir As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents picUsuario As System.Windows.Forms.PictureBox
    Friend WithEvents picPass As System.Windows.Forms.PictureBox
    Friend WithEvents KFormManager1 As Klik.Windows.Forms.v1.Common.KFormManager
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
