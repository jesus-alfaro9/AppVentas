using AppVentasNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppVentasNet.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        [HttpGet]
        public ActionResult Index()
        {
            MantenimientoCliente ocli = new MantenimientoCliente();
            
            return View(ocli.Lista());
        }
        public ActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registrar(FormCollection collection)
        {
            MantenimientoCliente ocli = new MantenimientoCliente();
            Cliente ocliente = new Cliente()
        {
            IdCliente=collection["ID"],
            NombreCompañia=collection["Nombre"],
            Direccion=collection["Direccion"],
            Ciudad=collection["Ciudad"],
            País=collection["Pais"],
            Telefono=collection["Telefono"]
        };
            if (!ocli.Registrar(ocliente))
            {
                return RedirectToAction("#");
            }
            return RedirectToAction("Index");
        }
    }
}