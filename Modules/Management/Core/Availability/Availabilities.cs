using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.Availability;

public class Availabilities
{
    [Key]
    [Map("id")]
    public int Id { get; set; }
    [Map("availabilityDescription")]
    public string? AvailabilityDescription { get; set; }
}

