using ESBasic;
using ESPlus.Application.Friends.Passive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 在客户端，可以通过IRapidPassiveEngine暴露出的FriendsOutter属性，来使用好友关系功能
 */

namespace MinChat.Communications
{
    class MFriendsOutter :IFriendsOutter
    {
        /// <summary>
        ///  当好友上线时，触发此事件。参数为好友的UserID
        /// </summary>        
        event CbGeneric<string> FriendConnected;

        /// <summary>
        ///  当好友下线时，触发此事件。参数为好友的UserID
        /// </summary>
        event CbGeneric<string> FriendOffline;

        /// <summary>
        /// 获取所有在线的好友列表。
        /// </summary>      
        List<string> GetAllOnlineFriends();

        /// <summary>
        /// 获取好友列表。
        /// </summary>      
        List<string> GetFriends(string tag);
    }
}
