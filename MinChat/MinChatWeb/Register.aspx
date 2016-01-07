<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="MinChatWeb.Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>MinChat官方注册</title>
<style type="text/css">
body {
	font-family: Verdana, Geneva, sans-serif;
	font-size: 22px;
	background-image: url(/image/body.png);
	background-repeat: repeat-x;
	display: block;
	height: 90%;
	width: 90%;
}
html {
	overflow-y: scroll;
	overflow-x: auto;
	display: block;
}
.Container {
	position: absolute;
	visibility: visible;
	font-style: normal;
	float: none;
	left: 58px;
	top: 117px;
	width: 303px;
}
.main_part {
	background-color: #FFF;
	float: left;
	position: absolute;
	height: 480px;
	width: 880px;
	left: 112px;
	top: 118px;
	border-bottom-style: groove;
	background-image: url(/image/MinChat.jpg);
	background-repeat: no-repeat;
	background-attachment: scroll;
	background-position: center;
}
.body_frame {
	width: 990px;
	height: 623px;
	position: absolute;
	left: 145px;
	top: 12px;
}
.header {
	height: 100px;
	background-image: url(/image/bg_chs_%E5%89%AF%E6%9C%AC.png);
	background-repeat: no-repeat;
	background-position: 20% 0%;
}
.copyright {
	position: absolute;
	left: 319px;
	top: 488px;
}
.btn {
	width: 140px;
	height: 36px;
	line-height: 18px;
	font-size: 18px;
	background: url(/image/btn_bg.png) no-repeat left top;
	color: #FFF;
	padding-bottom: 4px
}
</style>
<script type="text/javascript">
<!--
    function trim(str) {
        if (!str) return str;
        for (var begin = 0; begin < str.length; begin++)
            if (str.charAt(begin) != " ") break;
        if (begin == str.length) return "";
        for (var end = str.length - 1; end > begin; end--)
            if (str.charAt(end) != " ") break;
        return str.substring(begin, end + 1);
    }
    function check_blank(str) {
        var blank = false;
        if (str == null || str == "") blank = true;
        return blank;
    }
    function ClickBtn() {
        var oNick = document.getElementById("nick");
        var oPassword = document.getElementById("password2");
        var nickValue = trim(oNick.value);
        var passwordValue = trim(oPassword.value);
        if (check_blank(nickValue)) {
            alert("昵称不能为空!");
            oNick.focus();
        }
        else if (check_blank(passwordValue)) {
            alert("密码不能为空！");
            oPassword.focus();
        }
        document.getElementById('form1').submit();
    }
    //-->
</script>
</head>

<body>
<div class="body_frame"> <!--顶层div,用来控制界面相对位置-->
  <div class="header"> <!--顶层div,用来控制 头部相对位置--> 
    
  </div>
  <div class="main_part" >
    <p align="center">&nbsp;</p>
    <div class="Container">
      <table width="302" border="0" align="center" >
        <form  id="form1" method="post" >
          <tr>
            <td width="285" height="35" align="right"><label class="" for="nick">昵称</label>
              <input type="text"  class="" id="nick" name="nick" tabindex="2" maxlength="24"  size="18"autocomplete="off" /></td>
          </tr>
          <tr>
            <td height="35" align="right"><label class="" for="password2">密码</label>
              <input type="password" class="" id="password2" name="password" maxlength="16"  size="18"/></td>
          </tr>
          <tr>
            <td height="35" align="right"><label class="" for="password_again2">确认密码</label>
              <input type="password" class="" name="pass_again" id="password_again2" maxlength="16" size="18" /></td>
          </tr>
          <tr>
            <td height="35" align="right">生日&nbsp;<input type="date"  name="birthday"/>
           
           </td>
          </tr>
          <tr>
          	<td height="35" align="right">地址&nbsp;<input name="addr" type="text" id="addr" style="z-index: 0;" type="text" maxlength="24" autocomplete="off" size="18">
            </td>
           </tr>
          <tr>
            <td height="35" align="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;性别
              <input name="sex" id="man" type="radio" value="1" checked ="checked" />
              <label for="man">男</label>
              <input name="sex" id="woman" type="radio" value="0" />
              <label for="woman">女</label></td>
          </tr>
          <tr>
            <td height="35">&nbsp;</td>
          </tr>
          <tr>
            <td height="35" align="center"><input type="submit" onClick="ClickBtn()" class="btn" value="提交注册" title="提交注册" /></td>
          </tr>
          <tr>
            <td height="35">&nbsp;</td>
          </tr>
        </form>
      </table>
    </div>
    <div class="copyright">
      <table width="200" border="0">
        <tr>
          <td>©2016 MinChat</td>
        </tr>
      </table>
    </div>
  </div>
</div>
</body>
</html>
