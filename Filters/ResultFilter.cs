using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FiltersExample.Filters
{
    public class ResultFilter :Attribute, IResultFilter
    {
        

        public void OnResultExecuting(ResultExecutingContext context)
        {
            Console.WriteLine($"[Result Filter] Result filter executing...");
        }
        public void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine($"[Result Filter] Result filter executed");
            Console.WriteLine("User can change or format result");
        }
    }
}
