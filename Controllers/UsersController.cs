﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace angular_dotnet_example.Controllers
{
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly ILogger<UsersController> _logger;

        static readonly Models.IUserRepository repository = new Models.UserRepository();

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("api/users")]
        public IEnumerable<Models.UserModel> GetAllUsers()
        {
            return repository.GetAll();
        }

        [HttpGet]
        [Route("api/occupation")]
        public IEnumerable<Models.OccupationRating> GetAllOccupation()
        {
            return repository.GetAllOccupation();
        }

        [HttpGet]
        [Route("api/factor")]
        public IEnumerable<Models.RatingFactor> GetRatingFactor()
        {
            return repository.GetRatingFactor();
        }

        [HttpPost]
        [Route("api/user")]
        [Consumes("application/json")]
        public Models.UserModel PostUser(Models.UserModel item)
        {
            return repository.Add(item);
        }
        

    }
}
