using Eshop.Application.Common.Interfaces;
using Eshop.Domain.Entities;
using Eshop.Domain.ValueObjects;

using Eshop.Domain.Events;
using MediatR;

namespace Eshop.Application.Customers.Commands.CreateCustomer;
public record CreateCustomerCommand : IRequest<int>
{
    public string CustomerId { get; init; }

    public String Street { get; private set; }
    public String City { get; private set; }
    public String ZipCode { get; private set; }


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

        var address = new Address(request.Street, request.City, request.ZipCode);
        var entity = new Customer
        {
           CustomerId=request.CustomerId,
            Address=address,
            Phone=request.Phone,

        };

        //entity.AddDomainEvent(new CustomerCreatedEvent(entity));

        _context.Customers.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}
