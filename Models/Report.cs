using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nowadays.Models;

public class Report
{

    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int reportIDd { get; set; }
    [Required]
    public string? reportName { get; set; }
    public bool isActive { get; set; }

}