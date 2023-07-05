using Eshop.Application.Common.Interfaces;

namespace Eshop.Infrastructure.Services;
public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
