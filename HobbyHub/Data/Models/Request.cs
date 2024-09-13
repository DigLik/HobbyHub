using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HobbyHub.Data.Models
{
    [Table("Requests")]
    public class Request
    {
        [Key]
        public int RequestId { get; set; }
        public long Sender { get; set; }
        public long Recipient { get; set; }
        public string? Message { get; set; }
    }
}
