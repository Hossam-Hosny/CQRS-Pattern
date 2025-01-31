

using CQRS_Library.Data;
using CQRS_Library.Data.Models;
using CQRS_Library.Queries;
using MediatR;

namespace CQRS_Library.Handlers
{
    public class GetItemsListHandler : IRequestHandler<GetAllItemsQuery, List<Items>>
    {
        private readonly AppDbContext _db;
        public GetItemsListHandler(AppDbContext db)
        {
            _db = db;
        }



        public async Task<List<Items>> Handle(GetAllItemsQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_db.DBItems.ToList());
        }
    }
}
