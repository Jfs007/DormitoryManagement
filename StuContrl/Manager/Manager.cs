using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypojo
{
    public class Manager
    {
        private int loginId;
        private string loginNo;
        private string loginPwd;
        private string loginType;

        public int LoginId
        {
            get
            {
                return loginId;
            }

            set
            {
                loginId = value;
            }
        }

        public string LoginNo
        {
            get
            {
                return loginNo;
            }

            set
            {
                loginNo = value;
            }
        }

        public string LoginPwd
        {
            get
            {
                return loginPwd;
            }

            set
            {
                loginPwd = value;
            }
        }

        public string LoginType
        {
            get
            {
                return loginType;
            }

            set
            {
                loginType = value;
            }
        }
    }
}
