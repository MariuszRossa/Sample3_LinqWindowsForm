using System.Data.Linq;

namespace Sample3_LinqWindowsForm
{
    public class CreateConnection : IDataContext
    {
        public CreateConnection()
        {
            linqDataContext = new Form_LinqSqlConnectionDataContext();
        }

        public Form_LinqSqlConnectionDataContext linqDataContext { get; }
    }
}
