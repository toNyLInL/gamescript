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
        public int repeat_num { get; set; }
        /// <summary>
        /// 吃苹果种类
        /// </summary>
        public int apple { get; set; }
        /// <summary>
        /// 助战角色
        /// </summary>
        public string character { get; set; }
        /// <summary>
        /// 助战礼装
        /// </summary>
        public string equipment { get; set; }
        /// <summary>
        /// 选完角色等待时间-进本加载
        /// </summary>
        public int wait_time { get; set; }
        /// <summary>
        /// 延迟时间
        /// </summary>
        public int delay_time { get; set; }
        /// <summary>
        /// 战斗面数
        /// </summary>
        public int fight_turn { get; set; }
        /// <summary>
        /// 战斗面数与三连后等待时间
        /// </summary>
        public List<int> side_wait_time { get; set; }
        /// <summary>
        /// 在第x面换人
        /// </summary>
        public int change_character { get; set; }
        /// <summary>
        /// 模拟器窗口名称
        /// </summary>
        public string emulator_name { get; set; }
        /// <summary>
        /// 使用随机时间 1=true,0=false
        /// </summary>
        public int use_rand_time { get; set; }
        /// <summary>
        /// 战斗文件
        /// </summary>
        public string fight { get; set; }
        /// <summary>
        /// 提前补刀
        /// </summary>
        public int attack_in_advance { get; set; }

    }
}
