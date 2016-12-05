<DataContract>
Public Class DCarrera
    <DataMember>
    Public Property IdCarrera As Guid
    <DataMember>
    Public Property N As Long
    <DataMember>
    Public Property NombreCarrera As String
End Class

<DataContract>
Public Class DPais
    <DataMember>
    Public Property IdPais As Guid
    <DataMember>
    Public Property CodPais As String
    <DataMember>
    Public Property Descripcion As String
End Class

<DataContract>
Public Class DCiudad
    <DataMember>
    Public Property IdCiudad As Guid
    <DataMember>
    Public Property Descripcion As String
    <DataMember>
    Public Property IdPais As Guid
    <DataMember>
    Public Property Pais As String
End Class

<DataContract()>
Public Class DInstitucion
    <DataMember>
    Public Property IdInstitucion As Guid
    <DataMember>
    Public Property Descripcion As String
End Class

<DataContract()>
Public Class DDetalle_Encabezado
    <DataMember()>
    Public Property ID_DETALLE As Guid
    <DataMember()>
    Public Property ID_LIBRO As Guid
    <DataMember()>
    Public Property ID_ENCABEZADO As Guid
End Class

<DataContract>
Public Class DEditor
    <DataMember>
    Public Property IdEditor As Guid
    <DataMember>
    Public Property Descripcion As String
End Class

<DataContract()>
Public Class DEncabezado
    <DataMember>
    Public Property IdEncabezado As Guid
    <DataMember>
    Public Property Descripcion As String
End Class

<DataContract>
Public Class DGrado
    <DataMember>
    Public Property IdGrado As Guid
    <DataMember>
    Public Property Descripcion As String
End Class

<DataContract()>
Public Class DLibro
    <DataMember()>
    Public Property ID_LIBRO As Guid
    <DataMember()>
    Public Property N As Long
    <DataMember()>
    Public Property FechaReg As DateTime
    <DataMember()>
    Public Property FechaMod As DateTime
    <DataMember()>
    Public Property TIPODEDOCUMENTO As String
    <DataMember()>
    Public Property TIPOREGISTRO As String
    <DataMember()>
    Public Property TITULO As String
    <DataMember()>
    Public Property OTRO_TITULO As String
    <DataMember()>
    Public Property ID_TUTOR As Nullable(Of Guid)
    <DataMember()>
    Public Property TUTOR As String
    <DataMember()>
    Public Property ID_INSTITUCION As Nullable(Of Guid)
    <DataMember()>
    Public Property INSTITUCION As String
    <DataMember()>
    Public Property AUTOR1 As String
    <DataMember()>
    Public Property AUTOR2 As String
    <DataMember()>
    Public Property AUTOR3 As String
    <DataMember()>
    Public Property ID_IDIOMA As Nullable(Of Guid)
    <DataMember()>
    Public Property IDIOMA As String
    <DataMember()>
    Public Property ID_EDITORA As Nullable(Of Guid)
    <DataMember()>
    Public Property EDITORA As String
    <DataMember()>
    Public Property ID_CIUDAD As Nullable(Of Guid)
    <DataMember()>
    Public Property CIUDAD As String
    <DataMember()>
    Public Property EDICION As String
    <DataMember()>
    Public Property FECHAPUBLICACION As String
    <DataMember()>
    Public Property COLACION As String
    <DataMember()>
    Public Property ISBN As String
    <DataMember()>
    Public Property NOTAS As String
    <DataMember()>
    Public Property TIPOINVESTIGACION As String
    <DataMember()>
    Public Property ID_GRADO As Nullable(Of Guid)
    <DataMember()>
    Public Property GRADO As String
    <DataMember()>
    Public Property SIGNATURA As String
    <DataMember()>
    Public Property ADQUISICION As String
    <DataMember()>
    Public Property VALORORIGINAL As Decimal
    <DataMember()>
    Public Property VALORCORDOBA As Decimal
    <DataMember()>
    Public Property VALORDOLAR As Decimal
    <DataMember()>
    Public Property RESUMEN As String
    <DataMember()>
    Public Property OTRO_CODIGO As String
    <DataMember()>
    Public Property Norma As String
    <DataMember()>
    Public Property Estilo As String
    <DataMember()>
    Public Property Cita As String
    <DataMember()>
    Public Property ImagenPerfilUrl As String
    <DataMember()>
    Public Property Activo As Boolean
    <DataMember()>
    Public Property IdUsuario As Guid
