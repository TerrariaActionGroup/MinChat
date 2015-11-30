using ESBasic;
using ESPlus.Application.Basic.Passive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

/*
 * 客户端通过调用ESPlus.Application.Basic.Passive.IBasicOutter接口
 * 对应的方法以及预定其相关的事件，就可以完成基础功能或得到相关状态改变通知。
 *我们可以从ESPlus.Rapid.IRapidPassiveEngine暴露的BasicOutter属性来获取IBasicOutter引用
 */

namespace MinChat.Communications
{
    class MBasicOutter : IBasicOutter
    {
        /// <summary>
        ///  当自己被同名用户挤掉线时，触发此事件。此时，客户端引擎已被Dispose。
        /// </summary>
        event CbGeneric BeingPushedOut;

        /// <summary>
        ///  当自己被服务端踢出掉线时，触发此事件。此时，客户端引擎已被Dispose。
        /// </summary>
        event CbGeneric BeingKickedOut;
        /// <summary>
        /// 获取自己的IPE。
        /// </summary>
        /// <returns>通常是经过NAT之后的IPE</returns>
        IPEndPoint GetMyIPE();

        /// <summary>
        /// 获取当前AS上的所有在线的用户列表。【该方法仅仅用于demo和测试】
        /// </summary>      
        List<string> GetAllOnlineUsers();

        /// <summary>
        /// 查询用户是否在线。
        /// </summary>       
        bool IsUserOnline(string userID);

        /// <summary>
        /// ping服务器。在应用层模拟ping，比普通的ICMP的ping大一些（如8-10ms）。
        /// </summary>
        /// <returns>ping耗时，单位毫秒</returns>
        int Ping();

        /// <summary>
        /// ping其他在线用户(通过服务器中转)。
        /// 如果目标用户不在线，将抛出Timeout异常。
        /// </summary>
        /// <param name="targetUserID">要Ping的目标用户ID</param>
        /// <returns>ping耗时，单位毫秒</returns>
        int PingByServer(string targetUserID);

        /// <summary>
        /// ping其他在线用户（通过P2P通道）。
        /// 如果P2P通道不存在，则。如果目标用户不在线，将抛出Timeout异常。
        /// </summary>
        /// <param name="targetUserID">要Ping的目标用户ID</param>
        /// <returns>ping耗时，单位毫秒</returns>
        int PingByP2PChannel(string targetUserID);

        /// <summary>
        /// 命令服务端将目标用户踢出。如果目标用户不在当前AS上，则直接返回。
        /// </summary>
        /// <param name="targetUserID">要踢出的用户ID</param>
        void KickOut(string targetUserID);

        /// <summary>
        /// 向服务器发送心跳消息。被框架ESPlus.Application.Basic.Passive.HeartBeater使用。
        /// </summary>
        void SendHeartBeatMessage(); 
    }
}
