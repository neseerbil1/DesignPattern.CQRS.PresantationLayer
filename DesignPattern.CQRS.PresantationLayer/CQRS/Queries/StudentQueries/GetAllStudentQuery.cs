using DesignPattern.CQRS.PresantationLayer.CQRS.Results.StudentResult;
using MediatR;
using System.Collections.Generic;

namespace DesignPattern.CQRS.PresantationLayer.CQRS.Queries.StudentQueries
{
    public class GetAllStudentQuery:IRequest<List<GetAllStudentQueryResult>>
    {
    }
}
