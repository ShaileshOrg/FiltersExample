using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FiltersExample.Filters
{
    public class ActionFilter :Attribute, IActionFilter
    {
        

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"[Action Filter] Action filter executing...");
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"[Action Filter] Action filter executed");
        }
    }
}
