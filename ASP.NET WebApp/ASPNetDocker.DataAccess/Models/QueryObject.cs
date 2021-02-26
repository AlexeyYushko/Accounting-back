namespace ASPNetDocker.DataAccess.Models
{
    public class QueryObject
    {
        public QueryObject(string sql)
        {
            Sql = sql;
        }

        public QueryObject(string sql, object queryParameters)
        {
            Sql = sql;
            QueryParameters = queryParameters;
        }

        public string Sql { get; }
        public object QueryParameters { get; }
    }
}
