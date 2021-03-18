using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltersExample.Filters
{
    public class ResourceFilter : Attribute, IResourceFilter
    {
        

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine($"[Resource Filter] Resource filter executing....");
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine($"[Resource Filter] Resource filter executed");
        }
    }
}
