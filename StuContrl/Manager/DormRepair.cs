using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypojo
{
    public class DormRepair
    {
        private int repairId;
        private string buildArea;
        private int buildNo;
        private int dormNo;
        private string repairTime;
        private string dormJob;
        private string repairResult;

        public int RepairId
        {
            get
            {
                return repairId;
            }

            set
            {
                repairId = value;
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

        public string RepairTime
        {
            get
            {
                return repairTime;
            }

            set
            {
                repairTime = value;
            }
        }

        public string DormJob
        {
            get
            {
                return dormJob;
            }

            set
            {
                dormJob = value;
            }
        }

        public string RepairResult
        {
            get
            {
                return repairResult;
            }

            set
            {
                repairResult = value;
            }
        }
    }
}
