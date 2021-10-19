using System.Reflection;

namespace Application.Responses.Health
{
    public class GetHealthResponse
    {
        private static readonly string s_AssemblyVersion = Assembly.GetEntryAssembly()?.GetName().Version.ToString();
        public GetHealthResponse()
        {
            AssemblyVersion = s_AssemblyVersion;
        }

        public string Message { get; set; }
        public string AssemblyVersion { get; }
    }
}
