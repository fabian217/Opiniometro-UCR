﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Opiniometro_WebApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Opiniometro_DatosEntities : DbContext
    {
        public Opiniometro_DatosEntities()
            : base("name=Opiniometro_DatosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administrativo> Administrativo { get; set; }
        public virtual DbSet<Canton> Canton { get; set; }
        public virtual DbSet<Carrera> Carrera { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Ciclo_Lectivo> Ciclo_Lectivo { get; set; }
        public virtual DbSet<Conformado_Item_Sec_Form> Conformado_Item_Sec_Form { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Distrito> Distrito { get; set; }
        public virtual DbSet<Empadronado> Empadronado { get; set; }
        public virtual DbSet<Enfasis> Enfasis { get; set; }
        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<Facultad> Facultad { get; set; }
        public virtual DbSet<Fecha_Corte> Fecha_Corte { get; set; }
        public virtual DbSet<Formulario> Formulario { get; set; }
        public virtual DbSet<Formulario_Respuesta> Formulario_Respuesta { get; set; }
        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<Imparte> Imparte { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Matricula> Matricula { get; set; }
        public virtual DbSet<Opciones_De_Respuestas_Seleccion_Unica> Opciones_De_Respuestas_Seleccion_Unica { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<Permiso> Permiso { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Posee_Enfasis_Perfil_Permiso> Posee_Enfasis_Perfil_Permiso { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<Responde> Responde { get; set; }
        public virtual DbSet<Seccion> Seccion { get; set; }
        public virtual DbSet<Seleccion_Unica> Seleccion_Unica { get; set; }
        public virtual DbSet<TelefonoPersona> TelefonoPersona { get; set; }
        public virtual DbSet<Texto_Libre> Texto_Libre { get; set; }
        public virtual DbSet<Tiene_Grupo_Formulario> Tiene_Grupo_Formulario { get; set; }
        public virtual DbSet<Tiene_Usuario_Perfil_Enfasis> Tiene_Usuario_Perfil_Enfasis { get; set; }
        public virtual DbSet<Unidad_Academica> Unidad_Academica { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Conformado_For_Sec> Conformado_For_Sec { get; set; }
    
        public virtual ObjectResult<CursosSegunAnno_Result> CursosSegunAnno(Nullable<short> anno)
        {
            var annoParameter = anno.HasValue ?
                new ObjectParameter("anno", anno) :
                new ObjectParameter("anno", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CursosSegunAnno_Result>("CursosSegunAnno", annoParameter);
        }
    
        public virtual ObjectResult<CursosSegunCarrera_Result> CursosSegunCarrera(string siglaCarrera)
        {
            var siglaCarreraParameter = siglaCarrera != null ?
                new ObjectParameter("siglaCarrera", siglaCarrera) :
                new ObjectParameter("siglaCarrera", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CursosSegunCarrera_Result>("CursosSegunCarrera", siglaCarreraParameter);
        }
    
        public virtual ObjectResult<CursosSegunSemestre_Result> CursosSegunSemestre(Nullable<byte> semestre)
        {
            var semestreParameter = semestre.HasValue ?
                new ObjectParameter("semestre", semestre) :
                new ObjectParameter("semestre", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CursosSegunSemestre_Result>("CursosSegunSemestre", semestreParameter);
        }
    
        public virtual ObjectResult<DatosEstudiante_Result> DatosEstudiante(string cedula)
        {
            var cedulaParameter = cedula != null ?
                new ObjectParameter("Cedula", cedula) :
                new ObjectParameter("Cedula", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DatosEstudiante_Result>("DatosEstudiante", cedulaParameter);
        }
    
        public virtual int EliminarPreguntasDeSeccion(string codigoFormulario, string tituloSeccion)
        {
            var codigoFormularioParameter = codigoFormulario != null ?
                new ObjectParameter("CodigoFormulario", codigoFormulario) :
                new ObjectParameter("CodigoFormulario", typeof(string));
    
            var tituloSeccionParameter = tituloSeccion != null ?
                new ObjectParameter("TituloSeccion", tituloSeccion) :
                new ObjectParameter("TituloSeccion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarPreguntasDeSeccion", codigoFormularioParameter, tituloSeccionParameter);
        }
    
        public virtual ObjectResult<MostrarEstudiantes_Result> MostrarEstudiantes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MostrarEstudiantes_Result>("MostrarEstudiantes");
        }
    
        public virtual ObjectResult<string> NombrePersona(string cedula)
        {
            var cedulaParameter = cedula != null ?
                new ObjectParameter("Cedula", cedula) :
                new ObjectParameter("Cedula", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("NombrePersona", cedulaParameter);
        }
    
        public virtual ObjectResult<string> ObtenerPerfilPorDefecto(string correo)
        {
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("ObtenerPerfilPorDefecto", correoParameter);
        }
    
        public virtual ObjectResult<string> ObtenerPerfilUsuario(string correo)
        {
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("ObtenerPerfilUsuario", correoParameter);
        }
    
        public virtual int ProcIntroducirSeccion(string titulo, string descripcion)
        {
            var tituloParameter = titulo != null ?
                new ObjectParameter("titulo", titulo) :
                new ObjectParameter("titulo", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProcIntroducirSeccion", tituloParameter, descripcionParameter);
        }
    
        public virtual int ProcIntroduFormulario(string codigo, string nombre)
        {
            var codigoParameter = codigo != null ?
                new ObjectParameter("codigo", codigo) :
                new ObjectParameter("codigo", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProcIntroduFormulario", codigoParameter, nombreParameter);
        }
    
        public virtual int SP_AgregarPersonaUsuario(string correo, string contrasenna, string cedula, string nombre, string apellido1, string apellido2, string direccion)
        {
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var contrasennaParameter = contrasenna != null ?
                new ObjectParameter("Contrasenna", contrasenna) :
                new ObjectParameter("Contrasenna", typeof(string));
    
            var cedulaParameter = cedula != null ?
                new ObjectParameter("Cedula", cedula) :
                new ObjectParameter("Cedula", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellido1Parameter = apellido1 != null ?
                new ObjectParameter("Apellido1", apellido1) :
                new ObjectParameter("Apellido1", typeof(string));
    
            var apellido2Parameter = apellido2 != null ?
                new ObjectParameter("Apellido2", apellido2) :
                new ObjectParameter("Apellido2", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_AgregarPersonaUsuario", correoParameter, contrasennaParameter, cedulaParameter, nombreParameter, apellido1Parameter, apellido2Parameter, direccionParameter);
        }
    
        public virtual int SP_AgregarUsuario(string correo, string contrasenna, string cedula)
        {
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var contrasennaParameter = contrasenna != null ?
                new ObjectParameter("Contrasenna", contrasenna) :
                new ObjectParameter("Contrasenna", typeof(string));
    
            var cedulaParameter = cedula != null ?
                new ObjectParameter("Cedula", cedula) :
                new ObjectParameter("Cedula", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_AgregarUsuario", correoParameter, contrasennaParameter, cedulaParameter);
        }
    
        public virtual int SP_CambiarContrasenna(string correo, string contrasenna_Nueva, Nullable<bool> recuperarContrasenna)
        {
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var contrasenna_NuevaParameter = contrasenna_Nueva != null ?
                new ObjectParameter("Contrasenna_Nueva", contrasenna_Nueva) :
                new ObjectParameter("Contrasenna_Nueva", typeof(string));
    
            var recuperarContrasennaParameter = recuperarContrasenna.HasValue ?
                new ObjectParameter("RecuperarContrasenna", recuperarContrasenna) :
                new ObjectParameter("RecuperarContrasenna", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CambiarContrasenna", correoParameter, contrasenna_NuevaParameter, recuperarContrasennaParameter);
        }
    
        public virtual ObjectResult<SP_ContarRespuestasPorGrupo_Result> SP_ContarRespuestasPorGrupo(string codigoFormulario, string cedulaProfesor, Nullable<short> annoGrupo, Nullable<byte> semestreGrupo, Nullable<byte> numeroGrupo, string siglaCurso, string itemId)
        {
            var codigoFormularioParameter = codigoFormulario != null ?
                new ObjectParameter("codigoFormulario", codigoFormulario) :
                new ObjectParameter("codigoFormulario", typeof(string));
    
            var cedulaProfesorParameter = cedulaProfesor != null ?
                new ObjectParameter("cedulaProfesor", cedulaProfesor) :
                new ObjectParameter("cedulaProfesor", typeof(string));
    
            var annoGrupoParameter = annoGrupo.HasValue ?
                new ObjectParameter("annoGrupo", annoGrupo) :
                new ObjectParameter("annoGrupo", typeof(short));
    
            var semestreGrupoParameter = semestreGrupo.HasValue ?
                new ObjectParameter("semestreGrupo", semestreGrupo) :
                new ObjectParameter("semestreGrupo", typeof(byte));
    
            var numeroGrupoParameter = numeroGrupo.HasValue ?
                new ObjectParameter("numeroGrupo", numeroGrupo) :
                new ObjectParameter("numeroGrupo", typeof(byte));
    
            var siglaCursoParameter = siglaCurso != null ?
                new ObjectParameter("siglaCurso", siglaCurso) :
                new ObjectParameter("siglaCurso", typeof(string));
    
            var itemIdParameter = itemId != null ?
                new ObjectParameter("itemId", itemId) :
                new ObjectParameter("itemId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ContarRespuestasPorGrupo_Result>("SP_ContarRespuestasPorGrupo", codigoFormularioParameter, cedulaProfesorParameter, annoGrupoParameter, semestreGrupoParameter, numeroGrupoParameter, siglaCursoParameter, itemIdParameter);
        }
    
        public virtual ObjectResult<string> SP_DevolverObservacionesPorGrupo(string codigoFormulario, string cedulaProfesor, Nullable<short> annoGrupo, Nullable<byte> semestreGrupo, Nullable<byte> numeroGrupo, string siglaCurso, string itemId)
        {
            var codigoFormularioParameter = codigoFormulario != null ?
                new ObjectParameter("codigoFormulario", codigoFormulario) :
                new ObjectParameter("codigoFormulario", typeof(string));
    
            var cedulaProfesorParameter = cedulaProfesor != null ?
                new ObjectParameter("cedulaProfesor", cedulaProfesor) :
                new ObjectParameter("cedulaProfesor", typeof(string));
    
            var annoGrupoParameter = annoGrupo.HasValue ?
                new ObjectParameter("annoGrupo", annoGrupo) :
                new ObjectParameter("annoGrupo", typeof(short));
    
            var semestreGrupoParameter = semestreGrupo.HasValue ?
                new ObjectParameter("semestreGrupo", semestreGrupo) :
                new ObjectParameter("semestreGrupo", typeof(byte));
    
            var numeroGrupoParameter = numeroGrupo.HasValue ?
                new ObjectParameter("numeroGrupo", numeroGrupo) :
                new ObjectParameter("numeroGrupo", typeof(byte));
    
            var siglaCursoParameter = siglaCurso != null ?
                new ObjectParameter("siglaCurso", siglaCurso) :
                new ObjectParameter("siglaCurso", typeof(string));
    
            var itemIdParameter = itemId != null ?
                new ObjectParameter("itemId", itemId) :
                new ObjectParameter("itemId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SP_DevolverObservacionesPorGrupo", codigoFormularioParameter, cedulaProfesorParameter, annoGrupoParameter, semestreGrupoParameter, numeroGrupoParameter, siglaCursoParameter, itemIdParameter);
        }
    
        public virtual int SP_ExistenciaCorreo(string correo, ObjectParameter resultado)
        {
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ExistenciaCorreo", correoParameter, resultado);
        }
    
        public virtual int SP_LoginUsuario(string correo, string contrasenna, ObjectParameter resultado)
        {
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var contrasennaParameter = contrasenna != null ?
                new ObjectParameter("Contrasenna", contrasenna) :
                new ObjectParameter("Contrasenna", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_LoginUsuario", correoParameter, contrasennaParameter, resultado);
        }
    
        public virtual int SP_ModificarPersona(string cedulaBusqueda, string cedula, string nombre, string apellido1, string apellido2, string correo, string direccion)
        {
            var cedulaBusquedaParameter = cedulaBusqueda != null ?
                new ObjectParameter("CedulaBusqueda", cedulaBusqueda) :
                new ObjectParameter("CedulaBusqueda", typeof(string));
    
            var cedulaParameter = cedula != null ?
                new ObjectParameter("Cedula", cedula) :
                new ObjectParameter("Cedula", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellido1Parameter = apellido1 != null ?
                new ObjectParameter("Apellido1", apellido1) :
                new ObjectParameter("Apellido1", typeof(string));
    
            var apellido2Parameter = apellido2 != null ?
                new ObjectParameter("Apellido2", apellido2) :
                new ObjectParameter("Apellido2", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ModificarPersona", cedulaBusquedaParameter, cedulaParameter, nombreParameter, apellido1Parameter, apellido2Parameter, correoParameter, direccionParameter);
        }
    
        public virtual ObjectResult<string> SP_ObtenerFormulario(string cod)
        {
            var codParameter = cod != null ?
                new ObjectParameter("cod", cod) :
                new ObjectParameter("cod", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SP_ObtenerFormulario", codParameter);
        }
    
        public virtual int SP_ObtenerNombre(string correo, ObjectParameter nombre, ObjectParameter apellido)
        {
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ObtenerNombre", correoParameter, nombre, apellido);
        }
    
        public virtual ObjectResult<SP_ObtenerPermisosUsuario_Result> SP_ObtenerPermisosUsuario(string correo, string perfil)
        {
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var perfilParameter = perfil != null ?
                new ObjectParameter("Perfil", perfil) :
                new ObjectParameter("Perfil", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ObtenerPermisosUsuario_Result>("SP_ObtenerPermisosUsuario", correoParameter, perfilParameter);
        }
    
        public virtual ObjectResult<ObtenerPerfilesUsuario_Result> ObtenerPerfilesUsuario(string correo)
        {
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObtenerPerfilesUsuario_Result>("ObtenerPerfilesUsuario", correoParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int SP_CopiarSeccion(string codFormOrigen, string tituloSec, string codFormDest)
        {
            var codFormOrigenParameter = codFormOrigen != null ?
                new ObjectParameter("CodFormOrigen", codFormOrigen) :
                new ObjectParameter("CodFormOrigen", typeof(string));
    
            var tituloSecParameter = tituloSec != null ?
                new ObjectParameter("TituloSec", tituloSec) :
                new ObjectParameter("TituloSec", typeof(string));
    
            var codFormDestParameter = codFormDest != null ?
                new ObjectParameter("CodFormDest", codFormDest) :
                new ObjectParameter("CodFormDest", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CopiarSeccion", codFormOrigenParameter, tituloSecParameter, codFormDestParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int SP_Insertar_Opciones_De_Respuestas_Seleccion_Unica(string itemid, Nullable<short> orden, string opcionrespuesta)
        {
            var itemidParameter = itemid != null ?
                new ObjectParameter("itemid", itemid) :
                new ObjectParameter("itemid", typeof(string));
    
            var ordenParameter = orden.HasValue ?
                new ObjectParameter("orden", orden) :
                new ObjectParameter("orden", typeof(short));
    
            var opcionrespuestaParameter = opcionrespuesta != null ?
                new ObjectParameter("opcionrespuesta", opcionrespuesta) :
                new ObjectParameter("opcionrespuesta", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Insertar_Opciones_De_Respuestas_Seleccion_Unica", itemidParameter, ordenParameter, opcionrespuestaParameter);
        }
    
        public virtual int SP_Insertar_Seccion(string titulo, string descripcion)
        {
            var tituloParameter = titulo != null ?
                new ObjectParameter("titulo", titulo) :
                new ObjectParameter("titulo", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Insertar_Seccion", tituloParameter, descripcionParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
