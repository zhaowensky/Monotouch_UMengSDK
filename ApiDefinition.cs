using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

//友盟用户行为记录SDK
namespace UMengSDK
{
	[BaseType(typeof(NSObject), Delegates = new string[]{"UIAlertViewDelegate"}) ]
	interface MobClick{

		//开启友盟统计,以BATCH方式发送log.
		//+ (void)startWithAppkey:(NSString *)appKey;
		[Static,Export("startWithAppkey:")]
		void StartWithAppKey(string appKey);

		// channelId 为nil或@""时,默认会被被当作@"App Store"渠道
		//+ (void)startWithAppkey:(NSString *)appKey reportPolicy:(ReportPolicy)rp channelId:(NSString *)cid;
		[Static,Export("startWithAppkey:reportPolicy:channelId:")]
		void StartWithAppKey(string appKey,ReportPolicy rpt,string cid);

		//自定义app版本信息，如果不设置，默认从CFBundleVersion里取
		//+ (void)setAppVersion:(NSString *)appVersion;
		[Static,Export("setAppVersion:")]
		void SetAppVersion(string appVersion);

		//获取sdk 版本号
		//+ (NSString *)getAgentVersion; 
		[Static,Export("getAgentVersion")]
		string GetAgentVersion();

		//类方法设置是否让umeng SDK 捕捉和记录您的crash log
		//+ (void)setCrashReportEnabled:(BOOL)value;
		[Static,Export("setCrashReportEnabled:")]
		void SetCrashReportEnabled(bool value);

		//类方法设置是否打印sdk的log信息
		//+ (void)setLogEnabled:(BOOL)value;
		[Static,Export("setLogEnabled:")]
		void SetLogEnabled(bool value);

		//类方法，记录某个view打开多长时间.
		//+ (void)logPageView:(NSString *)pageName seconds:(int)seconds;
		[Static,Export("logPageView:seconds")]
		void LogPageView(string pageName,int seconds);

		//+ (void)beginLogPageView:(NSString *)pageName;
		[Static,Export("beginLogPageView:")]
		void BeginLogPageView(string pageName);

		//+ (void)endLogPageView:(NSString *)pageName;
		[Static,Export("beginLogPageView:")]
		void EndLogPageView(string pageName);

		//+ (void)event:(NSString *)eventId; //等同于 event:eventId label:eventId;
		[Static,Export("event:")]
		void Event(string eventId);

		//+ (void)event:(NSString *)eventId label:(NSString *)label; 
		// label为nil或@""时，等同于 event:eventId label:eventId;
		[Static,Export("event:label:")]
		void Event(string eventId,string lable);

		//		 //+ (void)event:(NSString *)eventId acc:(NSInteger)accumulation;
		//		[Static,Export("event:acc:")]
		//	    void Event(string eventId,int accumulation);
		//
		//		 //+ (void)event:(NSString *)eventId label:(NSString *)label acc:(NSInteger)accumulation;
		//		[Static,Export("event:label:acc:")]
		//	    void Event(string eventId,string lable,int accumulation);

		//+ (void)event:(NSString *)eventId attributes:(NSDictionary *)attributes;
		[Static,Export("event:attributes:")]
		void Event(string eventId,NSDictionary attributes);

		//+ (void)beginEvent:(NSString *)eventId;
		[Static,Export("beginEvent:")]
		void BeginEvent(string eventId);

		//+ (void)endEvent:(NSString *)eventId;
		[Static,Export("endEvent:")]
		void EndEvent(string eventId);

		//		 //+ (void)beginEvent:(NSString *)eventId label:(NSString *)label;
		//		[Static,Export("beginEvent:label:")]
		//	    void BeginEvent(string eventId,string lable);
		//
		//		 //+ (void)endEvent:(NSString *)eventId label:(NSString *)label;
		//		[Static,Export("endEvent:lable:")]
		//	    void EndEvent(string eventId,string lable);
		//
		//		 //+ (void)beginEvent:(NSString *)eventId primarykey :(NSString *)keyName attributes:(NSDictionary *)attributes;
		//		[Static,Export("beginEvent:primarykey:attributes:")]
		//	    void BeginEvent(string eventId,string keyName,NSDictionary attributes);

		//		 //+ (void)endEvent:(NSString *)eventId primarykey:(NSString *)keyName;
		//		[Static,Export("endEvent:primarykey:")]
		//	    void EndEvent(string eventId,string keyName);
		//
		//		 //+ (void)event:(NSString *)eventId durations:(int)microseconds;
		//		[Static,Export("event:durations:")]
		//	    void Event(string eventId,int microseconds);
		//
		//		 //+ (void)event:(NSString *)eventId label:(NSString *)label durations:(int)microseconds;
		//		[Static,Export("event:label:durations:")]
		//	    void Event(string eventId,string label,int microseconds);
		//
		//		 //+ (void)event:(NSString *)eventId attributes:(NSDictionary *)attributes durations:(int)microseconds;
		//		 [Static,Export("event:label:durations:microseconds:")]
		//	    void Event(string eventId,NSDictionary attributes,int microseconds);
		//
		//		 //此方法将在下一次更新中删除，请使用独立的用户反馈SDK
		//		 //+ (void)showFeedback:(UIViewController *)rootViewController;
		//		 [Static,Export("showFeedback:")]
		//		 void ShowFeedback(UIViewController rootViewController);
		//		
		//		 //类方法，生成一条反馈记录，并保存到本地缓存。
		//		 // 此方法将在下一次更新中删除，请使用独立的用户反馈SDK
		//		 [Static,Export("feedbackWithDictionary:")]
		//		 void FeedbackWithDictionary(NSDictionary feedbackDict);
		//
		//		 //+ (void)checkUpdate;
		//		 [Static,Export("checkUpdate")]
		//		 void CheckUpdate();
		//
		//		 //+ (void)checkUpdate:(NSString *)title cancelButtonTitle:(NSString *)cancelTitle otherButtonTitles:(NSString *)otherTitle;
		//		 [Static,Export("checkUpdate:cancelButtonTitle:otherButtonTitles")]
		//		 void CheckUpdate(string title,string cancelTitle,string otherTitle);

		//+ (void)checkUpdateWithDelegate:(id)delegate selector:(SEL)callBackSelectorWithDictionary;
		//		 [Static,Export("checkUpdateWithDelegate:cancelButtonTitle:otherButtonTitles")]
		//		  void CheckUpdateWithDelegate(,);

		//		 // + (void)updateOnlineConfig;
		//		 [Static,Export("updateOnlineConfig")]
		//		 void UpdateOnlineConfig();
		//
		//		 // + (NSString *)getConfigParams:(NSString *)key;
		//		 [Static,Export("getConfigParams:")]
		//		 string GetConfigParams(string key);
		//
		//		 //+ (NSDictionary *)getConfigParams;
		//		 [Static,Export("getConfigParams")]
		//		 NSDictionary GetConfigParams();
		//
		// 类方法，判断当前设备是否已经越狱
		//+ (BOOL)isJailbroken;
		[Static,Export("isJailbroken")]
		bool IsJailbroken();

		// 类方法，判断你的App是否被破解
		// +(BOOL)isPirated
		[Static,Export("isPirated")]
		bool IsPirated();

		//		 [Static,Export("setDelegate")]
		//		 void IsPirated();
		//		 + (void)setDelegate:(id)delegate;
		//		 + (void)setDelegate:(id)delegate reportPolicy:(ReportPolicy)rp;

	}


}

