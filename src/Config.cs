﻿using System.Collections.Generic;
using IdentityServer4.Models;
using LtiAdvantageLibrary.NetCore;

namespace AdvantagePlatform
{
    public class Config
    {
        // scopes define the resources in your system
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource(Constants.LtiScopes.MembershipReadonly, "Membership.Readonly"),
                new ApiResource(Constants.LtiScopes.AssignmentGradesLineItem, "LineItem"),
                new ApiResource(Constants.LtiScopes.AssignmentGradesResultReadonly, "Result.Readonly")
            };
        }
    }
}