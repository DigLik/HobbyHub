using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HobbyHub.Data.Models
{
    [Table("MediaUris")]
    public class MediaUri
    {
        [Key]
        public int MediaId { get; set; }
        public int Owner { get; set; }
        [Required]
        public string Uri { get; set; }
    }
}
