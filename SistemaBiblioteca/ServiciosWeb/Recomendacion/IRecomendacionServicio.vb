Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IRecomendacionServicio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IRecomendacionServicio

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
    Function Guardar(ByVal Recomendacion As DRecomendacion) As Guid

    <OperationContract()>
    Function CantidadAnual() As List(Of DCantidadMensual)

    <OperationContract()>
    Function Busqueda(ByVal Inicio As DateTime, ByVal Fin As DateTime, ByVal NombreUsuario As String) As List(Of DRecomendacion)

    <OperationContract()>
    Function RecomendacionesUsers(ByVal Inicio As DateTime, ByVal Fin As DateTime, ByVal IdUsuario As Guid) As List(Of DRecomendacion)

End Interface
