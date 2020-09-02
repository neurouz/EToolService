using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EToolService.WebAPI.Exceptions;
using EToolService.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EToolService.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IFileService _service;
        public FileController(IFileService service)
        {
            _service = service;
        }

        [HttpGet("Download/Services/{filename}")]
        public async Task<IActionResult> DownloadFiles(string filename)
        {
            var directory = Path.Combine(Directory.GetCurrentDirectory(), "Data", "ServiceAttachments", $"{filename}");

            try
            {
                var bytes = await System.IO.File.ReadAllBytesAsync(directory);
                return File(bytes, "application/octet-stream", filename);
            }
            catch (Exception)
            {
                throw new UserException("Fajl ne postoji ili je obrisan");
            }
        }
    }
}