namespace angular_dotnet_example.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string DateOfBirth { get; set; }
        public string Occupation { get; set; }
        public decimal DeathSumInsured { get; set; }
        
        public decimal MonthlyPremium{ get; set; }
    }
}