using ESPlus.Application.FileTransfering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 同ESPlus的Basic应用或CustomizeInfo应用一样，
 * 在客户端支持文件传送功能需要使用到相应的“Outter”组件IFileOutter。
 * 客户端通过ESPlus.Application.FileTransfering.Passive.IFileOutter接口
 * 提供的方法来提交发送文件请求等操作。我们可以从ESPlus.Rapid.IRapidPassiveEngine
 * 暴露的FileOutter属性来获取IFileOutter引用。IFileOutter接口直接从IBaseFileController继承，且未增加任何新的内容
 */

namespace MinChat.Communications
{
    class MFileOutter : IBaseFileController
    {
    }
}
