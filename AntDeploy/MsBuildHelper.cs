using Microsoft.Build.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzd.AntDeploy
{
    public class MsBuildHelper
    {
        public  string GetMsBuildPath()
        {
            try
            {
                var getmS = ToolLocationHelper.GetPathToBuildTools(ToolLocationHelper.CurrentToolsVersion);
                return getmS;
            }
            catch (Exception e)
            {
                return string.Empty;
            }
        }
    }
}
