using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChat.Communications.bean
{
    class MGroup
    {
        #region
        public int mGroupId
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

        public string mGroupName
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

        public int num
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
