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
    public class LuaCommonWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(LuaCommon), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(LuaCommon), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(LuaCommon), L, __CreateInstance, 3, 4, 4);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "IsMacPlatform", IsMacPlatform_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsIOSPlatform", IsIOSPlatform_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(LuaCommon));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "resultPath", get_resultPath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "xxxtdrfilepath", get_xxxtdrfilepath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "xxxtdr2filepath", get_xxxtdr2filepath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "android_platform", get_android_platform);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "resultPath", set_resultPath);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "xxxtdrfilepath", set_xxxtdrfilepath);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "xxxtdr2filepath", set_xxxtdr2filepath);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "android_platform", set_android_platform);
            
			Utils.EndClassRegister(typeof(LuaCommon), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					LuaCommon __cl_gen_ret = new LuaCommon();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCommon constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int IsMacPlatform_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                        bool __cl_gen_ret = LuaCommon.IsMacPlatform(  );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int IsIOSPlatform_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                        bool __cl_gen_ret = LuaCommon.IsIOSPlatform(  );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_resultPath(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushstring(L, LuaCommon.resultPath);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_xxxtdrfilepath(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushstring(L, LuaCommon.xxxtdrfilepath);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_xxxtdr2filepath(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushstring(L, LuaCommon.xxxtdr2filepath);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_android_platform(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, LuaCommon.android_platform);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_resultPath(RealStatePtr L)
        {
            
            try {
			    LuaCommon.resultPath = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_xxxtdrfilepath(RealStatePtr L)
        {
            
            try {
			    LuaCommon.xxxtdrfilepath = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_xxxtdr2filepath(RealStatePtr L)
        {
            
            try {
			    LuaCommon.xxxtdr2filepath = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_android_platform(RealStatePtr L)
        {
            
            try {
			    LuaCommon.android_platform = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
