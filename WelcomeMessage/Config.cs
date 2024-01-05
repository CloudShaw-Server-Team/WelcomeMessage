using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeMessage
{
    public class Config
    {
        [Description("启用日志模式")]
        public bool Logs { get; set; } = true;
        [Description("消息的时长")]
        public byte MessageSeconds { get; set; } = 5;
        [Description("消息的内容")]
        public string MessageText { get; set; } = "<size=30><b><color={color}>{name}</color> 欢迎进入服务器</b></size>";
    }
}
