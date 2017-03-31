using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypojo
{
    public class SubInfo
    {
        private int subNo;
        private string subPro;
        private string subDepart;
        private string subCode;

        public int SubNo
        {
            get
            {
                return subNo;
            }

            set
            {
                subNo = value;
            }
        }

        public string SubPro
        {
            get
            {
                return subPro;
            }

            set
            {
                subPro = value;
            }
        }

        public string SubDepart
        {
            get
            {
                return subDepart;
            }

            set
            {
                subDepart = value;
            }
        }

        public string SubCode
        {
            get
            {
                return subCode;
            }

            set
            {
                subCode = value;
            }
        }
    }
}
