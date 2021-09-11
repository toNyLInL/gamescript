using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Numerics;
using System.ComponentModel;

namespace WpfFileEdit.Model
{
    public class JsonModel
    {

    }

    public class BattleConfig : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 重复刷本次数
        /// </summary>
        public int Repeat_Num { get; set; }
        /// <summary>
        /// 吃苹果种类
        /// </summary>
        public int AppleType { get; set; }
        /// <summary>
        /// 助战角色
        /// </summary>
        public string Character { get; set; }
        /// <summary>
        /// 助战礼装
        /// </summary>
        public string CraftEssense { get; set; }
        /// <summary>
        /// 模拟器窗口名称
        /// </summary>
        public string Emulator_Name { get; set; }
        /// <summary>
        /// 选完角色等待时间-进本加载
        /// </summary>
        public int WaitTime { get; set; }

        public bool UseRandomTime;
        /// <summary>
        /// 延迟时间
        /// </summary>
        public int DelayTime { get; set; }
        /// <summary>
        /// 战斗面数
        /// </summary>
        public int BattleCount { get; set; }
        /// <summary>
        /// 每面
        /// </summary>
        public List<int> RoundTime { get; set; }

    }
}
