

using DesignPattern.CQRS.PresantationLayer.CQRS.Queries;
using DesignPattern.CQRS.PresantationLayer.CQRS.Results;
using DesignPattern.CQRS.PresantationLayer.DAL.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.CQRS.PresantationLayer.CQRS.Handlers
{
    public class GetProductPlannerQueryHandler
    {
        private readonly Context _context;

        public GetProductPlannerQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetProductPlannerQueryResult> Handle(GetProductPlannerQuery query)
        {
            var values = _context.Products.Select(x => new GetProductPlannerQueryResult
            {
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                ProductMinStock = x.ProductMinStock,
                ProductMaxStock = x.ProductMaxStock,
                ProductStatus = x.ProductStatus
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
