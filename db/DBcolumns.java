package com.example.knightboy.doudou.db;

/**
 *数据库结构
 */
public class DBcolumns {
	
	
	
	/**
	 * 聊天消息信息表
	 */
	public static final String TABLE_MSG= "table_msg";
	public static final String MSG_ID = "msg_id";
	public static final String MSG_FROM = "msg_from";                //ID
    public static final String MSG_FROM_USER = "msg_from_user";
	public static final String MSG_TO = "msg_to";
	public static final String MSG_TYPE = "msg_type";
	public static final String MSG_CONTENT = "msg_content";
	public static final String MSG_ISCOMING = "msg_iscoming";
	public static final String MSG_DATE= "msg_date";
	public static final String MSG_ISREADED = "msg_isreaded";
	public static final String MSG_BAK1= "msg_bak1";
	public static final String MSG_BAK2 = "msg_bak2";
	public static final String MSG_BAK3 = "msg_bak3";
	public static final String MSG_BAK4= "msg_bak4";
	public static final String MSG_BAK5= "msg_bak5";
	public static final String MSG_BAK6= "msg_bak6";
	
	
	/**
	 *  聊天会话表
	 */
	public static final String TABLE_SESSION = "table_session";
	public static final String SESSION_ID = "session_id";
	public static final String SESSION_FROM = "session_from";
    public static final String SESSION_FROM_USER = "session_from_user";
	public static final String SESSION_TYPE = "session_type";
	public static final String SESSION_TIME = "session_time";
	public static final String SESSION_CONTENT = "session_content";
	public static final String SESSION_TO = "session_to";                 // 登录人id
	public static final String SESSION_ISDISPOSE = "session_isdispose";
}
