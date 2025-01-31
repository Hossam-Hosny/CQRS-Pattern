
using CQRS_Library.Data.Models;
using MediatR;

namespace CQRS_Library.Commands
{
    public record InsertItemCommands(Items item):IRequest<Items>;
   
}
