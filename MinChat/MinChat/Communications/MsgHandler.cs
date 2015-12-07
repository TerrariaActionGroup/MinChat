using ESBasic;
using ESBasic.ObjectManagement.Forms;
using ESPlus.Application.Basic;
using ESPlus.Application.CustomizeInfo;
using ESPlus.FileTransceiver;
using ESPlus.Rapid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*功能：自定义处理器，用于处理服务器或其它用户发送过来的消息
 *时间：2015-11-23
 *作者：胡伟龙*/

namespace MinChat.Communications
{
    class MsgHandler : ICustomizeHandler
    {
        /// <summary>
        /// 处理接收到的信息（包括大数据块信息）。
        /// </summary>
        /// <param name="sourceUserID">发出信息的用户ID。如果为null，表示信息来自服务端。</param>
        /// <param name="informationType">自定义信息类型</param>
        /// <param name="info">信息</param>
        void HandleInformation(string sourceUserID, int informationType, byte[] info);

        /// <summary>
        /// 处理接收到的请求并返回应答信息。
        /// </summary>
        /// <param name="sourceUserID">发送请求信息的用户ID。如果为null，表示信息来自服务端。</param>     
        /// <param name="informationType">自定义请求信息的类型</param>  
        /// <param name="info">请求信息</param>
        /// <returns>应答信息</returns>
        byte[] HandleQuery(string sourceUserID, int informationType, byte[] info);
    }

}