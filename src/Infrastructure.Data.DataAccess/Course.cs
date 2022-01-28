using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimatLabs.Infrastructure.Data.DataSetup.Development;
/// <summary>
/// Class representing the courses
/// </summary>
public class Course
{
    /// <summary>
    /// Guid to identify the course
    /// </summary>
    /// <example>6A898F5A-F0DE-47DB-838A-51455C025A35</example>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid CourseId { get; set; }

    /// <summary>
    /// Title for the course
    /// </summary>
    /// <example>Advanced Magic Potions</example>
    [Required]
    [MaxLength(100)]
    public string Title { get; set; }

    /// <summary>
    /// Credits for the course
    /// </summary>
    /// <example>5</example>
    [Required]
    [Range(0, 5)]
    public int Credits { get; set; }

    /// <summary>
    /// Current Year in which the student is studying
    /// </summary>
    /// <example>2</example>
    [Range(1, 7)]
    public int Year { get; set; }

    /// <summary>
    /// The list of enrollments associated with the student
    /// </summary>
    public virtual ICollection<Enrollment> Enrollments { get; set; }
}