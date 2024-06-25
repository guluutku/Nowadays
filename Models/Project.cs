using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nowadays.Models
{
    public class Project
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int projectID { get; set; }
        [Required]
        public string? ProjectName { get; set; }
        public List<int>? issueIDs { get; set; }
        public bool isActive { get; set; }

    }
}