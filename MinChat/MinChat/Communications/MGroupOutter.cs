using ESBasic;
using ESFramework;
using ESPlus.Application.Group;
using ESPlus.Application.Group.Passive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 在客户端，可以通过IRapidPassiveEngine暴露出的GroupOutter属性，来使用组关系功能
 */

namespace MinChat.Communications
{
    class MGroupOutter :IGroupOutter
    {
        /// <summary>
        /// 当组成员上线时，触发该事件。参数：MemberID
        /// </summary>
        event CbGeneric<string> GroupmateConnected;

        /// <summary>
        /// 当组成员下线时，触发该事件。参数：MemberID
        /// </summary>
        event CbGeneric<string> GroupmateOffline;

        /// <summary>
        /// 当接收到某个组内的广播消息（包括大数据块信息）时，触发此事件。参数：broadcasterID - groupID - broadcastType - broadcastContent。
        /// 如果broadcasterID为null，表示是服务端发送的广播。
        /// </summary>
        event CbGeneric<string, string, int, byte[]> BroadcastReceived;

        /// <summary>
        /// 获取组的成员。
        /// </summary>        
        Groupmates GetGroupMembers(string groupID);

        /// <summary>
        /// 在组内广播信息。
        /// </summary>
        /// <param name="groupID">接收广播信息的组ID</param>
        /// <param name="broadcastType">广播信息的类型</param>
        /// <param name="broadcastContent">信息的内容</param>       
        /// <param name="action">当通道繁忙时采取的操作。</param>        
        void Broadcast(string groupID, int broadcastType, byte[] broadcastContent, ActionTypeOnChannelIsBusy action);
    }
}
