using Eshop.Application.Common.Interfaces;
using Eshop.Domain.Entities;
using Eshop.Domain.ValueObjects;

using Eshop.Domain.Events;
using MediatR;

namespace Eshop.Application.Customers.Commands.CreateCustomer;
public record CreateCustomerCommand : IRequest<int>
{
    public string CustomerId { get; init; }

    public Address Address { get; init; }


    public string Phone { get; init; }

}

public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateCustomerCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        var entity = new Customer
        {
           CustomerId=request.CustomerId,
            Address=request.Address,
            Phone=request.Phone,

        };

        //entity.AddDomainEvent(new CustomerCreatedEvent(entity));

        _context.Customers.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}
