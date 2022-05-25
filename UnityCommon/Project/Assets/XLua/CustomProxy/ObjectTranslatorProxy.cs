#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using RealStatePtr = System.IntPtr;
#endif

using System;
using static XLua.ObjectTranslator;

namespace XLua
{
    public partial class ObjectTranslatorProxy
    {
        public static ObjectTranslatorProxy proxy = new ObjectTranslatorProxy();

        public static ObjectTranslatorProxy  Find(ObjectTranslator translator)
        {
            proxy.translator = translator;
            return proxy;
        }

        public ObjectTranslator translator
        {
            get;
            set;
        }

        public MethodWrapsCache methodWrapsCache
        {
            get
            {
                return translator.MethodWrapsCache;
            }
        }
        public ObjectCheckers objectCheckers
        {
            get
            {
                return translator.ObjectCheckers;
            }
        }
        public ObjectCasters objectCasters
        {
            get
            {
                return translator.ObjectCasters;
            }
        }

        public void Get<T>(RealStatePtr L, int index, out T v)
        {
            translator.Get<T>(L, index, out v);
        }
        public void PushByType<T>(RealStatePtr L, T v)
        {
            translator.PushByType<T>(L, v);
        }

        public void DelayWrapLoader(Type type, Action<RealStatePtr> loader)
        {
            translator.DelayWrapLoader(type, loader);
        }

        public void AddInterfaceBridgeCreator(Type type, Func<int, LuaEnv, LuaBase> creator)
        {
            translator.AddInterfaceBridgeCreator(type, creator);
        }

        public bool TryDelayWrapLoader(RealStatePtr L, Type type)
        {
            return translator.TryDelayWrapLoader(L, type);
        }

        public void RegisterPushAndGetAndUpdate<T>(Action<RealStatePtr, T> push, GetFunc<T> get, Action<RealStatePtr, int, T> update)
        {
            translator.RegisterPushAndGetAndUpdate<T>(push, get, update);
        }

        public int getTypeId(RealStatePtr L, Type type, out bool is_first)
        {
            return translator.GetTypeId(L, type, out is_first);
        }
    }
}