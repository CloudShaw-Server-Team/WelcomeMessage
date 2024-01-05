using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Events;
using PluginAPI.Enums;
using FormatWith;

namespace WelcomeMessage
{
    public class Plugin
    {
        [PluginConfig]
        public Config Config;
        [PluginEntryPoint("WelcomeMessage", "1.0.0", "在玩家进入游戏时显示欢迎信息", "CloudShaw")]
        public void LoadPlugin()
        {
            EventManager.RegisterEvents(this);
            if (Config.Logs)
            {
                Log.Info("已启用日志模式");
            }
        }
        [PluginEvent(ServerEventType.PlayerJoined)]
        public void OnPlayerJoin(Player player)
        {
            string color;
            switch (player.RoleColor)
            {
                case "pink":
                    color = "#FF96DE";
                    break;
                case "red":
                    color = "#C50000";
                    break;
                case "brown":
                    color = "#944710";
                    break;
                case "silver":
                    color = "#A0A0A0";
                    break;
                case "light_green":
                    color = "#32CD32";
                    break;
                case "crimson":
                    color = "#DC143C";
                    break;
                case "cyan":
                    color = "#00B7EB";
                    break;
                case "aqua":
                    color = "#00FFFF";
                    break;
                case "deep_pink":
                    color = "#FF1493";
                    break;
                case "tomato":
                    color = "#FF6448";
                    break;
                case "yellow":
                    color = "#FAFF86";
                    break;
                case "magenta":
                    color = "#FF0090";
                    break;
                case "blue_green":
                    color = "#4DFFB8";
                    break;
                case "orange":
                    color = "#FF9966";
                    break;
                case "lime":
                    color = "#BFFF00";
                    break;
                case "green":
                    color = "#228B22";
                    break;
                case "emerald":
                    color = "#50C878";
                    break;
                case "carmine":
                    color = "#960018";
                    break;
                case "nickel":
                    color = "#727472";
                    break;
                case "mint":
                    color = "#98FB98";
                    break;
                case "army_green":
                    color = "#4B5320";
                    break;
                case "pumpkin":
                    color = "#EE7600";
                    break;
                default:
                    color = "white";
                    break;
            }
            player.SendBroadcast(Config.MessageText.FormatWith(new
            {
                name = player.Nickname,
                color = color,
            }), Config.MessageSeconds);
            if (Config.Logs)
            {
                Log.Debug(player.Nickname + "显示欢迎消息");
            }
        }
    }
}