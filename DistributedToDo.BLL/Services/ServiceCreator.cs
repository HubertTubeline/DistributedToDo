﻿using DistributedToDo.BLL.Interfaces;
using DistributedToDo.DAL.Repositories;

namespace DistributedToDo.BLL.Services
{
    public class ServiceCreator : IServiceCreator
    {
        public IUserService CreateUserService(string connection)
        {
            return new UserService(new IdentityUnitOfWork(connection));
        }
    }
}