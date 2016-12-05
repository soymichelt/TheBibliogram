Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IGradoServicio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IGradoServicio

    <OperationContract()>
    Sub DoWork()

    <OperationContract>
    Sub Guardar(ByVal Grado As DGrado)

    <OperationContract>
    Function Lista() As List(Of DGrado)

    <OperationContract>
    Function BuscarPorDescripcion(ByVal Descripcion As String) As DGrado

    <OperationContract>
    Function Existe(ByVal Descripcion As String) As Boolean

End Interface
