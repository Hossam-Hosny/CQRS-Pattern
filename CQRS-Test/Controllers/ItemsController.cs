using CQRS_Library.Commands;
using CQRS_Library.Data.Models;
using CQRS_Library.Handlers;
using CQRS_Library.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryContracts;

namespace CQRS_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItems _iItems;
        private readonly IMediator _mediator;
        public ItemsController(IItems items , IMediator mediator)
        {
            _iItems = items;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // return Ok( _iItems.GetItems());
            var result = await _mediator.Send(new GetAllItemsQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task <IActionResult> InsertItem(Items item)
        {
            //_iItems.InsertItem(item);
            //return Ok(item);

            var result =await _mediator.Send(new InsertItemCommands(item));
            return Ok(result);

        }







    }
}
