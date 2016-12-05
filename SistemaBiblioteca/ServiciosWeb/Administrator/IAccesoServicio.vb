Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IAccesoServicio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IAccesoServicio

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
    Sub RegistrarVisita(ByVal IdUsuario As Nullable(Of Guid))


End Interface
