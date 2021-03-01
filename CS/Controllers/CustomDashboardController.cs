using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardWeb;
using Microsoft.AspNetCore.Authorization;

namespace AspNetCore31Dashboard.Controllers {
    [Authorize]
    public class CustomDashboardController : DashboardController {
        public CustomDashboardController(DashboardConfigurator configurator)
            : base(configurator) {

        }
    }
}