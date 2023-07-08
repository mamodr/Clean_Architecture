using Eshop.Application.Common.Exceptions;
using Eshop.Application.Common.Interfaces;
using Eshop.Domain.Entities;
using Eshop.Domain.ValueObjects;
using MediatR;

namespace Eshop.Application.Customers.Commands.UpdateCustomer;
public record UpdateCustomerCommand : IRequest
{
    public string CustomerId { get; init; }

    public String? Street { get; init ; }
    public String? City { get; init; }
    public String? ZipCode { get; init; }


    public string Phone { get; init; }

}

public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand>
{
    private readonly IApplicationDbContext _context;

    public UpdateCustomerCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.Customers
            .FindAsync(new object[] { request.CustomerId }, cancellationToken);

        if (entity == null)
        {
            throw new NotFoundException(nameof(Customer), request.CustomerId);
        }

        var address = new Address(request.Street, request.City, request.ZipCode);

         entity.Address=address;
        entity.Phone= request.Phone;

        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
