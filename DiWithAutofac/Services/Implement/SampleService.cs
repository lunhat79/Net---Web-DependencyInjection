using DiWithAutofac.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiWithAutofac.Services.Implement
{
    public class SampleService : ISampleService
    {
        private readonly ISampleRepository _sampleRepository;

        public SampleService(ISampleRepository sampleRepository)
        {
            this._sampleRepository = sampleRepository;
        }

        public string getMessage()
        {
            return _sampleRepository.getMessage();
        }
    }
}