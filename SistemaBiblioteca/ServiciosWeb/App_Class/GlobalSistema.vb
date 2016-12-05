Module GlobalSistema

    Public Function NoEncontrado(ByVal nombre As String) As String
        Return "Intento consultar '" & nombre & "' pero no fue encontrado"
    End Function

    Public Function IngresarAtributo(ByVal NombreAtributo As String) As String
        Return "Debe ingresar el atributo '" & NombreAtributo & "'"
    End Function

    Public Function ExisteRegAtributo(ByVal Tabla As String, ByVal NombreAtributo As String, ByVal Valor As String) As String
        Return "Ya existe un registro dentro de la tabla '" & Tabla & "' con el atributo '" & NombreAtributo & "' igual a: " & Valor
    End Function

    Public Function Eliminado(ByVal Tabla As String)
        Return "El registro que intenta mostrar de la tabla '" & Tabla & "' ha sido eliminado."
    End Function

    Public Function ParametrosNoEnviados(ByVal Parametro As String)
        Return "Los parámetros de '" & Parametro & "' no han sido enviados."
    End Function

    Public PathImageBibliografia As String = "C:\Imagenes\Bibliografia\"

End Module