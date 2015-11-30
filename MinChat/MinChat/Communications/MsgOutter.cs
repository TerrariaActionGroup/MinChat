using ESFramework;
using ESFramework.Passive;
using ESPlus.Application.CustomizeInfo.Passive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *客户端可以发送信息给服务端，也可以发送信息给其他在线用户。
 *客户端通过ESPlus.Application.CustomizeInfo.Passive.ICustomizeOutter接口提供的方法来发送信息。
 *我们可以从ESPlus.Rapid.IRapidPassiveEngine暴露的CustomizeOutter属性来获取ICustomizeOutter引用。
 */

namespace MinChat.Communications
{
    class MsgOutter : ICustomizeOutter
    {
        /// <summary>
        /// 向服务器发送信息。
        /// </summary>
        /// <param name="informationType">自定义信息类型</param>
        /// <param name="info">信息</param>
        void Send(int informationType, byte[] info);

        /// <summary>
        /// 向在线用户targetUserID发送信息。
        /// </summary>
        /// <param name="targetUserID">接收消息的目标用户ID</param>
        /// <param name="informationType">自定义信息类型</param>
        /// <param name="info">信息</param>      
        void Send(string targetUserID, int informationType, byte[] info);

        /// <summary>
        /// 向服务器提交请求信息，并返回服务器的应答信息。如果超时没有应答则将抛出Timeout异常。
        /// </summary>      
        /// <param name="informationType">自定义请求信息的类型</param>
        /// <param name="info">请求信息</param>
        /// <returns>服务器的应答信息</returns>
        byte[] Query(int informationType, byte[] info);

        /// <summary>
        /// 向在线用户或服务器发送信息。
        /// </summary>
        /// <param name="targetUserID">接收消息的目标用户ID。如果为null，表示接收者为服务器。</param>
        /// <param name="informationType">自定义信息类型</param>
        /// <param name="post">是否采用Post模式发送消息</param>  
        /// <param name="action">当通道繁忙时所采取的动作</param>  
        void Send(string targetUserID, int informationType, byte[] info, bool post, ActionTypeOnChannelIsBusy action);   

        /// <summary>
        /// 通过可靠的P2P通道向在线用户targetUserID发送信息。
        /// </summary>
        /// <param name="targetUserID">接收消息的目标用户ID，不能为null。</param>
        /// <param name="informationType">自定义信息类型</param>
        /// <param name="info">信息</param>  
        /// <param name="actionType">当P2P通道不存在时，采取的操作</param>
        /// <param name="post">是否采用Post模式发送消息</param>  
        /// <param name="action">当通道繁忙时所采取的动作</param>  
        void SendByP2PChannel(string targetUserID, int informationType, byte[] info, ActionTypeOnNoP2PChannel actionType,
                               bool post, ActionTypeOnChannelIsBusy action);

        /// <summary>
        /// 即使与目标用户之间有可靠的P2P通道存在，也要通过服务器转发信息。
        /// </summary>
        /// <param name="targetUserID">接收消息的目标用户ID，不能为null。</param>
        /// <param name="informationType">自定义信息类型</param>
        /// <param name="info">信息</param>         
        void TransferByServer(string targetUserID, int informationType, byte[] info );   

        /// <summary>
        /// 向在线用户或服务器发送信息，并等待其ACK。当前调用线程会一直阻塞，直到收到ACK；如果超时都没有收到ACK，则将抛出TimeoutException。
        /// </summary>
        /// <param name="targetUserID">接收消息的目标用户ID。如果为null，表示信息接收者为服务端。</param>
        /// <param name="informationType">自定义信息类型</param>
        /// <param name="info">信息</param>      
        void SendCertainly(string targetUserID, int informationType, byte[] info);

        /// <summary>
        /// 向在线用户或服务器发送大的数据块信息。直到数据发送完毕，该方法才会返回。如果担心长时间阻塞调用线程，可考虑异步调用本方法。
        /// </summary>
        /// <param name="targetUserID">接收消息的目标用户ID。如果为null，表示接收者为服务器。</param>
        /// <param name="informationType">自定义信息类型</param>
        /// <param name="blobInfo">大的数据块信息</param>  
        /// <param name="fragmentSize">分片传递时，片段的大小</param>  
        void SendBlob(string targetUserID, int informationType, byte[] blobInfo  ,int fragmentSize);       

        /// <summary>
        /// 向在线目标用户或服务器提交请求信息，并返回应答信息。如果目标用户不在线，或超时没有应答则将抛出TimeoutException。
        /// 如果对方在处理请求时出现未捕获的异常，则该调用会抛出HandingException。
        /// </summary>      
        /// <param name="targetUserID">接收并处理请求消息的目标用户ID。如果为null，表示信息接收者为服务端。</param>
        /// <param name="informationType">自定义请求信息的类型</param>
        /// <param name="info">请求信息</param>
        /// <returns>应答信息</returns>
        byte[] Query(string targetUserID, int informationType, byte[] info);

        /// <summary>
        /// 回复异步调用。向在线目标用户或服务器提交请求信息，当收到应答信息或超时时，将回调CallbackHandler函数。
        /// </summary>      
        /// <param name="targetUserID">接收并处理请求消息的目标用户ID。如果为null，表示信息接收者为服务端。</param>
        /// <param name="informationType">自定义请求信息的类型</param>
        /// <param name="info">请求信息</param>
        /// <param name="handler">用于处理回复信息的处理器</param>
        /// <param name="tag">携带的状态数据，将被传递给回调函数handler</param>
        void Query(string targetUserID, int informationType, byte[] info, CallbackHandler handler, object tag);
    }

    /// <summary>
    /// 用于处理回复信息的方法委托。
    /// </summary>
    /// <param name="ee">如果为TimeoutException，表示超时没有回；如果为HandingException，表示处理方在处理时抛出异常。只有为null时，response参数才有效。</param>
    /// <param name="response">回复消息</param>
    /// <param name="tag">状态数据</param>
    public delegate void CallbackHandler(Exception ee, byte[] response, object tag);
}