End Class

<DataContract>
Public Class DIdioma
    <DataMember>
    Public IdIdioma As Guid
    <DataMember>
    Public Descripcion As String
End Class

<DataContract>
Public Class DPersona
    <DataMember>
    Public Property IdPersona As Guid
    <DataMember>
    Public Property N As Long
    <DataMember>
    Public Property FechaRegistro As DateTime
    <DataMember>
    Public Property FechaUltimaModificacion As DateTime
    <DataMember>
    Public Property TipoPersona As String
    <DataMember>
    Public Property TipoIdentificacion As String
    <DataMember>
    Public Property Identificacion As String
    <DataMember>
    Public Property Nombres As String
    <DataMember>
    Public Property Apellidos As String
    <DataMember>
    Public Property Sexo As Boolean
    <DataMember>
    Public Property FechaNacimiento As DateTime
    <DataMember>
    Public Property Telefono As String
    <DataMember>
    Public Property Domicilio As String
    <DataMember>
    Public Property NCarnet As String
    <DataMember>
    Public Property Turno As String
    <DataMember>
    Public Property Area As String
    <DataMember>
    Public Property DepartamentoAcademicoEstudiante As String
    <DataMember>
    Public Property DepartamentoAcademicoDocente As String
    <DataMember>
    Public Property Departamento As String
    <DataMember>
    Public Property Municipio As String
    <DataMember>
    Public Property IdCarrera As Nullable(Of Guid)
    <DataMember>
    Public Property Carrera As String
    <DataMember>
    Public Property IdCiudad As Nullable(Of Guid)
    <DataMember>
    Public Property Ciudad As String
    <DataMember>
    Public Property Pais As String
    <DataMember>
    Public Property Observacion As String
    <DataMember>
    Public Property Activo As Boolean
End Class

<DataContract>
Public Class DPrestamo
    <DataMember>
    Public Property IdPrestamo As Guid
    <DataMember>
    Public Property N As Long
    <DataMember>
    Public Property FechaPrestamo As DateTime
    <DataMember>
    Public Property Tipo As String
    <DataMember>
    Public Property Observacion As String
    <DataMember>
    Public Property IdPersona As Guid
    <DataMember>
    Public Property NombrePersona As String
    <DataMember>
    Public Property Activo As Boolean
    <DataMember>
    Public Property TipoPersona As String
    <DataMember>
    Public Property TipoIdentificacion As String
    <DataMember>
    Public Property Identificacion As String
    <DataMember>
    Public Property Sexo As Boolean
    <DataMember>
    Public Property Edad As Integer
    <DataMember>
    Public Property NCarnet As String
    <DataMember>
    Public Property Turno As String
    <DataMember>
    Public Property Area As String
    <DataMember>
    Public Property DepartamentoAcademicoEstudiante As String
    <DataMember>
    Public Property DepartamentoAcademicoDocente As String
    <DataMember>
    Public Property Departamento As String
    <DataMember>
    Public Property Municipio As String
    <DataMember>
    Public Property Carrera As String
End Class

