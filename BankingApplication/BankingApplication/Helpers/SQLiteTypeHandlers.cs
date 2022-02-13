using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication.Helpers
{
    public class SQLiteTypeHandlers
    {

    }
    class DateTimeOffsetHandler : SqlMapper.TypeHandler<DateTimeOffset>
    {
        public override void SetValue(IDbDataParameter parameter, DateTimeOffset value)
        {
            parameter.Value = value.ToString();
        }

        public override DateTimeOffset Parse(object value)
        {
            return DateTimeOffset.Parse(value.ToString());
        }
    }
}
