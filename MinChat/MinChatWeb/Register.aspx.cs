using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MinChatWeb
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.RequestType.ToUpper() == "POST")
            {
                string nickName = Request["nick"].ToString();
                string userPwd = Request["password"].ToString();
                string sex = Request["sex"].ToString();
                string birthday = Request["birthday"].ToString();
                string addr = Request["addr"].ToString();
                string data = nickName + userPwd + sex + birthday + addr;

                //添加用户到数据库
                CustomizeUser user = new CustomizeUser();
                user.UserName = nickName;
                user.UserPwd = userPwd;
                user.Sex = int.Parse(sex);
                user.Age = 0;
                user.Birthday = birthday;
                user.Address = addr;
                user.Time = DateTime.Now.ToString();

                UserDBManager manager = UserDBManager.getInstance();
                long newUserId = manager.getNewUserId();
                user.UserId = newUserId.ToString();
                manager.addUser(user);
                Response.Write("<script>alert('"+ user.UserName +", 你的账号是:" + user.UserId +  "');</script>");

                //创建用户数据库以及四张数据表
                DBManager dbManager = DBManager.getInstance();
                dbManager.createUserDb(user.UserId);
                dbManager.createMsgTable(user.UserId);
                dbManager.createRelationTable(user.UserId);
                dbManager.createMgroupTable(user.UserId);
                dbManager.createGroupTable(user.UserId);
            }

        }
    }
}