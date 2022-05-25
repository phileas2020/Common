
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

    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public partial class  InternalGlobalsProxy
    {
       
        public static Dictionary<Type, IEnumerable<MethodInfo>> extensionMethodMap
        {
            get
            {
                return InternalGlobals.extensionMethodMap;
            }
            set
            {
                InternalGlobals.extensionMethodMap = value;
            }
        }

       
         
        public static TryArrayGet genTryArrayGetPtr
        {
            get
            {
                return _get;
            }
            set
            {
                _get = value;

                if (_get == null)
                {
                    InternalGlobals.genTryArrayGetPtr = null;
                }
                else
                {
                    InternalGlobals.genTryArrayGetPtr = CustomTryArrayGet;
                }
            }
        }
        public static TryArraySet genTryArraySetPtr
        {
            get
            {
                return _set;
            }
            set
            {
                _set = value;
                if(_set == null)
                {
                    InternalGlobals.genTryArraySetPtr = null;
                }
                else
                {
                    InternalGlobals.genTryArraySetPtr = CustomTryArraySet;
                }
            }
        }

        public delegate bool TryArrayGet(Type type, RealStatePtr L, ObjectTranslator translator, object obj, int index);
        public delegate bool TryArraySet(Type type, RealStatePtr L, ObjectTranslator translator, object obj, int array_idx, int obj_idx);

        static TryArrayGet _get = null;
        static TryArraySet _set= null;
        internal static bool CustomTryArrayGet(Type type, RealStatePtr L, ObjectTranslator translator, object obj, int index)
        {
            if(_get != null)
            {
                return _get(type, L, translator, obj, index);
            }
          
            return false;

        }

        internal static bool CustomTryArraySet(Type type, RealStatePtr L, ObjectTranslator translator, object obj, int array_idx, int obj_idx)
        {
            if (_set != null)
            {
                return _set(type, L, translator, obj, array_idx, obj_idx);
            }

            return false;
        }
    }
}
