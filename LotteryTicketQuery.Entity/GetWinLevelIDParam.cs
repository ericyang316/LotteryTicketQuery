using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LotteryTicketQuery.Entity
{
    public class GetWinLevelIDParam
    {
        /// <summary>
        /// 彩票类型
        /// </summary>
        public int TicketType { get; set; }
        /// <summary>
        /// 期数
        /// </summary>
        public long VolumesNum { get; set; }

        public SSQGetWinLevelIDParam SSQGetWinLevelIDParam { get; set; }
    }

    public class SSQGetWinLevelIDParam
    {
        public int RedAreaFirstNum { get; set; }
        public int RedAreaSecNum { get; set; }
        public int RedAreaThirdNum { get; set; }
        public int RedAreaFourthNum { get; set; }
        public int RedAreaFifthNum { get; set; }
        public int RedAreaSixthNum { get; set; }
        public int BlueAreaFirstNum { get; set; }


    }
}
