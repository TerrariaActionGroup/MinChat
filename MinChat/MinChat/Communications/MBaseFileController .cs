using ESBasic;
using ESPlus.Application.FileTransfering;
using ESPlus.FileTransceiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 通过ESPlus.Application.FileTransfering.IBaseFileController接口，
 * 我们可以提交发送文件的请求，并且可以主动取消正在接收或发送的文件。
 * IBaseFileController即可用于客户端也可用户服务端。
 */

namespace MinChat.Communications
{
    class MBaseFileController : IBaseFileController
    {
        /// <summary>
        /// 当文件接收方收到了来自发送方发送文件（夹）的请求时，触发此事件。该事件将在后台线程中触发，如果处理该事件时需要刷新UI，则需要转发到UI线程。
        /// 当接收方确定要接收或拒绝文件时，请调用BeginReceiveFile方法或RejectFile方法。
        /// </summary>
        event CbFileRequestReceived FileRequestReceived;

        /// <summary>
        /// 当文件接收方回复了同意/拒绝接收文件（夹）时，在发送方触发此事件。参数为 TransmittingProject - bool（同意？）。可以通过参数TransmittingProject的AccepterID属性得知接收方的UserID。
        /// 通常，客户端预定该事件，只需要告知文件发送者，而不需要再做任何额外处理。该事件将在后台线程中触发，如果处理该事件时需要刷新UI，则需要转发到UI线程。
        /// </summary>
        event CbGeneric<TransferingProject, bool> FileResponseReceived;

        /// <summary>
        /// 该事件接口暴露了所有正在发送文件（夹）的实时状态。
        /// </summary>
        IFileTransferingEvents FileSendingEvents { get; }

        /// <summary>
        /// 该事件接口暴露了所有正在接收的文件（夹）的实时状态。
        /// </summary>
        IFileTransferingEvents FileReceivingEvents { get; }

        /// <summary>
        /// 发送方准备发送文件（夹）。目标用户必须在线。如果对方同意接收，则后台会自动发送文件（夹）；如果对方拒绝接收，则会取消发送。（通过FileResponseReceived事件，可以得知对方是否同意接收。）
        /// </summary>
        /// <param name="accepterID">接收文件（夹）的用户ID</param>
        /// <param name="fileOrDirPath">被发送文件（夹）的路径</param>    
        /// <param name="comment">其它附加备注。如果是在类似FTP的服务中，该参数可以是保存文件（夹）的路径</param>       
        /// <param name="projectID">返回文件传送项目的编号</param>
        void BeginSendFile(string accepterID, string fileOrDirPath, string comment, out string projectID);

        /// <summary>
        /// 发送方准备发送文件（夹）。目标用户必须在线。如果对方同意接收，则后台会自动发送文件；如果对方拒绝接收，则会取消发送。（通过FileAnswerReceived事件，可以得知对方是否同意接收。）
        /// </summary>
        /// <param name="accepterID">接收文件（夹）的用户ID</param>
        /// <param name="fileOrDirPath">被发送文件（夹）的路径</param>       
        /// <param name="comment">其它附加备注。如果是在类似FTP的服务中，该参数可以是保存文件（夹）的路径</param>
        /// <param name="paras">发送参数设定。传入null，表示采用IFileSenderManager的默认设置。</param>
        /// <param name="projectID">返回文件传送项目的编号</param>
        void BeginSendFile(string accepterID, string fileOrDirPath, string comment, SendingFileParas paras, out string projectID);

        /// <summary>
        /// 接收方如果同意接收文件（夹），则调用该方法。
        /// </summary>
        /// <param name="projectID">文件传送项目的编号</param>
        /// <param name="savePath">存储文件（夹）的路径。请特别注意，如果已经存在同名的文件（夹），将覆盖之。</param>
        void BeginReceiveFile(string projectID, string savePath);

        /// <summary>
        /// 接收方如果拒绝接收文件（夹），则调用该方法。
        /// </summary>
        /// <param name="projectID">文件传送项目的编号</param>
        void RejectFile(string projectID);

        /// <summary>
        /// 获取与目标用户相关的所有文件传送项目的projectID的列表（包括未被接收方回复的传送项目）。
        /// </summary>
        /// <param name="destUserID">目标用户ID。如果为null，则表示获取所有正在传送项目的projectID。</param>
        /// <returns>projectID的列表</returns>
        List<string> GetTransferingAbout(string destUserID);

        /// <summary>
        /// 主动取消正在发送或接收的文件（夹）（包括未被接收方回复的传送项目），并通知对方。
        /// </summary>        
        void CancelTransfering(string projectID);

        /// <summary>
        /// 取消与目标用户相关的正在传送项目（包括未被接收方回复的传送项目）。
        /// </summary>
        /// <param name="destUserID">目标用户ID。如果为null，则表示取消所有正在传送项目。</param> 
        void CancelTransferingAbout(string destUserID);

        /// <summary>
        /// 获取正在发送或接收中的文件传送项目（包括未被接收方回复的传送项目）。如果不存在目标项目，则返回null。
        /// </summary>       
        TransferingProject GetTransferingProject(string projectID);
    }
}
