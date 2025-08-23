using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoAirOperation
{
    /// <summary>
    /// Interface defining operations for the ContosoAir Home Page.
    /// </summary>
    public interface IHomePage
    {
        void NavigateToHomePage();
        string GetPageTitle();
    }
}
