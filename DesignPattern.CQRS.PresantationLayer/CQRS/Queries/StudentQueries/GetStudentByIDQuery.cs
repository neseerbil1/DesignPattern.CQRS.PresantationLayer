using DesignPattern.CQRS.PresantationLayer.CQRS.Results.StudentResult;
using MediatR;

namespace DesignPattern.CQRS.PresantationLayer.CQRS.Queries.StudentQueries
{
    public class GetStudentByIDQuery:IRequest<GetStudentByIDQueryResult>
    {
        public GetStudentByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; } 
    }
}
