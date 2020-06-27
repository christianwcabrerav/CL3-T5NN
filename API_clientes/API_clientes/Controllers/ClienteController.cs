using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using API_clientes.Models;

namespace API_clientes.Controllers
{
    public class ClienteController : Controller
    {
        //
        ValuesController bd = new ValuesController();

        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult listadoClientes()
        {
            return View(bd.GetClientes());
        }

        public ActionResult agregaCliente()
        {
            ViewBag.pais = new SelectList(bd.GetPaises(),"Idpais","NombrePais");
            return View(new clientes());
        }
        [HttpPost]
        public ActionResult agregaCliente(clientes objC)

        {
            if (!ModelState.IsValid)
            {
                return View(objC);
            }
            bd.Post(objC);
            return RedirectToAction("listadoClientes");
        }

        public ActionResult modificaCliente(string id)
        {
            clientes objC = bd.GetCliente(id);
            ViewBag.pais = new SelectList(bd.GetPaises(), "Idpais", "NombrePais", objC.idpais);
            return View(objC);
        }
        [HttpPost]
        public ActionResult modificaCliente(clientes objC)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.pais = new SelectList(bd.GetPaises(), "Idpais", "NombrePais", objC.idpais);
                return View(objC);
            }
            bd.Put(objC);
            return RedirectToAction("listadoClientes");
        }
        public ActionResult eliminaCliente(string id)
        {
            bd.Delete(id);
            return RedirectToAction("listadoClientes");
        }
    }
}