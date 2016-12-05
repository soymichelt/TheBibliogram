using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Capadedatos.Models
{
    /***************************************************
     *                                                 *
     *             MODULO DE ADQUISICIÓN               *
     *                                                 *
     ***************************************************/

    public class Adquisicion
    {
        public Adquisicion()
        {
            this.Inventarios = new HashSet<Inventario>();
        }

        [Key]
        public Guid IdAdquisicion { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long N { get; set; }
        public DateTime FechaReg { get; set; }
        public string Observacion { get; set; }

        public Boolean Activo { get; set; }

        public virtual ICollection<Inventario> Inventarios { get; set; }
    }

    /***************************************************
     *                                                 *
     *             MODULO DE CATALOGACION              *
     *                                                 *
     ***************************************************/

    //autor institucional
    public class Institucion
    {
        public Institucion()
        {
            this.Libros = new HashSet<Libro>();
        }

        [Key]
        public Guid IdInstitucion { get; set; }
        [Required]
        [Display(Name = "Autores Institucional")]
        public string Descripcion { get; set; }
        [Required]
        public bool Activo { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }

    //cuidad
    public class Ciudad
    {
        public Ciudad()
        {
            this.Libros = new HashSet<Libro>();
        }

        [Key]
        public Guid IdCiudad { get; set; }
        [Required]
        [Display(Name = "Nombre de la Ciudad")]
        public string Descripcion { get; set; }
        [Required]
        [Display(Name = "Nombre del Pais")]
        public Guid IdPais { get; set; }
        [Required]
        public bool Activo { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
        public virtual Pais Pais { get; set; }
    }

    //detalle_encabezado
    public class DetalleEncabezado
    {
        [Key]
        public Guid IdDetalle { get; set; }
        [Required]
        [Display(Name = "Libro")]
        public Guid IdLibro { get; set; }
        [Required]
        [Display(Name = "Encabezado")]
        public Guid IdEncabezado { get; set; }

        public virtual Encabezado Encabezado { get; set; }
        public virtual Libro Libro { get; set; }
    }

    //editor
    public class Editor
    {
        public Editor()
        { this.Libros = new HashSet<Libro>(); }

        [Key]
        public Guid IdEditor { get; set; }
        [Required]
        [Display(Name = "Nombre del Editor")]
        public string Descripcion { get; set; }
        [Required]
        public bool Activo { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }

    //encabezado
    public class Encabezado
    {
        public Encabezado()
        {
            this.DetalleEncabezado = new HashSet<DetalleEncabezado>();
        }

        [Key]
        public Guid IdEncabezado { get; set; }
        [Display(Name = "Nombre del Encabezado")]
        public string Descripcion { get; set; }
        [Required]
        public bool Activo { get; set; }

        public virtual ICollection<DetalleEncabezado> DetalleEncabezado { get; set; }
    }

    //grado
    public class Grado
    {
        public Grado()
        {
            this.Libros = new HashSet<Libro>();
        }

        [Key]
        public Guid IdGrado { get; set; }
        [Required]
        [Display(Name = "Grado Academico")]
        public string Descripcion { get; set; }
        [Required]
        public bool Activo { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }

    //idioma
    public class Idioma
    {
        public Idioma()
        {
            this.Libros = new HashSet<Libro>();
        }

        [Key]
        public Guid IdIdioma { get; set; }
        [Required]
        [Display(Name = "Idioma")]
        public string Descripcion { get; set; }
        [Required]
        public bool Activo { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }

    //inventario
    public class Inventario
    {
        public Inventario()
        {
            this.DetallesPrestamos = new HashSet<DetallePrestamo>();
            this.DetallesEntregas = new HashSet<DetalleEntrega>();
        }

        [Key]
        public Guid IdInventario { get; set; }
        [Required]
        [Display(Name = "N° de Registro")]
        public string Registro { get; set; }
        [Required]
        [Display(Name = "Libro")]
        public Guid IdLibro { get; set; }
        [Required]
        [Display(Name = "Adquisicion")]
        public Guid IdAdquisicion { get; set; }
        [Required]
        [Display(Name = "Prestado")]
        public Boolean Prestado { get; set; }
        [Required]
        [Display(Name = "Activo")]
        public Boolean Activo { get; set; }

        public virtual ICollection<DetallePrestamo> DetallesPrestamos { get; set; }
        public virtual ICollection<DetalleEntrega> DetallesEntregas { get; set; }
        public virtual Libro Libro { get; set; }
        public virtual Adquisicion Adquisicion { get; set; }
    }

    //libro
    public class Libro
    {
        public Libro()
        {
            this.DetallesEncabezados = new HashSet<DetalleEncabezado>();
            this.Inventarios = new HashSet<Inventario>();
            this.Archivos = new HashSet<Archivo>();
        }

        [Key]
        public Guid IdLibro { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long N { get; set; }
        public DateTime FechaReg { get; set; }
        public DateTime FechaMod { get; set; }
        //[Required]
        [Display(Name = "Tipo de Documento")]
        public string TipoDocumento { get; set; }
        //[Required]
        [Display(Name = "Tipo de Registro")]
        public string TipoRegistro { get; set; }
        //[Required]
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        //[Required]
        [Display(Name = "Otro Título")]
        public string OtroTitulo { get; set; }
        //[Required]
        [Display(Name = "Tutor")]
        public Nullable<Guid> IdTutor { get; set; }
        [Display(Name = "Autor Institucional")]
        public Nullable<Guid> IdInstitucion { get; set; }
        [Display(Name = "Primer Autor")]
        public string Autor1 { get; set; }
        [Display(Name = "Segundo Autor")]
        public string Autor2 { get; set; }
        [Display(Name = "Tercer Autor")]
        public string Autor3 { get; set; }
        //[Required]
        [Display(Name = "Idioma")]
        public Nullable<Guid> IdIdioma { get; set; }
        //[Required]
        [Display(Name = "Editor")]
        public Nullable<Guid> IdEditor { get; set; }
        [Display(Name = "Lugar de edición")]
        public Nullable<Guid> IdCiudad { get; set; }
        //[Required]
        [Display(Name = "Edición")]
        public string Edicion { get; set; }
        //[Required]
        [Display(Name = "Fecha de Publicación")]
        public string FechaPublicacion { get; set; }
        //[Required]
        [Display(Name = "Colación")]
        public string Colacion { get; set; }
        //[Required]
        [Display(Name = "N° ISBN")]
        public string Isbn { get; set; }
        [Display(Name = "Notas")]
        public string Notas { get; set; }
        [Display(Name = "Tipo de Investigación")]
        public string TipoInvestigacion { get; set; }
        [Display(Name = "Grado")]
        public Nullable<Guid> IdGrado { get; set; }
        [Display(Name = "Signatura")]
        public string Signatura { get; set; }
        [Display(Name = "Adquisición del Documento")]
        public string Adquisicion { get; set; }
        [Display(Name = "Valor en moneda original")]
        public decimal ValorOriginal { get; set; }
        [Display(Name = "Valor en dolar")]
        public decimal ValorDolar { get; set; }
        [Display(Name = "Valor en moneda nacional")]
        public decimal ValorCordoba { get; set; }
        [Display(Name = "Resumen")]
        public string Resumen { get; set; }
        [Display(Name = "Otro Código")]
        public string OtroCodigo { get; set; }
        [Display(Name = "Norma")]
        public string Norma { get; set; }
        [Display(Name = "Estilo")]
        public string Estilo { get; set; }
        [Display(Name = "Cita Bibliográfica")]
        public string Cita { get; set; }
        [Display(Name = "Imagen de Perfil")]
        public string ImagenPerfilUrl { get; set; }
        [Display(Name = "Activo")]
        public bool Activo { get; set; }
        public virtual Guid IdUsuario { get; set; }

        public virtual Institucion Institucion { get; set; }
        public virtual ICollection<DetalleEncabezado> DetallesEncabezados { get; set; }
        public virtual Grado Grado { get; set; }
        public virtual Idioma Idioma { get; set; }
        public virtual Tutor Tutor { get; set; }
        public virtual ICollection<Inventario> Inventarios { get; set; }
        public virtual ICollection<Archivo> Archivos { get; set; }
        public virtual Ciudad Ciudad { get; set; }
        public virtual Editor Editor { get; set; }
        public virtual ICollection<LibroImagen> LibrosImagenes { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<Publicacion> Publicaciones { get; set; }
        public ICollection<Favorito> Favoritos { get; set; }
    }

    public class LibroImagen
    {
        [Key]
        public Guid IdImagen { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string ImageUrl { get; set; }
        public Guid IdLibro { get; set; }
        public bool Activo { get; set; }

        public virtual Libro Libro { get; set; }
    }

    //pais
    public class Pais
    {
        public Pais()
        {
            this.Ciudades = new HashSet<Ciudad>();
        }

        [Key]
        public Guid IdPais { get; set; }
        [Required]
        [Display(Name = "Código del País")]
        public string CodPais { get; set; }
        [Required]
        [Display(Name = "Nombre del Pais")]
        public string Descripcion { get; set; }
        [Required]
        public bool Activo { get; set; }

        public virtual ICollection<Ciudad> Ciudades { get; set; }
    }

    //tutor
    public class Tutor
    {
        public Tutor()
        {
            this.Libros = new HashSet<Libro>();
        }

        [Key]
        public Guid IdTutor { get; set; }
        [Required]
        [Display(Name = "Nombre del Tutor")]
        public string Nombres { get; set; }
        [Required]
        [Display(Name = "Apellido del Tutor")]
        public string Apellidos { get; set; }
        [Required]
        public bool Activo { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }

    //archivos
    public class Archivo
    {
        [Key]
        public Guid IdArchivo { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public Guid IdLibro { get; set; }
        [Required]
        public bool Activo { get; set; }

        public virtual Libro Libro { get; set; }
    }

    /***************************************************
     *                                                 *
     *             MODULO DE PRESTAMOS                 *
     *                                                 *
     ***************************************************/

    public class Prestamo
    {
        public Prestamo()
        {
            this.DetallesPrestamos = new HashSet<DetallePrestamo>();
        }

        [Key]
        public Guid IdPrestamo { get; set; }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public long N { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public string Tipo { get; set; }
        public string Observacion { get; set; }
        public Guid IdPersona { get; set; }
        public Boolean Activo { get; set; }

        public string TipoPersona { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public Boolean Sexo { get; set; }
        public int Edad { get; set; }
        public string NCarnet { get; set; }
        public string Turno { get; set; }
        public string Area { get; set; }
        public string DepartamentoAcademicoEstudiante { get; set; }
        public string DepartamentoAcademicoDocente { get; set; }
        public string Carrera { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }

        public virtual ICollection<DetallePrestamo> DetallesPrestamos { get; set; }
        public Persona Persona { get; set; }
    }

    public class DetallePrestamo
    {
        [Key]
        public Guid IdDetallePrestamo { get; set; }
        public Guid IdInventario { get; set; }
        public Guid IdPrestamo { get; set; }

        public Prestamo Prestamo { get; set; }
        public Inventario Inventario { get; set; }
    }

    public class Entrega
    {
        public Entrega()
        {
            this.DetallesEntregas = new HashSet<DetalleEntrega>();
        }

        [Key]
        public Guid IdEntrada { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Mora { get; set; }
        [Required]
        public bool Activo { get; set; }

        public virtual ICollection<DetalleEntrega> DetallesEntregas { get; set; }
    }

    public class DetalleEntrega
    {
        [Key]
        public Guid IdDetalle { get; set; }
        public Guid IdEntrada { get; set; }
        public Guid IdInventario { get; set; }

        public Entrega Entrega { get; set; }
        public Inventario Inventario { get; set; }
    }


    public class Persona
    {
        [Key]
        public Guid IdPersona { get; set; }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public long N { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }
        public string TipoPersona { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public Boolean Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Domicilio { get; set; }
        public string NCarnet { get; set; }
        public string Turno { get; set; }
        public string Area { get; set; }
        public string DepartamentoAcademicoEstudiante { get; set; }
        public string DepartamentoAcademicoDocente { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public Nullable<Guid> IdCarrera { get; set; }
        public Nullable<Guid> IdCiudad { get; set; }
        public string Observacion { get; set; }
        public Boolean Activo { get; set; }

        public virtual Carrera Carrera { get; set; }
        public virtual ICollection<Prestamo> Prestamos { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
    }

    public class Publicacion
    {
        [Key]
        public Guid IdPublicacion { get; set; }
        public DateTime FechaReg { get; set; }
        public DateTime FechaMod { get; set; }
        public String Tipo { get; set; }
        public String Contenido { get; set; }
        public Boolean Activo { get; set; }
        public Guid IdUsuario { get; set; }
        public Nullable<Guid> IdLibro { get; set; }
        public Nullable<Guid> IdRecomendacion { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual Libro Libro { get; set; }
        public virtual Recomendacion Recomendar { get; set; }
        public virtual ICollection<Favorito> Favoritos { get; set; }
    }

    public class Carrera
    {
        [Key]
        public Guid IdCarrera { get; set; }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public long N { get; set; }
        public string NombreCarrera { get; set; }
        public Boolean Activo { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }

    public class Recomendacion
    {
        [Key]
        public Guid IdRecomendacion { get; set; }
        public DateTime FechaReg { get; set; }
        public DateTime FechaMod { get; set; }
        public string AreaDirigida { get; set; }
        public string Titulo { get; set; }
        public string OtroTitulo { get; set; }
        public string Autores { get; set; }
        public string Isbn { get; set; }
        public string Volumen { get; set; }
        public string Edicion { get; set; }
        public string Nota { get; set; }
        public Boolean Activo { get; set; }

        public Guid IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
        public virtual ICollection<Publicacion> Publicaciones { get; set; }
        public ICollection<Favorito> Favoritos { get; set; }
    }

    /*GESTION DE USUARIOS*/
    public class Usuario
    {
        public Usuario()
        {
            this.Recomendaciones = new HashSet<Recomendacion>();
            this.Visitas = new HashSet<Visita>();
            this.Sesiones = new HashSet<Sesion>();
        }

        [Key]
        public Guid IdUsuario { get; set; }
        public DateTime FechaReg { get; set; }
        public DateTime FechaMod { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Boolean Sexo { get; set; }
        public int Rol { get; set; }
        public string Descripcion { get; set; }
        public Nullable<Guid> IdPersona { get; set; }

        public Boolean Activo { get; set; }

        public ICollection<Recomendacion> Recomendaciones { get; set; }
        public ICollection<Visita> Visitas { get; set; }
        public ICollection<Sesion> Sesiones { get; set; }
        public ICollection<Favorito> Favoritos { get; set; }
        public ICollection<Guardado> Guardados { get; set; }
        public ICollection<Libro> Libros { get; set; }
        public virtual ICollection<Publicacion> Publicaciones { get; set; }
    }

    public class Favorito
    {
        [Key]
        public Guid IdFavorito { get; set; }
        public DateTime FechaReg { get; set; }
        public Guid IdUsuario { get; set; }
        public Nullable<Guid> IdPublicacion { get; set; }
        public Nullable<Guid> IdLibro { get; set; }
        public Nullable<Guid> IdRecomendacion { get; set; }
        public Boolean Activo { get; set; }

        public Usuario Usuario { get; set; }
        public Publicacion Publicacion { get; set; }
        public Libro Libro { get; set; }
        public Recomendacion Recomendacion { get; set; }
    }

    public class Guardado
    {
        [Key]
        public Guid IdGuardado { get; set; }
        public DateTime FechaReg { get; set; }
        public Guid IdUsuario { get; set; }
        public Guid IdLibro { get; set; }
        public Boolean Activo { get; set; }

        public Usuario Usuario { get; set; }
        public Libro Libro { get; set; }
    }
    public class Sesion
    {
        [Key]
        public Guid IdSesion { get; set; }
        public DateTime FechaReg { get; set; }
        public Guid IdUsuario { get; set; }

        public Usuario Usuario { get; set; }
    }
    public class Visita
    {
        [Key]
        public Guid IdVisita { get; set; }
        public DateTime FechaReg { get; set; }
        public Nullable<Guid> IdUsuario { get; set; }

        public Usuario Usuario { get; set; }
    }
    /*FIN DE USUARIOS*/

    /***************************************************
     *                                                 *
     *            CONTEXTO DE BASE DE DATOS            *
     *                                                 *
     ***************************************************/

    public class ContextoBiblioteca : DbContext
    {
        //iniciar conexion con name=Biblioteca
        public ContextoBiblioteca()
            : //base("name=Biblioteca")
            base("name=Biblioteca")
        { }

        //ADQUISICION
        public DbSet<Adquisicion> Adquisiciones { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }

        //inventario de la biblioteca
        public DbSet<Archivo> Archivos { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }
        public DbSet<Institucion> Instituciones { get; set; }
        public DbSet<Encabezado> Encabezados { get; set; }
        public DbSet<Grado> Grados { get; set; }
        public DbSet<Editor> Editores { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<LibroImagen> LibrosImagenes { get; set; }
        public DbSet<DetalleEncabezado> DetallesEncabezados { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Tutor> Tutores { get; set; }

        //RECOMENDACIONES
        public DbSet<Recomendacion> Recomendaciones { get; set; }

        //prestamos
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Entrega> Entregas { get; set; }
        public DbSet<DetallePrestamo> DetallesPrestamos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<DetalleEntrega> DetallesEntregas { get; set; }

        //Dashboard
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Visita> Visitas { get; set; }
        public DbSet<Sesion> Sesiones { get; set; }
        public DbSet<Favorito> Favoritos { get; set; }
        public DbSet<Guardado> Guardados { get; set; }
        public DbSet<Publicacion> Publicaciones { get; set; }

        //sobrecargar metodo heredado onModelCreating para especificar que no se pluralice el modelo
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}