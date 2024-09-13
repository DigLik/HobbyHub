using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HobbyHub.Data.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }

        public List<MediaUri> MediaUris { get; set; }
        public List<Request> Requests { get; set; }
    }
}
