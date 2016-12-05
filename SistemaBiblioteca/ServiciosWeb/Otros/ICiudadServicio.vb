Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "ICiudadServicio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface ICiudadServicio

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
    Function Lista() As List(Of DCiudad)

    <OperationContract()>
    Function Filtrar(ByVal Nombre As String) As List(Of DCiudad)

    <OperationContract()>
    Sub Guardar(ByVal Carrera As DCiudad)

    <OperationContract()>
    Sub Editar(ByVal Ciudad As DCiudad)

    <OperationContract()>
    Sub Eliminar(ByVal IdCiudad As Guid)

    <OperationContract()>
    Function BuscarPorNombre(ByVal Nombre As String) As DCiudad

    <OperationContract()>
    Function BuscarPorId(ByVal IdCarrera As Guid) As DCiudad

End Interface
