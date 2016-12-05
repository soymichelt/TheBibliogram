Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IInventarioServicio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IInventarioServicio

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
    Sub Guardar(ByVal Inventario As DInventario)

    <OperationContract()>
    Sub Editar(ByVal Inventario As DInventario)

    <OperationContract()>
    Sub Eliminar(ByVal IdInventario As Guid)

    <OperationContract()>
    Function BuscarPorId(ByVal IdInventario As Guid) As DInventario

    <OperationContract()>
    Function BuscarPorRegistro(ByVal Registro As String) As DInventario

    <OperationContract()>
    Function Busqueda(ByVal Libro As DLibro, ByVal Registro As String) As List(Of DInventario)

    <OperationContract()>
    Function CopiasDeLibro(ByVal IdLibro As Guid) As List(Of DInventario)

End Interface
