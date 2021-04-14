using DellCustomerService.Audit;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DellCustomerService.AuditMiddleWare
{
    public static class AuditLogingMiddlewareExtensions
    {
        public static IApplicationBuilder UseAuditUserRequest(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestLoggingMiddleware>();
        }
    }
}
