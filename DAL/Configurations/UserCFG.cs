using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    internal class UserCFG : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(50);
            builder.Property(x => x.UserName).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.Password).HasMaxLength(200);
            builder.Ignore(x => x.Age);
            builder.Property(x => x.ImagePath).HasMaxLength(300);
            builder.Property(x => x.Height).HasPrecision(3, 2);
            builder.Property(x => x.BasalMetabolicRate).HasPrecision(4, 1);

           
               builder.HasData(
               new User
               {
                   UserID = 1,
                   FirstName = "İrem",
                   UserName = "iremilgin@gmail.com",
                   Height = Convert.ToDouble(1.60),
                   Weight = 50,
                   Gender = Entities.Enums.Gender.Female,
                   BirthDate = DateTime.ParseExact("07/07/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   Activity = Entities.Enums.Activity.LotsOfExercise,
                   GoalWeight = 48,
                   Password = "123",
               },

                 new User
                 {
                     UserID = 2,
                     FirstName = "İlbey",
                     UserName = "ilbeyikiz@gmail.com",
                     Height = Convert.ToDouble(1.80),
                     Weight = 86,
                     Gender = Entities.Enums.Gender.Male,
                     BirthDate = DateTime.ParseExact("15/06/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                     Activity = Entities.Enums.Activity.LessExercise,
                     GoalWeight = 80,
                     Password = "1234"
                 },

                 new User
                 {
                     UserID=3,
                     FirstName="Yunus",
                     UserName="yunuskilic@gmail.com",
                     Height=Convert.ToDouble(1.77),
                     Weight=78,
                     Gender=Entities.Enums.Gender.Male,
                     BirthDate=DateTime.ParseExact("26/11/1992","dd/MM/yyyy",CultureInfo.InvariantCulture),
                     Activity=Entities.Enums.Activity.LessExercise,
                     GoalWeight=75,
                     Password="1206"


                 }

                 );

        }
    } 
}
