namespace ASPNetDocker.Interfaces
{
    public interface ISqlScriptReader
    {
        string Get<T>(T dao, string scriptPath);
    }
}