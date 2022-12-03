using DesignPattern.CQRS.PresantationLayer.CQRS.Queries;
using DesignPattern.CQRS.PresantationLayer.CQRS.Results;
using DesignPattern.CQRS.PresantationLayer.DAL.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.CQRS.PresantationLayer.CQRS.Handlers
{
    public class GetProductProducerQueryHandler
    {
        private readonly Context _context;

        public GetProductProducerQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetProductProducerQueryResult> Handle(GetProductProducerQuery query)
        {
            var values = _context.Products.Select(x => new GetProductProducerQueryResult
            {
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                ProductStatus = x.ProductStatus,
                ProductStorage = x.ProductStorage
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
