#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
#endif


namespace XLua
{
    partial class DelegateBridgeProxy : DelegateBridge
    {
        public DelegateBridgeProxy(int reference, LuaEnv luaenv) : base(reference, luaenv)
        {

        }
    }
    
}