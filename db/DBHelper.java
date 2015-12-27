package com.example.knightboy.doudou.db;


import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;


/**
 *建表
 */
public class DBHelper extends SQLiteOpenHelper {

	private static final String DB_NAME = "qq_byl";
	private static final int DB_VERSION = 1;
	private static DBHelper mInstance;

	public DBHelper(Context context) {
		super(context, DB_NAME, null, DB_VERSION);
	}

	public DBHelper(Context context, int version) {
		super(context, DB_NAME, null, version);
	}
	
	public synchronized static DBHelper getInstance(Context context) { 
		if (mInstance == null) { 
		     mInstance = new DBHelper(context); 
		} 
		return mInstance; 
	};

	@Override
	public void onCreate(SQLiteDatabase db) {
		
		/**
		 * 聊天记录
		 */
		String sql_msg = "Create table IF NOT EXISTS " + DBcolumns.TABLE_MSG
				+ "(" + DBcolumns.MSG_ID + " integer primary key autoincrement,"
				+ DBcolumns.MSG_FROM + " text,"
				+ DBcolumns.MSG_FROM_USER + " text,"
				+ DBcolumns.MSG_TO + " text,"
				+ DBcolumns.MSG_TYPE + " text,"
				+ DBcolumns.MSG_CONTENT + " text,"
				+ DBcolumns.MSG_ISCOMING + " integer,"
				+ DBcolumns.MSG_DATE + " text,"
				+ DBcolumns.MSG_ISREADED + " text,"
				+ DBcolumns.MSG_BAK1 + " text,"
				+ DBcolumns.MSG_BAK2 + " text,"
				+ DBcolumns.MSG_BAK3 + " text,"
				+ DBcolumns.MSG_BAK4 + " text,"
				+ DBcolumns.MSG_BAK5 + " text,"
				+ DBcolumns.MSG_BAK6 + " text);";
		
		/**
		 * 最近联系人
		 */
		String sql_session = "Create table IF NOT EXISTS "
				+ DBcolumns.TABLE_SESSION + "(" + DBcolumns.SESSION_ID + " integer primary key AUTOINCREMENT,"
				+ DBcolumns.SESSION_FROM + " text,"
                + DBcolumns.SESSION_FROM_USER + " text,"
				+ DBcolumns.SESSION_TYPE + " text,"
				+ DBcolumns.SESSION_TIME + " text,"
				+ DBcolumns.SESSION_TO + " text,"
				+ DBcolumns.SESSION_CONTENT + " text,"
				+ DBcolumns.SESSION_ISDISPOSE + " text);";
		
		
		db.execSQL(sql_msg);
		db.execSQL(sql_session);
	}

	@Override
	public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {

	}

}
