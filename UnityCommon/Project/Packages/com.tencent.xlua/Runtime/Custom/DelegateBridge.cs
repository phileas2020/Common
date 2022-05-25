
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
    partial class DelegateBridge : DelegateBridgeBase
    {

        public RealStatePtr rawL
        {
            get
            {
                return luaEnv.rawL;
            }
        }

        public ObjectTranslator translator
        {
            get
            {
                return luaEnv.translator;
            }
        }

        public override Delegate GetDelegateByType(Type type)
        {

            return null;
    
        }

        public static DelegateBridge Create(int reference, LuaEnv luaenv)
        {
            if(Creator != null)
            {
                return Creator(reference, luaenv);
            }else
            {
               return new DelegateBridge(reference , luaenv);
            }
        }

        public static Func<int, LuaEnv, DelegateBridge> Creator;
    }
}
