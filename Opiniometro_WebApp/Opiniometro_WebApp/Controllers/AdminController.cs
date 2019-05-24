﻿using System;
using System.Data.Entity.Core.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Opiniometro_WebApp.Models;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Net;

namespace Opiniometro_WebApp.Controllers
{
    public class AdminController : Controller
    {
        private Opiniometro_DatosEntities db = new Opiniometro_DatosEntities();
        private const string caracteres_aleatorios = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public ActionResult VerPersonas()
        {

            return View();
        }

        public ActionResult CrearUsuario()
        {

            return View();
        }

        public ActionResult CrearUsuario(InfoPersonaUsuario info)
        {
            // Autogenero una contrasenna generica.
            string contrasenna_generada = GenerarContrasenna(10);

            ObjectParameter exito = new ObjectParameter("Resultado", 0);
            db.SP_AgregarPersonaUsuario(info.CorreoInstitucional, contrasenna_generada, info.Cedula, info.Nombre, info.PrimerApellido, info.SegundoApellido, info.Direccion);
            //EXEC SP_AgregarPersonaUsuario @Correo @Contrasenna @Cedula @Nombre @Apellido1 @Apellido2 @Direccion

            string contenido =
                     "<p>Se le ha creado un usuario en Opiniometro@UCR.</p>" +
                     "<p>A continuación, su contraseña temporal, ingrésela junto con su correo institucional:</p> <b>"
                     + contrasenna_generada + "</b>";

            // Envio correo con la contrasenna autogenerada
            EnviarCorreo(info.CorreoInstitucional, "Usuario creado - Opiniómetro@UCR", contenido);
            return View();
        }

        private void EnviarCorreo(string receptor, string asunto, string contenido)
        {
            string autor = System.Configuration.ConfigurationManager.AppSettings["CorreoEmisor"].ToString();
            string contrasenna = System.Configuration.ConfigurationManager.AppSettings["ContrasennaEmisor"].ToString();

            SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
            cliente.EnableSsl = true;
            cliente.Timeout = 100000;
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.UseDefaultCredentials = false;
            cliente.Credentials = new NetworkCredential(autor, contrasenna);

            MailMessage correo = new MailMessage(autor, receptor, asunto, contenido);
            correo.IsBodyHtml = true;
            correo.BodyEncoding = UTF8Encoding.UTF8;
            cliente.Send(correo);

        }

        /*
         * EFECTO:
         * REQUIERE:
         * MODIFICA:
         * 
         * Basado en: https://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings
         */
        private string GenerarContrasenna(int tamanno)
        {
            byte[] datos = new byte[tamanno];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(datos);
            }

            StringBuilder contrasenna = new StringBuilder(tamanno);

            foreach (byte byte_aleatorio in datos)
            {
                contrasenna.Append(caracteres_aleatorios[byte_aleatorio % (caracteres_aleatorios.Length)]);
            }
            return contrasenna.ToString();
        }
    }
}