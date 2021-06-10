using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilesReplica_Self_motion
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Process[] name = Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName);
            if (name.Length > 1)
            {
                ShowWindowAsync(name[0].MainWindowHandle, WS_SHOWNORMAL);
                SetForegroundWindow(name[0].MainWindowHandle);
            }
            else
            {
                Application.Run(new MainForm());
            }
        }

        #region ��ֹϵͳ�ظ�����

        /// <summary>
        /// �ú��������ɲ�ͬ�̲߳����Ĵ��ڵ���ʾ״̬��
        /// </summary>
        /// <param name="hWnd">���ھ��</param>
        /// <param name="cmdShow">ָ�����������ʾ���鿴����ֵ�б������ShowWlndow������˵�����֡�</param>
        /// <returns>�������ԭ���ɼ�������ֵΪ���㣻�������ԭ�������أ�����ֵΪ�㡣</returns>
        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        /// <summary>
        /// �ú���������ָ�����ڵ��߳����õ�ǰ̨�����Ҽ���ô��ڡ���������ת��ô��ڣ���Ϊ�û��ĸ��ֿ��ӵļǺš�ϵͳ������ǰ̨���ڵ��̷߳����Ȩ���Ը��������̡߳�
        /// </summary>
        /// <param name="hWnd">�������������ǰ̨�Ĵ��ھ����</param>
        /// <returns>�������������ǰ̨������ֵΪ���㣻�������δ������ǰ̨������ֵΪ�㡣</returns>
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        private const int WS_SHOWNORMAL = 1;

        #endregion
    }
}
