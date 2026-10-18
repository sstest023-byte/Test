 0x6CF652B040 Offset: 0x14D4040 VA: 0x6CF652B040
	public string get_Id() { }

	// RVA: 0x6CF652B048 Offset: 0x14D4048 VA: 0x6CF652B048
	public string get_Name() { }

	// RVA: 0x6CF652B050 Offset: 0x14D4050 VA: 0x6CF652B050
	public string get_Description() { }

	// RVA: 0x6CF652B058 Offset: 0x14D4058 VA: 0x6CF652B058
	public string get_ImageUrl() { }

	// RVA: 0x6CF652B060 Offset: 0x14D4060 VA: 0x6CF652B060
	public ulong get_CurrentCount() { }

	// RVA: 0x6CF652B068 Offset: 0x14D4068 VA: 0x6CF652B068
	public EventVisibility get_Visibility() { }

}

// Dll : Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi.Events
public enum EventVisibility
{
	// Fields

	public int value__; // 0x10
	public const EventVisibility Hidden = 1; // 0x0
	public const EventVisibility Revealed = 2; // 0x0

	// Properties


	// Methods

}

// Dll : Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi.Events
public interface IEvent
{
	// Fields


	// Properties

	public abstract string Id { get; }
	public abstract string Name { get; }
	public abstract string Description { get; }
	public abstract string ImageUrl { get; }
	public abstract ulong CurrentCount { get; }
	public abstract EventVisibility Visibility { get; }

	// Methods

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public abstract string get_Id() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public abstract string get_Name() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public abstract string get_Description() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public abstract string get_ImageUrl() { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public abstract ulong get_CurrentCount() { }

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	public abstract EventVisibility get_Visibility() { }

}

// Dll : Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi.Events
public interface IEventsClient
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5BD7408 Offset: 0xB80408 VA: 0x6CF5BD7408
	public abstract void FetchAllEvents(DataSource source, Action`2 callback) { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public abstract void FetchEvent(DataSource source, string eventId, Action`2 callback) { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public abstract void IncrementEvent(string eventId, uint stepsToIncrement) { }

}

// Dll : Google.Play.Games.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=3113
{
	// Fields


	// Properties


	// Methods

}

// Dll : Google.Play.Games.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=4634
{
	// Fields


	// Properties


	// Methods

}

// Dll : Google.Play.Games.dll
// Namespace: 
internal sealed class <PrivateImplementationDetails> : Object
{
	// Fields

	internal static readonly __StaticArrayInitTypeSize=4634 10714EA4D10E8513B7D5886A98B93FBC1C362A34D1B452FFEE2154E776C9F3A3; // 0x0
	internal static readonly __StaticArrayInitTypeSize=3113 CD118BEB274046C5B9049A1ADE9FA7F89A04ED91B3372653FC41873C9E74398D; // 0x121A

	// Properties


	// Methods

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class MaxCmpService : Object
{
	// Fields

	private static readonly MaxCmpService _instance; // 0x0
	private static Action`1 OnCompletedAction; // 0x8
	private static readonly AndroidJavaClass MaxUnityPluginClass; // 0x10

	// Properties

	internal static MaxCmpService Instance { get; }
	public bool HasSupportedCmp { get; }

	// Methods

	// RVA: 0x6CF6536328 Offset: 0x14DF328 VA: 0x6CF6536328
	private void .ctor() { }

	// RVA: 0x6CF6536330 Offset: 0x14DF330 VA: 0x6CF6536330
	internal static MaxCmpService get_Instance() { }

	// RVA: 0x6CF6536388 Offset: 0x14DF388 VA: 0x6CF6536388
	public void ShowCmpForExistingUser(Action`1 onCompletedAction) { }

	// RVA: 0x6CF6536474 Offset: 0x14DF474 VA: 0x6CF6536474
	public bool get_HasSupportedCmp() { }

	// RVA: 0x6CF653656C Offset: 0x14DF56C VA: 0x6CF653656C
	internal static void NotifyCompletedIfNeeded(Dictionary`2 errorProps) { }

	// RVA: 0x6CF6536770 Offset: 0x14DF770 VA: 0x6CF6536770
	private static void .cctor() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public enum ErrorCode
{
	// Fields

	public int value__; // 0x10
	public const ErrorCode Unspecified = 4294967295; // 0x0
	public const ErrorCode IntegrationError = 1; // 0x0
	public const ErrorCode FormUnavailable = 2; // 0x0
	public const ErrorCode FormNotRequired = 3; // 0x0

	// Properties


	// Methods

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class MaxCmpError : Object
{
	// Fields

	private ErrorCode <Code>k__BackingField; // 0x10
	private string <Message>k__BackingField; // 0x18
	private int <CmpCode>k__BackingField; // 0x20
	private string <CmpMessage>k__BackingField; // 0x28

	// Properties

	public ErrorCode Code { get; set; }
	public string Message { get; set; }
	public int CmpCode { get; set; }
	public string CmpMessage { get; set; }

	// Methods

	// RVA: 0x6CF6536624 Offset: 0x14DF624 VA: 0x6CF6536624
	public static MaxCmpError Create(IDictionary`2 error) { }

	// RVA: 0x6CF6536984 Offset: 0x14DF984 VA: 0x6CF6536984
	private static ErrorCode GetCode(int code) { }

	// RVA: 0x6CF6536820 Offset: 0x14DF820 VA: 0x6CF6536820
	private void .ctor() { }

	// RVA: 0x6CF6536A70 Offset: 0x14DFA70 VA: 0x6CF6536A70
	public ErrorCode get_Code() { }

	// RVA: 0x6CF6536A78 Offset: 0x14DFA78 VA: 0x6CF6536A78
	private void set_Code(ErrorCode value) { }

	// RVA: 0x6CF6536A80 Offset: 0x14DFA80 VA: 0x6CF6536A80
	public string get_Message() { }

	// RVA: 0x6CF6536A88 Offset: 0x14DFA88 VA: 0x6CF6536A88
	private void set_Message(string value) { }

	// RVA: 0x6CF6536A90 Offset: 0x14DFA90 VA: 0x6CF6536A90
	public int get_CmpCode() { }

	// RVA: 0x6CF6536A98 Offset: 0x14DFA98 VA: 0x6CF6536A98
	private void set_CmpCode(int value) { }

	// RVA: 0x6CF6536AA0 Offset: 0x14DFAA0 VA: 0x6CF6536AA0
	public string get_CmpMessage() { }

	// RVA: 0x6CF6536AA8 Offset: 0x14DFAA8 VA: 0x6CF6536AA8
	private void set_CmpMessage(string value) { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class AppLovin : Object
{
	// Fields

	public const string UserLoggedIn; // 0x0
	public const string UserCreatedAccount; // 0x0
	public const string UserCompletedTutorial; // 0x0
	public const string UserCompletedLevel; // 0x0
	public const string UserCompletedAchievement; // 0x0
	public const string UserSpentVirtualCurrency; // 0x0
	public const string UserCompletedInAppPurchase; // 0x0
	public const string UserSentInvitation; // 0x0
	public const string UserSharedLink; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF6536AB0 Offset: 0x14DFAB0 VA: 0x6CF6536AB0
	public void .ctor() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public static class MaxEvents : Object
{
	// Fields


	// Properties


	// Methods

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class MaxSdk : MaxSdkAndroid
{
	// Fields

	private const string _version; // 0x0

	// Properties

	public static string Version { get; }

	// Methods

	// RVA: 0x6CF6536AB8 Offset: 0x14DFAB8 VA: 0x6CF6536AB8
	public static string get_Version() { }

	// RVA: 0x6CF6536AF8 Offset: 0x14DFAF8 VA: 0x6CF6536AF8
	public void .ctor() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
internal class BackgroundCallbackProxy : AndroidJavaProxy
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6536D18 Offset: 0x14DFD18 VA: 0x6CF6536D18
	public void .ctor() { }

	// RVA: 0x6CF653FAA4 Offset: 0x14E8AA4 VA: 0x6CF653FAA4
	public void onEvent(string propsStr) { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class MaxSdkAndroid : MaxSdkBase
{
	// Fields

	private static readonly AndroidJavaClass MaxUnityPluginClass; // 0x0
	private static BackgroundCallbackProxy BackgroundCallback; // 0x8

	// Properties

	public static MaxUserServiceAndroid UserService { get; }
	public static MaxUserSegment UserSegment { get; }
	public static MaxTargetingData TargetingData { get; }

	// Methods

	// RVA: 0x6CF6536BA4 Offset: 0x14DFBA4 VA: 0x6CF6536BA4
	public static MaxUserServiceAndroid get_UserService() { }

	// RVA: 0x6CF6536C2C Offset: 0x14DFC2C VA: 0x6CF6536C2C
	private static void .cctor() { }

	// RVA: 0x6CF6536FA4 Offset: 0x14DFFA4 VA: 0x6CF6536FA4
	public static void SetSdkKey(string sdkKey) { }

	// RVA: 0x6CF6537088 Offset: 0x14E0088 VA: 0x6CF6537088
	public static void InitializeSdk(String[] adUnitIds) { }

	// RVA: 0x6CF653736C Offset: 0x14E036C VA: 0x6CF653736C
	public static bool IsInitialized() { }

	// RVA: 0x6CF6537464 Offset: 0x14E0464 VA: 0x6CF6537464
	public static void SetUserId(string userId) { }

	// RVA: 0x6CF6537548 Offset: 0x14E0548 VA: 0x6CF6537548
	public static MaxUserSegment get_UserSegment() { }

	// RVA: 0x6CF65375A0 Offset: 0x14E05A0 VA: 0x6CF65375A0
	public static MaxTargetingData get_TargetingData() { }

	// RVA: 0x6CF65375F8 Offset: 0x14E05F8 VA: 0x6CF65375F8
	public static List`1 GetAvailableMediatedNetworks() { }

	// RVA: 0x6CF653773C Offset: 0x14E073C VA: 0x6CF653773C
	public static void ShowMediationDebugger() { }

	// RVA: 0x6CF6537820 Offset: 0x14E0820 VA: 0x6CF6537820
	public static void ShowCreativeDebugger() { }

	// RVA: 0x6CF6537904 Offset: 0x14E0904 VA: 0x6CF6537904
	public static string GetAdValue(string adUnitIdentifier, string key) { }

	// RVA: 0x6CF6537A48 Offset: 0x14E0A48 VA: 0x6CF6537A48
	public static SdkConfiguration GetSdkConfiguration() { }

	// RVA: 0x6CF6537E2C Offset: 0x14E0E2C VA: 0x6CF6537E2C
	public static void SetHasUserConsent(bool hasUserConsent) { }

	// RVA: 0x6CF6537F50 Offset: 0x14E0F50 VA: 0x6CF6537F50
	public static bool HasUserConsent() { }

	// RVA: 0x6CF6538048 Offset: 0x14E1048 VA: 0x6CF6538048
	public static bool IsUserConsentSet() { }

	// RVA: 0x6CF6538140 Offset: 0x14E1140 VA: 0x6CF6538140
	public static void SetIsAgeRestrictedUser(bool isAgeRestrictedUser) { }

	// RVA: 0x6CF6538264 Offset: 0x14E1264 VA: 0x6CF6538264
	public static bool IsAgeRestrictedUser() { }

	// RVA: 0x6CF653835C Offset: 0x14E135C VA: 0x6CF653835C
	public static bool IsAgeRestrictedUserSet() { }

	// RVA: 0x6CF6538454 Offset: 0x14E1454 VA: 0x6CF6538454
	public static void SetDoNotSell(bool doNotSell) { }

	// RVA: 0x6CF6538578 Offset: 0x14E1578 VA: 0x6CF6538578
	public static bool IsDoNotSell() { }

	// RVA: 0x6CF6538670 Offset: 0x14E1670 VA: 0x6CF6538670
	public static bool IsDoNotSellSet() { }

	// RVA: 0x6CF6538768 Offset: 0x14E1768 VA: 0x6CF6538768
	public static void CreateBanner(string adUnitIdentifier, BannerPosition bannerPosition) { }

	// RVA: 0x6CF65389FC Offset: 0x14E19FC VA: 0x6CF65389FC
	public static void CreateBanner(string adUnitIdentifier, float x, float y) { }

	// RVA: 0x6CF6538BCC Offset: 0x14E1BCC VA: 0x6CF6538BCC
	public static void LoadBanner(string adUnitIdentifier) { }

	// RVA: 0x6CF6538CF4 Offset: 0x14E1CF4 VA: 0x6CF6538CF4
	public static void SetBannerPlacement(string adUnitIdentifier, string placement) { }

	// RVA: 0x6CF6538E50 Offset: 0x14E1E50 VA: 0x6CF6538E50
	public static void StartBannerAutoRefresh(string adUnitIdentifier) { }

	// RVA: 0x6CF6538F78 Offset: 0x14E1F78 VA: 0x6CF6538F78
	public static void StopBannerAutoRefresh(string adUnitIdentifier) { }

	// RVA: 0x6CF65390A0 Offset: 0x14E20A0 VA: 0x6CF65390A0
	public static void UpdateBannerPosition(string adUnitIdentifier, BannerPosition bannerPosition) { }

	// RVA: 0x6CF6539208 Offset: 0x14E2208 VA: 0x6CF6539208
	public static void UpdateBannerPosition(string adUnitIdentifier, float x, float y) { }

	// RVA: 0x6CF65393D8 Offset: 0x14E23D8 VA: 0x6CF65393D8
	public static void SetBannerWidth(string adUnitIdentifier, float width) { }

	// RVA: 0x6CF6539560 Offset: 0x14E2560 VA: 0x6CF6539560
	public static void ShowBanner(string adUnitIdentifier) { }

	// RVA: 0x6CF6539688 Offset: 0x14E2688 VA: 0x6CF6539688
	public static void DestroyBanner(string adUnitIdentifier) { }

	// RVA: 0x6CF65397B0 Offset: 0x14E27B0 VA: 0x6CF65397B0
	public static void HideBanner(string adUnitIdentifier) { }

	// RVA: 0x6CF65398D8 Offset: 0x14E28D8 VA: 0x6CF65398D8
	public static void SetBannerBackgroundColor(string adUnitIdentifier, Color color) { }

	// RVA: 0x6CF6539C90 Offset: 0x14E2C90 VA: 0x6CF6539C90
	public static void SetBannerExtraParameter(string adUnitIdentifier, string key, string value) { }

	// RVA: 0x6CF6539E18 Offset: 0x14E2E18 VA: 0x6CF6539E18
	public static void SetBannerLocalExtraParameter(string adUnitIdentifier, string key, object value) { }

	// RVA: 0x6CF653A2A4 Offset: 0x14E32A4 VA: 0x6CF653A2A4
	public static void SetBannerCustomData(string adUnitIdentifier, string customData) { }

	// RVA: 0x6CF653A400 Offset: 0x14E3400 VA: 0x6CF653A400
	public static Rect GetBannerLayout(string adUnitIdentifier) { }

	// RVA: 0x6CF653A6BC Offset: 0x14E36BC VA: 0x6CF653A6BC
	public static void CreateMRec(string adUnitIdentifier, AdViewPosition mrecPosition) { }

	// RVA: 0x6CF653A8E0 Offset: 0x14E38E0 VA: 0x6CF653A8E0
	public static void CreateMRec(string adUnitIdentifier, float x, float y) { }

	// RVA: 0x6CF653AAB0 Offset: 0x14E3AB0 VA: 0x6CF653AAB0
	public static void LoadMRec(string adUnitIdentifier) { }

	// RVA: 0x6CF653ABD8 Offset: 0x14E3BD8 VA: 0x6CF653ABD8
	public static void SetMRecPlacement(string adUnitIdentifier, string placement) { }

	// RVA: 0x6CF653AD34 Offset: 0x14E3D34 VA: 0x6CF653AD34
	public static void StartMRecAutoRefresh(string adUnitIdentifier) { }

	// RVA: 0x6CF653AE5C Offset: 0x14E3E5C VA: 0x6CF653AE5C
	public static void StopMRecAutoRefresh(string adUnitIdentifier) { }

	// RVA: 0x6CF653AF84 Offset: 0x14E3F84 VA: 0x6CF653AF84
	public static void UpdateMRecPosition(string adUnitIdentifier, AdViewPosition mrecPosition) { }

	// RVA: 0x6CF653B0EC Offset: 0x14E40EC VA: 0x6CF653B0EC
	public static void UpdateMRecPosition(string adUnitIdentifier, float x, float y) { }

	// RVA: 0x6CF653B2BC Offset: 0x14E42BC VA: 0x6CF653B2BC
	public static void ShowMRec(string adUnitIdentifier) { }

	// RVA: 0x6CF653B3E4 Offset: 0x14E43E4 VA: 0x6CF653B3E4
	public static void DestroyMRec(string adUnitIdentifier) { }

	// RVA: 0x6CF653B50C Offset: 0x14E450C VA: 0x6CF653B50C
	public static void HideMRec(string adUnitIdentifier) { }

	// RVA: 0x6CF653B634 Offset: 0x14E4634 VA: 0x6CF653B634
	public static void SetMRecExtraParameter(string adUnitIdentifier, string key, string value) { }

	// RVA: 0x6CF653B7BC Offset: 0x14E47BC VA: 0x6CF653B7BC
	public static void SetMRecLocalExtraParameter(string adUnitIdentifier, string key, object value) { }

	// RVA: 0x6CF653BACC Offset: 0x14E4ACC VA: 0x6CF653BACC
	public static void SetMRecCustomData(string adUnitIdentifier, string customData) { }

	// RVA: 0x6CF653BC28 Offset: 0x14E4C28 VA: 0x6CF653BC28
	public static Rect GetMRecLayout(string adUnitIdentifier) { }

	// RVA: 0x6CF653BD68 Offset: 0x14E4D68 VA: 0x6CF653BD68
	public static void LoadInterstitial(string adUnitIdentifier) { }

	// RVA: 0x6CF653BE90 Offset: 0x14E4E90 VA: 0x6CF653BE90
	public static bool IsInterstitialReady(string adUnitIdentifier) { }

	// RVA: 0x6CF653BFCC Offset: 0x14E4FCC VA: 0x6CF653BFCC
	public static void ShowInterstitial(string adUnitIdentifier, string placement, string customData) { }

	// RVA: 0x6CF653C224 Offset: 0x14E5224 VA: 0x6CF653C224
	public static void SetInterstitialExtraParameter(string adUnitIdentifier, string key, string value) { }

	// RVA: 0x6CF653C3AC Offset: 0x14E53AC VA: 0x6CF653C3AC
	public static void SetInterstitialLocalExtraParameter(string adUnitIdentifier, string key, object value) { }

	// RVA: 0x6CF653C6BC Offset: 0x14E56BC VA: 0x6CF653C6BC
	public static void LoadAppOpenAd(string adUnitIdentifier) { }

	// RVA: 0x6CF653C7E4 Offset: 0x14E57E4 VA: 0x6CF653C7E4
	public static bool IsAppOpenAdReady(string adUnitIdentifier) { }

	// RVA: 0x6CF653C920 Offset: 0x14E5920 VA: 0x6CF653C920
	public static void ShowAppOpenAd(string adUnitIdentifier, string placement, string customData) { }

	// RVA: 0x6CF653CAEC Offset: 0x14E5AEC VA: 0x6CF653CAEC
	public static void SetAppOpenAdExtraParameter(string adUnitIdentifier, string key, string value) { }

	// RVA: 0x6CF653CC74 Offset: 0x14E5C74 VA: 0x6CF653CC74
	public static void SetAppOpenAdLocalExtraParameter(string adUnitIdentifier, string key, object value) { }

	// RVA: 0x6CF653CF84 Offset: 0x14E5F84 VA: 0x6CF653CF84
	public static void LoadRewardedAd(string adUnitIdentifier) { }

	// RVA: 0x6CF653D0AC Offset: 0x14E60AC VA: 0x6CF653D0AC
	public static bool IsRewardedAdReady(string adUnitIdentifier) { }

	// RVA: 0x6CF653D1E8 Offset: 0x14E61E8 VA: 0x6CF653D1E8
	public static void ShowRewardedAd(string adUnitIdentifier, string placement, string customData) { }

	// RVA: 0x6CF653D3B4 Offset: 0x14E63B4 VA: 0x6CF653D3B4
	public static void SetRewardedAdExtraParameter(string adUnitIdentifier, string key, string value) { }

	// RVA: 0x6CF653D53C Offset: 0x14E653C VA: 0x6CF653D53C
	public static void SetRewardedAdLocalExtraParameter(string adUnitIdentifier, string key, object value) { }

	// RVA: 0x6CF653D84C Offset: 0x14E684C VA: 0x6CF653D84C
	public static void LoadRewardedInterstitialAd(string adUnitIdentifier) { }

	// RVA: 0x6CF653D974 Offset: 0x14E6974 VA: 0x6CF653D974
	public static bool IsRewardedInterstitialAdReady(string adUnitIdentifier) { }

	// RVA: 0x6CF653DAB0 Offset: 0x14E6AB0 VA: 0x6CF653DAB0
	public static void ShowRewardedInterstitialAd(string adUnitIdentifier, string placement, string customData) { }

	// RVA: 0x6CF653DC7C Offset: 0x14E6C7C VA: 0x6CF653DC7C
	public static void SetRewardedInterstitialAdExtraParameter(string adUnitIdentifier, string key, string value) { }

	// RVA: 0x6CF653DE04 Offset: 0x14E6E04 VA: 0x6CF653DE04
	public static void SetRewardedInterstitialAdLocalExtraParameter(string adUnitIdentifier, string key, object value) { }

	// RVA: 0x6CF653E114 Offset: 0x14E7114 VA: 0x6CF653E114
	public static void TrackEvent(string name, IDictionary`2 parameters) { }

	// RVA: 0x6CF653E23C Offset: 0x14E723C VA: 0x6CF653E23C
	public static void SetMuted(bool muted) { }

	// RVA: 0x6CF653E360 Offset: 0x14E7360 VA: 0x6CF653E360
	public static bool IsMuted() { }

	// RVA: 0x6CF653E458 Offset: 0x14E7458 VA: 0x6CF653E458
	public static void SetVerboseLogging(bool enabled) { }

	// RVA: 0x6CF653E57C Offset: 0x14E757C VA: 0x6CF653E57C
	public static bool IsVerboseLoggingEnabled() { }

	// RVA: 0x6CF653E674 Offset: 0x14E7674 VA: 0x6CF653E674
	public static void SetCreativeDebuggerEnabled(bool enabled) { }

	// RVA: 0x6CF653E798 Offset: 0x14E7798 VA: 0x6CF653E798
	public static void SetTestDeviceAdvertisingIdentifiers(String[] advertisingIdentifiers) { }

	// RVA: 0x6CF653E940 Offset: 0x14E7940 VA: 0x6CF653E940
	public static void SetExceptionHandlerEnabled(bool enabled) { }

	// RVA: 0x6CF653EA64 Offset: 0x14E7A64 VA: 0x6CF653EA64
	public static void SetLocationCollectionEnabled(bool enabled) { }

	// RVA: 0x6CF653EB88 Offset: 0x14E7B88 VA: 0x6CF653EB88
	public static void SetExtraParameter(string key, string value) { }

	// RVA: 0x6CF653ECA0 Offset: 0x14E7CA0 VA: 0x6CF653ECA0
	internal static void SetUserSegmentField(string name, string value) { }

	// RVA: 0x6CF653EDB8 Offset: 0x14E7DB8 VA: 0x6CF653EDB8
	internal static void SetTargetingDataYearOfBirth(int yearOfBirth) { }

	// RVA: 0x6CF653EED0 Offset: 0x14E7ED0 VA: 0x6CF653EED0
	internal static void SetTargetingDataGender(string gender) { }

	// RVA: 0x6CF653EFB4 Offset: 0x14E7FB4 VA: 0x6CF653EFB4
	internal static void SetTargetingDataMaximumAdContentRating(int maximumAdContentRating) { }

	// RVA: 0x6CF653F0CC Offset: 0x14E80CC VA: 0x6CF653F0CC
	internal static void SetTargetingDataEmail(string email) { }

	// RVA: 0x6CF653F1B0 Offset: 0x14E81B0 VA: 0x6CF653F1B0
	internal static void SetTargetingDataPhoneNumber(string phoneNumber) { }

	// RVA: 0x6CF653F294 Offset: 0x14E8294 VA: 0x6CF653F294
	internal static void SetTargetingDataKeywords(String[] keywords) { }

	// RVA: 0x6CF653F374 Offset: 0x14E8374 VA: 0x6CF653F374
	internal static void SetTargetingDataInterests(String[] interests) { }

	// RVA: 0x6CF653F454 Offset: 0x14E8454 VA: 0x6CF653F454
	internal static void ClearAllTargetingData() { }

	// RVA: 0x6CF653F538 Offset: 0x14E8538 VA: 0x6CF653F538
	public static ConsentDialogState GetConsentDialogState() { }

	// RVA: 0x6CF653F664 Offset: 0x14E8664 VA: 0x6CF653F664
	public static AdInfo GetAdInfo(string adUnitIdentifier) { }

	// RVA: 0x6CF6536B4C Offset: 0x14DFB4C VA: 0x6CF6536B4C
	public void .ctor() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public enum ConsentFlowUserGeography
{
	// Fields

	public int value__; // 0x10
	public const ConsentFlowUserGeography Unknown = 0; // 0x0
	public const ConsentFlowUserGeography Gdpr = 1; // 0x0
	public const ConsentFlowUserGeography Other = 2; // 0x0

	// Properties


	// Methods

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public enum AdViewPosition
{
	// Fields

	public int value__; // 0x10
	public const AdViewPosition TopLeft = 0; // 0x0
	public const AdViewPosition TopCenter = 1; // 0x0
	public const AdViewPosition TopRight = 2; // 0x0
	public const AdViewPosition Centered = 3; // 0x0
	public const AdViewPosition CenterLeft = 4; // 0x0
	public const AdViewPosition CenterRight = 5; // 0x0
	public const AdViewPosition BottomLeft = 6; // 0x0
	public const AdViewPosition BottomCenter = 7; // 0x0
	public const AdViewPosition BottomRight = 8; // 0x0

	// Properties


	// Methods

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public enum BannerPosition
{
	// Fields

	public int value__; // 0x10
	public const BannerPosition TopLeft = 0; // 0x0
	public const BannerPosition TopCenter = 1; // 0x0
	public const BannerPosition TopRight = 2; // 0x0
	public const BannerPosition Centered = 3; // 0x0
	public const BannerPosition CenterLeft = 4; // 0x0
	public const BannerPosition CenterRight = 5; // 0x0
	public const BannerPosition BottomLeft = 6; // 0x0
	public const BannerPosition BottomCenter = 7; // 0x0
	public const BannerPosition BottomRight = 8; // 0x0

	// Properties


	// Methods

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class SdkConfiguration : Object
{
	// Fields

	private bool <IsSuccessfullyInitialized>k__BackingField; // 0x10
	private string <CountryCode>k__BackingField; // 0x18
	private bool <IsTestModeEnabled>k__BackingField; // 0x20
	private ConsentFlowUserGeography <ConsentFlowUserGeography>k__BackingField; // 0x24
	private ConsentDialogState <ConsentDialogState>k__BackingField; // 0x28

	// Properties

	public bool IsSuccessfullyInitialized { get; set; }
	public string CountryCode { get; set; }
	public bool IsTestModeEnabled { get; set; }
	public ConsentFlowUserGeography ConsentFlowUserGeography { get; set; }
	public ConsentDialogState ConsentDialogState { get; set; }

	// Methods

	// RVA: 0x6CF6541858 Offset: 0x14EA858 VA: 0x6CF6541858
	public bool get_IsSuccessfullyInitialized() { }

	// RVA: 0x6CF6541860 Offset: 0x14EA860 VA: 0x6CF6541860
	private void set_IsSuccessfullyInitialized(bool value) { }

	// RVA: 0x6CF654186C Offset: 0x14EA86C VA: 0x6CF654186C
	public string get_CountryCode() { }

	// RVA: 0x6CF6541874 Offset: 0x14EA874 VA: 0x6CF6541874
	private void set_CountryCode(string value) { }

	// RVA: 0x6CF654187C Offset: 0x14EA87C VA: 0x6CF654187C
	public bool get_IsTestModeEnabled() { }

	// RVA: 0x6CF6541884 Offset: 0x14EA884 VA: 0x6CF6541884
	private void set_IsTestModeEnabled(bool value) { }

	// RVA: 0x6CF6541890 Offset: 0x14EA890 VA: 0x6CF6541890
	public ConsentFlowUserGeography get_ConsentFlowUserGeography() { }

	// RVA: 0x6CF6541898 Offset: 0x14EA898 VA: 0x6CF6541898
	private void set_ConsentFlowUserGeography(ConsentFlowUserGeography value) { }

	// RVA: 0x6CF65418A0 Offset: 0x14EA8A0 VA: 0x6CF65418A0
	public ConsentDialogState get_ConsentDialogState() { }

	// RVA: 0x6CF65418A8 Offset: 0x14EA8A8 VA: 0x6CF65418A8
	private void set_ConsentDialogState(ConsentDialogState value) { }

	// RVA: 0x6CF6537BDC Offset: 0x14E0BDC VA: 0x6CF6537BDC
	public static SdkConfiguration Create(IDictionary`2 eventProps) { }

	// RVA: 0x6CF65418B0 Offset: 0x14EA8B0 VA: 0x6CF65418B0
	public void .ctor() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public struct Reward
{
	// Fields

	public string Label; // 0x10
	public int Amount; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF65419E8 Offset: 0x14EA9E8 VA: 0x6CF65419E8
	public override string ToString() { }

	// RVA: 0x6CF6541A68 Offset: 0x14EAA68 VA: 0x6CF6541A68
	public bool IsValid() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public enum ErrorCode
{
	// Fields

	public int value__; // 0x10
	public const ErrorCode Unspecified = 4294967295; // 0x0
	public const ErrorCode NoFill = 204; // 0x0
	public const ErrorCode AdLoadFailed = 4294962295; // 0x0
	public const ErrorCode AdDisplayFailed = 4294963091; // 0x0
	public const ErrorCode NetworkError = 4294966296; // 0x0
	public const ErrorCode NetworkTimeout = 4294966295; // 0x0
	public const ErrorCode NoNetwork = 4294966287; // 0x0
	public const ErrorCode FullscreenAdAlreadyShowing = 4294967273; // 0x0
	public const ErrorCode FullscreenAdNotReady = 4294967272; // 0x0
	public const ErrorCode NoActivity = 4294961695; // 0x0
	public const ErrorCode DontKeepActivitiesEnabled = 4294961694; // 0x0

	// Properties


	// Methods

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public enum MaxAdLoadState
{
	// Fields

	public int value__; // 0x10
	public const MaxAdLoadState AdLoadNotAttempted = 0; // 0x0
	public const MaxAdLoadState AdLoaded = 1; // 0x0
	public const MaxAdLoadState FailedToLoad = 2; // 0x0

	// Properties


	// Methods

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class AdInfo : Object
{
	// Fields

	private string <AdUnitIdentifier>k__BackingField; // 0x10
	private string <AdFormat>k__BackingField; // 0x18
	private string <NetworkName>k__BackingField; // 0x20
	private string <NetworkPlacement>k__BackingField; // 0x28
	private string <Placement>k__BackingField; // 0x30
	private string <CreativeIdentifier>k__BackingField; // 0x38
	private double <Revenue>k__BackingField; // 0x40
	private string <RevenuePrecision>k__BackingField; // 0x48
	private WaterfallInfo <WaterfallInfo>k__BackingField; // 0x50
	private string <DspName>k__BackingField; // 0x58

	// Properties

	public string AdUnitIdentifier { get; set; }
	public string AdFormat { get; set; }
	public string NetworkName { get; set; }
	public string NetworkPlacement { get; set; }
	public string Placement { get; set; }
	public string CreativeIdentifier { get; set; }
	public double Revenue { get; set; }
	public string RevenuePrecision { get; set; }
	public WaterfallInfo WaterfallInfo { get; set; }
	public string DspName { get; set; }

	// Methods

	// RVA: 0x6CF6541A9C Offset: 0x14EAA9C VA: 0x6CF6541A9C
	public string get_AdUnitIdentifier() { }

	// RVA: 0x6CF6541AA4 Offset: 0x14EAAA4 VA: 0x6CF6541AA4
	private void set_AdUnitIdentifier(string value) { }

	// RVA: 0x6CF6541AAC Offset: 0x14EAAAC VA: 0x6CF6541AAC
	public string get_AdFormat() { }

	// RVA: 0x6CF6541AB4 Offset: 0x14EAAB4 VA: 0x6CF6541AB4
	private void set_AdFormat(string value) { }

	// RVA: 0x6CF6541ABC Offset: 0x14EAABC VA: 0x6CF6541ABC
	public string get_NetworkName() { }

	// RVA: 0x6CF6541AC4 Offset: 0x14EAAC4 VA: 0x6CF6541AC4
	private void set_NetworkName(string value) { }

	// RVA: 0x6CF6541ACC Offset: 0x14EAACC VA: 0x6CF6541ACC
	public string get_NetworkPlacement() { }

	// RVA: 0x6CF6541AD4 Offset: 0x14EAAD4 VA: 0x6CF6541AD4
	private void set_NetworkPlacement(string value) { }

	// RVA: 0x6CF6541ADC Offset: 0x14EAADC VA: 0x6CF6541ADC
	public string get_Placement() { }

	// RVA: 0x6CF6541AE4 Offset: 0x14EAAE4 VA: 0x6CF6541AE4
	private void set_Placement(string value) { }

	// RVA: 0x6CF6541AEC Offset: 0x14EAAEC VA: 0x6CF6541AEC
	public string get_CreativeIdentifier() { }

	// RVA: 0x6CF6541AF4 Offset: 0x14EAAF4 VA: 0x6CF6541AF4
	private void set_CreativeIdentifier(string value) { }

	// RVA: 0x6CF6541AFC Offset: 0x14EAAFC VA: 0x6CF6541AFC
	public double get_Revenue() { }

	// RVA: 0x6CF6541B04 Offset: 0x14EAB04 VA: 0x6CF6541B04
	private void set_Revenue(double value) { }

	// RVA: 0x6CF6541B0C Offset: 0x14EAB0C VA: 0x6CF6541B0C
	public string get_RevenuePrecision() { }

	// RVA: 0x6CF6541B14 Offset: 0x14EAB14 VA: 0x6CF6541B14
	private void set_RevenuePrecision(string value) { }

	// RVA: 0x6CF6541B1C Offset: 0x14EAB1C VA: 0x6CF6541B1C
	public WaterfallInfo get_WaterfallInfo() { }

	// RVA: 0x6CF6541B24 Offset: 0x14EAB24 VA: 0x6CF6541B24
	private void set_WaterfallInfo(WaterfallInfo value) { }

	// RVA: 0x6CF6541B2C Offset: 0x14EAB2C VA: 0x6CF6541B2C
	public string get_DspName() { }

	// RVA: 0x6CF6541B34 Offset: 0x14EAB34 VA: 0x6CF6541B34
	private void set_DspName(string value) { }

	// RVA: 0x6CF653F80C Offset: 0x14E880C VA: 0x6CF653F80C
	public void .ctor(IDictionary`2 adInfoDictionary) { }

	// RVA: 0x6CF654215C Offset: 0x14EB15C VA: 0x6CF654215C
	public override string ToString() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
[Serializable]
private sealed class <>c : Object
{
	// Fields

	public static readonly <>c <>9; // 0x0
	public static Func`2 <>9__17_0; // 0x8

	// Properties


	// Methods

	// RVA: 0x6CF6542B48 Offset: 0x14EBB48 VA: 0x6CF6542B48
	private static void .cctor() { }

	// RVA: 0x6CF6542BA4 Offset: 0x14EBBA4 VA: 0x6CF6542BA4
	public void .ctor() { }

	// RVA: 0x6CF6542BAC Offset: 0x14EBBAC VA: 0x6CF6542BAC
	internal string <ToString>b__17_0(NetworkResponseInfo networkResponseInfo) { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class WaterfallInfo : Object
{
	// Fields

	private string <Name>k__BackingField; // 0x10
	private string <TestName>k__BackingField; // 0x18
	private List`1 <NetworkResponses>k__BackingField; // 0x20
	private long <LatencyMillis>k__BackingField; // 0x28

	// Properties

	public string Name { get; set; }
	public string TestName { get; set; }
	public List`1 NetworkResponses { get; set; }
	public long LatencyMillis { get; set; }

	// Methods

	// RVA: 0x6CF65423D8 Offset: 0x14EB3D8 VA: 0x6CF65423D8
	public string get_Name() { }

	// RVA: 0x6CF65423E0 Offset: 0x14EB3E0 VA: 0x6CF65423E0
	private void set_Name(string value) { }

	// RVA: 0x6CF65423E8 Offset: 0x14EB3E8 VA: 0x6CF65423E8
	public string get_TestName() { }

	// RVA: 0x6CF65423F0 Offset: 0x14EB3F0 VA: 0x6CF65423F0
	private void set_TestName(string value) { }

	// RVA: 0x6CF65423F8 Offset: 0x14EB3F8 VA: 0x6CF65423F8
	public List`1 get_NetworkResponses() { }

	// RVA: 0x6CF6542400 Offset: 0x14EB400 VA: 0x6CF6542400
	private void set_NetworkResponses(List`1 value) { }

	// RVA: 0x6CF6542408 Offset: 0x14EB408 VA: 0x6CF6542408
	public long get_LatencyMillis() { }

	// RVA: 0x6CF6542410 Offset: 0x14EB410 VA: 0x6CF6542410
	private void set_LatencyMillis(long value) { }

	// RVA: 0x6CF6541DA4 Offset: 0x14EADA4 VA: 0x6CF6541DA4
	public void .ctor(IDictionary`2 waterfallInfoDict) { }

	// RVA: 0x6CF65428B8 Offset: 0x14EB8B8 VA: 0x6CF65428B8
	public override string ToString() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
[Serializable]
private sealed class <>c : Object
{
	// Fields

	public static readonly <>c <>9; // 0x0
	public static Func`2 <>9__25_0; // 0x8

	// Properties


	// Methods

	// RVA: 0x6CF6543254 Offset: 0x14EC254 VA: 0x6CF6543254
	private static void .cctor() { }

	// RVA: 0x6CF65432B0 Offset: 0x14EC2B0 VA: 0x6CF65432B0
	public void .ctor() { }

	// RVA: 0x6CF65432B8 Offset: 0x14EC2B8 VA: 0x6CF65432B8
	internal string <ToString>b__25_0(KeyValuePair`2 keyValuePair) { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class NetworkResponseInfo : Object
{
	// Fields

	private MaxAdLoadState <AdLoadState>k__BackingField; // 0x10
	private MediatedNetworkInfo <MediatedNetwork>k__BackingField; // 0x18
	private Dictionary`2 <Credentials>k__BackingField; // 0x20
	private bool <IsBidding>k__BackingField; // 0x28
	private long <LatencyMillis>k__BackingField; // 0x30
	private ErrorInfo <Error>k__BackingField; // 0x38

	// Properties

	public MaxAdLoadState AdLoadState { get; set; }
	public MediatedNetworkInfo MediatedNetwork { get; set; }
	public Dictionary`2 Credentials { get; set; }
	public bool IsBidding { get; set; }
	public long LatencyMillis { get; set; }
	public ErrorInfo Error { get; set; }

	// Methods

	// RVA: 0x6CF6542BD0 Offset: 0x14EBBD0 VA: 0x6CF6542BD0
	public MaxAdLoadState get_AdLoadState() { }

	// RVA: 0x6CF6542BD8 Offset: 0x14EBBD8 VA: 0x6CF6542BD8
	private void set_AdLoadState(MaxAdLoadState value) { }

	// RVA: 0x6CF6542BE0 Offset: 0x14EBBE0 VA: 0x6CF6542BE0
	public MediatedNetworkInfo get_MediatedNetwork() { }

	// RVA: 0x6CF6542BE8 Offset: 0x14EBBE8 VA: 0x6CF6542BE8
	private void set_MediatedNetwork(MediatedNetworkInfo value) { }

	// RVA: 0x6CF6542BF0 Offset: 0x14EBBF0 VA: 0x6CF6542BF0
	public Dictionary`2 get_Credentials() { }

	// RVA: 0x6CF6542BF8 Offset: 0x14EBBF8 VA: 0x6CF6542BF8
	private void set_Credentials(Dictionary`2 value) { }

	// RVA: 0x6CF6542C00 Offset: 0x14EBC00 VA: 0x6CF6542C00
	public bool get_IsBidding() { }

	// RVA: 0x6CF6542C08 Offset: 0x14EBC08 VA: 0x6CF6542C08
	private void set_IsBidding(bool value) { }

	// RVA: 0x6CF6542C14 Offset: 0x14EBC14 VA: 0x6CF6542C14
	public long get_LatencyMillis() { }

	// RVA: 0x6CF6542C1C Offset: 0x14EBC1C VA: 0x6CF6542C1C
	private void set_LatencyMillis(long value) { }

	// RVA: 0x6CF6542C24 Offset: 0x14EBC24 VA: 0x6CF6542C24
	public ErrorInfo get_Error() { }

	// RVA: 0x6CF6542C2C Offset: 0x14EBC2C VA: 0x6CF6542C2C
	private void set_Error(ErrorInfo value) { }

	// RVA: 0x6CF6542524 Offset: 0x14EB524 VA: 0x6CF6542524
	public void .ctor(IDictionary`2 networkResponseInfoDict) { }

	// RVA: 0x6CF6542F50 Offset: 0x14EBF50 VA: 0x6CF6542F50
	public override string ToString() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class MediatedNetworkInfo : Object
{
	// Fields

	private string <Name>k__BackingField; // 0x10
	private string <AdapterClassName>k__BackingField; // 0x18
	private string <AdapterVersion>k__BackingField; // 0x20
	private string <SdkVersion>k__BackingField; // 0x28

	// Properties

	public string Name { get; set; }
	public string AdapterClassName { get; set; }
	public string AdapterVersion { get; set; }
	public string SdkVersion { get; set; }

	// Methods

	// RVA: 0x6CF654330C Offset: 0x14EC30C VA: 0x6CF654330C
	public string get_Name() { }

	// RVA: 0x6CF6543314 Offset: 0x14EC314 VA: 0x6CF6543314
	private void set_Name(string value) { }

	// RVA: 0x6CF654331C Offset: 0x14EC31C VA: 0x6CF654331C
	public string get_AdapterClassName() { }

	// RVA: 0x6CF6543324 Offset: 0x14EC324 VA: 0x6CF6543324
	private void set_AdapterClassName(string value) { }

	// RVA: 0x6CF654332C Offset: 0x14EC32C VA: 0x6CF654332C
	public string get_AdapterVersion() { }

	// RVA: 0x6CF6543334 Offset: 0x14EC334 VA: 0x6CF6543334
	private void set_AdapterVersion(string value) { }

	// RVA: 0x6CF654333C Offset: 0x14EC33C VA: 0x6CF654333C
	public string get_SdkVersion() { }

	// RVA: 0x6CF6543344 Offset: 0x14EC344 VA: 0x6CF6543344
	private void set_SdkVersion(string value) { }

	// RVA: 0x6CF6542C34 Offset: 0x14EBC34 VA: 0x6CF6542C34
	public void .ctor(IDictionary`2 mediatedNetworkDictionary) { }

	// RVA: 0x6CF654334C Offset: 0x14EC34C VA: 0x6CF654334C
	public override string ToString() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class ErrorInfo : Object
{
	// Fields

	private ErrorCode <Code>k__BackingField; // 0x10
	private string <Message>k__BackingField; // 0x18
	private int <MediatedNetworkErrorCode>k__BackingField; // 0x20
	private string <MediatedNetworkErrorMessage>k__BackingField; // 0x28
	private string <AdLoadFailureInfo>k__BackingField; // 0x30
	private WaterfallInfo <WaterfallInfo>k__BackingField; // 0x38

	// Properties

	public ErrorCode Code { get; set; }
	public string Message { get; set; }
	public int MediatedNetworkErrorCode { get; set; }
	public string MediatedNetworkErrorMessage { get; set; }
	public string AdLoadFailureInfo { get; set; }
	public WaterfallInfo WaterfallInfo { get; set; }

	// Methods

	// RVA: 0x6CF654349C Offset: 0x14EC49C VA: 0x6CF654349C
	public ErrorCode get_Code() { }

	// RVA: 0x6CF65434A4 Offset: 0x14EC4A4 VA: 0x6CF65434A4
	private void set_Code(ErrorCode value) { }

	// RVA: 0x6CF65434AC Offset: 0x14EC4AC VA: 0x6CF65434AC
	public string get_Message() { }

	// RVA: 0x6CF65434B4 Offset: 0x14EC4B4 VA: 0x6CF65434B4
	private void set_Message(string value) { }

	// RVA: 0x6CF65434BC Offset: 0x14EC4BC VA: 0x6CF65434BC
	public int get_MediatedNetworkErrorCode() { }

	// RVA: 0x6CF65434C4 Offset: 0x14EC4C4 VA: 0x6CF65434C4
	private void set_MediatedNetworkErrorCode(int value) { }

	// RVA: 0x6CF65434CC Offset: 0x14EC4CC VA: 0x6CF65434CC
	public string get_MediatedNetworkErrorMessage() { }

	// RVA: 0x6CF65434D4 Offset: 0x14EC4D4 VA: 0x6CF65434D4
	private void set_MediatedNetworkErrorMessage(string value) { }

	// RVA: 0x6CF65434DC Offset: 0x14EC4DC VA: 0x6CF65434DC
	public string get_AdLoadFailureInfo() { }

	// RVA: 0x6CF65434E4 Offset: 0x14EC4E4 VA: 0x6CF65434E4
	private void set_AdLoadFailureInfo(string value) { }

	// RVA: 0x6CF65434EC Offset: 0x14EC4EC VA: 0x6CF65434EC
	public WaterfallInfo get_WaterfallInfo() { }

	// RVA: 0x6CF65434F4 Offset: 0x14EC4F4 VA: 0x6CF65434F4
	private void set_WaterfallInfo(WaterfallInfo value) { }

	// RVA: 0x6CF6542D60 Offset: 0x14EBD60 VA: 0x6CF6542D60
	public void .ctor(IDictionary`2 errorInfoDictionary) { }

	// RVA: 0x6CF65434FC Offset: 0x14EC4FC VA: 0x6CF65434FC
	public override string ToString() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public enum ConsentDialogState
{
	// Fields

	public int value__; // 0x10
	public const ConsentDialogState Unknown = 0; // 0x0
	public const ConsentDialogState Applies = 1; // 0x0
	public const ConsentDialogState DoesNotApply = 2; // 0x0

	// Properties


	// Methods

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public abstract class MaxSdkBase : Object
{
	// Fields

	protected static readonly MaxUserSegment SharedUserSegment; // 0x0
	protected static readonly MaxTargetingData SharedTargetingData; // 0x8

	// Properties

	public static MaxCmpService CmpService { get; }

	// Methods

	// RVA: 0x6CF653FD08 Offset: 0x14E8D08 VA: 0x6CF653FD08
	public static MaxCmpService get_CmpService() { }

	// RVA: 0x6CF65388D0 Offset: 0x14E18D0 VA: 0x6CF65388D0
	protected static void ValidateAdUnitIdentifier(string adUnitIdentifier, string debugPurpose) { }

	// RVA: 0x6CF6536D88 Offset: 0x14DFD88 VA: 0x6CF6536D88
	protected static void InitCallbacks() { }

	// RVA: 0x6CF6537244 Offset: 0x14E0244 VA: 0x6CF6537244
	protected static string GenerateMetaData() { }

	// RVA: 0x6CF653A540 Offset: 0x14E3540 VA: 0x6CF653A540
	protected static Rect GetRectFromString(string rectPropString) { }

	// RVA: 0x6CF653FAF8 Offset: 0x14E8AF8 VA: 0x6CF653FAF8
	protected static void HandleBackgroundCallback(string propsStr) { }

	// RVA: 0x6CF653A128 Offset: 0x14E3128 VA: 0x6CF653A128
	protected static string SerializeLocalExtraParameterValue(object value) { }

	// RVA: 0x6CF653FA9C Offset: 0x14E8A9C VA: 0x6CF653FA9C
	protected void .ctor() { }

	// RVA: 0x6CF654179C Offset: 0x14EA79C VA: 0x6CF654179C
	private static void .cctor() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
internal static class AdPositionExtenstion : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6538940 Offset: 0x14E1940 VA: 0x6CF6538940
	public static string ToSnakeCaseString(BannerPosition position) { }

	// RVA: 0x6CF653A824 Offset: 0x14E3824 VA: 0x6CF653A824
	public static string ToSnakeCaseString(AdViewPosition position) { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class Interstitial : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF65468E0 Offset: 0x14EF8E0 VA: 0x6CF65468E0
	public static void add_OnAdLoadedEvent(Action`2 value) { }

	// RVA: 0x6CF65469C0 Offset: 0x14EF9C0 VA: 0x6CF65469C0
	public static void remove_OnAdLoadedEvent(Action`2 value) { }

	// RVA: 0x6CF6546AA0 Offset: 0x14EFAA0 VA: 0x6CF6546AA0
	public static void add_OnAdLoadFailedEvent(Action`2 value) { }

	// RVA: 0x6CF6546B80 Offset: 0x14EFB80 VA: 0x6CF6546B80
	public static void remove_OnAdLoadFailedEvent(Action`2 value) { }

	// RVA: 0x6CF6546C60 Offset: 0x14EFC60 VA: 0x6CF6546C60
	public static void add_OnAdDisplayedEvent(Action`2 value) { }

	// RVA: 0x6CF6546D40 Offset: 0x14EFD40 VA: 0x6CF6546D40
	public static void remove_OnAdDisplayedEvent(Action`2 value) { }

	// RVA: 0x6CF6546E20 Offset: 0x14EFE20 VA: 0x6CF6546E20
	public static void add_OnAdDisplayFailedEvent(Action`3 value) { }

	// RVA: 0x6CF6546F00 Offset: 0x14EFF00 VA: 0x6CF6546F00
	public static void remove_OnAdDisplayFailedEvent(Action`3 value) { }

	// RVA: 0x6CF6546FE0 Offset: 0x14EFFE0 VA: 0x6CF6546FE0
	public static void add_OnAdClickedEvent(Action`2 value) { }

	// RVA: 0x6CF65470C0 Offset: 0x14F00C0 VA: 0x6CF65470C0
	public static void remove_OnAdClickedEvent(Action`2 value) { }

	// RVA: 0x6CF65471A0 Offset: 0x14F01A0 VA: 0x6CF65471A0
	public static void add_OnAdRevenuePaidEvent(Action`2 value) { }

	// RVA: 0x6CF6547280 Offset: 0x14F0280 VA: 0x6CF6547280
	public static void remove_OnAdRevenuePaidEvent(Action`2 value) { }

	// RVA: 0x6CF6547360 Offset: 0x14F0360 VA: 0x6CF6547360
	public static void add_OnAdReviewCreativeIdGeneratedEvent(Action`3 value) { }

	// RVA: 0x6CF6547440 Offset: 0x14F0440 VA: 0x6CF6547440
	public static void remove_OnAdReviewCreativeIdGeneratedEvent(Action`3 value) { }

	// RVA: 0x6CF6547520 Offset: 0x14F0520 VA: 0x6CF6547520
	public static void add_OnAdHiddenEvent(Action`2 value) { }

	// RVA: 0x6CF6547600 Offset: 0x14F0600 VA: 0x6CF6547600
	public static void remove_OnAdHiddenEvent(Action`2 value) { }

	// RVA: 0x6CF65476E0 Offset: 0x14F06E0 VA: 0x6CF65476E0
	public void .ctor() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class AppOpen : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF65476E8 Offset: 0x14F06E8 VA: 0x6CF65476E8
	public static void add_OnAdLoadedEvent(Action`2 value) { }

	// RVA: 0x6CF65477C8 Offset: 0x14F07C8 VA: 0x6CF65477C8
	public static void remove_OnAdLoadedEvent(Action`2 value) { }

	// RVA: 0x6CF65478A8 Offset: 0x14F08A8 VA: 0x6CF65478A8
	public static void add_OnAdLoadFailedEvent(Action`2 value) { }

	// RVA: 0x6CF6547988 Offset: 0x14F0988 VA: 0x6CF6547988
	public static void remove_OnAdLoadFailedEvent(Action`2 value) { }

	// RVA: 0x6CF6547A68 Offset: 0x14F0A68 VA: 0x6CF6547A68
	public static void add_OnAdDisplayedEvent(Action`2 value) { }

	// RVA: 0x6CF6547B48 Offset: 0x14F0B48 VA: 0x6CF6547B48
	public static void remove_OnAdDisplayedEvent(Action`2 value) { }

	// RVA: 0x6CF6547C28 Offset: 0x14F0C28 VA: 0x6CF6547C28
	public static void add_OnAdDisplayFailedEvent(Action`3 value) { }

	// RVA: 0x6CF6547D08 Offset: 0x14F0D08 VA: 0x6CF6547D08
	public static void remove_OnAdDisplayFailedEvent(Action`3 value) { }

	// RVA: 0x6CF6547DE8 Offset: 0x14F0DE8 VA: 0x6CF6547DE8
	public static void add_OnAdClickedEvent(Action`2 value) { }

	// RVA: 0x6CF6547EC8 Offset: 0x14F0EC8 VA: 0x6CF6547EC8
	public static void remove_OnAdClickedEvent(Action`2 value) { }

	// RVA: 0x6CF6547FA8 Offset: 0x14F0FA8 VA: 0x6CF6547FA8
	public static void add_OnAdRevenuePaidEvent(Action`2 value) { }

	// RVA: 0x6CF6548088 Offset: 0x14F1088 VA: 0x6CF6548088
	public static void remove_OnAdRevenuePaidEvent(Action`2 value) { }

	// RVA: 0x6CF6548168 Offset: 0x14F1168 VA: 0x6CF6548168
	public static void add_OnAdHiddenEvent(Action`2 value) { }

	// RVA: 0x6CF6548248 Offset: 0x14F1248 VA: 0x6CF6548248
	public static void remove_OnAdHiddenEvent(Action`2 value) { }

	// RVA: 0x6CF6548328 Offset: 0x14F1328 VA: 0x6CF6548328
	public void .ctor() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class Rewarded : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6548330 Offset: 0x14F1330 VA: 0x6CF6548330
	public static void add_OnAdLoadedEvent(Action`2 value) { }

	// RVA: 0x6CF6548410 Offset: 0x14F1410 VA: 0x6CF6548410
	public static void remove_OnAdLoadedEvent(Action`2 value) { }

	// RVA: 0x6CF65484F0 Offset: 0x14F14F0 VA: 0x6CF65484F0
	public static void add_OnAdLoadFailedEvent(Action`2 value) { }

	// RVA: 0x6CF65485D0 Offset: 0x14F15D0 VA: 0x6CF65485D0
	public static void remove_OnAdLoadFailedEvent(Action`2 value) { }

	// RVA: 0x6CF65486B0 Offset: 0x14F16B0 VA: 0x6CF65486B0
	public static void add_OnAdDisplayedEvent(Action`2 value) { }

	// RVA: 0x6CF6548790 Offset: 0x14F1790 VA: 0x6CF6548790
	public static void remove_OnAdDisplayedEvent(Action`2 value) { }

	// RVA: 0x6CF6548870 Offset: 0x14F1870 VA: 0x6CF6548870
	public static void add_OnAdDisplayFailedEvent(Action`3 value) { }

	// RVA: 0x6CF6548950 Offset: 0x14F1950 VA: 0x6CF6548950
	public static void remove_OnAdDisplayFailedEvent(Action`3 value) { }

	// RVA: 0x6CF6548A30 Offset: 0x14F1A30 VA: 0x6CF6548A30
	public static void add_OnAdClickedEvent(Action`2 value) { }

	// RVA: 0x6CF6548B10 Offset: 0x14F1B10 VA: 0x6CF6548B10
	public static void remove_OnAdClickedEvent(Action`2 value) { }

	// RVA: 0x6CF6548BF0 Offset: 0x14F1BF0 VA: 0x6CF6548BF0
	public static void add_OnAdRevenuePaidEvent(Action`2 value) { }

	// RVA: 0x6CF6548CD0 Offset: 0x14F1CD0 VA: 0x6CF6548CD0
	public static void remove_OnAdRevenuePaidEvent(Action`2 value) { }

	// RVA: 0x6CF6548DB0 Offset: 0x14F1DB0 VA: 0x6CF6548DB0
	public static void add_OnAdReviewCreativeIdGeneratedEvent(Action`3 value) { }

	// RVA: 0x6CF6548E90 Offset: 0x14F1E90 VA: 0x6CF6548E90
	public static void remove_OnAdReviewCreativeIdGeneratedEvent(Action`3 value) { }

	// RVA: 0x6CF6548F70 Offset: 0x14F1F70 VA: 0x6CF6548F70
	public static void add_OnAdReceivedRewardEvent(Action`3 value) { }

	// RVA: 0x6CF6549050 Offset: 0x14F2050 VA: 0x6CF6549050
	public static void remove_OnAdReceivedRewardEvent(Action`3 value) { }

	// RVA: 0x6CF6549130 Offset: 0x14F2130 VA: 0x6CF6549130
	public static void add_OnAdHiddenEvent(Action`2 value) { }

	// RVA: 0x6CF6549210 Offset: 0x14F2210 VA: 0x6CF6549210
	public static void remove_OnAdHiddenEvent(Action`2 value) { }

	// RVA: 0x6CF65492F0 Offset: 0x14F22F0 VA: 0x6CF65492F0
	public void .ctor() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class RewardedInterstitial : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF65492F8 Offset: 0x14F22F8 VA: 0x6CF65492F8
	public static void add_OnAdLoadedEvent(Action`2 value) { }

	// RVA: 0x6CF65493D8 Offset: 0x14F23D8 VA: 0x6CF65493D8
	public static void remove_OnAdLoadedEvent(Action`2 value) { }

	// RVA: 0x6CF65494B8 Offset: 0x14F24B8 VA: 0x6CF65494B8
	public static void add_OnAdLoadFailedEvent(Action`2 value) { }

	// RVA: 0x6CF6549598 Offset: 0x14F2598 VA: 0x6CF6549598
	public static void remove_OnAdLoadFailedEvent(Action`2 value) { }

	// RVA: 0x6CF6549678 Offset: 0x14F2678 VA: 0x6CF6549678
	public static void add_OnAdDisplayedEvent(Action`2 value) { }

	// RVA: 0x6CF6549758 Offset: 0x14F2758 VA: 0x6CF6549758
	public static void remove_OnAdDisplayedEvent(Action`2 value) { }

	// RVA: 0x6CF6549838 Offset: 0x14F2838 VA: 0x6CF6549838
	public static void add_OnAdDisplayFailedEvent(Action`3 value) { }

	// RVA: 0x6CF6549918 Offset: 0x14F2918 VA: 0x6CF6549918
	public static void remove_OnAdDisplayFailedEvent(Action`3 value) { }

	// RVA: 0x6CF65499F8 Offset: 0x14F29F8 VA: 0x6CF65499F8
	public static void add_OnAdClickedEvent(Action`2 value) { }

	// RVA: 0x6CF6549AD8 Offset: 0x14F2AD8 VA: 0x6CF6549AD8
	public static void remove_OnAdClickedEvent(Action`2 value) { }

	// RVA: 0x6CF6549BB8 Offset: 0x14F2BB8 VA: 0x6CF6549BB8
	public static void add_OnAdRevenuePaidEvent(Action`2 value) { }

	// RVA: 0x6CF6549C98 Offset: 0x14F2C98 VA: 0x6CF6549C98
	public static void remove_OnAdRevenuePaidEvent(Action`2 value) { }

	// RVA: 0x6CF6549D78 Offset: 0x14F2D78 VA: 0x6CF6549D78
	public static void add_OnAdReviewCreativeIdGeneratedEvent(Action`3 value) { }

	// RVA: 0x6CF6549E58 Offset: 0x14F2E58 VA: 0x6CF6549E58
	public static void remove_OnAdReviewCreativeIdGeneratedEvent(Action`3 value) { }

	// RVA: 0x6CF6549F38 Offset: 0x14F2F38 VA: 0x6CF6549F38
	public static void add_OnAdReceivedRewardEvent(Action`3 value) { }

	// RVA: 0x6CF654A018 Offset: 0x14F3018 VA: 0x6CF654A018
	public static void remove_OnAdReceivedRewardEvent(Action`3 value) { }

	// RVA: 0x6CF654A0F8 Offset: 0x14F30F8 VA: 0x6CF654A0F8
	public static void add_OnAdHiddenEvent(Action`2 value) { }

	// RVA: 0x6CF654A1D8 Offset: 0x14F31D8 VA: 0x6CF654A1D8
	public static void remove_OnAdHiddenEvent(Action`2 value) { }

	// RVA: 0x6CF654A2B8 Offset: 0x14F32B8 VA: 0x6CF654A2B8
	public void .ctor() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class Banner : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF654A2C0 Offset: 0x14F32C0 VA: 0x6CF654A2C0
	public static void add_OnAdLoadedEvent(Action`2 value) { }

	// RVA: 0x6CF654A3A0 Offset: 0x14F33A0 VA: 0x6CF654A3A0
	public static void remove_OnAdLoadedEvent(Action`2 value) { }

	// RVA: 0x6CF654A480 Offset: 0x14F3480 VA: 0x6CF654A480
	public static void add_OnAdLoadFailedEvent(Action`2 value) { }

	// RVA: 0x6CF654A560 Offset: 0x14F3560 VA: 0x6CF654A560
	public static void remove_OnAdLoadFailedEvent(Action`2 value) { }

	// RVA: 0x6CF654A640 Offset: 0x14F3640 VA: 0x6CF654A640
	public static void add_OnAdClickedEvent(Action`2 value) { }

	// RVA: 0x6CF654A720 Offset: 0x14F3720 VA: 0x6CF654A720
	public static void remove_OnAdClickedEvent(Action`2 value) { }

	// RVA: 0x6CF654A800 Offset: 0x14F3800 VA: 0x6CF654A800
	public static void add_OnAdRevenuePaidEvent(Action`2 value) { }

	// RVA: 0x6CF654A8E0 Offset: 0x14F38E0 VA: 0x6CF654A8E0
	public static void remove_OnAdRevenuePaidEvent(Action`2 value) { }

	// RVA: 0x6CF654A9C0 Offset: 0x14F39C0 VA: 0x6CF654A9C0
	public static void add_OnAdReviewCreativeIdGeneratedEvent(Action`3 value) { }

	// RVA: 0x6CF654AAA0 Offset: 0x14F3AA0 VA: 0x6CF654AAA0
	public static void remove_OnAdReviewCreativeIdGeneratedEvent(Action`3 value) { }

	// RVA: 0x6CF654AB80 Offset: 0x14F3B80 VA: 0x6CF654AB80
	public static void add_OnAdExpandedEvent(Action`2 value) { }

	// RVA: 0x6CF654AC60 Offset: 0x14F3C60 VA: 0x6CF654AC60
	public static void remove_OnAdExpandedEvent(Action`2 value) { }

	// RVA: 0x6CF654AD40 Offset: 0x14F3D40 VA: 0x6CF654AD40
	public static void add_OnAdCollapsedEvent(Action`2 value) { }

	// RVA: 0x6CF654AE20 Offset: 0x14F3E20 VA: 0x6CF654AE20
	public static void remove_OnAdCollapsedEvent(Action`2 value) { }

	// RVA: 0x6CF654AF00 Offset: 0x14F3F00 VA: 0x6CF654AF00
	public void .ctor() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class MRec : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF654AF08 Offset: 0x14F3F08 VA: 0x6CF654AF08
	public static void add_OnAdLoadedEvent(Action`2 value) { }

	// RVA: 0x6CF654AFE8 Offset: 0x14F3FE8 VA: 0x6CF654AFE8
	public static void remove_OnAdLoadedEvent(Action`2 value) { }

	// RVA: 0x6CF654B0C8 Offset: 0x14F40C8 VA: 0x6CF654B0C8
	public static void add_OnAdLoadFailedEvent(Action`2 value) { }

	// RVA: 0x6CF654B1A8 Offset: 0x14F41A8 VA: 0x6CF654B1A8
	public static void remove_OnAdLoadFailedEvent(Action`2 value) { }

	// RVA: 0x6CF654B288 Offset: 0x14F4288 VA: 0x6CF654B288
	public static void add_OnAdClickedEvent(Action`2 value) { }

	// RVA: 0x6CF654B368 Offset: 0x14F4368 VA: 0x6CF654B368
	public static void remove_OnAdClickedEvent(Action`2 value) { }

	// RVA: 0x6CF654B448 Offset: 0x14F4448 VA: 0x6CF654B448
	public static void add_OnAdRevenuePaidEvent(Action`2 value) { }

	// RVA: 0x6CF654B528 Offset: 0x14F4528 VA: 0x6CF654B528
	public static void remove_OnAdRevenuePaidEvent(Action`2 value) { }

	// RVA: 0x6CF654B608 Offset: 0x14F4608 VA: 0x6CF654B608
	public static void add_OnAdReviewCreativeIdGeneratedEvent(Action`3 value) { }

	// RVA: 0x6CF654B6E8 Offset: 0x14F46E8 VA: 0x6CF654B6E8
	public static void remove_OnAdReviewCreativeIdGeneratedEvent(Action`3 value) { }

	// RVA: 0x6CF654B7C8 Offset: 0x14F47C8 VA: 0x6CF654B7C8
	public static void add_OnAdExpandedEvent(Action`2 value) { }

	// RVA: 0x6CF654B8A8 Offset: 0x14F48A8 VA: 0x6CF654B8A8
	public static void remove_OnAdExpandedEvent(Action`2 value) { }

	// RVA: 0x6CF654B988 Offset: 0x14F4988 VA: 0x6CF654B988
	public static void add_OnAdCollapsedEvent(Action`2 value) { }

	// RVA: 0x6CF654BA68 Offset: 0x14F4A68 VA: 0x6CF654BA68
	public static void remove_OnAdCollapsedEvent(Action`2 value) { }

	// RVA: 0x6CF654BB48 Offset: 0x14F4B48 VA: 0x6CF654BB48
	public void .ctor() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class MaxSdkCallbacks : MonoBehaviour
{
	// Fields

	private static MaxSdkCallbacks <Instance>k__BackingField; // 0x0
	private static Action`1 _onSdkInitializedEvent; // 0x8
	private static Action _onSdkConsentDialogDismissedEvent; // 0x10
	private static Action`2 _onInterstitialAdLoadedEventV2; // 0x18
	private static Action`2 _onInterstitialAdLoadFailedEventV2; // 0x20
	private static Action`2 _onInterstitialAdDisplayedEventV2; // 0x28
	private static Action`3 _onInterstitialAdFailedToDisplayEventV2; // 0x30
	private static Action`2 _onInterstitialAdClickedEventV2; // 0x38
	private static Action`2 _onInterstitialAdRevenuePaidEvent; // 0x40
	private static Action`3 _onInterstitialAdReviewCreativeIdGeneratedEvent; // 0x48
	private static Action`2 _onInterstitialAdHiddenEventV2; // 0x50
	private static Action`2 _onAppOpenAdLoadedEvent; // 0x58
	private static Action`2 _onAppOpenAdLoadFailedEvent; // 0x60
	private static Action`2 _onAppOpenAdDisplayedEvent; // 0x68
	private static Action`3 _onAppOpenAdFailedToDisplayEvent; // 0x70
	private static Action`2 _onAppOpenAdClickedEvent; // 0x78
	private static Action`2 _onAppOpenAdRevenuePaidEvent; // 0x80
	private static Action`2 _onAppOpenAdHiddenEvent; // 0x88
	private static Action`2 _onRewardedAdLoadedEventV2; // 0x90
	private static Action`2 _onRewardedAdLoadFailedEventV2; // 0x98
	private static Action`2 _onRewardedAdDisplayedEventV2; // 0xA0
	private static Action`3 _onRewardedAdFailedToDisplayEventV2; // 0xA8
	private static Action`2 _onRewardedAdClickedEventV2; // 0xB0
	private static Action`2 _onRewardedAdRevenuePaidEvent; // 0xB8
	private static Action`3 _onRewardedAdReviewCreativeIdGeneratedEvent; // 0xC0
	private static Action`3 _onRewardedAdReceivedRewardEventV2; // 0xC8
	private static Action`2 _onRewardedAdHiddenEventV2; // 0xD0
	private static Action`2 _onRewardedInterstitialAdLoadedEvent; // 0xD8
	private static Action`2 _onRewardedInterstitialAdLoadFailedEvent; // 0xE0
	private static Action`2 _onRewardedInterstitialAdDisplayedEvent; // 0xE8
	private static Action`3 _onRewardedInterstitialAdFailedToDisplayEvent; // 0xF0
	private static Action`2 _onRewardedInterstitialAdClickedEvent; // 0xF8
	private static Action`2 _onRewardedInterstitialAdRevenuePaidEvent; // 0x100
	private static Action`3 _onRewardedInterstitialAdReviewCreativeIdGeneratedEvent; // 0x108
	private static Action`3 _onRewardedInterstitialAdReceivedRewardEvent; // 0x110
	private static Action`2 _onRewardedInterstitialAdHiddenEvent; // 0x118
	private static Action`2 _onBannerAdLoadedEventV2; // 0x120
	private static Action`2 _onBannerAdLoadFailedEventV2; // 0x128
	private static Action`2 _onBannerAdClickedEventV2; // 0x130
	private static Action`2 _onBannerAdRevenuePaidEvent; // 0x138
	private static Action`3 _onBannerAdReviewCreativeIdGeneratedEvent; // 0x140
	private static Action`2 _onBannerAdExpandedEventV2; // 0x148
	private static Action`2 _onBannerAdCollapsedEventV2; // 0x150
	private static Action`2 _onMRecAdLoadedEventV2; // 0x158
	private static Action`2 _onMRecAdLoadFailedEventV2; // 0x160
	private static Action`2 _onMRecAdClickedEventV2; // 0x168
	private static Action`2 _onMRecAdRevenuePaidEvent; // 0x170
	private static Action`3 _onMRecAdReviewCreativeIdGeneratedEvent; // 0x178
	private static Action`2 _onMRecAdExpandedEventV2; // 0x180
	private static Action`2 _onMRecAdCollapsedEventV2; // 0x188
	private static Action`1 _onBannerAdLoadedEvent; // 0x190
	private static Action`2 _onBannerAdLoadFailedEvent; // 0x198
	private static Action`1 _onBannerAdClickedEvent; // 0x1A0
	private static Action`1 _onBannerAdExpandedEvent; // 0x1A8
	private static Action`1 _onBannerAdCollapsedEvent; // 0x1B0
	private static Action`1 _onMRecAdLoadedEvent; // 0x1B8
	private static Action`2 _onMRecAdLoadFailedEvent; // 0x1C0
	private static Action`1 _onMRecAdClickedEvent; // 0x1C8
	private static Action`1 _onMRecAdExpandedEvent; // 0x1D0
	private static Action`1 _onMRecAdCollapsedEvent; // 0x1D8
	private static Action`1 _onInterstitialAdLoadedEvent; // 0x1E0
	private static Action`2 _onInterstitialLoadFailedEvent; // 0x1E8
	private static Action`1 _onInterstitialAdDisplayedEvent; // 0x1F0
	private static Action`2 _onInterstitialAdFailedToDisplayEvent; // 0x1F8
	private static Action`1 _onInterstitialAdClickedEvent; // 0x200
	private static Action`1 _onInterstitialAdHiddenEvent; // 0x208
	private static Action`1 _onRewardedAdLoadedEvent; // 0x210
	private static Action`2 _onRewardedAdLoadFailedEvent; // 0x218
	private static Action`1 _onRewardedAdDisplayedEvent; // 0x220
	private static Action`2 _onRewardedAdFailedToDisplayEvent; // 0x228
	private static Action`1 _onRewardedAdClickedEvent; // 0x230
	private static Action`2 _onRewardedAdReceivedRewardEvent; // 0x238
	private static Action`1 _onRewardedAdHiddenEvent; // 0x240

	// Properties

	public static MaxSdkCallbacks Instance { get; set; }

	// Methods

	// RVA: 0x6CF65436D0 Offset: 0x14EC6D0 VA: 0x6CF65436D0
	public static MaxSdkCallbacks get_Instance() { }

	// RVA: 0x6CF6543718 Offset: 0x14EC718 VA: 0x6CF6543718
	private static void set_Instance(MaxSdkCallbacks value) { }

	// RVA: 0x6CF6543764 Offset: 0x14EC764 VA: 0x6CF6543764
	public static void add_OnSdkInitializedEvent(Action`1 value) { }

	// RVA: 0x6CF6543894 Offset: 0x14EC894 VA: 0x6CF6543894
	public static void remove_OnSdkInitializedEvent(Action`1 value) { }

	// RVA: 0x6CF65439C4 Offset: 0x14EC9C4 VA: 0x6CF65439C4
	public static void add_OnSdkConsentDialogDismissedEvent(Action value) { }

	// RVA: 0x6CF6543A90 Offset: 0x14ECA90 VA: 0x6CF6543A90
	public static void remove_OnSdkConsentDialogDismissedEvent(Action value) { }

	// RVA: 0x6CF6543B5C Offset: 0x14ECB5C VA: 0x6CF6543B5C
	public static void add_OnBannerAdLoadedEvent(Action`1 value) { }

	// RVA: 0x6CF6543C3C Offset: 0x14ECC3C VA: 0x6CF6543C3C
	public static void remove_OnBannerAdLoadedEvent(Action`1 value) { }

	// RVA: 0x6CF6543D1C Offset: 0x14ECD1C VA: 0x6CF6543D1C
	public static void add_OnBannerAdLoadFailedEvent(Action`2 value) { }

	// RVA: 0x6CF6543DFC Offset: 0x14ECDFC VA: 0x6CF6543DFC
	public static void remove_OnBannerAdLoadFailedEvent(Action`2 value) { }

	// RVA: 0x6CF6543EDC Offset: 0x14ECEDC VA: 0x6CF6543EDC
	public static void add_OnBannerAdClickedEvent(Action`1 value) { }

	// RVA: 0x6CF6543FBC Offset: 0x14ECFBC VA: 0x6CF6543FBC
	public static void remove_OnBannerAdClickedEvent(Action`1 value) { }

	// RVA: 0x6CF654409C Offset: 0x14ED09C VA: 0x6CF654409C
	public static void add_OnBannerAdExpandedEvent(Action`1 value) { }

	// RVA: 0x6CF654417C Offset: 0x14ED17C VA: 0x6CF654417C
	public static void remove_OnBannerAdExpandedEvent(Action`1 value) { }

	// RVA: 0x6CF654425C Offset: 0x14ED25C VA: 0x6CF654425C
	public static void add_OnBannerAdCollapsedEvent(Action`1 value) { }

	// RVA: 0x6CF654433C Offset: 0x14ED33C VA: 0x6CF654433C
	public static void remove_OnBannerAdCollapsedEvent(Action`1 value) { }

	// RVA: 0x6CF654441C Offset: 0x14ED41C VA: 0x6CF654441C
	public static void add_OnMRecAdLoadedEvent(Action`1 value) { }

	// RVA: 0x6CF65444FC Offset: 0x14ED4FC VA: 0x6CF65444FC
	public static void remove_OnMRecAdLoadedEvent(Action`1 value) { }

	// RVA: 0x6CF65445DC Offset: 0x14ED5DC VA: 0x6CF65445DC
	public static void add_OnMRecAdLoadFailedEvent(Action`2 value) { }

	// RVA: 0x6CF65446BC Offset: 0x14ED6BC VA: 0x6CF65446BC
	public static void remove_OnMRecAdLoadFailedEvent(Action`2 value) { }

	// RVA: 0x6CF654479C Offset: 0x14ED79C VA: 0x6CF654479C
	public static void add_OnMRecAdClickedEvent(Action`1 value) { }

	// RVA: 0x6CF654487C Offset: 0x14ED87C VA: 0x6CF654487C
	public static void remove_OnMRecAdClickedEvent(Action`1 value) { }

	// RVA: 0x6CF654495C Offset: 0x14ED95C VA: 0x6CF654495C
	public static void add_OnMRecAdExpandedEvent(Action`1 value) { }

	// RVA: 0x6CF6544A3C Offset: 0x14EDA3C VA: 0x6CF6544A3C
	public static void remove_OnMRecAdExpandedEvent(Action`1 value) { }

	// RVA: 0x6CF6544B1C Offset: 0x14EDB1C VA: 0x6CF6544B1C
	public static void add_OnMRecAdCollapsedEvent(Action`1 value) { }

	// RVA: 0x6CF6544BFC Offset: 0x14EDBFC VA: 0x6CF6544BFC
	public static void remove_OnMRecAdCollapsedEvent(Action`1 value) { }

	// RVA: 0x6CF6544CDC Offset: 0x14EDCDC VA: 0x6CF6544CDC
	public static void add_OnInterstitialLoadedEvent(Action`1 value) { }

	// RVA: 0x6CF6544DBC Offset: 0x14EDDBC VA: 0x6CF6544DBC
	public static void remove_OnInterstitialLoadedEvent(Action`1 value) { }

	// RVA: 0x6CF6544E9C Offset: 0x14EDE9C VA: 0x6CF6544E9C
	public static void add_OnInterstitialLoadFailedEvent(Action`2 value) { }

	// RVA: 0x6CF6544F7C Offset: 0x14EDF7C VA: 0x6CF6544F7C
	public static void remove_OnInterstitialLoadFailedEvent(Action`2 value) { }

	// RVA: 0x6CF654505C Offset: 0x14EE05C VA: 0x6CF654505C
	public static void add_OnInterstitialHiddenEvent(Action`1 value) { }

	// RVA: 0x6CF654513C Offset: 0x14EE13C VA: 0x6CF654513C
	public static void remove_OnInterstitialHiddenEvent(Action`1 value) { }

	// RVA: 0x6CF654521C Offset: 0x14EE21C VA: 0x6CF654521C
	public static void add_OnInterstitialDisplayedEvent(Action`1 value) { }

	// RVA: 0x6CF65452FC Offset: 0x14EE2FC VA: 0x6CF65452FC
	public static void remove_OnInterstitialDisplayedEvent(Action`1 value) { }

	// RVA: 0x6CF65453DC Offset: 0x14EE3DC VA: 0x6CF65453DC
	public static void add_OnInterstitialAdFailedToDisplayEvent(Action`2 value) { }

	// RVA: 0x6CF65454BC Offset: 0x14EE4BC VA: 0x6CF65454BC
	public static void remove_OnInterstitialAdFailedToDisplayEvent(Action`2 value) { }

	// RVA: 0x6CF654559C Offset: 0x14EE59C VA: 0x6CF654559C
	public static void add_OnInterstitialClickedEvent(Action`1 value) { }

	// RVA: 0x6CF654567C Offset: 0x14EE67C VA: 0x6CF654567C
	public static void remove_OnInterstitialClickedEvent(Action`1 value) { }

	// RVA: 0x6CF654575C Offset: 0x14EE75C VA: 0x6CF654575C
	public static void add_OnRewardedAdLoadedEvent(Action`1 value) { }

	// RVA: 0x6CF654583C Offset: 0x14EE83C VA: 0x6CF654583C
	public static void remove_OnRewardedAdLoadedEvent(Action`1 value) { }

	// RVA: 0x6CF654591C Offset: 0x14EE91C VA: 0x6CF654591C
	public static void add_OnRewardedAdLoadFailedEvent(Action`2 value) { }

	// RVA: 0x6CF65459FC Offset: 0x14EE9FC VA: 0x6CF65459FC
	public static void remove_OnRewardedAdLoadFailedEvent(Action`2 value) { }

	// RVA: 0x6CF6545ADC Offset: 0x14EEADC VA: 0x6CF6545ADC
	public static void add_OnRewardedAdDisplayedEvent(Action`1 value) { }

	// RVA: 0x6CF6545BBC Offset: 0x14EEBBC VA: 0x6CF6545BBC
	public static void remove_OnRewardedAdDisplayedEvent(Action`1 value) { }

	// RVA: 0x6CF6545C9C Offset: 0x14EEC9C VA: 0x6CF6545C9C
	public static void add_OnRewardedAdHiddenEvent(Action`1 value) { }

	// RVA: 0x6CF6545D7C Offset: 0x14EED7C VA: 0x6CF6545D7C
	public static void remove_OnRewardedAdHiddenEvent(Action`1 value) { }

	// RVA: 0x6CF6545E5C Offset: 0x14EEE5C VA: 0x6CF6545E5C
	public static void add_OnRewardedAdClickedEvent(Action`1 value) { }

	// RVA: 0x6CF6545F3C Offset: 0x14EEF3C VA: 0x6CF6545F3C
	public static void remove_OnRewardedAdClickedEvent(Action`1 value) { }

	// RVA: 0x6CF654601C Offset: 0x14EF01C VA: 0x6CF654601C
	public static void add_OnRewardedAdFailedToDisplayEvent(Action`2 value) { }

	// RVA: 0x6CF65460FC Offset: 0x14EF0FC VA: 0x6CF65460FC
	public static void remove_OnRewardedAdFailedToDisplayEvent(Action`2 value) { }

	// RVA: 0x6CF65461DC Offset: 0x14EF1DC VA: 0x6CF65461DC
	public static void add_OnRewardedAdReceivedRewardEvent(Action`2 value) { }

	// RVA: 0x6CF65462BC Offset: 0x14EF2BC VA: 0x6CF65462BC
	public static void remove_OnRewardedAdReceivedRewardEvent(Action`2 value) { }

	// RVA: 0x6CF654639C Offset: 0x14EF39C VA: 0x6CF654639C
	private void Awake() { }

	// RVA: 0x6CF653FEEC Offset: 0x14E8EEC VA: 0x6CF653FEEC
	public void ForwardEvent(string eventPropsStr) { }

	// RVA: 0x6CF654661C Offset: 0x14EF61C VA: 0x6CF654661C
	private static void InvokeEvent(Action evt, string eventName) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private static void InvokeEvent(Action`1 evt, T param, string eventName) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private static void InvokeEvent(Action`2 evt, T1 param1, T2 param2, string eventName) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private static void InvokeEvent(Action`3 evt, T1 param1, T2 param2, T3 param3, string eventName) { }

	// RVA: 0x6CF6546798 Offset: 0x14EF798 VA: 0x6CF6546798
	private static bool CanInvokeEvent(Delegate evt) { }

	// RVA: 0x6CF6543844 Offset: 0x14EC844 VA: 0x6CF6543844
	private static void LogSubscribedToEvent(string eventName) { }

	// RVA: 0x6CF6543974 Offset: 0x14EC974 VA: 0x6CF6543974
	private static void LogUnsubscribedToEvent(string eventName) { }

	// RVA: 0x6CF65468D8 Offset: 0x14EF8D8 VA: 0x6CF65468D8
	public void .ctor() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
private sealed class ALUnityBackgroundCallback : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF654BBF4 Offset: 0x14F4BF4 VA: 0x6CF654BBF4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF654BC90 Offset: 0x14F4C90 VA: 0x6CF654BC90
	public virtual void Invoke(string args) { }

	// RVA: 0x6CF654BCA4 Offset: 0x14F4CA4 VA: 0x6CF654BCA4
	public virtual IAsyncResult BeginInvoke(string args, AsyncCallback callback, object object) { }

	// RVA: 0x6CF654BCC4 Offset: 0x14F4CC4 VA: 0x6CF654BCC4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class MaxSdkiOS : MaxSdkBase
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF654BB50 Offset: 0x14F4B50 VA: 0x6CF654BB50
	private static void .cctor() { }

	// RVA: 0x6CF654BB9C Offset: 0x14F4B9C VA: 0x6CF654BB9C
	public void .ctor() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class MaxSdkLogger : Object
{
	// Fields

	private const string SdkTag; // 0x0
	public const string KeyVerboseLoggingEnabled; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF654684C Offset: 0x14EF84C VA: 0x6CF654684C
	public static void UserDebug(string message) { }

	// RVA: 0x6CF6546560 Offset: 0x14EF560 VA: 0x6CF6546560
	public static void D(string message) { }

	// RVA: 0x6CF653C198 Offset: 0x14E5198 VA: 0x6CF653C198
	public static void UserWarning(string message) { }

	// RVA: 0x6CF654BCD0 Offset: 0x14F4CD0 VA: 0x6CF654BCD0
	public static void W(string message) { }

	// RVA: 0x6CF653E8B4 Offset: 0x14E78B4 VA: 0x6CF653E8B4
	public static void UserError(string message) { }

	// RVA: 0x6CF65464A4 Offset: 0x14EF4A4 VA: 0x6CF65464A4
	public static void E(string message) { }

	// RVA: 0x6CF654BD8C Offset: 0x14F4D8C VA: 0x6CF654BD8C
	public void .ctor() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public enum VersionComparisonResult
{
	// Fields

	public int value__; // 0x10
	public const VersionComparisonResult Lesser = 4294967295; // 0x0
	public const VersionComparisonResult Equal = 0; // 0x0
	public const VersionComparisonResult Greater = 1; // 0x0

	// Properties


	// Methods

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
private sealed class <>c__DisplayClass27_0 : Object
{
	// Fields

	public int piece; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF654CF64 Offset: 0x14F5F64 VA: 0x6CF654CF64
	public void .ctor() { }

	// RVA: 0x6CF654D020 Offset: 0x14F6020 VA: 0x6CF654D020
	internal int <CompareVersions>b__0(string version) { }

	// RVA: 0x6CF654D050 Offset: 0x14F6050 VA: 0x6CF654D050
	internal int <CompareVersions>b__1(string version) { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class MaxSdkUtils : Object
{
	// Fields

	private static readonly AndroidJavaClass MaxUnityPluginClass; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF654BD94 Offset: 0x14F4D94 VA: 0x6CF654BD94
	public static float GetAdaptiveBannerHeight(float width) { }

	// RVA: 0x6CF6541C98 Offset: 0x14EAC98 VA: 0x6CF6541C98
	public static Dictionary`2 GetDictionaryFromDictionary(IDictionary`2 dictionary, string key, Dictionary`2 defaultValue) { }

	// RVA: 0x6CF6542418 Offset: 0x14EB418 VA: 0x6CF6542418
	public static List`1 GetListFromDictionary(IDictionary`2 dictionary, string key, List`1 defaultValue) { }

	// RVA: 0x6CF6536994 Offset: 0x14DF994 VA: 0x6CF6536994
	public static string GetStringFromDictionary(IDictionary`2 dictionary, string key, string defaultValue) { }

	// RVA: 0x6CF65418B8 Offset: 0x14EA8B8 VA: 0x6CF65418B8
	public static bool GetBoolFromDictionary(IDictionary`2 dictionary, string key, bool defaultValue) { }

	// RVA: 0x6CF6536828 Offset: 0x14DF828 VA: 0x6CF6536828
	public static int GetIntFromDictionary(IDictionary`2 dictionary, string key, int defaultValue) { }

	// RVA: 0x6CF654275C Offset: 0x14EB75C VA: 0x6CF654275C
	public static long GetLongFromDictionary(IDictionary`2 dictionary, string key, long defaultValue) { }

	// RVA: 0x6CF653FD90 Offset: 0x14E8D90 VA: 0x6CF653FD90
	public static float GetFloatFromDictionary(IDictionary`2 dictionary, string key, float defaultValue) { }

	// RVA: 0x6CF6541B3C Offset: 0x14EAB3C VA: 0x6CF6541B3C
	public static double GetDoubleFromDictionary(IDictionary`2 dictionary, string key, int defaultValue) { }

	// RVA: 0x6CF654BEC0 Offset: 0x14F4EC0 VA: 0x6CF654BEC0
	public static string InvariantCultureToString(object obj) { }

	// RVA: 0x6CF5BDDD38 Offset: 0xB86D38 VA: 0x6CF5BDDD38
	public static List`1 PropsStringsToList(string str) { }

	// RVA: 0x6CF6539A84 Offset: 0x14E2A84 VA: 0x6CF6539A84
	public static string ParseColor(Color color) { }

	// RVA: 0x6CF654BF38 Offset: 0x14F4F38 VA: 0x6CF654BF38
	public static bool IsTablet() { }

	// RVA: 0x6CF654C030 Offset: 0x14F5030 VA: 0x6CF654C030
	public static bool IsPhysicalDevice() { }

	// RVA: 0x6CF654C128 Offset: 0x14F5128 VA: 0x6CF654C128
	public static float GetScreenDensity() { }

	// RVA: 0x6CF654C220 Offset: 0x14F5220 VA: 0x6CF654C220
	public static Nullable`1 GetTcfConsentStatus(int vendorId) { }

	// RVA: 0x6CF654C280 Offset: 0x14F5280 VA: 0x6CF654C280
	private static int GetPlatformSpecificTcfConsentStatus(int vendorId) { }

	// RVA: 0x6CF654C418 Offset: 0x14F5418 VA: 0x6CF654C418
	public static Nullable`1 GetAdditionalConsentStatus(int atpId) { }

	// RVA: 0x6CF654C478 Offset: 0x14F5478 VA: 0x6CF654C478
	private static int GetPlatformSpecificAdditionalConsentStatus(int atpId) { }

	// RVA: 0x6CF654C5A4 Offset: 0x14F55A4 VA: 0x6CF654C5A4
	public static Nullable`1 GetPurposeConsentStatus(int purposeId) { }

	// RVA: 0x6CF654C604 Offset: 0x14F5604 VA: 0x6CF654C604
	private static int GetPlatformSpecificPurposeConsentStatus(int purposeId) { }

	// RVA: 0x6CF654C730 Offset: 0x14F5730 VA: 0x6CF654C730
	public static Nullable`1 GetSpecialFeatureOptInStatus(int specialFeatureId) { }

	// RVA: 0x6CF654C790 Offset: 0x14F5790 VA: 0x6CF654C790
	private static int GetPlatformSpecificSpecialFeatureOptInStatus(int specialFeatureId) { }

	// RVA: 0x6CF654C3AC Offset: 0x14F53AC VA: 0x6CF654C3AC
	private static Nullable`1 GetConsentStatusValue(int consentStatus) { }

	// RVA: 0x6CF654C8BC Offset: 0x14F58BC VA: 0x6CF654C8BC
	public static VersionComparisonResult CompareUnityMediationVersions(string versionA, string versionB) { }

	// RVA: 0x6CF654CBA4 Offset: 0x14F5BA4 VA: 0x6CF654CBA4
	public static VersionComparisonResult CompareVersions(string versionA, string versionB) { }

	// RVA: 0x6CF654CF6C Offset: 0x14F5F6C VA: 0x6CF654CF6C
	public static bool IsValidString(string toCheck) { }

	// RVA: 0x6CF654CF88 Offset: 0x14F5F88 VA: 0x6CF654CF88
	public void .ctor() { }

	// RVA: 0x6CF654CF90 Offset: 0x14F5F90 VA: 0x6CF654CF90
	private static void .cctor() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public enum AdContentRating
{
	// Fields

	public int value__; // 0x10
	public const AdContentRating None = 0; // 0x0
	public const AdContentRating AllAudiences = 1; // 0x0
	public const AdContentRating EveryoneOverTwelve = 2; // 0x0
	public const AdContentRating MatureAudiences = 3; // 0x0

	// Properties


	// Methods

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public enum UserGender
{
	// Fields

	public int value__; // 0x10
	public const UserGender Unknown = 0; // 0x0
	public const UserGender Female = 1; // 0x0
	public const UserGender Male = 2; // 0x0
	public const UserGender Other = 3; // 0x0

	// Properties


	// Methods

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class MaxTargetingData : Object
{
	// Fields


	// Properties

	public int YearOfBirth { set; }
	public UserGender Gender { set; }
	public AdContentRating MaximumAdContentRating { set; }
	public string Email { set; }
	public string PhoneNumber { set; }
	public String[] Keywords { set; }
	public String[] Interests { set; }

	// Methods

	// RVA: 0x6CF654D080 Offset: 0x14F6080 VA: 0x6CF654D080
	public void set_YearOfBirth(int value) { }

	// RVA: 0x6CF654D0D4 Offset: 0x14F60D4 VA: 0x6CF654D0D4
	public void set_Gender(UserGender value) { }

	// RVA: 0x6CF654D180 Offset: 0x14F6180 VA: 0x6CF654D180
	public void set_MaximumAdContentRating(AdContentRating value) { }

	// RVA: 0x6CF654D1D4 Offset: 0x14F61D4 VA: 0x6CF654D1D4
	public void set_Email(string value) { }

	// RVA: 0x6CF654D228 Offset: 0x14F6228 VA: 0x6CF654D228
	public void set_PhoneNumber(string value) { }

	// RVA: 0x6CF654D27C Offset: 0x14F627C VA: 0x6CF654D27C
	public void set_Keywords(String[] value) { }

	// RVA: 0x6CF654D2D0 Offset: 0x14F62D0 VA: 0x6CF654D2D0
	public void set_Interests(String[] value) { }

	// RVA: 0x6CF654D324 Offset: 0x14F6324 VA: 0x6CF654D324
	public void ClearAll() { }

	// RVA: 0x6CF6541850 Offset: 0x14EA850 VA: 0x6CF6541850
	public void .ctor() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class MaxUserSegment : Object
{
	// Fields

	private string _name; // 0x10

	// Properties

	public string Name { get; set; }

	// Methods

	// RVA: 0x6CF654D370 Offset: 0x14F6370 VA: 0x6CF654D370
	public void set_Name(string value) { }

	// RVA: 0x6CF654D3EC Offset: 0x14F63EC VA: 0x6CF654D3EC
	public string get_Name() { }

	// RVA: 0x6CF654D3F4 Offset: 0x14F63F4 VA: 0x6CF654D3F4
	public override string ToString() { }

	// RVA: 0x6CF6541848 Offset: 0x14EA848 VA: 0x6CF6541848
	public void .ctor() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class MaxUserServiceAndroid : Object
{
	// Fields

	private static readonly AndroidJavaClass _maxUnityPluginClass; // 0x0
	private static readonly MaxUserServiceAndroid _instance; // 0x8

	// Properties

	public static MaxUserServiceAndroid Instance { get; }

	// Methods

	// RVA: 0x6CF654D460 Offset: 0x14F6460 VA: 0x6CF654D460
	public static MaxUserServiceAndroid get_Instance() { }

	// RVA: 0x6CF654D4B8 Offset: 0x14F64B8 VA: 0x6CF654D4B8
	public void PreloadConsentDialog() { }

	// RVA: 0x6CF654D59C Offset: 0x14F659C VA: 0x6CF654D59C
	public void ShowConsentDialog() { }

	// RVA: 0x6CF654D680 Offset: 0x14F6680 VA: 0x6CF654D680
	public void .ctor() { }

	// RVA: 0x6CF654D688 Offset: 0x14F6688 VA: 0x6CF654D688
	private static void .cctor() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
public class MaxUserServiceUnityEditor : Object
{
	// Fields

	private static readonly MaxUserServiceUnityEditor _instance; // 0x0

	// Properties

	public static MaxUserServiceUnityEditor Instance { get; }

	// Methods

	// RVA: 0x6CF654D738 Offset: 0x14F6738 VA: 0x6CF654D738
	public static MaxUserServiceUnityEditor get_Instance() { }

	// RVA: 0x6CF654D790 Offset: 0x14F6790 VA: 0x6CF654D790
	public void PreloadConsentDialog() { }

	// RVA: 0x6CF654D7D0 Offset: 0x14F67D0 VA: 0x6CF654D7D0
	public void ShowConsentDialog() { }

	// RVA: 0x6CF654D810 Offset: 0x14F6810 VA: 0x6CF654D810
	public void .ctor() { }

	// RVA: 0x6CF654D818 Offset: 0x14F6818 VA: 0x6CF654D818
	private static void .cctor() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
private struct MonoScriptData
{
	// Fields

	public Byte[] FilePathsData; // 0x10
	public Byte[] TypesData; // 0x18
	public int TotalTypes; // 0x20
	public int TotalFiles; // 0x24
	public bool IsEditorOnly; // 0x28

	// Properties


	// Methods

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF654D874 Offset: 0x14F6874 VA: 0x6CF654D874
	private static MonoScriptData Get() { }

	// RVA: 0x6CF654D938 Offset: 0x14F6938 VA: 0x6CF654D938
	public void .ctor() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
private enum TOKEN
{
	// Fields

	public int value__; // 0x10
	public const TOKEN NONE = 0; // 0x0
	public const TOKEN CURLY_OPEN = 1; // 0x0
	public const TOKEN CURLY_CLOSE = 2; // 0x0
	public const TOKEN SQUARED_OPEN = 3; // 0x0
	public const TOKEN SQUARED_CLOSE = 4; // 0x0
	public const TOKEN COLON = 5; // 0x0
	public const TOKEN COMMA = 6; // 0x0
	public const TOKEN STRING = 7; // 0x0
	public const TOKEN NUMBER = 8; // 0x0
	public const TOKEN TRUE = 9; // 0x0
	public const TOKEN FALSE = 10; // 0x0
	public const TOKEN NULL = 11; // 0x0

	// Properties


	// Methods

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
private sealed class Parser : Object, IDisposable
{
	// Fields

	private const string WORD_BREAK; // 0x0
	private StringReader json; // 0x10

	// Properties

	private char PeekChar { get; }
	private char NextChar { get; }
	private string NextWord { get; }
	private TOKEN NextToken { get; }

	// Methods

	// RVA: 0x6CF654DB5C Offset: 0x14F6B5C VA: 0x6CF654DB5C
	public static bool IsWordBreak(char c) { }

	// RVA: 0x6CF654DBF8 Offset: 0x14F6BF8 VA: 0x6CF654DBF8
	private void .ctor(string jsonString) { }

	// RVA: 0x6CF654D940 Offset: 0x14F6940 VA: 0x6CF654D940
	public static object Parse(string jsonString) { }

	// RVA: 0x6CF654DC88 Offset: 0x14F6C88 VA: 0x6CF654DC88
	public void Dispose() { }

	// RVA: 0x6CF654DCB0 Offset: 0x14F6CB0 VA: 0x6CF654DCB0
	private Dictionary`2 ParseObject() { }

	// RVA: 0x6CF654E218 Offset: 0x14F7218 VA: 0x6CF654E218
	private List`1 ParseArray() { }

	// RVA: 0x6CF654DC6C Offset: 0x14F6C6C VA: 0x6CF654DC6C
	private object ParseValue() { }

	// RVA: 0x6CF654E340 Offset: 0x14F7340 VA: 0x6CF654E340
	private object ParseByToken(TOKEN token) { }

	// RVA: 0x6CF654DF98 Offset: 0x14F6F98 VA: 0x6CF654DF98
	private string ParseString() { }

	// RVA: 0x6CF654E430 Offset: 0x14F7430 VA: 0x6CF654E430
	private object ParseNumber() { }

	// RVA: 0x6CF654E62C Offset: 0x14F762C VA: 0x6CF654E62C
	private void EatWhitespace() { }

	// RVA: 0x6CF654E6D0 Offset: 0x14F76D0 VA: 0x6CF654E6D0
	private char get_PeekChar() { }

	// RVA: 0x6CF654E500 Offset: 0x14F7500 VA: 0x6CF654E500
	private char get_NextChar() { }

	// RVA: 0x6CF654E578 Offset: 0x14F7578 VA: 0x6CF654E578
	private string get_NextWord() { }

	// RVA: 0x6CF654DDD4 Offset: 0x14F6DD4 VA: 0x6CF654DDD4
	private TOKEN get_NextToken() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
private sealed class Serializer : Object
{
	// Fields

	private StringBuilder builder; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF654E748 Offset: 0x14F7748 VA: 0x6CF654E748
	private void .ctor() { }

	// RVA: 0x6CF654DAE8 Offset: 0x14F6AE8 VA: 0x6CF654DAE8
	public static string Serialize(object obj) { }

	// RVA: 0x6CF654E7AC Offset: 0x14F77AC VA: 0x6CF654E7AC
	private void SerializeValue(object value) { }

	// RVA: 0x6CF654EF98 Offset: 0x14F7F98 VA: 0x6CF654EF98
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0x6CF654EC38 Offset: 0x14F7C38 VA: 0x6CF654EC38
	private void SerializeArray(IList anArray) { }

	// RVA: 0x6CF654E97C Offset: 0x14F797C VA: 0x6CF654E97C
	private void SerializeString(string str) { }

	// RVA: 0x6CF654F424 Offset: 0x14F8424 VA: 0x6CF654F424
	private void SerializeOther(object value) { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: AppLovinMax.ThirdParty.MiniJson
public static class Json : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6537BB0 Offset: 0x14E0BB0 VA: 0x6CF6537BB0
	public static object Deserialize(string json) { }

	// RVA: 0x6CF653E238 Offset: 0x14E7238 VA: 0x6CF653E238
	public static string Serialize(object obj) { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: AppLovinMax.Internal.API
public class CFError : Object
{
	// Fields

	private int <Code>k__BackingField; // 0x10
	private string <Message>k__BackingField; // 0x18

	// Properties

	public int Code { get; set; }
	public string Message { get; set; }

	// Methods

	// RVA: 0x6CF654F6A8 Offset: 0x14F86A8 VA: 0x6CF654F6A8
	public int get_Code() { }

	// RVA: 0x6CF654F6B0 Offset: 0x14F86B0 VA: 0x6CF654F6B0
	private void set_Code(int value) { }

	// RVA: 0x6CF654F6B8 Offset: 0x14F86B8 VA: 0x6CF654F6B8
	public string get_Message() { }

	// RVA: 0x6CF654F6C0 Offset: 0x14F86C0 VA: 0x6CF654F6C0
	private void set_Message(string value) { }

	// RVA: 0x6CF654F6C8 Offset: 0x14F86C8 VA: 0x6CF654F6C8
	public static CFError Create(int code, string message) { }

	// RVA: 0x6CF654F734 Offset: 0x14F8734 VA: 0x6CF654F734
	private void .ctor(int code, string message) { }

	// RVA: 0x6CF654F764 Offset: 0x14F8764 VA: 0x6CF654F764
	public override string ToString() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: AppLovinMax.Internal.API
public enum CFType
{
	// Fields

	public int value__; // 0x10
	public const CFType Unknown = 0; // 0x0
	public const CFType Standard = 1; // 0x0
	public const CFType Detailed = 2; // 0x0

	// Properties


	// Methods

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
private sealed class <>c__DisplayClass2_0 : Object
{
	// Fields

	public Action`1 onFlowCompletedAction; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF654F9F4 Offset: 0x14F89F4 VA: 0x6CF654F9F4
	public void .ctor() { }

	// RVA: 0x6CF654FA04 Offset: 0x14F8A04 VA: 0x6CF654FA04
	internal void <SCF>b__0(MaxCmpError error) { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: AppLovinMax.Internal.API
public class CFService : Object
{
	// Fields


	// Properties

	public static CFType CFType { get; }

	// Methods

	// RVA: 0x6CF654F874 Offset: 0x14F8874 VA: 0x6CF654F874
	public static CFType get_CFType() { }

	// RVA: 0x6CF654F918 Offset: 0x14F8918 VA: 0x6CF654F918
	public static void SCF(Action`1 onFlowCompletedAction) { }

	// RVA: 0x6CF654F9FC Offset: 0x14F89FC VA: 0x6CF654F9FC
	public void .ctor() { }

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=669
{
	// Fields


	// Properties


	// Methods

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=960
{
	// Fields


	// Properties


	// Methods

}

// Dll : MaxSdk.Scripts.dll
// Namespace: 
internal sealed class <PrivateImplementationDetails> : Object
{
	// Fields

	internal static readonly __StaticArrayInitTypeSize=669 370FB44FE5032AD34FE5954AB4FACD1DA69A4D8F7042EB3A436C411E13A8B78D; // 0x0
	internal static readonly __StaticArrayInitTypeSize=960 77CFA1B153D6882BD50DEBB844C9A23D934AE9EC6798392163BF2167CE7FF462; // 0x29D

	// Properties


	// Methods

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine
public struct jvalue
{
	// Fields

	public bool z; // 0x10
	public sbyte b; // 0x10
	public char c; // 0x10
	public short s; // 0x10
	public int i; // 0x10
	public long j; // 0x10
	public float f; // 0x10
	public double d; // 0x10
	public IntPtr l; // 0x10

	// Properties


	// Methods

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine
public struct JNINativeMethod
{
	// Fields

	public string name; // 0x10
	public string signature; // 0x18
	public IntPtr fnPtr; // 0x20

	// Properties


	// Methods

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine
public static class AndroidJNIHelper : Object
{
	// Fields


	// Properties

	public static bool debug { get; set; }

	// Methods

	// RVA: 0x6CF694C1DC Offset: 0x18F51DC VA: 0x6CF694C1DC
	public static bool get_debug() { }

	// RVA: 0x6CF694C204 Offset: 0x18F5204 VA: 0x6CF694C204
	public static void set_debug(bool value) { }

	// RVA: 0x6CF694C240 Offset: 0x18F5240 VA: 0x6CF694C240
	public static IntPtr GetConstructorID(IntPtr javaClass) { }

	// RVA: 0x6CF694C288 Offset: 0x18F5288 VA: 0x6CF694C288
	public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	// RVA: 0x6CF694C454 Offset: 0x18F5454 VA: 0x6CF694C454
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName) { }

	// RVA: 0x6CF694C4B8 Offset: 0x18F54B8 VA: 0x6CF694C4B8
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature) { }

	// RVA: 0x6CF694C4B0 Offset: 0x18F54B0 VA: 0x6CF694C4B0
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x6CF694C698 Offset: 0x18F5698 VA: 0x6CF694C698
	public static IntPtr GetFieldID(IntPtr javaClass, string fieldName) { }

	// RVA: 0x6CF694C6FC Offset: 0x18F56FC VA: 0x6CF694C6FC
	public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature) { }

	// RVA: 0x6CF694C6F4 Offset: 0x18F56F4 VA: 0x6CF694C6F4
	public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x6CF694C9DC Offset: 0x18F59DC VA: 0x6CF694C9DC
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x6CF694CA38 Offset: 0x18F5A38 VA: 0x6CF694CA38
	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	// RVA: 0x6CF694CBDC Offset: 0x18F5BDC VA: 0x6CF694CBDC
	public static IntPtr ConvertToJNIArray(Array array) { }

	// RVA: 0x6CF694D7B0 Offset: 0x18F67B0 VA: 0x6CF694D7B0
	public static jvalue[] CreateJNIArgArray(Object[] args) { }

	// RVA: 0x6CF694DDC0 Offset: 0x18F6DC0 VA: 0x6CF694DDC0
	public static void CreateJNIArgArray(Object[] args, Span`1 jniArgs) { }

	// RVA: 0x6CF694DED0 Offset: 0x18F6ED0 VA: 0x6CF694DED0
	public static void DeleteJNIArgArray(Object[] args, jvalue[] jniArgs) { }

	// RVA: 0x6CF694E094 Offset: 0x18F7094 VA: 0x6CF694E094
	public static void DeleteJNIArgArray(Object[] args, Span`1 jniArgs) { }

	// RVA: 0x6CF694E098 Offset: 0x18F7098 VA: 0x6CF694E098
	public static IntPtr GetConstructorID(IntPtr jclass, Object[] args) { }

	// RVA: 0x6CF694E0D8 Offset: 0x18F70D8 VA: 0x6CF694E0D8
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, Object[] args, bool isStatic) { }

	// RVA: 0x6CF694E148 Offset: 0x18F7148 VA: 0x6CF694E148
	public static string GetSignature(object obj) { }

	// RVA: 0x6CF694F020 Offset: 0x18F8020 VA: 0x6CF694F020
	public static string GetSignature(Object[] args) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static ArrayType ConvertFromJNIArray(IntPtr array) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, Object[] args, bool isStatic) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, bool isStatic) { }

	// RVA: 0x6CF5BDDD38 Offset: 0xB86D38 VA: 0x6CF5BDDD38
	public static string GetSignature(Object[] args) { }

	// RVA: 0x6CF694F148 Offset: 0x18F8148 VA: 0x6CF694F148
	private static IntPtr Box(jvalue val, string boxedClass, string signature) { }

	// RVA: 0x6CF694F418 Offset: 0x18F8418 VA: 0x6CF694F418
	public static IntPtr Box(sbyte value) { }

	// RVA: 0x6CF694F480 Offset: 0x18F8480 VA: 0x6CF694F480
	public static IntPtr Box(short value) { }

	// RVA: 0x6CF694F4E8 Offset: 0x18F84E8 VA: 0x6CF694F4E8
	public static IntPtr Box(int value) { }

	// RVA: 0x6CF694F550 Offset: 0x18F8550 VA: 0x6CF694F550
	public static IntPtr Box(long value) { }

	// RVA: 0x6CF694F5B8 Offset: 0x18F85B8 VA: 0x6CF694F5B8
	public static IntPtr Box(float value) { }

	// RVA: 0x6CF694F620 Offset: 0x18F8620 VA: 0x6CF694F620
	public static IntPtr Box(double value) { }

	// RVA: 0x6CF694F688 Offset: 0x18F8688 VA: 0x6CF694F688
	public static IntPtr Box(char value) { }

	// RVA: 0x6CF694F6F0 Offset: 0x18F86F0 VA: 0x6CF694F6F0
	public static IntPtr Box(bool value) { }

	// RVA: 0x6CF694F758 Offset: 0x18F8758 VA: 0x6CF694F758
	private static IntPtr GetUnboxMethod(IntPtr obj, string methodName, string signature) { }

	// RVA: 0x6CF694F94C Offset: 0x18F894C VA: 0x6CF694F94C
	public static void Unbox(IntPtr obj, ref sbyte value) { }

	// RVA: 0x6CF694FA4C Offset: 0x18F8A4C VA: 0x6CF694FA4C
	public static void Unbox(IntPtr obj, ref short value) { }

	// RVA: 0x6CF694FB4C Offset: 0x18F8B4C VA: 0x6CF694FB4C
	public static void Unbox(IntPtr obj, ref int value) { }

	// RVA: 0x6CF694FC4C Offset: 0x18F8C4C VA: 0x6CF694FC4C
	public static void Unbox(IntPtr obj, ref long value) { }

	// RVA: 0x6CF694FD4C Offset: 0x18F8D4C VA: 0x6CF694FD4C
	public static void Unbox(IntPtr obj, ref float value) { }

	// RVA: 0x6CF694FE58 Offset: 0x18F8E58 VA: 0x6CF694FE58
	public static void Unbox(IntPtr obj, ref double value) { }

	// RVA: 0x6CF694FF64 Offset: 0x18F8F64 VA: 0x6CF694FF64
	public static void Unbox(IntPtr obj, ref char value) { }

	// RVA: 0x6CF6950064 Offset: 0x18F9064 VA: 0x6CF6950064
	public static void Unbox(IntPtr obj, ref bool value) { }

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine
public static class AndroidJNI : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6950168 Offset: 0x18F9168 VA: 0x6CF6950168
	public static IntPtr GetJavaVM() { }

	// RVA: 0x6CF6950190 Offset: 0x18F9190 VA: 0x6CF6950190
	public static int AttachCurrentThread() { }

	// RVA: 0x6CF69501B8 Offset: 0x18F91B8 VA: 0x6CF69501B8
	public static int DetachCurrentThread() { }

	// RVA: 0x6CF69501E0 Offset: 0x18F91E0 VA: 0x6CF69501E0
	public static int GetVersion() { }

	// RVA: 0x6CF6950208 Offset: 0x18F9208 VA: 0x6CF6950208
	public static IntPtr FindClass(string name) { }

	// RVA: 0x6CF6950244 Offset: 0x18F9244 VA: 0x6CF6950244
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x6CF6950280 Offset: 0x18F9280 VA: 0x6CF6950280
	public static IntPtr FromReflectedField(IntPtr refField) { }

	// RVA: 0x6CF69502BC Offset: 0x18F92BC VA: 0x6CF69502BC
	public static IntPtr ToReflectedMethod(IntPtr clazz, IntPtr methodID, bool isStatic) { }

	// RVA: 0x6CF6950310 Offset: 0x18F9310 VA: 0x6CF6950310
	public static IntPtr ToReflectedField(IntPtr clazz, IntPtr fieldID, bool isStatic) { }

	// RVA: 0x6CF6950364 Offset: 0x18F9364 VA: 0x6CF6950364
	public static IntPtr GetSuperclass(IntPtr clazz) { }

	// RVA: 0x6CF69503A0 Offset: 0x18F93A0 VA: 0x6CF69503A0
	public static bool IsAssignableFrom(IntPtr clazz1, IntPtr clazz2) { }

	// RVA: 0x6CF69503E4 Offset: 0x18F93E4 VA: 0x6CF69503E4
	public static int Throw(IntPtr obj) { }

	// RVA: 0x6CF6950420 Offset: 0x18F9420 VA: 0x6CF6950420
	public static int ThrowNew(IntPtr clazz, string message) { }

	// RVA: 0x6CF6950464 Offset: 0x18F9464 VA: 0x6CF6950464
	public static IntPtr ExceptionOccurred() { }

	// RVA: 0x6CF695048C Offset: 0x18F948C VA: 0x6CF695048C
	public static void ExceptionDescribe() { }

	// RVA: 0x6CF69504B4 Offset: 0x18F94B4 VA: 0x6CF69504B4
	public static void ExceptionClear() { }

	// RVA: 0x6CF69504DC Offset: 0x18F94DC VA: 0x6CF69504DC
	public static void FatalError(string message) { }

	// RVA: 0x6CF6950518 Offset: 0x18F9518 VA: 0x6CF6950518
	public static int PushLocalFrame(int capacity) { }

	// RVA: 0x6CF6950554 Offset: 0x18F9554 VA: 0x6CF6950554
	public static IntPtr PopLocalFrame(IntPtr ptr) { }

	// RVA: 0x6CF6950590 Offset: 0x18F9590 VA: 0x6CF6950590
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	// RVA: 0x6CF69505CC Offset: 0x18F95CC VA: 0x6CF69505CC
	public static void DeleteGlobalRef(IntPtr obj) { }

	// RVA: 0x6CF6950608 Offset: 0x18F9608 VA: 0x6CF6950608
	internal static void QueueDeleteGlobalRef(IntPtr obj) { }

	// RVA: 0x6CF6950644 Offset: 0x18F9644 VA: 0x6CF6950644
	internal static uint GetQueueGlobalRefsCount() { }

	// RVA: 0x6CF695066C Offset: 0x18F966C VA: 0x6CF695066C
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	// RVA: 0x6CF69506A8 Offset: 0x18F96A8 VA: 0x6CF69506A8
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	// RVA: 0x6CF69506E4 Offset: 0x18F96E4 VA: 0x6CF69506E4
	public static IntPtr NewLocalRef(IntPtr obj) { }

	// RVA: 0x6CF6950720 Offset: 0x18F9720 VA: 0x6CF6950720
	public static void DeleteLocalRef(IntPtr obj) { }

	// RVA: 0x6CF695075C Offset: 0x18F975C VA: 0x6CF695075C
	public static bool IsSameObject(IntPtr obj1, IntPtr obj2) { }

	// RVA: 0x6CF69507A0 Offset: 0x18F97A0 VA: 0x6CF69507A0
	public static int EnsureLocalCapacity(int capacity) { }

	// RVA: 0x6CF69507DC Offset: 0x18F97DC VA: 0x6CF69507DC
	public static IntPtr AllocObject(IntPtr clazz) { }

	// RVA: 0x6CF6950818 Offset: 0x18F9818 VA: 0x6CF6950818
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF6950880 Offset: 0x18F9880 VA: 0x6CF6950880
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF6950918 Offset: 0x18F9918 VA: 0x6CF6950918
	public static IntPtr NewObjectA(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF695096C Offset: 0x18F996C VA: 0x6CF695096C
	public static IntPtr GetObjectClass(IntPtr obj) { }

	// RVA: 0x6CF69509A8 Offset: 0x18F99A8 VA: 0x6CF69509A8
	public static bool IsInstanceOf(IntPtr obj, IntPtr clazz) { }

	// RVA: 0x6CF69509EC Offset: 0x18F99EC VA: 0x6CF69509EC
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x6CF6950A40 Offset: 0x18F9A40 VA: 0x6CF6950A40
	public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x6CF6950A94 Offset: 0x18F9A94 VA: 0x6CF6950A94
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x6CF6950AE8 Offset: 0x18F9AE8 VA: 0x6CF6950AE8
	public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x6CF6950B3C Offset: 0x18F9B3C VA: 0x6CF6950B3C
	public static IntPtr NewString(string chars) { }

	// RVA: 0x6CF6950B78 Offset: 0x18F9B78 VA: 0x6CF6950B78
	private static IntPtr NewStringFromStr(string chars) { }

	// RVA: 0x6CF6950BB4 Offset: 0x18F9BB4 VA: 0x6CF6950BB4
	public static IntPtr NewString(Char[] chars) { }

	// RVA: 0x6CF6950BF0 Offset: 0x18F9BF0 VA: 0x6CF6950BF0
	public static IntPtr NewStringUTF(string bytes) { }

	// RVA: 0x6CF6950C2C Offset: 0x18F9C2C VA: 0x6CF6950C2C
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x6CF6950C68 Offset: 0x18F9C68 VA: 0x6CF6950C68
	public static int GetStringLength(IntPtr str) { }

	// RVA: 0x6CF6950CA4 Offset: 0x18F9CA4 VA: 0x6CF6950CA4
	public static int GetStringUTFLength(IntPtr str) { }

	// RVA: 0x6CF6950CE0 Offset: 0x18F9CE0 VA: 0x6CF6950CE0
	public static string GetStringUTFChars(IntPtr str) { }

	// RVA: 0x6CF6950D1C Offset: 0x18F9D1C VA: 0x6CF6950D1C
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF6950D84 Offset: 0x18F9D84 VA: 0x6CF6950D84
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF6950E1C Offset: 0x18F9E1C VA: 0x6CF6950E1C
	public static string CallStringMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF6950E70 Offset: 0x18F9E70 VA: 0x6CF6950E70
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF6950ED8 Offset: 0x18F9ED8 VA: 0x6CF6950ED8
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF6950F70 Offset: 0x18F9F70 VA: 0x6CF6950F70
	public static IntPtr CallObjectMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF6950FC4 Offset: 0x18F9FC4 VA: 0x6CF6950FC4
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF695102C Offset: 0x18FA02C VA: 0x6CF695102C
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF69510C4 Offset: 0x18FA0C4 VA: 0x6CF69510C4
	public static int CallIntMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF6951118 Offset: 0x18FA118 VA: 0x6CF6951118
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF6951180 Offset: 0x18FA180 VA: 0x6CF6951180
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF695121C Offset: 0x18FA21C VA: 0x6CF695121C
	public static bool CallBooleanMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF6951270 Offset: 0x18FA270 VA: 0x6CF6951270
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF69512D8 Offset: 0x18FA2D8 VA: 0x6CF69512D8
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF6951370 Offset: 0x18FA370 VA: 0x6CF6951370
	public static short CallShortMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF69513C4 Offset: 0x18FA3C4 VA: 0x6CF69513C4
	public static byte CallByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF69513C8 Offset: 0x18FA3C8 VA: 0x6CF69513C8
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF6951430 Offset: 0x18FA430 VA: 0x6CF6951430
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF69514C8 Offset: 0x18FA4C8 VA: 0x6CF69514C8
	public static sbyte CallSByteMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF695151C Offset: 0x18FA51C VA: 0x6CF695151C
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF6951584 Offset: 0x18FA584 VA: 0x6CF6951584
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF695161C Offset: 0x18FA61C VA: 0x6CF695161C
	public static char CallCharMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF6951670 Offset: 0x18FA670 VA: 0x6CF6951670
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF69516D8 Offset: 0x18FA6D8 VA: 0x6CF69516D8
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF6951770 Offset: 0x18FA770 VA: 0x6CF6951770
	public static float CallFloatMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF69517C4 Offset: 0x18FA7C4 VA: 0x6CF69517C4
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF695182C Offset: 0x18FA82C VA: 0x6CF695182C
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF69518C4 Offset: 0x18FA8C4 VA: 0x6CF69518C4
	public static double CallDoubleMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF6951918 Offset: 0x18FA918 VA: 0x6CF6951918
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF6951980 Offset: 0x18FA980 VA: 0x6CF6951980
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF6951A18 Offset: 0x18FAA18 VA: 0x6CF6951A18
	public static long CallLongMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF6951A6C Offset: 0x18FAA6C VA: 0x6CF6951A6C
	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF6951AD4 Offset: 0x18FAAD4 VA: 0x6CF6951AD4
	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF6951B6C Offset: 0x18FAB6C VA: 0x6CF6951B6C
	public static void CallVoidMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF6951BC0 Offset: 0x18FABC0 VA: 0x6CF6951BC0
	public static string GetStringField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x6CF6951C04 Offset: 0x18FAC04 VA: 0x6CF6951C04
	public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x6CF6951C48 Offset: 0x18FAC48 VA: 0x6CF6951C48
	public static bool GetBooleanField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x6CF6951C8C Offset: 0x18FAC8C VA: 0x6CF6951C8C
	public static byte GetByteField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x6CF6951CD0 Offset: 0x18FACD0 VA: 0x6CF6951CD0
	public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x6CF6951D14 Offset: 0x18FAD14 VA: 0x6CF6951D14
	public static char GetCharField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x6CF6951D58 Offset: 0x18FAD58 VA: 0x6CF6951D58
	public static short GetShortField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x6CF6951D9C Offset: 0x18FAD9C VA: 0x6CF6951D9C
	public static int GetIntField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x6CF6951DE0 Offset: 0x18FADE0 VA: 0x6CF6951DE0
	public static long GetLongField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x6CF6951E24 Offset: 0x18FAE24 VA: 0x6CF6951E24
	public static float GetFloatField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x6CF6951E68 Offset: 0x18FAE68 VA: 0x6CF6951E68
	public static double GetDoubleField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x6CF6951EAC Offset: 0x18FAEAC VA: 0x6CF6951EAC
	public static void SetStringField(IntPtr obj, IntPtr fieldID, string val) { }

	// RVA: 0x6CF6951F00 Offset: 0x18FAF00 VA: 0x6CF6951F00
	public static void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val) { }

	// RVA: 0x6CF6951F54 Offset: 0x18FAF54 VA: 0x6CF6951F54
	public static void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val) { }

	// RVA: 0x6CF6951FA8 Offset: 0x18FAFA8 VA: 0x6CF6951FA8
	public static void SetByteField(IntPtr obj, IntPtr fieldID, byte val) { }

	// RVA: 0x6CF6951FFC Offset: 0x18FAFFC VA: 0x6CF6951FFC
	public static void SetSByteField(IntPtr obj, IntPtr fieldID, sbyte val) { }

	// RVA: 0x6CF6952050 Offset: 0x18FB050 VA: 0x6CF6952050
	public static void SetCharField(IntPtr obj, IntPtr fieldID, char val) { }

	// RVA: 0x6CF69520A4 Offset: 0x18FB0A4 VA: 0x6CF69520A4
	public static void SetShortField(IntPtr obj, IntPtr fieldID, short val) { }

	// RVA: 0x6CF69520F8 Offset: 0x18FB0F8 VA: 0x6CF69520F8
	public static void SetIntField(IntPtr obj, IntPtr fieldID, int val) { }

	// RVA: 0x6CF695214C Offset: 0x18FB14C VA: 0x6CF695214C
	public static void SetLongField(IntPtr obj, IntPtr fieldID, long val) { }

	// RVA: 0x6CF69521A0 Offset: 0x18FB1A0 VA: 0x6CF69521A0
	public static void SetFloatField(IntPtr obj, IntPtr fieldID, float val) { }

	// RVA: 0x6CF69521F4 Offset: 0x18FB1F4 VA: 0x6CF69521F4
	public static void SetDoubleField(IntPtr obj, IntPtr fieldID, double val) { }

	// RVA: 0x6CF6952248 Offset: 0x18FB248 VA: 0x6CF6952248
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF69522B0 Offset: 0x18FB2B0 VA: 0x6CF69522B0
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF6952348 Offset: 0x18FB348 VA: 0x6CF6952348
	public static string CallStaticStringMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF695239C Offset: 0x18FB39C VA: 0x6CF695239C
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF6952404 Offset: 0x18FB404 VA: 0x6CF6952404
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF695249C Offset: 0x18FB49C VA: 0x6CF695249C
	public static IntPtr CallStaticObjectMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF69524F0 Offset: 0x18FB4F0 VA: 0x6CF69524F0
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF6952558 Offset: 0x18FB558 VA: 0x6CF6952558
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF69525F0 Offset: 0x18FB5F0 VA: 0x6CF69525F0
	public static int CallStaticIntMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF6952644 Offset: 0x18FB644 VA: 0x6CF6952644
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF69526AC Offset: 0x18FB6AC VA: 0x6CF69526AC
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF6952748 Offset: 0x18FB748 VA: 0x6CF6952748
	public static bool CallStaticBooleanMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF695279C Offset: 0x18FB79C VA: 0x6CF695279C
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF6952804 Offset: 0x18FB804 VA: 0x6CF6952804
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF695289C Offset: 0x18FB89C VA: 0x6CF695289C
	public static short CallStaticShortMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF69528F0 Offset: 0x18FB8F0 VA: 0x6CF69528F0
	public static byte CallStaticByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF69528F4 Offset: 0x18FB8F4 VA: 0x6CF69528F4
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF695295C Offset: 0x18FB95C VA: 0x6CF695295C
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF69529F4 Offset: 0x18FB9F4 VA: 0x6CF69529F4
	public static sbyte CallStaticSByteMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF6952A48 Offset: 0x18FBA48 VA: 0x6CF6952A48
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF6952AB0 Offset: 0x18FBAB0 VA: 0x6CF6952AB0
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF6952B48 Offset: 0x18FBB48 VA: 0x6CF6952B48
	public static char CallStaticCharMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF6952B9C Offset: 0x18FBB9C VA: 0x6CF6952B9C
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF6952C04 Offset: 0x18FBC04 VA: 0x6CF6952C04
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF6952C9C Offset: 0x18FBC9C VA: 0x6CF6952C9C
	public static float CallStaticFloatMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF6952CF0 Offset: 0x18FBCF0 VA: 0x6CF6952CF0
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF6952D58 Offset: 0x18FBD58 VA: 0x6CF6952D58
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF6952DF0 Offset: 0x18FBDF0 VA: 0x6CF6952DF0
	public static double CallStaticDoubleMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF6952E44 Offset: 0x18FBE44 VA: 0x6CF6952E44
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF6952EAC Offset: 0x18FBEAC VA: 0x6CF6952EAC
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF6952F44 Offset: 0x18FBF44 VA: 0x6CF6952F44
	public static long CallStaticLongMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF6952F98 Offset: 0x18FBF98 VA: 0x6CF6952F98
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF6953000 Offset: 0x18FC000 VA: 0x6CF6953000
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF6953098 Offset: 0x18FC098 VA: 0x6CF6953098
	public static void CallStaticVoidMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x6CF69530EC Offset: 0x18FC0EC VA: 0x6CF69530EC
	public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x6CF6953130 Offset: 0x18FC130 VA: 0x6CF6953130
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x6CF6953174 Offset: 0x18FC174 VA: 0x6CF6953174
	public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x6CF69531B8 Offset: 0x18FC1B8 VA: 0x6CF69531B8
	public static byte GetStaticByteField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x6CF69531FC Offset: 0x18FC1FC VA: 0x6CF69531FC
	public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x6CF6953240 Offset: 0x18FC240 VA: 0x6CF6953240
	public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x6CF6953284 Offset: 0x18FC284 VA: 0x6CF6953284
	public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x6CF69532C8 Offset: 0x18FC2C8 VA: 0x6CF69532C8
	public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x6CF695330C Offset: 0x18FC30C VA: 0x6CF695330C
	public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x6CF6953350 Offset: 0x18FC350 VA: 0x6CF6953350
	public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x6CF6953394 Offset: 0x18FC394 VA: 0x6CF6953394
	public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x6CF69533D8 Offset: 0x18FC3D8 VA: 0x6CF69533D8
	public static void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val) { }

	// RVA: 0x6CF695342C Offset: 0x18FC42C VA: 0x6CF695342C
	public static void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val) { }

	// RVA: 0x6CF6953480 Offset: 0x18FC480 VA: 0x6CF6953480
	public static void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val) { }

	// RVA: 0x6CF69534D4 Offset: 0x18FC4D4 VA: 0x6CF69534D4
	public static void SetStaticByteField(IntPtr clazz, IntPtr fieldID, byte val) { }

	// RVA: 0x6CF6953528 Offset: 0x18FC528 VA: 0x6CF6953528
	public static void SetStaticSByteField(IntPtr clazz, IntPtr fieldID, sbyte val) { }

	// RVA: 0x6CF695357C Offset: 0x18FC57C VA: 0x6CF695357C
	public static void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val) { }

	// RVA: 0x6CF69535D0 Offset: 0x18FC5D0 VA: 0x6CF69535D0
	public static void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val) { }

	// RVA: 0x6CF6953624 Offset: 0x18FC624 VA: 0x6CF6953624
	public static void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val) { }

	// RVA: 0x6CF6953678 Offset: 0x18FC678 VA: 0x6CF6953678
	public static void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val) { }

	// RVA: 0x6CF69536CC Offset: 0x18FC6CC VA: 0x6CF69536CC
	public static void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val) { }

	// RVA: 0x6CF6953720 Offset: 0x18FC720 VA: 0x6CF6953720
	public static void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val) { }

	// RVA: 0x6CF6953774 Offset: 0x18FC774 VA: 0x6CF6953774
	public static IntPtr ToBooleanArray(Boolean[] array) { }

	// RVA: 0x6CF69537B0 Offset: 0x18FC7B0 VA: 0x6CF69537B0
	public static IntPtr ToByteArray(Byte[] array) { }

	// RVA: 0x6CF69537EC Offset: 0x18FC7EC VA: 0x6CF69537EC
	public static IntPtr ToSByteArray(SByte[] array) { }

	// RVA: 0x6CF6953840 Offset: 0x18FC840 VA: 0x6CF6953840
	public static IntPtr ToSByteArray(SByte* array, int length) { }

	// RVA: 0x6CF6953884 Offset: 0x18FC884 VA: 0x6CF6953884
	public static IntPtr ToCharArray(Char[] array) { }

	// RVA: 0x6CF69538D8 Offset: 0x18FC8D8 VA: 0x6CF69538D8
	public static IntPtr ToCharArray(Char* array, int length) { }

	// RVA: 0x6CF695391C Offset: 0x18FC91C VA: 0x6CF695391C
	public static IntPtr ToShortArray(Int16[] array) { }

	// RVA: 0x6CF6953970 Offset: 0x18FC970 VA: 0x6CF6953970
	public static IntPtr ToShortArray(Int16* array, int length) { }

	// RVA: 0x6CF69539B4 Offset: 0x18FC9B4 VA: 0x6CF69539B4
	public static IntPtr ToIntArray(Int32[] array) { }

	// RVA: 0x6CF6953A08 Offset: 0x18FCA08 VA: 0x6CF6953A08
	public static IntPtr ToIntArray(Int32* array, int length) { }

	// RVA: 0x6CF6953A4C Offset: 0x18FCA4C VA: 0x6CF6953A4C
	public static IntPtr ToLongArray(Int64[] array) { }

	// RVA: 0x6CF6953AA0 Offset: 0x18FCAA0 VA: 0x6CF6953AA0
	public static IntPtr ToLongArray(Int64* array, int length) { }

	// RVA: 0x6CF6953AE4 Offset: 0x18FCAE4 VA: 0x6CF6953AE4
	public static IntPtr ToFloatArray(Single[] array) { }

	// RVA: 0x6CF6953B38 Offset: 0x18FCB38 VA: 0x6CF6953B38
	public static IntPtr ToFloatArray(Single* array, int length) { }

	// RVA: 0x6CF6953B7C Offset: 0x18FCB7C VA: 0x6CF6953B7C
	public static IntPtr ToDoubleArray(Double[] array) { }

	// RVA: 0x6CF6953BD0 Offset: 0x18FCBD0 VA: 0x6CF6953BD0
	public static IntPtr ToDoubleArray(Double* array, int length) { }

	// RVA: 0x6CF6953C14 Offset: 0x18FCC14 VA: 0x6CF6953C14
	public static IntPtr ToObjectArray(IntPtr* array, int length, IntPtr arrayClass) { }

	// RVA: 0x6CF6953C68 Offset: 0x18FCC68 VA: 0x6CF6953C68
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	// RVA: 0x6CF6953CCC Offset: 0x18FCCCC VA: 0x6CF6953CCC
	public static IntPtr ToObjectArray(IntPtr[] array) { }

	// RVA: 0x6CF6953CD4 Offset: 0x18FCCD4 VA: 0x6CF6953CD4
	public static Boolean[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x6CF6953D10 Offset: 0x18FCD10 VA: 0x6CF6953D10
	public static Byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x6CF6953D4C Offset: 0x18FCD4C VA: 0x6CF6953D4C
	public static SByte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x6CF6953D88 Offset: 0x18FCD88 VA: 0x6CF6953D88
	public static Char[] FromCharArray(IntPtr array) { }

	// RVA: 0x6CF6953DC4 Offset: 0x18FCDC4 VA: 0x6CF6953DC4
	public static Int16[] FromShortArray(IntPtr array) { }

	// RVA: 0x6CF6953E00 Offset: 0x18FCE00 VA: 0x6CF6953E00
	public static Int32[] FromIntArray(IntPtr array) { }

	// RVA: 0x6CF6953E3C Offset: 0x18FCE3C VA: 0x6CF6953E3C
	public static Int64[] FromLongArray(IntPtr array) { }

	// RVA: 0x6CF6953E78 Offset: 0x18FCE78 VA: 0x6CF6953E78
	public static Single[] FromFloatArray(IntPtr array) { }

	// RVA: 0x6CF6953EB4 Offset: 0x18FCEB4 VA: 0x6CF6953EB4
	public static Double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x6CF6953EF0 Offset: 0x18FCEF0 VA: 0x6CF6953EF0
	public static IntPtr[] FromObjectArray(IntPtr array) { }

	// RVA: 0x6CF6953F2C Offset: 0x18FCF2C VA: 0x6CF6953F2C
	public static int GetArrayLength(IntPtr array) { }

	// RVA: 0x6CF6953F68 Offset: 0x18FCF68 VA: 0x6CF6953F68
	public static IntPtr NewBooleanArray(int size) { }

	// RVA: 0x6CF6953FA4 Offset: 0x18FCFA4 VA: 0x6CF6953FA4
	public static IntPtr NewByteArray(int size) { }

	// RVA: 0x6CF6953FE0 Offset: 0x18FCFE0 VA: 0x6CF6953FE0
	public static IntPtr NewSByteArray(int size) { }

	// RVA: 0x6CF695401C Offset: 0x18FD01C VA: 0x6CF695401C
	public static IntPtr NewCharArray(int size) { }

	// RVA: 0x6CF6954058 Offset: 0x18FD058 VA: 0x6CF6954058
	public static IntPtr NewShortArray(int size) { }

	// RVA: 0x6CF6954094 Offset: 0x18FD094 VA: 0x6CF6954094
	public static IntPtr NewIntArray(int size) { }

	// RVA: 0x6CF69540D0 Offset: 0x18FD0D0 VA: 0x6CF69540D0
	public static IntPtr NewLongArray(int size) { }

	// RVA: 0x6CF695410C Offset: 0x18FD10C VA: 0x6CF695410C
	public static IntPtr NewFloatArray(int size) { }

	// RVA: 0x6CF6954148 Offset: 0x18FD148 VA: 0x6CF6954148
	public static IntPtr NewDoubleArray(int size) { }

	// RVA: 0x6CF6954184 Offset: 0x18FD184 VA: 0x6CF6954184
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	// RVA: 0x6CF69541D8 Offset: 0x18FD1D8 VA: 0x6CF69541D8
	public static bool GetBooleanArrayElement(IntPtr array, int index) { }

	// RVA: 0x6CF695421C Offset: 0x18FD21C VA: 0x6CF695421C
	public static byte GetByteArrayElement(IntPtr array, int index) { }

	// RVA: 0x6CF6954260 Offset: 0x18FD260 VA: 0x6CF6954260
	public static sbyte GetSByteArrayElement(IntPtr array, int index) { }

	// RVA: 0x6CF69542A4 Offset: 0x18FD2A4 VA: 0x6CF69542A4
	public static char GetCharArrayElement(IntPtr array, int index) { }

	// RVA: 0x6CF69542E8 Offset: 0x18FD2E8 VA: 0x6CF69542E8
	public static short GetShortArrayElement(IntPtr array, int index) { }

	// RVA: 0x6CF695432C Offset: 0x18FD32C VA: 0x6CF695432C
	public static int GetIntArrayElement(IntPtr array, int index) { }

	// RVA: 0x6CF6954370 Offset: 0x18FD370 VA: 0x6CF6954370
	public static long GetLongArrayElement(IntPtr array, int index) { }

	// RVA: 0x6CF69543B4 Offset: 0x18FD3B4 VA: 0x6CF69543B4
	public static float GetFloatArrayElement(IntPtr array, int index) { }

	// RVA: 0x6CF69543F8 Offset: 0x18FD3F8 VA: 0x6CF69543F8
	public static double GetDoubleArrayElement(IntPtr array, int index) { }

	// RVA: 0x6CF695443C Offset: 0x18FD43C VA: 0x6CF695443C
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x6CF6954480 Offset: 0x18FD480 VA: 0x6CF6954480
	public static void SetBooleanArrayElement(IntPtr array, int index, byte val) { }

	// RVA: 0x6CF69544D8 Offset: 0x18FD4D8 VA: 0x6CF69544D8
	public static void SetBooleanArrayElement(IntPtr array, int index, bool val) { }

	// RVA: 0x6CF695452C Offset: 0x18FD52C VA: 0x6CF695452C
	public static void SetByteArrayElement(IntPtr array, int index, sbyte val) { }

	// RVA: 0x6CF6954580 Offset: 0x18FD580 VA: 0x6CF6954580
	public static void SetSByteArrayElement(IntPtr array, int index, sbyte val) { }

	// RVA: 0x6CF69545D4 Offset: 0x18FD5D4 VA: 0x6CF69545D4
	public static void SetCharArrayElement(IntPtr array, int index, char val) { }

	// RVA: 0x6CF6954628 Offset: 0x18FD628 VA: 0x6CF6954628
	public static void SetShortArrayElement(IntPtr array, int index, short val) { }

	// RVA: 0x6CF695467C Offset: 0x18FD67C VA: 0x6CF695467C
	public static void SetIntArrayElement(IntPtr array, int index, int val) { }

	// RVA: 0x6CF69546D0 Offset: 0x18FD6D0 VA: 0x6CF69546D0
	public static void SetLongArrayElement(IntPtr array, int index, long val) { }

	// RVA: 0x6CF6954724 Offset: 0x18FD724 VA: 0x6CF6954724
	public static void SetFloatArrayElement(IntPtr array, int index, float val) { }

	// RVA: 0x6CF6954778 Offset: 0x18FD778 VA: 0x6CF6954778
	public static void SetDoubleArrayElement(IntPtr array, int index, double val) { }

	// RVA: 0x6CF69547CC Offset: 0x18FD7CC VA: 0x6CF69547CC
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }

	// RVA: 0x6CF6954820 Offset: 0x18FD820 VA: 0x6CF6954820
	public static IntPtr NewDirectByteBuffer(Byte* buffer, long capacity) { }

	// RVA: 0x6CF6954864 Offset: 0x18FD864 VA: 0x6CF6954864
	public static IntPtr NewDirectByteBuffer(NativeArray`1 buffer) { }

	// RVA: 0x6CF69548BC Offset: 0x18FD8BC VA: 0x6CF69548BC
	public static IntPtr NewDirectByteBuffer(NativeArray`1 buffer) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private static IntPtr NewDirectByteBufferFromNativeArray(NativeArray`1 buffer) { }

	// RVA: 0x6CF6954914 Offset: 0x18FD914 VA: 0x6CF6954914
	public static SByte* GetDirectBufferAddress(IntPtr buffer) { }

	// RVA: 0x6CF6954950 Offset: 0x18FD950 VA: 0x6CF6954950
	public static long GetDirectBufferCapacity(IntPtr buffer) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private static NativeArray`1 GetDirectBuffer(IntPtr buffer) { }

	// RVA: 0x6CF695498C Offset: 0x18FD98C VA: 0x6CF695498C
	public static NativeArray`1 GetDirectByteBuffer(IntPtr buffer) { }

	// RVA: 0x6CF69549D4 Offset: 0x18FD9D4 VA: 0x6CF69549D4
	public static NativeArray`1 GetDirectSByteBuffer(IntPtr buffer) { }

	// RVA: 0x6CF6954A1C Offset: 0x18FDA1C VA: 0x6CF6954A1C
	public static int RegisterNatives(IntPtr clazz, JNINativeMethod[] methods) { }

	// RVA: 0x6CF6954BAC Offset: 0x18FDBAC VA: 0x6CF6954BAC
	private static IntPtr RegisterNativesAllocate(int length) { }

	// RVA: 0x6CF6954BE8 Offset: 0x18FDBE8 VA: 0x6CF6954BE8
	private static void RegisterNativesSet(IntPtr natives, int idx, string name, string signature, IntPtr fnPtr) { }

	// RVA: 0x6CF6954C54 Offset: 0x18FDC54 VA: 0x6CF6954C54
	private static int RegisterNativesAndFree(IntPtr clazz, IntPtr natives, int n) { }

	// RVA: 0x6CF6954CA8 Offset: 0x18FDCA8 VA: 0x6CF6954CA8
	public static int UnregisterNatives(IntPtr clazz) { }

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine
internal class AndroidJNISafe : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6954CE4 Offset: 0x18FDCE4 VA: 0x6CF6954CE4
	public static void CheckException() { }

	// RVA: 0x6CF695502C Offset: 0x18FE02C VA: 0x6CF695502C
	public static void QueueDeleteGlobalRef(IntPtr globalref) { }

	// RVA: 0x6CF6955084 Offset: 0x18FE084 VA: 0x6CF6955084
	public static void DeleteWeakGlobalRef(IntPtr globalref) { }

	// RVA: 0x6CF69550DC Offset: 0x18FE0DC VA: 0x6CF69550DC
	public static void DeleteLocalRef(IntPtr localref) { }

	// RVA: 0x6CF6955134 Offset: 0x18FE134 VA: 0x6CF6955134
	public static IntPtr NewString(string chars) { }

	// RVA: 0x6CF69551D4 Offset: 0x18FE1D4 VA: 0x6CF69551D4
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x6CF694F7F4 Offset: 0x18F87F4 VA: 0x6CF694F7F4
	public static IntPtr GetObjectClass(IntPtr ptr) { }

	// RVA: 0x6CF694F2E8 Offset: 0x18F82E8 VA: 0x6CF694F2E8
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x6CF694F894 Offset: 0x18F8894 VA: 0x6CF694F894
	public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	// RVA: 0x6CF6955274 Offset: 0x18FE274 VA: 0x6CF6955274
	public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x6CF695532C Offset: 0x18FE32C VA: 0x6CF695532C
	public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x6CF69553E4 Offset: 0x18FE3E4 VA: 0x6CF69553E4
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x6CF694F248 Offset: 0x18F8248 VA: 0x6CF694F248
	public static IntPtr FindClass(string name) { }

	// RVA: 0x6CF6955484 Offset: 0x18FE484 VA: 0x6CF6955484
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF69554FC Offset: 0x18FE4FC VA: 0x6CF69554FC
	public static void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val) { }

	// RVA: 0x6CF69555B8 Offset: 0x18FE5B8 VA: 0x6CF69555B8
	public static void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val) { }

	// RVA: 0x6CF6955674 Offset: 0x18FE674 VA: 0x6CF6955674
	public static void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val) { }

	// RVA: 0x6CF6955730 Offset: 0x18FE730 VA: 0x6CF6955730
	public static void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val) { }

	// RVA: 0x6CF69557EC Offset: 0x18FE7EC VA: 0x6CF69557EC
	public static void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val) { }

	// RVA: 0x6CF69558A8 Offset: 0x18FE8A8 VA: 0x6CF69558A8
	public static void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val) { }

	// RVA: 0x6CF6955964 Offset: 0x18FE964 VA: 0x6CF6955964
	public static void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val) { }

	// RVA: 0x6CF6955A20 Offset: 0x18FEA20 VA: 0x6CF6955A20
	public static void SetStaticSByteField(IntPtr clazz, IntPtr fieldID, sbyte val) { }

	// RVA: 0x6CF6955ADC Offset: 0x18FEADC VA: 0x6CF6955ADC
	public static void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val) { }

	// RVA: 0x6CF6955B98 Offset: 0x18FEB98 VA: 0x6CF6955B98
	public static void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val) { }

	// RVA: 0x6CF6955C54 Offset: 0x18FEC54 VA: 0x6CF6955C54
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x6CF6955CFC Offset: 0x18FECFC VA: 0x6CF6955CFC
	public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x6CF6955DA4 Offset: 0x18FEDA4 VA: 0x6CF6955DA4
	public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x6CF6955E4C Offset: 0x18FEE4C VA: 0x6CF6955E4C
	public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x6CF6955F00 Offset: 0x18FEF00 VA: 0x6CF6955F00
	public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x6CF6955FB4 Offset: 0x18FEFB4 VA: 0x6CF6955FB4
	public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x6CF695605C Offset: 0x18FF05C VA: 0x6CF695605C
	public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x6CF6956104 Offset: 0x18FF104 VA: 0x6CF6956104
	public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x6CF69561AC Offset: 0x18FF1AC VA: 0x6CF69561AC
	public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x6CF6956254 Offset: 0x18FF254 VA: 0x6CF6956254
	public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x6CF69562FC Offset: 0x18FF2FC VA: 0x6CF69562FC
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF6956374 Offset: 0x18FF374 VA: 0x6CF6956374
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF694F3A0 Offset: 0x18F83A0 VA: 0x6CF694F3A0
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF69563DC Offset: 0x18FF3DC VA: 0x6CF69563DC
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF6956444 Offset: 0x18FF444 VA: 0x6CF6956444
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF69564BC Offset: 0x18FF4BC VA: 0x6CF69564BC
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF6956534 Offset: 0x18FF534 VA: 0x6CF6956534
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF69565B8 Offset: 0x18FF5B8 VA: 0x6CF69565B8
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF695663C Offset: 0x18FF63C VA: 0x6CF695663C
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF69566B4 Offset: 0x18FF6B4 VA: 0x6CF69566B4
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF695672C Offset: 0x18FF72C VA: 0x6CF695672C
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF69567A4 Offset: 0x18FF7A4 VA: 0x6CF69567A4
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF695681C Offset: 0x18FF81C VA: 0x6CF695681C
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF6956894 Offset: 0x18FF894 VA: 0x6CF6956894
	public static void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val) { }

	// RVA: 0x6CF6956950 Offset: 0x18FF950 VA: 0x6CF6956950
	public static void SetStringField(IntPtr obj, IntPtr fieldID, string val) { }

	// RVA: 0x6CF6956A0C Offset: 0x18FFA0C VA: 0x6CF6956A0C
	public static void SetCharField(IntPtr obj, IntPtr fieldID, char val) { }

	// RVA: 0x6CF6956AC8 Offset: 0x18FFAC8 VA: 0x6CF6956AC8
	public static void SetDoubleField(IntPtr obj, IntPtr fieldID, double val) { }

	// RVA: 0x6CF6956B84 Offset: 0x18FFB84 VA: 0x6CF6956B84
	public static void SetFloatField(IntPtr obj, IntPtr fieldID, float val) { }

	// RVA: 0x6CF6956C40 Offset: 0x18FFC40 VA: 0x6CF6956C40
	public static void SetLongField(IntPtr obj, IntPtr fieldID, long val) { }

	// RVA: 0x6CF6956CFC Offset: 0x18FFCFC VA: 0x6CF6956CFC
	public static void SetShortField(IntPtr obj, IntPtr fieldID, short val) { }

	// RVA: 0x6CF6956DB8 Offset: 0x18FFDB8 VA: 0x6CF6956DB8
	public static void SetSByteField(IntPtr obj, IntPtr fieldID, sbyte val) { }

	// RVA: 0x6CF6956E74 Offset: 0x18FFE74 VA: 0x6CF6956E74
	public static void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val) { }

	// RVA: 0x6CF6956F30 Offset: 0x18FFF30 VA: 0x6CF6956F30
	public static void SetIntField(IntPtr obj, IntPtr fieldID, int val) { }

	// RVA: 0x6CF6956FEC Offset: 0x18FFFEC VA: 0x6CF6956FEC
	public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x6CF6957094 Offset: 0x1900094 VA: 0x6CF6957094
	public static string GetStringField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x6CF695713C Offset: 0x190013C VA: 0x6CF695713C
	public static char GetCharField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x6CF69571E4 Offset: 0x19001E4 VA: 0x6CF69571E4
	public static double GetDoubleField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x6CF6957298 Offset: 0x1900298 VA: 0x6CF6957298
	public static float GetFloatField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x6CF695734C Offset: 0x190034C VA: 0x6CF695734C
	public static long GetLongField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x6CF69573F4 Offset: 0x19003F4 VA: 0x6CF69573F4
	public static short GetShortField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x6CF695749C Offset: 0x190049C VA: 0x6CF695749C
	public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x6CF6957544 Offset: 0x1900544 VA: 0x6CF6957544
	public static bool GetBooleanField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x6CF69575EC Offset: 0x19005EC VA: 0x6CF69575EC
	public static int GetIntField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x6CF6957694 Offset: 0x1900694 VA: 0x6CF6957694
	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF695770C Offset: 0x190070C VA: 0x6CF695770C
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x6CF6957774 Offset: 0x1900774 VA: 0x6CF6957774
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF69577EC Offset: 0x19007EC VA: 0x6CF69577EC
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF694FFEC Offset: 0x18F8FEC VA: 0x6CF694FFEC
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF694FEE0 Offset: 0x18F8EE0 VA: 0x6CF694FEE0
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF694FDD4 Offset: 0x18F8DD4 VA: 0x6CF694FDD4
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF694FCD4 Offset: 0x18F8CD4 VA: 0x6CF694FCD4
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF694FAD4 Offset: 0x18F8AD4 VA: 0x6CF694FAD4
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF694F9D4 Offset: 0x18F89D4 VA: 0x6CF694F9D4
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF69500F0 Offset: 0x18F90F0 VA: 0x6CF69500F0
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF694FBD4 Offset: 0x18F8BD4 VA: 0x6CF694FBD4
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span`1 args) { }

	// RVA: 0x6CF6957864 Offset: 0x1900864 VA: 0x6CF6957864
	public static Char[] FromCharArray(IntPtr array) { }

	// RVA: 0x6CF6957904 Offset: 0x1900904 VA: 0x6CF6957904
	public static Double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x6CF69579A4 Offset: 0x19009A4 VA: 0x6CF69579A4
	public static Single[] FromFloatArray(IntPtr array) { }

	// RVA: 0x6CF6957A44 Offset: 0x1900A44 VA: 0x6CF6957A44
	public static Int64[] FromLongArray(IntPtr array) { }

	// RVA: 0x6CF6957AE4 Offset: 0x1900AE4 VA: 0x6CF6957AE4
	public static Int16[] FromShortArray(IntPtr array) { }

	// RVA: 0x6CF6957B84 Offset: 0x1900B84 VA: 0x6CF6957B84
	public static Byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x6CF6957C24 Offset: 0x1900C24 VA: 0x6CF6957C24
	public static SByte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x6CF6957CC4 Offset: 0x1900CC4 VA: 0x6CF6957CC4
	public static Boolean[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x6CF6957D64 Offset: 0x1900D64 VA: 0x6CF6957D64
	public static Int32[] FromIntArray(IntPtr array) { }

	// RVA: 0x6CF6957E04 Offset: 0x1900E04 VA: 0x6CF6957E04
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	// RVA: 0x6CF6957E7C Offset: 0x1900E7C VA: 0x6CF6957E7C
	public static IntPtr ToCharArray(Char[] array) { }

	// RVA: 0x6CF6957EF4 Offset: 0x1900EF4 VA: 0x6CF6957EF4
	public static IntPtr ToDoubleArray(Double[] array) { }

	// RVA: 0x6CF6957F6C Offset: 0x1900F6C VA: 0x6CF6957F6C
	public static IntPtr ToFloatArray(Single[] array) { }

	// RVA: 0x6CF6957FE4 Offset: 0x1900FE4 VA: 0x6CF6957FE4
	public static IntPtr ToLongArray(Int64[] array) { }

	// RVA: 0x6CF695805C Offset: 0x190105C VA: 0x6CF695805C
	public static IntPtr ToShortArray(Int16[] array) { }

	// RVA: 0x6CF69580D4 Offset: 0x19010D4 VA: 0x6CF69580D4
	public static IntPtr ToByteArray(Byte[] array) { }

	// RVA: 0x6CF6958174 Offset: 0x1901174 VA: 0x6CF6958174
	public static IntPtr ToSByteArray(SByte[] array) { }

	// RVA: 0x6CF69581EC Offset: 0x19011EC VA: 0x6CF69581EC
	public static IntPtr ToBooleanArray(Boolean[] array) { }

	// RVA: 0x6CF695828C Offset: 0x190128C VA: 0x6CF695828C
	public static IntPtr ToIntArray(Int32[] array) { }

	// RVA: 0x6CF6958304 Offset: 0x1901304 VA: 0x6CF6958304
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x6CF69583AC Offset: 0x19013AC VA: 0x6CF69583AC
	public static int GetArrayLength(IntPtr array) { }

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine
public sealed class AndroidJavaRunnable : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF695844C Offset: 0x190144C VA: 0x6CF695844C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF69584D4 Offset: 0x19014D4 VA: 0x6CF69584D4
	public virtual void Invoke() { }

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine
public sealed class AndroidJavaException : Exception
{
	// Fields

	private string mJavaStackTrace; // 0x90

	// Properties

	public override string StackTrace { get; }

	// Methods

	// RVA: 0x6CF6954FB8 Offset: 0x18FDFB8 VA: 0x6CF6954FB8
	internal void .ctor(string message, string javaStackTrace) { }

	// RVA: 0x6CF69584E8 Offset: 0x19014E8 VA: 0x6CF69584E8
	public override string get_StackTrace() { }

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine
internal class GlobalJavaObjectRef : Object
{
	// Fields

	private bool m_disposed; // 0x10
	protected IntPtr m_jobject; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF695850C Offset: 0x190150C VA: 0x6CF695850C
	public void .ctor(IntPtr jobject) { }

	// RVA: 0x6CF695857C Offset: 0x190157C VA: 0x6CF695857C
	protected override void Finalize() { }

	// RVA: 0x6CF6958650 Offset: 0x1901650 VA: 0x6CF6958650
	public static IntPtr op_Implicit(GlobalJavaObjectRef obj) { }

	// RVA: 0x6CF6958610 Offset: 0x1901610 VA: 0x6CF6958610
	public void Dispose() { }

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine
internal class AndroidJavaRunnableProxy : AndroidJavaProxy
{
	// Fields

	private AndroidJavaRunnable mRunnable; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF6958668 Offset: 0x1901668 VA: 0x6CF6958668
	public void .ctor(AndroidJavaRunnable runnable) { }

	// RVA: 0x6CF6958768 Offset: 0x1901768 VA: 0x6CF6958768
	public void run() { }

	// RVA: 0x6CF695878C Offset: 0x190178C VA: 0x6CF695878C
	public override IntPtr Invoke(string methodName, IntPtr javaArgs) { }

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine
public class AndroidJavaProxy : Object
{
	// Fields

	public readonly AndroidJavaClass javaInterface; // 0x10
	internal IntPtr proxyObject; // 0x18
	private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; // 0x0
	private static readonly IntPtr s_HashCodeMethodID; // 0x8

	// Properties


	// Methods

	// RVA: 0x6CF69586E8 Offset: 0x19016E8 VA: 0x6CF69586E8
	public void .ctor(string javaInterface) { }

	// RVA: 0x6CF6958C58 Offset: 0x1901C58 VA: 0x6CF6958C58
	public void .ctor(AndroidJavaClass javaInterface) { }

	// RVA: 0x6CF6958C84 Offset: 0x1901C84 VA: 0x6CF6958C84
	protected override void Finalize() { }

	// RVA: 0x6CF6958D1C Offset: 0x1901D1C VA: 0x6CF6958D1C
	public virtual AndroidJavaObject Invoke(string methodName, Object[] args) { }

	// RVA: 0x6CF695A1E8 Offset: 0x19031E8 VA: 0x6CF695A1E8
	public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

	// RVA: 0x6CF695884C Offset: 0x190184C VA: 0x6CF695884C
	public virtual IntPtr Invoke(string methodName, IntPtr javaArgs) { }

	// RVA: 0x6CF695B04C Offset: 0x190404C VA: 0x6CF695B04C
	public virtual bool equals(AndroidJavaObject obj) { }

	// RVA: 0x6CF695B0A4 Offset: 0x19040A4 VA: 0x6CF695B0A4
	public virtual int hashCode() { }

	// RVA: 0x6CF695B258 Offset: 0x1904258 VA: 0x6CF695B258
	public virtual string toString() { }

	// RVA: 0x6CF695B2BC Offset: 0x19042BC VA: 0x6CF695B2BC
	internal AndroidJavaObject GetProxyObject() { }

	// RVA: 0x6CF695B160 Offset: 0x1904160 VA: 0x6CF695B160
	internal IntPtr GetRawProxy() { }

	// RVA: 0x6CF695B2CC Offset: 0x19042CC VA: 0x6CF695B2CC
	private static void .cctor() { }

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine
public class AndroidJavaObject : Object, IDisposable
{
	// Fields

	private static bool enableDebugPrints; // 0x0
	internal GlobalJavaObjectRef m_jobject; // 0x10
	internal GlobalJavaObjectRef m_jclass; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF695B3C4 Offset: 0x19043C4 VA: 0x6CF695B3C4
	public void .ctor(string className, String[] args) { }

	// RVA: 0x6CF695B570 Offset: 0x1904570 VA: 0x6CF695B570
	public void .ctor(string className, AndroidJavaObject[] args) { }

	// RVA: 0x6CF695B624 Offset: 0x1904624 VA: 0x6CF695B624
	public void .ctor(string className, AndroidJavaClass[] args) { }

	// RVA: 0x6CF695B6D8 Offset: 0x19046D8 VA: 0x6CF695B6D8
	public void .ctor(string className, AndroidJavaProxy[] args) { }

	// RVA: 0x6CF695B78C Offset: 0x190478C VA: 0x6CF695B78C
	public void .ctor(string className, AndroidJavaRunnable[] args) { }

	// RVA: 0x6CF695B840 Offset: 0x1904840 VA: 0x6CF695B840
	public void .ctor(string className, Object[] args) { }

	// RVA: 0x6CF695A0F0 Offset: 0x19030F0 VA: 0x6CF695A0F0
	public void .ctor(IntPtr jobject) { }

	// RVA: 0x6CF695B874 Offset: 0x1904874 VA: 0x6CF695B874
	public void .ctor(IntPtr clazz, IntPtr constructorID, Object[] args) { }

	// RVA: 0x6CF695AF0C Offset: 0x1903F0C VA: 0x6CF695AF0C
	public void Dispose() { }

	// RVA: 0x6CF5BD766C Offset: 0xB8066C VA: 0x6CF5BD766C
	public void Call(string methodName, T[] args) { }

	// RVA: 0x6CF5BD74F4 Offset: 0xB804F4 VA: 0x6CF5BD74F4
	public void Call(IntPtr methodID, T[] args) { }

	// RVA: 0x6CF695BADC Offset: 0x1904ADC VA: 0x6CF695BADC
	public void Call(string methodName, Object[] args) { }

	// RVA: 0x6CF695BB40 Offset: 0x1904B40 VA: 0x6CF695BB40
	public void Call(IntPtr methodID, Object[] args) { }

	// RVA: 0x6CF5BD766C Offset: 0xB8066C VA: 0x6CF5BD766C
	public void CallStatic(string methodName, T[] args) { }

	// RVA: 0x6CF5BD74F4 Offset: 0xB804F4 VA: 0x6CF5BD74F4
	public void CallStatic(IntPtr methodID, T[] args) { }

	// RVA: 0x6CF695BCD8 Offset: 0x1904CD8 VA: 0x6CF695BCD8
	public void CallStatic(string methodName, Object[] args) { }

	// RVA: 0x6CF695BD3C Offset: 0x1904D3C VA: 0x6CF695BD3C
	public void CallStatic(IntPtr methodID, Object[] args) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public FieldType Get(string fieldName) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public FieldType Get(IntPtr fieldID) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public void Set(string fieldName, FieldType val) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public void Set(IntPtr fieldID, FieldType val) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public FieldType GetStatic(string fieldName) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public FieldType GetStatic(IntPtr fieldID) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public void SetStatic(string fieldName, FieldType val) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public void SetStatic(IntPtr fieldID, FieldType val) { }

	// RVA: 0x6CF695B034 Offset: 0x1904034 VA: 0x6CF695B034
	public IntPtr GetRawObject() { }

	// RVA: 0x6CF695BEEC Offset: 0x1904EEC VA: 0x6CF695BEEC
	public IntPtr GetRawClass() { }

	// RVA: 0x6CF695BF24 Offset: 0x1904F24 VA: 0x6CF695BF24
	public AndroidJavaObject CloneReference() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public ReturnType Call(string methodName, T[] args) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public ReturnType Call(IntPtr methodID, T[] args) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public ReturnType Call(string methodName, Object[] args) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public ReturnType Call(IntPtr methodID, Object[] args) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public ReturnType CallStatic(string methodName, T[] args) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public ReturnType CallStatic(IntPtr methodID, T[] args) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public ReturnType CallStatic(string methodName, Object[] args) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public ReturnType CallStatic(IntPtr methodID, Object[] args) { }

	// RVA: 0x6CF695C134 Offset: 0x1905134 VA: 0x6CF695C134
	protected void DebugPrint(string msg) { }

	// RVA: 0x6CF695C1BC Offset: 0x19051BC VA: 0x6CF695C1BC
	protected void DebugPrint(string call, string methodName, string signature, Object[] args) { }

	// RVA: 0x6CF695B480 Offset: 0x1904480 VA: 0x6CF695B480
	private void _AndroidJavaObject(string className, Object[] args) { }

	// RVA: 0x6CF695B900 Offset: 0x1904900 VA: 0x6CF695B900
	private void _AndroidJavaObject(IntPtr constructorID, Object[] args) { }

	// RVA: 0x6CF695B478 Offset: 0x1904478 VA: 0x6CF695B478
	internal void .ctor() { }

	// RVA: 0x6CF695C454 Offset: 0x1905454 VA: 0x6CF695C454
	protected override void Finalize() { }

	// RVA: 0x6CF695C4F4 Offset: 0x19054F4 VA: 0x6CF695C4F4
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x6CF695BAE0 Offset: 0x1904AE0 VA: 0x6CF695BAE0
	protected void _Call(string methodName, Object[] args) { }

	// RVA: 0x6CF695BB44 Offset: 0x1904B44 VA: 0x6CF695BB44
	protected void _Call(IntPtr methodID, Object[] args) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	protected ReturnType _Call(string methodName, Object[] args) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	protected ReturnType _Call(IntPtr methodID, Object[] args) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	protected FieldType _Get(string fieldName) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	protected FieldType _Get(IntPtr fieldID) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	protected void _Set(string fieldName, FieldType val) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	protected void _Set(IntPtr fieldID, FieldType val) { }

	// RVA: 0x6CF695BCDC Offset: 0x1904CDC VA: 0x6CF695BCDC
	protected void _CallStatic(string methodName, Object[] args) { }

	// RVA: 0x6CF695BD40 Offset: 0x1904D40 VA: 0x6CF695BD40
	protected void _CallStatic(IntPtr methodID, Object[] args) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	protected ReturnType _CallStatic(string methodName, Object[] args) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	protected ReturnType _CallStatic(IntPtr methodID, Object[] args) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	protected FieldType _GetStatic(string fieldName) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	protected FieldType _GetStatic(IntPtr fieldID) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	protected void _SetStatic(string fieldName, FieldType val) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	protected void _SetStatic(IntPtr fieldID, FieldType val) { }

	// RVA: 0x6CF695AF78 Offset: 0x1903F78 VA: 0x6CF695AF78
	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x6CF695C524 Offset: 0x1905524 VA: 0x6CF695C524
	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	internal static ReturnType FromJavaArrayDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x6CF695BED4 Offset: 0x1904ED4 VA: 0x6CF695BED4
	protected IntPtr _GetRawObject() { }

	// RVA: 0x6CF695BF08 Offset: 0x1904F08 VA: 0x6CF695BF08
	protected IntPtr _GetRawClass() { }

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine
public class AndroidJavaClass : AndroidJavaObject
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6958C2C Offset: 0x1901C2C VA: 0x6CF6958C2C
	public void .ctor(string className) { }

	// RVA: 0x6CF695C5E0 Offset: 0x19055E0 VA: 0x6CF695C5E0
	private void _AndroidJavaClass(string className) { }

	// RVA: 0x6CF695C070 Offset: 0x1905070 VA: 0x6CF695C070
	internal void .ctor(IntPtr jclass) { }

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine
internal class AndroidReflection : Object
{
	// Fields

	private static readonly GlobalJavaObjectRef s_ReflectionHelperClass; // 0x0
	private static readonly IntPtr s_ReflectionHelperGetConstructorID; // 0x8
	private static readonly IntPtr s_ReflectionHelperGetMethodID; // 0x10
	private static readonly IntPtr s_ReflectionHelperGetFieldID; // 0x18
	private static readonly IntPtr s_ReflectionHelperGetFieldSignature; // 0x20
	private static readonly IntPtr s_ReflectionHelperNewProxyInstance; // 0x28
	private static readonly IntPtr s_ReflectionHelperCeateInvocationError; // 0x30
	private static readonly IntPtr s_FieldGetDeclaringClass; // 0x38

	// Properties


	// Methods

	// RVA: 0x6CF695C69C Offset: 0x190569C VA: 0x6CF695C69C
	public static bool IsPrimitive(Type t) { }

	// RVA: 0x6CF695C6B0 Offset: 0x19056B0 VA: 0x6CF695C6B0
	public static bool IsAssignableFrom(Type t, Type from) { }

	// RVA: 0x6CF695C6D0 Offset: 0x19056D0 VA: 0x6CF695C6D0
	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x6CF695C76C Offset: 0x190576C VA: 0x6CF695C76C
	private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x6CF695C808 Offset: 0x1905808 VA: 0x6CF695C808
	public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	// RVA: 0x6CF695C990 Offset: 0x1905990 VA: 0x6CF695C990
	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x6CF695CB8C Offset: 0x1905B8C VA: 0x6CF695CB8C
	public static IntPtr GetFieldMember(IntPtr jclass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x6CF695CD88 Offset: 0x1905D88 VA: 0x6CF695CD88
	public static IntPtr GetFieldClass(IntPtr field) { }

	// RVA: 0x6CF695CDEC Offset: 0x1905DEC VA: 0x6CF695CDEC
	public static string GetFieldSignature(IntPtr field) { }

	// RVA: 0x6CF695CE94 Offset: 0x1905E94 VA: 0x6CF695CE94
	public static IntPtr NewProxyInstance(IntPtr player, IntPtr delegateHandle, IntPtr interfaze) { }

	// RVA: 0x6CF695A004 Offset: 0x1903004 VA: 0x6CF695A004
	internal static IntPtr CreateInvocationError(Exception ex, bool methodNotFound) { }

	// RVA: 0x6CF695CF78 Offset: 0x1905F78 VA: 0x6CF695CF78
	private static void .cctor() { }

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine
internal sealed class _AndroidJNIHelper : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF694CB54 Offset: 0x18F5B54 VA: 0x6CF694CB54
	public static IntPtr CreateJavaProxy(IntPtr player, IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	// RVA: 0x6CF694C9E0 Offset: 0x18F59E0 VA: 0x6CF694C9E0
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x6CF695D21C Offset: 0x190621C VA: 0x6CF695D21C
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	// RVA: 0x6CF694D840 Offset: 0x18F6840 VA: 0x6CF694D840
	public static void CreateJNIArgArray(Object[] args, Span`1 ret) { }

	// RVA: 0x6CF695D334 Offset: 0x1906334 VA: 0x6CF695D334
	public static object UnboxArray(AndroidJavaObject obj) { }

	// RVA: 0x6CF695A35C Offset: 0x190335C VA: 0x6CF695A35C
	public static object Unbox(AndroidJavaObject obj) { }

	// RVA: 0x6CF6959650 Offset: 0x1902650 VA: 0x6CF6959650
	public static AndroidJavaObject Box(object obj) { }

	// RVA: 0x6CF694DF3C Offset: 0x18F6F3C VA: 0x6CF694DF3C
	public static void DeleteJNIArgArray(Object[] args, Span`1 jniArgs) { }

	// RVA: 0x6CF694CBE0 Offset: 0x18F5BE0 VA: 0x6CF694CBE0
	public static IntPtr ConvertToJNIArray(Array array) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static ArrayType ConvertFromJNIArray(IntPtr array) { }

	// RVA: 0x6CF694E0B8 Offset: 0x18F70B8 VA: 0x6CF694E0B8
	public static IntPtr GetConstructorID(IntPtr jclass, Object[] args) { }

	// RVA: 0x6CF694E110 Offset: 0x18F7110 VA: 0x6CF694E110
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, Object[] args, bool isStatic) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, Object[] args, bool isStatic) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, bool isStatic) { }

	// RVA: 0x6CF694C28C Offset: 0x18F528C VA: 0x6CF694C28C
	public static IntPtr GetConstructorID(IntPtr jclass, string signature) { }

	// RVA: 0x6CF694C4C0 Offset: 0x18F54C0 VA: 0x6CF694C4C0
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x6CF695DACC Offset: 0x1906ACC VA: 0x6CF695DACC
	private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x6CF694C704 Offset: 0x18F5704 VA: 0x6CF694C704
	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x6CF694E14C Offset: 0x18F714C VA: 0x6CF694E14C
	public static string GetSignature(object obj) { }

	// RVA: 0x6CF694F024 Offset: 0x18F8024 VA: 0x6CF694F024
	public static string GetSignature(Object[] args) { }

	// RVA: 0x6CF5BDDD38 Offset: 0xB86D38 VA: 0x6CF5BDDD38
	public static string GetSignature(Object[] args) { }

	// RVA: 0x6CF695DB60 Offset: 0x1906B60 VA: 0x6CF695DB60
	public void .ctor() { }

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine.Android
internal static class AndroidApp : Object
{
	// Fields


	// Properties

	public static IntPtr UnityPlayerRaw { get; }

	// Methods

	// RVA: 0x6CF694CB2C Offset: 0x18F5B2C VA: 0x6CF694CB2C
	public static IntPtr get_UnityPlayerRaw() { }

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine.Android
public enum AndroidAssetPackStatus
{
	// Fields

	public int value__; // 0x10
	public const AndroidAssetPackStatus Unknown = 0; // 0x0
	public const AndroidAssetPackStatus Pending = 1; // 0x0
	public const AndroidAssetPackStatus Downloading = 2; // 0x0
	public const AndroidAssetPackStatus Transferring = 3; // 0x0
	public const AndroidAssetPackStatus Completed = 4; // 0x0
	public const AndroidAssetPackStatus Failed = 5; // 0x0
	public const AndroidAssetPackStatus Canceled = 6; // 0x0
	public const AndroidAssetPackStatus WaitingForWifi = 7; // 0x0
	public const AndroidAssetPackStatus NotInstalled = 8; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine.Android
public enum AndroidAssetPackError
{
	// Fields

	public int value__; // 0x10
	public const AndroidAssetPackError NoError = 0; // 0x0
	public const AndroidAssetPackError AppUnavailable = 4294967295; // 0x0
	public const AndroidAssetPackError PackUnavailable = 4294967294; // 0x0
	public const AndroidAssetPackError InvalidRequest = 4294967293; // 0x0
	public const AndroidAssetPackError DownloadNotFound = 4294967292; // 0x0
	public const AndroidAssetPackError ApiNotAvailable = 4294967291; // 0x0
	public const AndroidAssetPackError NetworkError = 4294967290; // 0x0
	public const AndroidAssetPackError AccessDenied = 4294967289; // 0x0
	public const AndroidAssetPackError InsufficientStorage = 4294967286; // 0x0
	public const AndroidAssetPackError PlayStoreNotFound = 4294967285; // 0x0
	public const AndroidAssetPackError NetworkUnrestricted = 4294967284; // 0x0
	public const AndroidAssetPackError AppNotOwned = 4294967283; // 0x0
	public const AndroidAssetPackError InternalError = 4294967196; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine.Android
public class AndroidAssetPackInfo : Object
{
	// Fields

	private readonly string <name>k__BackingField; // 0x10
	private readonly AndroidAssetPackStatus <status>k__BackingField; // 0x18
	private readonly ulong <size>k__BackingField; // 0x20
	private readonly ulong <bytesDownloaded>k__BackingField; // 0x28
	private readonly float <transferProgress>k__BackingField; // 0x30
	private readonly AndroidAssetPackError <error>k__BackingField; // 0x34

	// Properties


	// Methods

	// RVA: 0x6CF695DB68 Offset: 0x1906B68 VA: 0x6CF695DB68
	internal void .ctor(string name, AndroidAssetPackStatus status, ulong size, ulong bytesDownloaded, float transferProgress, AndroidAssetPackError error) { }

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine.Android
public class AndroidAssetPackState : Object
{
	// Fields

	private readonly string <name>k__BackingField; // 0x10
	private readonly AndroidAssetPackStatus <status>k__BackingField; // 0x18
	private readonly AndroidAssetPackError <error>k__BackingField; // 0x1C

	// Properties


	// Methods

	// RVA: 0x6CF695DBCC Offset: 0x1906BCC VA: 0x6CF695DBCC
	internal void .ctor(string name, AndroidAssetPackStatus status, AndroidAssetPackError error) { }

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine.Android
public class AndroidAssetPackUseMobileDataRequestResult : Object
{
	// Fields

	private readonly bool <allowed>k__BackingField; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF695DC08 Offset: 0x1906C08 VA: 0x6CF695DC08
	internal void .ctor(bool allowed) { }

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: 
private class AssetPackManagerDownloadStatusCallback : AndroidJavaProxy
{
	// Fields

	private Action`1 m_Callback; // 0x20
	private String[] m_AssetPacks; // 0x28

	// Properties


	// Methods

	// RVA: 0x6CF695DFD4 Offset: 0x1906FD4 VA: 0x6CF695DFD4
	public void .ctor(Action`1 callback, String[] assetPacks) { }

	// RVA: 0x6CF695E058 Offset: 0x1907058 VA: 0x6CF695E058
	private void onStatusUpdate(string assetPackName, int assetPackStatus, long assetPackSize, long assetPackBytesDownloaded, int assetPackTransferProgress, int assetPackErrorCode) { }

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: 
private class AssetPackManagerMobileDataConfirmationCallback : AndroidJavaProxy
{
	// Fields

	private Action`1 m_Callback; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF695E164 Offset: 0x1907164 VA: 0x6CF695E164
	public void .ctor(Action`1 callback) { }

	// RVA: 0x6CF695E1E4 Offset: 0x19071E4 VA: 0x6CF695E1E4
	private void onMobileDataConfirmationResult(bool allowed) { }

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: 
private class AssetPackManagerStatusQueryCallback : AndroidJavaProxy
{
	// Fields

	private Action`2 m_Callback; // 0x20
	private List`1 m_AssetPackNames; // 0x28
	private List`1 m_States; // 0x30
	private long m_Size; // 0x38

	// Properties


	// Methods

	// RVA: 0x6CF695E268 Offset: 0x1907268 VA: 0x6CF695E268
	public void .ctor(Action`2 callback, String[] assetPacks) { }

	// RVA: 0x6CF695E358 Offset: 0x1907358 VA: 0x6CF695E358
	private void onStatusResult(long totalBytes, String[] assetPackNames, Int32[] assetPackStatuses, Int32[] assetPackErrorCodes) { }

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine.Android
public static class AndroidAssetPacks : Object
{
	// Fields

	private static AndroidJavaObject s_JavaPlayAssetDeliveryWrapper; // 0x0
	private static bool s_ApiMissing; // 0x8

	// Properties


	// Methods

	// RVA: 0x6CF695DC30 Offset: 0x1906C30 VA: 0x6CF695DC30
	private static AndroidJavaObject GetAssetPackManager() { }

}

// Dll : UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine.Android
public class PermissionCallbacks : AndroidJavaProxy
{
	// Fields

	private Action`1 PermissionGranted; // 0x20
	private Action`1 PermissionDenied; // 0x28
	private Action`1 PermissionDeniedAndDontAskAgain; // 0x30

	// Properties


	// Methods

	// RVA: 0x6CF695E6C4 Offset: 0x19076C4 VA: 0x6CF695E6C4
	public void add_PermissionGranted(Action`1 value) { }

	// RVA: 0x6CF695E774 Offset: 0x1907774 VA: 0x6CF695E774
	public void remove_PermissionGranted(Action`1 value) { }

	// RVA: 0x6CF695E824 Offset: 0x1907824 VA: 0x6CF695E824
	public void add_PermissionDenied(Action`1 value) { }

	// RVA: 0x6CF695E8D4 Offset: 0x19078D4 VA: 0x6CF695E8D4
	public void remove_PermissionDenied(Action`1 value) { }

	// RVA: 0x6CF695E984 Offset: 0x1907984 VA: 0x6CF695E984
	public void add_PermissionDeniedAndDontAskAgain(Action`1 value) { }

	// RVA: 0x6CF695EA34 Offset: 0x1907A34 VA: 0x6CF695EA34
	public void remove_PermissionDeniedAndDontAskAgain(Action`1 value) { }

	// RVA: 0x6CF695EAE4 Offset: 0x1907AE4 VA: 0x6CF695EAE4
	public void .ctor() { }

	// RVA: 0x6CF695EB50 Offset: 0x1907B50 VA: 0x6CF695EB50
	private void onPermissionGranted(string permissionName) { }

	// RVA: 0x6CF695EB6C Offset: 0x1907B6C VA: 0x6CF695EB6C
	private void onPermissionDenied(string permissionName) { }

	// RVA: 0x6CF695EB88 Offset: 0x1907B88 VA: 0x6CF695EB88
	private void onPermissionDeniedAndDontAskAgain(string permissionName) { }

}

// Dll : UnityEngine.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.Core.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.Core.dll
// Namespace: 
internal static class SR : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF67A927C Offset: 0x175227C VA: 0x6CF67A927C
	internal static string GetString(string name) { }

}

// Dll : System.Core.dll
// Namespace: System.Security.Cryptography
public sealed class AesManaged : Aes
{
	// Fields

	private RijndaelManaged m_rijndael; // 0x48

	// Properties

	public override int FeedbackSize { get; set; }
	public override Byte[] IV { get; set; }
	public override Byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x6CF67A9280 Offset: 0x1752280 VA: 0x6CF67A9280
	public void .ctor() { }

	// RVA: 0x6CF67A93DC Offset: 0x17523DC VA: 0x6CF67A93DC
	public override int get_FeedbackSize() { }

	// RVA: 0x6CF67A93FC Offset: 0x17523FC VA: 0x6CF67A93FC
	public override void set_FeedbackSize(int value) { }

	// RVA: 0x6CF67A941C Offset: 0x175241C VA: 0x6CF67A941C
	public override Byte[] get_IV() { }

	// RVA: 0x6CF67A943C Offset: 0x175243C VA: 0x6CF67A943C
	public override void set_IV(Byte[] value) { }

	// RVA: 0x6CF67A945C Offset: 0x175245C VA: 0x6CF67A945C
	public override Byte[] get_Key() { }

	// RVA: 0x6CF67A947C Offset: 0x175247C VA: 0x6CF67A947C
	public override void set_Key(Byte[] value) { }

	// RVA: 0x6CF67A94A0 Offset: 0x17524A0 VA: 0x6CF67A94A0
	public override int get_KeySize() { }

	// RVA: 0x6CF67A94C4 Offset: 0x17524C4 VA: 0x6CF67A94C4
	public override void set_KeySize(int value) { }

	// RVA: 0x6CF67A94E8 Offset: 0x17524E8 VA: 0x6CF67A94E8
	public override CipherMode get_Mode() { }

	// RVA: 0x6CF67A950C Offset: 0x175250C VA: 0x6CF67A950C
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x6CF67A958C Offset: 0x175258C VA: 0x6CF67A958C
	public override PaddingMode get_Padding() { }

	// RVA: 0x6CF67A95B0 Offset: 0x17525B0 VA: 0x6CF67A95B0
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x6CF67A95D4 Offset: 0x17525D4 VA: 0x6CF67A95D4
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x6CF67A95F8 Offset: 0x17525F8 VA: 0x6CF67A95F8
	public override ICryptoTransform CreateDecryptor(Byte[] key, Byte[] iv) { }

	// RVA: 0x6CF67A9738 Offset: 0x1752738 VA: 0x6CF67A9738
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x6CF67A975C Offset: 0x175275C VA: 0x6CF67A975C
	public override ICryptoTransform CreateEncryptor(Byte[] key, Byte[] iv) { }

	// RVA: 0x6CF67A989C Offset: 0x175289C VA: 0x6CF67A989C
	protected override void Dispose(bool disposing) { }

	// RVA: 0x6CF67A99CC Offset: 0x17529CC VA: 0x6CF67A99CC
	public override void GenerateIV() { }

	// RVA: 0x6CF67A99F0 Offset: 0x17529F0 VA: 0x6CF67A99F0
	public override void GenerateKey() { }

}

// Dll : System.Core.dll
// Namespace: System.Security.Cryptography
public sealed class AesCryptoServiceProvider : Aes
{
	// Fields


	// Properties

	public override Byte[] IV { get; set; }
	public override Byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override int FeedbackSize { get; set; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x6CF67A9A14 Offset: 0x1752A14 VA: 0x6CF67A9A14
	public void .ctor() { }

	// RVA: 0x6CF67A9A78 Offset: 0x1752A78 VA: 0x6CF67A9A78
	public override void GenerateIV() { }

	// RVA: 0x6CF67A9A9C Offset: 0x1752A9C VA: 0x6CF67A9A9C
	public override void GenerateKey() { }

	// RVA: 0x6CF67A9AC0 Offset: 0x1752AC0 VA: 0x6CF67A9AC0
	public override ICryptoTransform CreateDecryptor(Byte[] key, Byte[] iv) { }

	// RVA: 0x6CF67AA2A4 Offset: 0x17532A4 VA: 0x6CF67AA2A4
	public override ICryptoTransform CreateEncryptor(Byte[] key, Byte[] iv) { }

	// RVA: 0x6CF67AA394 Offset: 0x1753394 VA: 0x6CF67AA394
	public override Byte[] get_IV() { }

	// RVA: 0x6CF67AA39C Offset: 0x175339C VA: 0x6CF67AA39C
	public override void set_IV(Byte[] value) { }

	// RVA: 0x6CF67AA3A4 Offset: 0x17533A4 VA: 0x6CF67AA3A4
	public override Byte[] get_Key() { }

	// RVA: 0x6CF67AA3AC Offset: 0x17533AC VA: 0x6CF67AA3AC
	public override void set_Key(Byte[] value) { }

	// RVA: 0x6CF67AA3B4 Offset: 0x17533B4 VA: 0x6CF67AA3B4
	public override int get_KeySize() { }

	// RVA: 0x6CF67AA3BC Offset: 0x17533BC VA: 0x6CF67AA3BC
	public override void set_KeySize(int value) { }

	// RVA: 0x6CF67AA3C4 Offset: 0x17533C4 VA: 0x6CF67AA3C4
	public override int get_FeedbackSize() { }

	// RVA: 0x6CF67AA3CC Offset: 0x17533CC VA: 0x6CF67AA3CC
	public override void set_FeedbackSize(int value) { }

	// RVA: 0x6CF67AA3D4 Offset: 0x17533D4 VA: 0x6CF67AA3D4
	public override CipherMode get_Mode() { }

	// RVA: 0x6CF67AA3DC Offset: 0x17533DC VA: 0x6CF67AA3DC
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x6CF67AA438 Offset: 0x1753438 VA: 0x6CF67AA438
	public override PaddingMode get_Padding() { }

	// RVA: 0x6CF67AA440 Offset: 0x1753440 VA: 0x6CF67AA440
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x6CF67AA448 Offset: 0x1753448 VA: 0x6CF67AA448
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x6CF67AA498 Offset: 0x1753498 VA: 0x6CF67AA498
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x6CF67AA4E8 Offset: 0x17534E8 VA: 0x6CF67AA4E8
	protected override void Dispose(bool disposing) { }

}

// Dll : System.Core.dll
// Namespace: System.Security.Cryptography
internal class AesTransform : SymmetricTransform
{
	// Fields

	private UInt32[] expandedKey; // 0x58
	private int Nk; // 0x60
	private int Nr; // 0x64
	private static readonly UInt32[] Rcon; // 0x0
	private static readonly Byte[] SBox; // 0x8
	private static readonly Byte[] iSBox; // 0x10
	private static readonly UInt32[] T0; // 0x18
	private static readonly UInt32[] T1; // 0x20
	private static readonly UInt32[] T2; // 0x28
	private static readonly UInt32[] T3; // 0x30
	private static readonly UInt32[] iT0; // 0x38
	private static readonly UInt32[] iT1; // 0x40
	private static readonly UInt32[] iT2; // 0x48
	private static readonly UInt32[] iT3; // 0x50

	// Properties


	// Methods

	// RVA: 0x6CF67A9BB0 Offset: 0x1752BB0 VA: 0x6CF67A9BB0
	public void .ctor(Aes algo, bool encryption, Byte[] key, Byte[] iv) { }

	// RVA: 0x6CF67AA5B8 Offset: 0x17535B8 VA: 0x6CF67AA5B8
	protected override void ECB(Byte[] input, Byte[] output) { }

	// RVA: 0x6CF67AA4F4 Offset: 0x17534F4 VA: 0x6CF67AA4F4
	private uint SubByte(uint a) { }

	// RVA: 0x6CF67AA5CC Offset: 0x17535CC VA: 0x6CF67AA5CC
	private void Encrypt128(Byte[] indata, Byte[] outdata, UInt32[] ekey) { }

	// RVA: 0x6CF67AC3F8 Offset: 0x17553F8 VA: 0x6CF67AC3F8
	private void Decrypt128(Byte[] indata, Byte[] outdata, UInt32[] ekey) { }

	// RVA: 0x6CF67AE1EC Offset: 0x17571EC VA: 0x6CF67AE1EC
	private static void .cctor() { }

}

// Dll : System.Core.dll
// Namespace: System.Security.Cryptography.X509Certificates
public static class RSACertificateExtensions : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF67AE504 Offset: 0x1757504 VA: 0x6CF67AE504
	public static RSA GetRSAPublicKey(X509Certificate2 certificate) { }

}

// Dll : System.Core.dll
// Namespace: System.Linq
internal static class Error : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF67AE5E4 Offset: 0x17575E4 VA: 0x6CF67AE5E4
	internal static Exception ArgumentNull(string s) { }

	// RVA: 0x6CF67AE640 Offset: 0x1757640 VA: 0x6CF67AE640
	internal static Exception ArgumentOutOfRange(string s) { }

	// RVA: 0x6CF67AE69C Offset: 0x175769C VA: 0x6CF67AE69C
	internal static Exception MoreThanOneMatch() { }

	// RVA: 0x6CF67AE708 Offset: 0x1757708 VA: 0x6CF67AE708
	internal static Exception NoElements() { }

	// RVA: 0x6CF67AE774 Offset: 0x1757774 VA: 0x6CF67AE774
	internal static Exception NoMatch() { }

}

// Dll : System.Core.dll
// Namespace: 
private abstract class Iterator`1 : Object, IEnumerable`1, IEnumerable, IEnumerator`1, IDisposable, IEnumerator
{
	// Fields

	private int threadId; // 0x0
	internal int state; // 0x0
	internal TSource current; // 0x0

	// Properties

	public TSource Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void .ctor() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public TSource get_Current() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public abstract Iterator`1 Clone() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public virtual void Dispose() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public IEnumerator`1 GetEnumerator() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public abstract bool MoveNext() { }

	// RVA: 0x6CF5BD6D7C Offset: 0xB7FD7C VA: 0x6CF5BD6D7C
	public abstract IEnumerable`1 Select(Func`2 selector) { }

	// RVA: 0x6CF5BD6D7C Offset: 0xB7FD7C VA: 0x6CF5BD6D7C
	public abstract IEnumerable`1 Where(Func`2 predicate) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	private void System.Collections.IEnumerator.Reset() { }

}

// Dll : System.Core.dll
// Namespace: 
private class WhereEnumerableIterator`1 : Iterator`1
{
	// Fields

	private IEnumerable`1 source; // 0x0
	private Func`2 predicate; // 0x0
	private IEnumerator`1 enumerator; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BD766C Offset: 0xB8066C VA: 0x6CF5BD766C
	public void .ctor(IEnumerable`1 source, Func`2 predicate) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public override Iterator`1 Clone() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public override void Dispose() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public override bool MoveNext() { }

	// RVA: 0x6CF5BD6D7C Offset: 0xB7FD7C VA: 0x6CF5BD6D7C
	public override IEnumerable`1 Select(Func`2 selector) { }

	// RVA: 0x6CF5BD6D7C Offset: 0xB7FD7C VA: 0x6CF5BD6D7C
	public override IEnumerable`1 Where(Func`2 predicate) { }

}

// Dll : System.Core.dll
// Namespace: 
private class WhereArrayIterator`1 : Iterator`1
{
	// Fields

	private TSource[] source; // 0x0
	private Func`2 predicate; // 0x0
	private int index; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BD766C Offset: 0xB8066C VA: 0x6CF5BD766C
	public void .ctor(TSource[] source, Func`2 predicate) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public override Iterator`1 Clone() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public override bool MoveNext() { }

	// RVA: 0x6CF5BD6D7C Offset: 0xB7FD7C VA: 0x6CF5BD6D7C
	public override IEnumerable`1 Select(Func`2 selector) { }

	// RVA: 0x6CF5BD6D7C Offset: 0xB7FD7C VA: 0x6CF5BD6D7C
	public override IEnumerable`1 Where(Func`2 predicate) { }

}

// Dll : System.Core.dll
// Namespace: 
private class WhereListIterator`1 : Iterator`1
{
	// Fields

	private List`1 source; // 0x0
	private Func`2 predicate; // 0x0
	private Enumerator enumerator; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BD766C Offset: 0xB8066C VA: 0x6CF5BD766C
	public void .ctor(List`1 source, Func`2 predicate) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public override Iterator`1 Clone() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public override bool MoveNext() { }

	// RVA: 0x6CF5BD6D7C Offset: 0xB7FD7C VA: 0x6CF5BD6D7C
	public override IEnumerable`1 Select(Func`2 selector) { }

	// RVA: 0x6CF5BD6D7C Offset: 0xB7FD7C VA: 0x6CF5BD6D7C
	public override IEnumerable`1 Where(Func`2 predicate) { }

}

// Dll : System.Core.dll
// Namespace: 
private class WhereSelectEnumerableIterator`2 : Iterator`1
{
	// Fields

	private IEnumerable`1 source; // 0x0
	private Func`2 predicate; // 0x0
	private Func`2 selector; // 0x0
	private IEnumerator`1 enumerator; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BD773C Offset: 0xB8073C VA: 0x6CF5BD773C
	public void .ctor(IEnumerable`1 source, Func`2 predicate, Func`2 selector) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public override Iterator`1 Clone() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public override void Dispose() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public override bool MoveNext() { }

	// RVA: 0x6CF5BD6D7C Offset: 0xB7FD7C VA: 0x6CF5BD6D7C
	public override IEnumerable`1 Select(Func`2 selector) { }

	// RVA: 0x6CF5BD6D7C Offset: 0xB7FD7C VA: 0x6CF5BD6D7C
	public override IEnumerable`1 Where(Func`2 predicate) { }

}

// Dll : System.Core.dll
// Namespace: 
private class WhereSelectArrayIterator`2 : Iterator`1
{
	// Fields

	private TSource[] source; // 0x0
	private Func`2 predicate; // 0x0
	private Func`2 selector; // 0x0
	private int index; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BD773C Offset: 0xB8073C VA: 0x6CF5BD773C
	public void .ctor(TSource[] source, Func`2 predicate, Func`2 selector) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public override Iterator`1 Clone() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public override bool MoveNext() { }

	// RVA: 0x6CF5BD6D7C Offset: 0xB7FD7C VA: 0x6CF5BD6D7C
	public override IEnumerable`1 Select(Func`2 selector) { }

	// RVA: 0x6CF5BD6D7C Offset: 0xB7FD7C VA: 0x6CF5BD6D7C
	public override IEnumerable`1 Where(Func`2 predicate) { }

}

// Dll : System.Core.dll
// Namespace: 
private class WhereSelectListIterator`2 : Iterator`1
{
	// Fields

	private List`1 source; // 0x0
	private Func`2 predicate; // 0x0
	private Func`2 selector; // 0x0
	private Enumerator enumerator; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BD773C Offset: 0xB8073C VA: 0x6CF5BD773C
	public void .ctor(List`1 source, Func`2 predicate, Func`2 selector) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public override Iterator`1 Clone() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public override bool MoveNext() { }

	// RVA: 0x6CF5BD6D7C Offset: 0xB7FD7C VA: 0x6CF5BD6D7C
	public override IEnumerable`1 Select(Func`2 selector) { }

	// RVA: 0x6CF5BD6D7C Offset: 0xB7FD7C VA: 0x6CF5BD6D7C
	public override IEnumerable`1 Where(Func`2 predicate) { }

}

// Dll : System.Core.dll
// Namespace: 
private sealed class <>c__DisplayClass6_0`1 : Object
{
	// Fields

	public Func`2 predicate1; // 0x0
	public Func`2 predicate2; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void .ctor() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	internal bool <CombinePredicates>b__0(TSource x) { }

}

// Dll : System.Core.dll
// Namespace: 
private sealed class <>c__DisplayClass7_0`3 : Object
{
	// Fields

	public Func`2 selector2; // 0x0
	public Func`2 selector1; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void .ctor() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	internal TResult <CombineSelectors>b__0(TSource x) { }

}

// Dll : System.Core.dll
// Namespace: 
private sealed class <DistinctIterator>d__68`1 : Object, IEnumerable`1, IEnumerable, IEnumerator`1, IDisposable, IEnumerator
{
	// Fields

	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEqualityComparer`1 comparer; // 0x0
	public IEqualityComparer`1 <>3__comparer; // 0x0
	private IEnumerable`1 source; // 0x0
	public IEnumerable`1 <>3__source; // 0x0
	private Set`1 <set>5__2; // 0x0
	private IEnumerator`1 <>7__wrap2; // 0x0

	// Properties

	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5BD7380 Offset: 0xB80380 VA: 0x6CF5BD7380
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	private bool MoveNext() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	private void <>m__Finally1() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IEnumerator`1 System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Dll : System.Core.dll
// Namespace: 
private sealed class <RangeIterator>d__115 : Object, IEnumerable`1, IEnumerable, IEnumerator`1, IDisposable, IEnumerator
{
	// Fields

	private int <>1__state; // 0x10
	private int <>2__current; // 0x14
	private int <>l__initialThreadId; // 0x18
	private int start; // 0x1C
	public int <>3__start; // 0x20
	private int count; // 0x24
	public int <>3__count; // 0x28
	private int <i>5__2; // 0x2C

	// Properties

	private int System.Collections.Generic.IEnumerator<System.Int32>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF67AE8AC Offset: 0x17578AC VA: 0x6CF67AE8AC
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF67AEF30 Offset: 0x1757F30 VA: 0x6CF67AEF30
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF67AEF34 Offset: 0x1757F34 VA: 0x6CF67AEF34
	private bool MoveNext() { }

	// RVA: 0x6CF67AEF98 Offset: 0x1757F98 VA: 0x6CF67AEF98
	private int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

	// RVA: 0x6CF67AEFA0 Offset: 0x1757FA0 VA: 0x6CF67AEFA0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF67AEFD8 Offset: 0x1757FD8 VA: 0x6CF67AEFD8
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x6CF67AF034 Offset: 0x1758034 VA: 0x6CF67AF034
	private IEnumerator`1 System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

	// RVA: 0x6CF67AF0D8 Offset: 0x17580D8 VA: 0x6CF67AF0D8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Dll : System.Core.dll
// Namespace: System.Linq
public static class Enumerable : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5BDE440 Offset: 0xB87440 VA: 0x6CF5BDE440
	public static IEnumerable`1 Where(IEnumerable`1 source, Func`2 predicate) { }

	// RVA: 0x6CF5BDE440 Offset: 0xB87440 VA: 0x6CF5BDE440
	public static IEnumerable`1 Select(IEnumerable`1 source, Func`2 selector) { }

	// RVA: 0x6CF5BDE440 Offset: 0xB87440 VA: 0x6CF5BDE440
	private static Func`2 CombinePredicates(Func`2 predicate1, Func`2 predicate2) { }

	// RVA: 0x6CF5BDE440 Offset: 0xB87440 VA: 0x6CF5BDE440
	private static Func`2 CombineSelectors(Func`2 selector1, Func`2 selector2) { }

	// RVA: 0x6CF5BDE440 Offset: 0xB87440 VA: 0x6CF5BDE440
	public static IOrderedEnumerable`1 OrderBy(IEnumerable`1 source, Func`2 keySelector) { }

	// RVA: 0x6CF5BDE440 Offset: 0xB87440 VA: 0x6CF5BDE440
	public static IOrderedEnumerable`1 ThenBy(IOrderedEnumerable`1 source, Func`2 keySelector) { }

	// RVA: 0x6CF5BDDD38 Offset: 0xB86D38 VA: 0x6CF5BDDD38
	public static IEnumerable`1 Distinct(IEnumerable`1 source) { }

	// RVA: 0x6CF5BDE440 Offset: 0xB87440 VA: 0x6CF5BDE440
	private static IEnumerable`1 DistinctIterator(IEnumerable`1 source, IEqualityComparer`1 comparer) { }

	// RVA: 0x6CF5BD8FA4 Offset: 0xB81FA4 VA: 0x6CF5BD8FA4
	public static bool SequenceEqual(IEnumerable`1 first, IEnumerable`1 second) { }

	// RVA: 0x6CF5BD9068 Offset: 0xB82068 VA: 0x6CF5BD9068
	public static bool SequenceEqual(IEnumerable`1 first, IEnumerable`1 second, IEqualityComparer`1 comparer) { }

	// RVA: 0x6CF5BDDD38 Offset: 0xB86D38 VA: 0x6CF5BDDD38
	public static TSource[] ToArray(IEnumerable`1 source) { }

	// RVA: 0x6CF5BDDD38 Offset: 0xB86D38 VA: 0x6CF5BDDD38
	public static List`1 ToList(IEnumerable`1 source) { }

	// RVA: 0x6CF5BDE694 Offset: 0xB87694 VA: 0x6CF5BDE694
	public static Dictionary`2 ToDictionary(IEnumerable`1 source, Func`2 keySelector, Func`2 elementSelector) { }

	// RVA: 0x6CF5BDE75C Offset: 0xB8775C VA: 0x6CF5BDE75C
	public static Dictionary`2 ToDictionary(IEnumerable`1 source, Func`2 keySelector, Func`2 elementSelector, IEqualityComparer`1 comparer) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static TSource First(IEnumerable`1 source) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static TSource First(IEnumerable`1 source, Func`2 predicate) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static TSource FirstOrDefault(IEnumerable`1 source) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static TSource FirstOrDefault(IEnumerable`1 source, Func`2 predicate) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static TSource LastOrDefault(IEnumerable`1 source, Func`2 predicate) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static TSource SingleOrDefault(IEnumerable`1 source, Func`2 predicate) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static TSource ElementAt(IEnumerable`1 source, int index) { }

	// RVA: 0x6CF67AE7E0 Offset: 0x17577E0 VA: 0x6CF67AE7E0
	public static IEnumerable`1 Range(int start, int count) { }

	// RVA: 0x6CF67AE82C Offset: 0x175782C VA: 0x6CF67AE82C
	private static IEnumerable`1 RangeIterator(int start, int count) { }

	// RVA: 0x6CF5BDDC54 Offset: 0xB86C54 VA: 0x6CF5BDDC54
	public static IEnumerable`1 Empty() { }

	// RVA: 0x6CF5BD8758 Offset: 0xB81758 VA: 0x6CF5BD8758
	public static bool Any(IEnumerable`1 source) { }

	// RVA: 0x6CF5BD8FA4 Offset: 0xB81FA4 VA: 0x6CF5BD8FA4
	public static bool Any(IEnumerable`1 source, Func`2 predicate) { }

	// RVA: 0x6CF5BD8FA4 Offset: 0xB81FA4 VA: 0x6CF5BD8FA4
	public static bool All(IEnumerable`1 source, Func`2 predicate) { }

	// RVA: 0x6CF5BDB424 Offset: 0xB84424 VA: 0x6CF5BDB424
	public static int Count(IEnumerable`1 source) { }

	// RVA: 0x6CF5BDBDDC Offset: 0xB84DDC VA: 0x6CF5BDBDDC
	public static int Count(IEnumerable`1 source, Func`2 predicate) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static bool Contains(IEnumerable`1 source, TSource value) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static bool Contains(IEnumerable`1 source, TSource value, IEqualityComparer`1 comparer) { }

	// RVA: 0x6CF67AE8E0 Offset: 0x17578E0 VA: 0x6CF67AE8E0
	public static int Min(IEnumerable`1 source) { }

	// RVA: 0x6CF67AEC08 Offset: 0x1757C08 VA: 0x6CF67AEC08
	public static int Max(IEnumerable`1 source) { }

}

// Dll : System.Core.dll
// Namespace: System.Linq
internal class EmptyEnumerable`1 : Object
{
	// Fields

	public static readonly TElement[] Instance; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BE00D4 Offset: 0xB890D4 VA: 0x6CF5BE00D4
	private static void .cctor() { }

}

// Dll : System.Core.dll
// Namespace: System.Linq
public interface IOrderedEnumerable`1 : IEnumerable`1, IEnumerable
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public abstract IOrderedEnumerable`1 CreateOrderedEnumerable(Func`2 keySelector, IComparer`1 comparer, bool descending) { }

}

// Dll : System.Core.dll
// Namespace: 
internal struct Slot
{
	// Fields

	internal int hashCode; // 0x0
	internal TElement value; // 0x0
	internal int next; // 0x0

	// Properties


	// Methods

}

// Dll : System.Core.dll
// Namespace: System.Linq
internal class Set`1 : Object
{
	// Fields

	private Int32[] buckets; // 0x0
	private Slot[] slots; // 0x0
	private int count; // 0x0
	private int freeList; // 0x0
	private IEqualityComparer`1 comparer; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public void .ctor(IEqualityComparer`1 comparer) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public bool Add(TElement value) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private bool Find(TElement value, bool add) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	private void Resize() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	internal int InternalGetHashCode(TElement value) { }

}

// Dll : System.Core.dll
// Namespace: 
private sealed class <GetEnumerator>d__1 : Object, IEnumerator`1, IDisposable, IEnumerator
{
	// Fields

	private int <>1__state; // 0x0
	private TElement <>2__current; // 0x0
	public OrderedEnumerable`1 <>4__this; // 0x0
	private Buffer`1 <buffer>5__2; // 0x0
	private Int32[] <map>5__3; // 0x0
	private int <i>5__4; // 0x0

	// Properties

	private TElement System.Collections.Generic.IEnumerator<TElement>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5BD7380 Offset: 0xB80380 VA: 0x6CF5BD7380
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	private bool MoveNext() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : System.Core.dll
// Namespace: System.Linq
internal abstract class OrderedEnumerable`1 : Object, IOrderedEnumerable`1, IEnumerable`1, IEnumerable
{
	// Fields

	internal IEnumerable`1 source; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public IEnumerator`1 GetEnumerator() { }

	// RVA: 0x6CF5BD6D7C Offset: 0xB7FD7C VA: 0x6CF5BD6D7C
	internal abstract EnumerableSorter`1 GetEnumerableSorter(EnumerableSorter`1 next) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	private IOrderedEnumerable`1 System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable(Func`2 keySelector, IComparer`1 comparer, bool descending) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	protected void .ctor() { }

}

// Dll : System.Core.dll
// Namespace: System.Linq
internal class OrderedEnumerable`2 : OrderedEnumerable`1
{
	// Fields

	internal OrderedEnumerable`1 parent; // 0x0
	internal Func`2 keySelector; // 0x0
	internal IComparer`1 comparer; // 0x0
	internal bool descending; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	internal void .ctor(IEnumerable`1 source, Func`2 keySelector, IComparer`1 comparer, bool descending) { }

	// RVA: 0x6CF5BD6D7C Offset: 0xB7FD7C VA: 0x6CF5BD6D7C
	internal override EnumerableSorter`1 GetEnumerableSorter(EnumerableSorter`1 next) { }

}

// Dll : System.Core.dll
// Namespace: System.Linq
internal abstract class EnumerableSorter`1 : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5BD75A8 Offset: 0xB805A8 VA: 0x6CF5BD75A8
	internal abstract void ComputeKeys(TElement[] elements, int count) { }

	// RVA: 0x6CF5BD6A88 Offset: 0xB7FA88 VA: 0x6CF5BD6A88
	internal abstract int CompareKeys(int index1, int index2) { }

	// RVA: 0x6CF5BD6DFC Offset: 0xB7FDFC VA: 0x6CF5BD6DFC
	internal Int32[] Sort(TElement[] elements, int count) { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	private void QuickSort(Int32[] map, int left, int right) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	protected void .ctor() { }

}

// Dll : System.Core.dll
// Namespace: System.Linq
internal class EnumerableSorter`2 : EnumerableSorter`1
{
	// Fields

	internal Func`2 keySelector; // 0x0
	internal IComparer`1 comparer; // 0x0
	internal bool descending; // 0x0
	internal EnumerableSorter`1 next; // 0x0
	internal TKey[] keys; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	internal void .ctor(Func`2 keySelector, IComparer`1 comparer, bool descending, EnumerableSorter`1 next) { }

	// RVA: 0x6CF5BD75A8 Offset: 0xB805A8 VA: 0x6CF5BD75A8
	internal override void ComputeKeys(TElement[] elements, int count) { }

	// RVA: 0x6CF5BD6A88 Offset: 0xB7FA88 VA: 0x6CF5BD6A88
	internal override int CompareKeys(int index1, int index2) { }

}

// Dll : System.Core.dll
// Namespace: System.Linq
internal struct Buffer`1
{
	// Fields

	internal TElement[] items; // 0x0
	internal int count; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	internal void .ctor(IEnumerable`1 source) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	internal TElement[] ToArray() { }

}

// Dll : System.Core.dll
// Namespace: 
internal struct Slot
{
	// Fields

	internal int hashCode; // 0x0
	internal int next; // 0x0
	internal T value; // 0x0

	// Properties


	// Methods

}

// Dll : System.Core.dll
// Namespace: 
[Serializable]
public struct Enumerator : IEnumerator`1, IDisposable, IEnumerator
{
	// Fields

	private HashSet`1 _set; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0

	// Properties

	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	internal void .ctor(HashSet`1 set) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void Dispose() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public bool MoveNext() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public T get_Current() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	private void System.Collections.IEnumerator.Reset() { }

}

// Dll : System.Core.dll
// Namespace: System.Collections.Generic
[Serializable]
public class HashSet`1 : Object, ICollection`1, IEnumerable`1, IEnumerable, ISet`1, IReadOnlyCollection`1, ISerializable, IDeserializationCallback
{
	// Fields

	private const int Lower31BitMask; // 0x0
	private const int StackAllocThreshold; // 0x0
	private const int ShrinkThreshold; // 0x0
	private const string CapacityName; // 0x0
	private const string ElementsName; // 0x0
	private const string ComparerName; // 0x0
	private const string VersionName; // 0x0
	private Int32[] _buckets; // 0x0
	private Slot[] _slots; // 0x0
	private int _count; // 0x0
	private int _lastIndex; // 0x0
	private int _freeList; // 0x0
	private IEqualityComparer`1 _comparer; // 0x0
	private int _version; // 0x0
	private SerializationInfo _siInfo; // 0x0

	// Properties

	public int Count { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	public IEqualityComparer`1 Comparer { get; }

	// Methods

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void .ctor() { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public void .ctor(IEqualityComparer`1 comparer) { }

	// RVA: 0x6CF5BD7380 Offset: 0xB80380 VA: 0x6CF5BD7380
	public void .ctor(int capacity) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public void .ctor(IEnumerable`1 collection) { }

	// RVA: 0x6CF5BD766C Offset: 0xB8066C VA: 0x6CF5BD766C
	public void .ctor(IEnumerable`1 collection, IEqualityComparer`1 comparer) { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	private void CopyFrom(HashSet`1 source) { }

	// RVA: 0x6CF5BD7408 Offset: 0xB80408 VA: 0x6CF5BD7408
	public void .ctor(int capacity, IEqualityComparer`1 comparer) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void Clear() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public bool Contains(T item) { }

	// RVA: 0x6CF5BD75A8 Offset: 0xB805A8 VA: 0x6CF5BD75A8
	public void CopyTo(T[] array, int arrayIndex) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public bool Remove(T item) { }

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	public int get_Count() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public Enumerator GetEnumerator() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IEnumerator`1 System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public bool Add(T item) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public void UnionWith(IEnumerable`1 other) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public void CopyTo(T[] array) { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public void CopyTo(T[] array, int arrayIndex, int count) { }

	// RVA: 0x6CF5BD6B20 Offset: 0xB7FB20 VA: 0x6CF5BD6B20
	public int RemoveWhere(Predicate`1 match) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public IEqualityComparer`1 get_Comparer() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void TrimExcess() { }

	// RVA: 0x6CF5BD6A44 Offset: 0xB7FA44 VA: 0x6CF5BD6A44
	private int Initialize(int capacity) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	private void IncreaseCapacity() { }

	// RVA: 0x6CF5BD7380 Offset: 0xB80380 VA: 0x6CF5BD7380
	private void SetCapacity(int newSize) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private bool AddIfNotPresent(T value) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private void AddValue(int index, int hashCode, T value) { }

	// RVA: 0x6CF5BD8FA4 Offset: 0xB81FA4 VA: 0x6CF5BD8FA4
	private static bool AreEqualityComparersEqual(HashSet`1 set1, HashSet`1 set2) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private int InternalGetHashCode(T item) { }

}

// Dll : System.Core.dll
// Namespace: System.Collections.Generic
internal sealed class ICollectionDebugView`1 : Object
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.Core.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=120
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.Core.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=256
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.Core.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=1024
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.Core.dll
// Namespace: 
internal sealed class <PrivateImplementationDetails> : Object
{
	// Fields

	internal static readonly __StaticArrayInitTypeSize=1024 0270BFF41CB170C33C20788C368CB1B5A66B0FD0B98D638A827B783537583821; // 0x0
	internal static readonly __StaticArrayInitTypeSize=1024 09FDC69AA887AC8D36E0C8284C7B1D53E580E4880B72A67FF80D7E38317115D9; // 0x400
	internal static readonly __StaticArrayInitTypeSize=1024 0F4764044BF2E91EFEFAF3D4F1E81C10A2B7F0F45305489925CFC01198CF45B5; // 0x800
	internal static readonly __StaticArrayInitTypeSize=1024 15A0E7628178B3FE6546E9B60F35E2B1C4864E020B16376866F38F72C74B45A9; // 0xC00
	internal static readonly __StaticArrayInitTypeSize=1024 4CF8DC711CD3210D673D86981355E2609233025ED22E4DC7A1F9B8E75ADE35F4; // 0x1000
	internal static readonly __StaticArrayInitTypeSize=1024 783FB0A44BE7670EB6EC170CF7F16BB2B6F23F4964B87B60C4EB506C7C6A286D; // 0x1400
	internal static readonly __StaticArrayInitTypeSize=120 914FCE8DC82DA59038745B264F743222527FBAE2E4A28E71C89760B7E3DBBA67; // 0x1800
	internal static readonly __StaticArrayInitTypeSize=256 93631B0726F6FE6629DAA743EE51B49F4477ED07391B68EEEA0672A4A90018AA; // 0x1878
	internal static readonly __StaticArrayInitTypeSize=256 C2D8E5EED6CBEBD8625FC18F81486A7733C04F9B0129FFBE974C68B90308B4F2; // 0x1978
	internal static readonly __StaticArrayInitTypeSize=1024 C40A9A77EE05E10AF16DA9D1781A2053159EA8570ADA03637BB5FE3D076C9F89; // 0x1A78
	internal static readonly __StaticArrayInitTypeSize=1024 E8058399671D13082C35B6B3CE7F9E282507EDD458CCFDD3BAD9F35D90016F62; // 0x1E78

	// Properties


	// Methods

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public class CreatePropertyAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public class DontCreatePropertyAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public sealed class PropertyGetter`2 : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public virtual TValue Invoke(ref TContainer container) { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public sealed class PropertySetter`2 : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public virtual void Invoke(ref TContainer container, TValue value) { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public class DelegateProperty`2 : Property`2
{
	// Fields

	private readonly PropertyGetter`2 m_Getter; // 0x0
	private readonly PropertySetter`2 m_Setter; // 0x0
	private readonly string <Name>k__BackingField; // 0x0

	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public override string get_Name() { }

	// RVA: 0x6CF5BD773C Offset: 0xB8073C VA: 0x6CF5BD773C
	public void .ctor(string name, PropertyGetter`2 getter, PropertySetter`2 setter) { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public interface IProperty
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public abstract Type DeclaredValueType() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public interface IProperty`1 : IProperty
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public abstract class Property`2 : Object, IProperty`1, IProperty, IAttributes
{
	// Fields

	private List`1 m_Attributes; // 0x0

	// Properties

	public abstract string Name { get; }

	// Methods

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public abstract string get_Name() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public Type DeclaredValueType() { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	protected void AddAttribute(Attribute attribute) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	protected void AddAttributes(IEnumerable`1 attributes) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	private void Unity.Properties.Internal.IAttributes.AddAttribute(Attribute attribute) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	private void Unity.Properties.Internal.IAttributes.AddAttributes(IEnumerable`1 attributes) { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public bool HasAttribute() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	protected void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
internal interface IMemberInfo
{
	// Fields


	// Properties

	public abstract string Name { get; }
	public abstract bool IsReadOnly { get; }
	public abstract Type ValueType { get; }

	// Methods

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public abstract string get_Name() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public abstract bool get_IsReadOnly() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public abstract Type get_ValueType() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public abstract IEnumerable`1 GetCustomAttributes() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
internal struct FieldMember : IMemberInfo
{
	// Fields

	internal readonly FieldInfo m_FieldInfo; // 0x10
	private readonly string <Name>k__BackingField; // 0x18

	// Properties

	public string Name { get; }
	public bool IsReadOnly { get; }
	public Type ValueType { get; }

	// Methods

	// RVA: 0x6CF69D3538 Offset: 0x197C538 VA: 0x6CF69D3538
	public void .ctor(FieldInfo fieldInfo) { }

	// RVA: 0x6CF69D364C Offset: 0x197C64C VA: 0x6CF69D364C
	public string get_Name() { }

	// RVA: 0x6CF69D3654 Offset: 0x197C654 VA: 0x6CF69D3654
	public bool get_IsReadOnly() { }

	// RVA: 0x6CF69D3670 Offset: 0x197C670 VA: 0x6CF69D3670
	public Type get_ValueType() { }

	// RVA: 0x6CF69D3694 Offset: 0x197C694 VA: 0x6CF69D3694
	public IEnumerable`1 GetCustomAttributes() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
internal struct PropertyMember : IMemberInfo
{
	// Fields

	internal readonly PropertyInfo m_PropertyInfo; // 0x10
	private readonly string <Name>k__BackingField; // 0x18

	// Properties

	public string Name { get; }
	public bool IsReadOnly { get; }
	public Type ValueType { get; }

	// Methods

	// RVA: 0x6CF69D36A0 Offset: 0x197C6A0 VA: 0x6CF69D36A0
	public string get_Name() { }

	// RVA: 0x6CF69D36A8 Offset: 0x197C6A8 VA: 0x6CF69D36A8
	public bool get_IsReadOnly() { }

	// RVA: 0x6CF69D36D8 Offset: 0x197C6D8 VA: 0x6CF69D36D8
	public Type get_ValueType() { }

	// RVA: 0x6CF69D36FC Offset: 0x197C6FC VA: 0x6CF69D36FC
	public void .ctor(PropertyInfo propertyInfo) { }

	// RVA: 0x6CF69D371C Offset: 0x197C71C VA: 0x6CF69D371C
	public IEnumerable`1 GetCustomAttributes() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private sealed class GetStructValueAction : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public virtual TValue Invoke(ref TContainer container) { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private sealed class SetStructValueAction : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public virtual void Invoke(ref TContainer container, TValue value) { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private sealed class GetClassValueAction : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public virtual TValue Invoke(TContainer container) { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private sealed class SetClassValueAction : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public virtual void Invoke(TContainer container, TValue value) { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public class ReflectedMemberProperty`2 : Property`2
{
	// Fields

	private readonly IMemberInfo m_Info; // 0x0
	private readonly bool m_IsStructContainerType; // 0x0
	private GetStructValueAction m_GetStructValueAction; // 0x0
	private SetStructValueAction m_SetStructValueAction; // 0x0
	private GetClassValueAction m_GetClassValueAction; // 0x0
	private SetClassValueAction m_SetClassValueAction; // 0x0
	private readonly string <Name>k__BackingField; // 0x0
	private readonly bool <IsReadOnly>k__BackingField; // 0x0

	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public override string get_Name() { }

	// RVA: 0x6CF5BD766C Offset: 0xB8066C VA: 0x6CF5BD766C
	internal void .ctor(IMemberInfo info, string name) { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public sealed class ArrayPropertyBag`1 : IndexedCollectionPropertyBag`2
{
	// Fields


	// Properties

	protected override InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	protected override InstantiationKind get_InstantiationKind() { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	protected override TElement[] InstantiateWithCount(int count) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	protected override TElement[] Instantiate() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public abstract class ContainerPropertyBag`1 : PropertyBag`1
{
	// Fields

	private readonly List`1 m_PropertiesList; // 0x0
	private readonly Dictionary`2 m_PropertiesHash; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BE00D4 Offset: 0xB890D4 VA: 0x6CF5BE00D4
	private static void .cctor() { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	protected void AddProperty(Property`2 property) { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public bool TryGetProperty(ref TContainer container, string name, ref IProperty`1 property) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	protected void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public class DictionaryPropertyBag`2 : KeyValueCollectionPropertyBag`3
{
	// Fields


	// Properties

	protected override InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	protected override InstantiationKind get_InstantiationKind() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	protected override Dictionary`2 Instantiate() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public class HashSetPropertyBag`1 : SetPropertyBagBase`2
{
	// Fields


	// Properties

	protected override InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	protected override InstantiationKind get_InstantiationKind() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	protected override HashSet`1 Instantiate() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public interface IPropertyBag
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public abstract void Accept(ITypeVisitor visitor) { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public interface IPropertyBag`1 : IPropertyBag
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class ListElementProperty : Property`2
{
	// Fields

	internal int m_Index; // 0x0

	// Properties

	public int Index { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	public int get_Index() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public override string get_Name() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public class IndexedCollectionPropertyBag`2 : PropertyBag`1, IPropertyBag`1, IPropertyBag, IConstructorWithCount`1, IConstructor
{
	// Fields

	private readonly ListElementProperty m_Property; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private TList Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount(int count) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	protected virtual TList InstantiateWithCount(int count) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class KeyValuePairProperty : Property`2
{
	// Fields

	private TKey <Key>k__BackingField; // 0x0

	// Properties

	public override string Name { get; }
	public TKey Key { get; }

	// Methods

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public override string get_Name() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public TKey get_Key() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public class KeyValueCollectionPropertyBag`3 : PropertyBag`1, IPropertyBag`1, IPropertyBag
{
	// Fields

	private readonly KeyValuePairProperty m_KeyValuePairProperty; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
[Serializable]
private sealed class <>c : Object
{
	// Fields

	public static readonly <>c <>9; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BE00D4 Offset: 0xB890D4 VA: 0x6CF5BE00D4
	private static void .cctor() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void .ctor() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	internal TKey <.cctor>b__7_0(ref KeyValuePair`2 container) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	internal TValue <.cctor>b__7_1(ref KeyValuePair`2 container) { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public class KeyValuePairPropertyBag`2 : PropertyBag`1
{
	// Fields

	private static readonly DelegateProperty`2 s_KeyProperty; // 0x0
	private static readonly DelegateProperty`2 s_ValueProperty; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void .ctor() { }

	// RVA: 0x6CF5BE00D4 Offset: 0xB890D4 VA: 0x6CF5BE00D4
	private static void .cctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public class ListPropertyBag`1 : IndexedCollectionPropertyBag`2
{
	// Fields


	// Properties

	protected override InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	protected override InstantiationKind get_InstantiationKind() { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	protected override List`1 InstantiateWithCount(int count) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	protected override List`1 Instantiate() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public static class PropertyBag : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5BE0BD0 Offset: 0xB89BD0 VA: 0x6CF5BE0BD0
	public static void Register(PropertyBag`1 propertyBag) { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public abstract class PropertyBag`1 : Object, IPropertyBag`1, IPropertyBag, IPropertyBagRegister, IConstructor`1, IConstructor
{
	// Fields

	private readonly InstantiationKind <InstantiationKind>k__BackingField; // 0x0

	// Properties

	private InstantiationKind Unity.Properties.IConstructor.InstantiationKind { get; }
	protected virtual InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: 0x6CF5BE00D4 Offset: 0xB890D4 VA: 0x6CF5BE00D4
	private static void .cctor() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	private void Unity.Properties.Internal.IPropertyBagRegister.Register() { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public void Accept(ITypeVisitor visitor) { }

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	private InstantiationKind Unity.Properties.IConstructor.get_InstantiationKind() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private TContainer Unity.Properties.IConstructor<TContainer>.Instantiate() { }

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	protected virtual InstantiationKind get_InstantiationKind() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	protected virtual TContainer Instantiate() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	protected void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class SetElementProperty : Property`2
{
	// Fields

	internal TElement m_Value; // 0x0

	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public override string get_Name() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public class SetPropertyBagBase`2 : PropertyBag`1, IPropertyBag`1, IPropertyBag
{
	// Fields

	private readonly SetElementProperty m_Property; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public interface ITypeVisitor
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public abstract void Visit() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public static class TypeTraits : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D3728 Offset: 0x197C728 VA: 0x6CF69D3728
	public static bool IsContainer(Type type) { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public static class TypeTraits`1 : Object
{
	// Fields

	private static readonly bool <IsValueType>k__BackingField; // 0x0
	private static readonly bool <IsPrimitive>k__BackingField; // 0x0
	private static readonly bool <IsInterface>k__BackingField; // 0x0
	private static readonly bool <IsAbstract>k__BackingField; // 0x0
	private static readonly bool <IsArray>k__BackingField; // 0x0
	private static readonly bool <IsMultidimensionalArray>k__BackingField; // 0x0
	private static readonly bool <IsEnum>k__BackingField; // 0x0
	private static readonly bool <IsEnumFlags>k__BackingField; // 0x0
	private static readonly bool <IsNullable>k__BackingField; // 0x0
	private static readonly bool <IsObject>k__BackingField; // 0x0
	private static readonly bool <IsString>k__BackingField; // 0x0
	private static readonly bool <IsContainer>k__BackingField; // 0x0
	private static readonly bool <CanBeNull>k__BackingField; // 0x0
	private static readonly bool <IsPrimitiveOrString>k__BackingField; // 0x0
	private static readonly bool <IsAbstractOrInterface>k__BackingField; // 0x0
	private static readonly bool <IsUnityObject>k__BackingField; // 0x0
	private static readonly bool <IsLazyLoadReference>k__BackingField; // 0x0

	// Properties

	public static bool IsValueType { get; }
	public static bool IsPrimitive { get; }
	public static bool IsInterface { get; }
	public static bool IsAbstract { get; }
	public static bool IsArray { get; }
	public static bool IsEnum { get; }
	public static bool IsNullable { get; }
	public static bool IsObject { get; }
	public static bool IsString { get; }
	public static bool IsContainer { get; }
	public static bool CanBeNull { get; }
	public static bool IsAbstractOrInterface { get; }

	// Methods

	// RVA: 0x6CF5BD7D60 Offset: 0xB80D60 VA: 0x6CF5BD7D60
	public static bool get_IsValueType() { }

	// RVA: 0x6CF5BD7D60 Offset: 0xB80D60 VA: 0x6CF5BD7D60
	public static bool get_IsPrimitive() { }

	// RVA: 0x6CF5BD7D60 Offset: 0xB80D60 VA: 0x6CF5BD7D60
	public static bool get_IsInterface() { }

	// RVA: 0x6CF5BD7D60 Offset: 0xB80D60 VA: 0x6CF5BD7D60
	public static bool get_IsAbstract() { }

	// RVA: 0x6CF5BD7D60 Offset: 0xB80D60 VA: 0x6CF5BD7D60
	public static bool get_IsArray() { }

	// RVA: 0x6CF5BD7D60 Offset: 0xB80D60 VA: 0x6CF5BD7D60
	public static bool get_IsEnum() { }

	// RVA: 0x6CF5BD7D60 Offset: 0xB80D60 VA: 0x6CF5BD7D60
	public static bool get_IsNullable() { }

	// RVA: 0x6CF5BD7D60 Offset: 0xB80D60 VA: 0x6CF5BD7D60
	public static bool get_IsObject() { }

	// RVA: 0x6CF5BD7D60 Offset: 0xB80D60 VA: 0x6CF5BD7D60
	public static bool get_IsString() { }

	// RVA: 0x6CF5BD7D60 Offset: 0xB80D60 VA: 0x6CF5BD7D60
	public static bool get_IsContainer() { }

	// RVA: 0x6CF5BD7D60 Offset: 0xB80D60 VA: 0x6CF5BD7D60
	public static bool get_CanBeNull() { }

	// RVA: 0x6CF5BD7D60 Offset: 0xB80D60 VA: 0x6CF5BD7D60
	public static bool get_IsAbstractOrInterface() { }

	// RVA: 0x6CF5BE00D4 Offset: 0xB890D4 VA: 0x6CF5BE00D4
	private static void .cctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public enum InstantiationKind
{
	// Fields

	public int value__; // 0x10
	public const InstantiationKind Activator = 0; // 0x0
	public const InstantiationKind PropertyBagOverride = 1; // 0x0
	public const InstantiationKind NotInstantiatable = 2; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
internal interface IConstructor
{
	// Fields


	// Properties

	public abstract InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	public abstract InstantiationKind get_InstantiationKind() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
internal interface IConstructor`1 : IConstructor
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public abstract T Instantiate() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
internal interface IConstructorWithCount`1 : IConstructor
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public abstract T InstantiateWithCount(int count) { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private interface ITypeConstructor
{
	// Fields


	// Properties

	public abstract bool CanBeInstantiated { get; }

	// Methods

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public abstract bool get_CanBeInstantiated() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public abstract object Instantiate() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private interface ITypeConstructor`1 : ITypeConstructor
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public abstract T Instantiate() { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public abstract void SetExplicitConstructor(Func`1 constructor) { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class TypeConstructor`1 : Object, ITypeConstructor`1, ITypeConstructor
{
	// Fields

	private Func`1 m_ExplicitConstructor; // 0x0
	private Func`1 m_ImplicitConstructor; // 0x0
	private IConstructor`1 m_OverrideConstructor; // 0x0

	// Properties

	private bool Unity.Properties.TypeUtility.ITypeConstructor.CanBeInstantiated { get; }

	// Methods

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	private bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void .ctor() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	private void SetImplicitConstructor() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private static T CreateValueTypeInstance() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private static T CreateScriptableObjectInstance() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private static T CreateClassInstance() { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public void SetExplicitConstructor(Func`1 constructor) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private T Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private object Unity.Properties.TypeUtility.ITypeConstructor.Instantiate() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class NonConstructable : Object, ITypeConstructor
{
	// Fields


	// Properties

	private bool Unity.Properties.TypeUtility.ITypeConstructor.CanBeInstantiated { get; }

	// Methods

	// RVA: 0x6CF69D5198 Offset: 0x197E198 VA: 0x6CF69D5198
	private bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }

	// RVA: 0x6CF69D51A0 Offset: 0x197E1A0 VA: 0x6CF69D51A0
	public object Instantiate() { }

	// RVA: 0x6CF69D4D74 Offset: 0x197DD74 VA: 0x6CF69D4D74
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private struct Cache`1
{
	// Fields

	public static ITypeConstructor`1 TypeConstructor; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class TypeConstructorVisitor : Object, ITypeVisitor
{
	// Fields

	public ITypeConstructor TypeConstructor; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void Visit() { }

	// RVA: 0x6CF69D4D6C Offset: 0x197DD6C VA: 0x6CF69D4D6C
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
[Serializable]
private sealed class <>c : Object
{
	// Fields

	public static readonly <>c <>9; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF69D51EC Offset: 0x197E1EC VA: 0x6CF69D51EC
	private static void .cctor() { }

	// RVA: 0x6CF69D5248 Offset: 0x197E248 VA: 0x6CF69D5248
	public void .ctor() { }

	// RVA: 0x6CF69D5250 Offset: 0x197E250 VA: 0x6CF69D5250
	internal StringBuilder <.cctor>b__11_0() { }

	// RVA: 0x6CF69D52A4 Offset: 0x197E2A4 VA: 0x6CF69D52A4
	internal void <.cctor>b__11_1(StringBuilder sb) { }

	// RVA: 0x6CF69D52BC Offset: 0x197E2BC VA: 0x6CF69D52BC
	internal string <.cctor>b__11_2() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public static class TypeUtility : Object
{
	// Fields

	private static readonly ConcurrentDictionary`2 s_TypeConstructors; // 0x0
	private static readonly MethodInfo s_CreateTypeConstructor; // 0x8
	private static readonly ConcurrentDictionary`2 s_CachedResolvedName; // 0x10
	private static readonly ObjectPool`1 s_Builders; // 0x18
	private static readonly object syncedPoolObject; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF69D3868 Offset: 0x197C868 VA: 0x6CF69D3868
	private static void .cctor() { }

	// RVA: 0x6CF69D3C80 Offset: 0x197CC80 VA: 0x6CF69D3C80
	public static string GetTypeDisplayName(Type type) { }

	// RVA: 0x6CF69D3D98 Offset: 0x197CD98 VA: 0x6CF69D3D98
	private static string GetTypeDisplayName(Type type, IReadOnlyList`1 args, ref int argIndex) { }

	// RVA: 0x6CF69D473C Offset: 0x197D73C VA: 0x6CF69D473C
	public static Type GetRootType(Type type) { }

	// RVA: 0x6CF69D4870 Offset: 0x197D870 VA: 0x6CF69D4870
	private static ITypeConstructor CreateTypeConstructor(Type type) { }

	// RVA: 0x6CF5BDDC54 Offset: 0xB86C54 VA: 0x6CF5BDDC54
	private static ITypeConstructor`1 CreateTypeConstructor() { }

	// RVA: 0x6CF69D4D7C Offset: 0x197DD7C VA: 0x6CF69D4D7C
	private static ITypeConstructor GetTypeConstructor(Type type) { }

	// RVA: 0x6CF5BDDC54 Offset: 0xB86C54 VA: 0x6CF5BDDC54
	private static ITypeConstructor`1 GetTypeConstructor() { }

	// RVA: 0x6CF69D4E34 Offset: 0x197DE34 VA: 0x6CF69D4E34
	public static bool CanBeInstantiated(Type type) { }

	// RVA: 0x6CF5BD7D60 Offset: 0xB80D60 VA: 0x6CF5BD7D60
	public static bool CanBeInstantiated() { }

	// RVA: 0x6CF5BE0BD0 Offset: 0xB89BD0 VA: 0x6CF5BE0BD0
	public static void SetExplicitInstantiationMethod(Func`1 constructor) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static T Instantiate() { }

	// RVA: 0x6CF5BD8758 Offset: 0xB81758 VA: 0x6CF5BD8758
	public static bool TryInstantiate(ref T instance) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static T Instantiate(Type derivedType) { }

	// RVA: 0x6CF5BD8FA4 Offset: 0xB81FA4 VA: 0x6CF5BD8FA4
	public static bool TryInstantiate(Type derivedType, ref T value) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static TArray InstantiateArray(int count) { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public static bool TryInstantiateArray(int count, ref TArray instance) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static TArray InstantiateArray(Type derivedType, int count) { }

	// RVA: 0x6CF69D4F00 Offset: 0x197DF00 VA: 0x6CF69D4F00
	private static void CheckIsAssignableFrom(Type type, Type derivedType) { }

	// RVA: 0x6CF5BE0BD0 Offset: 0xB89BD0 VA: 0x6CF5BE0BD0
	private static void CheckCanBeInstantiated(ITypeConstructor`1 constructor) { }

	// RVA: 0x6CF69D5068 Offset: 0x197E068 VA: 0x6CF69D5068
	private static void CheckCanBeInstantiated(ITypeConstructor constructor, Type type) { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties.Internal
internal interface IAttributes
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public abstract void AddAttribute(Attribute attribute) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public abstract void AddAttributes(IEnumerable`1 attributes) { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties.Internal
internal static class DefaultPropertyBagInitializer : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D5304 Offset: 0x197E304 VA: 0x6CF69D5304
	internal static void Initialize() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class RProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D644C Offset: 0x197F44C VA: 0x6CF69D644C
	public override string get_Name() { }

	// RVA: 0x6CF69D632C Offset: 0x197F32C VA: 0x6CF69D632C
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class GProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D648C Offset: 0x197F48C VA: 0x6CF69D648C
	public override string get_Name() { }

	// RVA: 0x6CF69D6374 Offset: 0x197F374 VA: 0x6CF69D6374
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class BProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D64CC Offset: 0x197F4CC VA: 0x6CF69D64CC
	public override string get_Name() { }

	// RVA: 0x6CF69D63BC Offset: 0x197F3BC VA: 0x6CF69D63BC
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class AProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D650C Offset: 0x197F50C VA: 0x6CF69D650C
	public override string get_Name() { }

	// RVA: 0x6CF69D6404 Offset: 0x197F404 VA: 0x6CF69D6404
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties.Internal
internal class ColorPropertyBag : ContainerPropertyBag`1
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D5634 Offset: 0x197E634 VA: 0x6CF69D5634
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class XProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D65DC Offset: 0x197F5DC VA: 0x6CF69D65DC
	public override string get_Name() { }

	// RVA: 0x6CF69D654C Offset: 0x197F54C VA: 0x6CF69D654C
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class YProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D661C Offset: 0x197F61C VA: 0x6CF69D661C
	public override string get_Name() { }

	// RVA: 0x6CF69D6594 Offset: 0x197F594 VA: 0x6CF69D6594
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties.Internal
internal class Vector2PropertyBag : ContainerPropertyBag`1
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D5794 Offset: 0x197E794 VA: 0x6CF69D5794
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class XProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D6734 Offset: 0x197F734 VA: 0x6CF69D6734
	public override string get_Name() { }

	// RVA: 0x6CF69D665C Offset: 0x197F65C VA: 0x6CF69D665C
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class YProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D6774 Offset: 0x197F774 VA: 0x6CF69D6774
	public override string get_Name() { }

	// RVA: 0x6CF69D66A4 Offset: 0x197F6A4 VA: 0x6CF69D66A4
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class ZProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D67B4 Offset: 0x197F7B4 VA: 0x6CF69D67B4
	public override string get_Name() { }

	// RVA: 0x6CF69D66EC Offset: 0x197F6EC VA: 0x6CF69D66EC
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties.Internal
internal class Vector3PropertyBag : ContainerPropertyBag`1
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D5884 Offset: 0x197E884 VA: 0x6CF69D5884
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class XProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D6914 Offset: 0x197F914 VA: 0x6CF69D6914
	public override string get_Name() { }

	// RVA: 0x6CF69D67F4 Offset: 0x197F7F4 VA: 0x6CF69D67F4
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class YProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D6954 Offset: 0x197F954 VA: 0x6CF69D6954
	public override string get_Name() { }

	// RVA: 0x6CF69D683C Offset: 0x197F83C VA: 0x6CF69D683C
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class ZProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D6994 Offset: 0x197F994 VA: 0x6CF69D6994
	public override string get_Name() { }

	// RVA: 0x6CF69D6884 Offset: 0x197F884 VA: 0x6CF69D6884
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class WProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D69D4 Offset: 0x197F9D4 VA: 0x6CF69D69D4
	public override string get_Name() { }

	// RVA: 0x6CF69D68CC Offset: 0x197F8CC VA: 0x6CF69D68CC
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties.Internal
internal class Vector4PropertyBag : ContainerPropertyBag`1
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D59B0 Offset: 0x197E9B0 VA: 0x6CF69D59B0
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class XProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D6AA4 Offset: 0x197FAA4 VA: 0x6CF69D6AA4
	public override string get_Name() { }

	// RVA: 0x6CF69D6A14 Offset: 0x197FA14 VA: 0x6CF69D6A14
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class YProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D6AE4 Offset: 0x197FAE4 VA: 0x6CF69D6AE4
	public override string get_Name() { }

	// RVA: 0x6CF69D6A5C Offset: 0x197FA5C VA: 0x6CF69D6A5C
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties.Internal
internal class Vector2IntPropertyBag : ContainerPropertyBag`1
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D5B10 Offset: 0x197EB10 VA: 0x6CF69D5B10
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class XProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D6BFC Offset: 0x197FBFC VA: 0x6CF69D6BFC
	public override string get_Name() { }

	// RVA: 0x6CF69D6B24 Offset: 0x197FB24 VA: 0x6CF69D6B24
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class YProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D6C3C Offset: 0x197FC3C VA: 0x6CF69D6C3C
	public override string get_Name() { }

	// RVA: 0x6CF69D6B6C Offset: 0x197FB6C VA: 0x6CF69D6B6C
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class ZProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D6C7C Offset: 0x197FC7C VA: 0x6CF69D6C7C
	public override string get_Name() { }

	// RVA: 0x6CF69D6BB4 Offset: 0x197FBB4 VA: 0x6CF69D6BB4
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties.Internal
internal class Vector3IntPropertyBag : ContainerPropertyBag`1
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D5C00 Offset: 0x197EC00 VA: 0x6CF69D5C00
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class XProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D6DDC Offset: 0x197FDDC VA: 0x6CF69D6DDC
	public override string get_Name() { }

	// RVA: 0x6CF69D6CBC Offset: 0x197FCBC VA: 0x6CF69D6CBC
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class YProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D6E1C Offset: 0x197FE1C VA: 0x6CF69D6E1C
	public override string get_Name() { }

	// RVA: 0x6CF69D6D04 Offset: 0x197FD04 VA: 0x6CF69D6D04
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class WidthProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D6E5C Offset: 0x197FE5C VA: 0x6CF69D6E5C
	public override string get_Name() { }

	// RVA: 0x6CF69D6D4C Offset: 0x197FD4C VA: 0x6CF69D6D4C
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class HeightProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D6E9C Offset: 0x197FE9C VA: 0x6CF69D6E9C
	public override string get_Name() { }

	// RVA: 0x6CF69D6D94 Offset: 0x197FD94 VA: 0x6CF69D6D94
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties.Internal
internal class RectPropertyBag : ContainerPropertyBag`1
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D5D2C Offset: 0x197ED2C VA: 0x6CF69D5D2C
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class XProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D6FFC Offset: 0x197FFFC VA: 0x6CF69D6FFC
	public override string get_Name() { }

	// RVA: 0x6CF69D6EDC Offset: 0x197FEDC VA: 0x6CF69D6EDC
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class YProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D703C Offset: 0x198003C VA: 0x6CF69D703C
	public override string get_Name() { }

	// RVA: 0x6CF69D6F24 Offset: 0x197FF24 VA: 0x6CF69D6F24
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class WidthProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D707C Offset: 0x198007C VA: 0x6CF69D707C
	public override string get_Name() { }

	// RVA: 0x6CF69D6F6C Offset: 0x197FF6C VA: 0x6CF69D6F6C
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class HeightProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D70BC Offset: 0x19800BC VA: 0x6CF69D70BC
	public override string get_Name() { }

	// RVA: 0x6CF69D6FB4 Offset: 0x197FFB4 VA: 0x6CF69D6FB4
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties.Internal
internal class RectIntPropertyBag : ContainerPropertyBag`1
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D5E8C Offset: 0x197EE8C VA: 0x6CF69D5E8C
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class CenterProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D718C Offset: 0x198018C VA: 0x6CF69D718C
	public override string get_Name() { }

	// RVA: 0x6CF69D70FC Offset: 0x19800FC VA: 0x6CF69D70FC
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class ExtentsProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D71CC Offset: 0x19801CC VA: 0x6CF69D71CC
	public override string get_Name() { }

	// RVA: 0x6CF69D7144 Offset: 0x1980144 VA: 0x6CF69D7144
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties.Internal
internal class BoundsPropertyBag : ContainerPropertyBag`1
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D5FEC Offset: 0x197EFEC VA: 0x6CF69D5FEC
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class PositionProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D729C Offset: 0x198029C VA: 0x6CF69D729C
	public override string get_Name() { }

	// RVA: 0x6CF69D720C Offset: 0x198020C VA: 0x6CF69D720C
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class SizeProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D72DC Offset: 0x19802DC VA: 0x6CF69D72DC
	public override string get_Name() { }

	// RVA: 0x6CF69D7254 Offset: 0x1980254 VA: 0x6CF69D7254
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties.Internal
internal class BoundsIntPropertyBag : ContainerPropertyBag`1
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D60DC Offset: 0x197F0DC VA: 0x6CF69D60DC
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class MajorProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D731C Offset: 0x198031C VA: 0x6CF69D731C
	public void .ctor() { }

	// RVA: 0x6CF69D759C Offset: 0x198059C VA: 0x6CF69D759C
	public override string get_Name() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class MinorProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D73BC Offset: 0x19803BC VA: 0x6CF69D73BC
	public void .ctor() { }

	// RVA: 0x6CF69D75DC Offset: 0x19805DC VA: 0x6CF69D75DC
	public override string get_Name() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class BuildProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D745C Offset: 0x198045C VA: 0x6CF69D745C
	public void .ctor() { }

	// RVA: 0x6CF69D761C Offset: 0x198061C VA: 0x6CF69D761C
	public override string get_Name() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private class RevisionProperty : Property`2
{
	// Fields


	// Properties

	public override string Name { get; }

	// Methods

	// RVA: 0x6CF69D74FC Offset: 0x19804FC VA: 0x6CF69D74FC
	public void .ctor() { }

	// RVA: 0x6CF69D765C Offset: 0x198065C VA: 0x6CF69D765C
	public override string get_Name() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties.Internal
internal class SystemVersionPropertyBag : ContainerPropertyBag`1
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D61CC Offset: 0x197F1CC VA: 0x6CF69D61CC
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties.Internal
internal interface IPropertyBagRegister
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public abstract void Register() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
internal struct TypedStore`1
{
	// Fields

	public static IPropertyBag`1 PropertyBag; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties.Internal
internal static class PropertyBagStore : Object
{
	// Fields

	private static readonly ConcurrentDictionary`2 s_PropertyBags; // 0x0
	private static readonly List`1 s_RegisteredTypes; // 0x8
	private static Action`2 NewTypeRegistered; // 0x10
	private static ReflectedPropertyBagProvider s_PropertyBagProvider; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF69D769C Offset: 0x198069C VA: 0x6CF69D769C
	private static void .cctor() { }

	// RVA: 0x6CF5BE0BD0 Offset: 0xB89BD0 VA: 0x6CF5BE0BD0
	internal static void AddPropertyBag(IPropertyBag`1 propertyBag) { }

	// RVA: 0x6CF5BDDC54 Offset: 0xB86C54 VA: 0x6CF5BDDC54
	internal static IPropertyBag`1 GetPropertyBag() { }

	// RVA: 0x6CF69D4AE8 Offset: 0x197DAE8 VA: 0x6CF69D4AE8
	internal static IPropertyBag GetPropertyBag(Type type) { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBagAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D7C60 Offset: 0x1980C60 VA: 0x6CF69D7C60
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBag`1 : ContainerPropertyBag`1
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	internal void AddProperty(Property`2 property) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void .ctor() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
[Serializable]
private sealed class <>c : Object
{
	// Fields

	public static readonly <>c <>9; // 0x0
	public static Func`2 <>9__10_0; // 0x8
	public static Func`2 <>9__22_0; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF69D7F38 Offset: 0x1980F38 VA: 0x6CF69D7F38
	private static void .cctor() { }

	// RVA: 0x6CF69D7F94 Offset: 0x1980F94 VA: 0x6CF69D7F94
	public void .ctor() { }

	// RVA: 0x6CF69D7F9C Offset: 0x1980F9C VA: 0x6CF69D7F9C
	internal bool <.ctor>b__10_0(MethodInfo x) { }

	// RVA: 0x6CF69D8024 Offset: 0x1981024 VA: 0x6CF69D8024
	internal int <GetPropertyMembers>b__22_0(MemberInfo x) { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: 
private sealed class <GetPropertyMembers>d__22 : Object, IEnumerable`1, IEnumerable, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private MemberInfo <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private Type type; // 0x28
	public Type <>3__type; // 0x30
	private IOrderedEnumerable`1 <members>5__1; // 0x38
	private IEnumerator`1 <>s__2; // 0x40
	private MemberInfo <member>5__3; // 0x48
	private bool <hasDontCreatePropertyAttribute>5__4; // 0x50
	private bool <hasCreatePropertyAttribute>5__5; // 0x51
	private bool <hasNonSerializedAttribute>5__6; // 0x52
	private bool <hasSerializedFieldAttribute>5__7; // 0x53
	private FieldInfo <field>5__8; // 0x58

	// Properties

	private MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF69D7CD8 Offset: 0x1980CD8 VA: 0x6CF69D7CD8
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF69D804C Offset: 0x198104C VA: 0x6CF69D804C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF69D8078 Offset: 0x1981078 VA: 0x6CF69D8078
	private bool MoveNext() { }

	// RVA: 0x6CF69D8790 Offset: 0x1981790 VA: 0x6CF69D8790
	private void <>m__Finally1() { }

	// RVA: 0x6CF69D8840 Offset: 0x1981840 VA: 0x6CF69D8840
	private MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.get_Current() { }

	// RVA: 0x6CF69D8848 Offset: 0x1981848 VA: 0x6CF69D8848
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF69D8880 Offset: 0x1981880 VA: 0x6CF69D8880
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x6CF69D8888 Offset: 0x1981888 VA: 0x6CF69D8888
	private IEnumerator`1 System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator() { }

	// RVA: 0x6CF69D8924 Offset: 0x1981924 VA: 0x6CF69D8924
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBagProvider : Object
{
	// Fields

	private readonly MethodInfo m_CreatePropertyMethod; // 0x10
	private readonly MethodInfo m_CreatePropertyBagMethod; // 0x18
	private readonly MethodInfo m_CreateIndexedCollectionPropertyBagMethod; // 0x20
	private readonly MethodInfo m_CreateSetPropertyBagMethod; // 0x28
	private readonly MethodInfo m_CreateKeyValueCollectionPropertyBagMethod; // 0x30
	private readonly MethodInfo m_CreateKeyValuePairPropertyBagMethod; // 0x38
	private readonly MethodInfo m_CreateArrayPropertyBagMethod; // 0x40
	private readonly MethodInfo m_CreateListPropertyBagMethod; // 0x48
	private readonly MethodInfo m_CreateHashSetPropertyBagMethod; // 0x50
	private readonly MethodInfo m_CreateDictionaryPropertyBagMethod; // 0x58

	// Properties


	// Methods

	// RVA: 0x6CF69D77AC Offset: 0x19807AC VA: 0x6CF69D77AC
	public void .ctor() { }

	// RVA: 0x6CF69D7B3C Offset: 0x1980B3C VA: 0x6CF69D7B3C
	public IPropertyBag CreatePropertyBag(Type type) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public IPropertyBag`1 CreatePropertyBag() { }

	// RVA: 0x6CF5BD766C Offset: 0xB8066C VA: 0x6CF5BD766C
	private void CreateProperty(IMemberInfo member, ReflectedPropertyBag`1 propertyBag) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IPropertyBag`1 CreateIndexedCollectionPropertyBag() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IPropertyBag`1 CreateSetPropertyBag() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IPropertyBag`1 CreateKeyValueCollectionPropertyBag() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IPropertyBag`1 CreateKeyValuePairPropertyBag() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IPropertyBag`1 CreateArrayPropertyBag() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IPropertyBag`1 CreateListPropertyBag() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IPropertyBag`1 CreateHashSetPropertyBag() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IPropertyBag`1 CreateDictionaryPropertyBag() { }

	// RVA: 0x6CF69D7C68 Offset: 0x1980C68 VA: 0x6CF69D7C68
	private static IEnumerable`1 GetPropertyMembers(Type type) { }

	// RVA: 0x6CF69D7D0C Offset: 0x1980D0C VA: 0x6CF69D7D0C
	private static bool IsValidMember(MemberInfo memberInfo) { }

	// RVA: 0x6CF69D7E44 Offset: 0x1980E44 VA: 0x6CF69D7E44
	private static bool IsValidPropertyType(Type type) { }

}

// Dll : UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties.Internal
internal static class ReflectionUtilities : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D3558 Offset: 0x197C558 VA: 0x6CF69D3558
	public static string SanitizeMemberName(MemberInfo info) { }

}

// Dll : LitJson.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : LitJson.dll
// Namespace: LitJson
public enum JsonType
{
	// Fields

	public int value__; // 0x10
	public const JsonType None = 0; // 0x0
	public const JsonType Object = 1; // 0x0
	public const JsonType Array = 2; // 0x0
	public const JsonType String = 3; // 0x0
	public const JsonType Int = 4; // 0x0
	public const JsonType Long = 5; // 0x0
	public const JsonType Double = 6; // 0x0
	public const JsonType Boolean = 7; // 0x0

	// Properties


	// Methods

}

// Dll : LitJson.dll
// Namespace: LitJson
public interface IJsonWrapper : IList, IOrderedDictionary, ICollection, IEnumerable, IDictionary
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5BD72B8 Offset: 0xB802B8 VA: 0x6CF5BD72B8
	public abstract void SetBoolean(bool val) { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public abstract void SetDouble(double val) { }

	// RVA: 0x6CF5BD7380 Offset: 0xB80380 VA: 0x6CF5BD7380
	public abstract void SetInt(int val) { }

	// RVA: 0x6CF5BD7380 Offset: 0xB80380 VA: 0x6CF5BD7380
	public abstract void SetJsonType(JsonType type) { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public abstract void SetLong(long val) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public abstract void SetString(string val) { }

}

// Dll : LitJson.dll
// Namespace: LitJson
public class JsonData : Object, IJsonWrapper, IEquatable`1, IList, IOrderedDictionary, ICollection, IEnumerable, IDictionary
{
	// Fields

	private IList`1 inst_array; // 0x10
	private bool inst_boolean; // 0x18
	private double inst_double; // 0x20
	private int inst_int; // 0x28
	private long inst_long; // 0x30
	private IDictionary`2 inst_object; // 0x38
	private string inst_string; // 0x40
	private string json; // 0x48
	private JsonType type; // 0x50
	private IList`1 object_list; // 0x58

	// Properties

	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private object System.Collections.IList.Item { get; set; }
	public int Count { get; }
	public JsonData Item { get; set; }
	public JsonData Item { get; set; }

	// Methods

	// RVA: 0x6CF652B070 Offset: 0x14D4070 VA: 0x6CF652B070
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x6CF652B120 Offset: 0x14D4120 VA: 0x6CF652B120
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x6CF652B2A0 Offset: 0x14D42A0 VA: 0x6CF652B2A0
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x6CF652B34C Offset: 0x14D434C VA: 0x6CF652B34C
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x6CF652B574 Offset: 0x14D4574 VA: 0x6CF652B574
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x6CF652B620 Offset: 0x14D4620 VA: 0x6CF652B620
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x6CF652B9F8 Offset: 0x14D49F8 VA: 0x6CF652B9F8
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x6CF652BDD0 Offset: 0x14D4DD0 VA: 0x6CF652BDD0
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x6CF652BFB4 Offset: 0x14D4FB4 VA: 0x6CF652BFB4
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x6CF652C060 Offset: 0x14D5060 VA: 0x6CF652C060
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x6CF652C110 Offset: 0x14D5110 VA: 0x6CF652C110
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x6CF652C600 Offset: 0x14D5600 VA: 0x6CF652C600
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x6CF652C6B0 Offset: 0x14D56B0 VA: 0x6CF652C6B0
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x6CF652B074 Offset: 0x14D4074 VA: 0x6CF652B074
	public int get_Count() { }

	// RVA: 0x6CF652C984 Offset: 0x14D5984 VA: 0x6CF652C984
	public JsonData get_Item(string prop_name) { }

	// RVA: 0x6CF652C274 Offset: 0x14D5274 VA: 0x6CF652C274
	public void set_Item(string prop_name, JsonData value) { }

	// RVA: 0x6CF652CA34 Offset: 0x14D5A34 VA: 0x6CF652CA34
	public JsonData get_Item(int index) { }

	// RVA: 0x6CF652C6E8 Offset: 0x14D56E8 VA: 0x6CF652C6E8
	public void set_Item(int index, JsonData value) { }

	// RVA: 0x6CF652CB84 Offset: 0x14D5B84 VA: 0x6CF652CB84
	public void .ctor() { }

	// RVA: 0x6CF652CB8C Offset: 0x14D5B8C VA: 0x6CF652CB8C
	public void .ctor(object obj) { }

	// RVA: 0x6CF652CDAC Offset: 0x14D5DAC VA: 0x6CF652CDAC
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x6CF652CE6C Offset: 0x14D5E6C VA: 0x6CF652CE6C
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x6CF652D02C Offset: 0x14D602C VA: 0x6CF652D02C
	private void System.Collections.IDictionary.Clear() { }

	// RVA: 0x6CF652D158 Offset: 0x14D6158 VA: 0x6CF652D158
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x6CF652D20C Offset: 0x14D620C VA: 0x6CF652D20C
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x6CF652D2A0 Offset: 0x14D62A0 VA: 0x6CF652D2A0
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x6CF652D524 Offset: 0x14D6524 VA: 0x6CF652D524
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x6CF652D5CC Offset: 0x14D65CC VA: 0x6CF652D5CC
	private void LitJson.IJsonWrapper.SetBoolean(bool val) { }

	// RVA: 0x6CF652D5E4 Offset: 0x14D65E4 VA: 0x6CF652D5E4
	private void LitJson.IJsonWrapper.SetDouble(double val) { }

	// RVA: 0x6CF652D5F8 Offset: 0x14D65F8 VA: 0x6CF652D5F8
	private void LitJson.IJsonWrapper.SetInt(int val) { }

	// RVA: 0x6CF652D60C Offset: 0x14D660C VA: 0x6CF652D60C
	private void LitJson.IJsonWrapper.SetLong(long val) { }

	// RVA: 0x6CF652D620 Offset: 0x14D6620 VA: 0x6CF652D620
	private void LitJson.IJsonWrapper.SetString(string val) { }

	// RVA: 0x6CF652D630 Offset: 0x14D6630 VA: 0x6CF652D630
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x6CF652D6F8 Offset: 0x14D66F8 VA: 0x6CF652D6F8
	private void System.Collections.IList.Clear() { }

	// RVA: 0x6CF652D7AC Offset: 0x14D67AC VA: 0x6CF652D7AC
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x6CF652D860 Offset: 0x14D6860 VA: 0x6CF652D860
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x6CF652D914 Offset: 0x14D6914 VA: 0x6CF652D914
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x6CF652D9E0 Offset: 0x14D69E0 VA: 0x6CF652D9E0
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x6CF652DA9C Offset: 0x14D6A9C VA: 0x6CF652DA9C
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x6CF652DB58 Offset: 0x14D6B58 VA: 0x6CF652DB58
	private IDictionaryEnumerator System.Collections.Specialized.IOrderedDictionary.GetEnumerator() { }

	// RVA: 0x6CF652B1CC Offset: 0x14D41CC VA: 0x6CF652B1CC
	private ICollection EnsureCollection() { }

	// RVA: 0x6CF652B3F8 Offset: 0x14D43F8 VA: 0x6CF652B3F8
	private IDictionary EnsureDictionary() { }

	// RVA: 0x6CF652BE7C Offset: 0x14D4E7C VA: 0x6CF652BE7C
	private IList EnsureList() { }

	// RVA: 0x6CF652C1E8 Offset: 0x14D51E8 VA: 0x6CF652C1E8
	private JsonData ToJsonData(object obj) { }

	// RVA: 0x6CF652D634 Offset: 0x14D6634 VA: 0x6CF652D634
	public int Add(object value) { }

	// RVA: 0x6CF652DC64 Offset: 0x14D6C64 VA: 0x6CF652DC64
	public bool Equals(JsonData x) { }

	// RVA: 0x6CF652DDBC Offset: 0x14D6DBC VA: 0x6CF652DDBC
	public void SetJsonType(JsonType type) { }

	// RVA: 0x6CF652DF0C Offset: 0x14D6F0C VA: 0x6CF652DF0C
	public override string ToString() { }

}

// Dll : LitJson.dll
// Namespace: LitJson
internal class OrderedDictionaryEnumerator : Object, IDictionaryEnumerator, IEnumerator
{
	// Fields

	private IEnumerator`1 list_enumerator; // 0x10

	// Properties

	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x6CF652E028 Offset: 0x14D7028 VA: 0x6CF652E028
	public object get_Current() { }

	// RVA: 0x6CF652E08C Offset: 0x14D708C VA: 0x6CF652E08C
	public DictionaryEntry get_Entry() { }

	// RVA: 0x6CF652E174 Offset: 0x14D7174 VA: 0x6CF652E174
	public object get_Key() { }

	// RVA: 0x6CF652E220 Offset: 0x14D7220 VA: 0x6CF652E220
	public object get_Value() { }

	// RVA: 0x6CF652DC3C Offset: 0x14D6C3C VA: 0x6CF652DC3C
	public void .ctor(IEnumerator`1 enumerator) { }

	// RVA: 0x6CF652E2D4 Offset: 0x14D72D4 VA: 0x6CF652E2D4
	public bool MoveNext() { }

	// RVA: 0x6CF652E374 Offset: 0x14D7374 VA: 0x6CF652E374
	public void Reset() { }

}

// Dll : LitJson.dll
// Namespace: LitJson
public class JsonException : ApplicationException
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF652E418 Offset: 0x14D7418 VA: 0x6CF652E418
	internal void .ctor(ParserToken token, Exception inner_exception) { }

	// RVA: 0x6CF652E4BC Offset: 0x14D74BC VA: 0x6CF652E4BC
	internal void .ctor(int c) { }

	// RVA: 0x6CF652E558 Offset: 0x14D7558 VA: 0x6CF652E558
	public void .ctor(string message) { }

}

// Dll : LitJson.dll
// Namespace: LitJson
internal struct PropertyMetadata
{
	// Fields

	public MemberInfo Info; // 0x10
	public bool IsField; // 0x18
	public Type Type; // 0x20

	// Properties


	// Methods

}

// Dll : LitJson.dll
// Namespace: LitJson
internal struct ArrayMetadata
{
	// Fields

	private Type element_type; // 0x10
	private bool is_array; // 0x18
	private bool is_list; // 0x19

	// Properties


	// Methods

}

// Dll : LitJson.dll
// Namespace: LitJson
internal struct ObjectMetadata
{
	// Fields

	private Type element_type; // 0x10
	private bool is_dictionary; // 0x18
	private IDictionary`2 properties; // 0x20

	// Properties


	// Methods

}

// Dll : LitJson.dll
// Namespace: LitJson
internal sealed class ExporterFunc : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF652E560 Offset: 0x14D7560 VA: 0x6CF652E560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF652E664 Offset: 0x14D7664 VA: 0x6CF652E664
	public virtual void Invoke(object obj, JsonWriter writer) { }

}

// Dll : LitJson.dll
// Namespace: LitJson
internal sealed class ImporterFunc : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF652E678 Offset: 0x14D7678 VA: 0x6CF652E678
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF652E778 Offset: 0x14D7778 VA: 0x6CF652E778
	public virtual object Invoke(object input) { }

}

// Dll : LitJson.dll
// Namespace: LitJson
public sealed class WrapperFactory : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF652E78C Offset: 0x14D778C VA: 0x6CF652E78C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF652E814 Offset: 0x14D7814 VA: 0x6CF652E814
	public virtual IJsonWrapper Invoke() { }

}

// Dll : LitJson.dll
// Namespace: LitJson
public class JsonMapper : Object
{
	// Fields

	private static int max_nesting_depth; // 0x0
	private static IFormatProvider datetime_format; // 0x8
	private static IDictionary`2 base_exporters_table; // 0x10
	private static IDictionary`2 custom_exporters_table; // 0x18
	private static IDictionary`2 base_importers_table; // 0x20
	private static IDictionary`2 custom_importers_table; // 0x28
	private static IDictionary`2 array_metadata; // 0x30
	private static readonly object array_metadata_lock; // 0x38
	private static IDictionary`2 conv_ops; // 0x40
	private static readonly object conv_ops_lock; // 0x48
	private static IDictionary`2 object_metadata; // 0x50
	private static readonly object object_metadata_lock; // 0x58
	private static IDictionary`2 type_properties; // 0x60
	private static readonly object type_properties_lock; // 0x68
	private static JsonWriter static_writer; // 0x70
	private static readonly object static_writer_lock; // 0x78
	private static ExporterFunc <>f__am$cache1; // 0x80
	private static ExporterFunc <>f__am$cache2; // 0x88
	private static ExporterFunc <>f__am$cache3; // 0x90
	private static ExporterFunc <>f__am$cache4; // 0x98
	private static ExporterFunc <>f__am$cache5; // 0xA0
	private static ExporterFunc <>f__am$cache6; // 0xA8
	private static ExporterFunc <>f__am$cache7; // 0xB0
	private static ExporterFunc <>f__am$cache8; // 0xB8
	private static ExporterFunc <>f__am$cache9; // 0xC0
	private static ImporterFunc <>f__am$cacheA; // 0xC8
	private static ImporterFunc <>f__am$cacheB; // 0xD0
	private static ImporterFunc <>f__am$cacheC; // 0xD8
	private static ImporterFunc <>f__am$cacheD; // 0xE0
	private static ImporterFunc <>f__am$cacheE; // 0xE8
	private static ImporterFunc <>f__am$cacheF; // 0xF0
	private static ImporterFunc <>f__am$cache10; // 0xF8
	private static ImporterFunc <>f__am$cache11; // 0x100
	private static ImporterFunc <>f__am$cache12; // 0x108
	private static ImporterFunc <>f__am$cache13; // 0x110
	private static ImporterFunc <>f__am$cache14; // 0x118
	private static ImporterFunc <>f__am$cache15; // 0x120
	private static WrapperFactory <>f__am$cache18; // 0x128

	// Properties


	// Methods

	// RVA: 0x6CF652E828 Offset: 0x14D7828 VA: 0x6CF652E828
	private static void .cctor() { }

	// RVA: 0x6CF6530220 Offset: 0x14D9220 VA: 0x6CF6530220
	private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader) { }

	// RVA: 0x6CF652EC3C Offset: 0x14D7C3C VA: 0x6CF652EC3C
	private static void RegisterBaseExporters() { }

	// RVA: 0x6CF652F758 Offset: 0x14D8758 VA: 0x6CF652F758
	private static void RegisterBaseImporters() { }

	// RVA: 0x6CF6530D00 Offset: 0x14D9D00 VA: 0x6CF6530D00
	private static void RegisterImporter(IDictionary`2 table, Type json_type, Type value_type, ImporterFunc importer) { }

	// RVA: 0x6CF6530F40 Offset: 0x14D9F40 VA: 0x6CF6530F40
	public static JsonData ToObject(string json) { }

	// RVA: 0x6CF6531064 Offset: 0x14DA064 VA: 0x6CF6531064
	public static IJsonWrapper ToWrapper(WrapperFactory factory, string json) { }

	// RVA: 0x6CF6531160 Offset: 0x14DA160 VA: 0x6CF6531160
	private static void <RegisterBaseExporters>m__1(object obj, JsonWriter writer) { }

	// RVA: 0x6CF65312E8 Offset: 0x14DA2E8 VA: 0x6CF65312E8
	private static void <RegisterBaseExporters>m__2(object obj, JsonWriter writer) { }

	// RVA: 0x6CF6531428 Offset: 0x14DA428 VA: 0x6CF6531428
	private static void <RegisterBaseExporters>m__3(object obj, JsonWriter writer) { }

	// RVA: 0x6CF6531514 Offset: 0x14DA514 VA: 0x6CF6531514
	private static void <RegisterBaseExporters>m__4(object obj, JsonWriter writer) { }

	// RVA: 0x6CF653166C Offset: 0x14DA66C VA: 0x6CF653166C
	private static void <RegisterBaseExporters>m__5(object obj, JsonWriter writer) { }

	// RVA: 0x6CF6531720 Offset: 0x14DA720 VA: 0x6CF6531720
	private static void <RegisterBaseExporters>m__6(object obj, JsonWriter writer) { }

	// RVA: 0x6CF65317D4 Offset: 0x14DA7D4 VA: 0x6CF65317D4
	private static void <RegisterBaseExporters>m__7(object obj, JsonWriter writer) { }

	// RVA: 0x6CF6531888 Offset: 0x14DA888 VA: 0x6CF6531888
	private static void <RegisterBaseExporters>m__8(object obj, JsonWriter writer) { }

	// RVA: 0x6CF6531A10 Offset: 0x14DAA10 VA: 0x6CF6531A10
	private static void <RegisterBaseExporters>m__9(object obj, JsonWriter writer) { }

	// RVA: 0x6CF6531A8C Offset: 0x14DAA8C VA: 0x6CF6531A8C
	private static object <RegisterBaseImporters>m__A(object input) { }

	// RVA: 0x6CF6531B5C Offset: 0x14DAB5C VA: 0x6CF6531B5C
	private static object <RegisterBaseImporters>m__B(object input) { }

	// RVA: 0x6CF6531C2C Offset: 0x14DAC2C VA: 0x6CF6531C2C
	private static object <RegisterBaseImporters>m__C(object input) { }

	// RVA: 0x6CF6531CFC Offset: 0x14DACFC VA: 0x6CF6531CFC
	private static object <RegisterBaseImporters>m__D(object input) { }

	// RVA: 0x6CF6531DCC Offset: 0x14DADCC VA: 0x6CF6531DCC
	private static object <RegisterBaseImporters>m__E(object input) { }

	// RVA: 0x6CF6531E9C Offset: 0x14DAE9C VA: 0x6CF6531E9C
	private static object <RegisterBaseImporters>m__F(object input) { }

	// RVA: 0x6CF6531F6C Offset: 0x14DAF6C VA: 0x6CF6531F6C
	private static object <RegisterBaseImporters>m__10(object input) { }

	// RVA: 0x6CF6532038 Offset: 0x14DB038 VA: 0x6CF6532038
	private static object <RegisterBaseImporters>m__11(object input) { }

	// RVA: 0x6CF6532104 Offset: 0x14DB104 VA: 0x6CF6532104
	private static object <RegisterBaseImporters>m__12(object input) { }

	// RVA: 0x6CF65321FC Offset: 0x14DB1FC VA: 0x6CF65321FC
	private static object <RegisterBaseImporters>m__13(object input) { }

	// RVA: 0x6CF65322CC Offset: 0x14DB2CC VA: 0x6CF65322CC
	private static object <RegisterBaseImporters>m__14(object input) { }

	// RVA: 0x6CF6532390 Offset: 0x14DB390 VA: 0x6CF6532390
	private static object <RegisterBaseImporters>m__15(object input) { }

	// RVA: 0x6CF653248C Offset: 0x14DB48C VA: 0x6CF653248C
	private static IJsonWrapper <ToObject>m__18() { }

}

// Dll : LitJson.dll
// Namespace: LitJson
public enum JsonToken
{
	// Fields

	public int value__; // 0x10
	public const JsonToken None = 0; // 0x0
	public const JsonToken ObjectStart = 1; // 0x0
	public const JsonToken PropertyName = 2; // 0x0
	public const JsonToken ObjectEnd = 3; // 0x0
	public const JsonToken ArrayStart = 4; // 0x0
	public const JsonToken ArrayEnd = 5; // 0x0
	public const JsonToken Int = 6; // 0x0
	public const JsonToken Long = 7; // 0x0
	public const JsonToken Double = 8; // 0x0
	public const JsonToken String = 9; // 0x0
	public const JsonToken Boolean = 10; // 0x0
	public const JsonToken Null = 11; // 0x0

	// Properties


	// Methods

}

// Dll : LitJson.dll
// Namespace: LitJson
public class JsonReader : Object
{
	// Fields

	private static IDictionary`2 parse_table; // 0x0
	private Stack`1 automaton_stack; // 0x10
	private int current_input; // 0x18
	private int current_symbol; // 0x1C
	private bool end_of_json; // 0x20
	private bool end_of_input; // 0x21
	private Lexer lexer; // 0x28
	private bool parser_in_string; // 0x30
	private bool parser_return; // 0x31
	private bool read_started; // 0x32
	private TextReader reader; // 0x38
	private bool reader_is_owned; // 0x40
	private bool skip_non_members; // 0x41
	private object token_value; // 0x48
	private JsonToken token; // 0x50

	// Properties

	public JsonToken Token { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x6CF65324E0 Offset: 0x14DB4E0 VA: 0x6CF65324E0
	public JsonToken get_Token() { }

	// RVA: 0x6CF65324E8 Offset: 0x14DB4E8 VA: 0x6CF65324E8
	public object get_Value() { }

	// RVA: 0x6CF65324F0 Offset: 0x14DB4F0 VA: 0x6CF65324F0
	private static void .cctor() { }

	// RVA: 0x6CF65310F0 Offset: 0x14DA0F0 VA: 0x6CF65310F0
	public void .ctor(string json_text) { }

	// RVA: 0x6CF6532C34 Offset: 0x14DBC34 VA: 0x6CF6532C34
	private void .ctor(TextReader reader, bool owned) { }

	// RVA: 0x6CF65324F4 Offset: 0x14DB4F4 VA: 0x6CF65324F4
	private static void PopulateParseTable() { }

	// RVA: 0x6CF6532F84 Offset: 0x14DBF84 VA: 0x6CF6532F84
	private static void TableAddCol(ParserToken row, int col, Int32[] symbols) { }

	// RVA: 0x6CF6532E68 Offset: 0x14DBE68 VA: 0x6CF6532E68
	private static void TableAddRow(ParserToken rule) { }

	// RVA: 0x6CF65330E4 Offset: 0x14DC0E4 VA: 0x6CF65330E4
	private void ProcessNumber(string number) { }

	// RVA: 0x6CF6533290 Offset: 0x14DC290 VA: 0x6CF6533290
	private void ProcessSymbol() { }

	// RVA: 0x6CF6533424 Offset: 0x14DC424 VA: 0x6CF6533424
	private bool ReadToken() { }

	// RVA: 0x6CF6533638 Offset: 0x14DC638 VA: 0x6CF6533638
	public void Close() { }

	// RVA: 0x6CF65308B8 Offset: 0x14D98B8 VA: 0x6CF65308B8
	public bool Read() { }

}

// Dll : LitJson.dll
// Namespace: LitJson
internal enum Condition
{
	// Fields

	public int value__; // 0x10
	public const Condition InArray = 0; // 0x0
	public const Condition InObject = 1; // 0x0
	public const Condition NotAProperty = 2; // 0x0
	public const Condition Property = 3; // 0x0
	public const Condition Value = 4; // 0x0

	// Properties


	// Methods

}

// Dll : LitJson.dll
// Namespace: LitJson
internal class WriterContext : Object
{
	// Fields

	public int Count; // 0x10
	public bool InArray; // 0x14
	public bool InObject; // 0x15
	public bool ExpectingValue; // 0x16

	// Properties


	// Methods

	// RVA: 0x6CF653367C Offset: 0x14DC67C VA: 0x6CF653367C
	public void .ctor() { }

}

// Dll : LitJson.dll
// Namespace: LitJson
public class JsonWriter : Object
{
	// Fields

	private static NumberFormatInfo number_format; // 0x0
	private WriterContext context; // 0x10
	private Stack`1 ctx_stack; // 0x18
	private bool has_reached_end; // 0x20
	private Char[] hex_seq; // 0x28
	private int indentation; // 0x30
	private int indent_value; // 0x34
	private StringBuilder inst_string_builder; // 0x38
	private bool pretty_print; // 0x40
	private bool validate; // 0x41
	private TextWriter writer; // 0x48

	// Properties


	// Methods

	// RVA: 0x6CF6533684 Offset: 0x14DC684 VA: 0x6CF6533684
	private static void .cctor() { }

	// RVA: 0x6CF652EB9C Offset: 0x14D7B9C VA: 0x6CF652EB9C
	public void .ctor() { }

	// RVA: 0x6CF65337E0 Offset: 0x14DC7E0 VA: 0x6CF65337E0
	private void DoValidation(Condition cond) { }

	// RVA: 0x6CF65336D4 Offset: 0x14DC6D4 VA: 0x6CF65336D4
	private void Init() { }

	// RVA: 0x6CF6533964 Offset: 0x14DC964 VA: 0x6CF6533964
	private static void IntToHex(int n, Char[] hex) { }

	// RVA: 0x6CF65339DC Offset: 0x14DC9DC VA: 0x6CF65339DC
	private void Put(string str) { }

	// RVA: 0x6CF6533A64 Offset: 0x14DCA64 VA: 0x6CF6533A64
	private void PutNewline() { }

	// RVA: 0x6CF6533A6C Offset: 0x14DCA6C VA: 0x6CF6533A6C
	private void PutNewline(bool add_comma) { }

	// RVA: 0x6CF6533AEC Offset: 0x14DCAEC VA: 0x6CF6533AEC
	private void PutString(string str) { }

	// RVA: 0x6CF6533DE4 Offset: 0x14DCDE4 VA: 0x6CF6533DE4
	public override string ToString() { }

	// RVA: 0x6CF6531590 Offset: 0x14DA590 VA: 0x6CF6531590
	public void Write(decimal number) { }

	// RVA: 0x6CF6531214 Offset: 0x14DA214 VA: 0x6CF6531214
	public void Write(int number) { }

	// RVA: 0x6CF653139C Offset: 0x14DA39C VA: 0x6CF653139C
	public void Write(string str) { }

	// RVA: 0x6CF653193C Offset: 0x14DA93C VA: 0x6CF653193C
	public void Write(ulong number) { }

}

// Dll : LitJson.dll
// Namespace: LitJson
internal class FsmContext : Object
{
	// Fields

	public bool Return; // 0x10
	public int NextState; // 0x14
	public Lexer L; // 0x18
	public int StateStack; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF6533E4C Offset: 0x14DCE4C VA: 0x6CF6533E4C
	public void .ctor() { }

}

// Dll : LitJson.dll
// Namespace: 
private sealed class StateHandler : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6534ECC Offset: 0x14DDECC VA: 0x6CF6534ECC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF6536314 Offset: 0x14DF314 VA: 0x6CF6536314
	public virtual bool Invoke(FsmContext ctx) { }

}

// Dll : LitJson.dll
// Namespace: LitJson
internal class Lexer : Object
{
	// Fields

	private static Int32[] fsm_return_table; // 0x0
	private static StateHandler[] fsm_handler_table; // 0x8
	private bool allow_comments; // 0x10
	private bool allow_single_quoted_strings; // 0x11
	private bool end_of_input; // 0x12
	private FsmContext fsm_context; // 0x18
	private int input_buffer; // 0x20
	private int input_char; // 0x24
	private TextReader reader; // 0x28
	private int state; // 0x30
	private StringBuilder string_buffer; // 0x38
	private string string_value; // 0x40
	private int token; // 0x48
	private int unichar; // 0x4C
	private static StateHandler <>f__mg$cache0; // 0x10
	private static StateHandler <>f__mg$cache1; // 0x18
	private static StateHandler <>f__mg$cache2; // 0x20
	private static StateHandler <>f__mg$cache3; // 0x28
	private static StateHandler <>f__mg$cache4; // 0x30
	private static StateHandler <>f__mg$cache5; // 0x38
	private static StateHandler <>f__mg$cache6; // 0x40
	private static StateHandler <>f__mg$cache7; // 0x48
	private static StateHandler <>f__mg$cache8; // 0x50
	private static StateHandler <>f__mg$cache9; // 0x58
	private static StateHandler <>f__mg$cacheA; // 0x60
	private static StateHandler <>f__mg$cacheB; // 0x68
	private static StateHandler <>f__mg$cacheC; // 0x70
	private static StateHandler <>f__mg$cacheD; // 0x78
	private static StateHandler <>f__mg$cacheE; // 0x80
	private static StateHandler <>f__mg$cacheF; // 0x88
	private static StateHandler <>f__mg$cache10; // 0x90
	private static StateHandler <>f__mg$cache11; // 0x98
	private static StateHandler <>f__mg$cache12; // 0xA0
	private static StateHandler <>f__mg$cache13; // 0xA8
	private static StateHandler <>f__mg$cache14; // 0xB0
	private static StateHandler <>f__mg$cache15; // 0xB8
	private static StateHandler <>f__mg$cache16; // 0xC0
	private static StateHandler <>f__mg$cache17; // 0xC8
	private static StateHandler <>f__mg$cache18; // 0xD0
	private static StateHandler <>f__mg$cache19; // 0xD8
	private static StateHandler <>f__mg$cache1A; // 0xE0
	private static StateHandler <>f__mg$cache1B; // 0xE8

	// Properties

	public bool EndOfInput { get; }
	public int Token { get; }
	public string StringValue { get; }

	// Methods

	// RVA: 0x6CF6533E54 Offset: 0x14DCE54 VA: 0x6CF6533E54
	public bool get_EndOfInput() { }

	// RVA: 0x6CF6533E5C Offset: 0x14DCE5C VA: 0x6CF6533E5C
	public int get_Token() { }

	// RVA: 0x6CF6533E64 Offset: 0x14DCE64 VA: 0x6CF6533E64
	public string get_StringValue() { }

	// RVA: 0x6CF6533E6C Offset: 0x14DCE6C VA: 0x6CF6533E6C
	private static void .cctor() { }

	// RVA: 0x6CF6532DA0 Offset: 0x14DBDA0 VA: 0x6CF6532DA0
	public void .ctor(TextReader reader) { }

	// RVA: 0x6CF6534E48 Offset: 0x14DDE48 VA: 0x6CF6534E48
	private static int HexValue(int digit) { }

	// RVA: 0x6CF6533E70 Offset: 0x14DCE70 VA: 0x6CF6533E70
	private static void PopulateFsmTables() { }

	// RVA: 0x6CF6534FCC Offset: 0x14DDFCC VA: 0x6CF6534FCC
	private static char ProcessEscChar(int esc_char) { }

	// RVA: 0x6CF65350C0 Offset: 0x14DE0C0 VA: 0x6CF65350C0
	private static bool State1(FsmContext ctx) { }

	// RVA: 0x6CF65352B0 Offset: 0x14DE2B0 VA: 0x6CF65352B0
	private static bool State2(FsmContext ctx) { }

	// RVA: 0x6CF6535358 Offset: 0x14DE358 VA: 0x6CF6535358
	private static bool State3(FsmContext ctx) { }

	// RVA: 0x6CF653548C Offset: 0x14DE48C VA: 0x6CF653548C
	private static bool State4(FsmContext ctx) { }

	// RVA: 0x6CF6535584 Offset: 0x14DE584 VA: 0x6CF6535584
	private static bool State5(FsmContext ctx) { }

	// RVA: 0x6CF6535600 Offset: 0x14DE600 VA: 0x6CF6535600
	private static bool State6(FsmContext ctx) { }

	// RVA: 0x6CF65356F8 Offset: 0x14DE6F8 VA: 0x6CF65356F8
	private static bool State7(FsmContext ctx) { }

	// RVA: 0x6CF653578C Offset: 0x14DE78C VA: 0x6CF653578C
	private static bool State8(FsmContext ctx) { }

	// RVA: 0x6CF6535848 Offset: 0x14DE848 VA: 0x6CF6535848
	private static bool State9(FsmContext ctx) { }

	// RVA: 0x6CF65358B0 Offset: 0x14DE8B0 VA: 0x6CF65358B0
	private static bool State10(FsmContext ctx) { }

	// RVA: 0x6CF6535918 Offset: 0x14DE918 VA: 0x6CF6535918
	private static bool State11(FsmContext ctx) { }

	// RVA: 0x6CF6535984 Offset: 0x14DE984 VA: 0x6CF6535984
	private static bool State12(FsmContext ctx) { }

	// RVA: 0x6CF65359EC Offset: 0x14DE9EC VA: 0x6CF65359EC
	private static bool State13(FsmContext ctx) { }

	// RVA: 0x6CF6535A54 Offset: 0x14DEA54 VA: 0x6CF6535A54
	private static bool State14(FsmContext ctx) { }

	// RVA: 0x6CF6535ABC Offset: 0x14DEABC VA: 0x6CF6535ABC
	private static bool State15(FsmContext ctx) { }

	// RVA: 0x6CF6535B28 Offset: 0x14DEB28 VA: 0x6CF6535B28
	private static bool State16(FsmContext ctx) { }

	// RVA: 0x6CF6535B90 Offset: 0x14DEB90 VA: 0x6CF6535B90
	private static bool State17(FsmContext ctx) { }

	// RVA: 0x6CF6535BF8 Offset: 0x14DEBF8 VA: 0x6CF6535BF8
	private static bool State18(FsmContext ctx) { }

	// RVA: 0x6CF6535C64 Offset: 0x14DEC64 VA: 0x6CF6535C64
	private static bool State19(FsmContext ctx) { }

	// RVA: 0x6CF6535D0C Offset: 0x14DED0C VA: 0x6CF6535D0C
	private static bool State20(FsmContext ctx) { }

	// RVA: 0x6CF6535D78 Offset: 0x14DED78 VA: 0x6CF6535D78
	private static bool State21(FsmContext ctx) { }

	// RVA: 0x6CF6535E88 Offset: 0x14DEE88 VA: 0x6CF6535E88
	private static bool State22(FsmContext ctx) { }

	// RVA: 0x6CF6535FFC Offset: 0x14DEFFC VA: 0x6CF6535FFC
	private static bool State23(FsmContext ctx) { }

	// RVA: 0x6CF65360A4 Offset: 0x14DF0A4 VA: 0x6CF65360A4
	private static bool State24(FsmContext ctx) { }

	// RVA: 0x6CF6536118 Offset: 0x14DF118 VA: 0x6CF6536118
	private static bool State25(FsmContext ctx) { }

	// RVA: 0x6CF6536194 Offset: 0x14DF194 VA: 0x6CF6536194
	private static bool State26(FsmContext ctx) { }

	// RVA: 0x6CF65361FC Offset: 0x14DF1FC VA: 0x6CF65361FC
	private static bool State27(FsmContext ctx) { }

	// RVA: 0x6CF6536264 Offset: 0x14DF264 VA: 0x6CF6536264
	private static bool State28(FsmContext ctx) { }

	// RVA: 0x6CF6535280 Offset: 0x14DE280 VA: 0x6CF6535280
	private bool GetChar() { }

	// RVA: 0x6CF65362DC Offset: 0x14DF2DC VA: 0x6CF65362DC
	private int NextChar() { }

	// RVA: 0x6CF6533478 Offset: 0x14DC478 VA: 0x6CF6533478
	public bool NextToken() { }

	// RVA: 0x6CF6535480 Offset: 0x14DE480 VA: 0x6CF6535480
	private void UngetChar() { }

}

// Dll : LitJson.dll
// Namespace: LitJson
internal enum ParserToken
{
	// Fields

	public int value__; // 0x10
	public const ParserToken None = 65536; // 0x0
	public const ParserToken Number = 65537; // 0x0
	public const ParserToken True = 65538; // 0x0
	public const ParserToken False = 65539; // 0x0
	public const ParserToken Null = 65540; // 0x0
	public const ParserToken CharSeq = 65541; // 0x0
	public const ParserToken Char = 65542; // 0x0
	public const ParserToken Text = 65543; // 0x0
	public const ParserToken Object = 65544; // 0x0
	public const ParserToken ObjectPrime = 65545; // 0x0
	public const ParserToken Pair = 65546; // 0x0
	public const ParserToken PairRest = 65547; // 0x0
	public const ParserToken Array = 65548; // 0x0
	public const ParserToken ArrayPrime = 65549; // 0x0
	public const ParserToken Value = 65550; // 0x0
	public const ParserToken ValueRest = 65551; // 0x0
	public const ParserToken String = 65552; // 0x0
	public const ParserToken End = 65553; // 0x0
	public const ParserToken Epsilon = 65554; // 0x0

	// Properties


	// Methods

}

// Dll : LitJson.dll
// Namespace: 
private struct $ArrayType=12
{
	// Fields


	// Properties


	// Methods

}

// Dll : LitJson.dll
// Namespace: 
private struct $ArrayType=112
{
	// Fields


	// Properties


	// Methods

}

// Dll : LitJson.dll
// Namespace: 
internal static class <PrivateImplementationDetails>{d7db51ae-d199-4277-a2a4-4bdb68cd3ac9} : Object
{
	// Fields

	internal static $ArrayType=12 $field-0; // 0x0
	internal static $ArrayType=12 $field-1; // 0xC
	internal static $ArrayType=12 $field-2; // 0x18
	internal static $ArrayType=12 $field-3; // 0x24
	internal static $ArrayType=12 $field-4; // 0x30
	internal static $ArrayType=12 $field-5; // 0x3C
	internal static $ArrayType=12 $field-6; // 0x48
	internal static $ArrayType=12 $field-7; // 0x54
	internal static $ArrayType=12 $field-8; // 0x60
	internal static $ArrayType=12 $field-9; // 0x6C
	internal static $ArrayType=12 $field-A; // 0x78
	internal static $ArrayType=12 $field-B; // 0x84
	internal static $ArrayType=112 $field-C; // 0x90

	// Properties


	// Methods

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public enum RigidbodyConstraints
{
	// Fields

	public int value__; // 0x10
	public const RigidbodyConstraints None = 0; // 0x0
	public const RigidbodyConstraints FreezePositionX = 2; // 0x0
	public const RigidbodyConstraints FreezePositionY = 4; // 0x0
	public const RigidbodyConstraints FreezePositionZ = 8; // 0x0
	public const RigidbodyConstraints FreezeRotationX = 16; // 0x0
	public const RigidbodyConstraints FreezeRotationY = 32; // 0x0
	public const RigidbodyConstraints FreezeRotationZ = 64; // 0x0
	public const RigidbodyConstraints FreezePosition = 14; // 0x0
	public const RigidbodyConstraints FreezeRotation = 112; // 0x0
	public const RigidbodyConstraints FreezeAll = 126; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public enum ForceMode
{
	// Fields

	public int value__; // 0x10
	public const ForceMode Force = 0; // 0x0
	public const ForceMode Acceleration = 5; // 0x0
	public const ForceMode Impulse = 1; // 0x0
	public const ForceMode VelocityChange = 2; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public class ControllerColliderHit : Object
{
	// Fields

	internal CharacterController m_Controller; // 0x10
	internal Collider m_Collider; // 0x18
	internal Vector3 m_Point; // 0x20
	internal Vector3 m_Normal; // 0x2C
	internal Vector3 m_MoveDirection; // 0x38
	internal float m_MoveLength; // 0x44
	internal int m_Push; // 0x48

	// Properties

	public Collider collider { get; }
	public Vector3 point { get; }

	// Methods

	// RVA: 0x6CF69CE0A4 Offset: 0x19770A4 VA: 0x6CF69CE0A4
	public Collider get_collider() { }

	// RVA: 0x6CF69CE0AC Offset: 0x19770AC VA: 0x6CF69CE0AC
	public Vector3 get_point() { }

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public class Collision : Object
{
	// Fields

	private ContactPairHeader m_Header; // 0x10
	private ContactPair m_Pair; // 0x38
	private bool m_Flipped; // 0x60
	private ContactPoint[] m_LegacyContacts; // 0x68

	// Properties

	internal bool Flipped { set; }

	// Methods

	// RVA: 0x6CF69CE0B8 Offset: 0x19770B8 VA: 0x6CF69CE0B8
	internal void set_Flipped(bool value) { }

	// RVA: 0x6CF69CE0C4 Offset: 0x19770C4 VA: 0x6CF69CE0C4
	public void .ctor() { }

	// RVA: 0x6CF69CE0F8 Offset: 0x19770F8 VA: 0x6CF69CE0F8
	internal void .ctor(ref ContactPairHeader header, ref ContactPair pair, bool flipped) { }

	// RVA: 0x6CF69CE228 Offset: 0x1977228 VA: 0x6CF69CE228
	internal void Reuse(ref ContactPairHeader header, ref ContactPair pair) { }

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public enum CollisionFlags
{
	// Fields

	public int value__; // 0x10
	public const CollisionFlags None = 0; // 0x0
	public const CollisionFlags Sides = 1; // 0x0
	public const CollisionFlags Above = 2; // 0x0
	public const CollisionFlags Below = 4; // 0x0
	public const CollisionFlags CollidedSides = 1; // 0x0
	public const CollisionFlags CollidedAbove = 2; // 0x0
	public const CollisionFlags CollidedBelow = 4; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public enum QueryTriggerInteraction
{
	// Fields

	public int value__; // 0x10
	public const QueryTriggerInteraction UseGlobal = 0; // 0x0
	public const QueryTriggerInteraction Ignore = 1; // 0x0
	public const QueryTriggerInteraction Collide = 2; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: 
public sealed class ContactEventDelegate : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D18B0 Offset: 0x197A8B0 VA: 0x6CF69D18B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF69D193C Offset: 0x197A93C VA: 0x6CF69D193C
	public virtual void Invoke(PhysicsScene scene, ReadOnly headerArray) { }

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public class Physics : Object
{
	// Fields

	private static Action`2 ContactModifyEvent; // 0x0
	private static Action`2 ContactModifyEventCCD; // 0x8
	private static ContactEventDelegate ContactEvent; // 0x10
	private static readonly Collision s_ReusableCollision; // 0x18

	// Properties

	public static Vector3 gravity { get; }
	public static bool invokeCollisionCallbacks { get; }
	public static PhysicsScene defaultPhysicsScene { get; }
	public static bool reuseCollisionCallbacks { get; }

	// Methods

	// RVA: 0x6CF69CE258 Offset: 0x1977258 VA: 0x6CF69CE258
	private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	// RVA: 0x6CF69CE33C Offset: 0x197733C VA: 0x6CF69CE33C
	public static Vector3 get_gravity() { }

	// RVA: 0x6CF69CE404 Offset: 0x1977404 VA: 0x6CF69CE404
	public static bool get_invokeCollisionCallbacks() { }

	// RVA: 0x6CF69CE42C Offset: 0x197742C VA: 0x6CF69CE42C
	public static PhysicsScene get_defaultPhysicsScene() { }

	// RVA: 0x6CF69CE4E4 Offset: 0x19774E4 VA: 0x6CF69CE4E4
	public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore) { }

	// RVA: 0x6CF69CE538 Offset: 0x1977538 VA: 0x6CF69CE538
	public static void IgnoreLayerCollision(int layer1, int layer2) { }

	// RVA: 0x6CF69CE5C0 Offset: 0x19775C0 VA: 0x6CF69CE5C0
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69CE868 Offset: 0x1977868 VA: 0x6CF69CE868
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	// RVA: 0x6CF69CE92C Offset: 0x197792C VA: 0x6CF69CE92C
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	// RVA: 0x6CF69CE9F4 Offset: 0x19779F4 VA: 0x6CF69CE9F4
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	// RVA: 0x6CF69CEAAC Offset: 0x1977AAC VA: 0x6CF69CEAAC
	public static bool Raycast(Vector3 origin, Vector3 direction, ref RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69CED70 Offset: 0x1977D70 VA: 0x6CF69CED70
	public static bool Raycast(Vector3 origin, Vector3 direction, ref RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x6CF69CEE4C Offset: 0x1977E4C VA: 0x6CF69CEE4C
	public static bool Raycast(Vector3 origin, Vector3 direction, ref RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x6CF69CEF14 Offset: 0x1977F14 VA: 0x6CF69CEF14
	public static bool Raycast(Vector3 origin, Vector3 direction, ref RaycastHit hitInfo) { }

	// RVA: 0x6CF69CEFDC Offset: 0x1977FDC VA: 0x6CF69CEFDC
	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69CF074 Offset: 0x1978074 VA: 0x6CF69CF074
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	// RVA: 0x6CF69CF110 Offset: 0x1978110 VA: 0x6CF69CF110
	public static bool Raycast(Ray ray, float maxDistance) { }

	// RVA: 0x6CF69CF198 Offset: 0x1978198 VA: 0x6CF69CF198
	public static bool Raycast(Ray ray) { }

	// RVA: 0x6CF69CF220 Offset: 0x1978220 VA: 0x6CF69CF220
	public static bool Raycast(Ray ray, ref RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69CF2D0 Offset: 0x19782D0 VA: 0x6CF69CF2D0
	public static bool Raycast(Ray ray, ref RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x6CF69CF388 Offset: 0x1978388 VA: 0x6CF69CF388
	public static bool Raycast(Ray ray, ref RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x6CF69CF428 Offset: 0x1978428 VA: 0x6CF69CF428
	public static bool Raycast(Ray ray, ref RaycastHit hitInfo) { }

	// RVA: 0x6CF69CF4B8 Offset: 0x19784B8 VA: 0x6CF69CF4B8
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69CF5D4 Offset: 0x19785D4 VA: 0x6CF69CF5D4
	public static bool Linecast(Vector3 start, Vector3 end) { }

	// RVA: 0x6CF69CF670 Offset: 0x1978670 VA: 0x6CF69CF670
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, ref RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69CF74C Offset: 0x197874C VA: 0x6CF69CF74C
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, ref RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x6CF69CF808 Offset: 0x1978808 VA: 0x6CF69CF808
	public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69CF8E4 Offset: 0x19788E4 VA: 0x6CF69CF8E4
	public static bool SphereCast(Ray ray, float radius, float maxDistance) { }

	// RVA: 0x6CF69CF988 Offset: 0x1978988 VA: 0x6CF69CF988
	public static bool SphereCast(Ray ray, float radius, ref RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69CFA54 Offset: 0x1978A54 VA: 0x6CF69CFA54
	public static bool SphereCast(Ray ray, float radius, ref RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x6CF69CFB0C Offset: 0x1978B0C VA: 0x6CF69CFB0C
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69CFC20 Offset: 0x1978C20 VA: 0x6CF69CFC20
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69CFE44 Offset: 0x1978E44 VA: 0x6CF69CFE44
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	// RVA: 0x6CF69CFEF4 Offset: 0x1978EF4 VA: 0x6CF69CFEF4
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	// RVA: 0x6CF69CFFA0 Offset: 0x1978FA0 VA: 0x6CF69CFFA0
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	// RVA: 0x6CF69D0044 Offset: 0x1979044 VA: 0x6CF69D0044
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69D00F8 Offset: 0x19790F8 VA: 0x6CF69D00F8
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	// RVA: 0x6CF69D01A8 Offset: 0x19791A8 VA: 0x6CF69D01A8
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	// RVA: 0x6CF69D024C Offset: 0x197924C VA: 0x6CF69D024C
	public static RaycastHit[] RaycastAll(Ray ray) { }

	// RVA: 0x6CF69D02E8 Offset: 0x19792E8 VA: 0x6CF69D02E8
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69D05E8 Offset: 0x19795E8 VA: 0x6CF69D05E8
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	// RVA: 0x6CF69D0680 Offset: 0x1979680 VA: 0x6CF69D0680
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	// RVA: 0x6CF69D071C Offset: 0x197971C VA: 0x6CF69D071C
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	// RVA: 0x6CF69D07A8 Offset: 0x19797A8 VA: 0x6CF69D07A8
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69D087C Offset: 0x197987C VA: 0x6CF69D087C
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	// RVA: 0x6CF69D0954 Offset: 0x1979954 VA: 0x6CF69D0954
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	// RVA: 0x6CF69D0A18 Offset: 0x1979A18 VA: 0x6CF69D0A18
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	// RVA: 0x6CF69D0ADC Offset: 0x1979ADC VA: 0x6CF69D0ADC
	private static Collider[] OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69D0BFC Offset: 0x1979BFC VA: 0x6CF69D0BFC
	public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69D0C98 Offset: 0x1979C98 VA: 0x6CF69D0C98
	public static Collider[] OverlapSphere(Vector3 position, float radius) { }

	// RVA: 0x6CF69D0D1C Offset: 0x1979D1C VA: 0x6CF69D0D1C
	public static bool get_reuseCollisionCallbacks() { }

	// RVA: 0x6CF69D0D44 Offset: 0x1979D44 VA: 0x6CF69D0D44
	internal static Collider GetColliderByInstanceID(int instanceID) { }

	// RVA: 0x6CF69D0D80 Offset: 0x1979D80 VA: 0x6CF69D0D80
	internal static Component GetBodyByInstanceID(int instanceID) { }

	// RVA: 0x6CF69D0DBC Offset: 0x1979DBC VA: 0x6CF69D0DBC
	private static void SendOnCollisionEnter(Component component, Collision collision) { }

	// RVA: 0x6CF69D0E00 Offset: 0x1979E00 VA: 0x6CF69D0E00
	private static void SendOnCollisionStay(Component component, Collision collision) { }

	// RVA: 0x6CF69D0E44 Offset: 0x1979E44 VA: 0x6CF69D0E44
	private static void SendOnCollisionExit(Component component, Collision collision) { }

	// RVA: 0x6CF69D0E88 Offset: 0x1979E88 VA: 0x6CF69D0E88
	private static void OnSceneContact(PhysicsScene scene, IntPtr buffer, int count) { }

	// RVA: 0x6CF69D10E0 Offset: 0x197A0E0 VA: 0x6CF69D10E0
	private static void ReportContacts(ReadOnly array) { }

	// RVA: 0x6CF69D16E8 Offset: 0x197A6E8 VA: 0x6CF69D16E8
	private static Collision GetCollisionToReport(ref ContactPairHeader header, ref ContactPair pair, bool flipped) { }

	// RVA: 0x6CF69D1824 Offset: 0x197A824 VA: 0x6CF69D1824
	private static void .cctor() { }

	// RVA: 0x6CF69CE3C8 Offset: 0x19773C8 VA: 0x6CF69CE3C8
	private static void get_gravity_Injected(ref Vector3 ret) { }

	// RVA: 0x6CF69CE4A8 Offset: 0x19774A8 VA: 0x6CF69CE4A8
	private static void get_defaultPhysicsScene_Injected(ref PhysicsScene ret) { }

	// RVA: 0x6CF69CFBB4 Offset: 0x1978BB4 VA: 0x6CF69CFBB4
	private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69D0B90 Offset: 0x1979B90 VA: 0x6CF69D0B90
	private static Collider[] OverlapSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public struct ModifiableContactPair
{
	// Fields

	private IntPtr actor; // 0x10
	private IntPtr otherActor; // 0x18
	private IntPtr shape; // 0x20
	private IntPtr otherShape; // 0x28
	public Quaternion rotation; // 0x30
	public Vector3 position; // 0x40
	public Quaternion otherRotation; // 0x4C
	public Vector3 otherPosition; // 0x5C
	private int numContacts; // 0x68
	private IntPtr contacts; // 0x70

	// Properties


	// Methods

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public class PhysicMaterial : Object
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public struct RaycastHit
{
	// Fields

	internal Vector3 m_Point; // 0x10
	internal Vector3 m_Normal; // 0x1C
	internal uint m_FaceID; // 0x28
	internal float m_Distance; // 0x2C
	internal Vector2 m_UV; // 0x30
	internal int m_Collider; // 0x38

	// Properties

	public Collider collider { get; }
	public Vector3 point { get; }
	public Vector3 normal { get; }
	public float distance { get; }
	public Transform transform { get; }
	public Rigidbody rigidbody { get; }

	// Methods

	// RVA: 0x6CF69D1954 Offset: 0x197A954 VA: 0x6CF69D1954
	public Collider get_collider() { }

	// RVA: 0x6CF69D1A00 Offset: 0x197AA00 VA: 0x6CF69D1A00
	public Vector3 get_point() { }

	// RVA: 0x6CF69D1A0C Offset: 0x197AA0C VA: 0x6CF69D1A0C
	public Vector3 get_normal() { }

	// RVA: 0x6CF69D1A18 Offset: 0x197AA18 VA: 0x6CF69D1A18
	public float get_distance() { }

	// RVA: 0x6CF69D1A20 Offset: 0x197AA20 VA: 0x6CF69D1A20
	public Transform get_transform() { }

	// RVA: 0x6CF69D1AFC Offset: 0x197AAFC VA: 0x6CF69D1AFC
	public Rigidbody get_rigidbody() { }

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public class Rigidbody : Component
{
	// Fields


	// Properties

	public Vector3 velocity { get; set; }
	public Vector3 angularVelocity { get; set; }
	public float drag { get; set; }
	public float angularDrag { get; set; }
	public bool useGravity { set; }
	public bool isKinematic { get; set; }
	public bool freezeRotation { set; }
	public RigidbodyConstraints constraints { set; }
	public Vector3 position { get; }
	public Quaternion rotation { set; }
	public float maxAngularVelocity { set; }

	// Methods

	// RVA: 0x6CF69D1BF4 Offset: 0x197ABF4 VA: 0x6CF69D1BF4
	public Vector3 get_velocity() { }

	// RVA: 0x6CF69D1C94 Offset: 0x197AC94 VA: 0x6CF69D1C94
	public void set_velocity(Vector3 value) { }

	// RVA: 0x6CF69D1D2C Offset: 0x197AD2C VA: 0x6CF69D1D2C
	public Vector3 get_angularVelocity() { }

	// RVA: 0x6CF69D1DCC Offset: 0x197ADCC VA: 0x6CF69D1DCC
	public void set_angularVelocity(Vector3 value) { }

	// RVA: 0x6CF69D1E64 Offset: 0x197AE64 VA: 0x6CF69D1E64
	public float get_drag() { }

	// RVA: 0x6CF69D1EA0 Offset: 0x197AEA0 VA: 0x6CF69D1EA0
	public void set_drag(float value) { }

	// RVA: 0x6CF69D1EEC Offset: 0x197AEEC VA: 0x6CF69D1EEC
	public float get_angularDrag() { }

	// RVA: 0x6CF69D1F28 Offset: 0x197AF28 VA: 0x6CF69D1F28
	public void set_angularDrag(float value) { }

	// RVA: 0x6CF69D1F74 Offset: 0x197AF74 VA: 0x6CF69D1F74
	public void set_useGravity(bool value) { }

	// RVA: 0x6CF69D1FB8 Offset: 0x197AFB8 VA: 0x6CF69D1FB8
	public bool get_isKinematic() { }

	// RVA: 0x6CF69D1FF4 Offset: 0x197AFF4 VA: 0x6CF69D1FF4
	public void set_isKinematic(bool value) { }

	// RVA: 0x6CF69D2038 Offset: 0x197B038 VA: 0x6CF69D2038
	public void set_freezeRotation(bool value) { }

	// RVA: 0x6CF69D207C Offset: 0x197B07C VA: 0x6CF69D207C
	public void set_constraints(RigidbodyConstraints value) { }

	// RVA: 0x6CF69D20C0 Offset: 0x197B0C0 VA: 0x6CF69D20C0
	public Vector3 get_position() { }

	// RVA: 0x6CF69D2160 Offset: 0x197B160 VA: 0x6CF69D2160
	public void set_rotation(Quaternion value) { }

	// RVA: 0x6CF69D21F8 Offset: 0x197B1F8 VA: 0x6CF69D21F8
	public void set_maxAngularVelocity(float value) { }

	// RVA: 0x6CF69D2244 Offset: 0x197B244 VA: 0x6CF69D2244
	public void Sleep() { }

	// RVA: 0x6CF69D2280 Offset: 0x197B280 VA: 0x6CF69D2280
	public void AddForce(Vector3 force, ForceMode mode) { }

	// RVA: 0x6CF69D2330 Offset: 0x197B330 VA: 0x6CF69D2330
	public void AddForce(Vector3 force) { }

	// RVA: 0x6CF69D2338 Offset: 0x197B338 VA: 0x6CF69D2338
	public void AddRelativeForce(Vector3 force, ForceMode mode) { }

	// RVA: 0x6CF69D23E8 Offset: 0x197B3E8 VA: 0x6CF69D23E8
	public void AddRelativeForce(float x, float y, float z, ForceMode mode) { }

	// RVA: 0x6CF69D23EC Offset: 0x197B3EC VA: 0x6CF69D23EC
	public void AddRelativeForce(float x, float y, float z) { }

	// RVA: 0x6CF69D23F4 Offset: 0x197B3F4 VA: 0x6CF69D23F4
	public void AddTorque(Vector3 torque, ForceMode mode) { }

	// RVA: 0x6CF69D24A4 Offset: 0x197B4A4 VA: 0x6CF69D24A4
	public void AddTorque(Vector3 torque) { }

	// RVA: 0x6CF69D24AC Offset: 0x197B4AC VA: 0x6CF69D24AC
	public void AddRelativeTorque(Vector3 torque, ForceMode mode) { }

	// RVA: 0x6CF69D255C Offset: 0x197B55C VA: 0x6CF69D255C
	public void AddRelativeTorque(float x, float y, float z, ForceMode mode) { }

	// RVA: 0x6CF69D2560 Offset: 0x197B560 VA: 0x6CF69D2560
	public void AddRelativeTorque(float x, float y, float z) { }

	// RVA: 0x6CF69D2568 Offset: 0x197B568 VA: 0x6CF69D2568
	public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode) { }

	// RVA: 0x6CF69D262C Offset: 0x197B62C VA: 0x6CF69D262C
	public void .ctor() { }

	// RVA: 0x6CF69D1C50 Offset: 0x197AC50 VA: 0x6CF69D1C50
	private void get_velocity_Injected(ref Vector3 ret) { }

	// RVA: 0x6CF69D1CE8 Offset: 0x197ACE8 VA: 0x6CF69D1CE8
	private void set_velocity_Injected(ref Vector3 value) { }

	// RVA: 0x6CF69D1D88 Offset: 0x197AD88 VA: 0x6CF69D1D88
	private void get_angularVelocity_Injected(ref Vector3 ret) { }

	// RVA: 0x6CF69D1E20 Offset: 0x197AE20 VA: 0x6CF69D1E20
	private void set_angularVelocity_Injected(ref Vector3 value) { }

	// RVA: 0x6CF69D211C Offset: 0x197B11C VA: 0x6CF69D211C
	private void get_position_Injected(ref Vector3 ret) { }

	// RVA: 0x6CF69D21B4 Offset: 0x197B1B4 VA: 0x6CF69D21B4
	private void set_rotation_Injected(ref Quaternion value) { }

	// RVA: 0x6CF69D22DC Offset: 0x197B2DC VA: 0x6CF69D22DC
	private void AddForce_Injected(ref Vector3 force, ForceMode mode) { }

	// RVA: 0x6CF69D2394 Offset: 0x197B394 VA: 0x6CF69D2394
	private void AddRelativeForce_Injected(ref Vector3 force, ForceMode mode) { }

	// RVA: 0x6CF69D2450 Offset: 0x197B450 VA: 0x6CF69D2450
	private void AddTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	// RVA: 0x6CF69D2508 Offset: 0x197B508 VA: 0x6CF69D2508
	private void AddRelativeTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	// RVA: 0x6CF69D25D0 Offset: 0x197B5D0 VA: 0x6CF69D25D0
	private void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, ForceMode mode) { }

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public class Collider : Component
{
	// Fields


	// Properties

	public bool enabled { set; }
	public Rigidbody attachedRigidbody { get; }
	public bool isTrigger { set; }

	// Methods

	// RVA: 0x6CF69D2634 Offset: 0x197B634 VA: 0x6CF69D2634
	public void set_enabled(bool value) { }

	// RVA: 0x6CF69D1BB8 Offset: 0x197ABB8 VA: 0x6CF69D1BB8
	public Rigidbody get_attachedRigidbody() { }

	// RVA: 0x6CF69D2678 Offset: 0x197B678 VA: 0x6CF69D2678
	public void set_isTrigger(bool value) { }

	// RVA: 0x6CF69D26BC Offset: 0x197B6BC VA: 0x6CF69D26BC
	public void .ctor() { }

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public class CharacterController : Collider
{
	// Fields


	// Properties

	public Vector3 velocity { get; }
	public bool isGrounded { get; }
	public float radius { get; }
	public float height { get; set; }
	public Vector3 center { set; }
	public float slopeLimit { get; }

	// Methods

	// RVA: 0x6CF69D26C4 Offset: 0x197B6C4 VA: 0x6CF69D26C4
	public CollisionFlags Move(Vector3 motion) { }

	// RVA: 0x6CF69D275C Offset: 0x197B75C VA: 0x6CF69D275C
	public Vector3 get_velocity() { }

	// RVA: 0x6CF69D27FC Offset: 0x197B7FC VA: 0x6CF69D27FC
	public bool get_isGrounded() { }

	// RVA: 0x6CF69D2838 Offset: 0x197B838 VA: 0x6CF69D2838
	public float get_radius() { }

	// RVA: 0x6CF69D2874 Offset: 0x197B874 VA: 0x6CF69D2874
	public float get_height() { }

	// RVA: 0x6CF69D28B0 Offset: 0x197B8B0 VA: 0x6CF69D28B0
	public void set_height(float value) { }

	// RVA: 0x6CF69D28FC Offset: 0x197B8FC VA: 0x6CF69D28FC
	public void set_center(Vector3 value) { }

	// RVA: 0x6CF69D2994 Offset: 0x197B994 VA: 0x6CF69D2994
	public float get_slopeLimit() { }

	// RVA: 0x6CF69D2718 Offset: 0x197B718 VA: 0x6CF69D2718
	private CollisionFlags Move_Injected(ref Vector3 motion) { }

	// RVA: 0x6CF69D27B8 Offset: 0x197B7B8 VA: 0x6CF69D27B8
	private void get_velocity_Injected(ref Vector3 ret) { }

	// RVA: 0x6CF69D2950 Offset: 0x197B950 VA: 0x6CF69D2950
	private void set_center_Injected(ref Vector3 value) { }

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public class MeshCollider : Collider
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public class CapsuleCollider : Collider
{
	// Fields


	// Properties

	public Vector3 center { get; set; }
	public float radius { get; }
	public float height { get; set; }

	// Methods

	// RVA: 0x6CF69D29D0 Offset: 0x197B9D0 VA: 0x6CF69D29D0
	public Vector3 get_center() { }

	// RVA: 0x6CF69D2A70 Offset: 0x197BA70 VA: 0x6CF69D2A70
	public void set_center(Vector3 value) { }

	// RVA: 0x6CF69D2B08 Offset: 0x197BB08 VA: 0x6CF69D2B08
	public float get_radius() { }

	// RVA: 0x6CF69D2B44 Offset: 0x197BB44 VA: 0x6CF69D2B44
	public float get_height() { }

	// RVA: 0x6CF69D2B80 Offset: 0x197BB80 VA: 0x6CF69D2B80
	public void set_height(float value) { }

	// RVA: 0x6CF69D2A2C Offset: 0x197BA2C VA: 0x6CF69D2A2C
	private void get_center_Injected(ref Vector3 ret) { }

	// RVA: 0x6CF69D2AC4 Offset: 0x197BAC4 VA: 0x6CF69D2AC4
	private void set_center_Injected(ref Vector3 value) { }

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public class BoxCollider : Collider
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public class SphereCollider : Collider
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public class Joint : Component
{
	// Fields


	// Properties

	public Rigidbody connectedBody { get; set; }
	public Vector3 anchor { set; }

	// Methods

	// RVA: 0x6CF69D2BCC Offset: 0x197BBCC VA: 0x6CF69D2BCC
	public Rigidbody get_connectedBody() { }

	// RVA: 0x6CF69D2C08 Offset: 0x197BC08 VA: 0x6CF69D2C08
	public void set_connectedBody(Rigidbody value) { }

	// RVA: 0x6CF69D2C4C Offset: 0x197BC4C VA: 0x6CF69D2C4C
	public void set_anchor(Vector3 value) { }

	// RVA: 0x6CF69D2CA0 Offset: 0x197BCA0 VA: 0x6CF69D2CA0
	private void set_anchor_Injected(ref Vector3 value) { }

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public class SpringJoint : Joint
{
	// Fields


	// Properties

	public float spring { set; }
	public float damper { set; }
	public float maxDistance { set; }

	// Methods

	// RVA: 0x6CF69D2CE4 Offset: 0x197BCE4 VA: 0x6CF69D2CE4
	public void set_spring(float value) { }

	// RVA: 0x6CF69D2D30 Offset: 0x197BD30 VA: 0x6CF69D2D30
	public void set_damper(float value) { }

	// RVA: 0x6CF69D2D7C Offset: 0x197BD7C VA: 0x6CF69D2D7C
	public void set_maxDistance(float value) { }

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public struct ContactPoint
{
	// Fields

	internal Vector3 m_Point; // 0x10
	internal Vector3 m_Normal; // 0x1C
	internal Vector3 m_Impulse; // 0x28
	internal int m_ThisColliderInstanceID; // 0x34
	internal int m_OtherColliderInstanceID; // 0x38
	internal float m_Separation; // 0x3C

	// Properties


	// Methods

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public struct PhysicsScene : IEquatable`1
{
	// Fields

	private int m_Handle; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF69D2DC8 Offset: 0x197BDC8 VA: 0x6CF69D2DC8
	public override string ToString() { }

	// RVA: 0x6CF69D2EAC Offset: 0x197BEAC VA: 0x6CF69D2EAC
	public override int GetHashCode() { }

	// RVA: 0x6CF69D2EB4 Offset: 0x197BEB4 VA: 0x6CF69D2EB4
	public override bool Equals(object other) { }

	// RVA: 0x6CF69D2F2C Offset: 0x197BF2C VA: 0x6CF69D2F2C
	public bool Equals(PhysicsScene other) { }

	// RVA: 0x6CF69CE698 Offset: 0x1977698 VA: 0x6CF69CE698
	public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69D2F3C Offset: 0x197BF3C VA: 0x6CF69D2F3C
	private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69CEB84 Offset: 0x1977B84 VA: 0x6CF69CEB84
	public bool Raycast(Vector3 origin, Vector3 direction, ref RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69D3024 Offset: 0x197C024 VA: 0x6CF69D3024
	private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69D0394 Offset: 0x1979394 VA: 0x6CF69D0394
	public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69D311C Offset: 0x197C11C VA: 0x6CF69D311C
	private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69D3210 Offset: 0x197C210 VA: 0x6CF69D3210
	private static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69D3338 Offset: 0x197C338 VA: 0x6CF69D3338
	private static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, ref RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69CF744 Offset: 0x1978744 VA: 0x6CF69CF744
	public bool SphereCast(Vector3 origin, float radius, Vector3 direction, ref RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69D2FB8 Offset: 0x197BFB8 VA: 0x6CF69D2FB8
	private static bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69D30A0 Offset: 0x197C0A0 VA: 0x6CF69D30A0
	private static bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69D3194 Offset: 0x197C194 VA: 0x6CF69D3194
	private static int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x6CF69D32AC Offset: 0x197C2AC VA: 0x6CF69D32AC
	private static bool Query_SphereCast_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public struct ContactPairHeader
{
	// Fields

	internal readonly int m_BodyID; // 0x10
	internal readonly int m_OtherBodyID; // 0x14
	internal readonly IntPtr m_StartPtr; // 0x18
	internal readonly uint m_NbPairs; // 0x20
	internal readonly CollisionPairHeaderFlags m_Flags; // 0x24
	internal readonly Vector3 m_RelativeVelocity; // 0x28

	// Properties

	public Component Body { get; }
	public Component OtherBody { get; }
	internal bool HasRemovedBody { get; }

	// Methods

	// RVA: 0x6CF69D14D4 Offset: 0x197A4D4 VA: 0x6CF69D14D4
	public Component get_Body() { }

	// RVA: 0x6CF69D154C Offset: 0x197A54C VA: 0x6CF69D154C
	public Component get_OtherBody() { }

	// RVA: 0x6CF69D14B0 Offset: 0x197A4B0 VA: 0x6CF69D14B0
	internal bool get_HasRemovedBody() { }

	// RVA: 0x6CF69D14C0 Offset: 0x197A4C0 VA: 0x6CF69D14C0
	public ref ContactPair GetContactPair(int index) { }

	// RVA: 0x6CF69D3464 Offset: 0x197C464 VA: 0x6CF69D3464
	internal ContactPair* GetContactPair_Internal(int index) { }

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public struct ContactPair
{
	// Fields

	internal readonly int m_ColliderID; // 0x10
	internal readonly int m_OtherColliderID; // 0x14
	internal readonly IntPtr m_StartPtr; // 0x18
	internal readonly uint m_NbPoints; // 0x20
	internal readonly CollisionPairFlags m_Flags; // 0x24
	internal readonly CollisionPairEventFlags m_Events; // 0x26
	internal readonly Vector3 m_ImpulseSum; // 0x28

	// Properties

	public Collider Collider { get; }
	public Collider OtherCollider { get; }
	public bool IsCollisionEnter { get; }
	public bool IsCollisionExit { get; }
	public bool IsCollisionStay { get; }
	internal bool HasRemovedCollider { get; }

	// Methods

	// RVA: 0x6CF69D15C4 Offset: 0x197A5C4 VA: 0x6CF69D15C4
	public Collider get_Collider() { }

	// RVA: 0x6CF69D1650 Offset: 0x197A650 VA: 0x6CF69D1650
	public Collider get_OtherCollider() { }

	// RVA: 0x6CF69D16DC Offset: 0x197A6DC VA: 0x6CF69D16DC
	public bool get_IsCollisionEnter() { }

	// RVA: 0x6CF69D1818 Offset: 0x197A818 VA: 0x6CF69D1818
	public bool get_IsCollisionExit() { }

	// RVA: 0x6CF69D180C Offset: 0x197A80C VA: 0x6CF69D180C
	public bool get_IsCollisionStay() { }

	// RVA: 0x6CF69D14C4 Offset: 0x197A4C4 VA: 0x6CF69D14C4
	internal bool get_HasRemovedCollider() { }

	// RVA: 0x6CF69CE1D4 Offset: 0x19771D4 VA: 0x6CF69CE1D4
	internal int ExtractContactsArray(ContactPoint[] managedContainer, bool flipped) { }

	// RVA: 0x6CF69D34E4 Offset: 0x197C4E4 VA: 0x6CF69D34E4
	private static int ExtractContactsArray_Injected(ref ContactPair _unity_self, ContactPoint[] managedContainer, bool flipped) { }

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
internal enum CollisionPairHeaderFlags
{
	// Fields

	public ushort value__; // 0x10
	public const CollisionPairHeaderFlags RemovedActor = 1; // 0x0
	public const CollisionPairHeaderFlags RemovedOtherActor = 2; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
internal enum CollisionPairFlags
{
	// Fields

	public ushort value__; // 0x10
	public const CollisionPairFlags RemovedShape = 1; // 0x0
	public const CollisionPairFlags RemovedOtherShape = 2; // 0x0
	public const CollisionPairFlags ActorPairHasFirstTouch = 4; // 0x0
	public const CollisionPairFlags ActorPairLostTouch = 8; // 0x0
	public const CollisionPairFlags InternalHasImpulses = 16; // 0x0
	public const CollisionPairFlags InternalContactsAreFlipped = 32; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
internal enum CollisionPairEventFlags
{
	// Fields

	public ushort value__; // 0x10
	public const CollisionPairEventFlags SolveContacts = 1; // 0x0
	public const CollisionPairEventFlags ModifyContacts = 2; // 0x0
	public const CollisionPairEventFlags NotifyTouchFound = 4; // 0x0
	public const CollisionPairEventFlags NotifyTouchPersists = 8; // 0x0
	public const CollisionPairEventFlags NotifyTouchLost = 16; // 0x0
	public const CollisionPairEventFlags NotifyTouchCCD = 32; // 0x0
	public const CollisionPairEventFlags NotifyThresholdForceFound = 64; // 0x0
	public const CollisionPairEventFlags NotifyThresholdForcePersists = 128; // 0x0
	public const CollisionPairEventFlags NotifyThresholdForceLost = 256; // 0x0
	public const CollisionPairEventFlags NotifyContactPoint = 512; // 0x0
	public const CollisionPairEventFlags DetectDiscreteContact = 1024; // 0x0
	public const CollisionPairEventFlags DetectCCDContact = 2048; // 0x0
	public const CollisionPairEventFlags PreSolverVelocity = 4096; // 0x0
	public const CollisionPairEventFlags PostSolverVelocity = 8192; // 0x0
	public const CollisionPairEventFlags ContactEventPose = 16384; // 0x0
	public const CollisionPairEventFlags NextFree = 32768; // 0x0
	public const CollisionPairEventFlags ContactDefault = 1025; // 0x0
	public const CollisionPairEventFlags TriggerDefault = 1044; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore
[Serializable]
public struct FaceInfo
{
	// Fields

	private int m_FaceIndex; // 0x10
	private string m_FamilyName; // 0x18
	private string m_StyleName; // 0x20
	private int m_PointSize; // 0x28
	private float m_Scale; // 0x2C
	private int m_UnitsPerEM; // 0x30
	private float m_LineHeight; // 0x34
	private float m_AscentLine; // 0x38
	private float m_CapLine; // 0x3C
	private float m_MeanLine; // 0x40
	private float m_Baseline; // 0x44
	private float m_DescentLine; // 0x48
	private float m_SuperscriptOffset; // 0x4C
	private float m_SuperscriptSize; // 0x50
	private float m_SubscriptOffset; // 0x54
	private float m_SubscriptSize; // 0x58
	private float m_UnderlineOffset; // 0x5C
	private float m_UnderlineThickness; // 0x60
	private float m_StrikethroughOffset; // 0x64
	private float m_StrikethroughThickness; // 0x68
	private float m_TabWidth; // 0x6C

	// Properties

	internal int faceIndex { get; }
	public string familyName { get; }
	public string styleName { get; }
	public int pointSize { get; }
	public float scale { get; set; }
	public float lineHeight { get; }
	public float ascentLine { get; }
	public float capLine { get; set; }
	public float meanLine { get; set; }
	public float baseline { get; }
	public float descentLine { get; }
	public float superscriptOffset { get; }
	public float superscriptSize { get; }
	public float subscriptOffset { get; }
	public float subscriptSize { get; }
	public float underlineOffset { get; }
	public float underlineThickness { get; }
	public float strikethroughOffset { get; set; }
	public float tabWidth { get; }

	// Methods

	// RVA: 0x6CF69D92A8 Offset: 0x19822A8 VA: 0x6CF69D92A8
	internal int get_faceIndex() { }

	// RVA: 0x6CF69D92B0 Offset: 0x19822B0 VA: 0x6CF69D92B0
	public string get_familyName() { }

	// RVA: 0x6CF69D92B8 Offset: 0x19822B8 VA: 0x6CF69D92B8
	public string get_styleName() { }

	// RVA: 0x6CF69D92C0 Offset: 0x19822C0 VA: 0x6CF69D92C0
	public int get_pointSize() { }

	// RVA: 0x6CF69D92C8 Offset: 0x19822C8 VA: 0x6CF69D92C8
	public float get_scale() { }

	// RVA: 0x6CF69D92D0 Offset: 0x19822D0 VA: 0x6CF69D92D0
	public void set_scale(float value) { }

	// RVA: 0x6CF69D92D8 Offset: 0x19822D8 VA: 0x6CF69D92D8
	public float get_lineHeight() { }

	// RVA: 0x6CF69D92E0 Offset: 0x19822E0 VA: 0x6CF69D92E0
	public float get_ascentLine() { }

	// RVA: 0x6CF69D92E8 Offset: 0x19822E8 VA: 0x6CF69D92E8
	public float get_capLine() { }

	// RVA: 0x6CF69D92F0 Offset: 0x19822F0 VA: 0x6CF69D92F0
	public void set_capLine(float value) { }

	// RVA: 0x6CF69D92F8 Offset: 0x19822F8 VA: 0x6CF69D92F8
	public float get_meanLine() { }

	// RVA: 0x6CF69D9300 Offset: 0x1982300 VA: 0x6CF69D9300
	public void set_meanLine(float value) { }

	// RVA: 0x6CF69D9308 Offset: 0x1982308 VA: 0x6CF69D9308
	public float get_baseline() { }

	// RVA: 0x6CF69D9310 Offset: 0x1982310 VA: 0x6CF69D9310
	public float get_descentLine() { }

	// RVA: 0x6CF69D9318 Offset: 0x1982318 VA: 0x6CF69D9318
	public float get_superscriptOffset() { }

	// RVA: 0x6CF69D9320 Offset: 0x1982320 VA: 0x6CF69D9320
	public float get_superscriptSize() { }

	// RVA: 0x6CF69D9328 Offset: 0x1982328 VA: 0x6CF69D9328
	public float get_subscriptOffset() { }

	// RVA: 0x6CF69D9330 Offset: 0x1982330 VA: 0x6CF69D9330
	public float get_subscriptSize() { }

	// RVA: 0x6CF69D9338 Offset: 0x1982338 VA: 0x6CF69D9338
	public float get_underlineOffset() { }

	// RVA: 0x6CF69D9340 Offset: 0x1982340 VA: 0x6CF69D9340
	public float get_underlineThickness() { }

	// RVA: 0x6CF69D9348 Offset: 0x1982348 VA: 0x6CF69D9348
	public float get_strikethroughOffset() { }

	// RVA: 0x6CF69D9350 Offset: 0x1982350 VA: 0x6CF69D9350
	public void set_strikethroughOffset(float value) { }

	// RVA: 0x6CF69D9358 Offset: 0x1982358 VA: 0x6CF69D9358
	public float get_tabWidth() { }

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore
public enum GlyphClassDefinitionType
{
	// Fields

	public int value__; // 0x10
	public const GlyphClassDefinitionType Undefined = 0; // 0x0
	public const GlyphClassDefinitionType Base = 1; // 0x0
	public const GlyphClassDefinitionType Ligature = 2; // 0x0
	public const GlyphClassDefinitionType Mark = 3; // 0x0
	public const GlyphClassDefinitionType Component = 4; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore
[Serializable]
public struct GlyphRect : IEquatable`1
{
	// Fields

	private int m_X; // 0x10
	private int m_Y; // 0x14
	private int m_Width; // 0x18
	private int m_Height; // 0x1C
	private static readonly GlyphRect s_ZeroGlyphRect; // 0x0

	// Properties

	public int x { get; }
	public int y { get; }
	public int width { get; }
	public int height { get; }
	public static GlyphRect zero { get; }

	// Methods

	// RVA: 0x6CF69D9360 Offset: 0x1982360 VA: 0x6CF69D9360
	public int get_x() { }

	// RVA: 0x6CF69D9368 Offset: 0x1982368 VA: 0x6CF69D9368
	public int get_y() { }

	// RVA: 0x6CF69D9370 Offset: 0x1982370 VA: 0x6CF69D9370
	public int get_width() { }

	// RVA: 0x6CF69D9378 Offset: 0x1982378 VA: 0x6CF69D9378
	public int get_height() { }

	// RVA: 0x6CF69D9380 Offset: 0x1982380 VA: 0x6CF69D9380
	public static GlyphRect get_zero() { }

	// RVA: 0x6CF69D93D8 Offset: 0x19823D8 VA: 0x6CF69D93D8
	public void .ctor(int x, int y, int width, int height) { }

	// RVA: 0x6CF69D93E4 Offset: 0x19823E4 VA: 0x6CF69D93E4
	public override int GetHashCode() { }

	// RVA: 0x6CF69D9448 Offset: 0x1982448 VA: 0x6CF69D9448
	public override bool Equals(object obj) { }

	// RVA: 0x6CF69D94C0 Offset: 0x19824C0 VA: 0x6CF69D94C0
	public bool Equals(GlyphRect other) { }

	// RVA: 0x6CF69D9554 Offset: 0x1982554 VA: 0x6CF69D9554
	private static void .cctor() { }

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore
[Serializable]
public struct GlyphMetrics : IEquatable`1
{
	// Fields

	private float m_Width; // 0x10
	private float m_Height; // 0x14
	private float m_HorizontalBearingX; // 0x18
	private float m_HorizontalBearingY; // 0x1C
	private float m_HorizontalAdvance; // 0x20

	// Properties

	public float width { get; }
	public float height { get; }
	public float horizontalBearingX { get; }
	public float horizontalBearingY { get; }
	public float horizontalAdvance { get; }

	// Methods

	// RVA: 0x6CF69D959C Offset: 0x198259C VA: 0x6CF69D959C
	public float get_width() { }

	// RVA: 0x6CF69D95A4 Offset: 0x19825A4 VA: 0x6CF69D95A4
	public float get_height() { }

	// RVA: 0x6CF69D95AC Offset: 0x19825AC VA: 0x6CF69D95AC
	public float get_horizontalBearingX() { }

	// RVA: 0x6CF69D95B4 Offset: 0x19825B4 VA: 0x6CF69D95B4
	public float get_horizontalBearingY() { }

	// RVA: 0x6CF69D95BC Offset: 0x19825BC VA: 0x6CF69D95BC
	public float get_horizontalAdvance() { }

	// RVA: 0x6CF69D95C4 Offset: 0x19825C4 VA: 0x6CF69D95C4
	public void .ctor(float width, float height, float bearingX, float bearingY, float advance) { }

	// RVA: 0x6CF69D95D4 Offset: 0x19825D4 VA: 0x6CF69D95D4
	public override int GetHashCode() { }

	// RVA: 0x6CF69D9640 Offset: 0x1982640 VA: 0x6CF69D9640
	public override bool Equals(object obj) { }

	// RVA: 0x6CF69D96C0 Offset: 0x19826C0 VA: 0x6CF69D96C0
	public bool Equals(GlyphMetrics other) { }

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore
[Serializable]
public class Glyph : Object
{
	// Fields

	private uint m_Index; // 0x10
	private GlyphMetrics m_Metrics; // 0x14
	private GlyphRect m_GlyphRect; // 0x28
	private float m_Scale; // 0x38
	private int m_AtlasIndex; // 0x3C
	private GlyphClassDefinitionType m_ClassDefinitionType; // 0x40

	// Properties

	public uint index { get; }
	public GlyphMetrics metrics { get; }
	public GlyphRect glyphRect { get; }
	public float scale { get; }
	public int atlasIndex { get; set; }

	// Methods

	// RVA: 0x6CF69D9764 Offset: 0x1982764 VA: 0x6CF69D9764
	public uint get_index() { }

	// RVA: 0x6CF69D976C Offset: 0x198276C VA: 0x6CF69D976C
	public GlyphMetrics get_metrics() { }

	// RVA: 0x6CF69D9780 Offset: 0x1982780 VA: 0x6CF69D9780
	public GlyphRect get_glyphRect() { }

	// RVA: 0x6CF69D978C Offset: 0x198278C VA: 0x6CF69D978C
	public float get_scale() { }

	// RVA: 0x6CF69D9794 Offset: 0x1982794 VA: 0x6CF69D9794
	public int get_atlasIndex() { }

	// RVA: 0x6CF69D979C Offset: 0x198279C VA: 0x6CF69D979C
	public void set_atlasIndex(int value) { }

	// RVA: 0x6CF69D97A4 Offset: 0x19827A4 VA: 0x6CF69D97A4
	public void .ctor() { }

	// RVA: 0x6CF69D97CC Offset: 0x19827CC VA: 0x6CF69D97CC
	internal void .ctor(GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x6CF69D9858 Offset: 0x1982858 VA: 0x6CF69D9858
	public void .ctor(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore.LowLevel
public enum GlyphLoadFlags
{
	// Fields

	public int value__; // 0x10
	public const GlyphLoadFlags LOAD_DEFAULT = 0; // 0x0
	public const GlyphLoadFlags LOAD_NO_SCALE = 1; // 0x0
	public const GlyphLoadFlags LOAD_NO_HINTING = 2; // 0x0
	public const GlyphLoadFlags LOAD_RENDER = 4; // 0x0
	public const GlyphLoadFlags LOAD_NO_BITMAP = 8; // 0x0
	public const GlyphLoadFlags LOAD_FORCE_AUTOHINT = 32; // 0x0
	public const GlyphLoadFlags LOAD_MONOCHROME = 4096; // 0x0
	public const GlyphLoadFlags LOAD_NO_AUTOHINT = 32768; // 0x0
	public const GlyphLoadFlags LOAD_COLOR = 1048576; // 0x0
	public const GlyphLoadFlags LOAD_COMPUTE_METRICS = 2097152; // 0x0
	public const GlyphLoadFlags LOAD_BITMAP_METRICS_ONLY = 4194304; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore.LowLevel
public enum FontEngineError
{
	// Fields

	public int value__; // 0x10
	public const FontEngineError Success = 0; // 0x0
	public const FontEngineError Invalid_File_Path = 1; // 0x0
	public const FontEngineError Invalid_File_Format = 2; // 0x0
	public const FontEngineError Invalid_File_Structure = 3; // 0x0
	public const FontEngineError Invalid_File = 4; // 0x0
	public const FontEngineError Invalid_Table = 8; // 0x0
	public const FontEngineError Invalid_Glyph_Index = 16; // 0x0
	public const FontEngineError Invalid_Character_Code = 17; // 0x0
	public const FontEngineError Invalid_Pixel_Size = 23; // 0x0
	public const FontEngineError Invalid_Library = 33; // 0x0
	public const FontEngineError Invalid_Face = 35; // 0x0
	public const FontEngineError Invalid_Library_or_Face = 41; // 0x0
	public const FontEngineError Atlas_Generation_Cancelled = 100; // 0x0
	public const FontEngineError Invalid_SharedTextureData = 101; // 0x0
	public const FontEngineError OpenTypeLayoutLookup_Mismatch = 116; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore.LowLevel
public enum GlyphRenderMode
{
	// Fields

	public int value__; // 0x10
	public const GlyphRenderMode SMOOTH_HINTED = 4121; // 0x0
	public const GlyphRenderMode SMOOTH = 4117; // 0x0
	public const GlyphRenderMode COLOR_HINTED = 69656; // 0x0
	public const GlyphRenderMode COLOR = 69652; // 0x0
	public const GlyphRenderMode RASTER_HINTED = 4122; // 0x0
	public const GlyphRenderMode RASTER = 4118; // 0x0
	public const GlyphRenderMode SDF = 4134; // 0x0
	public const GlyphRenderMode SDF8 = 8230; // 0x0
	public const GlyphRenderMode SDF16 = 16422; // 0x0
	public const GlyphRenderMode SDF32 = 32806; // 0x0
	public const GlyphRenderMode SDFAA_HINTED = 4169; // 0x0
	public const GlyphRenderMode SDFAA = 4165; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore.LowLevel
public enum GlyphPackingMode
{
	// Fields

	public int value__; // 0x10
	public const GlyphPackingMode BestShortSideFit = 0; // 0x0
	public const GlyphPackingMode BestLongSideFit = 1; // 0x0
	public const GlyphPackingMode BestAreaFit = 2; // 0x0
	public const GlyphPackingMode BottomLeftRule = 3; // 0x0
	public const GlyphPackingMode ContactPointRule = 4; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore.LowLevel
internal struct FontReference
{
	// Fields

	public string familyName; // 0x10
	public string styleName; // 0x18
	public int faceIndex; // 0x20
	public string filePath; // 0x28

	// Properties


	// Methods

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore.LowLevel
public sealed class FontEngine : Object
{
	// Fields

	private static Glyph[] s_Glyphs; // 0x0
	private static UInt32[] s_GlyphIndexes_MarshallingArray_A; // 0x8
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN; // 0x10
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT; // 0x18
	private static GlyphRect[] s_FreeGlyphRects; // 0x20
	private static GlyphRect[] s_UsedGlyphRects; // 0x28
	private static GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray; // 0x30
	private static Dictionary`2 s_GlyphLookupDictionary; // 0x38

	// Properties


	// Methods

	// RVA: 0x6CF69D98C8 Offset: 0x19828C8 VA: 0x6CF69D98C8
	public static FontEngineError LoadFontFace(string filePath, int pointSize, int faceIndex) { }

	// RVA: 0x6CF69D9954 Offset: 0x1982954 VA: 0x6CF69D9954
	private static int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex) { }

	// RVA: 0x6CF69D99A8 Offset: 0x19829A8 VA: 0x6CF69D99A8
	public static FontEngineError LoadFontFace(Font font, int pointSize, int faceIndex) { }

	// RVA: 0x6CF69D9A34 Offset: 0x1982A34 VA: 0x6CF69D9A34
	private static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(Font font, int pointSize, int faceIndex) { }

	// RVA: 0x6CF69D9A88 Offset: 0x1982A88 VA: 0x6CF69D9A88
	public static FontEngineError LoadFontFace(string familyName, string styleName, int pointSize) { }

	// RVA: 0x6CF69D9B14 Offset: 0x1982B14 VA: 0x6CF69D9B14
	private static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize) { }

	// RVA: 0x6CF69D9B68 Offset: 0x1982B68 VA: 0x6CF69D9B68
	internal static bool TryGetSystemFontReference(string familyName, string styleName, ref FontReference fontRef) { }

	// RVA: 0x6CF69D9BF4 Offset: 0x1982BF4 VA: 0x6CF69D9BF4
	private static bool TryGetSystemFontReference_Internal(string familyName, string styleName, ref FontReference fontRef) { }

	// RVA: 0x6CF69D9C48 Offset: 0x1982C48 VA: 0x6CF69D9C48
	public static FaceInfo GetFaceInfo() { }

	// RVA: 0x6CF69D9CE8 Offset: 0x1982CE8 VA: 0x6CF69D9CE8
	private static int GetFaceInfo_Internal(ref FaceInfo faceInfo) { }

	// RVA: 0x6CF69D9D24 Offset: 0x1982D24 VA: 0x6CF69D9D24
	internal static uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x6CF69D9D60 Offset: 0x1982D60 VA: 0x6CF69D9D60
	public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, ref Glyph glyph) { }

	// RVA: 0x6CF69D9EA4 Offset: 0x1982EA4 VA: 0x6CF69D9EA4
	private static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x6CF69D9EF8 Offset: 0x1982EF8 VA: 0x6CF69D9EF8
	public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, ref Glyph glyph) { }

	// RVA: 0x6CF69DA03C Offset: 0x198303C VA: 0x6CF69DA03C
	private static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x6CF69DA090 Offset: 0x1983090 VA: 0x6CF69DA090
	internal static void SetTextureUploadMode(bool shouldUploadImmediately) { }

	// RVA: 0x6CF69DA0CC Offset: 0x19830CC VA: 0x6CF69DA0CC
	internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List`1 freeGlyphRects, List`1 usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, ref Glyph glyph) { }

	// RVA: 0x6CF69DA5E0 Offset: 0x19835E0 VA: 0x6CF69DA5E0
	private static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, ref GlyphMarshallingStruct glyph) { }

	// RVA: 0x6CF69DA67C Offset: 0x198367C VA: 0x6CF69DA67C
	internal static bool TryAddGlyphsToTexture(List`1 glyphIndexes, int padding, GlyphPackingMode packingMode, List`1 freeGlyphRects, List`1 usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, ref Glyph[] glyphs) { }

	// RVA: 0x6CF69DAF2C Offset: 0x1983F2C VA: 0x6CF69DAF2C
	private static bool TryAddGlyphsToTexture_Internal(UInt32[] glyphIndex, int padding, GlyphPackingMode packingMode, GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, GlyphMarshallingStruct[] glyphs, ref int glyphCount) { }

	// RVA: 0x6CF69DAFD4 Offset: 0x1983FD4 VA: 0x6CF69DAFD4
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(UInt32[] glyphIndexes) { }

	// RVA: 0x6CF69DB1A4 Offset: 0x19841A4 VA: 0x6CF69DB1A4
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(List`1 glyphIndexes, ref int recordCount) { }

	// RVA: 0x6CF69DB124 Offset: 0x1984124 VA: 0x6CF69DB124
	private static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(UInt32[] glyphIndexes, ref int recordCount) { }

	// RVA: 0x6CF69DB168 Offset: 0x1984168 VA: 0x6CF69DB168
	private static int GetPairAdjustmentRecordsFromMarshallingArray(GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords) { }

	// RVA: 0x6CF5BE19C0 Offset: 0xB8A9C0 VA: 0x6CF5BE19C0
	private static void GenericListToMarshallingArray(ref List`1 srcList, ref T[] dstArray) { }

	// RVA: 0x6CF5BE1540 Offset: 0xB8A540 VA: 0x6CF5BE1540
	private static void SetMarshallingArraySize(ref T[] marshallingArray, int recordCount) { }

	// RVA: 0x6CF69DB32C Offset: 0x198432C VA: 0x6CF69DB32C
	internal static void ResetAtlasTexture(Texture2D texture) { }

	// RVA: 0x6CF69DB368 Offset: 0x1984368 VA: 0x6CF69DB368
	private static void .cctor() { }

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore.LowLevel
internal struct FontEngineUtilities
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69DAF0C Offset: 0x1983F0C VA: 0x6CF69DAF0C
	internal static int MaxValue(int a, int b, int c) { }

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore.LowLevel
internal struct GlyphMarshallingStruct
{
	// Fields

	public uint index; // 0x10
	public GlyphMetrics metrics; // 0x14
	public GlyphRect glyphRect; // 0x28
	public float scale; // 0x38
	public int atlasIndex; // 0x3C
	public GlyphClassDefinitionType classDefinitionType; // 0x40

	// Properties


	// Methods

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore.LowLevel
public enum FontFeatureLookupFlags
{
	// Fields

	public int value__; // 0x10
	public const FontFeatureLookupFlags None = 0; // 0x0
	public const FontFeatureLookupFlags IgnoreLigatures = 4; // 0x0
	public const FontFeatureLookupFlags IgnoreSpacingAdjustments = 256; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore.LowLevel
[Serializable]
public struct GlyphValueRecord : IEquatable`1
{
	// Fields

	private float m_XPlacement; // 0x10
	private float m_YPlacement; // 0x14
	private float m_XAdvance; // 0x18
	private float m_YAdvance; // 0x1C

	// Properties

	public float xPlacement { get; set; }
	public float yPlacement { get; set; }
	public float xAdvance { get; }
	public float yAdvance { get; }

	// Methods

	// RVA: 0x6CF69DB4B0 Offset: 0x19844B0 VA: 0x6CF69DB4B0
	public float get_xPlacement() { }

	// RVA: 0x6CF69DB4B8 Offset: 0x19844B8 VA: 0x6CF69DB4B8
	public void set_xPlacement(float value) { }

	// RVA: 0x6CF69DB4C0 Offset: 0x19844C0 VA: 0x6CF69DB4C0
	public float get_yPlacement() { }

	// RVA: 0x6CF69DB4C8 Offset: 0x19844C8 VA: 0x6CF69DB4C8
	public void set_yPlacement(float value) { }

	// RVA: 0x6CF69DB4D0 Offset: 0x19844D0 VA: 0x6CF69DB4D0
	public float get_xAdvance() { }

	// RVA: 0x6CF69DB4D8 Offset: 0x19844D8 VA: 0x6CF69DB4D8
	public float get_yAdvance() { }

	// RVA: 0x6CF69DB4E0 Offset: 0x19844E0 VA: 0x6CF69DB4E0
	public static GlyphValueRecord op_Addition(GlyphValueRecord a, GlyphValueRecord b) { }

	// RVA: 0x6CF69DB4F4 Offset: 0x19844F4 VA: 0x6CF69DB4F4
	public override int GetHashCode() { }

	// RVA: 0x6CF69DB558 Offset: 0x1984558 VA: 0x6CF69DB558
	public override bool Equals(object obj) { }

	// RVA: 0x6CF69DB5D0 Offset: 0x19845D0 VA: 0x6CF69DB5D0
	public bool Equals(GlyphValueRecord other) { }

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore.LowLevel
[Serializable]
public struct GlyphAdjustmentRecord : IEquatable`1
{
	// Fields

	private uint m_GlyphIndex; // 0x10
	private GlyphValueRecord m_GlyphValueRecord; // 0x14

	// Properties

	public uint glyphIndex { get; }
	public GlyphValueRecord glyphValueRecord { get; }

	// Methods

	// RVA: 0x6CF69DB678 Offset: 0x1984678 VA: 0x6CF69DB678
	public uint get_glyphIndex() { }

	// RVA: 0x6CF69DB680 Offset: 0x1984680 VA: 0x6CF69DB680
	public GlyphValueRecord get_glyphValueRecord() { }

	// RVA: 0x6CF69DB68C Offset: 0x198468C VA: 0x6CF69DB68C
	public override int GetHashCode() { }

	// RVA: 0x6CF69DB6F8 Offset: 0x19846F8 VA: 0x6CF69DB6F8
	public override bool Equals(object obj) { }

	// RVA: 0x6CF69DB778 Offset: 0x1984778 VA: 0x6CF69DB778
	public bool Equals(GlyphAdjustmentRecord other) { }

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore.LowLevel
[Serializable]
public struct GlyphPairAdjustmentRecord : IEquatable`1
{
	// Fields

	private GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
	private GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
	private FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38

	// Properties

	public GlyphAdjustmentRecord firstAdjustmentRecord { get; }
	public GlyphAdjustmentRecord secondAdjustmentRecord { get; }
	public FontFeatureLookupFlags featureLookupFlags { get; }

	// Methods

	// RVA: 0x6CF69DB81C Offset: 0x198481C VA: 0x6CF69DB81C
	public GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0x6CF69DB830 Offset: 0x1984830 VA: 0x6CF69DB830
	public GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	// RVA: 0x6CF69DB844 Offset: 0x1984844 VA: 0x6CF69DB844
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	// RVA: 0x6CF69DB84C Offset: 0x198484C VA: 0x6CF69DB84C
	public override int GetHashCode() { }

	// RVA: 0x6CF69DB8B8 Offset: 0x19848B8 VA: 0x6CF69DB8B8
	public override bool Equals(object obj) { }

	// RVA: 0x6CF69DB938 Offset: 0x1984938 VA: 0x6CF69DB938
	public bool Equals(GlyphPairAdjustmentRecord other) { }

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore.LowLevel
[Serializable]
internal struct GlyphAnchorPoint
{
	// Fields

	private float m_XCoordinate; // 0x10
	private float m_YCoordinate; // 0x14

	// Properties

	public float xCoordinate { get; }
	public float yCoordinate { get; }

	// Methods

	// RVA: 0x6CF69DB9DC Offset: 0x19849DC VA: 0x6CF69DB9DC
	public float get_xCoordinate() { }

	// RVA: 0x6CF69DB9E4 Offset: 0x19849E4 VA: 0x6CF69DB9E4
	public float get_yCoordinate() { }

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore.LowLevel
[Serializable]
internal struct MarkPositionAdjustment
{
	// Fields

	private float m_XPositionAdjustment; // 0x10
	private float m_YPositionAdjustment; // 0x14

	// Properties

	public float xPositionAdjustment { get; }
	public float yPositionAdjustment { get; }

	// Methods

	// RVA: 0x6CF69DB9EC Offset: 0x19849EC VA: 0x6CF69DB9EC
	public float get_xPositionAdjustment() { }

	// RVA: 0x6CF69DB9F4 Offset: 0x19849F4 VA: 0x6CF69DB9F4
	public float get_yPositionAdjustment() { }

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore.LowLevel
[Serializable]
internal struct MarkToBaseAdjustmentRecord
{
	// Fields

	private uint m_BaseGlyphID; // 0x10
	private GlyphAnchorPoint m_BaseGlyphAnchorPoint; // 0x14
	private uint m_MarkGlyphID; // 0x1C
	private MarkPositionAdjustment m_MarkPositionAdjustment; // 0x20

	// Properties

	public uint baseGlyphID { get; }
	public GlyphAnchorPoint baseGlyphAnchorPoint { get; }
	public uint markGlyphID { get; }
	public MarkPositionAdjustment markPositionAdjustment { get; }

	// Methods

	// RVA: 0x6CF69DB9FC Offset: 0x19849FC VA: 0x6CF69DB9FC
	public uint get_baseGlyphID() { }

	// RVA: 0x6CF69DBA04 Offset: 0x1984A04 VA: 0x6CF69DBA04
	public GlyphAnchorPoint get_baseGlyphAnchorPoint() { }

	// RVA: 0x6CF69DBA0C Offset: 0x1984A0C VA: 0x6CF69DBA0C
	public uint get_markGlyphID() { }

	// RVA: 0x6CF69DBA14 Offset: 0x1984A14 VA: 0x6CF69DBA14
	public MarkPositionAdjustment get_markPositionAdjustment() { }

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore.LowLevel
[Serializable]
internal struct MarkToMarkAdjustmentRecord
{
	// Fields

	private uint m_BaseMarkGlyphID; // 0x10
	private GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint; // 0x14
	private uint m_CombiningMarkGlyphID; // 0x1C
	private MarkPositionAdjustment m_CombiningMarkPositionAdjustment; // 0x20

	// Properties

	public uint baseMarkGlyphID { get; }
	public GlyphAnchorPoint baseMarkGlyphAnchorPoint { get; }
	public uint combiningMarkGlyphID { get; }
	public MarkPositionAdjustment combiningMarkPositionAdjustment { get; }

	// Methods

	// RVA: 0x6CF69DBA1C Offset: 0x1984A1C VA: 0x6CF69DBA1C
	public uint get_baseMarkGlyphID() { }

	// RVA: 0x6CF69DBA24 Offset: 0x1984A24 VA: 0x6CF69DBA24
	public GlyphAnchorPoint get_baseMarkGlyphAnchorPoint() { }

	// RVA: 0x6CF69DBA2C Offset: 0x1984A2C VA: 0x6CF69DBA2C
	public uint get_combiningMarkGlyphID() { }

	// RVA: 0x6CF69DBA34 Offset: 0x1984A34 VA: 0x6CF69DBA34
	public MarkPositionAdjustment get_combiningMarkPositionAdjustment() { }

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore.LowLevel
[Serializable]
internal struct MultipleSubstitutionRecord
{
	// Fields

	private uint m_TargetGlyphID; // 0x10
	private UInt32[] m_SubstituteGlyphIDs; // 0x18

	// Properties


	// Methods

}

// Dll : UnityEngine.TextCoreFontEngineModule.dll
// Namespace: UnityEngine.TextCore.LowLevel
[Serializable]
internal struct LigatureSubstitutionRecord
{
	// Fields

	private UInt32[] m_ComponentGlyphIDs; // 0x10
	private uint m_LigatureGlyphID; // 0x18

	// Properties

	public UInt32[] componentGlyphIDs { get; }
	public uint ligatureGlyphID { get; }

	// Methods

	// RVA: 0x6CF69DBA3C Offset: 0x1984A3C VA: 0x6CF69DBA3C
	public UInt32[] get_componentGlyphIDs() { }

	// RVA: 0x6CF69DBA44 Offset: 0x1984A44 VA: 0x6CF69DBA44
	public uint get_ligatureGlyphID() { }

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
public sealed class SharedBetweenAnimatorsAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
public abstract class StateMachineBehaviour : ScriptableObject
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF695EBAC Offset: 0x1907BAC VA: 0x6CF695EBAC
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x6CF695EBB0 Offset: 0x1907BB0 VA: 0x6CF695EBB0
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x6CF695EBB4 Offset: 0x1907BB4 VA: 0x6CF695EBB4
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x6CF695EBB8 Offset: 0x1907BB8 VA: 0x6CF695EBB8
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x6CF695EBBC Offset: 0x1907BBC VA: 0x6CF695EBBC
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x6CF695EBC0 Offset: 0x1907BC0 VA: 0x6CF695EBC0
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x6CF695EBC4 Offset: 0x1907BC4 VA: 0x6CF695EBC4
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x6CF695EBC8 Offset: 0x1907BC8 VA: 0x6CF695EBC8
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x6CF695EBCC Offset: 0x1907BCC VA: 0x6CF695EBCC
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x6CF695EBD0 Offset: 0x1907BD0 VA: 0x6CF695EBD0
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x6CF695EBD4 Offset: 0x1907BD4 VA: 0x6CF695EBD4
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x6CF695EBD8 Offset: 0x1907BD8 VA: 0x6CF695EBD8
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x6CF695EBDC Offset: 0x1907BDC VA: 0x6CF695EBDC
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x6CF695EBE0 Offset: 0x1907BE0 VA: 0x6CF695EBE0
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x6CF695EBE4 Offset: 0x1907BE4 VA: 0x6CF695EBE4
	protected void .ctor() { }

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
public enum PlayMode
{
	// Fields

	public int value__; // 0x10
	public const PlayMode StopSameLayer = 0; // 0x0
	public const PlayMode StopAll = 4; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
internal enum AnimationEventSource
{
	// Fields

	public int value__; // 0x10
	public const AnimationEventSource NoSource = 0; // 0x0
	public const AnimationEventSource Legacy = 1; // 0x0
	public const AnimationEventSource Animator = 2; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: 
private sealed class Enumerator : Object, IEnumerator
{
	// Fields

	private Animation m_Outer; // 0x10
	private int m_CurrentIndex; // 0x18

	// Properties

	public object Current { get; }

	// Methods

	// RVA: 0x6CF695F114 Offset: 0x1908114 VA: 0x6CF695F114
	internal void .ctor(Animation outer) { }

	// RVA: 0x6CF695F1C4 Offset: 0x19081C4 VA: 0x6CF695F1C4
	public object get_Current() { }

	// RVA: 0x6CF695F210 Offset: 0x1908210 VA: 0x6CF695F210
	public bool MoveNext() { }

	// RVA: 0x6CF695F270 Offset: 0x1908270 VA: 0x6CF695F270
	public void Reset() { }

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
public sealed class Animation : Behaviour, IEnumerable
{
	// Fields


	// Properties

	public bool playAutomatically { set; }
	public bool isPlaying { get; }
	public AnimationState Item { get; }

	// Methods

	// RVA: 0x6CF695EBEC Offset: 0x1907BEC VA: 0x6CF695EBEC
	public void set_playAutomatically(bool value) { }

	// RVA: 0x6CF695EC30 Offset: 0x1907C30 VA: 0x6CF695EC30
	public void Stop() { }

	// RVA: 0x6CF695EC6C Offset: 0x1907C6C VA: 0x6CF695EC6C
	public void Stop(string name) { }

	// RVA: 0x6CF695ECB0 Offset: 0x1907CB0 VA: 0x6CF695ECB0
	private void StopNamed(string name) { }

	// RVA: 0x6CF695ECF4 Offset: 0x1907CF4 VA: 0x6CF695ECF4
	public void Rewind(string name) { }

	// RVA: 0x6CF695ED38 Offset: 0x1907D38 VA: 0x6CF695ED38
	private void RewindNamed(string name) { }

	// RVA: 0x6CF695ED7C Offset: 0x1907D7C VA: 0x6CF695ED7C
	public bool get_isPlaying() { }

	// RVA: 0x6CF695EDB8 Offset: 0x1907DB8 VA: 0x6CF695EDB8
	public AnimationState get_Item(string name) { }

	// RVA: 0x6CF695EE40 Offset: 0x1907E40 VA: 0x6CF695EE40
	public bool Play() { }

	// RVA: 0x6CF695EE80 Offset: 0x1907E80 VA: 0x6CF695EE80
	public bool Play(PlayMode mode) { }

	// RVA: 0x6CF695EEC4 Offset: 0x1907EC4 VA: 0x6CF695EEC4
	private bool PlayDefaultAnimation(PlayMode mode) { }

	// RVA: 0x6CF695EF08 Offset: 0x1907F08 VA: 0x6CF695EF08
	public bool Play(string animation) { }

	// RVA: 0x6CF695EF50 Offset: 0x1907F50 VA: 0x6CF695EF50
	public bool Play(string animation, PlayMode mode) { }

	// RVA: 0x6CF695EFA4 Offset: 0x1907FA4 VA: 0x6CF695EFA4
	public void CrossFade(string animation) { }

	// RVA: 0x6CF695EFF4 Offset: 0x1907FF4 VA: 0x6CF695EFF4
	public void CrossFade(string animation, float fadeLength) { }

	// RVA: 0x6CF695F04C Offset: 0x190804C VA: 0x6CF695F04C
	public void CrossFade(string animation, float fadeLength, PlayMode mode) { }

	// RVA: 0x6CF695F0B0 Offset: 0x19080B0 VA: 0x6CF695F0B0
	public IEnumerator GetEnumerator() { }

	// RVA: 0x6CF695EDFC Offset: 0x1907DFC VA: 0x6CF695EDFC
	internal AnimationState GetState(string name) { }

	// RVA: 0x6CF695F144 Offset: 0x1908144 VA: 0x6CF695F144
	internal AnimationState GetStateAtIndex(int index) { }

	// RVA: 0x6CF695F188 Offset: 0x1908188 VA: 0x6CF695F188
	internal int GetStateCount() { }

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
public sealed class AnimationState : TrackedReference
{
	// Fields


	// Properties

	public WrapMode wrapMode { set; }
	public float time { set; }
	public float speed { get; set; }
	public float length { get; }
	public int layer { set; }

	// Methods

	// RVA: 0x6CF695F27C Offset: 0x190827C VA: 0x6CF695F27C
	public void set_wrapMode(WrapMode value) { }

	// RVA: 0x6CF695F2C0 Offset: 0x19082C0 VA: 0x6CF695F2C0
	public void set_time(float value) { }

	// RVA: 0x6CF695F30C Offset: 0x190830C VA: 0x6CF695F30C
	public float get_speed() { }

	// RVA: 0x6CF695F348 Offset: 0x1908348 VA: 0x6CF695F348
	public void set_speed(float value) { }

	// RVA: 0x6CF695F394 Offset: 0x1908394 VA: 0x6CF695F394
	public float get_length() { }

	// RVA: 0x6CF695F3D0 Offset: 0x19083D0 VA: 0x6CF695F3D0
	public void set_layer(int value) { }

	// RVA: 0x6CF695F414 Offset: 0x1908414 VA: 0x6CF695F414
	public void AddMixingTransform(Transform mix) { }

	// RVA: 0x6CF695F45C Offset: 0x190845C VA: 0x6CF695F45C
	public void AddMixingTransform(Transform mix, bool recursive) { }

	// RVA: 0x6CF695F4B0 Offset: 0x19084B0 VA: 0x6CF695F4B0
	public void .ctor() { }

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
[Serializable]
public sealed class AnimationEvent : Object
{
	// Fields

	internal float m_Time; // 0x10
	internal string m_FunctionName; // 0x18
	internal string m_StringParameter; // 0x20
	internal object m_ObjectReferenceParameter; // 0x28
	internal float m_FloatParameter; // 0x30
	internal int m_IntParameter; // 0x34
	internal int m_MessageOptions; // 0x38
	internal AnimationEventSource m_Source; // 0x3C
	internal AnimationState m_StateSender; // 0x40
	internal AnimatorStateInfo m_AnimatorStateInfo; // 0x48
	internal AnimatorClipInfo m_AnimatorClipInfo; // 0x6C

	// Properties


	// Methods

	// RVA: 0x6CF695F4B8 Offset: 0x19084B8 VA: 0x6CF695F4B8
	public void .ctor() { }

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
public sealed class AnimationClip : Motion
{
	// Fields


	// Properties

	public WrapMode wrapMode { get; set; }

	// Methods

	// RVA: 0x6CF695F51C Offset: 0x190851C VA: 0x6CF695F51C
	public void SampleAnimation(GameObject go, float time) { }

	// RVA: 0x6CF695F5E4 Offset: 0x19085E4 VA: 0x6CF695F5E4
	internal static void SampleAnimation(GameObject go, AnimationClip clip, float inTime, WrapMode wrapMode) { }

	// RVA: 0x6CF695F5A8 Offset: 0x19085A8 VA: 0x6CF695F5A8
	public WrapMode get_wrapMode() { }

	// RVA: 0x6CF695F648 Offset: 0x1908648 VA: 0x6CF695F648
	public void set_wrapMode(WrapMode value) { }

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
internal enum StateInfoIndex
{
	// Fields

	public int value__; // 0x10
	public const StateInfoIndex CurrentState = 0; // 0x0
	public const StateInfoIndex NextState = 1; // 0x0
	public const StateInfoIndex ExitState = 2; // 0x0
	public const StateInfoIndex InterruptedState = 3; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
public struct AnimatorClipInfo
{
	// Fields

	private int m_ClipInstanceID; // 0x10
	private float m_Weight; // 0x14

	// Properties


	// Methods

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
public struct AnimatorStateInfo
{
	// Fields

	private int m_Name; // 0x10
	private int m_Path; // 0x14
	private int m_FullPath; // 0x18
	private float m_NormalizedTime; // 0x1C
	private float m_Length; // 0x20
	private float m_Speed; // 0x24
	private float m_SpeedMultiplier; // 0x28
	private int m_Tag; // 0x2C
	private int m_Loop; // 0x30

	// Properties

	public float normalizedTime { get; }

	// Methods

	// RVA: 0x6CF695F68C Offset: 0x190868C VA: 0x6CF695F68C
	public bool IsName(string name) { }

	// RVA: 0x6CF695F738 Offset: 0x1908738 VA: 0x6CF695F738
	public float get_normalizedTime() { }

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
public struct AnimatorTransitionInfo
{
	// Fields

	private int m_FullPath; // 0x10
	private int m_UserName; // 0x14
	private int m_Name; // 0x18
	private bool m_HasFixedDuration; // 0x1C
	private float m_Duration; // 0x20
	private float m_NormalizedTime; // 0x24
	private bool m_AnyState; // 0x28
	private int m_TransitionType; // 0x2C

	// Properties


	// Methods

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
public class Animator : Behaviour
{
	// Fields


	// Properties

	public Vector3 deltaPosition { get; }
	public bool applyRootMotion { get; set; }
	public float speed { set; }
	public bool hasBoundPlayables { get; }

	// Methods

	// RVA: 0x6CF695F740 Offset: 0x1908740 VA: 0x6CF695F740
	public float GetFloat(string name) { }

	// RVA: 0x6CF695F7C8 Offset: 0x19087C8 VA: 0x6CF695F7C8
	public void SetFloat(string name, float value) { }

	// RVA: 0x6CF695F870 Offset: 0x1908870 VA: 0x6CF695F870
	public void SetFloat(string name, float value, float dampTime, float deltaTime) { }

	// RVA: 0x6CF695F948 Offset: 0x1908948 VA: 0x6CF695F948
	public bool GetBool(string name) { }

	// RVA: 0x6CF695F9D0 Offset: 0x19089D0 VA: 0x6CF695F9D0
	public void SetBool(string name, bool value) { }

	// RVA: 0x6CF695FA78 Offset: 0x1908A78 VA: 0x6CF695FA78
	public int GetInteger(string name) { }

	// RVA: 0x6CF695FB00 Offset: 0x1908B00 VA: 0x6CF695FB00
	public void SetInteger(string name, int value) { }

	// RVA: 0x6CF695FBA8 Offset: 0x1908BA8 VA: 0x6CF695FBA8
	public void SetTrigger(string name) { }

	// RVA: 0x6CF695FC30 Offset: 0x1908C30 VA: 0x6CF695FC30
	public void ResetTrigger(string name) { }

	// RVA: 0x6CF695FCB8 Offset: 0x1908CB8 VA: 0x6CF695FCB8
	public Vector3 get_deltaPosition() { }

	// RVA: 0x6CF695FD58 Offset: 0x1908D58 VA: 0x6CF695FD58
	public bool get_applyRootMotion() { }

	// RVA: 0x6CF695FD94 Offset: 0x1908D94 VA: 0x6CF695FD94
	public void set_applyRootMotion(bool value) { }

	// RVA: 0x6CF695FDD8 Offset: 0x1908DD8 VA: 0x6CF695FDD8
	public float GetLayerWeight(int layerIndex) { }

	// RVA: 0x6CF695FE1C Offset: 0x1908E1C VA: 0x6CF695FE1C
	public void SetLayerWeight(int layerIndex, float weight) { }

	// RVA: 0x6CF695FE70 Offset: 0x1908E70 VA: 0x6CF695FE70
	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, ref AnimatorStateInfo info) { }

	// RVA: 0x6CF695FECC Offset: 0x1908ECC VA: 0x6CF695FECC
	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x6CF695FF4C Offset: 0x1908F4C VA: 0x6CF695FF4C
	public void set_speed(float value) { }

	// RVA: 0x6CF695FF98 Offset: 0x1908F98 VA: 0x6CF695FF98
	public bool get_hasBoundPlayables() { }

	// RVA: 0x6CF695F6FC Offset: 0x19086FC VA: 0x6CF695F6FC
	public static int StringToHash(string name) { }

	// RVA: 0x6CF695F81C Offset: 0x190881C VA: 0x6CF695F81C
	private void SetFloatString(string name, float value) { }

	// RVA: 0x6CF695F784 Offset: 0x1908784 VA: 0x6CF695F784
	private float GetFloatString(string name) { }

	// RVA: 0x6CF695FA24 Offset: 0x1908A24 VA: 0x6CF695FA24
	private void SetBoolString(string name, bool value) { }

	// RVA: 0x6CF695F98C Offset: 0x190898C VA: 0x6CF695F98C
	private bool GetBoolString(string name) { }

	// RVA: 0x6CF695FB54 Offset: 0x1908B54 VA: 0x6CF695FB54
	private void SetIntegerString(string name, int value) { }

	// RVA: 0x6CF695FABC Offset: 0x1908ABC VA: 0x6CF695FABC
	private int GetIntegerString(string name) { }

	// RVA: 0x6CF695FBEC Offset: 0x1908BEC VA: 0x6CF695FBEC
	private void SetTriggerString(string name) { }

	// RVA: 0x6CF695FC74 Offset: 0x1908C74 VA: 0x6CF695FC74
	private void ResetTriggerString(string name) { }

	// RVA: 0x6CF695F8DC Offset: 0x19088DC VA: 0x6CF695F8DC
	private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	// RVA: 0x6CF695FD14 Offset: 0x1908D14 VA: 0x6CF695FD14
	private void get_deltaPosition_Injected(ref Vector3 ret) { }

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: 
internal sealed class OnOverrideControllerDirtyCallback : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6960004 Offset: 0x1909004 VA: 0x6CF6960004
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF696008C Offset: 0x190908C VA: 0x6CF696008C
	public virtual void Invoke() { }

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
public class AnimatorOverrideController : RuntimeAnimatorController
{
	// Fields

	internal OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF695FFD4 Offset: 0x1908FD4 VA: 0x6CF695FFD4
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
public struct SkeletonBone
{
	// Fields

	public string name; // 0x10
	internal string parentName; // 0x18
	public Vector3 position; // 0x20
	public Quaternion rotation; // 0x2C
	public Vector3 scale; // 0x3C

	// Properties


	// Methods

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
public struct HumanLimit
{
	// Fields

	private Vector3 m_Min; // 0x10
	private Vector3 m_Max; // 0x1C
	private Vector3 m_Center; // 0x28
	private float m_AxisLength; // 0x34
	private int m_UseDefaultValues; // 0x38

	// Properties


	// Methods

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
public struct HumanBone
{
	// Fields

	private string m_BoneName; // 0x10
	private string m_HumanName; // 0x18
	public HumanLimit limit; // 0x20

	// Properties


	// Methods

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
public class Motion : Object
{
	// Fields

	private readonly bool <isAnimatorMotion>k__BackingField; // 0x18

	// Properties


	// Methods

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
public class RuntimeAnimatorController : Object
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine.Animations
public class DiscreteEvaluationAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine.Animations
public class NotKeyableAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine.Animations
public struct AnimationClipPlayable : IEquatable`1
{
	// Fields

	private PlayableHandle m_Handle; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF69600A0 Offset: 0x19090A0 VA: 0x6CF69600A0
	public PlayableHandle GetHandle() { }

	// RVA: 0x6CF69600AC Offset: 0x19090AC VA: 0x6CF69600AC
	public bool Equals(AnimationClipPlayable other) { }

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine.Animations
public struct AnimationHumanStream
{
	// Fields

	private IntPtr stream; // 0x10

	// Properties


	// Methods

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine.Animations
public struct AnimationLayerMixerPlayable : IEquatable`1
{
	// Fields

	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationLayerMixerPlayable m_NullPlayable; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF6960124 Offset: 0x1909124 VA: 0x6CF6960124
	internal void .ctor(PlayableHandle handle, bool singleLayerOptimization) { }

	// RVA: 0x6CF69602B4 Offset: 0x19092B4 VA: 0x6CF69602B4
	public PlayableHandle GetHandle() { }

	// RVA: 0x6CF69602C0 Offset: 0x19092C0 VA: 0x6CF69602C0
	public bool Equals(AnimationLayerMixerPlayable other) { }

	// RVA: 0x6CF6960270 Offset: 0x1909270 VA: 0x6CF6960270
	private static void SetSingleLayerOptimizationInternal(ref PlayableHandle handle, bool value) { }

	// RVA: 0x6CF696035C Offset: 0x190935C VA: 0x6CF696035C
	private static void .cctor() { }

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine.Animations
public struct AnimationMixerPlayable : IEquatable`1
{
	// Fields

	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationMixerPlayable m_NullPlayable; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF69603FC Offset: 0x19093FC VA: 0x6CF69603FC
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x6CF69604EC Offset: 0x19094EC VA: 0x6CF69604EC
	public PlayableHandle GetHandle() { }

	// RVA: 0x6CF69604F8 Offset: 0x19094F8 VA: 0x6CF69604F8
	public bool Equals(AnimationMixerPlayable other) { }

	// RVA: 0x6CF6960594 Offset: 0x1909594 VA: 0x6CF6960594
	private static void .cctor() { }

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine.Animations
internal struct AnimationMotionXToDeltaPlayable : IEquatable`1
{
	// Fields

	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF6960630 Offset: 0x1909630 VA: 0x6CF6960630
	private void .ctor(PlayableHandle handle) { }

	// RVA: 0x6CF6960720 Offset: 0x1909720 VA: 0x6CF6960720
	public PlayableHandle GetHandle() { }

	// RVA: 0x6CF696072C Offset: 0x190972C VA: 0x6CF696072C
	public bool Equals(AnimationMotionXToDeltaPlayable other) { }

	// RVA: 0x6CF69607C8 Offset: 0x19097C8 VA: 0x6CF69607C8
	private static void .cctor() { }

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine.Animations
internal struct AnimationOffsetPlayable : IEquatable`1
{
	// Fields

	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF6960864 Offset: 0x1909864 VA: 0x6CF6960864
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x6CF6960954 Offset: 0x1909954 VA: 0x6CF6960954
	public PlayableHandle GetHandle() { }

	// RVA: 0x6CF6960960 Offset: 0x1909960 VA: 0x6CF6960960
	public bool Equals(AnimationOffsetPlayable other) { }

	// RVA: 0x6CF6960A14 Offset: 0x1909A14 VA: 0x6CF6960A14
	private static void .cctor() { }

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine.Animations
public struct AnimationPlayableOutput
{
	// Fields

	private PlayableOutputHandle m_Handle; // 0x10

	// Properties


	// Methods

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine.Animations
internal struct AnimationPosePlayable : IEquatable`1
{
	// Fields

	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationPosePlayable m_NullPlayable; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF6960AB0 Offset: 0x1909AB0 VA: 0x6CF6960AB0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x6CF6960BA0 Offset: 0x1909BA0 VA: 0x6CF6960BA0
	public PlayableHandle GetHandle() { }

	// RVA: 0x6CF6960BAC Offset: 0x1909BAC VA: 0x6CF6960BAC
	public bool Equals(AnimationPosePlayable other) { }

	// RVA: 0x6CF6960C60 Offset: 0x1909C60 VA: 0x6CF6960C60
	private static void .cctor() { }

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine.Animations
internal struct AnimationRemoveScalePlayable : IEquatable`1
{
	// Fields

	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF6960CFC Offset: 0x1909CFC VA: 0x6CF6960CFC
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x6CF6960DEC Offset: 0x1909DEC VA: 0x6CF6960DEC
	public PlayableHandle GetHandle() { }

	// RVA: 0x6CF6960DF8 Offset: 0x1909DF8 VA: 0x6CF6960DF8
	public bool Equals(AnimationRemoveScalePlayable other) { }

	// RVA: 0x6CF6960EAC Offset: 0x1909EAC VA: 0x6CF6960EAC
	private static void .cctor() { }

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine.Animations
public struct AnimationScriptPlayable : IEquatable`1
{
	// Fields

	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationScriptPlayable m_NullPlayable; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF6960F48 Offset: 0x1909F48 VA: 0x6CF6960F48
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x6CF6961038 Offset: 0x190A038 VA: 0x6CF6961038
	public PlayableHandle GetHandle() { }

	// RVA: 0x6CF6961044 Offset: 0x190A044 VA: 0x6CF6961044
	public bool Equals(AnimationScriptPlayable other) { }

	// RVA: 0x6CF69610E0 Offset: 0x190A0E0 VA: 0x6CF69610E0
	private static void .cctor() { }

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine.Animations
public struct AnimationStream
{
	// Fields

	private uint m_AnimatorBindingsVersion; // 0x10
	private IntPtr constant; // 0x18
	private IntPtr input; // 0x20
	private IntPtr output; // 0x28
	private IntPtr workspace; // 0x30
	private IntPtr inputStreamAccessor; // 0x38
	private IntPtr animationHandleBinder; // 0x40

	// Properties


	// Methods

}

// Dll : UnityEngine.AnimationModule.dll
// Namespace: UnityEngine.Animations
public struct AnimatorControllerPlayable : IEquatable`1
{
	// Fields

	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimatorControllerPlayable m_NullPlayable; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF696117C Offset: 0x190A17C VA: 0x6CF696117C
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x6CF696135C Offset: 0x190A35C VA: 0x6CF696135C
	public PlayableHandle GetHandle() { }

	// RVA: 0x6CF6961218 Offset: 0x190A218 VA: 0x6CF6961218
	public void SetHandle(PlayableHandle handle) { }

	// RVA: 0x6CF6961368 Offset: 0x190A368 VA: 0x6CF6961368
	public bool Equals(AnimatorControllerPlayable other) { }

	// RVA: 0x6CF6961404 Offset: 0x190A404 VA: 0x6CF6961404
	private static void .cctor() { }

}

// Dll : System.Numerics.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.Numerics.dll
// Namespace: 
private enum GetBytesMode
{
	// Fields

	public int value__; // 0x10
	public const GetBytesMode AllocateArray = 0; // 0x0
	public const GetBytesMode Count = 1; // 0x0
	public const GetBytesMode Span = 2; // 0x0

	// Properties


	// Methods

}

// Dll : System.Numerics.dll
// Namespace: System.Numerics
[Serializable]
public struct BigInteger : IFormattable, IComparable, IComparable`1, IEquatable`1
{
	// Fields

	internal readonly int _sign; // 0x10
	internal readonly UInt32[] _bits; // 0x18
	private static readonly BigInteger s_bnMinInt; // 0x0
	private static readonly BigInteger s_bnOneInt; // 0x10
	private static readonly BigInteger s_bnZeroInt; // 0x20
	private static readonly BigInteger s_bnMinusOneInt; // 0x30
	private static readonly Byte[] s_success; // 0x40

	// Properties

	public static BigInteger MinusOne { get; }

	// Methods

	// RVA: 0x6CF67C3300 Offset: 0x176C300 VA: 0x6CF67C3300
	public void .ctor(int value) { }

	// RVA: 0x6CF67C337C Offset: 0x176C37C VA: 0x6CF67C337C
	public void .ctor(long value) { }

	// RVA: 0x6CF67C3494 Offset: 0x176C494 VA: 0x6CF67C3494
	public void .ctor(Byte[] value) { }

	// RVA: 0x6CF67C3558 Offset: 0x176C558 VA: 0x6CF67C3558
	public void .ctor(ReadOnlySpan`1 value, bool isUnsigned, bool isBigEndian) { }

	// RVA: 0x6CF67C3B44 Offset: 0x176CB44 VA: 0x6CF67C3B44
	internal void .ctor(int n, UInt32[] rgu) { }

	// RVA: 0x6CF67C3B50 Offset: 0x176CB50 VA: 0x6CF67C3B50
	internal void .ctor(UInt32[] value, bool negative) { }

	// RVA: 0x6CF67C3CD8 Offset: 0x176CCD8 VA: 0x6CF67C3CD8
	public static BigInteger get_MinusOne() { }

	// RVA: 0x6CF67C3D30 Offset: 0x176CD30 VA: 0x6CF67C3D30
	public override int GetHashCode() { }

	// RVA: 0x6CF67C3D70 Offset: 0x176CD70 VA: 0x6CF67C3D70
	public override bool Equals(object obj) { }

	// RVA: 0x6CF67C3E18 Offset: 0x176CE18 VA: 0x6CF67C3E18
	public bool Equals(BigInteger other) { }

	// RVA: 0x6CF67C3F3C Offset: 0x176CF3C VA: 0x6CF67C3F3C
	public int CompareTo(BigInteger other) { }

	// RVA: 0x6CF67C4064 Offset: 0x176D064 VA: 0x6CF67C4064
	public int CompareTo(object obj) { }

	// RVA: 0x6CF67C4168 Offset: 0x176D168 VA: 0x6CF67C4168
	public bool TryWriteBytes(Span`1 destination, ref int bytesWritten, bool isUnsigned, bool isBigEndian) { }

	// RVA: 0x6CF67C4724 Offset: 0x176D724 VA: 0x6CF67C4724
	internal bool TryWriteOrCountBytes(Span`1 destination, ref int bytesWritten, bool isUnsigned, bool isBigEndian) { }

	// RVA: 0x6CF67C4218 Offset: 0x176D218 VA: 0x6CF67C4218
	private Byte[] TryGetBytes(GetBytesMode mode, Span`1 destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten) { }

	// RVA: 0x6CF67C47CC Offset: 0x176D7CC VA: 0x6CF67C47CC
	public override string ToString() { }

	// RVA: 0x6CF67C48A8 Offset: 0x176D8A8 VA: 0x6CF67C48A8
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x6CF67C48E0 Offset: 0x176D8E0 VA: 0x6CF67C48E0
	private static BigInteger Add(UInt32[] leftBits, int leftSign, UInt32[] rightBits, int rightSign) { }

	// RVA: 0x6CF67C4C24 Offset: 0x176DC24 VA: 0x6CF67C4C24
	private static BigInteger Subtract(UInt32[] leftBits, int leftSign, UInt32[] rightBits, int rightSign) { }

	// RVA: 0x6CF67C4FE0 Offset: 0x176DFE0 VA: 0x6CF67C4FE0
	public static BigInteger op_Implicit(byte value) { }

	// RVA: 0x6CF67C5008 Offset: 0x176E008 VA: 0x6CF67C5008
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x6CF67C4A2C Offset: 0x176DA2C VA: 0x6CF67C4A2C
	public static BigInteger op_Implicit(long value) { }

	// RVA: 0x6CF67C5030 Offset: 0x176E030 VA: 0x6CF67C5030
	public static int op_Explicit(BigInteger value) { }

	// RVA: 0x6CF67C5108 Offset: 0x176E108 VA: 0x6CF67C5108
	public static BigInteger op_LeftShift(BigInteger value, int shift) { }

	// RVA: 0x6CF67C535C Offset: 0x176E35C VA: 0x6CF67C535C
	public static BigInteger op_RightShift(BigInteger value, int shift) { }

	// RVA: 0x6CF67C5738 Offset: 0x176E738 VA: 0x6CF67C5738
	public static BigInteger op_Addition(BigInteger left, BigInteger right) { }

	// RVA: 0x6CF67C5680 Offset: 0x176E680 VA: 0x6CF67C5680
	private static bool GetPartsForBitManipulation(ref BigInteger x, ref UInt32[] xd, ref int xl) { }

	// RVA: 0x6CF67C3ED4 Offset: 0x176CED4 VA: 0x6CF67C3ED4
	internal static int GetDiffLength(UInt32[] rgu1, UInt32[] rgu2, int cu) { }

	// RVA: 0x6CF67C57E4 Offset: 0x176E7E4 VA: 0x6CF67C57E4
	private static void .cctor() { }

}

// Dll : System.Numerics.dll
// Namespace: System.Numerics
internal static class BigIntegerCalculator : Object
{
	// Fields

	private static int ReducerThreshold; // 0x0
	private static int SquareThreshold; // 0x4
	private static int AllocationThreshold; // 0x8
	private static int MultiplyThreshold; // 0xC

	// Properties


	// Methods

	// RVA: 0x6CF67C4A60 Offset: 0x176DA60 VA: 0x6CF67C4A60
	public static UInt32[] Add(UInt32[] left, uint right) { }

	// RVA: 0x6CF67C4B38 Offset: 0x176DB38 VA: 0x6CF67C4B38
	public static UInt32[] Add(UInt32[] left, UInt32[] right) { }

	// RVA: 0x6CF67C5934 Offset: 0x176E934 VA: 0x6CF67C5934
	private static void Add(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	// RVA: 0x6CF67C4DB4 Offset: 0x176DDB4 VA: 0x6CF67C4DB4
	public static UInt32[] Subtract(UInt32[] left, uint right) { }

	// RVA: 0x6CF67C4EEC Offset: 0x176DEEC VA: 0x6CF67C4EEC
	public static UInt32[] Subtract(UInt32[] left, UInt32[] right) { }

	// RVA: 0x6CF67C59B8 Offset: 0x176E9B8 VA: 0x6CF67C59B8
	private static void Subtract(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	// RVA: 0x6CF67C4E6C Offset: 0x176DE6C VA: 0x6CF67C4E6C
	public static int Compare(UInt32[] left, UInt32[] right) { }

	// RVA: 0x6CF67C5A30 Offset: 0x176EA30 VA: 0x6CF67C5A30
	private static void .cctor() { }

}

// Dll : System.Numerics.dll
// Namespace: System.Numerics
internal static class BigNumber : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF67C5A80 Offset: 0x176EA80 VA: 0x6CF67C5A80
	internal static char ParseFormatSpecifier(ReadOnlySpan`1 format, ref int digits) { }

	// RVA: 0x6CF67C5B70 Offset: 0x176EB70 VA: 0x6CF67C5B70
	private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, char format, int digits, NumberFormatInfo info, Span`1 destination, ref int charsWritten, ref bool spanSuccess) { }

	// RVA: 0x6CF67C47FC Offset: 0x176D7FC VA: 0x6CF67C47FC
	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

	// RVA: 0x6CF67C64A8 Offset: 0x176F4A8 VA: 0x6CF67C64A8
	private static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, ReadOnlySpan`1 formatSpan, NumberFormatInfo info, Span`1 destination, ref int charsWritten, ref bool spanSuccess) { }

}

// Dll : System.Numerics.dll
// Namespace: System.Numerics
internal static class NumericsHelpers : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF67C3A90 Offset: 0x176CA90 VA: 0x6CF67C3A90
	public static void DangerousMakeTwosComplement(UInt32[] d) { }

	// RVA: 0x6CF67C6E88 Offset: 0x176FE88 VA: 0x6CF67C6E88
	public static ulong MakeUlong(uint uHi, uint uLo) { }

	// RVA: 0x6CF67C4A54 Offset: 0x176DA54 VA: 0x6CF67C4A54
	public static uint Abs(int a) { }

	// RVA: 0x6CF67C6FD0 Offset: 0x176FFD0 VA: 0x6CF67C6FD0
	public static uint CombineHash(uint u1, uint u2) { }

	// RVA: 0x6CF67C3D68 Offset: 0x176CD68 VA: 0x6CF67C3D68
	public static int CombineHash(int n1, int n2) { }

}

// Dll : System.Numerics.dll
// Namespace: 
internal struct NumberBuffer
{
	// Fields

	public int precision; // 0x10
	public int scale; // 0x14
	public bool sign; // 0x18
	public Char* overrideDigits; // 0x20

	// Properties

	public Char* digits { get; }

	// Methods

	// RVA: 0x6CF67CA734 Offset: 0x1773734 VA: 0x6CF67CA734
	public Char* get_digits() { }

}

// Dll : System.Numerics.dll
// Namespace: 
private class Number : Object
{
	// Fields

	private static String[] s_posCurrencyFormats; // 0x0
	private static String[] s_negCurrencyFormats; // 0x8
	private static String[] s_posPercentFormats; // 0x10
	private static String[] s_negPercentFormats; // 0x18
	private static String[] s_negNumberFormats; // 0x20
	private static string s_posNumberFormat; // 0x28

	// Properties


	// Methods

	// RVA: 0x6CF67C870C Offset: 0x177170C VA: 0x6CF67C870C
	internal static void Int32ToDecChars(Char* buffer, ref int index, uint value, int digits) { }

	// RVA: 0x6CF67C6FD8 Offset: 0x176FFD8 VA: 0x6CF67C6FD8
	internal static char ParseFormatSpecifier(ReadOnlySpan`1 format, ref int digits) { }

	// RVA: 0x6CF67C711C Offset: 0x177011C VA: 0x6CF67C711C
	internal static void NumberToString(ref ValueStringBuilder sb, ref NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

	// RVA: 0x6CF67C8838 Offset: 0x1771838 VA: 0x6CF67C8838
	private static void FormatCurrency(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x6CF67C9A10 Offset: 0x1772A10 VA: 0x6CF67C9A10
	private static int wcslen(Char* s) { }

	// RVA: 0x6CF67C8A98 Offset: 0x1771A98 VA: 0x6CF67C8A98
	private static void FormatFixed(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Int32[] groupDigits, string sDecimal, string sGroup) { }

	// RVA: 0x6CF67C8FA4 Offset: 0x1771FA4 VA: 0x6CF67C8FA4
	private static void FormatNumber(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x6CF67C91EC Offset: 0x17721EC VA: 0x6CF67C91EC
	private static void FormatScientific(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

	// RVA: 0x6CF67C9C38 Offset: 0x1772C38 VA: 0x6CF67C9C38
	private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

	// RVA: 0x6CF67C9428 Offset: 0x1772428 VA: 0x6CF67C9428
	private static void FormatGeneral(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

	// RVA: 0x6CF67C97B0 Offset: 0x17727B0 VA: 0x6CF67C97B0
	private static void FormatPercent(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x6CF67C8768 Offset: 0x1771768 VA: 0x6CF67C8768
	private static void RoundNumber(ref NumberBuffer number, int pos) { }

	// RVA: 0x6CF67C9F28 Offset: 0x1772F28 VA: 0x6CF67C9F28
	private static int FindSection(ReadOnlySpan`1 format, int section) { }

	// RVA: 0x6CF67C7674 Offset: 0x1770674 VA: 0x6CF67C7674
	internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref NumberBuffer number, ReadOnlySpan`1 format, NumberFormatInfo info) { }

	// RVA: 0x6CF67CA074 Offset: 0x1773074 VA: 0x6CF67CA074
	private static void .cctor() { }

}

// Dll : System.Numerics.dll
// Namespace: System.Globalization
internal class FormatProvider : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF67C6E98 Offset: 0x176FE98 VA: 0x6CF67C6E98
	internal static void FormatBigInteger(ref ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan`1 format, NumberFormatInfo numberFormatInfo, Char[] digits, int startIndex) { }

}

// Dll : System.Numerics.dll
// Namespace: System.Text
internal struct ValueStringBuilder
{
	// Fields

	private Char[] _arrayToReturnToPool; // 0x10
	private Span`1 _chars; // 0x18
	private int _pos; // 0x28

	// Properties

	public int Length { get; }

	// Methods

	// RVA: 0x6CF67C6120 Offset: 0x176F120 VA: 0x6CF67C6120
	public void .ctor(Span`1 initialBuffer) { }

	// RVA: 0x6CF67CA73C Offset: 0x177373C VA: 0x6CF67CA73C
	public int get_Length() { }

	// RVA: 0x6CF67C63DC Offset: 0x176F3DC VA: 0x6CF67C63DC
	public override string ToString() { }

	// RVA: 0x6CF67C62F4 Offset: 0x176F2F4 VA: 0x6CF67C62F4
	public bool TryCopyTo(Span`1 destination, ref int charsWritten) { }

	// RVA: 0x6CF67C6130 Offset: 0x176F130 VA: 0x6CF67C6130
	public void Insert(int index, char value, int count) { }

	// RVA: 0x6CF67CA988 Offset: 0x1773988 VA: 0x6CF67CA988
	public void Append(char c) { }

	// RVA: 0x6CF67CAA84 Offset: 0x1773A84 VA: 0x6CF67CAA84
	public void Append(string s) { }

	// RVA: 0x6CF67CAB30 Offset: 0x1773B30 VA: 0x6CF67CAB30
	private void AppendSlow(string s) { }

	// RVA: 0x6CF67C9B10 Offset: 0x1772B10 VA: 0x6CF67C9B10
	public void Append(char c, int count) { }

	// RVA: 0x6CF67C9A30 Offset: 0x1772A30 VA: 0x6CF67C9A30
	public void Append(Char* value, int length) { }

	// RVA: 0x6CF67CAC5C Offset: 0x1773C5C VA: 0x6CF67CAC5C
	public Span`1 AppendSpan(int length) { }

	// RVA: 0x6CF67CAA04 Offset: 0x1773A04 VA: 0x6CF67CAA04
	private void GrowAndAppend(char c) { }

	// RVA: 0x6CF67CA744 Offset: 0x1773744 VA: 0x6CF67CA744
	private void Grow(int requiredAdditionalCapacity) { }

	// RVA: 0x6CF67CAD18 Offset: 0x1773D18 VA: 0x6CF67CAD18
	public void Dispose() { }

}

// Dll : UnityEngine.UnityWebRequestModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.UnityWebRequestModule.dll
// Namespace: UnityEngineInternal
internal static class WebRequestUtils : Object
{
	// Fields

	private static Regex domainRegex; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF6B9ADB0 Offset: 0x1B43DB0 VA: 0x6CF6B9ADB0
	internal static string RedirectTo(string baseUri, string redirectUri) { }

	// RVA: 0x6CF6B9AE9C Offset: 0x1B43E9C VA: 0x6CF6B9AE9C
	internal static string MakeInitialUrl(string targetUrl, string localUrl) { }

	// RVA: 0x6CF6B9B20C Offset: 0x1B4420C VA: 0x6CF6B9B20C
	internal static string MakeUriString(Uri targetUri, string targetUrl, bool prependProtocol) { }

	// RVA: 0x6CF6B9B5E8 Offset: 0x1B445E8 VA: 0x6CF6B9B5E8
	private static string URLDecode(string encoded) { }

	// RVA: 0x6CF6B9B6F0 Offset: 0x1B446F0 VA: 0x6CF6B9B6F0
	private static void .cctor() { }

}

// Dll : UnityEngine.UnityWebRequestModule.dll
// Namespace: UnityEngine
public class WWWForm : Object
{
	// Fields

	private static Byte[] dDash; // 0x0
	private static Byte[] crlf; // 0x8
	private static Byte[] contentTypeHeader; // 0x10
	private static Byte[] dispositionHeader; // 0x18
	private static Byte[] endQuote; // 0x20
	private static Byte[] fileNameField; // 0x28
	private static Byte[] ampersand; // 0x30
	private static Byte[] equal; // 0x38

	// Properties

	internal static Encoding DefaultEncoding { get; }

	// Methods

	// RVA: 0x6CF6B9B780 Offset: 0x1B44780 VA: 0x6CF6B9B780
	internal static Encoding get_DefaultEncoding() { }

	// RVA: 0x6CF6B9B788 Offset: 0x1B44788 VA: 0x6CF6B9B788
	private static void .cctor() { }

}

// Dll : UnityEngine.UnityWebRequestModule.dll
// Namespace: UnityEngine
internal class WWWTranscoder : Object
{
	// Fields

	private static Byte[] ucHexChars; // 0x0
	private static Byte[] lcHexChars; // 0x8
	private static byte urlEscapeChar; // 0x10
	private static Byte[] urlSpace; // 0x18
	private static Byte[] dataSpace; // 0x20
	private static Byte[] urlForbidden; // 0x28
	private static byte qpEscapeChar; // 0x30
	private static Byte[] qpSpace; // 0x38
	private static Byte[] qpForbidden; // 0x40

	// Properties


	// Methods

	// RVA: 0x6CF6B9B9C0 Offset: 0x1B449C0 VA: 0x6CF6B9B9C0
	private static byte Hex2Byte(Byte[] b, int offset) { }

	// RVA: 0x6CF6B9B68C Offset: 0x1B4468C VA: 0x6CF6B9B68C
	public static Byte[] URLDecode(Byte[] toEncode) { }

	// RVA: 0x6CF6B9BD84 Offset: 0x1B44D84 VA: 0x6CF6B9BD84
	private static bool ByteSubArrayEquals(Byte[] array, int index, Byte[] comperand) { }

	// RVA: 0x6CF6B9BA6C Offset: 0x1B44A6C VA: 0x6CF6B9BA6C
	public static Byte[] Decode(Byte[] input, byte escapeChar, Byte[] space) { }

	// RVA: 0x6CF6B9BE14 Offset: 0x1B44E14 VA: 0x6CF6B9BE14
	private static void .cctor() { }

}

// Dll : UnityEngine.UnityWebRequestModule.dll
// Namespace: UnityEngine.Networking
public class CertificateHandler : Object
{
	// Fields

	internal IntPtr m_Ptr; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF6B9C038 Offset: 0x1B45038 VA: 0x6CF6B9C038
	private void Release() { }

	// RVA: 0x6CF6B9C074 Offset: 0x1B45074 VA: 0x6CF6B9C074
	protected virtual bool ValidateCertificate(Byte[] certificateData) { }

	// RVA: 0x6CF6B9C07C Offset: 0x1B4507C VA: 0x6CF6B9C07C
	internal bool ValidateCertificateNative(Byte[] certificateData) { }

	// RVA: 0x6CF6B9C088 Offset: 0x1B45088 VA: 0x6CF6B9C088
	public void Dispose() { }

}

// Dll : UnityEngine.UnityWebRequestModule.dll
// Namespace: UnityEngine.Networking
public class DownloadHandler : Object, IDisposable
{
	// Fields

	internal IntPtr m_Ptr; // 0x10

	// Properties

	public Byte[] data { get; }
	public string text { get; }

	// Methods

	// RVA: 0x6CF6B9C0E0 Offset: 0x1B450E0 VA: 0x6CF6B9C0E0
	private void Release() { }

	// RVA: 0x6CF6B9C11C Offset: 0x1B4511C VA: 0x6CF6B9C11C
	internal void .ctor() { }

	// RVA: 0x6CF6B9C124 Offset: 0x1B45124 VA: 0x6CF6B9C124
	protected override void Finalize() { }

	// RVA: 0x6CF6B9C1C0 Offset: 0x1B451C0 VA: 0x6CF6B9C1C0
	public virtual void Dispose() { }

	// RVA: 0x6CF6B9C218 Offset: 0x1B45218 VA: 0x6CF6B9C218
	public Byte[] get_data() { }

	// RVA: 0x6CF6B9C224 Offset: 0x1B45224 VA: 0x6CF6B9C224
	public string get_text() { }

	// RVA: 0x6CF6B9C230 Offset: 0x1B45230 VA: 0x6CF6B9C230
	protected virtual NativeArray`1 GetNativeData() { }

	// RVA: 0x6CF6B9C23C Offset: 0x1B4523C VA: 0x6CF6B9C23C
	protected virtual Byte[] GetData() { }

	// RVA: 0x6CF6B9C2C4 Offset: 0x1B452C4 VA: 0x6CF6B9C2C4
	protected virtual string GetText() { }

	// RVA: 0x6CF6B9C384 Offset: 0x1B45384 VA: 0x6CF6B9C384
	private Encoding GetTextEncoder() { }

	// RVA: 0x6CF6B9C5F4 Offset: 0x1B455F4 VA: 0x6CF6B9C5F4
	private string GetContentType() { }

	// RVA: 0x6CF6B9C630 Offset: 0x1B45630 VA: 0x6CF6B9C630
	protected virtual bool ReceiveData(Byte[] data, int dataLength) { }

	// RVA: 0x6CF6B9C638 Offset: 0x1B45638 VA: 0x6CF6B9C638
	protected virtual void ReceiveContentLengthHeader(ulong contentLength) { }

	// RVA: 0x6CF6B9C644 Offset: 0x1B45644 VA: 0x6CF6B9C644
	protected virtual void ReceiveContentLength(int contentLength) { }

	// RVA: 0x6CF6B9C648 Offset: 0x1B45648 VA: 0x6CF6B9C648
	protected virtual void CompleteContent() { }

	// RVA: 0x6CF6B9C64C Offset: 0x1B4564C VA: 0x6CF6B9C64C
	protected virtual float GetProgress() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	protected static T GetCheckedDownloader(UnityWebRequest www) { }

	// RVA: 0x6CF6B9C654 Offset: 0x1B45654 VA: 0x6CF6B9C654
	internal static Byte* InternalGetByteArray(DownloadHandler dh, ref int length) { }

	// RVA: 0x6CF6B9C240 Offset: 0x1B45240 VA: 0x6CF6B9C240
	internal static Byte[] InternalGetByteArray(DownloadHandler dh) { }

	// RVA: 0x6CF6B9C698 Offset: 0x1B45698 VA: 0x6CF6B9C698
	internal static NativeArray`1 InternalGetNativeArray(DownloadHandler dh, ref NativeArray`1 nativeArray) { }

	// RVA: 0x6CF6B9C770 Offset: 0x1B45770 VA: 0x6CF6B9C770
	internal static void DisposeNativeArray(ref NativeArray`1 data) { }

	// RVA: 0x6CF6B9C7B4 Offset: 0x1B457B4 VA: 0x6CF6B9C7B4
	internal static void CreateNativeArrayForNativeData(ref NativeArray`1 data, Byte* bytes, int length) { }

}

// Dll : UnityEngine.UnityWebRequestModule.dll
// Namespace: UnityEngine.Networking
public sealed class DownloadHandlerBuffer : DownloadHandler
{
	// Fields

	private NativeArray`1 m_NativeData; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF6B9C81C Offset: 0x1B4581C VA: 0x6CF6B9C81C
	private static IntPtr Create(DownloadHandlerBuffer obj) { }

	// RVA: 0x6CF6B9C858 Offset: 0x1B45858 VA: 0x6CF6B9C858
	private void InternalCreateBuffer() { }

	// RVA: 0x6CF6B9C89C Offset: 0x1B4589C VA: 0x6CF6B9C89C
	public void .ctor() { }

	// RVA: 0x6CF6B9C8E8 Offset: 0x1B458E8 VA: 0x6CF6B9C8E8
	protected override NativeArray`1 GetNativeData() { }

	// RVA: 0x6CF6B9C8F0 Offset: 0x1B458F0 VA: 0x6CF6B9C8F0
	public override void Dispose() { }

}

// Dll : UnityEngine.UnityWebRequestModule.dll
// Namespace: UnityEngine.Networking
public class UnityWebRequestAsyncOperation : AsyncOperation
{
	// Fields

	private UnityWebRequest <webRequest>k__BackingField; // 0x20

	// Properties

	internal UnityWebRequest webRequest { set; }

	// Methods

	// RVA: 0x6CF6B9C93C Offset: 0x1B4593C VA: 0x6CF6B9C93C
	internal void set_webRequest(UnityWebRequest value) { }

	// RVA: 0x6CF6B9C944 Offset: 0x1B45944 VA: 0x6CF6B9C944
	public void .ctor() { }

}

// Dll : UnityEngine.UnityWebRequestModule.dll
// Namespace: 
internal enum UnityWebRequestMethod
{
	// Fields

	public int value__; // 0x10
	public const UnityWebRequestMethod Get = 0; // 0x0
	public const UnityWebRequestMethod Post = 1; // 0x0
	public const UnityWebRequestMethod Put = 2; // 0x0
	public const UnityWebRequestMethod Head = 3; // 0x0
	public const UnityWebRequestMethod Custom = 4; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.UnityWebRequestModule.dll
// Namespace: 
internal enum UnityWebRequestError
{
	// Fields

	public int value__; // 0x10
	public const UnityWebRequestError OK = 0; // 0x0
	public const UnityWebRequestError OKCached = 1; // 0x0
	public const UnityWebRequestError Unknown = 2; // 0x0
	public const UnityWebRequestError SDKError = 3; // 0x0
	public const UnityWebRequestError UnsupportedProtocol = 4; // 0x0
	public const UnityWebRequestError MalformattedUrl = 5; // 0x0
	public const UnityWebRequestError CannotResolveProxy = 6; // 0x0
	public const UnityWebRequestError CannotResolveHost = 7; // 0x0
	public const UnityWebRequestError CannotConnectToHost = 8; // 0x0
	public const UnityWebRequestError AccessDenied = 9; // 0x0
	public const UnityWebRequestError GenericHttpError = 10; // 0x0
	public const UnityWebRequestError WriteError = 11; // 0x0
	public const UnityWebRequestError ReadError = 12; // 0x0
	public const UnityWebRequestError OutOfMemory = 13; // 0x0
	public const UnityWebRequestError Timeout = 14; // 0x0
	public const UnityWebRequestError HTTPPostError = 15; // 0x0
	public const UnityWebRequestError SSLCannotConnect = 16; // 0x0
	public const UnityWebRequestError Aborted = 17; // 0x0
	public const UnityWebRequestError TooManyRedirects = 18; // 0x0
	public const UnityWebRequestError ReceivedNoData = 19; // 0x0
	public const UnityWebRequestError SSLNotSupported = 20; // 0x0
	public const UnityWebRequestError FailedToSendData = 21; // 0x0
	public const UnityWebRequestError FailedToReceiveData = 22; // 0x0
	public const UnityWebRequestError SSLCertificateError = 23; // 0x0
	public const UnityWebRequestError SSLCipherNotAvailable = 24; // 0x0
	public const UnityWebRequestError SSLCACertError = 25; // 0x0
	public const UnityWebRequestError UnrecognizedContentEncoding = 26; // 0x0
	public const UnityWebRequestError LoginFailed = 27; // 0x0
	public const UnityWebRequestError SSLShutdownFailed = 28; // 0x0
	public const UnityWebRequestError RedirectLimitInvalid = 29; // 0x0
	public const UnityWebRequestError InvalidRedirect = 30; // 0x0
	public const UnityWebRequestError CannotModifyRequest = 31; // 0x0
	public const UnityWebRequestError HeaderNameContainsInvalidCharacters = 32; // 0x0
	public const UnityWebRequestError HeaderValueContainsInvalidCharacters = 33; // 0x0
	public const UnityWebRequestError CannotOverrideSystemHeaders = 34; // 0x0
	public const UnityWebRequestError AlreadySent = 35; // 0x0
	public const UnityWebRequestError InvalidMethod = 36; // 0x0
	public const UnityWebRequestError NotImplemented = 37; // 0x0
	public const UnityWebRequestError NoInternetConnection = 38; // 0x0
	public const UnityWebRequestError DataProcessingError = 39; // 0x0
	public const UnityWebRequestError InsecureConnectionNotAllowed = 40; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.UnityWebRequestModule.dll
// Namespace: 
public enum Result
{
	// Fields

	public int value__; // 0x10
	public const Result InProgress = 0; // 0x0
	public const Result Success = 1; // 0x0
	public const Result ConnectionError = 2; // 0x0
	public const Result ProtocolError = 3; // 0x0
	public const Result DataProcessingError = 4; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.UnityWebRequestModule.dll
// Namespace: UnityEngine.Networking
public class UnityWebRequest : Object, IDisposable
{
	// Fields

	internal IntPtr m_Ptr; // 0x10
	internal DownloadHandler m_DownloadHandler; // 0x18
	internal UploadHandler m_UploadHandler; // 0x20
	internal CertificateHandler m_CertificateHandler; // 0x28
	internal Uri m_Uri; // 0x30
	private bool <disposeCertificateHandlerOnDispose>k__BackingField; // 0x38
	private bool <disposeDownloadHandlerOnDispose>k__BackingField; // 0x39
	private bool <disposeUploadHandlerOnDispose>k__BackingField; // 0x3A

	// Properties

	public bool disposeCertificateHandlerOnDispose { get; set; }
	public bool disposeDownloadHandlerOnDispose { get; set; }
	public bool disposeUploadHandlerOnDispose { get; set; }
	public string method { set; }
	public string error { get; }
	public string url { get; set; }
	public long responseCode { get; }
	public bool isModifiable { get; }
	public bool isDone { get; }
	public Result result { get; }
	public UploadHandler uploadHandler { get; set; }
	public DownloadHandler downloadHandler { get; set; }
	public CertificateHandler certificateHandler { get; }

	// Methods

	// RVA: 0x6CF6B9C94C Offset: 0x1B4594C VA: 0x6CF6B9C94C
	private static string GetWebErrorString(UnityWebRequestError err) { }

	// RVA: 0x6CF6B9C988 Offset: 0x1B45988 VA: 0x6CF6B9C988
	internal static string GetHTTPStatusString(long responseCode) { }

	// RVA: 0x6CF6B9C9C4 Offset: 0x1B459C4 VA: 0x6CF6B9C9C4
	public bool get_disposeCertificateHandlerOnDispose() { }

	// RVA: 0x6CF6B9C9CC Offset: 0x1B459CC VA: 0x6CF6B9C9CC
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	// RVA: 0x6CF6B9C9D8 Offset: 0x1B459D8 VA: 0x6CF6B9C9D8
	public bool get_disposeDownloadHandlerOnDispose() { }

	// RVA: 0x6CF6B9C9E0 Offset: 0x1B459E0 VA: 0x6CF6B9C9E0
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	// RVA: 0x6CF6B9C9EC Offset: 0x1B459EC VA: 0x6CF6B9C9EC
	public bool get_disposeUploadHandlerOnDispose() { }

	// RVA: 0x6CF6B9C9F4 Offset: 0x1B459F4 VA: 0x6CF6B9C9F4
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	// RVA: 0x6CF6B9CA00 Offset: 0x1B45A00 VA: 0x6CF6B9CA00
	internal static IntPtr Create() { }

	// RVA: 0x6CF6B9CA28 Offset: 0x1B45A28 VA: 0x6CF6B9CA28
	private void Release() { }

	// RVA: 0x6CF6B9CA64 Offset: 0x1B45A64 VA: 0x6CF6B9CA64
	internal void InternalDestroy() { }

	// RVA: 0x6CF6B9CB20 Offset: 0x1B45B20 VA: 0x6CF6B9CB20
	private void InternalSetDefaults() { }

	// RVA: 0x6CF6B9CB34 Offset: 0x1B45B34 VA: 0x6CF6B9CB34
	public void .ctor(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	// RVA: 0x6CF6B9CFE8 Offset: 0x1B45FE8 VA: 0x6CF6B9CFE8
	protected override void Finalize() { }

	// RVA: 0x6CF6B9D0E4 Offset: 0x1B460E4 VA: 0x6CF6B9D0E4
	public void Dispose() { }

	// RVA: 0x6CF6B9D084 Offset: 0x1B46084 VA: 0x6CF6B9D084
	private void DisposeHandlers() { }

	// RVA: 0x6CF6B9D164 Offset: 0x1B46164 VA: 0x6CF6B9D164
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	// RVA: 0x6CF6B9D1A0 Offset: 0x1B461A0 VA: 0x6CF6B9D1A0
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	// RVA: 0x6CF6B9CAE4 Offset: 0x1B45AE4 VA: 0x6CF6B9CAE4
	public void Abort() { }

	// RVA: 0x6CF6B9D1E8 Offset: 0x1B461E8 VA: 0x6CF6B9D1E8
	private UnityWebRequestError SetMethod(UnityWebRequestMethod methodType) { }

	// RVA: 0x6CF6B9D22C Offset: 0x1B4622C VA: 0x6CF6B9D22C
	internal void InternalSetMethod(UnityWebRequestMethod methodType) { }

	// RVA: 0x6CF6B9D368 Offset: 0x1B46368 VA: 0x6CF6B9D368
	private UnityWebRequestError SetCustomMethod(string customMethodName) { }

	// RVA: 0x6CF6B9D3AC Offset: 0x1B463AC VA: 0x6CF6B9D3AC
	internal void InternalSetCustomMethod(string customMethodName) { }

	// RVA: 0x6CF6B9CC60 Offset: 0x1B45C60 VA: 0x6CF6B9CC60
	public void set_method(string value) { }

	// RVA: 0x6CF6B9D4AC Offset: 0x1B464AC VA: 0x6CF6B9D4AC
	private UnityWebRequestError GetError() { }

	// RVA: 0x6CF6B9D4E8 Offset: 0x1B464E8 VA: 0x6CF6B9D4E8
	public string get_error() { }

	// RVA: 0x6CF6B9D704 Offset: 0x1B46704 VA: 0x6CF6B9D704
	public string get_url() { }

	// RVA: 0x6CF6B9CBD8 Offset: 0x1B45BD8 VA: 0x6CF6B9CBD8
	public void set_url(string value) { }

	// RVA: 0x6CF6B9D740 Offset: 0x1B46740 VA: 0x6CF6B9D740
	private string GetUrl() { }

	// RVA: 0x6CF6B9D87C Offset: 0x1B4687C VA: 0x6CF6B9D87C
	private UnityWebRequestError SetUrl(string url) { }

	// RVA: 0x6CF6B9D77C Offset: 0x1B4677C VA: 0x6CF6B9D77C
	private void InternalSetUrl(string url) { }

	// RVA: 0x6CF6B9D6C8 Offset: 0x1B466C8 VA: 0x6CF6B9D6C8
	public long get_responseCode() { }

	// RVA: 0x6CF6B9D32C Offset: 0x1B4632C VA: 0x6CF6B9D32C
	public bool get_isModifiable() { }

	// RVA: 0x6CF6B9D8C0 Offset: 0x1B468C0 VA: 0x6CF6B9D8C0
	public bool get_isDone() { }

	// RVA: 0x6CF6B9D68C Offset: 0x1B4668C VA: 0x6CF6B9D68C
	public Result get_result() { }

	// RVA: 0x6CF6B9D908 Offset: 0x1B46908 VA: 0x6CF6B9D908
	private UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	// RVA: 0x6CF6B9D154 Offset: 0x1B46154 VA: 0x6CF6B9D154
	public UploadHandler get_uploadHandler() { }

	// RVA: 0x6CF6B9CEE4 Offset: 0x1B45EE4 VA: 0x6CF6B9CEE4
	public void set_uploadHandler(UploadHandler value) { }

	// RVA: 0x6CF6B9D94C Offset: 0x1B4694C VA: 0x6CF6B9D94C
	private UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	// RVA: 0x6CF6B9D14C Offset: 0x1B4614C VA: 0x6CF6B9D14C
	public DownloadHandler get_downloadHandler() { }

	// RVA: 0x6CF6B9CDE0 Offset: 0x1B45DE0 VA: 0x6CF6B9CDE0
	public void set_downloadHandler(DownloadHandler value) { }

	// RVA: 0x6CF6B9D15C Offset: 0x1B4615C VA: 0x6CF6B9D15C
	public CertificateHandler get_certificateHandler() { }

	// RVA: 0x6CF6B9D990 Offset: 0x1B46990 VA: 0x6CF6B9D990
	public static UnityWebRequest Get(string uri) { }

}

// Dll : UnityEngine.UnityWebRequestModule.dll
// Namespace: UnityEngine.Networking
public class UploadHandler : Object
{
	// Fields

	internal IntPtr m_Ptr; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF6B9DA34 Offset: 0x1B46A34 VA: 0x6CF6B9DA34
	private void Release() { }

	// RVA: 0x6CF6B9DA70 Offset: 0x1B46A70 VA: 0x6CF6B9DA70
	public virtual void Dispose() { }

}

// Dll : UnityEngine.UIModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.UIModule.dll
// Namespace: UnityEngine
public interface ICanvasRaycastFilter
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public abstract bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

}

// Dll : UnityEngine.UIModule.dll
// Namespace: UnityEngine
public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter
{
	// Fields


	// Properties

	public float alpha { get; set; }
	public bool interactable { get; set; }
	public bool blocksRaycasts { get; set; }
	public bool ignoreParentGroups { get; set; }

	// Methods

	// RVA: 0x6CF6B62544 Offset: 0x1B0B544 VA: 0x6CF6B62544
	public float get_alpha() { }

	// RVA: 0x6CF6B62580 Offset: 0x1B0B580 VA: 0x6CF6B62580
	public void set_alpha(float value) { }

	// RVA: 0x6CF6B625CC Offset: 0x1B0B5CC VA: 0x6CF6B625CC
	public bool get_interactable() { }

	// RVA: 0x6CF6B62608 Offset: 0x1B0B608 VA: 0x6CF6B62608
	public void set_interactable(bool value) { }

	// RVA: 0x6CF6B6264C Offset: 0x1B0B64C VA: 0x6CF6B6264C
	public bool get_blocksRaycasts() { }

	// RVA: 0x6CF6B62688 Offset: 0x1B0B688 VA: 0x6CF6B62688
	public void set_blocksRaycasts(bool value) { }

	// RVA: 0x6CF6B626CC Offset: 0x1B0B6CC VA: 0x6CF6B626CC
	public bool get_ignoreParentGroups() { }

	// RVA: 0x6CF6B62708 Offset: 0x1B0B708 VA: 0x6CF6B62708
	public void set_ignoreParentGroups(bool value) { }

	// RVA: 0x6CF6B6274C Offset: 0x1B0B74C VA: 0x6CF6B6274C
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

}

// Dll : UnityEngine.UIModule.dll
// Namespace: UnityEngine
public sealed class CanvasRenderer : Component
{
	// Fields

	private bool <isMask>k__BackingField; // 0x18

	// Properties

	public bool hasPopInstruction { set; }
	public int materialCount { get; set; }
	public int popMaterialCount { set; }
	public int absoluteDepth { get; }
	public bool hasMoved { get; }
	public bool cull { get; set; }
	public Vector2 clippingSoftness { set; }

	// Methods

	// RVA: 0x6CF6B62788 Offset: 0x1B0B788 VA: 0x6CF6B62788
	public void set_hasPopInstruction(bool value) { }

	// RVA: 0x6CF6B627CC Offset: 0x1B0B7CC VA: 0x6CF6B627CC
	public int get_materialCount() { }

	// RVA: 0x6CF6B62808 Offset: 0x1B0B808 VA: 0x6CF6B62808
	public void set_materialCount(int value) { }

	// RVA: 0x6CF6B6284C Offset: 0x1B0B84C VA: 0x6CF6B6284C
	public void set_popMaterialCount(int value) { }

	// RVA: 0x6CF6B62890 Offset: 0x1B0B890 VA: 0x6CF6B62890
	public int get_absoluteDepth() { }

	// RVA: 0x6CF6B628CC Offset: 0x1B0B8CC VA: 0x6CF6B628CC
	public bool get_hasMoved() { }

	// RVA: 0x6CF6B62908 Offset: 0x1B0B908 VA: 0x6CF6B62908
	public bool get_cull() { }

	// RVA: 0x6CF6B62944 Offset: 0x1B0B944 VA: 0x6CF6B62944
	public void set_cull(bool value) { }

	// RVA: 0x6CF6B62988 Offset: 0x1B0B988 VA: 0x6CF6B62988
	public void SetColor(Color color) { }

	// RVA: 0x6CF6B62A20 Offset: 0x1B0BA20 VA: 0x6CF6B62A20
	public Color GetColor() { }

	// RVA: 0x6CF6B62ABC Offset: 0x1B0BABC VA: 0x6CF6B62ABC
	public void EnableRectClipping(Rect rect) { }

	// RVA: 0x6CF6B62B54 Offset: 0x1B0BB54 VA: 0x6CF6B62B54
	public void set_clippingSoftness(Vector2 value) { }

	// RVA: 0x6CF6B62BE0 Offset: 0x1B0BBE0 VA: 0x6CF6B62BE0
	public void DisableRectClipping() { }

	// RVA: 0x6CF6B62C1C Offset: 0x1B0BC1C VA: 0x6CF6B62C1C
	public void SetMaterial(Material material, int index) { }

	// RVA: 0x6CF6B62C70 Offset: 0x1B0BC70 VA: 0x6CF6B62C70
	public void SetPopMaterial(Material material, int index) { }

	// RVA: 0x6CF6B62CC4 Offset: 0x1B0BCC4 VA: 0x6CF6B62CC4
	public void SetTexture(Texture texture) { }

	// RVA: 0x6CF6B62D08 Offset: 0x1B0BD08 VA: 0x6CF6B62D08
	public void SetAlphaTexture(Texture texture) { }

	// RVA: 0x6CF6B62D4C Offset: 0x1B0BD4C VA: 0x6CF6B62D4C
	public void SetMesh(Mesh mesh) { }

	// RVA: 0x6CF6B62D90 Offset: 0x1B0BD90 VA: 0x6CF6B62D90
	public void Clear() { }

	// RVA: 0x6CF6B62DCC Offset: 0x1B0BDCC VA: 0x6CF6B62DCC
	public void SetAlpha(float alpha) { }

	// RVA: 0x6CF6B62DF4 Offset: 0x1B0BDF4 VA: 0x6CF6B62DF4
	public void SetMaterial(Material material, Texture texture) { }

	// RVA: 0x6CF6B62F1C Offset: 0x1B0BF1C VA: 0x6CF6B62F1C
	public static void SplitUIVertexStreams(List`1 verts, List`1 positions, List`1 colors, List`1 uv0S, List`1 uv1S, List`1 uv2S, List`1 uv3S, List`1 normals, List`1 tangents, List`1 indices) { }

	// RVA: 0x6CF6B630CC Offset: 0x1B0C0CC VA: 0x6CF6B630CC
	public static void CreateUIVertexStream(List`1 verts, List`1 positions, List`1 colors, List`1 uv0S, List`1 uv1S, List`1 uv2S, List`1 uv3S, List`1 normals, List`1 tangents, List`1 indices) { }

	// RVA: 0x6CF6B63204 Offset: 0x1B0C204 VA: 0x6CF6B63204
	public static void AddUIVertexStream(List`1 verts, List`1 positions, List`1 colors, List`1 uv0S, List`1 uv1S, List`1 uv2S, List`1 uv3S, List`1 normals, List`1 tangents) { }

	// RVA: 0x6CF6B63088 Offset: 0x1B0C088 VA: 0x6CF6B63088
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	// RVA: 0x6CF6B62FEC Offset: 0x1B0BFEC VA: 0x6CF6B62FEC
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

	// RVA: 0x6CF6B63168 Offset: 0x1B0C168 VA: 0x6CF6B63168
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	// RVA: 0x6CF6B629DC Offset: 0x1B0B9DC VA: 0x6CF6B629DC
	private void SetColor_Injected(ref Color color) { }

	// RVA: 0x6CF6B62A78 Offset: 0x1B0BA78 VA: 0x6CF6B62A78
	private void GetColor_Injected(ref Color ret) { }

	// RVA: 0x6CF6B62B10 Offset: 0x1B0BB10 VA: 0x6CF6B62B10
	private void EnableRectClipping_Injected(ref Rect rect) { }

	// RVA: 0x6CF6B62B9C Offset: 0x1B0BB9C VA: 0x6CF6B62B9C
	private void set_clippingSoftness_Injected(ref Vector2 value) { }

}

// Dll : UnityEngine.UIModule.dll
// Namespace: UnityEngine
public sealed class RectTransformUtility : Object
{
	// Fields

	private static readonly Vector3[] s_Corners; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF6B632A0 Offset: 0x1B0C2A0 VA: 0x6CF6B632A0
	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { }

	// RVA: 0x6CF6B633A0 Offset: 0x1B0C3A0 VA: 0x6CF6B633A0
	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { }

	// RVA: 0x6CF6B63494 Offset: 0x1B0C494 VA: 0x6CF6B63494
	private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset) { }

	// RVA: 0x6CF6B63598 Offset: 0x1B0C598 VA: 0x6CF6B63598
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) { }

	// RVA: 0x6CF6B6366C Offset: 0x1B0C66C VA: 0x6CF6B6366C
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset) { }

	// RVA: 0x6CF6B63718 Offset: 0x1B0C718 VA: 0x6CF6B63718
	public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, ref Vector3 worldPoint) { }

	// RVA: 0x6CF6B63CF4 Offset: 0x1B0CCF4 VA: 0x6CF6B63CF4
	public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, ref Vector2 localPoint) { }

	// RVA: 0x6CF6B63B3C Offset: 0x1B0CB3C VA: 0x6CF6B63B3C
	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { }

	// RVA: 0x6CF6B63DF0 Offset: 0x1B0CDF0 VA: 0x6CF6B63DF0
	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { }

	// RVA: 0x6CF6B63EA0 Offset: 0x1B0CEA0 VA: 0x6CF6B63EA0
	public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) { }

	// RVA: 0x6CF6B64160 Offset: 0x1B0D160 VA: 0x6CF6B64160
	public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) { }

	// RVA: 0x6CF6B643B8 Offset: 0x1B0D3B8 VA: 0x6CF6B643B8
	private static Vector2 GetTransposed(Vector2 input) { }

	// RVA: 0x6CF6B643C8 Offset: 0x1B0D3C8 VA: 0x6CF6B643C8
	private static void .cctor() { }

	// RVA: 0x6CF6B63344 Offset: 0x1B0C344 VA: 0x6CF6B63344
	private static void PixelAdjustPoint_Injected(ref Vector2 point, Transform elementTransform, Canvas canvas, ref Vector2 ret) { }

	// RVA: 0x6CF6B63440 Offset: 0x1B0C440 VA: 0x6CF6B63440
	private static void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, ref Rect ret) { }

	// RVA: 0x6CF6B6353C Offset: 0x1B0C53C VA: 0x6CF6B6353C
	private static bool PointInRectangle_Injected(ref Vector2 screenPoint, RectTransform rect, Camera cam, ref Vector4 offset) { }

}

// Dll : UnityEngine.UIModule.dll
// Namespace: UnityEngine
public enum RenderMode
{
	// Fields

	public int value__; // 0x10
	public const RenderMode ScreenSpaceOverlay = 0; // 0x0
	public const RenderMode ScreenSpaceCamera = 1; // 0x0
	public const RenderMode WorldSpace = 2; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.UIModule.dll
// Namespace: 
public sealed class WillRenderCanvases : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6B65174 Offset: 0x1B0E174 VA: 0x6CF6B65174
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF6B651FC Offset: 0x1B0E1FC VA: 0x6CF6B651FC
	public virtual void Invoke() { }

}

// Dll : UnityEngine.UIModule.dll
// Namespace: UnityEngine
public sealed class Canvas : Behaviour
{
	// Fields

	private static WillRenderCanvases preWillRenderCanvases; // 0x0
	private static WillRenderCanvases willRenderCanvases; // 0x8
	private static Action`1 <externBeginRenderOverlays>k__BackingField; // 0x10
	private static Action`2 <externRenderOverlaysBefore>k__BackingField; // 0x18
	private static Action`1 <externEndRenderOverlays>k__BackingField; // 0x20

	// Properties

	public RenderMode renderMode { get; set; }
	public bool isRootCanvas { get; }
	public Rect pixelRect { get; }
	public float scaleFactor { get; set; }
	public float referencePixelsPerUnit { get; set; }
	public bool pixelPerfect { get; set; }
	public int renderOrder { get; }
	public bool overrideSorting { get; set; }
	public int sortingOrder { get; set; }
	public int targetDisplay { get; }
	public int sortingLayerID { get; set; }
	public Canvas rootCanvas { get; }
	public Vector2 renderingDisplaySize { get; }
	internal static Action`1 externBeginRenderOverlays { get; set; }
	internal static Action`2 externRenderOverlaysBefore { get; set; }
	internal static Action`1 externEndRenderOverlays { get; set; }
	public Camera worldCamera { get; }

	// Methods

	// RVA: 0x6CF6B64430 Offset: 0x1B0D430 VA: 0x6CF6B64430
	public static void add_preWillRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x6CF6B644E8 Offset: 0x1B0D4E8 VA: 0x6CF6B644E8
	public static void remove_preWillRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x6CF6B645A0 Offset: 0x1B0D5A0 VA: 0x6CF6B645A0
	public static void add_willRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x6CF6B6465C Offset: 0x1B0D65C VA: 0x6CF6B6465C
	public static void remove_willRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x6CF6B64718 Offset: 0x1B0D718 VA: 0x6CF6B64718
	public RenderMode get_renderMode() { }

	// RVA: 0x6CF6B64754 Offset: 0x1B0D754 VA: 0x6CF6B64754
	public void set_renderMode(RenderMode value) { }

	// RVA: 0x6CF6B64798 Offset: 0x1B0D798 VA: 0x6CF6B64798
	public bool get_isRootCanvas() { }

	// RVA: 0x6CF6B647D4 Offset: 0x1B0D7D4 VA: 0x6CF6B647D4
	public Rect get_pixelRect() { }

	// RVA: 0x6CF6B64870 Offset: 0x1B0D870 VA: 0x6CF6B64870
	public float get_scaleFactor() { }

	// RVA: 0x6CF6B648AC Offset: 0x1B0D8AC VA: 0x6CF6B648AC
	public void set_scaleFactor(float value) { }

	// RVA: 0x6CF6B648F8 Offset: 0x1B0D8F8 VA: 0x6CF6B648F8
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x6CF6B64934 Offset: 0x1B0D934 VA: 0x6CF6B64934
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x6CF6B64980 Offset: 0x1B0D980 VA: 0x6CF6B64980
	public bool get_pixelPerfect() { }

	// RVA: 0x6CF6B649BC Offset: 0x1B0D9BC VA: 0x6CF6B649BC
	public void set_pixelPerfect(bool value) { }

	// RVA: 0x6CF6B64A00 Offset: 0x1B0DA00 VA: 0x6CF6B64A00
	public int get_renderOrder() { }

	// RVA: 0x6CF6B64A3C Offset: 0x1B0DA3C VA: 0x6CF6B64A3C
	public bool get_overrideSorting() { }

	// RVA: 0x6CF6B64A78 Offset: 0x1B0DA78 VA: 0x6CF6B64A78
	public void set_overrideSorting(bool value) { }

	// RVA: 0x6CF6B64ABC Offset: 0x1B0DABC VA: 0x6CF6B64ABC
	public int get_sortingOrder() { }

	// RVA: 0x6CF6B64AF8 Offset: 0x1B0DAF8 VA: 0x6CF6B64AF8
	public void set_sortingOrder(int value) { }

	// RVA: 0x6CF6B64B3C Offset: 0x1B0DB3C VA: 0x6CF6B64B3C
	public int get_targetDisplay() { }

	// RVA: 0x6CF6B64B78 Offset: 0x1B0DB78 VA: 0x6CF6B64B78
	public int get_sortingLayerID() { }

	// RVA: 0x6CF6B64BB4 Offset: 0x1B0DBB4 VA: 0x6CF6B64BB4
	public void set_sortingLayerID(int value) { }

	// RVA: 0x6CF6B64BF8 Offset: 0x1B0DBF8 VA: 0x6CF6B64BF8
	public Canvas get_rootCanvas() { }

	// RVA: 0x6CF6B64C34 Offset: 0x1B0DC34 VA: 0x6CF6B64C34
	public Vector2 get_renderingDisplaySize() { }

	// RVA: 0x6CF6B64CC4 Offset: 0x1B0DCC4 VA: 0x6CF6B64CC4
	internal static Action`1 get_externBeginRenderOverlays() { }

	// RVA: 0x6CF6B64D0C Offset: 0x1B0DD0C VA: 0x6CF6B64D0C
	internal static void set_externBeginRenderOverlays(Action`1 value) { }

	// RVA: 0x6CF6B64D58 Offset: 0x1B0DD58 VA: 0x6CF6B64D58
	internal static Action`2 get_externRenderOverlaysBefore() { }

	// RVA: 0x6CF6B64DA0 Offset: 0x1B0DDA0 VA: 0x6CF6B64DA0
	internal static void set_externRenderOverlaysBefore(Action`2 value) { }

	// RVA: 0x6CF6B64DEC Offset: 0x1B0DDEC VA: 0x6CF6B64DEC
	internal static Action`1 get_externEndRenderOverlays() { }

	// RVA: 0x6CF6B64E34 Offset: 0x1B0DE34 VA: 0x6CF6B64E34
	internal static void set_externEndRenderOverlays(Action`1 value) { }

	// RVA: 0x6CF6B64E80 Offset: 0x1B0DE80 VA: 0x6CF6B64E80
	internal static void SetExternalCanvasEnabled(bool enabled) { }

	// RVA: 0x6CF6B64EBC Offset: 0x1B0DEBC VA: 0x6CF6B64EBC
	public Camera get_worldCamera() { }

	// RVA: 0x6CF6B64EF8 Offset: 0x1B0DEF8 VA: 0x6CF6B64EF8
	public static Material GetDefaultCanvasMaterial() { }

	// RVA: 0x6CF6B64F20 Offset: 0x1B0DF20 VA: 0x6CF6B64F20
	public static Material GetETC1SupportedCanvasMaterial() { }

	// RVA: 0x6CF6B64F48 Offset: 0x1B0DF48 VA: 0x6CF6B64F48
	public static void ForceUpdateCanvases() { }

	// RVA: 0x6CF6B64F58 Offset: 0x1B0DF58 VA: 0x6CF6B64F58
	private static void SendPreWillRenderCanvases() { }

	// RVA: 0x6CF6B64FBC Offset: 0x1B0DFBC VA: 0x6CF6B64FBC
	private static void SendWillRenderCanvases() { }

	// RVA: 0x6CF6B65020 Offset: 0x1B0E020 VA: 0x6CF6B65020
	private static void BeginRenderExtraOverlays(int displayIndex) { }

	// RVA: 0x6CF6B6508C Offset: 0x1B0E08C VA: 0x6CF6B6508C
	private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder) { }

	// RVA: 0x6CF6B65100 Offset: 0x1B0E100 VA: 0x6CF6B65100
	private static void EndRenderExtraOverlays(int displayIndex) { }

	// RVA: 0x6CF6B6516C Offset: 0x1B0E16C VA: 0x6CF6B6516C
	public void .ctor() { }

	// RVA: 0x6CF6B6482C Offset: 0x1B0D82C VA: 0x6CF6B6482C
	private void get_pixelRect_Injected(ref Rect ret) { }

	// RVA: 0x6CF6B64C80 Offset: 0x1B0DC80 VA: 0x6CF6B64C80
	private void get_renderingDisplaySize_Injected(ref Vector2 ret) { }

}

// Dll : UnityEngine.UIModule.dll
// Namespace: 
public enum SampleType
{
	// Fields

	public int value__; // 0x10
	public const SampleType Layout = 0; // 0x0
	public const SampleType Render = 1; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.UIModule.dll
// Namespace: UnityEngine
public static class UISystemProfilerApi : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6B65210 Offset: 0x1B0E210 VA: 0x6CF6B65210
	public static void BeginSample(SampleType type) { }

	// RVA: 0x6CF6B6524C Offset: 0x1B0E24C VA: 0x6CF6B6524C
	public static void EndSample(SampleType type) { }

	// RVA: 0x6CF6B65288 Offset: 0x1B0E288 VA: 0x6CF6B65288
	public static void AddMarker(string name, object obj) { }

}

// Dll : UnityEngine.TextRenderingModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.TextRenderingModule.dll
// Namespace: UnityEngine
public enum FontStyle
{
	// Fields

	public int value__; // 0x10
	public const FontStyle Normal = 0; // 0x0
	public const FontStyle Bold = 1; // 0x0
	public const FontStyle Italic = 2; // 0x0
	public const FontStyle BoldAndItalic = 3; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.TextRenderingModule.dll
// Namespace: UnityEngine
internal enum TextGenerationError
{
	// Fields

	public int value__; // 0x10
	public const TextGenerationError None = 0; // 0x0
	public const TextGenerationError CustomSizeOnNonDynamicFont = 1; // 0x0
	public const TextGenerationError CustomStyleOnNonDynamicFont = 2; // 0x0
	public const TextGenerationError NoFont = 4; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.TextRenderingModule.dll
// Namespace: UnityEngine
public struct TextGenerationSettings
{
	// Fields

	public Font font; // 0x10
	public Color color; // 0x18
	public int fontSize; // 0x28
	public float lineSpacing; // 0x2C
	public bool richText; // 0x30
	public float scaleFactor; // 0x34
	public FontStyle fontStyle; // 0x38
	public TextAnchor textAnchor; // 0x3C
	public bool alignByGeometry; // 0x40
	public bool resizeTextForBestFit; // 0x41
	public int resizeTextMinSize; // 0x44
	public int resizeTextMaxSize; // 0x48
	public bool updateBounds; // 0x4C
	public VerticalWrapMode verticalOverflow; // 0x50
	public HorizontalWrapMode horizontalOverflow; // 0x54
	public Vector2 generationExtents; // 0x58
	public Vector2 pivot; // 0x60
	public bool generateOutOfBounds; // 0x68

	// Properties


	// Methods

	// RVA: 0x6CF6A0B4BC Offset: 0x19B44BC VA: 0x6CF6A0B4BC
	private bool CompareColors(Color left, Color right) { }

	// RVA: 0x6CF6A0B5F4 Offset: 0x19B45F4 VA: 0x6CF6A0B5F4
	private bool CompareVector2(Vector2 left, Vector2 right) { }

	// RVA: 0x6CF6A0B6BC Offset: 0x19B46BC VA: 0x6CF6A0B6BC
	public bool Equals(TextGenerationSettings other) { }

}

// Dll : UnityEngine.TextRenderingModule.dll
// Namespace: UnityEngine
public sealed class TextGenerator : Object, IDisposable
{
	// Fields

	internal IntPtr m_Ptr; // 0x10
	private string m_LastString; // 0x18
	private TextGenerationSettings m_LastSettings; // 0x20
	private bool m_HasGenerated; // 0x80
	private TextGenerationError m_LastValid; // 0x84
	private readonly List`1 m_Verts; // 0x88
	private readonly List`1 m_Characters; // 0x90
	private readonly List`1 m_Lines; // 0x98
	private bool m_CachedVerts; // 0xA0
	private bool m_CachedCharacters; // 0xA1
	private bool m_CachedLines; // 0xA2

	// Properties

	public int characterCountVisible { get; }
	public IList`1 verts { get; }
	public IList`1 characters { get; }
	public IList`1 lines { get; }
	public Rect rectExtents { get; }
	public int characterCount { get; }
	public int lineCount { get; }

	// Methods

	// RVA: 0x6CF6A0B8DC Offset: 0x19B48DC VA: 0x6CF6A0B8DC
	public void .ctor() { }

	// RVA: 0x6CF6A0B8E4 Offset: 0x19B48E4 VA: 0x6CF6A0B8E4
	public void .ctor(int initialCapacity) { }

	// RVA: 0x6CF6A0BA58 Offset: 0x19B4A58 VA: 0x6CF6A0BA58
	protected override void Finalize() { }

	// RVA: 0x6CF6A0BB68 Offset: 0x19B4B68 VA: 0x6CF6A0BB68
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF6A0BC00 Offset: 0x19B4C00 VA: 0x6CF6A0BC00
	public int get_characterCountVisible() { }

	// RVA: 0x6CF6A0BC80 Offset: 0x19B4C80 VA: 0x6CF6A0BC80
	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

	// RVA: 0x6CF6A0BF6C Offset: 0x19B4F6C VA: 0x6CF6A0BF6C
	public void Invalidate() { }

	// RVA: 0x6CF6A0BF74 Offset: 0x19B4F74 VA: 0x6CF6A0BF74
	public void GetCharacters(List`1 characters) { }

	// RVA: 0x6CF6A0BFFC Offset: 0x19B4FFC VA: 0x6CF6A0BFFC
	public void GetLines(List`1 lines) { }

	// RVA: 0x6CF6A0C084 Offset: 0x19B5084 VA: 0x6CF6A0C084
	public void GetVertices(List`1 vertices) { }

	// RVA: 0x6CF6A0C10C Offset: 0x19B510C VA: 0x6CF6A0C10C
	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	// RVA: 0x6CF6A0C218 Offset: 0x19B5218 VA: 0x6CF6A0C218
	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	// RVA: 0x6CF6A0C278 Offset: 0x19B5278 VA: 0x6CF6A0C278
	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	// RVA: 0x6CF6A0C170 Offset: 0x19B5170 VA: 0x6CF6A0C170
	public bool Populate(string str, TextGenerationSettings settings) { }

	// RVA: 0x6CF6A0C430 Offset: 0x19B5430 VA: 0x6CF6A0C430
	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	// RVA: 0x6CF6A0C4C0 Offset: 0x19B54C0 VA: 0x6CF6A0C4C0
	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	// RVA: 0x6CF6A0C770 Offset: 0x19B5770 VA: 0x6CF6A0C770
	public IList`1 get_verts() { }

	// RVA: 0x6CF6A0C7CC Offset: 0x19B57CC VA: 0x6CF6A0C7CC
	public IList`1 get_characters() { }

	// RVA: 0x6CF6A0C828 Offset: 0x19B5828 VA: 0x6CF6A0C828
	public IList`1 get_lines() { }

	// RVA: 0x6CF6A0C1C0 Offset: 0x19B51C0 VA: 0x6CF6A0C1C0
	public Rect get_rectExtents() { }

	// RVA: 0x6CF6A0BC44 Offset: 0x19B4C44 VA: 0x6CF6A0BC44
	public int get_characterCount() { }

	// RVA: 0x6CF6A0C8C8 Offset: 0x19B58C8 VA: 0x6CF6A0C8C8
	public int get_lineCount() { }

	// RVA: 0x6CF6A0BA30 Offset: 0x19B4A30 VA: 0x6CF6A0BA30
	private static IntPtr Internal_Create() { }

	// RVA: 0x6CF6A0BBC4 Offset: 0x19B4BC4 VA: 0x6CF6A0BBC4
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x6CF6A0C904 Offset: 0x19B5904 VA: 0x6CF6A0C904
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, ref uint error) { }

	// RVA: 0x6CF6A0C5C8 Offset: 0x19B55C8 VA: 0x6CF6A0C5C8
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, ref TextGenerationError error) { }

	// RVA: 0x6CF6A0C0C8 Offset: 0x19B50C8 VA: 0x6CF6A0C0C8
	private void GetVerticesInternal(object vertices) { }

	// RVA: 0x6CF6A0BFB8 Offset: 0x19B4FB8 VA: 0x6CF6A0BFB8
	private void GetCharactersInternal(object characters) { }

	// RVA: 0x6CF6A0C040 Offset: 0x19B5040 VA: 0x6CF6A0C040
	private void GetLinesInternal(object lines) { }

	// RVA: 0x6CF6A0C884 Offset: 0x19B5884 VA: 0x6CF6A0C884
	private void get_rectExtents_Injected(ref Rect ret) { }

	// RVA: 0x6CF6A0CA50 Offset: 0x19B5A50 VA: 0x6CF6A0CA50
	private bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, ref uint error) { }

}

// Dll : UnityEngine.TextRenderingModule.dll
// Namespace: UnityEngine
public enum TextAnchor
{
	// Fields

	public int value__; // 0x10
	public const TextAnchor UpperLeft = 0; // 0x0
	public const TextAnchor UpperCenter = 1; // 0x0
	public const TextAnchor UpperRight = 2; // 0x0
	public const TextAnchor MiddleLeft = 3; // 0x0
	public const TextAnchor MiddleCenter = 4; // 0x0
	public const TextAnchor MiddleRight = 5; // 0x0
	public const TextAnchor LowerLeft = 6; // 0x0
	public const TextAnchor LowerCenter = 7; // 0x0
	public const TextAnchor LowerRight = 8; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.TextRenderingModule.dll
// Namespace: UnityEngine
public enum HorizontalWrapMode
{
	// Fields

	public int value__; // 0x10
	public const HorizontalWrapMode Wrap = 0; // 0x0
	public const HorizontalWrapMode Overflow = 1; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.TextRenderingModule.dll
// Namespace: UnityEngine
public enum VerticalWrapMode
{
	// Fields

	public int value__; // 0x10
	public const VerticalWrapMode Truncate = 0; // 0x0
	public const VerticalWrapMode Overflow = 1; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.TextRenderingModule.dll
// Namespace: UnityEngine
public sealed class TextMesh : Component
{
	// Fields


	// Properties

	public string text { set; }
	public Font font { set; }
	public TextAnchor anchor { set; }
	public float characterSize { set; }

	// Methods

	// RVA: 0x6CF6A0CB80 Offset: 0x19B5B80 VA: 0x6CF6A0CB80
	public void set_text(string value) { }

	// RVA: 0x6CF6A0CBC4 Offset: 0x19B5BC4 VA: 0x6CF6A0CBC4
	public void set_font(Font value) { }

	// RVA: 0x6CF6A0CC08 Offset: 0x19B5C08 VA: 0x6CF6A0CC08
	public void set_anchor(TextAnchor value) { }

	// RVA: 0x6CF6A0CC4C Offset: 0x19B5C4C VA: 0x6CF6A0CC4C
	public void set_characterSize(float value) { }

}

// Dll : UnityEngine.TextRenderingModule.dll
// Namespace: UnityEngine
public struct UICharInfo
{
	// Fields

	public Vector2 cursorPos; // 0x10
	public float charWidth; // 0x18

	// Properties


	// Methods

}

// Dll : UnityEngine.TextRenderingModule.dll
// Namespace: UnityEngine
public struct UILineInfo
{
	// Fields

	public int startCharIdx; // 0x10
	public int height; // 0x14
	public float topY; // 0x18
	public float leading; // 0x1C

	// Properties


	// Methods

}

// Dll : UnityEngine.TextRenderingModule.dll
// Namespace: UnityEngine
public struct UIVertex
{
	// Fields

	public Vector3 position; // 0x10
	public Vector3 normal; // 0x1C
	public Vector4 tangent; // 0x28
	public Color32 color; // 0x38
	public Vector4 uv0; // 0x3C
	public Vector4 uv1; // 0x4C
	public Vector4 uv2; // 0x5C
	public Vector4 uv3; // 0x6C
	private static readonly Color32 s_DefaultColor; // 0x0
	private static readonly Vector4 s_DefaultTangent; // 0x4
	public static UIVertex simpleVert; // 0x14

	// Properties


	// Methods

	// RVA: 0x6CF6A0CC98 Offset: 0x19B5C98 VA: 0x6CF6A0CC98
	private static void .cctor() { }

}

// Dll : UnityEngine.TextRenderingModule.dll
// Namespace: 
public sealed class FontTextureRebuildCallback : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6A0D1F0 Offset: 0x19B61F0 VA: 0x6CF6A0D1F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF6A0D278 Offset: 0x19B6278 VA: 0x6CF6A0D278
	public virtual void Invoke() { }

}

// Dll : UnityEngine.TextRenderingModule.dll
// Namespace: UnityEngine
public sealed class Font : Object
{
	// Fields

	private static Action`1 textureRebuilt; // 0x0
	private FontTextureRebuildCallback m_FontTextureRebuildCallback; // 0x18

	// Properties

	public Material material { get; }
	public bool dynamic { get; }
	public int fontSize { get; }

	// Methods

	// RVA: 0x6CF6A0CE04 Offset: 0x19B5E04 VA: 0x6CF6A0CE04
	public static void add_textureRebuilt(Action`1 value) { }

	// RVA: 0x6CF6A0CED0 Offset: 0x19B5ED0 VA: 0x6CF6A0CED0
	public static void remove_textureRebuilt(Action`1 value) { }

	// RVA: 0x6CF6A0CF9C Offset: 0x19B5F9C VA: 0x6CF6A0CF9C
	public Material get_material() { }

	// RVA: 0x6CF6A0BF30 Offset: 0x19B4F30 VA: 0x6CF6A0BF30
	public bool get_dynamic() { }

	// RVA: 0x6CF6A0CFD8 Offset: 0x19B5FD8 VA: 0x6CF6A0CFD8
	public int get_fontSize() { }

	// RVA: 0x6CF6A0D014 Offset: 0x19B6014 VA: 0x6CF6A0D014
	public void .ctor() { }

	// RVA: 0x6CF6A0D0DC Offset: 0x19B60DC VA: 0x6CF6A0D0DC
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	// RVA: 0x6CF6A0D168 Offset: 0x19B6168 VA: 0x6CF6A0D168
	public bool HasCharacter(char c) { }

	// RVA: 0x6CF6A0D1AC Offset: 0x19B61AC VA: 0x6CF6A0D1AC
	private bool HasCharacter(int c) { }

	// RVA: 0x6CF6A0D098 Offset: 0x19B6098 VA: 0x6CF6A0D098
	private static void Internal_CreateFont(Font self, string name) { }

}

// Dll : UnityEngine.InputLegacyModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.InputLegacyModule.dll
// Namespace: UnityEngine
public enum TouchPhase
{
	// Fields

	public int value__; // 0x10
	public const TouchPhase Began = 0; // 0x0
	public const TouchPhase Moved = 1; // 0x0
	public const TouchPhase Stationary = 2; // 0x0
	public const TouchPhase Ended = 3; // 0x0
	public const TouchPhase Canceled = 4; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.InputLegacyModule.dll
// Namespace: UnityEngine
public enum IMECompositionMode
{
	// Fields

	public int value__; // 0x10
	public const IMECompositionMode Auto = 0; // 0x0
	public const IMECompositionMode On = 1; // 0x0
	public const IMECompositionMode Off = 2; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.InputLegacyModule.dll
// Namespace: UnityEngine
public enum TouchType
{
	// Fields

	public int value__; // 0x10
	public const TouchType Direct = 0; // 0x0
	public const TouchType Indirect = 1; // 0x0
	public const TouchType Stylus = 2; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.InputLegacyModule.dll
// Namespace: UnityEngine
public struct Touch
{
	// Fields

	private int m_FingerId; // 0x10
	private Vector2 m_Position; // 0x14
	private Vector2 m_RawPosition; // 0x1C
	private Vector2 m_PositionDelta; // 0x24
	private float m_TimeDelta; // 0x2C
	private int m_TapCount; // 0x30
	private TouchPhase m_Phase; // 0x34
	private TouchType m_Type; // 0x38
	private float m_Pressure; // 0x3C
	private float m_maximumPossiblePressure; // 0x40
	private float m_Radius; // 0x44
	private float m_RadiusVariance; // 0x48
	private float m_AltitudeAngle; // 0x4C
	private float m_AzimuthAngle; // 0x50

	// Properties

	public int fingerId { get; }
	public Vector2 position { get; set; }
	public Vector2 rawPosition { get; set; }
	public Vector2 deltaPosition { get; set; }
	public float deltaTime { get; }
	public int tapCount { get; }
	public TouchPhase phase { get; }
	public float pressure { get; }
	public float maximumPossiblePressure { get; }
	public TouchType type { get; }
	public float altitudeAngle { get; }
	public float azimuthAngle { get; }
	public float radius { get; }
	public float radiusVariance { get; }

	// Methods

	// RVA: 0x6CF69CA0CC Offset: 0x19730CC VA: 0x6CF69CA0CC
	public int get_fingerId() { }

	// RVA: 0x6CF69CA0D4 Offset: 0x19730D4 VA: 0x6CF69CA0D4
	public Vector2 get_position() { }

	// RVA: 0x6CF69CA0DC Offset: 0x19730DC VA: 0x6CF69CA0DC
	public void set_position(Vector2 value) { }

	// RVA: 0x6CF69CA0E4 Offset: 0x19730E4 VA: 0x6CF69CA0E4
	public Vector2 get_rawPosition() { }

	// RVA: 0x6CF69CA0EC Offset: 0x19730EC VA: 0x6CF69CA0EC
	public void set_rawPosition(Vector2 value) { }

	// RVA: 0x6CF69CA0F4 Offset: 0x19730F4 VA: 0x6CF69CA0F4
	public Vector2 get_deltaPosition() { }

	// RVA: 0x6CF69CA0FC Offset: 0x19730FC VA: 0x6CF69CA0FC
	public void set_deltaPosition(Vector2 value) { }

	// RVA: 0x6CF69CA104 Offset: 0x1973104 VA: 0x6CF69CA104
	public float get_deltaTime() { }

	// RVA: 0x6CF69CA10C Offset: 0x197310C VA: 0x6CF69CA10C
	public int get_tapCount() { }

	// RVA: 0x6CF69CA114 Offset: 0x1973114 VA: 0x6CF69CA114
	public TouchPhase get_phase() { }

	// RVA: 0x6CF69CA11C Offset: 0x197311C VA: 0x6CF69CA11C
	public float get_pressure() { }

	// RVA: 0x6CF69CA124 Offset: 0x1973124 VA: 0x6CF69CA124
	public float get_maximumPossiblePressure() { }

	// RVA: 0x6CF69CA12C Offset: 0x197312C VA: 0x6CF69CA12C
	public TouchType get_type() { }

	// RVA: 0x6CF69CA134 Offset: 0x1973134 VA: 0x6CF69CA134
	public float get_altitudeAngle() { }

	// RVA: 0x6CF69CA13C Offset: 0x197313C VA: 0x6CF69CA13C
	public float get_azimuthAngle() { }

	// RVA: 0x6CF69CA144 Offset: 0x1973144 VA: 0x6CF69CA144
	public float get_radius() { }

	// RVA: 0x6CF69CA14C Offset: 0x197314C VA: 0x6CF69CA14C
	public float get_radiusVariance() { }

}

// Dll : UnityEngine.InputLegacyModule.dll
// Namespace: UnityEngine
public enum PenStatus
{
	// Fields

	public int value__; // 0x10
	public const PenStatus None = 0; // 0x0
	public const PenStatus Contact = 1; // 0x0
	public const PenStatus Barrel = 2; // 0x0
	public const PenStatus Inverted = 4; // 0x0
	public const PenStatus Eraser = 8; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.InputLegacyModule.dll
// Namespace: UnityEngine
public enum PenEventType
{
	// Fields

	public int value__; // 0x10
	public const PenEventType NoContact = 0; // 0x0
	public const PenEventType PenDown = 1; // 0x0
	public const PenEventType PenUp = 2; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.InputLegacyModule.dll
// Namespace: UnityEngine
public struct PenData
{
	// Fields

	public Vector2 position; // 0x10
	public Vector2 tilt; // 0x18
	public PenStatus penStatus; // 0x20
	public float twist; // 0x24
	public float pressure; // 0x28
	public PenEventType contactType; // 0x2C
	public Vector2 deltaPos; // 0x30

	// Properties


	// Methods

}

// Dll : UnityEngine.InputLegacyModule.dll
// Namespace: UnityEngine
internal class CameraRaycastHelper : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69CA154 Offset: 0x1973154 VA: 0x6CF69CA154
	internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x6CF69CA21C Offset: 0x197321C VA: 0x6CF69CA21C
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x6CF69CA1B8 Offset: 0x19731B8 VA: 0x6CF69CA1B8
	private static GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }

	// RVA: 0x6CF69CA280 Offset: 0x1973280 VA: 0x6CF69CA280
	private static GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }

}

// Dll : UnityEngine.InputLegacyModule.dll
// Namespace: UnityEngine
public class Input : Object
{
	// Fields


	// Properties

	public static bool anyKey { get; }
	public static Vector3 mousePosition { get; }
	public static Vector2 mouseScrollDelta { get; }
	public static IMECompositionMode imeCompositionMode { get; set; }
	public static string compositionString { get; }
	public static Vector2 compositionCursorPos { get; set; }
	public static bool mousePresent { get; }
	public static int touchCount { get; }
	public static bool touchSupported { get; }
	public static Vector3 acceleration { get; }
	public static Touch[] touches { get; }

	// Methods

	// RVA: 0x6CF69CA2E4 Offset: 0x19732E4 VA: 0x6CF69CA2E4
	public static float GetAxis(string axisName) { }

	// RVA: 0x6CF69CA35C Offset: 0x197335C VA: 0x6CF69CA35C
	public static float GetAxisRaw(string axisName) { }

	// RVA: 0x6CF69CA3D4 Offset: 0x19733D4 VA: 0x6CF69CA3D4
	public static bool GetButton(string buttonName) { }

	// RVA: 0x6CF69CA44C Offset: 0x197344C VA: 0x6CF69CA44C
	public static bool GetButtonDown(string buttonName) { }

	// RVA: 0x6CF69CA4C4 Offset: 0x19734C4 VA: 0x6CF69CA4C4
	public static bool GetButtonUp(string buttonName) { }

	// RVA: 0x6CF69CA53C Offset: 0x197353C VA: 0x6CF69CA53C
	private static bool GetKeyInt(KeyCode key) { }

	// RVA: 0x6CF69CA578 Offset: 0x1973578 VA: 0x6CF69CA578
	private static bool GetKeyDownInt(KeyCode key) { }

	// RVA: 0x6CF69CA5B4 Offset: 0x19735B4 VA: 0x6CF69CA5B4
	public static bool GetMouseButton(int button) { }

	// RVA: 0x6CF69CA5F0 Offset: 0x19735F0 VA: 0x6CF69CA5F0
	public static bool GetMouseButtonDown(int button) { }

	// RVA: 0x6CF69CA62C Offset: 0x197362C VA: 0x6CF69CA62C
	public static bool GetMouseButtonUp(int button) { }

	// RVA: 0x6CF69CA668 Offset: 0x1973668 VA: 0x6CF69CA668
	public static Touch GetTouch(int index) { }

	// RVA: 0x6CF69CA71C Offset: 0x197371C VA: 0x6CF69CA71C
	public static PenData GetLastPenContactEvent() { }

	// RVA: 0x6CF69CA7BC Offset: 0x19737BC VA: 0x6CF69CA7BC
	public static void ClearLastPenContactEvent() { }

	// RVA: 0x6CF69CA7E4 Offset: 0x19737E4 VA: 0x6CF69CA7E4
	public static bool GetKey(KeyCode key) { }

	// RVA: 0x6CF69CA820 Offset: 0x1973820 VA: 0x6CF69CA820
	public static bool GetKeyDown(KeyCode key) { }

	// RVA: 0x6CF69CA85C Offset: 0x197385C VA: 0x6CF69CA85C
	public static bool get_anyKey() { }

	// RVA: 0x6CF69CA884 Offset: 0x1973884 VA: 0x6CF69CA884
	public static Vector3 get_mousePosition() { }

	// RVA: 0x6CF69CA90C Offset: 0x197390C VA: 0x6CF69CA90C
	public static Vector2 get_mouseScrollDelta() { }

	// RVA: 0x6CF69CA98C Offset: 0x197398C VA: 0x6CF69CA98C
	public static IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x6CF69CA9B4 Offset: 0x19739B4 VA: 0x6CF69CA9B4
	public static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x6CF69CA9F0 Offset: 0x19739F0 VA: 0x6CF69CA9F0
	public static string get_compositionString() { }

	// RVA: 0x6CF69CAA18 Offset: 0x1973A18 VA: 0x6CF69CAA18
	public static Vector2 get_compositionCursorPos() { }

	// RVA: 0x6CF69CAA98 Offset: 0x1973A98 VA: 0x6CF69CAA98
	public static void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x6CF69CAB14 Offset: 0x1973B14 VA: 0x6CF69CAB14
	public static bool get_mousePresent() { }

	// RVA: 0x6CF69CAB3C Offset: 0x1973B3C VA: 0x6CF69CAB3C
	public static int get_touchCount() { }

	// RVA: 0x6CF69CAB64 Offset: 0x1973B64 VA: 0x6CF69CAB64
	public static bool get_touchSupported() { }

	// RVA: 0x6CF69CAB8C Offset: 0x1973B8C VA: 0x6CF69CAB8C
	public static Vector3 get_acceleration() { }

	// RVA: 0x6CF69CAC14 Offset: 0x1973C14 VA: 0x6CF69CAC14
	public static Touch[] get_touches() { }

	// RVA: 0x6CF69CAD54 Offset: 0x1973D54 VA: 0x6CF69CAD54
	internal static bool CheckDisabled() { }

	// RVA: 0x6CF69CA6D8 Offset: 0x19736D8 VA: 0x6CF69CA6D8
	private static void GetTouch_Injected(int index, ref Touch ret) { }

	// RVA: 0x6CF69CA780 Offset: 0x1973780 VA: 0x6CF69CA780
	private static void GetLastPenContactEvent_Injected(ref PenData ret) { }

	// RVA: 0x6CF69CA8D0 Offset: 0x19738D0 VA: 0x6CF69CA8D0
	private static void get_mousePosition_Injected(ref Vector3 ret) { }

	// RVA: 0x6CF69CA950 Offset: 0x1973950 VA: 0x6CF69CA950
	private static void get_mouseScrollDelta_Injected(ref Vector2 ret) { }

	// RVA: 0x6CF69CAA5C Offset: 0x1973A5C VA: 0x6CF69CAA5C
	private static void get_compositionCursorPos_Injected(ref Vector2 ret) { }

	// RVA: 0x6CF69CAAD8 Offset: 0x1973AD8 VA: 0x6CF69CAAD8
	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

	// RVA: 0x6CF69CABD8 Offset: 0x1973BD8 VA: 0x6CF69CABD8
	private static void get_acceleration_Injected(ref Vector3 ret) { }

}

// Dll : UnityEngine.InputLegacyModule.dll
// Namespace: 
private struct HitInfo
{
	// Fields

	public GameObject target; // 0x10
	public Camera camera; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF69CBDCC Offset: 0x1974DCC VA: 0x6CF69CBDCC
	public void SendMessage(string name) { }

	// RVA: 0x6CF69CBD2C Offset: 0x1974D2C VA: 0x6CF69CBD2C
	public static bool op_Implicit(HitInfo exists) { }

	// RVA: 0x6CF69CBDF0 Offset: 0x1974DF0 VA: 0x6CF69CBDF0
	public static bool Compare(HitInfo lhs, HitInfo rhs) { }

}

// Dll : UnityEngine.InputLegacyModule.dll
// Namespace: UnityEngine
internal class SendMouseEvents : Object
{
	// Fields

	private static bool s_MouseUsed; // 0x0
	private static readonly HitInfo[] m_LastHit; // 0x8
	private static readonly HitInfo[] m_MouseDownHit; // 0x10
	private static readonly HitInfo[] m_CurrentHit; // 0x18
	private static Camera[] m_Cameras; // 0x20
	public static Func`1 s_GetMouseState; // 0x28
	private static Vector2 s_MousePosition; // 0x30
	private static bool s_MouseButtonPressedThisFrame; // 0x38
	private static bool s_MouseButtonIsPressed; // 0x39

	// Properties


	// Methods

	// RVA: 0x6CF69CAD7C Offset: 0x1973D7C VA: 0x6CF69CAD7C
	private static void UpdateMouse() { }

	// RVA: 0x6CF69CAF40 Offset: 0x1973F40 VA: 0x6CF69CAF40
	private static void SetMouseMoved() { }

	// RVA: 0x6CF69CAF9C Offset: 0x1973F9C VA: 0x6CF69CAF9C
	private static void DoSendMouseEvents(int skipRTCameras) { }

	// RVA: 0x6CF69CB904 Offset: 0x1974904 VA: 0x6CF69CB904
	private static void SendEvents(int i, HitInfo hit) { }

	// RVA: 0x6CF69CBEA4 Offset: 0x1974EA4 VA: 0x6CF69CBEA4
	private static void .cctor() { }

}

// Dll : UnityEngine.InputLegacyModule.dll
// Namespace: UnityEngine.Internal
internal static class InputUnsafeUtility : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69CBF48 Offset: 0x1974F48 VA: 0x6CF69CBF48
	internal static bool GetKeyString__Unmanaged(Byte* name, int nameLen) { }

	// RVA: 0x6CF69CBF8C Offset: 0x1974F8C VA: 0x6CF69CBF8C
	internal static bool GetKeyUpString__Unmanaged(Byte* name, int nameLen) { }

	// RVA: 0x6CF69CBFD0 Offset: 0x1974FD0 VA: 0x6CF69CBFD0
	internal static bool GetKeyDownString__Unmanaged(Byte* name, int nameLen) { }

	// RVA: 0x6CF69CA320 Offset: 0x1973320 VA: 0x6CF69CA320
	internal static float GetAxis(string axisName) { }

	// RVA: 0x6CF69CC014 Offset: 0x1975014 VA: 0x6CF69CC014
	internal static float GetAxis__Unmanaged(Byte* axisName, int axisNameLen) { }

	// RVA: 0x6CF69CA398 Offset: 0x1973398 VA: 0x6CF69CA398
	internal static float GetAxisRaw(string axisName) { }

	// RVA: 0x6CF69CC058 Offset: 0x1975058 VA: 0x6CF69CC058
	internal static float GetAxisRaw__Unmanaged(Byte* axisName, int axisNameLen) { }

	// RVA: 0x6CF69CA410 Offset: 0x1973410 VA: 0x6CF69CA410
	internal static bool GetButton(string buttonName) { }

	// RVA: 0x6CF69CC09C Offset: 0x197509C VA: 0x6CF69CC09C
	internal static bool GetButton__Unmanaged(Byte* buttonName, int buttonNameLen) { }

	// RVA: 0x6CF69CA488 Offset: 0x1973488 VA: 0x6CF69CA488
	internal static bool GetButtonDown(string buttonName) { }

	// RVA: 0x6CF69CC0E0 Offset: 0x19750E0 VA: 0x6CF69CC0E0
	internal static byte GetButtonDown__Unmanaged(Byte* buttonName, int buttonNameLen) { }

	// RVA: 0x6CF69CA500 Offset: 0x1973500 VA: 0x6CF69CA500
	internal static bool GetButtonUp(string buttonName) { }

	// RVA: 0x6CF69CC124 Offset: 0x1975124 VA: 0x6CF69CC124
	internal static bool GetButtonUp__Unmanaged(Byte* buttonName, int buttonNameLen) { }

}

// Dll : UnityEngine.Physics2DModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.Physics2DModule.dll
// Namespace: UnityEngine
public struct PhysicsScene2D : IEquatable`1
{
	// Fields

	private int m_Handle; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF69CC8EC Offset: 0x19758EC VA: 0x6CF69CC8EC
	public override string ToString() { }

	// RVA: 0x6CF69CC9D0 Offset: 0x19759D0 VA: 0x6CF69CC9D0
	public override int GetHashCode() { }

	// RVA: 0x6CF69CC9D8 Offset: 0x19759D8 VA: 0x6CF69CC9D8
	public override bool Equals(object other) { }

	// RVA: 0x6CF69CCA50 Offset: 0x1975A50 VA: 0x6CF69CCA50
	public bool Equals(PhysicsScene2D other) { }

	// RVA: 0x6CF69CCA60 Offset: 0x1975A60 VA: 0x6CF69CCA60
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	// RVA: 0x6CF69CCCBC Offset: 0x1975CBC VA: 0x6CF69CCCBC
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	// RVA: 0x6CF69CCC28 Offset: 0x1975C28 VA: 0x6CF69CCC28
	private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	// RVA: 0x6CF69CCD8C Offset: 0x1975D8C VA: 0x6CF69CCD8C
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x6CF69CCDBC Offset: 0x1975DBC VA: 0x6CF69CCDBC
	private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x6CF69CCEB0 Offset: 0x1975EB0 VA: 0x6CF69CCEB0
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List`1 results) { }

	// RVA: 0x6CF69CCEE0 Offset: 0x1975EE0 VA: 0x6CF69CCEE0
	private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List`1 results) { }

	// RVA: 0x6CF69CCFD4 Offset: 0x1975FD4 VA: 0x6CF69CCFD4
	public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, int layerMask) { }

	// RVA: 0x6CF69CCFF8 Offset: 0x1975FF8 VA: 0x6CF69CCFF8
	private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

	// RVA: 0x6CF69CCD10 Offset: 0x1975D10 VA: 0x6CF69CCD10
	private static void Raycast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, ref RaycastHit2D ret) { }

	// RVA: 0x6CF69CCE34 Offset: 0x1975E34 VA: 0x6CF69CCE34
	private static int RaycastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x6CF69CCF58 Offset: 0x1975F58 VA: 0x6CF69CCF58
	private static int RaycastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List`1 results) { }

	// RVA: 0x6CF69CD078 Offset: 0x1976078 VA: 0x6CF69CD078
	private static int GetRayIntersectionArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

}

// Dll : UnityEngine.Physics2DModule.dll
// Namespace: UnityEngine
public class Physics2D : Object
{
	// Fields

	private static List`1 m_LastDisabledRigidbody2D; // 0x0

	// Properties

	public static PhysicsScene2D defaultPhysicsScene { get; }
	public static bool queriesHitTriggers { get; }

	// Methods

	// RVA: 0x6CF69CD0F4 Offset: 0x19760F4 VA: 0x6CF69CD0F4
	public static PhysicsScene2D get_defaultPhysicsScene() { }

	// RVA: 0x6CF69CD0FC Offset: 0x19760FC VA: 0x6CF69CD0FC
	public static bool get_queriesHitTriggers() { }

	// RVA: 0x6CF69CD124 Offset: 0x1976124 VA: 0x6CF69CD124
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) { }

	// RVA: 0x6CF69CD1E4 Offset: 0x19761E4 VA: 0x6CF69CD1E4
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance) { }

	// RVA: 0x6CF69CD2AC Offset: 0x19762AC VA: 0x6CF69CD2AC
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	// RVA: 0x6CF69CD3BC Offset: 0x19763BC VA: 0x6CF69CD3BC
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth) { }

	// RVA: 0x6CF69CD4CC Offset: 0x19764CC VA: 0x6CF69CD4CC
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth) { }

	// RVA: 0x6CF69CD5E4 Offset: 0x19765E4 VA: 0x6CF69CD5E4
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x6CF69CD6A0 Offset: 0x19766A0 VA: 0x6CF69CD6A0
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	// RVA: 0x6CF69CD764 Offset: 0x1976764 VA: 0x6CF69CD764
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List`1 results, float distance) { }

	// RVA: 0x6CF69CD828 Offset: 0x1976828 VA: 0x6CF69CD828
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) { }

	// RVA: 0x6CF69CD944 Offset: 0x1976944 VA: 0x6CF69CD944
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) { }

	// RVA: 0x6CF69CD9B8 Offset: 0x19769B8 VA: 0x6CF69CD9B8
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, int layerMask) { }

	// RVA: 0x6CF69CD894 Offset: 0x1976894 VA: 0x6CF69CD894
	private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) { }

	// RVA: 0x6CF69CDAA4 Offset: 0x1976AA4 VA: 0x6CF69CDAA4
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) { }

	// RVA: 0x6CF69CDB20 Offset: 0x1976B20 VA: 0x6CF69CDB20
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) { }

	// RVA: 0x6CF69CDBA4 Offset: 0x1976BA4 VA: 0x6CF69CDBA4
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, int layerMask) { }

	// RVA: 0x6CF69CDC2C Offset: 0x1976C2C VA: 0x6CF69CDC2C
	private static void .cctor() { }

	// RVA: 0x6CF69CDA38 Offset: 0x1976A38 VA: 0x6CF69CDA38
	private static RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask) { }

}

// Dll : UnityEngine.Physics2DModule.dll
// Namespace: UnityEngine
public enum ForceMode2D
{
	// Fields

	public int value__; // 0x10
	public const ForceMode2D Force = 0; // 0x0
	public const ForceMode2D Impulse = 1; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.Physics2DModule.dll
// Namespace: UnityEngine
[Serializable]
public struct ContactFilter2D
{
	// Fields

	public bool useTriggers; // 0x10
	public bool useLayerMask; // 0x11
	public bool useDepth; // 0x12
	public bool useOutsideDepth; // 0x13
	public bool useNormalAngle; // 0x14
	public bool useOutsideNormalAngle; // 0x15
	public LayerMask layerMask; // 0x18
	public float minDepth; // 0x1C
	public float maxDepth; // 0x20
	public float minNormalAngle; // 0x24
	public float maxNormalAngle; // 0x28

	// Properties


	// Methods

	// RVA: 0x6CF69CDCB8 Offset: 0x1976CB8 VA: 0x6CF69CDCB8
	private void CheckConsistency() { }

	// RVA: 0x6CF69CDD30 Offset: 0x1976D30 VA: 0x6CF69CDD30
	public void SetLayerMask(LayerMask layerMask) { }

	// RVA: 0x6CF69CDD40 Offset: 0x1976D40 VA: 0x6CF69CDD40
	public void SetDepth(float minDepth, float maxDepth) { }

	// RVA: 0x6CF69CCB28 Offset: 0x1975B28 VA: 0x6CF69CCB28
	internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth) { }

	// RVA: 0x6CF69CDCF4 Offset: 0x1976CF4 VA: 0x6CF69CDCF4
	private static void CheckConsistency_Injected(ref ContactFilter2D _unity_self) { }

}

// Dll : UnityEngine.Physics2DModule.dll
// Namespace: UnityEngine
public class Collision2D : Object
{
	// Fields

	internal int m_Collider; // 0x10
	internal int m_OtherCollider; // 0x14
	internal int m_Rigidbody; // 0x18
	internal int m_OtherRigidbody; // 0x1C
	internal Vector2 m_RelativeVelocity; // 0x20
	internal int m_Enabled; // 0x28
	internal int m_ContactCount; // 0x2C
	internal ContactPoint2D[] m_ReusedContacts; // 0x30
	internal ContactPoint2D[] m_LegacyContacts; // 0x38

	// Properties


	// Methods

}

// Dll : UnityEngine.Physics2DModule.dll
// Namespace: UnityEngine
public struct ContactPoint2D
{
	// Fields

	private Vector2 m_Point; // 0x10
	private Vector2 m_Normal; // 0x18
	private Vector2 m_RelativeVelocity; // 0x20
	private float m_Separation; // 0x28
	private float m_NormalImpulse; // 0x2C
	private float m_TangentImpulse; // 0x30
	private int m_Collider; // 0x34
	private int m_OtherCollider; // 0x38
	private int m_Rigidbody; // 0x3C
	private int m_OtherRigidbody; // 0x40
	private int m_Enabled; // 0x44

	// Properties


	// Methods

}

// Dll : UnityEngine.Physics2DModule.dll
// Namespace: UnityEngine
public struct RaycastHit2D
{
	// Fields

	private Vector2 m_Centroid; // 0x10
	private Vector2 m_Point; // 0x18
	private Vector2 m_Normal; // 0x20
	private float m_Distance; // 0x28
	private float m_Fraction; // 0x2C
	private int m_Collider; // 0x30

	// Properties

	public Vector2 point { get; }
	public Vector2 normal { get; }
	public float distance { get; }
	public Collider2D collider { get; }

	// Methods

	// RVA: 0x6CF69CDD88 Offset: 0x1976D88 VA: 0x6CF69CDD88
	public Vector2 get_point() { }

	// RVA: 0x6CF69CDD90 Offset: 0x1976D90 VA: 0x6CF69CDD90
	public Vector2 get_normal() { }

	// RVA: 0x6CF69CDD98 Offset: 0x1976D98 VA: 0x6CF69CDD98
	public float get_distance() { }

	// RVA: 0x6CF69CDDA0 Offset: 0x1976DA0 VA: 0x6CF69CDDA0
	public Collider2D get_collider() { }

}

// Dll : UnityEngine.Physics2DModule.dll
// Namespace: UnityEngine
public sealed class Rigidbody2D : Component
{
	// Fields


	// Properties

	public Vector2 velocity { get; set; }
	public float angularVelocity { get; set; }

	// Methods

	// RVA: 0x6CF69CDE4C Offset: 0x1976E4C VA: 0x6CF69CDE4C
	public Vector2 get_velocity() { }

	// RVA: 0x6CF69CDEDC Offset: 0x1976EDC VA: 0x6CF69CDEDC
	public void set_velocity(Vector2 value) { }

	// RVA: 0x6CF69CDF68 Offset: 0x1976F68 VA: 0x6CF69CDF68
	public float get_angularVelocity() { }

	// RVA: 0x6CF69CDFA4 Offset: 0x1976FA4 VA: 0x6CF69CDFA4
	public void set_angularVelocity(float value) { }

	// RVA: 0x6CF69CDFF0 Offset: 0x1976FF0 VA: 0x6CF69CDFF0
	public void AddForce(Vector2 force) { }

	// RVA: 0x6CF69CDFF8 Offset: 0x1976FF8 VA: 0x6CF69CDFF8
	public void AddForce(Vector2 force, ForceMode2D mode) { }

	// RVA: 0x6CF69CDE98 Offset: 0x1976E98 VA: 0x6CF69CDE98
	private void get_velocity_Injected(ref Vector2 ret) { }

	// RVA: 0x6CF69CDF24 Offset: 0x1976F24 VA: 0x6CF69CDF24
	private void set_velocity_Injected(ref Vector2 value) { }

	// RVA: 0x6CF69CE050 Offset: 0x1977050 VA: 0x6CF69CE050
	private void AddForce_Injected(ref Vector2 force, ForceMode2D mode) { }

}

// Dll : UnityEngine.Physics2DModule.dll
// Namespace: UnityEngine
public class Collider2D : Behaviour
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.Physics2DModule.dll
// Namespace: UnityEngine
public sealed class BoxCollider2D : Collider2D
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine
internal sealed class AssetFileNameExtensionAttribute : Attribute
{
	// Fields

	private readonly string <preferredExtension>k__BackingField; // 0x10
	private readonly IEnumerable`1 <otherExtensions>k__BackingField; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF69D8928 Offset: 0x1981928 VA: 0x6CF69D8928
	public void .ctor(string preferredExtension, String[] otherExtensions) { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine
internal class ThreadAndSerializationSafeAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D8954 Offset: 0x1981954 VA: 0x6CF69D8954
	public void .ctor() { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine
internal class WritableAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D895C Offset: 0x198195C VA: 0x6CF69D895C
	public void .ctor() { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine
internal class UnityEngineModuleAssembly : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D8964 Offset: 0x1981964 VA: 0x6CF69D8964
	public void .ctor() { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine
internal sealed class NativeClassAttribute : Attribute
{
	// Fields

	private string <QualifiedNativeName>k__BackingField; // 0x10
	private string <Declaration>k__BackingField; // 0x18

	// Properties

	private string QualifiedNativeName { set; }
	private string Declaration { set; }

	// Methods

	// RVA: 0x6CF69D896C Offset: 0x198196C VA: 0x6CF69D896C
	private void set_QualifiedNativeName(string value) { }

	// RVA: 0x6CF69D8974 Offset: 0x1981974 VA: 0x6CF69D8974
	private void set_Declaration(string value) { }

	// RVA: 0x6CF69D897C Offset: 0x198197C VA: 0x6CF69D897C
	public void .ctor(string qualifiedCppName) { }

	// RVA: 0x6CF69D89EC Offset: 0x19819EC VA: 0x6CF69D89EC
	public void .ctor(string qualifiedCppName, string declaration) { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine
internal sealed class UnityString : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D8A18 Offset: 0x1981A18 VA: 0x6CF69D8A18
	public static string Format(string fmt, Object[] args) { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine.Bindings
internal class VisibleToOtherModulesAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D8AA0 Offset: 0x1981AA0 VA: 0x6CF69D8AA0
	public void .ctor() { }

	// RVA: 0x6CF69D8AA8 Offset: 0x1981AA8 VA: 0x6CF69D8AA8
	public void .ctor(String[] modules) { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine.Bindings
internal class NativeConditionalAttribute : Attribute
{
	// Fields

	private string <Condition>k__BackingField; // 0x10
	private bool <Enabled>k__BackingField; // 0x18

	// Properties

	public string Condition { set; }
	public bool Enabled { set; }

	// Methods

	// RVA: 0x6CF69D8AB0 Offset: 0x1981AB0 VA: 0x6CF69D8AB0
	public void set_Condition(string value) { }

	// RVA: 0x6CF69D8AB8 Offset: 0x1981AB8 VA: 0x6CF69D8AB8
	public void set_Enabled(bool value) { }

	// RVA: 0x6CF69D8AC4 Offset: 0x1981AC4 VA: 0x6CF69D8AC4
	public void .ctor(string condition) { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine.Bindings
internal class NativeHeaderAttribute : Attribute
{
	// Fields

	private string <Header>k__BackingField; // 0x10

	// Properties

	public string Header { set; }

	// Methods

	// RVA: 0x6CF69D8AF4 Offset: 0x1981AF4 VA: 0x6CF69D8AF4
	public void set_Header(string value) { }

	// RVA: 0x6CF69D8AFC Offset: 0x1981AFC VA: 0x6CF69D8AFC
	public void .ctor(string header) { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine.Bindings
internal class NativeNameAttribute : Attribute
{
	// Fields

	private string <Name>k__BackingField; // 0x10

	// Properties

	public string Name { set; }

	// Methods

	// RVA: 0x6CF69D8BF8 Offset: 0x1981BF8 VA: 0x6CF69D8BF8
	public void set_Name(string value) { }

	// RVA: 0x6CF69D8C00 Offset: 0x1981C00 VA: 0x6CF69D8C00
	public void .ctor(string name) { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine.Bindings
internal sealed class NativeWritableSelfAttribute : Attribute
{
	// Fields

	private bool <WritableSelf>k__BackingField; // 0x10

	// Properties

	public bool WritableSelf { set; }

	// Methods

	// RVA: 0x6CF69D8CFC Offset: 0x1981CFC VA: 0x6CF69D8CFC
	public void set_WritableSelf(bool value) { }

	// RVA: 0x6CF69D8D08 Offset: 0x1981D08 VA: 0x6CF69D8D08
	public void .ctor() { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine.Bindings
internal class NativeMethodAttribute : Attribute
{
	// Fields

	private string <Name>k__BackingField; // 0x10
	private bool <IsThreadSafe>k__BackingField; // 0x18
	private bool <IsFreeFunction>k__BackingField; // 0x19
	private bool <ThrowsException>k__BackingField; // 0x1A
	private bool <HasExplicitThis>k__BackingField; // 0x1B

	// Properties

	public string Name { set; }
	public bool IsThreadSafe { set; }
	public bool IsFreeFunction { set; }
	public bool ThrowsException { set; }
	public bool HasExplicitThis { set; }

	// Methods

	// RVA: 0x6CF69D8D28 Offset: 0x1981D28 VA: 0x6CF69D8D28
	public void set_Name(string value) { }

	// RVA: 0x6CF69D8D30 Offset: 0x1981D30 VA: 0x6CF69D8D30
	public void set_IsThreadSafe(bool value) { }

	// RVA: 0x6CF69D8D3C Offset: 0x1981D3C VA: 0x6CF69D8D3C
	public void set_IsFreeFunction(bool value) { }

	// RVA: 0x6CF69D8D48 Offset: 0x1981D48 VA: 0x6CF69D8D48
	public void set_ThrowsException(bool value) { }

	// RVA: 0x6CF69D8D54 Offset: 0x1981D54 VA: 0x6CF69D8D54
	public void set_HasExplicitThis(bool value) { }

	// RVA: 0x6CF69D8D60 Offset: 0x1981D60 VA: 0x6CF69D8D60
	public void .ctor() { }

	// RVA: 0x6CF69D8D68 Offset: 0x1981D68 VA: 0x6CF69D8D68
	public void .ctor(string name) { }

	// RVA: 0x6CF69D8E64 Offset: 0x1981E64 VA: 0x6CF69D8E64
	public void .ctor(string name, bool isFreeFunction) { }

	// RVA: 0x6CF69D8E8C Offset: 0x1981E8C VA: 0x6CF69D8E8C
	public void .ctor(string name, bool isFreeFunction, bool isThreadSafe) { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine.Bindings
internal enum TargetType
{
	// Fields

	public int value__; // 0x10
	public const TargetType Function = 0; // 0x0
	public const TargetType Field = 1; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine.Bindings
internal class NativePropertyAttribute : NativeMethodAttribute
{
	// Fields

	private TargetType <TargetType>k__BackingField; // 0x1C

	// Properties

	public TargetType TargetType { set; }

	// Methods

	// RVA: 0x6CF69D8EC0 Offset: 0x1981EC0 VA: 0x6CF69D8EC0
	public void set_TargetType(TargetType value) { }

	// RVA: 0x6CF69D8EC8 Offset: 0x1981EC8 VA: 0x6CF69D8EC8
	public void .ctor() { }

	// RVA: 0x6CF69D8ED0 Offset: 0x1981ED0 VA: 0x6CF69D8ED0
	public void .ctor(string name) { }

	// RVA: 0x6CF69D8ED4 Offset: 0x1981ED4 VA: 0x6CF69D8ED4
	public void .ctor(string name, bool isFree, TargetType targetType) { }

	// RVA: 0x6CF69D8F04 Offset: 0x1981F04 VA: 0x6CF69D8F04
	public void .ctor(string name, bool isFree, TargetType targetType, bool isThreadSafe) { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine.Bindings
internal enum CodegenOptions
{
	// Fields

	public int value__; // 0x10
	public const CodegenOptions Auto = 0; // 0x0
	public const CodegenOptions Custom = 1; // 0x0
	public const CodegenOptions Force = 2; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine.Bindings
internal class NativeAsStructAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D8F48 Offset: 0x1981F48 VA: 0x6CF69D8F48
	public void .ctor() { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine.Bindings
internal class NativeTypeAttribute : Attribute
{
	// Fields

	private string <Header>k__BackingField; // 0x10
	private string <IntermediateScriptingStructName>k__BackingField; // 0x18
	private CodegenOptions <CodegenOptions>k__BackingField; // 0x20

	// Properties

	public string Header { set; }
	public string IntermediateScriptingStructName { set; }
	public CodegenOptions CodegenOptions { set; }

	// Methods

	// RVA: 0x6CF69D8F50 Offset: 0x1981F50 VA: 0x6CF69D8F50
	public void set_Header(string value) { }

	// RVA: 0x6CF69D8F58 Offset: 0x1981F58 VA: 0x6CF69D8F58
	public void set_IntermediateScriptingStructName(string value) { }

	// RVA: 0x6CF69D8F60 Offset: 0x1981F60 VA: 0x6CF69D8F60
	public void set_CodegenOptions(CodegenOptions value) { }

	// RVA: 0x6CF69D8F68 Offset: 0x1981F68 VA: 0x6CF69D8F68
	public void .ctor() { }

	// RVA: 0x6CF69D8F84 Offset: 0x1981F84 VA: 0x6CF69D8F84
	public void .ctor(CodegenOptions codegenOptions) { }

	// RVA: 0x6CF69D8FAC Offset: 0x1981FAC VA: 0x6CF69D8FAC
	public void .ctor(string header) { }

	// RVA: 0x6CF69D90AC Offset: 0x19820AC VA: 0x6CF69D90AC
	public void .ctor(CodegenOptions codegenOptions, string intermediateStructName) { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine.Bindings
internal class NotNullAttribute : Attribute
{
	// Fields

	private string <Exception>k__BackingField; // 0x10

	// Properties

	public string Exception { set; }

	// Methods

	// RVA: 0x6CF69D90DC Offset: 0x19820DC VA: 0x6CF69D90DC
	public void set_Exception(string value) { }

	// RVA: 0x6CF69D90E4 Offset: 0x19820E4 VA: 0x6CF69D90E4
	public void .ctor(string exception) { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine.Bindings
internal class UnmarshalledAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D910C Offset: 0x198210C VA: 0x6CF69D910C
	public void .ctor() { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine.Bindings
internal class FreeFunctionAttribute : NativeMethodAttribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D9114 Offset: 0x1982114 VA: 0x6CF69D9114
	public void .ctor() { }

	// RVA: 0x6CF69D9134 Offset: 0x1982134 VA: 0x6CF69D9134
	public void .ctor(string name) { }

	// RVA: 0x6CF69D9150 Offset: 0x1982150 VA: 0x6CF69D9150
	public void .ctor(string name, bool isThreadSafe) { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine.Bindings
internal class ThreadSafeAttribute : NativeMethodAttribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D9180 Offset: 0x1982180 VA: 0x6CF69D9180
	public void .ctor() { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine.Bindings
internal enum StaticAccessorType
{
	// Fields

	public int value__; // 0x10
	public const StaticAccessorType Dot = 0; // 0x0
	public const StaticAccessorType Arrow = 1; // 0x0
	public const StaticAccessorType DoubleColon = 2; // 0x0
	public const StaticAccessorType ArrowWithDefaultReturnIfNull = 3; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine.Bindings
internal class StaticAccessorAttribute : Attribute
{
	// Fields

	private string <Name>k__BackingField; // 0x10
	private StaticAccessorType <Type>k__BackingField; // 0x18

	// Properties

	public string Name { set; }
	public StaticAccessorType Type { set; }

	// Methods

	// RVA: 0x6CF69D91A0 Offset: 0x19821A0 VA: 0x6CF69D91A0
	public void set_Name(string value) { }

	// RVA: 0x6CF69D91A8 Offset: 0x19821A8 VA: 0x6CF69D91A8
	public void set_Type(StaticAccessorType value) { }

	// RVA: 0x6CF69D91B0 Offset: 0x19821B0 VA: 0x6CF69D91B0
	internal void .ctor(string name) { }

	// RVA: 0x6CF69D91D8 Offset: 0x19821D8 VA: 0x6CF69D91D8
	public void .ctor(string name, StaticAccessorType type) { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine.Bindings
internal class NativeThrowsAttribute : Attribute
{
	// Fields

	private bool <ThrowsException>k__BackingField; // 0x10

	// Properties

	public bool ThrowsException { set; }

	// Methods

	// RVA: 0x6CF69D9208 Offset: 0x1982208 VA: 0x6CF69D9208
	public void set_ThrowsException(bool value) { }

	// RVA: 0x6CF69D9214 Offset: 0x1982214 VA: 0x6CF69D9214
	public void .ctor() { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine.Bindings
internal class IgnoreAttribute : Attribute
{
	// Fields

	private bool <DoesNotContributeToSize>k__BackingField; // 0x10

	// Properties

	public bool DoesNotContributeToSize { set; }

	// Methods

	// RVA: 0x6CF69D9234 Offset: 0x1982234 VA: 0x6CF69D9234
	public void set_DoesNotContributeToSize(bool value) { }

	// RVA: 0x6CF69D9240 Offset: 0x1982240 VA: 0x6CF69D9240
	public void .ctor() { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine.Bindings
internal class PreventReadOnlyInstanceModificationAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D9248 Offset: 0x1982248 VA: 0x6CF69D9248
	public void .ctor() { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine.Scripting
internal class UsedByNativeCodeAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69D9250 Offset: 0x1982250 VA: 0x6CF69D9250
	public void .ctor() { }

}

// Dll : UnityEngine.SharedInternalsModule.dll
// Namespace: UnityEngine.Scripting
internal class RequiredByNativeCodeAttribute : Attribute
{
	// Fields

	private string <Name>k__BackingField; // 0x10
	private bool <Optional>k__BackingField; // 0x18
	private bool <GenerateProxy>k__BackingField; // 0x19

	// Properties

	public string Name { set; }
	public bool Optional { set; }
	public bool GenerateProxy { set; }

	// Methods

	// RVA: 0x6CF69D9258 Offset: 0x1982258 VA: 0x6CF69D9258
	public void .ctor() { }

	// RVA: 0x6CF69D9260 Offset: 0x1982260 VA: 0x6CF69D9260
	public void .ctor(string name) { }

	// RVA: 0x6CF69D9288 Offset: 0x1982288 VA: 0x6CF69D9288
	public void set_Name(string value) { }

	// RVA: 0x6CF69D9290 Offset: 0x1982290 VA: 0x6CF69D9290
	public void set_Optional(bool value) { }

	// RVA: 0x6CF69D929C Offset: 0x198229C VA: 0x6CF69D929C
	public void set_GenerateProxy(bool value) { }

}

// Dll : UnityEngine.AudioModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.AudioModule.dll
// Namespace: 
public sealed class AudioConfigurationChangeHandler : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6961624 Offset: 0x190A624 VA: 0x6CF6961624
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF69616B0 Offset: 0x190A6B0 VA: 0x6CF69616B0
	public virtual void Invoke(bool deviceWasChanged) { }

}

// Dll : UnityEngine.AudioModule.dll
// Namespace: 
public static class Mobile : Object
{
	// Fields

	private static bool <muteState>k__BackingField; // 0x0
	private static bool _stopAudioOutputOnMute; // 0x1
	private static Action`1 OnMuteStateChanged; // 0x8

	// Properties

	public static bool muteState { get; set; }
	public static bool stopAudioOutputOnMute { get; }

	// Methods

	// RVA: 0x6CF69616C8 Offset: 0x190A6C8 VA: 0x6CF69616C8
	public static bool get_muteState() { }

	// RVA: 0x6CF6961710 Offset: 0x190A710 VA: 0x6CF6961710
	private static void set_muteState(bool value) { }

	// RVA: 0x6CF6961760 Offset: 0x190A760 VA: 0x6CF6961760
	public static bool get_stopAudioOutputOnMute() { }

	// RVA: 0x6CF69617A8 Offset: 0x190A7A8 VA: 0x6CF69617A8
	internal static void InvokeOnMuteStateChanged(bool mute) { }

	// RVA: 0x6CF6961978 Offset: 0x190A978 VA: 0x6CF6961978
	internal static bool InvokeIsStopAudioOutputOnMuteEnabled() { }

	// RVA: 0x6CF6961950 Offset: 0x190A950 VA: 0x6CF6961950
	public static void StartAudioOutput() { }

	// RVA: 0x6CF6961928 Offset: 0x190A928 VA: 0x6CF6961928
	public static void StopAudioOutput() { }

}

// Dll : UnityEngine.AudioModule.dll
// Namespace: UnityEngine
public sealed class AudioSettings : Object
{
	// Fields

	private static AudioConfigurationChangeHandler OnAudioConfigurationChanged; // 0x0
	private static Action OnAudioSystemShuttingDown; // 0x8
	private static Action OnAudioSystemStartedUp; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF69614A0 Offset: 0x190A4A0 VA: 0x6CF69614A0
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	// RVA: 0x6CF696150C Offset: 0x190A50C VA: 0x6CF696150C
	internal static void InvokeOnAudioSystemShuttingDown() { }

	// RVA: 0x6CF6961570 Offset: 0x190A570 VA: 0x6CF6961570
	internal static void InvokeOnAudioSystemStartedUp() { }

	// RVA: 0x6CF69615D4 Offset: 0x190A5D4 VA: 0x6CF69615D4
	internal static bool StartAudioOutput() { }

	// RVA: 0x6CF69615FC Offset: 0x190A5FC VA: 0x6CF69615FC
	internal static bool StopAudioOutput() { }

}

// Dll : UnityEngine.AudioModule.dll
// Namespace: 
public sealed class PCMReaderCallback : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6961A90 Offset: 0x190AA90 VA: 0x6CF6961A90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF6961B2C Offset: 0x190AB2C VA: 0x6CF6961B2C
	public virtual void Invoke(Single[] data) { }

}

// Dll : UnityEngine.AudioModule.dll
// Namespace: 
public sealed class PCMSetPositionCallback : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6961B40 Offset: 0x190AB40 VA: 0x6CF6961B40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF6961BCC Offset: 0x190ABCC VA: 0x6CF6961BCC
	public virtual void Invoke(int position) { }

}

// Dll : UnityEngine.AudioModule.dll
// Namespace: UnityEngine
public sealed class AudioClip : Object
{
	// Fields

	private PCMReaderCallback m_PCMReaderCallback; // 0x18
	private PCMSetPositionCallback m_PCMSetPositionCallback; // 0x20

	// Properties

	public float length { get; }

	// Methods

	// RVA: 0x6CF69619C0 Offset: 0x190A9C0 VA: 0x6CF69619C0
	private void .ctor() { }

	// RVA: 0x6CF6961A1C Offset: 0x190AA1C VA: 0x6CF6961A1C
	public float get_length() { }

	// RVA: 0x6CF6961A58 Offset: 0x190AA58 VA: 0x6CF6961A58
	private void InvokePCMReaderCallback_Internal(Single[] data) { }

	// RVA: 0x6CF6961A74 Offset: 0x190AA74 VA: 0x6CF6961A74
	private void InvokePCMSetPositionCallback_Internal(int position) { }

}

// Dll : UnityEngine.AudioModule.dll
// Namespace: UnityEngine
public class AudioBehaviour : Behaviour
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.AudioModule.dll
// Namespace: UnityEngine
public sealed class AudioListener : AudioBehaviour
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.AudioModule.dll
// Namespace: UnityEngine
public sealed class AudioSource : AudioBehaviour
{
	// Fields


	// Properties

	public float volume { set; }
	public AudioClip clip { get; set; }
	public bool isPlaying { get; }
	public float spatialBlend { set; }

	// Methods

	// RVA: 0x6CF6961BE0 Offset: 0x190ABE0 VA: 0x6CF6961BE0
	private static void PlayHelper(AudioSource source, ulong delay) { }

	// RVA: 0x6CF6961C24 Offset: 0x190AC24 VA: 0x6CF6961C24
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	// RVA: 0x6CF6961C78 Offset: 0x190AC78 VA: 0x6CF6961C78
	private void Stop(bool stopOneShots) { }

	// RVA: 0x6CF6961CBC Offset: 0x190ACBC VA: 0x6CF6961CBC
	public void set_volume(float value) { }

	// RVA: 0x6CF6961D08 Offset: 0x190AD08 VA: 0x6CF6961D08
	public AudioClip get_clip() { }

	// RVA: 0x6CF6961D44 Offset: 0x190AD44 VA: 0x6CF6961D44
	public void set_clip(AudioClip value) { }

	// RVA: 0x6CF6961D88 Offset: 0x190AD88 VA: 0x6CF6961D88
	public void Play() { }

	// RVA: 0x6CF6961DC8 Offset: 0x190ADC8 VA: 0x6CF6961DC8
	public void PlayOneShot(AudioClip clip) { }

	// RVA: 0x6CF6961DD0 Offset: 0x190ADD0 VA: 0x6CF6961DD0
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	// RVA: 0x6CF6961ECC Offset: 0x190AECC VA: 0x6CF6961ECC
	public void Stop() { }

	// RVA: 0x6CF6961F0C Offset: 0x190AF0C VA: 0x6CF6961F0C
	public bool get_isPlaying() { }

	// RVA: 0x6CF6961F48 Offset: 0x190AF48 VA: 0x6CF6961F48
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) { }

	// RVA: 0x6CF69621C8 Offset: 0x190B1C8 VA: 0x6CF69621C8
	public void set_spatialBlend(float value) { }

}

// Dll : UnityEngine.AudioModule.dll
// Namespace: 
public sealed class SampleFramesHandler : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6962264 Offset: 0x190B264 VA: 0x6CF6962264
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF6962368 Offset: 0x190B368 VA: 0x6CF6962368
	public virtual void Invoke(AudioSampleProvider provider, uint sampleFrameCount) { }

}

// Dll : UnityEngine.AudioModule.dll
// Namespace: UnityEngine.Experimental.Audio
public class AudioSampleProvider : Object
{
	// Fields

	private SampleFramesHandler sampleFramesAvailable; // 0x10
	private SampleFramesHandler sampleFramesOverflow; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF6962214 Offset: 0x190B214 VA: 0x6CF6962214
	private void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	// RVA: 0x6CF696223C Offset: 0x190B23C VA: 0x6CF696223C
	private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }

}

// Dll : UnityEngine.AudioModule.dll
// Namespace: UnityEngine.Audio
public struct AudioClipPlayable : IEquatable`1
{
	// Fields

	private PlayableHandle m_Handle; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF696237C Offset: 0x190B37C VA: 0x6CF696237C
	public PlayableHandle GetHandle() { }

	// RVA: 0x6CF6962388 Offset: 0x190B388 VA: 0x6CF6962388
	public bool Equals(AudioClipPlayable other) { }

}

// Dll : UnityEngine.AudioModule.dll
// Namespace: UnityEngine.Audio
public struct AudioMixerPlayable : IEquatable`1
{
	// Fields

	private PlayableHandle m_Handle; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF6962400 Offset: 0x190B400 VA: 0x6CF6962400
	public PlayableHandle GetHandle() { }

	// RVA: 0x6CF696240C Offset: 0x190B40C VA: 0x6CF696240C
	public bool Equals(AudioMixerPlayable other) { }

}

// Dll : UnityEngine.AudioModule.dll
// Namespace: UnityEngine.Audio
public struct AudioPlayableOutput
{
	// Fields

	private PlayableOutputHandle m_Handle; // 0x10

	// Properties


	// Methods

}

// Dll : UnityEngine.ParticleSystemModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.ParticleSystemModule.dll
// Namespace: 
public struct MainModule
{
	// Fields

	internal ParticleSystem m_ParticleSystem; // 0x10

	// Properties

	public float startLifetimeMultiplier { get; }

	// Methods

	// RVA: 0x6CF69CC810 Offset: 0x1975810 VA: 0x6CF69CC810
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x6CF69CC6A4 Offset: 0x19756A4 VA: 0x6CF69CC6A4
	public float get_startLifetimeMultiplier() { }

	// RVA: 0x6CF69CC820 Offset: 0x1975820 VA: 0x6CF69CC820
	private static float get_startLifetimeMultiplier_Injected(ref MainModule _unity_self) { }

}

// Dll : UnityEngine.ParticleSystemModule.dll
// Namespace: 
public struct EmissionModule
{
	// Fields

	internal ParticleSystem m_ParticleSystem; // 0x10

	// Properties

	public bool enabled { set; }

	// Methods

	// RVA: 0x6CF69CC818 Offset: 0x1975818 VA: 0x6CF69CC818
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x6CF69CC61C Offset: 0x197561C VA: 0x6CF69CC61C
	public void set_enabled(bool value) { }

	// RVA: 0x6CF69CC85C Offset: 0x197585C VA: 0x6CF69CC85C
	private static void set_enabled_Injected(ref EmissionModule _unity_self, bool value) { }

}

// Dll : UnityEngine.ParticleSystemModule.dll
// Namespace: 
public struct Particle
{
	// Fields

	private Vector3 m_Position; // 0x10
	private Vector3 m_Velocity; // 0x1C
	private Vector3 m_AnimatedVelocity; // 0x28
	private Vector3 m_InitialVelocity; // 0x34
	private Vector3 m_AxisOfRotation; // 0x40
	private Vector3 m_Rotation; // 0x4C
	private Vector3 m_AngularVelocity; // 0x58
	private Vector3 m_StartSize; // 0x64
	private Color32 m_StartColor; // 0x70
	private uint m_RandomSeed; // 0x74
	private uint m_ParentRandomSeed; // 0x78
	private float m_Lifetime; // 0x7C
	private float m_StartLifetime; // 0x80
	private int m_MeshIndex; // 0x84
	private float m_EmitAccumulator0; // 0x88
	private float m_EmitAccumulator1; // 0x8C
	private uint m_Flags; // 0x90

	// Properties

	public float lifetime { set; }
	public Vector3 position { set; }
	public Vector3 velocity { set; }
	public float remainingLifetime { set; }
	public float startLifetime { set; }
	public Color32 startColor { set; }
	public uint randomSeed { set; }
	public float startSize { set; }
	public Vector3 rotation3D { set; }
	public Vector3 angularVelocity3D { set; }

	// Methods

	// RVA: 0x6CF69CC4C4 Offset: 0x19754C4 VA: 0x6CF69CC4C4
	public void set_lifetime(float value) { }

	// RVA: 0x6CF69CC4AC Offset: 0x19754AC VA: 0x6CF69CC4AC
	public void set_position(Vector3 value) { }

	// RVA: 0x6CF69CC4B8 Offset: 0x19754B8 VA: 0x6CF69CC4B8
	public void set_velocity(Vector3 value) { }

	// RVA: 0x6CF69CC8A0 Offset: 0x19758A0 VA: 0x6CF69CC8A0
	public void set_remainingLifetime(float value) { }

	// RVA: 0x6CF69CC4CC Offset: 0x19754CC VA: 0x6CF69CC4CC
	public void set_startLifetime(float value) { }

	// RVA: 0x6CF69CC538 Offset: 0x1975538 VA: 0x6CF69CC538
	public void set_startColor(Color32 value) { }

	// RVA: 0x6CF69CC540 Offset: 0x1975540 VA: 0x6CF69CC540
	public void set_randomSeed(uint value) { }

	// RVA: 0x6CF69CC4D4 Offset: 0x19754D4 VA: 0x6CF69CC4D4
	public void set_startSize(float value) { }

	// RVA: 0x6CF69CC4E0 Offset: 0x19754E0 VA: 0x6CF69CC4E0
	public void set_rotation3D(Vector3 value) { }

	// RVA: 0x6CF69CC50C Offset: 0x197550C VA: 0x6CF69CC50C
	public void set_angularVelocity3D(Vector3 value) { }

}

// Dll : UnityEngine.ParticleSystemModule.dll
// Namespace: 
public struct EmitParams
{
	// Fields

	private Particle m_Particle; // 0x10
	private bool m_PositionSet; // 0x94
	private bool m_VelocitySet; // 0x95
	private bool m_AxisOfRotationSet; // 0x96
	private bool m_RotationSet; // 0x97
	private bool m_AngularVelocitySet; // 0x98
	private bool m_StartSizeSet; // 0x99
	private bool m_StartColorSet; // 0x9A
	private bool m_RandomSeedSet; // 0x9B
	private bool m_StartLifetimeSet; // 0x9C
	private bool m_MeshIndexSet; // 0x9D
	private bool m_ApplyShapeToPosition; // 0x9E

	// Properties


	// Methods

}

// Dll : UnityEngine.ParticleSystemModule.dll
// Namespace: UnityEngine
public sealed class ParticleSystem : Component
{
	// Fields


	// Properties

	public bool enableEmission { set; }
	public float startLifetime { get; }
	public MainModule main { get; }
	public EmissionModule emission { get; }

	// Methods

	// RVA: 0x6CF69CC3A8 Offset: 0x19753A8 VA: 0x6CF69CC3A8
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	// RVA: 0x6CF69CC58C Offset: 0x197558C VA: 0x6CF69CC58C
	public void Emit(Particle particle) { }

	// RVA: 0x6CF69CC5D0 Offset: 0x19755D0 VA: 0x6CF69CC5D0
	public void set_enableEmission(bool value) { }

	// RVA: 0x6CF69CC660 Offset: 0x1975660 VA: 0x6CF69CC660
	public float get_startLifetime() { }

	// RVA: 0x6CF69CC6E0 Offset: 0x19756E0 VA: 0x6CF69CC6E0
	public void Emit(int count) { }

	// RVA: 0x6CF69CC724 Offset: 0x1975724 VA: 0x6CF69CC724
	private void Emit_Internal(int count) { }

	// RVA: 0x6CF69CC768 Offset: 0x1975768 VA: 0x6CF69CC768
	public void Emit(EmitParams emitParams, int count) { }

	// RVA: 0x6CF69CC548 Offset: 0x1975548 VA: 0x6CF69CC548
	private void EmitOld_Internal(ref Particle particle) { }

	// RVA: 0x6CF69CC6A0 Offset: 0x19756A0 VA: 0x6CF69CC6A0
	public MainModule get_main() { }

	// RVA: 0x6CF69CC618 Offset: 0x1975618 VA: 0x6CF69CC618
	public EmissionModule get_emission() { }

	// RVA: 0x6CF69CC7BC Offset: 0x19757BC VA: 0x6CF69CC7BC
	private void Emit_Injected(ref EmitParams emitParams, int count) { }

}

// Dll : UnityEngine.ParticleSystemModule.dll
// Namespace: UnityEngine
public sealed class ParticleSystemRenderer : Renderer
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69CC8A8 Offset: 0x19758A8 VA: 0x6CF69CC8A8
	public int GetMeshes(Mesh[] meshes) { }

}

// Dll : UnityEngine.GameCenterModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine
public static class Social : Object
{
	// Fields


	// Properties

	public static ISocialPlatform Active { get; set; }

	// Methods

	// RVA: 0x6CF69A17E8 Offset: 0x194A7E8 VA: 0x6CF69A17E8
	public static ISocialPlatform get_Active() { }

	// RVA: 0x6CF69A1854 Offset: 0x194A854 VA: 0x6CF69A1854
	public static void set_Active(ISocialPlatform value) { }

	// RVA: 0x6CF69A18EC Offset: 0x194A8EC VA: 0x6CF69A18EC
	public static void ShowLeaderboardUI() { }

}

// Dll : UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms
public class Local : Object, ISocialPlatform
{
	// Fields

	private static LocalUser m_LocalUser; // 0x0
	private List`1 m_Friends; // 0x10
	private List`1 m_Users; // 0x18
	private List`1 m_AchievementDescriptions; // 0x20
	private List`1 m_Achievements; // 0x28
	private List`1 m_Leaderboards; // 0x30

	// Properties

	public ILocalUser localUser { get; }

	// Methods

	// RVA: 0x6CF69A1984 Offset: 0x194A984 VA: 0x6CF69A1984
	public ILocalUser get_localUser() { }

	// RVA: 0x6CF69A1A68 Offset: 0x194AA68 VA: 0x6CF69A1A68
	private bool UnityEngine.SocialPlatforms.ISocialPlatform.GetLoading(ILeaderboard board) { }

	// RVA: 0x6CF69A1C98 Offset: 0x194AC98 VA: 0x6CF69A1C98
	public void ShowLeaderboardUI() { }

	// RVA: 0x6CF69A1B00 Offset: 0x194AB00 VA: 0x6CF69A1B00
	private bool VerifyUser() { }

	// RVA: 0x6CF69A1D00 Offset: 0x194AD00 VA: 0x6CF69A1D00
	public void .ctor() { }

}

// Dll : UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms
internal static class ActivePlatform : Object
{
	// Fields

	private static ISocialPlatform _active; // 0x0

	// Properties

	internal static ISocialPlatform Instance { get; set; }

	// Methods

	// RVA: 0x6CF69A17EC Offset: 0x194A7EC VA: 0x6CF69A17EC
	internal static ISocialPlatform get_Instance() { }

	// RVA: 0x6CF69A18A0 Offset: 0x194A8A0 VA: 0x6CF69A18A0
	internal static void set_Instance(ISocialPlatform value) { }

	// RVA: 0x6CF69A1E6C Offset: 0x194AE6C VA: 0x6CF69A1E6C
	private static ISocialPlatform SelectSocialPlatform() { }

}

// Dll : UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms
public interface ISocialPlatform
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public abstract void ShowLeaderboardUI() { }

	// RVA: 0x6CF5BD68DC Offset: 0xB7F8DC VA: 0x6CF5BD68DC
	public abstract bool GetLoading(ILeaderboard board) { }

}

// Dll : UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms
public interface ILocalUser : IUserProfile
{
	// Fields


	// Properties

	public abstract bool authenticated { get; }

	// Methods

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public abstract bool get_authenticated() { }

}

// Dll : UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms
public enum UserState
{
	// Fields

	public int value__; // 0x10
	public const UserState Online = 0; // 0x0
	public const UserState OnlineAndAway = 1; // 0x0
	public const UserState OnlineAndBusy = 2; // 0x0
	public const UserState Offline = 3; // 0x0
	public const UserState Playing = 4; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms
public interface IUserProfile
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms
public interface IAchievement
{
	// Fields


	// Properties

	public abstract string id { get; }
	public abstract bool completed { get; }

	// Methods

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public abstract string get_id() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public abstract bool get_completed() { }

}

// Dll : UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms
public interface IAchievementDescription
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms
public interface IScore
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms
public enum UserScope
{
	// Fields

	public int value__; // 0x10
	public const UserScope Global = 0; // 0x0
	public const UserScope FriendsOnly = 1; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms
public enum TimeScope
{
	// Fields

	public int value__; // 0x10
	public const TimeScope Today = 0; // 0x0
	public const TimeScope Week = 1; // 0x0
	public const TimeScope AllTime = 2; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms
public struct Range
{
	// Fields

	public int from; // 0x10
	public int count; // 0x14

	// Properties


	// Methods

}

// Dll : UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms
public interface ILeaderboard
{
	// Fields


	// Properties

	public abstract bool loading { get; }
	public abstract string id { get; }
	public abstract UserScope userScope { get; }
	public abstract Range range { get; }
	public abstract TimeScope timeScope { get; }

	// Methods

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public abstract bool get_loading() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public abstract string get_id() { }

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	public abstract UserScope get_userScope() { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public abstract Range get_range() { }

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	public abstract TimeScope get_timeScope() { }

}

// Dll : UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms.Impl
public class LocalUser : UserProfile, ILocalUser, IUserProfile
{
	// Fields

	private IUserProfile[] m_Friends; // 0x38
	private bool m_Authenticated; // 0x40
	private bool m_Underage; // 0x41

	// Properties

	public bool authenticated { get; }

	// Methods

	// RVA: 0x6CF69A1A0C Offset: 0x194AA0C VA: 0x6CF69A1A0C
	public void .ctor() { }

	// RVA: 0x6CF69A1F74 Offset: 0x194AF74 VA: 0x6CF69A1F74
	public bool get_authenticated() { }

}

// Dll : UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms.Impl
public class UserProfile : Object, IUserProfile
{
	// Fields

	protected string m_UserName; // 0x10
	protected string m_ID; // 0x18
	private string m_legacyID; // 0x20
	protected bool m_IsFriend; // 0x28
	protected UserState m_State; // 0x2C
	protected Texture2D m_Image; // 0x30

	// Properties

	public string userName { get; }
	public string id { get; }
	public bool isFriend { get; }
	public UserState state { get; }

	// Methods

	// RVA: 0x6CF69A1EBC Offset: 0x194AEBC VA: 0x6CF69A1EBC
	public void .ctor() { }

	// RVA: 0x6CF69A1F7C Offset: 0x194AF7C VA: 0x6CF69A1F7C
	public override string ToString() { }

	// RVA: 0x6CF69A20E4 Offset: 0x194B0E4 VA: 0x6CF69A20E4
	public string get_userName() { }

	// RVA: 0x6CF69A20DC Offset: 0x194B0DC VA: 0x6CF69A20DC
	public string get_id() { }

	// RVA: 0x6CF69A20EC Offset: 0x194B0EC VA: 0x6CF69A20EC
	public bool get_isFriend() { }

	// RVA: 0x6CF69A20F4 Offset: 0x194B0F4 VA: 0x6CF69A20F4
	public UserState get_state() { }

}

// Dll : UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms.Impl
public class Achievement : Object, IAchievement
{
	// Fields

	private bool m_Completed; // 0x10
	private string <id>k__BackingField; // 0x18

	// Properties

	public string id { get; }
	public bool completed { get; }

	// Methods

	// RVA: 0x6CF69A20FC Offset: 0x194B0FC VA: 0x6CF69A20FC
	public string get_id() { }

	// RVA: 0x6CF69A2104 Offset: 0x194B104 VA: 0x6CF69A2104
	public bool get_completed() { }

}

// Dll : UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms.Impl
public class AchievementDescription : Object, IAchievementDescription
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms.Impl
public class Leaderboard : Object, ILeaderboard
{
	// Fields

	private string <id>k__BackingField; // 0x10
	private UserScope <userScope>k__BackingField; // 0x18
	private Range <range>k__BackingField; // 0x1C
	private TimeScope <timeScope>k__BackingField; // 0x24

	// Properties

	public bool loading { get; }
	public string id { get; }
	public UserScope userScope { get; }
	public Range range { get; }
	public TimeScope timeScope { get; }

	// Methods

	// RVA: 0x6CF69A1BEC Offset: 0x194ABEC VA: 0x6CF69A1BEC
	public bool get_loading() { }

	// RVA: 0x6CF69A210C Offset: 0x194B10C VA: 0x6CF69A210C
	public string get_id() { }

	// RVA: 0x6CF69A2114 Offset: 0x194B114 VA: 0x6CF69A2114
	public UserScope get_userScope() { }

	// RVA: 0x6CF69A211C Offset: 0x194B11C VA: 0x6CF69A211C
	public Range get_range() { }

	// RVA: 0x6CF69A2124 Offset: 0x194B124 VA: 0x6CF69A2124
	public TimeScope get_timeScope() { }

}

// Dll : NativeShare.Runtime.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : NativeShare.Runtime.dll
// Namespace: 
public enum ShareResult
{
	// Fields

	public int value__; // 0x10
	public const ShareResult Unknown = 0; // 0x0
	public const ShareResult Shared = 1; // 0x0
	public const ShareResult NotShared = 2; // 0x0

	// Properties


	// Methods

}

// Dll : NativeShare.Runtime.dll
// Namespace: 
public sealed class ShareResultCallback : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6779888 Offset: 0x1722888 VA: 0x6CF6779888
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF6779914 Offset: 0x1722914 VA: 0x6CF6779914
	public virtual void Invoke(ShareResult result, string shareTarget) { }

	// RVA: 0x6CF6779928 Offset: 0x1722928 VA: 0x6CF6779928
	public virtual IAsyncResult BeginInvoke(ShareResult result, string shareTarget, AsyncCallback callback, object object) { }

	// RVA: 0x6CF67799BC Offset: 0x17229BC VA: 0x6CF67799BC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Dll : NativeShare.Runtime.dll
// Namespace: 
public class NativeShare : Object
{
	// Fields

	private static AndroidJavaClass m_ajc; // 0x0
	private static AndroidJavaObject m_context; // 0x8
	private string subject; // 0x10
	private string text; // 0x18
	private string title; // 0x20
	private string url; // 0x28
	private readonly List`1 emailRecipients; // 0x30
	private readonly List`1 targetPackages; // 0x38
	private readonly List`1 targetClasses; // 0x40
	private readonly List`1 files; // 0x48
	private readonly List`1 mimes; // 0x50
	private ShareResultCallback callback; // 0x58

	// Properties

	private static AndroidJavaClass AJC { get; }
	private static AndroidJavaObject Context { get; }

	// Methods

	// RVA: 0x6CF6777D38 Offset: 0x1720D38 VA: 0x6CF6777D38
	private static AndroidJavaClass get_AJC() { }

	// RVA: 0x6CF6777DDC Offset: 0x1720DDC VA: 0x6CF6777DDC
	private static AndroidJavaObject get_Context() { }

	// RVA: 0x6CF6777FF4 Offset: 0x1720FF4 VA: 0x6CF6777FF4
	public NativeShare SetSubject(string subject) { }

	// RVA: 0x6CF6778060 Offset: 0x1721060 VA: 0x6CF6778060
	public NativeShare SetText(string text) { }

	// RVA: 0x6CF67780CC Offset: 0x17210CC VA: 0x6CF67780CC
	public NativeShare SetUrl(string url) { }

	// RVA: 0x6CF6778138 Offset: 0x1721138 VA: 0x6CF6778138
	public NativeShare SetTitle(string title) { }

	// RVA: 0x6CF67781A4 Offset: 0x17211A4 VA: 0x6CF67781A4
	public NativeShare SetCallback(ShareResultCallback callback) { }

	// RVA: 0x6CF67781AC Offset: 0x17211AC VA: 0x6CF67781AC
	public NativeShare AddTarget(string androidPackageName, string androidClassName) { }

	// RVA: 0x6CF6778364 Offset: 0x1721364 VA: 0x6CF6778364
	public NativeShare AddFile(string filePath, string mime) { }

	// RVA: 0x6CF6778510 Offset: 0x1721510 VA: 0x6CF6778510
	public NativeShare AddFile(Texture2D texture, string createdFileName) { }

	// RVA: 0x6CF6778854 Offset: 0x1721854 VA: 0x6CF6778854
	public NativeShare AddEmailRecipient(string emailAddress) { }

	// RVA: 0x6CF6778934 Offset: 0x1721934 VA: 0x6CF6778934
	public void Share() { }

	// RVA: 0x6CF6778E5C Offset: 0x1721E5C VA: 0x6CF6778E5C
	public static bool TargetExists(string androidPackageName, string androidClassName) { }

	// RVA: 0x6CF6778FDC Offset: 0x1721FDC VA: 0x6CF6778FDC
	public static bool FindTarget(ref string androidPackageName, ref string androidClassName, string packageNameRegex, string classNameRegex) { }

	// RVA: 0x6CF67791DC Offset: 0x17221DC VA: 0x6CF67791DC
	private string GetURLWithScheme() { }

	// RVA: 0x6CF6778DB4 Offset: 0x1721DB4 VA: 0x6CF6778DB4
	private string CombineURLWithText() { }

	// RVA: 0x6CF6778774 Offset: 0x1721774 VA: 0x6CF6778774
	private Byte[] GetTextureBytes(Texture2D texture, bool isJpeg) { }

	// RVA: 0x6CF6779278 Offset: 0x1722278 VA: 0x6CF6779278
	private Byte[] GetTextureBytesFromCopy(Texture2D texture, bool isJpeg) { }

	// RVA: 0x6CF6779770 Offset: 0x1722770 VA: 0x6CF6779770
	public void .ctor() { }

}

// Dll : NativeShare.Runtime.dll
// Namespace: 
private struct MonoScriptData
{
	// Fields

	public Byte[] FilePathsData; // 0x10
	public Byte[] TypesData; // 0x18
	public int TotalTypes; // 0x20
	public int TotalFiles; // 0x24
	public bool IsEditorOnly; // 0x28

	// Properties


	// Methods

}

// Dll : NativeShare.Runtime.dll
// Namespace: 
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF67799C8 Offset: 0x17229C8 VA: 0x6CF67799C8
	private static MonoScriptData Get() { }

	// RVA: 0x6CF6779A88 Offset: 0x1722A88 VA: 0x6CF6779A88
	public void .ctor() { }

}

// Dll : NativeShare.Runtime.dll
// Namespace: 
private sealed class <OnApplicationFocus>d__6 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public bool focus; // 0x20
	public NSCallbackHelper <>4__this; // 0x28

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF6779C94 Offset: 0x1722C94 VA: 0x6CF6779C94
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF6779D3C Offset: 0x1722D3C VA: 0x6CF6779D3C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF6779D40 Offset: 0x1722D40 VA: 0x6CF6779D40
	private bool MoveNext() { }

	// RVA: 0x6CF6779DA8 Offset: 0x1722DA8 VA: 0x6CF6779DA8
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF6779DB0 Offset: 0x1722DB0 VA: 0x6CF6779DB0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF6779DE8 Offset: 0x1722DE8 VA: 0x6CF6779DE8
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : NativeShare.Runtime.dll
// Namespace: NativeShareNamespace
public class NSCallbackHelper : MonoBehaviour
{
	// Fields

	public ShareResultCallback callback; // 0x20
	private ShareResult result; // 0x28
	private string shareTarget; // 0x30
	private bool resultReceived; // 0x38

	// Properties


	// Methods

	// RVA: 0x6CF6779A90 Offset: 0x1722A90 VA: 0x6CF6779A90
	private void Awake() { }

	// RVA: 0x6CF6779AFC Offset: 0x1722AFC VA: 0x6CF6779AFC
	private void Update() { }

	// RVA: 0x6CF6779C20 Offset: 0x1722C20 VA: 0x6CF6779C20
	private IEnumerator OnApplicationFocus(bool focus) { }

	// RVA: 0x6CF6779CBC Offset: 0x1722CBC VA: 0x6CF6779CBC
	public void OnShareCompleted(int resultRaw, string shareTarget) { }

	// RVA: 0x6CF6779D34 Offset: 0x1722D34 VA: 0x6CF6779D34
	public void .ctor() { }

}

// Dll : NativeShare.Runtime.dll
// Namespace: NativeShareNamespace
public class NSShareResultCallbackAndroid : AndroidJavaProxy
{
	// Fields

	private readonly NSCallbackHelper callbackHelper; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF6778CC0 Offset: 0x1721CC0 VA: 0x6CF6778CC0
	public void .ctor(ShareResultCallback callback) { }

	// RVA: 0x6CF6779DF0 Offset: 0x1722DF0 VA: 0x6CF6779DF0
	public void OnShareCompleted(int result, string shareTarget) { }

	// RVA: 0x6CF6779EC8 Offset: 0x1722EC8 VA: 0x6CF6779EC8
	public bool HasManagedCallback() { }

}

// Dll : NativeShare.Runtime.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=113
{
	// Fields


	// Properties


	// Methods

}

// Dll : NativeShare.Runtime.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=188
{
	// Fields


	// Properties


	// Methods

}

// Dll : NativeShare.Runtime.dll
// Namespace: 
internal sealed class <PrivateImplementationDetails> : Object
{
	// Fields

	internal static readonly __StaticArrayInitTypeSize=188 360050D56B8897086F828B4E2353FDEEBBF8FA9BDB588873F7EF245485B896DF; // 0x0
	internal static readonly __StaticArrayInitTypeSize=113 96510F11CF09AC66ABBB502651EAECBA8B3EE989C404C70971CEC7DF7FBF0405; // 0xBC

	// Properties


	// Methods

}

// Dll : UnityEngine.UnityWebRequestWWWModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.UnityWebRequestWWWModule.dll
// Namespace: UnityEngine
public class WWW : CustomYieldInstruction, IDisposable
{
	// Fields

	private UnityWebRequest _uwr; // 0x10

	// Properties

	public string error { get; }
	public bool isDone { get; }
	public string text { get; }
	public Texture2D texture { get; }
	public string url { get; }
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x6CF6B9DDA0 Offset: 0x1B46DA0 VA: 0x6CF6B9DDA0
	public void .ctor(string url) { }

	// RVA: 0x6CF6B9DDE0 Offset: 0x1B46DE0 VA: 0x6CF6B9DDE0
	public string get_error() { }

	// RVA: 0x6CF6B9DEFC Offset: 0x1B46EFC VA: 0x6CF6B9DEFC
	public bool get_isDone() { }

	// RVA: 0x6CF6B9DF18 Offset: 0x1B46F18 VA: 0x6CF6B9DF18
	public string get_text() { }

	// RVA: 0x6CF6B9E08C Offset: 0x1B4708C VA: 0x6CF6B9E08C
	private Texture2D CreateTextureFromDownloadedData(bool markNonReadable) { }

	// RVA: 0x6CF6B9E17C Offset: 0x1B4717C VA: 0x6CF6B9E17C
	public Texture2D get_texture() { }

	// RVA: 0x6CF6B9E184 Offset: 0x1B47184 VA: 0x6CF6B9E184
	public string get_url() { }

	// RVA: 0x6CF6B9E1A0 Offset: 0x1B471A0 VA: 0x6CF6B9E1A0
	public override bool get_keepWaiting() { }

	// RVA: 0x6CF6B9E1CC Offset: 0x1B471CC VA: 0x6CF6B9E1CC
	public void Dispose() { }

	// RVA: 0x6CF6B9DFA8 Offset: 0x1B46FA8 VA: 0x6CF6B9DFA8
	private bool WaitUntilDoneIfPossible() { }

}

// Dll : UnityEngine.AIModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.AIModule.dll
// Namespace: UnityEngine.AI
public sealed class NavMeshAgent : Behaviour
{
	// Fields


	// Properties

	public Vector3 desiredVelocity { get; }
	public bool updatePosition { set; }
	public bool updateRotation { set; }

	// Methods

	// RVA: 0x6CF694BF18 Offset: 0x18F4F18 VA: 0x6CF694BF18
	public bool SetDestination(Vector3 target) { }

	// RVA: 0x6CF694BFB4 Offset: 0x18F4FB4 VA: 0x6CF694BFB4
	public Vector3 get_desiredVelocity() { }

	// RVA: 0x6CF694C054 Offset: 0x18F5054 VA: 0x6CF694C054
	public void set_updatePosition(bool value) { }

	// RVA: 0x6CF694C098 Offset: 0x18F5098 VA: 0x6CF694C098
	public void set_updateRotation(bool value) { }

	// RVA: 0x6CF694BF70 Offset: 0x18F4F70 VA: 0x6CF694BF70
	private bool SetDestination_Injected(ref Vector3 target) { }

	// RVA: 0x6CF694C010 Offset: 0x18F5010 VA: 0x6CF694C010
	private void get_desiredVelocity_Injected(ref Vector3 ret) { }

}

// Dll : UnityEngine.AIModule.dll
// Namespace: 
public sealed class OnNavMeshPreUpdate : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF694C140 Offset: 0x18F5140 VA: 0x6CF694C140
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF694C1C8 Offset: 0x18F51C8 VA: 0x6CF694C1C8
	public virtual void Invoke() { }

}

// Dll : UnityEngine.AIModule.dll
// Namespace: UnityEngine.AI
public static class NavMesh : Object
{
	// Fields

	public static OnNavMeshPreUpdate onPreUpdate; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF694C0DC Offset: 0x18F50DC VA: 0x6CF694C0DC
	private static void Internal_CallOnNavMeshPreUpdate() { }

}

// Dll : UnityEngine.UnityWebRequestTextureModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.UnityWebRequestTextureModule.dll
// Namespace: UnityEngine.Networking
public sealed class DownloadHandlerTexture : DownloadHandler
{
	// Fields

	private NativeArray`1 m_NativeData; // 0x18
	private bool mNonReadable; // 0x28

	// Properties

	public Texture2D texture { get; }

	// Methods

	// RVA: 0x6CF6B9DAC8 Offset: 0x1B46AC8 VA: 0x6CF6B9DAC8
	private static IntPtr Create(DownloadHandlerTexture obj, bool readable) { }

	// RVA: 0x6CF6B9DB0C Offset: 0x1B46B0C VA: 0x6CF6B9DB0C
	private void InternalCreateTexture(bool readable) { }

	// RVA: 0x6CF6B9DB58 Offset: 0x1B46B58 VA: 0x6CF6B9DB58
	public void .ctor(bool readable) { }

	// RVA: 0x6CF6B9DBB8 Offset: 0x1B46BB8 VA: 0x6CF6B9DBB8
	protected override NativeArray`1 GetNativeData() { }

	// RVA: 0x6CF6B9DBC4 Offset: 0x1B46BC4 VA: 0x6CF6B9DBC4
	public override void Dispose() { }

	// RVA: 0x6CF6B9DBE8 Offset: 0x1B46BE8 VA: 0x6CF6B9DBE8
	public Texture2D get_texture() { }

	// RVA: 0x6CF6B9DC24 Offset: 0x1B46C24 VA: 0x6CF6B9DC24
	private Texture2D InternalGetTextureNative() { }

	// RVA: 0x6CF6B9DC60 Offset: 0x1B46C60 VA: 0x6CF6B9DC60
	public static Texture2D GetContent(UnityWebRequest www) { }

}

// Dll : UnityEngine.UnityWebRequestTextureModule.dll
// Namespace: UnityEngine.Networking
public static class UnityWebRequestTexture : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6B9DCDC Offset: 0x1B46CDC VA: 0x6CF6B9DCDC
	public static UnityWebRequest GetTexture(string uri) { }

	// RVA: 0x6CF6B9DCE4 Offset: 0x1B46CE4 VA: 0x6CF6B9DCE4
	public static UnityWebRequest GetTexture(string uri, bool nonReadable) { }

}

// Dll : UnityEngine.ImageConversionModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.ImageConversionModule.dll
// Namespace: UnityEngine
public static class ImageConversion : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69A212C Offset: 0x194B12C VA: 0x6CF69A212C
	public static Byte[] EncodeToPNG(Texture2D tex) { }

	// RVA: 0x6CF69A2168 Offset: 0x194B168 VA: 0x6CF69A2168
	public static Byte[] EncodeToJPG(Texture2D tex, int quality) { }

	// RVA: 0x6CF69A21AC Offset: 0x194B1AC VA: 0x6CF69A21AC
	public static bool LoadImage(Texture2D tex, Byte[] data, bool markNonReadable) { }

}

// Dll : UnityEngine.JSONSerializeModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.JSONSerializeModule.dll
// Namespace: UnityEngine
public static class JsonUtility : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69CC168 Offset: 0x1975168 VA: 0x6CF69CC168
	private static object FromJsonInternal(string json, object objectToOverwrite, Type type) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static T FromJson(string json) { }

	// RVA: 0x6CF69CC1BC Offset: 0x19751BC VA: 0x6CF69CC1BC
	public static object FromJson(string json, Type type) { }

}

// Dll : UnityEngine.TilemapModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.TilemapModule.dll
// Namespace: UnityEngine.Tilemaps
public sealed class Tilemap : GridLayout
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.TilemapModule.dll
// Namespace: UnityEngine.Tilemaps
public sealed class TilemapRenderer : Renderer
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.GridModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.GridModule.dll
// Namespace: UnityEngine
public class GridLayout : Behaviour
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.SpriteShapeModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.SpriteShapeModule.dll
// Namespace: UnityEngine.U2D
public class SpriteShapeRenderer : Renderer
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.Configuration.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.Configuration.dll
// Namespace: System.Configuration
public abstract class ConfigurationElement : Object
{
	// Fields


	// Properties

	protected internal virtual ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x6CF67A8E18 Offset: 0x1751E18 VA: 0x6CF67A8E18
	protected internal virtual ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x6CF67A8E50 Offset: 0x1751E50 VA: 0x6CF67A8E50
	protected internal virtual void DeserializeElement(XmlReader reader, bool serializeCollectionKey) { }

	// RVA: 0x6CF67A8E88 Offset: 0x1751E88 VA: 0x6CF67A8E88
	protected internal virtual void InitializeDefault() { }

	// RVA: 0x6CF67A8EC0 Offset: 0x1751EC0 VA: 0x6CF67A8EC0
	protected internal virtual bool IsModified() { }

	// RVA: 0x6CF67A8EF8 Offset: 0x1751EF8 VA: 0x6CF67A8EF8
	protected virtual void PostDeserialize() { }

	// RVA: 0x6CF67A8F30 Offset: 0x1751F30 VA: 0x6CF67A8F30
	protected internal virtual void Reset(ConfigurationElement parentElement) { }

	// RVA: 0x6CF67A8F68 Offset: 0x1751F68 VA: 0x6CF67A8F68
	protected internal virtual void ResetModified() { }

}

// Dll : System.Configuration.dll
// Namespace: System.Configuration
public sealed class Configuration : Object
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.Configuration.dll
// Namespace: System.Configuration
public abstract class ConfigurationSection : ConfigurationElement
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF67A8FA0 Offset: 0x1751FA0 VA: 0x6CF67A8FA0
	protected internal virtual void DeserializeSection(XmlReader reader) { }

	// RVA: 0x6CF67A8FD8 Offset: 0x1751FD8 VA: 0x6CF67A8FD8
	protected internal override bool IsModified() { }

	// RVA: 0x6CF67A9010 Offset: 0x1752010 VA: 0x6CF67A9010
	protected internal override void ResetModified() { }

	// RVA: 0x6CF67A9048 Offset: 0x1752048 VA: 0x6CF67A9048
	protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) { }

}

// Dll : System.Configuration.dll
// Namespace: System.Configuration
public enum ConfigurationSaveMode
{
	// Fields

	public int value__; // 0x10
	public const ConfigurationSaveMode Full = 2; // 0x0
	public const ConfigurationSaveMode Minimal = 1; // 0x0
	public const ConfigurationSaveMode Modified = 0; // 0x0

	// Properties


	// Methods

}

// Dll : System.Configuration.dll
// Namespace: System.Configuration
public class ConfigurationPropertyCollection : Object
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.Configuration.dll
// Namespace: System.Configuration
public abstract class ConfigurationElementCollection : ConfigurationElement
{
	// Fields


	// Properties

	protected virtual bool ThrowOnDuplicate { get; }

	// Methods

	// RVA: 0x6CF67A9080 Offset: 0x1752080 VA: 0x6CF67A9080
	protected virtual bool get_ThrowOnDuplicate() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	protected abstract ConfigurationElement CreateNewElement() { }

	// RVA: 0x6CF5BD6D7C Offset: 0xB7FD7C VA: 0x6CF5BD6D7C
	protected abstract object GetElementKey(ConfigurationElement element) { }

}

// Dll : System.Configuration.dll
// Namespace: System.Configuration
public sealed class ConfigurationCollectionAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF67A90B8 Offset: 0x17520B8 VA: 0x6CF67A90B8
	public void .ctor(Type itemType) { }

}

// Dll : System.Configuration.dll
// Namespace: System.Configuration
public class ConfigurationSectionGroup : Object
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.Configuration.dll
// Namespace: System.Configuration
public sealed class IgnoreSection : ConfigurationSection
{
	// Fields


	// Properties

	protected internal override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x6CF67A90BC Offset: 0x17520BC VA: 0x6CF67A90BC
	public void .ctor() { }

	// RVA: 0x6CF67A90F4 Offset: 0x17520F4 VA: 0x6CF67A90F4
	protected internal override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x6CF67A912C Offset: 0x175212C VA: 0x6CF67A912C
	protected internal override void DeserializeSection(XmlReader xmlReader) { }

	// RVA: 0x6CF67A9164 Offset: 0x1752164 VA: 0x6CF67A9164
	protected internal override bool IsModified() { }

	// RVA: 0x6CF67A919C Offset: 0x175219C VA: 0x6CF67A919C
	protected internal override void Reset(ConfigurationElement parentSection) { }

	// RVA: 0x6CF67A91D4 Offset: 0x17521D4 VA: 0x6CF67A91D4
	protected internal override void ResetModified() { }

	// RVA: 0x6CF67A920C Offset: 0x175220C VA: 0x6CF67A920C
	protected internal override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode) { }

}

// Dll : System.Configuration.dll
// Namespace: Unity
internal sealed class ThrowStub : ObjectDisposedException
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF67A9244 Offset: 0x1752244 VA: 0x6CF67A9244
	public static void ThrowNotSupportedException() { }

}

// Dll : __Generated
// Namespace: 
internal interface IActivationFactory : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public override object ActivateInstance() { }

}

// Dll : __Generated
// Namespace: System
internal class __Il2CppComObject : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6B9E1F0 Offset: 0x1B471F0 VA: 0x6CF6B9E1F0
	protected override void Finalize() { }

}

// Dll : __Generated
// Namespace: System
internal sealed class __Il2CppComDelegate : __Il2CppComObject
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6B9E22C Offset: 0x1B4722C VA: 0x6CF6B9E22C
	protected override void Finalize() { }

}

// Dll : __Generated
// Namespace: Unity.IL2CPP.Metadata
internal abstract class __Il2CppFullySharedGenericType : ValueType
{
	// Fields


	// Properties


	// Methods

}

// Dll : __Generated
// Namespace: Unity.IL2CPP.Metadata
internal abstract struct __Il2CppFullySharedGenericStructType
{
	// Fields


	// Properties


	// Methods

}
