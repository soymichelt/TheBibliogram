Public Class frmBuscarPrestamo
    Dim FormLoad As Boolean = False
    Sub llenar()
        Try
            Using Prestamo As New PrestamoServicio.PrestamoServicioClient
                dtRegistro.DataSource = (From pre In Prestamo.Busqueda(DateTime.Parse(dtpInicio.Value.ToShortDateString() & " 00:00:00"), DateTime.Parse(dtpFinal.Value.ToShortDateString() & " 23:59:59"), txtNombre.Text.Trim) Select pre.IdPrestamo, pre.N, pre.Tipo, pre.FechaPrestamo, pre.Observacion, pre.TipoPersona, pre.NombrePersona, pre.Departamento, pre.Municipio, Sexo = If(pre.Sexo, "Masculino", "Femenino")).ToList()
                If dtRegistro.Columns.Count > 0 Then
                    dtRegistro.Columns(0).Visible = False
                    dtRegistro.Columns(1).Width = 100 : dtRegistro.Columns(1).HeaderText = vbNewLine & "Nº de Prestamo" & vbNewLine
                    dtRegistro.Columns(2).Width = 100
                    dtRegistro.Columns(3).Width = 100 : dtRegistro.Columns(3).HeaderText = "Fecha"
                    dtRegistro.Columns(4).Width = 300 : dtRegistro.Columns(4).HeaderText = "Observación"
                    dtRegistro.Columns(5).Width = 120 : dtRegistro.Columns(5).HeaderText = "T. Persona"
                    dtRegistro.Columns(6).Width = 300 : dtRegistro.Columns(6).HeaderText = "Nombres y Apellidos"
                    dtRegistro.Columns(7).Width = 120 : dtRegistro.Columns(7).HeaderText = "Departamento"
                    dtRegistro.Columns(8).Width = 120 : dtRegistro.Columns(8).HeaderText = "Municipio"
                    dtRegistro.Columns(9).Width = 120 : dtRegistro.Columns(9).HeaderText = "Sexo"

                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        llenar()
    End Sub

    Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click
        dtpInicio.Value = DateTime.Now
        dtpFinal.Value = DateTime.Now
        txtNombre.Clear()
    End Sub

    Private Sub frmBuscarPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpInicio.Value = DateTime.Now
        dtpFinal.Value = DateTime.Now
    End Sub


    Private Sub dtRegistro_SelectionChanged(sender As Object, e As EventArgs) Handles dtRegistro.SelectionChanged
        If dtRegistro.SelectedRows.Count > 0 Then
            Try
                Using Prestamo As New PrestamoServicio.PrestamoServicioClient
                    dtDetalle.DataSource = (From inv In Prestamo.ListadoDetalle(Guid.Parse(dtRegistro.SelectedRows(0).Cells(0).Value.ToString)) Select inv.IdInventario, inv.Registro, inv.TipoDocumento, inv.TipoRegistro, inv.Signatura, inv.Titulo, inv.OtroTitulo, inv.Autor1, inv.Autor2, inv.Autor3, inv.Institucion, inv.Idioma, inv.Isbn, inv.Editor, inv.Edicion).ToList()
                    For Each c As DataGridViewColumn In dtDetalle.Columns
                        c.HeaderCell.Style.Font = New Font("Arial", Me.Font.Size, FontStyle.Bold)
                        c.DefaultCellStyle.Font = New Font("Arial", Me.Font.Size, FontStyle.Regular)
                        c.HeaderText = c.HeaderText.ToUpper
                    Next
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub dtDetalle_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtDetalle.CellDoubleClick
        Try
            If dtDetalle.SelectedRows.Count > 0 Then
                Using Prestamo As New PrestamoServicio.PrestamoServicioClient
                    Prestamo.Entregar(Guid.Parse(dtDetalle.SelectedRows(0).Cells(0).Value.ToString))
                    MessageBox.Show("Entregado!!!")
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class