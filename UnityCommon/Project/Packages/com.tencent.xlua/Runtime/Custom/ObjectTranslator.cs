namespace XLua
{

#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
    using LuaAPI = XLua.LuaDLL.Lua;
    using RealStatePtr = System.IntPtr;
    using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

    using System.Collections.Generic;
    using System.Reflection;
    using System;

    partial class ObjectTranslator
    {
        public MethodWrapsCache MethodWrapsCache
        {
            get
            {
                return this.methodWrapsCache;
            }
        }
        public ObjectCheckers ObjectCheckers
        {
            get
            {
                return this.objectCheckers;
            }
        }
        public ObjectCasters ObjectCasters
        {
            get
            {
                return this.objectCasters;
            }
        }

        public ObjectPool Objects
        {
            get
            {
                return this.objects;
            }
        }
        public Dictionary<object, int> ReverseMap
        {
            get
            {
                return this.reverseMap;
            }
        }
        public LuaEnv LuaEnv
        {
            get
            {
                return this.luaEnv;
            }
        }
        public StaticLuaCallbacks MetaFunctions
        {
            get
            {
                return this.metaFunctions;
            }
        }
        public List<Assembly> Assemblies
        {
            get
            {
                return this.assemblies;
            }
        }

        public int GetTypeId(RealStatePtr L, Type type, out bool is_first)
        {
            return getTypeId(L, type, out is_first);
        }

        public object CustomSafeGetCSObj(RealStatePtr L, int index)
        {
            return SafeGetCSObj(L, index); 
        }

        public object CustomFastGetCSObj(RealStatePtr L, int index)
        {
            return FastGetCSObj(L, index);
        }

        public void CustomReleaseCSObj(RealStatePtr L, int index)
        {
            ReleaseCSObj(L, index);
        }

        public static int LUA_REGISTRYINDEX
        {
            get
            { 
                return LuaIndexes.LUA_REGISTRYINDEX; 
            }
            set
            {
                LuaIndexes.LUA_REGISTRYINDEX = value;
            }
        }
    }
}
