Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IIdiomaServicio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IIdiomaServicio

    <OperationContract()>
    Sub DoWork()

    <OperationContract>
    Sub Guardar(ByVal Idioma As DIdioma)

    <OperationContract>
    Function Lista() As List(Of DIdioma)

    <OperationContract>
    Function BuscarPorDescripcion(ByVal Descripcion As String) As DIdioma

    <OperationContract>
    Function Existe(ByVal Descripcion As String) As Boolean

End Interface
