using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCoreInAction.Core;
using EfCoreInAction.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EfCoreInAction.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;
        private readonly IRepository _repository;

        public BooksController(ILogger<BooksController> logger, IRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Book> Get() => _repository.ListAll();
    }
}