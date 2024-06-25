using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nowadays.Models;

public class Employee
{

    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int employeeId { get; set; }
    [Required]
    public string? employeeName { get; set; }
    public int companyID { get; set; }
    public int issueID { get; set; }
    public bool isActive { get; set; }

}