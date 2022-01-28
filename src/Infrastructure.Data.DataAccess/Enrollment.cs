using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimatLabs.Infrastructure.Data.DataAccess;
/// <summary>
/// Class representing the enrollments
/// </summary>
public class Enrollment
{
    /// <summary>
    /// Guid to identify the enrollment
    /// </summary>
    /// <example>6A898F5A-F0DE-47DB-838A-51455C025A36</example>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid EnrollmentId { get; set; }

    /// <summary>
    /// Guid to identify the course
    /// </summary>
    /// <example>6A898F5A-F0DE-47DB-838A-51455C025A35</example>
    public Guid CourseId { get; set; }
    
    /// <summary>
    /// Guid to identify the student
    /// </summary>
    /// <example>6A898F5A-F0DE-47DB-838A-51455C025A34</example>
    public Guid StudentId { get; set; }
    
    /// <summary>
    /// Grade associated with the course
    /// </summary>
    /// <example>6A898F5A-F0DE-47DB-838A-51455C025A36</example>
    public Grade? Grade { get; set; }
    
    /// <summary>
    /// Course associated with the enrollment
    /// </summary>
    public virtual Course Course { get; set; }

    /// <summary>
    /// Student associated with the enrollment
    /// </summary>
    public virtual Student Student { get; set; }
}