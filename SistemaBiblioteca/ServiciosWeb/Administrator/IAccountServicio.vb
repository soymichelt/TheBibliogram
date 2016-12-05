Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IAccountServicio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IAccountServicio

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
    Function Signin(ByVal Usuario As DUsuario) As DUsuario

    <OperationContract()>
    Function Register(ByVal Usuario As DUsuario) As DUsuario

End Interface
