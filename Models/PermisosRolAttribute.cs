using Microsoft.AspNetCore.Mvc.Filters;
using System.Web;
using Aduanas.Models;

namespace Aduanas.Models
{
    public class PermisosRolAttribute : ActionFilterAttribute
    {
        private Rol idrol;

        public PermisosRolAttribute(Rol _idrol)
        {
            idrol = _idrol;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {

            base.OnActionExecuting(context);
        }

    }
}
