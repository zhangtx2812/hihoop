using System.ComponentModel;

namespace HiHoop
{
    public enum CallServiceType
    {
        [Description("茶水")]
        Tea = 1,

        [Description("麦克风")]
        MicroPhone = 2,

        [Description("纸笔")]
        Pen = 3,

        [Description("人员")]
        Personel = 4,

        [Description("换座位")]
        Change = 5
    }

    public enum MememberStates
    {
        [Description("离开")]
        leave,
        [Description("会议中")]
        Meeting,
        [Description("分享中")]
        Sharing,
        [Description("已升起")]
        UpScreem,
        [Description("已下降")]
        DownScreem
    }

    public enum VoteFirstDone
    {
        [Description("第一次有效")]
        First = 1,
        [Description("最后一次有效")]
        Last = 0
    }

    public enum SignIn
    {
        [Description("签到")]
        go = 1,
        [Description("不签到")]
        undo = 0
    }

    public enum MeetingState
    {
        [Description("结束")]
        end = 1,
        [Description("准备中")]
        prepare = 0,
        [Description("开始")]
        start = -1
    }

    public enum VoteState
    { 
        [Description("准备中")]
        prepare = 0,
        [Description("开始")]
        start = 1,
        [Description("结束")]
        end = 2
    }
}