using ESBasic;
using ESPlus.Application.P2PSession.Passive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ESPlus为客户端提供了ESPlus.Application.P2PSession.Passive. IP2PController接口以控制和管理P2P通道。
 *通过IRapidPassiveEngine暴露了P2PController属性，我们可以获取IP2PController的引用。
 */

namespace MinChat.Communications
{
    class MP2PController :IP2PController
    {
        ///<summary>
         /// 当尝试建立P2P连接失败时，触发此事件。参数为对方的UserID。
         ///</summary>
         event CbGeneric<string> P2PConnectFailed;

         ///<summary>
         /// 当某个P2P Channel创建成功时，触发此事件。
         ///</summary>
         event CbGeneric<P2PChannelState> P2PChannelOpened;

         ///<summary>
         /// 当某个P2P Channel关闭时，触发此事件。参数为对方的UserID。
         ///</summary>
         event CbGeneric<P2PChannelState> P2PChannelClosed;

         ///<summary>
         /// 当使用可靠UDP的P2P通道时，是否开启PMTU自动发现。默认状态为关闭。
         ///</summary>
         bool PMTUDiscoveryEnabled { get; set; }

         ///<summary>
         /// 采用的P2P通道的类型。默认为TcpAndUdp，表示TCP打洞和UDP打洞都进行尝试。
         ///</summary>
         P2PChannelMode P2PChannelMode { get; set; }
 
         ///<summary>
         /// 尝试与目标用户建立P2P Channel。（异步方式。）
         ///</summary>
         ///<param name="destUserID">目标用户的UserID</param>
         void P2PConnectAsyn(string destUserID);
 
         ///<summary>
         /// 与目标用户之间是否存在P2P通道。
         ///</summary>
         bool IsP2PChannelExist(string destUserID);
 
         ///<summary>
         /// P2P通道是否繁忙。如果返回null，表示没有P2P通道，或者不了解P2P通道的繁忙状态（当tcp通道接入时或使用未增强的UDP通道）。
         ///</summary>
         bool? P2PChannelIsBusy(string destUserID);
 
         ///<summary>
         /// 获取所有P2P通道的状态。
         ///</summary>
         Dictionary<string, P2PChannelState> GetP2PChannelState();
 
         ///<summary>
         /// 获取目标用户的P2P通道的状态。
         ///</summary>
         P2PChannelState GetP2PChannelState(string destUserID);
   }
 
   ///<summary>
   /// P2P通道模型。
   ///</summary>
   public enum P2PChannelMode
   {
       TcpAndUdp = 0,
       Tcp,
       Udp
   }
}
