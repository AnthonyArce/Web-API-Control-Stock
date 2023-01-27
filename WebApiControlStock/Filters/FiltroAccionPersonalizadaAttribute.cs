using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace WebApiControlStock.Filters
{
    public class FiltroAccionPersonalizadaAttribute : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Do something after the action executes.
            Debug.WriteLine("Se ejecuto el filtro de acción OnActionExecuted - ocurre despues de ejecutar action");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            // Do something before the action executes.
            Debug.WriteLine("Se ejecuto el filtro de acción OnActionExecuted - ocurre antes de ejecutar action");
        }
    }
}
