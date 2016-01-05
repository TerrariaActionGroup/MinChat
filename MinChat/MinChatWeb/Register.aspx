<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="MinChatWeb.Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>MinChat官方注册</title>
<style type="text/css">
.bg {
	background-image: url(/image/bg_chs.png);
	background-repeat: no-repeat;
	background-position: center top;
}
body {
	font-family: Verdana, Geneva, sans-serif;
	font-size: 22px;
	background-image: url(/image/body.png);
	background-repeat: repeat-x;
	overflow-y: hidden;
}
html {
	overflow-y: scroll;
	overflow-x: auto;
}
html{
	display:block;
}
form{
	padding-top:20px;
}
body{
	display:block;
}
div{
	display: block;
}
* {
	padding: 0;
	margin: 0;
	list-style:none;
}

*,body {
	color:#333;
}

.contanier{
	width:956px;
	margin:auto;
	background:url(/image/left.png) left bottom no-repeat;
	position:relative;
}
.header{
	background:url(/image/bg_chs.png) top center no-repeat;
	height:94px;
}
.hide{display:none!important;}
.right {
    border-top: solid 1px #80add9;
    border-bottom: solid 1px #d6d9db;
    background: url(/image/right_1600.png) right top no-repeat #f8fdff;
    padding-bottom: 80px;
    min-height: 530px;
    _height: 530px;
    float: left;
    width: 1000px;
	padding-left: 250px;
}
.haomaTitle{
	position: relative;
	width: 604px;
	height: 80px;
	margin-left: 63px;
	border-bottom:1px solid #ddd;
}

.right .box{
	margin-right: 3px;
}
.box{
	clear: both;
	height: auto;
}
 .nickNameName_ipt_box{
	z-index: 0;
}
.box .ipt_box{
	float: left;
	width: 306px;
	height: 50px;
	position: relative;
}

.box .ipt_box input.new_txt{
	border:none;
	line-height:18px;
	font-size:14px;
	height:34px;
	_height:17px;
	width:284px;
	padding:8px;
	background:transparent;
	}
.box .info{
	float:left;
	width:236px;
	height:40px;
	height:38px\9;
	}
.info table{
	margin-left:6px;
	}
.box .ipt_box .bg_txt{
	border:none;
	height:70px;
	width:300px;
	background:no-repeat scroll 0 0 transparent;
	}
.box_7 .item{
	height:40px;
	padding-top:0;
	height:39px\9\0;
	padding-top:1px\9\0;
	_height:38px;
	_padding-top:2px;
	}
.submit {
	position: relative;
	visibility: visible;
}
</style>

</head>

<body onload="init()">
   <div class="bg">
      <div class="container">
          <div class="header">
              <a href="zhuce.html" class="logo" target="_self" title="QQzhuce"></a>
           </div>
           <div class="content">
               <div class="right">
                   <div class="haomaTitle">
                       <div class="haomaTitle_web-inspect-hid-shortcut_">
                           <div class="homa-inner" id="hama-inner" >注册账号</div>
                        		 <br /><br />
                   				   <form  id="form1" method="post" >
                         				<div class="box_box_1" style="z-index 0">
                         					<label class="item" for="nickName">昵称</label> 
                   						</div>
                       					<div class="ipt_box">
                        				   <div id="nickName_bg" class="bgcolor">
                        				   <input type="text" class="new_txt" id="nickName" name="nickName" tabindex="6" style="z-index:0" maxlength="24" autocomplete="off" />
                        				   </div>
                       					</div>
                 
                     					<div class="box box_2">
                         				<label class="item" for="pwd">密码</label>       
                                        </div>
                         				<div class="ipt_box">
                         				<div id="pwd_bg" class="bg_txt">
                         				<input type="pwd" class="new_txt" id="pwd" name="pwd" maxlength="16"  />
                         				</div>
                        				</div>
                      
                      					<div class="box box_3">
                      					<label class="item" for="pwd2">确认密码</label>
                      					</div>
                                        
                                        
                   					 <div class="ipt_box">
                   					   <div id="pwd2_bg" class="bg_txt">
                      					<input type="pwd" class="new_txt" name="pwd2" id="pwd2" maxlength="16" />
                      					</div>
                      					</div>
                                         
                                       <div class="box box_4">
                                         <div class="item">性别</div>
                                         <div class="ipt_box sex_box">
                                         <input type="radio" value="1" name="sex" checked="checked" />男
                                         <input type="radio" value="0" name="sex"  />
                                         女
                                         </div>
                                        </div>
                                     
                                     <div class ="box box_5">
                                      <label class="item" for="age">年龄</label>
                                      </div>
                                      <div class="ipt_box">
                                      <div id="age" class="bg_txt">
                        				<input type="text" class="new_txt" id="age" name="age"   maxlength="24" autocomplete="off" />
                                        </div>
                                        </div>
                        				
                                      <div class ="box box_6">
                                      <label class="item" for="birthday">生日</label>
                                      </div>
                                      <div class="ipt_box">
                                      <div id="birthday" class="bg_txt">
                        				<input type="text" class="new_txt" id="birthday" name="birthday" style="z-index:0" maxlength="24" autocomplete="off" />
                                        </div>
                                        </div>
                                     
                                      <div class ="box box_7">
                                      <label class="item" for="addr">地址</label>
                                      </div>
                                      <div class="ipt_box">
                                      <div id="address" class="bg_txt">
                        				<input type="text" class="new_txt" id="addr" name="addr"  style="z-index:0" maxlength="24" autocomplete="off" />
                                        </div>
                                        </div>
        
    								<div class="submit"> 
   										<input type="submit" value="提交注册" title="提交注册" id="submit" />
                      					</div>
                                   </form>
                         </div>
                    </div>
                 </div>
              </div>
           </div>
      </div>
</body>
</html>

