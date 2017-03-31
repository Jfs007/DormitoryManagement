using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypojo
{
   public class Dorm
    {
        private Build build;
        private int dormId;
        private int dormNo;
        private int bedNum;
        private string dormElse;

        public int DormId
        {
            get
            {
                return dormId;
            }

            set
            {
                dormId = value;
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

        public int BedNum
        {
            get
            {
                return bedNum;
            }

            set
            {
                bedNum = value;
            }
        }

        public string DormElse
        {
            get
            {
                return dormElse;
            }

            set
            {
                dormElse = value;
            }
        }

        public Build Build
        {
            get
            {
                return build;
            }

            set
            {
                build = value;
            }
        }
    }
}
