using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypojo
{
   public class DormDes
    {
        private int msgId;
        private string buildArea;
        private int buildNo;
        private int dormNo;
        private string foulsTime;
        private string dormMsg;
        private string dormResult;

        public int MsgId
        {
            get
            {
                return msgId;
            }

            set
            {
                msgId = value;
            }
        }

        public string BuildArea
        {
            get
            {
                return buildArea;
            }

            set
            {
                buildArea = value;
            }
        }

        public int BuildNo
        {
            get
            {
                return buildNo;
            }

            set
            {
                buildNo = value;
            }
        }

        public int DormNo
        {
            get
            {
                return dormNo;
            }

            set
            {
                dormNo = value;
            }
        }

        public string FoulsTime
        {
            get
            {
                return foulsTime;
            }

            set
            {
                foulsTime = value;
            }
        }

        public string DormMsg
        {
            get
            {
                return dormMsg;
            }

            set
            {
                dormMsg = value;
            }
        }

        public string DormResult
        {
            get
            {
                return dormResult;
            }

            set
            {
                dormResult = value;
            }
        }
    }
}
