

using CQRS_Library.Data.Models;
using MediatR;

namespace CQRS_Library.Queries
{
    public record GetAllItemsQuery:IRequest<List<Items>>;
    
}
