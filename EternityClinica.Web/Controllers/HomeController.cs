using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EternityClinica.Web.Models;
using EterniyClinica.Domain;

namespace EternityClinica.Web.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            return View();
        }

        public ActionResult Especialidades()
        {
            return View();
        }


        public ActionResult Parceiros()
        {
            return View();
        }

        public ActionResult Contato()
        {
            return View(new ContatoViewModel());
        }
        [HttpPost]
        public string Contato(ContatoViewModel model)
        {
            try
            {
                var email = new SendMail();
                var contato = new Contato
                {
                    Id = model.Id,
                    Nome = model.Nome,
                    Email = model.Email,
                    Assunto = model.Assunto,
                    Telefone = model.Telefone,
                    Comentario = model.Comentario
                };
                email.EnviarEmail(contato);
                email.EnviaEmailResponsavel(contato);
                return "ok";
            }

            catch
            {
                return "erro";
            }
        }
       

        public ActionResult Convenios()
        {
            return View();
        }

        public ActionResult Cursos()
        {
            return View();
        }
                    
        public ActionResult Fotos()
        {
            return View();
        }       
    }
}