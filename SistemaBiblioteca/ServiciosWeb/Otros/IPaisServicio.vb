Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IPaisServicio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IPaisServicio

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
    Function Lista() As List(Of DPais)

    <OperationContract()>
    Function Filtrar(ByVal Nombre As String) As List(Of DPais)

    <OperationContract()>
    Sub Guardar(ByVal Pais As DPais)

    <OperationContract()>
    Sub Editar(ByVal Pais As DPais)

    <OperationContract()>
    Sub Eliminar(ByVal IdPais As Guid)

    <OperationContract()>
    Function BuscarPorNombre(ByVal Nombre As String) As DPais

    <OperationContract()>
    Function BuscarPorId(ByVal IdPais As Guid) As DPais

End Interface
