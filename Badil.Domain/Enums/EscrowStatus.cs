using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Domain.Enums
{
    public enum EscrowStatus
    {
        AwaitingDeposit,
        FundsLocked,
        InTransit,
        InspectionPeriod,
        FundsReleased,
        Disputed
    }
}
