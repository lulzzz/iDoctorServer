﻿using Hangfire.Dashboard;

namespace AN.Web.Infrastructure
{
    public class MyHangFireAuthorizationFilter : IDashboardAuthorizationFilter
    {
        public bool Authorize(DashboardContext context)
        {
            // var httpContext = context.GetHttpContext();

            // Allow all authenticated users to see the Dashboard (potentially dangerous).
            // return httpContext.User.Identity.IsAuthenticated;

            return true;
        }
    }
}
