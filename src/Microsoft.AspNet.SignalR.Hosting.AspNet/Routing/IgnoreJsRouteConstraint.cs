﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.md in the project root for license information.

using System;
using System.IO;
using System.Web;
using System.Web.Routing;

namespace Microsoft.AspNet.SignalR.Hosting.AspNet.Routing
{
    public class IgnoreJsRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (Path.GetExtension(httpContext.Request.AppRelativeCurrentExecutionFilePath).Equals(".js", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            return true;
        }
    }
}
