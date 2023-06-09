﻿using Domain.AuditableEntity;
using Microsoft.AspNetCore.Identity;

namespace Domain.Identity
{
    /// <summary>
    /// More info: http://www.dotnettips.info/post/2577
    /// and http://www.dotnettips.info/post/2578
    /// </summary>
    public class UserClaim : IdentityUserClaim<int>, IAuditableEntity
    {
        public virtual User User { get; set; }
        public int? ModifiedByUserId { get; set; }

    }

}