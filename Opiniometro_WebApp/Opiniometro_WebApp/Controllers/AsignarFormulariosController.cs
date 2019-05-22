﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Opiniometro_WebApp.Models;

namespace Opiniometro_WebApp.Controllers
{
    public class AsignarFormulariosController : Controller
    {
        private Opiniometro_DatosEntities db = new Opiniometro_DatosEntities();

        // GET: AsignarFormularios
        public ActionResult Index(string searchString)
        {
            var cursos = from m in db.Curso
                         select m;
            //searchString = "Programacion";
            if (!String.IsNullOrEmpty(searchString))
            {
                cursos = cursos.Where(s => s.Nombre.Contains(searchString));
            }

            /*var modelo = new AsignarFormulariosModel
            {
                //Ciclos = obtenerCiclos(),
                //Carreras = ...
                //Enfasis =
                //Cursos =

                //Grupos = ObtenerGrupos("", "", "", 255, "") //,

                //Formularios =

                //Asignaciones =
            };*/
            var modelo = new AsignarFormulariosModel { Cursos = cursos };
            return View(modelo);
        }

        // ### Métodos utilizados en el constructor ###
        // Ejemplo: 
        /* public IEnumerable<SelectListItem> ObtenerCiclos()
        {
            // Calcular u obtener los valores por mostrar
            return new List<SelectListItem>() { };
        } */
        // Los parámetros pueden ser usados para especificar qué elementos se deben enlistar.

        /// <summary>
        /// Retorna la lista de grupos de cursos que se mostrarán.
        /// </summary>
        /// <param name="ciclo">Ciclo en los que se imparten los grupos.</param>
        /// <param name="codigoUnidadAcadem">Código de la unidad academica a la que pertenecen los cursos de los grupos.</param>
        /// <param name="siglaCarrera">Sigla de la carrera en la que se encuentran los cursos de los grupos.</param>
        /// <param name="numEnfasis">Número del énfasis de la carrera en el que se encuentran los cursos de los grupos.</param>
        /// <param name="siglaCurso">Sigla del curso al que pertenecen los grupos</param>
        /// <returns>Lista de los grupos que satisfacen los filtros utilizados como parámetros.</returns>
        public IEnumerable<SelectListItem> ObtenerGrupos(String ciclo, String codigoUnidadAcadem, String siglaCarrera, byte? numEnfasis,
                                                         String siglaCurso)
        {
            return new List<SelectListItem>() { };
        }

        [HttpGet]
        public ActionResult Index()
        {
            Carrera carrera = db.Carrera.Find("SC-01234");

            var curso = from s in db.Curso
                           select s;
            ViewBag.Carreras = new SelectList(db.Carrera, "Sigla", "Nombre", carrera.CodigoUnidadAcademica);
            

            if (!String.IsNullOrEmpty(carrera.Sigla))
            {
                curso = curso.Where(s => s.CodigoUnidad.Equals(carrera.CodigoUnidadAcademica));
            }
            ViewBag.Cursos = new SelectList(curso, "Sigla", "Nombre", carrera.Unidad_Academica);
            return View();
        }
    }
}