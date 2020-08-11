using ASPNetDocker.Exceptions;
using ASPNetDocker.Interfaces;
using ASPNetDocker.Models;
using System;
using System.Collections.Concurrent;
using System.IO;

namespace ASPNetDocker.Managers
{
    internal sealed class SqlScriptReader : ISqlScriptReader
    {
        private readonly ConcurrentDictionary<AssemblyScriptPath, string> scripts
            = new ConcurrentDictionary<AssemblyScriptPath, string>();

        public string Get<T>(T dao, string scriptPath)
        {
            return Get(typeof(T), scriptPath);
        }

        private string Get(Type type, string scriptPath)
        {
            var assembly = type.Assembly;
            var assemblyScriptPath = new AssemblyScriptPath(assembly, scriptPath);

            var script = scripts.GetOrAdd(assemblyScriptPath, GetScriptResourceFromAssembly);

            return script;
        }

        private static string GetScriptResourceFromAssembly(AssemblyScriptPath scriptPath)
        {
            var assemblyName = scriptPath.Assembly.GetName().Name;
            using var stream = scriptPath.Assembly.GetManifestResourceStream($"{assemblyName}.{scriptPath.Path}");

            if (stream == null)
            {
                throw new ScriptNotFoundException(assemblyName, scriptPath.Path);
            }

            using var reader = new StreamReader(stream);

            return reader.ReadToEnd();
        }
    }
}
