namespace EncyclopediaGalactica.SourceFormats.Rest.Service.Controllers.V1
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using EncyclopediaGalactica.SourceFormats.Rest.Service.DomainObjects;
    using Microsoft.AspNetCore.JsonPatch;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("/v1")]
    [Produces("application/json")]
    public class SourceFormatController : ControllerBase
    {
        [HttpGet("{id}")]
        [Route("/sourceformat")]
        
        public async Task<ActionResult<SourceFormat>> GetAsync(long id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("/sourceformat")]
        public async Task<ActionResult<SourceFormat>> PostAsync()
        {
            throw new NotImplementedException();
        }

        [HttpPatch("{id}")]
        [Route("/sourceformat")]
        public async Task<ActionResult<SourceFormat>> PatchAsync([FromBody] JsonPatchDocument<SourceFormat> patch)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        [Route("/sourceformat")]
        public async Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{offset}/{limit}")]
        [Route("/sourceformats")]
        public async Task<ActionResult<List<SourceFormat>>> GetSourceFormatsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
