﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class UnityEngineEventSystemsPointerEventDataWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.EventSystems.PointerEventData);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 31, 28);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsPointerMoving", _m_IsPointerMoving);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsScrolling", _m_IsScrolling);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", _m_ToString);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "pointerEnter", _g_get_pointerEnter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lastPress", _g_get_lastPress);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rawPointerPress", _g_get_rawPointerPress);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pointerDrag", _g_get_pointerDrag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pointerClick", _g_get_pointerClick);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pointerCurrentRaycast", _g_get_pointerCurrentRaycast);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pointerPressRaycast", _g_get_pointerPressRaycast);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "eligibleForClick", _g_get_eligibleForClick);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pointerId", _g_get_pointerId);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "position", _g_get_position);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "delta", _g_get_delta);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pressPosition", _g_get_pressPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clickTime", _g_get_clickTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clickCount", _g_get_clickCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scrollDelta", _g_get_scrollDelta);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useDragThreshold", _g_get_useDragThreshold);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "dragging", _g_get_dragging);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "button", _g_get_button);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pressure", _g_get_pressure);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tangentialPressure", _g_get_tangentialPressure);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "altitudeAngle", _g_get_altitudeAngle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "azimuthAngle", _g_get_azimuthAngle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "twist", _g_get_twist);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "radius", _g_get_radius);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "radiusVariance", _g_get_radiusVariance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fullyExited", _g_get_fullyExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "reentered", _g_get_reentered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enterEventCamera", _g_get_enterEventCamera);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pressEventCamera", _g_get_pressEventCamera);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pointerPress", _g_get_pointerPress);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hovered", _g_get_hovered);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "pointerEnter", _s_set_pointerEnter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rawPointerPress", _s_set_rawPointerPress);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pointerDrag", _s_set_pointerDrag);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pointerClick", _s_set_pointerClick);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pointerCurrentRaycast", _s_set_pointerCurrentRaycast);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pointerPressRaycast", _s_set_pointerPressRaycast);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "eligibleForClick", _s_set_eligibleForClick);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pointerId", _s_set_pointerId);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "position", _s_set_position);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "delta", _s_set_delta);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pressPosition", _s_set_pressPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "clickTime", _s_set_clickTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "clickCount", _s_set_clickCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scrollDelta", _s_set_scrollDelta);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useDragThreshold", _s_set_useDragThreshold);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "dragging", _s_set_dragging);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "button", _s_set_button);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pressure", _s_set_pressure);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "tangentialPressure", _s_set_tangentialPressure);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "altitudeAngle", _s_set_altitudeAngle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "azimuthAngle", _s_set_azimuthAngle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "twist", _s_set_twist);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "radius", _s_set_radius);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "radiusVariance", _s_set_radiusVariance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fullyExited", _s_set_fullyExited);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "reentered", _s_set_reentered);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pointerPress", _s_set_pointerPress);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hovered", _s_set_hovered);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<UnityEngine.EventSystems.EventSystem>(L, 2))
				{
					UnityEngine.EventSystems.EventSystem _eventSystem = (UnityEngine.EventSystems.EventSystem)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.EventSystem));
					
					var gen_ret = new UnityEngine.EventSystems.PointerEventData(_eventSystem);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.EventSystems.PointerEventData constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsPointerMoving(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
               	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);

            
            
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.IsPointerMoving(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsScrolling(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
               	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);

            
            
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.IsScrolling(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToString(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
               	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);

            
            
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.ToString(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pointerEnter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.pointerEnter);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lastPress(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.lastPress);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rawPointerPress(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rawPointerPress);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pointerDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.pointerDrag);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pointerClick(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.pointerClick);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pointerCurrentRaycast(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.pointerCurrentRaycast);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pointerPressRaycast(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.pointerPressRaycast);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_eligibleForClick(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.eligibleForClick);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pointerId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.pointerId);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_position(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                proxy.PushUnityEngineVector2(L, gen_to_be_invoked.position);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_delta(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                proxy.PushUnityEngineVector2(L, gen_to_be_invoked.delta);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pressPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                proxy.PushUnityEngineVector2(L, gen_to_be_invoked.pressPosition);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clickTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.clickTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clickCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.clickCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scrollDelta(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                proxy.PushUnityEngineVector2(L, gen_to_be_invoked.scrollDelta);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useDragThreshold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useDragThreshold);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_dragging(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.dragging);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_button(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.button);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pressure(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.pressure);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tangentialPressure(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.tangentialPressure);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_altitudeAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.altitudeAngle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_azimuthAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.azimuthAngle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_twist(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.twist);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_radius(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                proxy.PushUnityEngineVector2(L, gen_to_be_invoked.radius);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_radiusVariance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                proxy.PushUnityEngineVector2(L, gen_to_be_invoked.radiusVariance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fullyExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.fullyExited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_reentered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.reentered);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enterEventCamera(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.enterEventCamera);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pressEventCamera(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.pressEventCamera);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pointerPress(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.pointerPress);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hovered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            	ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
            
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.hovered);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pointerEnter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                gen_to_be_invoked.pointerEnter = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rawPointerPress(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                gen_to_be_invoked.rawPointerPress = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pointerDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                gen_to_be_invoked.pointerDrag = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pointerClick(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                gen_to_be_invoked.pointerClick = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pointerCurrentRaycast(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                UnityEngine.EventSystems.RaycastResult gen_value;proxy.Get(L, 2, out gen_value);
				gen_to_be_invoked.pointerCurrentRaycast = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pointerPressRaycast(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                UnityEngine.EventSystems.RaycastResult gen_value;proxy.Get(L, 2, out gen_value);
				gen_to_be_invoked.pointerPressRaycast = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_eligibleForClick(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                gen_to_be_invoked.eligibleForClick = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pointerId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                gen_to_be_invoked.pointerId = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_position(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;proxy.Get(L, 2, out gen_value);
				gen_to_be_invoked.position = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_delta(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;proxy.Get(L, 2, out gen_value);
				gen_to_be_invoked.delta = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pressPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;proxy.Get(L, 2, out gen_value);
				gen_to_be_invoked.pressPosition = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_clickTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                gen_to_be_invoked.clickTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_clickCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                gen_to_be_invoked.clickCount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scrollDelta(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;proxy.Get(L, 2, out gen_value);
				gen_to_be_invoked.scrollDelta = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useDragThreshold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                gen_to_be_invoked.useDragThreshold = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_dragging(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                gen_to_be_invoked.dragging = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_button(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                UnityEngine.EventSystems.PointerEventData.InputButton gen_value;proxy.Get(L, 2, out gen_value);
				gen_to_be_invoked.button = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pressure(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                gen_to_be_invoked.pressure = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tangentialPressure(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                gen_to_be_invoked.tangentialPressure = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_altitudeAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                gen_to_be_invoked.altitudeAngle = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_azimuthAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                gen_to_be_invoked.azimuthAngle = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_twist(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                gen_to_be_invoked.twist = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_radius(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;proxy.Get(L, 2, out gen_value);
				gen_to_be_invoked.radius = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_radiusVariance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;proxy.Get(L, 2, out gen_value);
				gen_to_be_invoked.radiusVariance = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fullyExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                gen_to_be_invoked.fullyExited = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_reentered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                gen_to_be_invoked.reentered = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pointerPress(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                gen_to_be_invoked.pointerPress = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hovered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
                ObjectTranslatorProxy proxy = ObjectTranslatorProxy.Find(translator);
                
			
                UnityEngine.EventSystems.PointerEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.CustomFastGetCSObj(L, 1);
                gen_to_be_invoked.hovered = (System.Collections.Generic.List<UnityEngine.GameObject>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.GameObject>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
