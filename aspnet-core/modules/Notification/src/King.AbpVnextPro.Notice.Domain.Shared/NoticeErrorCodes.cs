namespace King.AbpVnextPro.Notice;

public static class NoticeErrorCodes
{
    //Add your business exception error codes here...
    private const string GroupName = "NotificationHub";
    /* You can add your business exception error codes here, as constants */
    public const string ReceiverNotNull = GroupName + ":100001";
    public const string MessageNotExist = GroupName + ":100002";
    public const string MessageTypeUnknown = GroupName + ":100003";
    public const string UserUnSubscription = GroupName + ":100004";
    public const string MessageTitle = GroupName + ":100005";
    public const string MessageContent = GroupName + ":100006";
}
