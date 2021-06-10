using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilesReplica_Self_motion._Uilitily
{
    public class _ComputerInformation
    {
        #region   基础参数

        #region  0-获取电脑硬件的编号
        //CPU的参数
        private const string _CPUPara = "Win32_Processor";
        private const string _CPUIDPara = "ProcessorId";

        //主板参数
        private const string _MainBoardPara = "Win32_BaseBoard";
        private const string _MainBoardIDPara = "SerialNumber";

        //硬盘参数
        private const string _HardDiskPara = "Win32_PhysicalMedia";
        private const string _HardDiskIDPara = "SerialNumber";

        //BIOS参数
        private const string _BiosPara = "Win32_BIOS";
        private const string _BiosIDPara = "SerialNumber";

        #endregion

        #region   1-获取到电脑其他信息

        //系统名称
        private const string _SystemNamePara = "Win32_OperatingSystem";
        private const string _SystemName = "Name";

        //CPU名称
        private const string _CPUName = "Name";
        private const string _CPUAllPara = "Select * from Win32_Processor";
        private const string _CPUCoreNum = "NumberOfCores";

        #endregion

        #endregion



        #region   公有方法

        #region  0-获取电脑硬件的编号
        /// <summary>
        /// 获取到CPU编号
        /// </summary>
        /// <returns>返回当前电脑的CPU编号</returns>
        public static string GetCPUID()
        {
            try
            {
                string strID = null;

                ManagementClass mc = new ManagementClass(_CPUPara);
                ManagementObjectCollection moc = mc.GetInstances();

                foreach (ManagementObject mo in moc)
                {
                    strID = mo.Properties[_CPUIDPara].Value.ToString();
                    break;
                }

                return strID;
            }
            catch (Exception e)
            {

                return "";
            }

        }

        /// <summary>
        /// 获取到主板的编号
        /// </summary>
        /// <returns>返回当前电脑主板的编号</returns>
        public static string GetMainBoardID()
        {
            try
            {
                string strID = null;
                ManagementClass mc = new ManagementClass(_MainBoardPara);
                ManagementObjectCollection moc = mc.GetInstances();

                foreach (ManagementObject mo in moc)
                {
                    strID = mo.Properties[_MainBoardIDPara].Value.ToString();
                    break;
                }

                return strID;
            }
            catch (Exception)
            {
                return "";
            }

        }

        /// <summary>
        /// 获取到硬盘的编号
        /// </summary>
        /// <returns>返回当前电脑硬盘的编号</returns>
        public static string GetHardDiskID()
        {
            try
            {
                string strID = null;

                ManagementClass mc = new ManagementClass(_HardDiskPara);
                ManagementObjectCollection moc = mc.GetInstances();

                foreach (ManagementObject mo in moc)
                {
                    strID = mo.Properties[_HardDiskIDPara].Value.ToString();
                    break;
                }
                return strID;
            }
            catch (Exception)
            {
                return "";
            }

        }

        /// <summary>
        /// 获取到Bios的编号
        /// </summary>
        /// <returns>返回当前电脑Bios的编号</returns>
        public static string GetBiosID()
        {
            try
            {
                string strID = null;

                ManagementClass mc = new ManagementClass(_BiosPara);
                ManagementObjectCollection moc = mc.GetInstances();

                foreach (ManagementObject mo in moc)
                {
                    strID = mo.Properties[_BiosIDPara].Value.ToString();
                    break;
                }

                return strID;
            }
            catch (Exception)
            {
                return "";
            }

        }



        #endregion

        #region   1-获取到电脑其他信息

        /// <summary>
        /// 获取到系统名称
        /// </summary>
        /// <returns>返回当前电脑系统的名称</returns>
        public static string GetSystemName()
        {
            try
            {
                string str = null;

                ManagementClass manag = new ManagementClass(_SystemNamePara);
                ManagementObjectCollection managCollection = manag.GetInstances();
                foreach (ManagementObject m in managCollection)
                {
                    str = m[_SystemName].ToString();
                    break;
                }

                return str;

            }
            catch (Exception)
            {
                return "";
            }

        }

        /// <summary>
        /// 获取到CPU的名称
        /// </summary>
        /// <returns>返回当前电脑CPU的名称</returns>
        public static string GetCPUName()
        {
            try
            {
                string str = null;
                ManagementClass mcCPU = new ManagementClass(_CPUPara);
                ManagementObjectCollection mocCPU = mcCPU.GetInstances();
                foreach (ManagementObject m in mocCPU)
                {
                    str = m[_CPUName].ToString();
                    break;
                }

                return str;
            }
            catch (Exception)
            {
                return "";
            }

        }

        /// <summary>
        /// 获取到当前CPU的核心数量
        /// </summary>
        /// <returns>返回当前电脑CPU的核心数量</returns>
        public static int GetCPUNumber()
        {
            try
            {
                int coreCount = 0;

                foreach (var item in new System.Management.ManagementObjectSearcher(_CPUAllPara).Get())
                {
                    coreCount += int.Parse(item[_CPUCoreNum].ToString());
                }

                return coreCount;
            }
            catch (Exception)
            {
                return default;
            }

        }

        /// <summary>
        /// 获取到系统的内存(GB)
        /// </summary>
        /// <returns>返回当前电脑内存的大小</returns>
        public static float GetSystemMemorySizeOfGB()
        {
            try
            {
                float size = 0;

                ManagementObjectSearcher searcher = new ManagementObjectSearcher();   //用于查询一些如系统信息的管理对象
                searcher.Query = new SelectQuery("Win32_PhysicalMemory", "", new string[] { "Capacity" });//设置查询条件
                ManagementObjectCollection collection = searcher.Get();   //获取内存容量 
                ManagementObjectCollection.ManagementObjectEnumerator em = collection.GetEnumerator();
                long capacity = 0;
                while (em.MoveNext())
                {
                    ManagementBaseObject baseObj = em.Current;
                    if (baseObj.Properties["Capacity"].Value != null)
                    {
                        capacity += long.Parse(baseObj.Properties["Capacity"].Value.ToString());
                    }
                }
                size = (capacity / 1024 / 1024 / 1024);

                return size;
            }
            catch (Exception)
            {
                return default;
            }

        }

        /// <summary>
        /// 获取到硬盘的存储空间(总空间、剩余空间(GB))
        /// </summary>
        /// <returns>返回当前电脑的硬盘存储空间</returns>
        public static float[] GetHardDiskSpace()
        {
            try
            {
                float[] Space = new float[2];
                System.IO.DriveInfo[] drives = System.IO.DriveInfo.GetDrives();
                long totalFreeSpace = 0;
                long totalDiskSize = 0;
                foreach (var drive in drives)
                {
                    if (drive.IsReady)  //判断代码运行时 磁盘是可操作作态 
                    {
                        totalFreeSpace += drive.AvailableFreeSpace;
                        totalDiskSize += drive.TotalSize;
                    }
                }

                //总空间(单位：GB)
                float totalSpace = totalDiskSize / 1024 / 1024 / 1024;
                //剩余空间(单位:GB)
                float surplusSpce = totalFreeSpace / 1024 / 1024 / 1024;

                Space[0] = totalSpace;
                Space[1] = surplusSpce;

                return Space;
            }
            catch (Exception)
            {
                return default;
            }


        }

        /// <summary>
        /// 获取到屏幕分辩率
        /// </summary>
        /// <returns>返回当前电脑屏幕的分辩率（宽*高）</returns>
        public static int[] GetScreenSize()
        {
            try
            {
                int[] sceeenSize = new int[2];

                int width = Screen.PrimaryScreen.Bounds.Width;
                int height = Screen.PrimaryScreen.Bounds.Height;

                sceeenSize[0] = width;
                sceeenSize[1] = height;

                return sceeenSize;
            }
            catch (Exception)
            {
                return default;
            }

        }

        /// <summary>
        /// 获取到GPU的名称
        /// </summary>
        /// <returns>返回当前电脑的GPU名称</returns>
        public static string GetGPUName()
        {
            try
            {
                string str = null;
                ManagementClass manage = new ManagementClass("Win32_VideoController");
                ManagementObjectCollection manageCollection = manage.GetInstances();
                foreach (ManagementObject m in manageCollection)
                {
                    str = m["VideoProcessor"].ToString().Replace("Family", "");
                    break;
                }

                return str;
            }
            catch (Exception)
            {
                return "";
            }

        }

        /// <summary>
        ///获取到GPU的显存大小(单位：GB)
        /// </summary>
        /// <returns>返回当前电脑的GPU显存大小</returns>
        public static float GetGPUMemorySize()
        {
            try
            {
                float size = 0;
                ManagementClass manage = new ManagementClass("Win32_VideoController");
                ManagementObjectCollection manageCollection = manage.GetInstances();
                foreach (ManagementObject m in manageCollection)
                {
                    size = (Convert.ToInt64(m["AdapterRAM"]) / 1024 / 1024 / 1024);
                    break;
                }

                return size;
            }
            catch (Exception)
            {
                return default;
            }

        }

        #endregion

        #endregion
    }
}
