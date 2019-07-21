using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCVSite
{
    public static class AppState
    {
        public static bool HideSideBar
        {
            get
            {
                return SideBarItems == null || SideBarItems.Count == 0;
            }
        }
        public static List<string> SideBarItems = new List<string>();
    }
}
