using System.ComponentModel.DataAnnotations;

namespace BlaiseFileUploadAlien.Models;

public class FileDeletionDto
{
    [Required]
    public string Filename { get; set; } = string.Empty;
}