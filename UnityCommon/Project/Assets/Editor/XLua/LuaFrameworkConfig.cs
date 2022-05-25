using System;
using System.Collections.Generic;
using XLua;

public static class LuaFrameworkConfig
{
    [CSharpCallLua]
    public static List<Type> CSharpCallLua = new List<Type>()
    {
        typeof(Action),
        typeof(Action<float>),
        typeof(Action<float, float>),
        typeof(Action<float,float,float>),
        typeof(Action<bool>),
        typeof(Action<int>),
        typeof(Action<uint>),
        typeof(Action<bool,int>),
        typeof(Action<string>),
 };

    [LuaCallCSharp]
    public static List<Type> LuaCallCSharp = new List<Type>()
    {
        typeof(UnityEngine.EventSystems.PointerEventData),
        typeof(UnityEngine.EventSystems.BaseEventData),
    };
}