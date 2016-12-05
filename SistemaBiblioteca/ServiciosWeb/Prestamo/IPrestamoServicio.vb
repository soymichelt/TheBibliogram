Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IPrestamoServicio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IPrestamoServicio

    <OperationContract()>
    Sub DoWork()

    <OperationContract>
    Sub Guardar(ByVal Prestamo As DPrestamo, ByVal BibliografiaPrestar As List(Of DInventario))

    <OperationContract>
    Sub Editar(ByVal Prestamo As DPrestamo, ByVal BibliografiaPrestar As List(Of DInventario))

    <OperationContract>
    Sub Eliminar(ByVal IdPrestamo As Guid)

    <OperationContract>
    Function Lista(ByVal Prestamo As DPrestamo, ByVal Inicio As DateTime, ByVal Final As DateTime, ByVal EdadMinima As Integer, ByVal EdadMaxima As Integer) As List(Of DPrestamo)

    <OperationContract>
    Function BuscarPorId(ByVal IdPrestamo As Guid) As DPrestamo

    <OperationContract>
    Function BuscarPorN(ByVal N As Integer) As DPrestamo

    <OperationContract>
    Function ListadoDetalle(ByVal IdPrestamo As Guid) As List(Of DDetallePrestamo)

    <OperationContract()>
    Function BuscarPorRegistro(ByVal Registro As String) As DInventario

    <OperationContract()>
    Function Busqueda(ByVal Inicio As DateTime, ByVal Final As DateTime, ByVal Persona As String) As List(Of DPrestamo)

    <OperationContract()>
    Sub Entregar(ByVal IdInventario As Guid)

    <OperationContract()>
    Function Solvencia() As List(Of DInventario)

End Interface
