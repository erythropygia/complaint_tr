using Microsoft.AspNetCore.Identity;

namespace complaint_tr.Areas.Identity.Data;

public class User : IdentityUser
{
    [PersonalData]
    public string ? Name { get; set; }

    [PersonalData]
    public string ? Surname { get; set; }

}