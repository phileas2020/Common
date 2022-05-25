using System;

namespace XLua.Custom
{

    public interface ILogger
    {
        void Error(string message, params object[] args);

        void Error(string message);

        void Warn(string message, params object[] args);

        void Warn(string message);

        void Info(string message, params object[] args);

        void Info(string message);
       
    }

    class DefaultLogger : ILogger
    {
        public void Error(string message, params object[] args)
        {
            UnityEngine.Debug.LogErrorFormat(message, args);
        }

        public void Error(string message)
        {
            UnityEngine.Debug.LogError(message);
        }

        public void Info(string message, params object[] args)
        {
            UnityEngine.Debug.LogFormat(message, args);
        }

        public void Info(string message)
        {
            UnityEngine.Debug.Log(message);
        }

        public void Warn(string message, params object[] args)
        {
            UnityEngine.Debug.LogWarningFormat(message, args);
        }

        public void Warn(string message)
        {
            UnityEngine.Debug.LogWarning(message);
        }
    }
    public static class LogFacade
    {
        static ILogger mLogger = null;
        public static ILogger Logger
        {
            get
            {
                if(mLogger == null)
                {
                    mLogger = new DefaultLogger();
                }
                return mLogger;
            }
            set
            {
                mLogger = value;
            }
        }

        public static void Info(string msg)
        {
            Logger.Info(msg);
        }

        internal static void Warn(string msg)
        {
            Logger.Warn(msg);
        }
    }
}
