﻿using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace BikeRentalAPI.Models;

[Table("UserInfo")]
public class UserInfo
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int? PhoneNumber { get; set; }
    public string? Gender { get; set; }
    public string UserId { get; set; }
    
    
}