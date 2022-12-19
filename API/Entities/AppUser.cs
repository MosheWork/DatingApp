

namespace API.Entities
{
    public class AppUser
    {
        //entity knows that Id=Primary key otherwise we need to set [Key]
        public int Id { get; set; }

        //when use **?** make it optional 
        public string UserName { get; set; }  

        

    }
}