using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TicketSystem.Domain
{
    public enum IncidentTypeCategory
    {
        [Description("Infrastructure")]
        Infrastructure = 1,

        [Description("Software")]
        Software = 2,

        [Description("Components")]
        Components = 3,

        [Description("Repair")]
        Repair = 4           

    }
}

