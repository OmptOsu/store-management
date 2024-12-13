using StoreManagement.Application.Common.Interfaces.Services;

namespace StoreManagement.Infrastructure.Services;

public class DateTimeProvider: IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}