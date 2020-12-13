using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Constants
{
    public class ProjectsControllerRoute
    {
        public const string GetProject = ControllerName.Projects + nameof(GetProject);
        public const string PostProject = ControllerName.Projects + nameof(PostProject);
    }
}
