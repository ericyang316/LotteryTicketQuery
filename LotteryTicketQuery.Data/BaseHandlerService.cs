using LotteryTicketQuery.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LotteryTicketQuery.Data
{
   public interface BaseHandlerService
    {
       int GetWinLevelID(GetWinLevelIDParam Param);
    }
}
