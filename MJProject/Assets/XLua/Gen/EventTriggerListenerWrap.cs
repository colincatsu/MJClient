#if USE_UNI_LUA
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


namespace CSObjectWrap
{
    public class EventTriggerListenerWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(EventTriggerListener), L, translator, 0, 0, 3, 3);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "onClick", get_onClick);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "_buttons", get__buttons);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "_toggles", get__toggles);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "onClick", set_onClick);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "_buttons", set__buttons);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "_toggles", set__toggles);
            
			Utils.EndObjectRegister(typeof(EventTriggerListener), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(EventTriggerListener), L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Get", Get_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(EventTriggerListener));
			
			
			Utils.EndClassRegister(typeof(EventTriggerListener), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					EventTriggerListener __cl_gen_ret = new EventTriggerListener();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to EventTriggerListener constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Get_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                        EventTriggerListener __cl_gen_ret = EventTriggerListener.Get( go );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_onClick(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                EventTriggerListener __cl_gen_to_be_invoked = (EventTriggerListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onClick);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get__buttons(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                EventTriggerListener __cl_gen_to_be_invoked = (EventTriggerListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked._buttons);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get__toggles(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                EventTriggerListener __cl_gen_to_be_invoked = (EventTriggerListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked._toggles);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_onClick(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                EventTriggerListener __cl_gen_to_be_invoked = (EventTriggerListener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onClick = translator.GetDelegate<EventTriggerListener.VoidDelegate>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set__buttons(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                EventTriggerListener __cl_gen_to_be_invoked = (EventTriggerListener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked._buttons = (UnityEngine.UI.Button[])translator.GetObject(L, 2, typeof(UnityEngine.UI.Button[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set__toggles(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                EventTriggerListener __cl_gen_to_be_invoked = (EventTriggerListener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked._toggles = (UnityEngine.UI.Toggle[])translator.GetObject(L, 2, typeof(UnityEngine.UI.Toggle[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
