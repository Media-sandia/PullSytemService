using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Magna.CSL.Context
{
    public class Context : DAL.MagnaPullSystemEntities

    {
        public MainLog logger;

        public Context(string connectionString)
        {
            this.logger = new MainLog();

            this.Database.Connection.ConnectionString = connectionString;

            this.Database.Log = (s) =>
            {
                logger.WriteLog(s);
            };
        }

    }

    public abstract class Log
    {
        public Log()
        {

        }
        public ICollection<EntityLog> LogGenerated { get; set; }
        public virtual void WriteLog(string message)
        { throw new NotImplementedException(); }
        public virtual IEnumerable<EntityLog> FindLog(Expression<Func<EntityLog, bool>> criteria)
        { throw new NotImplementedException(); }
    }

    internal class Logger : Log
    {
        public Logger()
        {
            LogGenerated = new List<EntityLog>();
        }

        public override void WriteLog(string message)
        {
            LogGenerated.Add(new EntityLog(message));
        }
        public override IEnumerable<EntityLog> FindLog(Expression<Func<EntityLog, bool>> criteria)
        {
            var result = LogGenerated.AsQueryable().Where(criteria);
            return result.ToList();
        }
    }

    public class MainLog : Log
    {
        Logger log;
        public MainLog()
        {
            log = new Logger();
        }
        public override IEnumerable<EntityLog> FindLog(Expression<Func<EntityLog, bool>> criteria)
        {
            return log.FindLog(criteria);
        }
        public override void WriteLog(string message)
        {
            log.WriteLog(message);
        }
    }

    public class MyDbConfiguration : DbConfiguration
    {
        public MyDbConfiguration()
        {
            SetDatabaseLogFormatter(
                (context, writeAction) => new OneLineFormatter(context, writeAction));
        }
    }

    public class OneLineFormatter : DatabaseLogFormatter
    {
        public OneLineFormatter(DbContext context, Action<string> writeAction)
            : base(context, writeAction)
        {
        }

        public override void LogCommand<TResult>(
            DbCommand command, DbCommandInterceptionContext<TResult> interceptionContext)
        {
            string parametersString = string.Empty;
            var parameters = command.Parameters;
            if (parameters.Count > 0)
                parametersString = string.Join(", ", (from p in parameters.Cast<DbParameter>() select $"@{p.ParameterName} = '{p.Value}'").ToArray());

            string commandString = $"Context '{Context.GetType().Name}' is executing command '{command.CommandText.Replace(Environment.NewLine, "")}' {parametersString}\n";

            Write(commandString);
            Console.WriteLine(commandString);
        }

        public override void LogResult<TResult>(
            DbCommand command, DbCommandInterceptionContext<TResult> interceptionContext)
        {
        }
    }

    public class EntityLog
    {
        public EntityLog(string message)
        {
            this.FechaHora = DateTime.Now;
            this.Message = message;
        }
        public string Message { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
