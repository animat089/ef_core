using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Data;
/// <summary>
/// Class representing a student
/// </summary>
public class Student
{
    /// <summary>
    /// Guid to identify the student
    /// </summary>
    /// <example>6A898F5A-F0DE-47DB-838A-51455C025A24</example>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid StudentId { get; set; }

    /// <summary>
    /// First name for the student
    /// </summary>
    /// <example>John</example>
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }

    /// <summary>
    /// Last name for the student
    /// </summary>
    /// <example>Doe</example>
    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }

    /// <summary>
    /// House associated with the student
    /// </summary>
    /// <example>Gryffindor</example>
    public House? House { get; set; }

    /// <summary>
    /// Current Year in which the student is studying
    /// </summary>
    /// <example>2</example>
    [Required]
    [Range(1, 7)]
    public int Year { get; set; }

    /// <summary>
    /// The list of enrollments associated with the student
    /// </summary>
    public virtual ICollection<Enrollment> Enrollments { get; set; }
}