using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesReplica_Self_motion._Uilitily
{
    public class _EncryptAndDecode
    {
        private static string MinYao
        {
            get
            { return "mh*#$_6715yl"; }
        }

        //========加密========#region ========加密========
        /// <summary>
        /// 加密数据
        /// </summary>
        /// <param name="text">要加密的文本</param>
        /// <param name="key">密钥</param>
        /// <returns></returns>
        public static string Encrypt(string text)
        {
            try
            {
                if (!string.IsNullOrEmpty(text))
                {
                    string s = MuHuaJiaMi.EncryptUtil.Encrypt3DES(text, MinYao);
                    if (!string.IsNullOrEmpty(s))
                    {
                        return s;
                    }
                }
            }
            catch (Exception)
            {
            }
            return "";
        }

        //========解密========#region ========解密========

        /// <summary>
        /// 解密数据
        /// </summary>
        /// <param name="text">解密文本</param>
        /// <param name="sKey">解密密钥</param>
        /// <returns></returns>
        public static string Decrypt(string text)
        {
            try
            {
                if (text != "Q+8xeg03WHQ=")
                {
                    string s = MuHuaJiaMi.EncryptUtil.Decrypt3DES(text, MinYao);
                    if (!string.IsNullOrEmpty(s))
                    {
                        return s;
                    }
                }
            }
            catch (Exception)
            {
            }
            return "";
        }
    }
}
