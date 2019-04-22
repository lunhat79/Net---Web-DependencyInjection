using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiWithAutofac.Repositories.Implement
{
    public class SampleRepository : ISampleRepository
    {
        public string getMessage()
        {
            return "Hello There";
        }
    }
}