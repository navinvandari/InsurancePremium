using System;
using System.Collections.Generic;

namespace angular_dotnet_example.Models
{
    public interface IUserRepository
    {
        IEnumerable<UserModel> GetAll();

        IEnumerable<OccupationRating> GetAllOccupation();

        IEnumerable<RatingFactor> GetRatingFactor();

        UserModel Add(UserModel user);
    }
}