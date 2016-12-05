Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IEditorServicio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IEditorServicio

    <OperationContract()>
    Sub DoWork()

    <OperationContract>
    Sub Guardar(ByVal Editor As DEditor)

    <OperationContract>
    Function Lista() As List(Of DEditor)

    <OperationContract()>
    Sub Editar(ByVal Editor As DEditor)

    <OperationContract()>
    Sub Eliminar(ByVal IdEditor As Guid)

    <OperationContract()>
    Function BuscarPorId(ByVal IdEditor As Guid) As DEditor

    <OperationContract>
    Function Busqueda(ByVal Descripcion As String) As List(Of DEditor)

    <OperationContract>
    Function BuscarPorDescripcion(ByVal Descripcion As String) As DEditor

    <OperationContract>
    Function Existe(ByVal Descripcion As String) As Boolean

End Interface
