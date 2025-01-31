
using CQRS_Library.Commands;
using CQRS_Library.Data;
using CQRS_Library.Data.Models;
using MediatR;

namespace CQRS_Library.Handlers
{
    public class InsertItemHandler : IRequestHandler<InsertItemCommands, Items>
    {
        private readonly AppDbContext _db;
        public InsertItemHandler(AppDbContext db)
        {
            _db = db;
        }


        public async Task<Items> Handle(InsertItemCommands request, CancellationToken cancellationToken)
        {
           await _db.DBItems.AddAsync(request.item);
            _db.SaveChanges();

            //  return await Task.FromResult(request.item);
            return request.item;
        }
    }
}
