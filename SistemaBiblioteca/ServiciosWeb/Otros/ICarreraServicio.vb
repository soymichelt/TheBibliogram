Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "ICarreraServicio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface ICarreraServicio

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
    Function Lista() As List(Of DCarrera)

    <OperationContract()>
    Function Filtrar(ByVal Nombre As String) As List(Of DCarrera)

    <OperationContract()>
    Sub Guardar(ByVal Carrera As DCarrera)

    <OperationContract()>
    Function BuscarPorNombre(ByVal Nombre As String) As DCarrera

    <OperationContract()>
    Function BuscarPorId(ByVal IdCarrera As Guid) As DCarrera

End Interface
