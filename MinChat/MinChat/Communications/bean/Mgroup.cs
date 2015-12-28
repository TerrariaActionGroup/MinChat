using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChat.Communications.bean
{
    class MGroup
    {
        private int mGroupId;
        private string mGroupName;
        private int num;
        #region
        public int MGroupId
        {
            get
            {
                return mGroupId;
            }
            set
            {
                mGroupId = value;
            }
        }

        public string MGroupName
        {
            get
            {
                return mGroupName;
            }
            set
            {
                mGroupName = value;
            }
        }

        public int Num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }
        #endregion
    }
}
