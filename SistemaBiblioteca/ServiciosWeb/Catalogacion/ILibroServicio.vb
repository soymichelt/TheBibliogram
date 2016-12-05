Imports System.ServiceModel
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "ILibroController" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface ILibroServicio

    <OperationContract()>
    Function Guardar(ByVal Libro As DLibro, ByVal Encabezados As List(Of DDetalle_Encabezado), ByVal Copias As List(Of DInventario), ByVal Imagen As Byte()) As Boolean

    <OperationContract()>
    Function Detalle(ByVal IdLibro As Guid) As DLibro

    <OperationContract()>
    Function Editar(ByVal libro As DLibro, ByVal Encabezados As List(Of DDetalle_Encabezado), ByVal Copias As List(Of DInventario), ByVal Imagen As Byte()) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal IdLibro As Guid) As Boolean

    <OperationContract()>
    Function BuscarId(ByVal IdLibro As Guid) As DLibro

    <OperationContract()>
    Function BuscarSigTop(ByVal SignaturaTopografica As String) As DLibro

    <OperationContract()>
    Function Lista() As List(Of DLibro)

    <OperationContract()>
    Function Busqueda(ByVal Libro As DLibro, ByVal Encabezado As String) As List(Of DLibro)

    <OperationContract>
    Function BuscarEncabezadoPorLibro(ByVal IdLibro As Guid) As List(Of DEncabezado)

    <OperationContract>
    Function BuscarCopiaPorLibro(ByVal IdLibro As Guid) As List(Of DInventario)

    <OperationContract>
    Function BuscarImagen(ByVal Url As String) As Byte()


End Interface