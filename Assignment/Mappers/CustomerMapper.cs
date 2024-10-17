using Assignment.Dto;
using Assignment.Models;

namespace Assignment.Mappers;

public static class CustomerMapper
{
    public static CustomerDto ToDto(this Customer customer)
    {
        return new CustomerDto()
        {
            Id = customer.Id,
            LoginAccount = customer.LoginAccount,
            Email = customer.Email,
            Phone = customer.Phone,
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            Topic = customer.Topic,
        };
    }
}