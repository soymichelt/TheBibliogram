Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IInstitucionServicio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IInstitucionServicio

    <OperationContract()>
    Sub DoWork()

    <OperationContract>
    Sub Guardar(ByVal Institucion As DInstitucion)

    <OperationContract>
    Function Lista() As List(Of DInstitucion)

    <OperationContract>
    Function BuscarPorDescripcion(ByVal Descripcion As String) As DInstitucion

    <OperationContract>
    Function Existe(ByVal Descripcion As String) As Boolean

End Interface
