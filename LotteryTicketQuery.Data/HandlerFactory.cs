using Enum;
using LotteryTicketQuery.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LotteryTicketQuery.Data
{
    public class HandlerFactory
    {
        public static BaseHandlerService GetServiceEntity(GetWinLevelIDParam Param)
        {

            //switch (Param.TicketType)
            //{
            //    case LotteryTicketType.双色球.GetHashCode():
            return new SSQHandlerService();

            //}
            return null;
        }

    }
}
