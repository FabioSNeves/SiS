using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TicketSystem.Domain
{
    public enum IncidentTypeStatus
    {
        [Description("new")]
        New = 1,

        [Description("inProgress")]
        InProgress = 2,

        [Description("finished")]
        Finished = 3
    }
}

