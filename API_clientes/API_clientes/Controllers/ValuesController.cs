using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_clientes.Models;

namespace API_clientes.Controllers
{
    public class ValuesController : ApiController
    {
        Negocios2020Entities bd = new Negocios2020Entities();
        // GET api/values 
        //Lista clientes


        public IEnumerable<clientes> GetClientes()
        {
            return bd.clientes.ToList();
        }

        //Lista paises
        public IEnumerable<paises> GetPaises()
        {
            return bd.paises.ToList();
        }

        // GET api/values/5
        //Buscar cliente

        public clientes GetCliente(string id)
        {

            return bd.clientes.ToList().Where(c => c.IdCliente == id).FirstOrDefault();
        }

        // POST api/values
        //Agrega cliente

        public void Post(clientes reg)

        {
            try
            {
                clientes objC = new clientes()
                {
                    IdCliente = reg.IdCliente,
                    NomCliente = reg.NomCliente,
                    DirCliente = reg.DirCliente,
                    idpais = reg.idpais,
                    fonoCliente = reg.fonoCliente
                };
                bd.clientes.Add(objC);
                bd.SaveChanges();
            }
            catch (Exception){

            }
        }

        // PUT api/values/5
        //Actuializa cliente
        public void Put(clientes objC)

        {
            bd.Entry<clientes>(objC).State = System.Data.Entity.EntityState.Modified;
            bd.SaveChanges();
        }

        // DELETE api/values/5
        //Eliminar cliente
        public void Delete(string id)
        {
            clientes objC = GetCliente(id);
            bd.clientes.Remove(objC);
            bd.SaveChanges();

        }
    }
}
