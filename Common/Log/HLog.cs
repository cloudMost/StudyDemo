using System;
using System.IO;
using System.Reflection;
using log4net;
using Common.Enum;

namespace Common.Log
{
    public class HLog
    {
        #region 全局设置
        public static void Init()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var xml = assembly.GetManifestResourceStream("Common.Log.Default.config");
            log4net.Config.XmlConfigurator.Configure(xml);
        }

        public static void Init(string path)
        {
            log4net.Config.XmlConfigurator.Configure(new FileInfo(path));
        }

        public static void Init(Stream xml)
        {
            log4net.Config.XmlConfigurator.Configure(xml);
        }
        #endregion
        /// <summary>
        /// 错误日志记录
        /// </summary>
        /// <param name="log"></param>
        /// <param name="function"></param>
        /// <param name="errorType"></param>
        /// <param name="tryHandle"></param>
        /// <param name="catchHandle"></param>
        /// <param name="finallyHandle"></param>
        public static void Logger(ILog log, string function, ErrorHandleType errorType, Action tryHandle, Action<Exception> catchHandle = null, Action finallyHandle = null)
        {
            try
            {
                log.Debug(function);
                tryHandle();
            }
            catch (Exception ex)
            {
                log.Error(function + "失败", ex);

                if (catchHandle != null)
                    catchHandle(ex);
                
                if (errorType == ErrorHandleType.ThrowException) 
                    throw ex;
            }
            finally
            {
                if (finallyHandle != null)
                    finallyHandle();
            }
        }
    }
}
