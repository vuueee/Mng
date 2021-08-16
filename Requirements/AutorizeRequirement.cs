using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Mng.Models;
using Microsoft.AspNetCore.Authorization;
using Mng.Data;
using Microsoft.AspNetCore.Identity;

namespace Mng.Requirements
{
    public class MemberHandler : AuthorizationHandler<AutorizeMemberRequirement, Group>
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<AppUser> _userManager;
        public MemberHandler(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context,
            AutorizeMemberRequirement requirement, Group gr)
        {
            if (gr == null) context.Fail();
            else
            {
                AppUser appUser = await _userManager.GetUserAsync(context.User);
                _context.Entry(gr).Collection(g => g.GroupMembers).Load();
                if (await _userManager.IsInRoleAsync(appUser, "admin") || gr.GroupMembers.FirstOrDefault(gm => gm.AppUserId == appUser.Id && gm.GroupId == gr.Id) != null)
                {
                    context.Succeed(requirement);
                }
            }
            return;// Task.CompletedTask;
        }
    }
    public class AutorizeMemberRequirement : IAuthorizationRequirement
    {

    }

}