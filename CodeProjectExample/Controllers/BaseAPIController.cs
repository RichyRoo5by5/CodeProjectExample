﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CodeProjectExample.DBContext;
using Newtonsoft.Json;
using System.Text;

namespace CodeProjectExample.Controllers
{
    public class BaseAPIController : ApiController
    {

        protected readonly UserDBEntities UserDB = new UserDBEntities();
        protected HttpResponseMessage ToJson(dynamic obj)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            return response;
        }
    }
}
