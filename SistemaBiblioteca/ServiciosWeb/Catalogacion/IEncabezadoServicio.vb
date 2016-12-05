Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IEncabezadoServicio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IEncabezadoServicio

    <OperationContract()>
    Sub DoWork()

    <OperationContract>
    Sub Guardar(ByVal Encabezado As DEncabezado)

    <OperationContract>
    Function Lista() As List(Of DEncabezado)

    <OperationContract>
    Function BuscarPorDescripcion(ByVal Descripcion As String) As DEncabezado

    <OperationContract>
    Function Existe(ByVal Descripcion As String) As Boolean

End Interface
