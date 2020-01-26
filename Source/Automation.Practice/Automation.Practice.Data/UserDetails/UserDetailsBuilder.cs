using FizzWare.NBuilder;

namespace Automation.Practice.Data.UserDetails
{
    public static class UserDetailsBuilder
    {
        public static UserDetails CreateNew()
        {
            return new Builder()
                .CreateNew<UserDetails>()
                .With(x => x.Address = CreateNewAddress())
                .With(x => x.FirstName = Faker.NameFaker.FirstName())
                .With(x => x.LastName = Faker.NameFaker.LastName())
                .With(x => x.Password = $"{Faker.CompanyFaker.Name()}{Faker.NumberFaker.Number()}")
                .With(x => x.Email = $"{Faker.NumberFaker.Number()}{Faker.InternetFaker.Email()}")
                .With(x => x.PhoneNumber = Faker.PhoneFaker.Phone())
                .Build();
        }

        public static UserAddress CreateNewAddress()
        {
            return new Builder()
                .CreateNew<UserAddress>()
                .With(x => x.AddressLine1 = Faker.LocationFaker.Street())
                .With(x => x.AddressLine2 = Faker.LocationFaker.StreetName())
                .With(x => x.City = Faker.LocationFaker.City())
                .With(x => x.Country = "United States")
                .With(x => x.County = "Alaska")
                .With(x => x.PostCode = Faker.LocationFaker.ZipCode())
                .Build();
        }
    }
}
