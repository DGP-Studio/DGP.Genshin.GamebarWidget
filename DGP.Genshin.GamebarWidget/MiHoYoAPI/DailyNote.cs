using Newtonsoft.Json;
using System;

namespace DGP.Genshin.GamebarWidget.MiHoYoAPI
{
    public class DailyNote
    {
        /// <summary>
        /// 当前树脂
        /// </summary>
        [JsonProperty("current_resin")] public int CurrentResin { get; set; }
        /// <summary>
        /// 最大树脂
        /// </summary>
        [JsonProperty("max_resin")] public int MaxResin { get; set; }
        /// <summary>
        /// 树脂恢复时间<see cref="string"/>类型的秒数
        /// </summary>
        [JsonProperty("resin_recovery_time")] public string ResinRecoveryTime { get; set; }

        public string ResinFormatted
        {
            get
            {
                return $"{CurrentResin} / {MaxResin}";
            }
        }

        public string ResinRecoveryTargetTimeFormatted
        {
            get
            {
                if (ResinRecoveryTime != null)
                {
                    DateTime tt = DateTime.Now.AddSeconds(int.Parse(ResinRecoveryTime));
                    int totalDays = (tt - DateTime.Today).Days;
                    string day;
                    switch (totalDays)
                    {
                        case 0: 
                            day = "今天"; 
                            break;
                        case 1: 
                            day = "明天"; 
                            break;
                        case 2: 
                            day = "后天"; 
                            break;
                        default: 
                            day = $"{totalDays}天"; 
                            break;
                    };
                    return $"将于 {day} {tt:HH:mm} 完全恢复";
                }
                return null;
            }
        }
    }
}
