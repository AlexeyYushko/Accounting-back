using System;

namespace ASPNetDocker.Exceptions
{
    public class ScriptNotFoundException: Exception
    {
        public ScriptNotFoundException(string assemblyName, string scriptPath) : base(
            $"Script {scriptPath} not found in assembly {assemblyName}")
        {
        }
    }
}
