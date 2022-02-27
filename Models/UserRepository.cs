using System;
using System.Collections.Generic;

namespace angular_dotnet_example.Models
{
    public class UserRepository : IUserRepository
    {
        //private List<UserModel> users = new List<UserModel>();
        private List<UserModel> users = new List<UserModel>();
        private List<OccupationRating> occupationRatings = new List<OccupationRating>();
        private List<RatingFactor> ratingFactors = new List<RatingFactor>();

        private int _nextId = 1;

        public UserRepository()
        {
            //Add(new UserModel { Name = "first1_last1", Age = 56, DateOfBirth = "12-08-1968", DeathSumInsured = 78000, Occupation = "Clearner",MonthlyPremium = 123 });
            //Add(new UserModel { Name = "first2_last2", Age = 63, DateOfBirth = "12-08-1960", DeathSumInsured = 178000, Occupation = "Doctor", MonthlyPremium = 156 });
            //Add(new UserModel { Name = "first3_last3", Age = 12, DateOfBirth = "12-08-1963", DeathSumInsured = 278000, Occupation = "Author", MonthlyPremium = 187 });

            occupationRatings.Add(new OccupationRating { Occupation = "Cleaner",  Rating = "Light Manual"});
            occupationRatings.Add(new OccupationRating { Occupation = "Doctor",   Rating = "Professional" });
            occupationRatings.Add(new OccupationRating { Occupation = "Author",   Rating = "White Collar" });
            occupationRatings.Add(new OccupationRating { Occupation = "Farmer",   Rating = "Heavy Manual" });
            occupationRatings.Add(new OccupationRating { Occupation = "Mechanic", Rating = "Heavy Manual" });
            occupationRatings.Add(new OccupationRating { Occupation = "Florist",  Rating = "Light Manual" });

            ratingFactors.Add(new RatingFactor { Rating = "Light Manual", Factor = 1.0});
            ratingFactors.Add(new RatingFactor { Rating = "Professional", Factor= 1.25});
            ratingFactors.Add(new RatingFactor { Rating = "White Collar", Factor= 1.50});
            ratingFactors.Add(new RatingFactor { Rating = "Heavy Manual", Factor= 1.75});
        }

        public IEnumerable<UserModel> GetAll()
        {
            return users;
        }

        public IEnumerable<OccupationRating> GetAllOccupation()
        {
            return occupationRatings;
        }

        public UserModel Add(UserModel item)
        {
            users.Clear();
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            var rating = occupationRatings.Find(x => x.Occupation.Contains(item.Occupation));            
            var factor = rating==null? 0 : (decimal)ratingFactors.Find(x => x.Rating.Contains(rating.Rating)).Factor;
            item.MonthlyPremium = (item.DeathSumInsured                          
                                   * factor
                                  * item.Age)
                                  / 1000
                                  * 12;
            users.Add(item);

            return item;
        }

        
    }
}