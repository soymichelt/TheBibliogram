Public Class frmBuscarRecomendacion

    Sub Lista()
        Try
            Using Recomendacion As New RecomendacionServicio.RecomendacionServicioClient
                If dtRegistro.Visible Then
                    dtRegistro.DataSource = (From rec In Recomendacion.Busqueda(dtpInicio.Value.ToShortDateString() & " 00:00:00", dtpFinal.Value.ToShortDateString() & " 23:59:59", txtNombre.Text) Select rec.IdRecomendacion, Estado = If(rec.Activo, "activo", "eliminado"), rec.FechaReg, rec.Usuario, rec.AreaDirigida, rec.Titulo, rec.OtroTitulo, rec.Autores, rec.Isbn, rec.Volumen, rec.Edicion, rec.Nota).ToList
                    If dtRegistro.Columns.Count > 0 Then
                        dtRegistro.Columns(0).Visible = False
                        dtRegistro.Columns(1).HeaderText = vbNewLine & "Estado" & vbNewLine : dtRegistro.Columns(1).Width = 80
                        dtRegistro.Columns(2).HeaderText = vbNewLine & "Fecha" & vbNewLine : dtRegistro.Columns(2).Width = 100
                        dtRegistro.Columns(3).HeaderText = "Usuario" : dtRegistro.Columns(3).Width = 200
                        dtRegistro.Columns(4).HeaderText = "Dirigido a" : dtRegistro.Columns(4).Width = 200
                        dtRegistro.Columns(5).HeaderText = "Título de la Bibliografía" : dtRegistro.Columns(5).Width = 300
                        dtRegistro.Columns(6).HeaderText = "Otro Título" : dtRegistro.Columns(6).Width = 200
                        dtRegistro.Columns(7).HeaderText = "Autor(es) / Institución" : dtRegistro.Columns(7).Width = 300
                        dtRegistro.Columns(8).HeaderText = "ISBN" : dtRegistro.Columns(8).Width = 80
                        dtRegistro.Columns(9).HeaderText = "Volumen" : dtRegistro.Columns(9).Width = 80
                        dtRegistro.Columns(10).HeaderText = "Edición" : dtRegistro.Columns(10).Width = 80
                        dtRegistro.Columns(11).HeaderText = "Nota" : dtRegistro.Columns(11).Width = 300
                        For Each c As DataGridViewColumn In dtRegistro.Columns
                            c.HeaderText = UCase(c.HeaderText)
                            'c.HeaderCell.Style.Font = New Font(Me.Font.FontFamily, Me.Font.Size, FontStyle.Bold)
                        Next
                    End If
                Else
                    Dim rpt As New rptListadoRecomendacion
                    rpt.SetDataSource((From rec In Recomendacion.Busqueda(dtpInicio.Value.ToShortDateString() & " 00:00:00", dtpFinal.Value.ToShortDateString() & " 23:59:59", txtNombre.Text) Select rec.IdRecomendacion, Estado = If(rec.Activo, "activo", "eliminado"), rec.FechaReg, rec.IdUsuario, rec.Usuario, rec.AreaDirigida, rec.Titulo, rec.OtroTitulo, rec.Autores, rec.Isbn, rec.Volumen, rec.Edicion, rec.Nota).ToList)
                    crvReporte.ReportSource = rpt
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmRecomendacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtRegistro.Font = New Font(Me.Font.FontFamily, Me.Font.Size, FontStyle.Regular)
        dtpInicio.Value = DateTime.Now
        dtpFinal.Value = DateTime.Now
        Lista()
    End Sub

    Private Sub btReporte_Click(sender As Object, e As EventArgs) Handles btReporte.Click
        crvReporte.Visible = True
        dtRegistro.Visible = False
        Lista()
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        crvReporte.Visible = False
        dtRegistro.Visible = True
        Lista()
    End Sub

    Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click
        dtpInicio.Value = DateTime.Now
        dtpFinal.Value = DateTime.Now
        txtNombre.Clear()
        Lista()
    End Sub

    Private Sub dtpInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpInicio.ValueChanged
        Lista()
    End Sub

    Private Sub dtpFinal_ValueChanged(sender As Object, e As EventArgs) Handles dtpFinal.ValueChanged
        Lista()
    End Sub


    Private Sub dtpInicio_Click(sender As Object, e As EventArgs) Handles dtpInicio.Click

    End Sub
End Class