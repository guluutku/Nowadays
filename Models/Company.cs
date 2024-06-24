using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nowadays.Models;

public class Company
{

    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? id { get; set; }
    
}
