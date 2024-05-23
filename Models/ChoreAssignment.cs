using Microsoft.AspNetCore.Identity;

namespace HouseRules.Models;

public class ChoreAssignment
{
    public int Id { get; set; }
    public int UserProfileId { get; set; }
    public int ChoreId { get; set; }
}