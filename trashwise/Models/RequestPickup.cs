using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace trashwise.Models;

public class RequestPickup
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string FullName { get; set; }

    [Required]
    [StringLength(200)]
    public string Address { get; set; }

    [Required]
    [Phone]
    public string PhoneNumber { get; set; }

    [Required]
    public WasteType WasteCategory { get; set; }  // Enum for predefined waste types

    [Required]
    public DateTime PreferredPickupDate { get; set; }

    [StringLength(500)]
    public string AdditionalNotes { get; set; }

    public DateTime RequestDate { get; set; } = DateTime.UtcNow; // Auto-set the request date
}

public enum WasteType
{
    Paper,
    Plastic,
    Glass,
    Metal,
    Organic,
    Electronics
}