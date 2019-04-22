using DiWithAutofac.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DiWithAutofac.Controllers
{
    public class SampleController : ApiController
    {
        private readonly ISampleService _service;

        public SampleController(ISampleService service)
        {
            _service = service;
        }

        // GET api/<controller>
        public string Get()
        {
            return _service.getMessage();
        }

        
    }
}