<DataContract>
Public Class DDetallePrestamo
    <DataMember>
    Public Property IdDetallePrestamo As Guid
    <DataMember>
    Public Property IdInventario As Guid
    <DataMember>
    Public Property IdPrestamo As Guid

    'datos del inventario
    <DataMember>
    Public Property Registro As String

    'datos del libro
    <DataMember>
    Public Property TipoDocumento As String
    <DataMember>
    Public Property TipoRegistro As String
    <DataMember>
    Public Property Signatura As String
    <DataMember>
    Public Property Titulo As String
    <DataMember>
    Public Property OtroTitulo As String
    <DataMember>
    Public Property Institucion As String
    <DataMember>
    Public Property Autor1 As String
    <DataMember>
    Public Property Autor2 As String
    <DataMember>
    Public Property Autor3 As String
    <DataMember>
    Public Property Idioma As String
    <DataMember>
    Public Property Editor As String
    <DataMember>
    Public Property Edicion As String
    <DataMember>
    Public Property Isbn As String
End Class

<DataContract>
Public Class DInventario
    <DataMember>
    Public Property IdInventario As Guid
    <DataMember>
    Public Property Registro As String
    <DataMember>
    Public Property IdLibro As Guid
    <DataMember>
    Public Property IdAdquisicion As Guid
    <DataMember>
    Public Property Prestado As Boolean
    <DataMember>
    Public Property Activo As Boolean

    'datos del libro
    <DataMember>
    Public Property TipoDocumento As String
    <DataMember>
    Public Property TipoRegistro As String
    <DataMember>
    Public Property Signatura As String
    <DataMember>
    Public Property Titulo As String
    <DataMember>
    Public Property OtroTitulo As String
    <DataMember>
    Public Property Institucion As String
    <DataMember>
    Public Property Autor1 As String
    <DataMember>
    Public Property Autor2 As String
    <DataMember>
    Public Property Autor3 As String
    <DataMember>
    Public Property Idioma As String
    <DataMember>
    Public Property Editor As String
    <DataMember>
    Public Property Edicion As String
    <DataMember>
    Public Property Isbn As String

End Class

<DataContract>
Public Class DRecomendacion
    <DataMember>
    Public Property IdRecomendacion As Guid
    <DataMember>
    Public Property FechaReg As DateTime
    <DataMember>
    Public Property FechaMod As DateTime
    <DataMember>
    Public Property AreaDirigida As String
    <DataMember>
    Public Property Titulo As String
    <DataMember>
    Public Property OtroTitulo As String
    <DataMember>
    Public Property Autores As String
    <DataMember>
    Public Property Isbn As String
    <DataMember>
    Public Property Volumen As String
    <DataMember>
    Public Property Edicion As String
    <DataMember>
    Public Property Nota As String
    <DataMember>
    Public Property Activo As Boolean
    <DataMember>
    Public Property IdUsuario As Guid
    <DataMember>
    Public Property Usuario As String
End Class

<DataContract>
Public Class DCantidadMensual
    <DataMember>
    Public Property Id As Integer
    <DataMember>
    Public Property Mes As String
    <DataMember>
    Public Property Cantidad As Decimal
End Class

<DataContract>
Public Class DCantidadMensual3Columnas
    <DataMember>
    Public Property Id As Integer
    <DataMember>
    Public Property Mes As String
    <DataMember>
    Public Property C1 As Decimal
    <DataMember>
    Public Property C2 As Decimal
    <DataMember>
    Public Property C3 As Decimal
End Class

<DataContract>
Public Class DUsuario
    <DataMember>
    Public Property IdUsuario As Guid
    <DataMember>
    Public Property FechaReg As DateTime
    <DataMember>
    Public Property FechaMod As DateTime
    <DataMember>
    Public Property Nombres As String
    <DataMember>
    Public Property Apellidos As String
    <DataMember>
    Public Property FechaNacimiento As DateTime
    <DataMember>
    Public Property Email As String
    <DataMember>
    Public Property Password As String
    <DataMember>
    Public Property Sexo As Boolean
    <DataMember>
    Public Property Rol As Integer
    <DataMember>
    Public Property Descripcion As String
    <DataMember>
    Public Property Activo As Boolean
End Class