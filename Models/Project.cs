using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nowadays.Models
{
    public class Project
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectID { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Proje adı girilmeli")]
        public string? ProjectName { get; set; }

    }
}