using System;

namespace angular_dotnet_example.Models
{
    public class RatingFactor
    {   
        public string Rating { get; set; }
        public double Factor { get; set;}

        public static explicit operator decimal(RatingFactor v)
        {
            throw new NotImplementedException();
        }
    }
}
