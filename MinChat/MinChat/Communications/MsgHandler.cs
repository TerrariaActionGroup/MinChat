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
        private string userID;
        private IRapidPassiveEngine rapidPassiveEngine;


        #region ICustomizeHandler 实现 -- 处理接收到的自定义信息
        /// <summary>
        ///  处理消息,如果sourceUserID为null， 则表示是服务端发送过来的消息；如果sourceUserID不为null， 则表示是其他客户端发送过来的消息
        /// </summary>       
        public void HandleInformation(string sourceUserID, int informationType, byte[] info)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new CbGeneric<string, int, byte[]>(this.HandleInformation), sourceUserID, informationType, info);
            }
            else
            {
                if (sourceUserID != null)
                {
                    if (informationType == InformationTypes.Chat)
                    {
                        ChatForm form = this.chatFormManager.GetForm(sourceUserID);
                        if (form == null)
                        {
                            form = new ChatForm(this.userID, sourceUserID, this.rapidPassiveEngine.CustomizeOutter, this.rapidPassiveEngine.FileOutter);
                            this.chatFormManager.Add(form);
                            form.Show();
                        }

                        form.Focus();

                        form.ShowOtherTextChat(sourceUserID, System.Text.Encoding.UTF8.GetString(info));
                    }
                    if (informationType == InformationTypes.SendBlob)
                    {
                        string msg = System.Text.Encoding.UTF8.GetString(info);
                        this.ShowMessage(msg);
                    }
                }
                else
                {
                    if (informationType == InformationTypes.ServerSendToClient)
                    {
                        string msg = System.Text.Encoding.UTF8.GetString(info);
                        MessageBox.Show(string.Format("收到服务端的消息：{0}", msg));
                    }
                }
            }
        }

        public byte[] HandleQuery(string sourceUserID, int informationType, byte[] info)
        {
            if (sourceUserID != null)//客户端同步调用
            {
                if (informationType == InformationTypes.ClientCallClient)
                {
                    this.ShowMessage(string.Format("收到好友{0}的同步调用请求，立即回复", sourceUserID));
                    return System.Text.Encoding.UTF8.GetBytes(this.userID + "已经收到你的同步调用请求！");
                }
            }
            else//服务端同步调用
            {
                if (informationType == InformationTypes.ServerCallClient)
                {
                    this.ShowMessage("收到服务端的同步调用请求，立即回复");
                    return System.Text.Encoding.UTF8.GetBytes(this.userID + "已经收到来自服务端的同步调用请求！");
                }
            }
            return null;
        }

        #endregion
    }

}