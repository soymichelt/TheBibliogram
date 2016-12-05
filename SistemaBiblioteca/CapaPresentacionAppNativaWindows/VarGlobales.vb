Imports System.IO

Public Module VarGlobales
    Public Function TipoDocumento() As List(Of Display)
        Dim Lista As New List(Of Display)
        Lista.Add(New Display With {.Key = "Colec", .Name = "Colec"})
        Lista.Add(New Display With {.Key = "Medic", .Name = "Medic"})
        Lista.Add(New Display With {.Key = "Monog", .Name = "Monog"})
        Lista.Add(New Display With {.Key = "Autor", .Name = "Autor"})
        Lista.Add(New Display With {.Key = "Refer", .Name = "Refer"})
        Lista.Add(New Display With {.Key = "Extrj", .Name = "Extrj"})
        Return Lista
    End Function

    Public Function PathImage() As String
        Try
            If Not Directory.Exists(My.Application.Info.DirectoryPath & "\FilesSystem\") Then
                Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\FilesSystem\")
                If Not Directory.Exists(My.Application.Info.DirectoryPath & "\FilesSystem\ImagesBook") Then
                    Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\FilesSystem\ImagesBook\")
                End If
            End If
            Return My.Application.Info.DirectoryPath & "\FilesSystem\ImagesBook\"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return ""
        End Try
    End Function

    Public Function TipoRegistro() As List(Of Display)
        Dim Lista As New List(Of Display)
        Lista.Add(New Display With {.Key = "TI", .Name = "TI"})
        Lista.Add(New Display With {.Key = "PE", .Name = "PE"})
        Lista.Add(New Display With {.Key = "IN", .Name = "IN"})
        Return Lista
    End Function

    Public Function TipoInvestigacion() As List(Of Display)
        Dim Lista As New List(Of Display)
        Lista.Add(New Display With {.Key = "Monografía", .Name = "Monografía"})
        Lista.Add(New Display With {.Key = "Seminario", .Name = "Seminario"})
        Lista.Add(New Display With {.Key = "Tesis", .Name = "Tesis"})
        Return Lista
    End Function

    Public Function RolUsuario() As List(Of Display)
        Dim Lista As New List(Of Display)
        Lista.AddRange(New List(Of Display) From {New Display With {.Key = "0", .Name = "Público en General"}, New Display With {.Key = "1", .Name = "Administrador"}, New Display With {.Key = "2", .Name = "Analista Documental"}, New Display With {.Key = "3", .Name = "Analista Referencial"}, New Display With {.Key = "4", .Name = "Administración"}, New Display With {.Key = "5", .Name = "Director de Biblioteca"}, New Display With {.Key = "6", .Name = "Decanatura"}})
        Return Lista
    End Function

    Public Function TipoPrestamo() As List(Of Display)
        Dim Lista As New List(Of Display)
        Lista.Add(New Display With {.Key = "Interno", .Name = "Interno"})
        Lista.Add(New Display With {.Key = "Externo", .Name = "Externo"})
        Return Lista
    End Function

    Public Sesion As AccountServicio.DUsuario

End Module

Public Class Display
    Public Property Key As String
    Public Property Name As String
End Class

