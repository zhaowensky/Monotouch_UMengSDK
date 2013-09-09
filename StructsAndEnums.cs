using System;

namespace UMengSDK
{
	public enum ReportPolicy
	{
		REALTIME = 0,       //实时发送
		BATCH = 1,          //启动发送
		SENDDAILY = 4,      //每日发送
		SENDWIFIONLY = 5    //仅在WIFI下启动时发送
	}
}

