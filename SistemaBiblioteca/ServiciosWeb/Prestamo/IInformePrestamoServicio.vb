Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IInformePrestamoServicio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IInformePrestamoServicio

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
    Function PrestamosPorDepartamento(ByVal Anual As Short, ByVal Modalidad As Byte, ByVal Departamento As Byte) As List(Of DCantidadMensual3Columnas)

    <OperationContract()>
    Function PrestamosPorCarrera(ByVal Anual As Short, ByVal Modalidad As Byte, ByVal Carrera As Guid) As List(Of DCantidadMensual3Columnas)

    <OperationContract()>
    Function PrestamosPorTipoPersona(ByVal Anual As Short, ByVal Modalidad As Byte, ByVal TipoPersona As Byte) As List(Of DCantidadMensual3Columnas)

End Interface
