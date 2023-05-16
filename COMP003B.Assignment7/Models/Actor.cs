using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment7.Models
{
    public class Actor
    {
        [Required]
        public int ActorId
        { get; set; }

        [Required]
        public string ActorName
        { get; set; }

        [Required]
        public string ActorGender
        { get; set; }

        public int ActorAge { get; set; }
    }
}
