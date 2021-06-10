using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesReplica_Self_motion._Uilitily
{
    public class _AppConfigAccess
    {
        private static Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);


        /// <summary>
        /// 获取指定节点的值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetAppSetting(string key)
        {
            if (ConfigurationManager.AppSettings.AllKeys.Contains(key))
            {
                string value = config.AppSettings.Settings[key].Value;
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 增加一个appsetting节点
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static bool SetAppSetting(string key, string value)
        {
            try
            {
                if (!ConfigurationManager.AppSettings.AllKeys.Contains(key))
                {
                    //如果不 存在就增加一个节点
                    config.AppSettings.Settings.Add(key, value);
                    config.Save(ConfigurationSaveMode.Modified);
                }
                else
                { //如果当前节点存在，则更新当前节点
                    config.AppSettings.Settings[key].Value = value;
                    config.Save(ConfigurationSaveMode.Modified);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        /// <summary>
        /// 删除appsetting节点
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void DeleteAppSettings(string key, string value)
        {
            if (ConfigurationManager.AppSettings.AllKeys.Contains(key))
            {
                //如果当前节点存在，则删除当前节点
                config.AppSettings.Settings.Remove(key);
                config.Save(ConfigurationSaveMode.Modified);
            }
        }
    }
}
