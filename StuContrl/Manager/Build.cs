using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypojo
{
    public class Build
    {
        private int buildId;
        private string buildArea;
        private int buildNo;
        private string buildMsg;

        public int BuildId
        {
            get
            {
                return buildId;
            }

            set
            {
                buildId = value;
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

        public string BuildMsg
        {
            get
            {
                return buildMsg;
            }

            set
            {
                buildMsg = value;
            }
        }
    }
}
