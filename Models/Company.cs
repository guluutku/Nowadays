using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nowadays.Models;

public class Company
{

    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int companyID { get; set; }
    public string? name { get; set; }
    public bool isActive { get; set; }

}
