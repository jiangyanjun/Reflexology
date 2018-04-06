using Foot.Client.Base;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static Foot.Client.MyMsgBox;

namespace Foot.Client
{
    internal class Msg
    {
        #region 弹出框封装
        /// <summary>
        /// 显示操作成功消息框
        /// </summary>
        /// <param name="pMsg">消息内容</param>
        /// <returns></returns>
        public static System.Windows.Forms.DialogResult ShowOkMsg(string pMsg)
        {
            // LogHelper.LogWrite(pMsg);
            //return MyMsgBox.Show(pMsg, "提示信息", MyButtons.OK, MyIcon.Information);
            return MessageBox.Show(pMsg, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        ///  显示操作错误消息框
        /// </summary>
        /// <param name="pMsg">消息内容</param>
        /// <returns></returns>
        public static System.Windows.Forms.DialogResult ShowErrorMsg(string pMsg)
        {
            DialogResult result = DialogResult.OK;
            using (BackgroundWorker worker = new BackgroundWorker())
            {
                worker.RunWorkerCompleted += delegate (object sender, RunWorkerCompletedEventArgs e)
                {
                    // LogHelper.LogWrite(pMsg);
                    result = MessageBox.Show(pMsg, "出错信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //result = MyMsgBox.Show(pMsg, "出错信息", MyButtons.OK,MyIcon.Error);
                };
                worker.RunWorkerAsync();
            }
            return result;
        }
        public static System.Windows.Forms.DialogResult ShowErrorMsg(Exception ex, string pMsg)
        {
            //LogHelper.LogWrite(string.Format("{2} Exception:{0}，StackTrace:{1}", ex.ToString(), ex.StackTrace, pMsg));
            return MessageBox.Show(string.Format("{2} Exception:{0}，StackTrace:{1}", ex.ToString(), ex.StackTrace, pMsg), "出错信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //return MyMsgBox.Show(string.Format("{2} Exception:{0}，StackTrace:{1}", ex.ToString(), ex.StackTrace, pMsg), "出错信息", MyButtons.OK,MyIcon.Error);
        }
        /// <summary>
        ///  显示操作错误消息框
        /// </summary>
        /// <param name="pMsg">消息内容</param>
        /// <returns></returns>
        public static System.Windows.Forms.DialogResult ShowErrorMsg(Exception ex, [CallerMemberName] string memberName = null, [CallerFilePath] string path = null, [CallerLineNumber] int line = 0)
        {
            // LogHelper.LogWrite(string.Format("Exception:{0}，StackTrace:{1}", ex.ToString(), ex.StackTrace));
            return MessageBox.Show(string.Format("{2} Exception:{0}，StackTrace:{1}", ex.ToString(), ex.StackTrace, string.Format("{0},{1},{2}", path, memberName, line)), "出错信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // return MyMsgBox.Show(string.Format("Exception:{0}，StackTrace:{1}", ex.ToString(), ex.StackTrace), "出错信息", MyButtons.OK,MyIcon.Error);
        }
        /// <summary>
        /// 显示一个YesNo选择对话确认框
        /// </summary>
        /// <param name="pMsg"></param>
        /// <returns></returns>
        public static System.Windows.Forms.DialogResult ShowConfirmMsg(string pMsg)
        {
            return MessageBox.Show(pMsg, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //return MyMsgBox.Show(pMsg, "确认", MyMsgBox.MyButtons.YesNo, MyMsgBox.MyIcon.Question);
            //return MyMsgBox.Show(pMsg, "确认", MyButtons.YesNo,MyIcon.Question);
        }
        #endregion

        /// <summary>
        /// 后台异步运行代码
        /// </summary>
        /// <param name="doWork">需要异步执行方法委托</param>
        /// <param name="runWorkerCompleted">异步执行完成后的方法委托</param>
        public static void RunInBackground(DoWorkEventHandler doWork, RunWorkerCompletedEventHandler runWorkerCompleted)
        {
            var loadingFrm = new LoadingFrm();
            using (var worker = new BackgroundWorker())
            {
                worker.DoWork += doWork;
                worker.RunWorkerCompleted += delegate (object obj, RunWorkerCompletedEventArgs env)
                {
                    loadingFrm.Close();//关闭等待窗口
                };
                worker.RunWorkerCompleted += runWorkerCompleted;
                worker.RunWorkerAsync();//执行异步线程
                loadingFrm.ShowDialog();//打开等待窗口
            }
        }


    }
}
