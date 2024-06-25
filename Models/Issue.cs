using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nowadays.Models;

public class Issue
{

    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int issueID { get; set; }
    [Required]
    public string? issueName { get; set; }
    public bool isActive { get; set; }

}