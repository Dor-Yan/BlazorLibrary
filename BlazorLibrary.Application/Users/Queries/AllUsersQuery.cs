using BlazorLibrary.Application.Common.Interfaces;
using BlazorLibrary.Domain.Enities;
using BlazorLibrary.Shared.Users.Queries.AllUsersQuery;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorLibrary.Application.Users.Queries
{
    public class AllUsersQuery : IRequest<List<UserForListVm>>
    {
    }

    public class AllUsersQueryHandler : IRequestHandler<AllUsersQuery, List<UserForListVm>>
    {
        public readonly IBlazorLibraryDbContext _context;

        public AllUsersQueryHandler(IBlazorLibraryDbContext context)
        {
            _context = context;
        }
        public async Task<List<UserForListVm>> Handle(AllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _context.Users.ToListAsync();
            return MapUsersToVm(users);
        }

        private List<UserForListVm> MapUsersToVm(List<User> users)
        {
            var result = new List<UserForListVm>();
            foreach (var user in users)
            {
                var userVm = new UserForListVm()
                {
                    Name = user.Name,
                    PhoneNumber = user.PhoneNumber,
                    EmailAdress = user.EmailAdress,
                    CreateDate = user.Created,
                    StatusId = user.StatusId,
                    Id = user.Id,
                };
                result.Add(userVm);
            }
            return result;
        }
    }
}
