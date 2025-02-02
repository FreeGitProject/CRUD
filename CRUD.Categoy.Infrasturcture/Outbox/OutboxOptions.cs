using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Category.Infrasturcture.Outbox
{
    public sealed class OutboxOptions
    {
        public int IntervalInSeconds { get; init; }

        public int BatchSize { get; init; }
    }
}
