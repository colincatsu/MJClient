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
    public class MXSocketClientWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(MX.SocketClient), L, translator, 0, 6, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnRegister", OnRegister);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnRemove", OnRemove);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Close", Close);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendConnect", SendConnect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendMessage", SendMessage);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendProtocol", SendProtocol);
			
			
			
			
			Utils.EndObjectRegister(typeof(MX.SocketClient), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(MX.SocketClient), L, __CreateInstance, 1, 1, 1);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(MX.SocketClient));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "_logged", get__logged);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "_logged", set__logged);
            
			Utils.EndClassRegister(typeof(MX.SocketClient), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					MX.SocketClient __cl_gen_ret = new MX.SocketClient();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MX.SocketClient constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int OnRegister(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            MX.SocketClient __cl_gen_to_be_invoked = (MX.SocketClient)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.OnRegister(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int OnRemove(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            MX.SocketClient __cl_gen_to_be_invoked = (MX.SocketClient)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.OnRemove(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Close(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            MX.SocketClient __cl_gen_to_be_invoked = (MX.SocketClient)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Close(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int SendConnect(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            MX.SocketClient __cl_gen_to_be_invoked = (MX.SocketClient)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.SendConnect(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int SendMessage(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            MX.SocketClient __cl_gen_to_be_invoked = (MX.SocketClient)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    MX.ByteBuffer buffer = (MX.ByteBuffer)translator.GetObject(L, 2, typeof(MX.ByteBuffer));
                    
                    __cl_gen_to_be_invoked.SendMessage( buffer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int SendProtocol(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            MX.SocketClient __cl_gen_to_be_invoked = (MX.SocketClient)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string meta = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.SendProtocol( meta );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get__logged(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, MX.SocketClient._logged);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set__logged(RealStatePtr L)
        {
            
            try {
			    MX.SocketClient._logged = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
