using System;
using TicketSystem.Domain.Users;

namespace TicketSystem.Api.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int TypeId { get; set; }
    }

    public static class UserModelExtensions
    {
        public static UserModel ToModel(this User domain)
        {
            return new UserModel
            {
                Name = domain.Name,
                Type = domain.Type.GetDescription(),
                TypeId = (int)domain.Type
            };
        }
    }
}