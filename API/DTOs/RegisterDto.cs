using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    //data transfer object (DTO). A DTO is an object that defines how the data will be sent over the network.
    //right now, our web API exposes the database entities to the client. The client receives data that maps directly to your database tables.
    // However, that's not always a good idea. Sometimes you want to change the shape of the data that you send to client.
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}