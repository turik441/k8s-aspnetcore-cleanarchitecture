using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application.Responses
{
    public class HealthResponse
    {
        private static readonly string s_AssemblyVersion = Assembly.GetEntryAssembly()?.GetName().Version.ToString();
        public HealthResponse()
        {
            AssemblyVersion = s_AssemblyVersion;
        }

        public string Message { get; set; }
        public string AssemblyVersion { get; }
    }
}
