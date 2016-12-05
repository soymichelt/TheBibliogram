Public Class frmCreditos

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Try
            Process.Start("http://www.chontales.unan.edu.ni")
        Catch ex As Exception
            MessageBox.Show("Error, " & ex.Message)
        End Try
    End Sub

    Private Sub frmCreditos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmCreditos_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        pnCredito.Left = (Me.Width / 2) - (Me.pnCredito.Width / 2)
        pnCredito.Top = (Me.Height / 2) - (Me.pnCredito.Height / 2)
    End Sub
End Class