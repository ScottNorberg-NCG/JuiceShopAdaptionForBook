﻿using System.ComponentModel.DataAnnotations.Schema;

namespace JuiceShopDotNet.Safe.Data;

public class JuiceShopUser
{
    public int JuiceShopUserID { get; set; }
    public Guid PublicIdentifier { get; set; }
    public string UserName { get; set; } = null!;
    public string UserEmail { get; set; } = null!;
    public string NormalizedUserName { get; set; }
    public string NormalizedUserEmail { get; set; }
    public bool UserEmailConfirmed { get; set; }
    public string PasswordHash { get; set; } = null!;
    public string? SecurityStamp { get; set; }
    public string? ConcurrencyStamp { get; set; }
}
