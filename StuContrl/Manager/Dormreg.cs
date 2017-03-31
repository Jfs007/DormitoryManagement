using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypojo
{
   public class Dormreg
    {
        private Student student;
        private string buildArea;
        private int buildNo;
        private int dormNo;

       

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

        public Student Student
        {
            get
            {
                return student;
            }

            set
            {
                student = value;
            }
        }
    }
}
