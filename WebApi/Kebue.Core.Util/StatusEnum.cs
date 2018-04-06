using System.ComponentModel;

namespace Kebue.Core.Util
{

    public enum StatusEnum
    {
        /// <summary>
        /// 有效状态
        /// </summary>
        [Description("有效状态")]
        True = 1,
        /// <summary>
        /// 无效状态
        /// </summary>
        [Description("无效状态")]
        False = 2,
        /// <summary>
        /// 正常
        /// </summary>
        [Description("正常")]
        Normal = 3,
        /// <summary>
        /// 已预订
        /// </summary>
        [Description("已预订")]
        Reserved = 4,
        /// <summary>
        /// 使用中
        /// </summary>
        [Description("使用中")]
        Using = 5,
        /// <summary>
        /// 清扫中
        /// </summary>
        [Description("环境卫生清洁中")]
        Clean = 6,
        /// <summary>
        /// 故障
        /// </summary>
        [Description("故障")]
        Malfunction = 7,

        /// <summary>
        /// 故障
        /// </summary>
        [Description("未知")]
        Unknown = 8,
    }
}
