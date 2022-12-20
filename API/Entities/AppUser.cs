

using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace API.Entities
{
    public class AppUser
    {
        //entity knows that Id=Primary key otherwise we need to set [Key]
        public int Id { get; set; }

        //when use **?** make it optional 
        [Required]
        public string UserName { get; set; }



        //technique to protect passwords stored in databases by adding a string of 32 or more characters and then hashing them
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }

        //every time we add property to out entity we need to tell out DB to add Columns
        //we need to create new migration >> stop the API>>dotnet ef migrations add *name* (UserPasswordAdded)
        //then we need to update the DB >> dotnet ef database update

    }
}