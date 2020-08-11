using System.Reflection;

namespace ASPNetDocker.Models
{
    public class AssemblyScriptPath
    {
        public string Path { get; }
        public Assembly Assembly { get; }
        public AssemblyScriptPath(Assembly assembly, string path)
        {
            Path = path;
            Assembly = assembly;
        }
    }
}
