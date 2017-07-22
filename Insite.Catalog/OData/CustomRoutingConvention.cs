using System;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.OData.Routing.Conventions;
using Microsoft.AspNetCore.Routing;

namespace Insite.Catalog.OData
{
	public class CustomRoutingConvention : IODataRoutingConvention
	{
		public ActionDescriptor SelectAction(RouteContext routeContext)
		{
			return null;
		}
	}
}
