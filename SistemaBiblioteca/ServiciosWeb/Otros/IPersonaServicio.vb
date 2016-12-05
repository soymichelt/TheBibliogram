Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IPersonaServicio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IPersonaServicio

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
    Sub Guardar(ByVal Persona As DPersona)

    <OperationContract()>
    Sub Editar(ByVal Persona As DPersona)

    <OperationContract()>
    Sub Eliminar(ByVal IdPersona As Guid)

    <OperationContract()>
    Function Lista() As List(Of DPersona)

    <OperationContract()>
    Function Filtrar(ByVal Carnet As String, ByVal Id As String, ByVal Nombres As String, ByVal Apellidos As String) As List(Of DPersona)

    <OperationContract()>
    Function BuscarPorCarnet(ByVal Carnet As String) As DPersona

    <OperationContract()>
    Function BuscarPorIdentificacion(ByVal Id As String) As DPersona

    <OperationContract>
    Function Busqueda(ByVal Persona As DPersona) As List(Of DPersona)

    <OperationContract>
    Function BuscarPorId(ByVal IdPersona As Guid) As DPersona

    <OperationContract>
    Function BuscarPorCarnetOIdentificacion(ByVal Id As String) As DPersona

End Interface