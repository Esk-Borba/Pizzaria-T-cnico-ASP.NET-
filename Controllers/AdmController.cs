﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Sa_pro_chefe.Models;

namespace Sa_pro_chefe.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class AdmController : ApiController
    {
        // GET: api/Adm
        public IEnumerable<dynamic> Get()
        {
            using (pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                var administrador = from admin in bd.administrador
                                    select new{admin.id, admin.nome, admin.senha, admin.usuario, admin.tipo_usuario};
                return administrador.ToList();
                       
            }
        }

        // GET: api/Adm/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Adm
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Adm/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Adm/5
        public void Delete(int id)
        {
        }
    }
}
