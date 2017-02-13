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
    public class UnityEngineParticleSystemWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.ParticleSystem), L, translator, 0, 9, 39, 17);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetParticles", SetParticles);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetParticles", GetParticles);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Simulate", Simulate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Play", Play);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Stop", Stop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Pause", Pause);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsAlive", IsAlive);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Emit", Emit);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "startDelay", get_startDelay);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isPlaying", get_isPlaying);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isStopped", get_isStopped);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isPaused", get_isPaused);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "loop", get_loop);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playOnAwake", get_playOnAwake);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "time", get_time);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "duration", get_duration);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playbackSpeed", get_playbackSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "particleCount", get_particleCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startSpeed", get_startSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startSize", get_startSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startColor", get_startColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startRotation", get_startRotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startRotation3D", get_startRotation3D);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startLifetime", get_startLifetime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gravityModifier", get_gravityModifier);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxParticles", get_maxParticles);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "simulationSpace", get_simulationSpace);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scalingMode", get_scalingMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "randomSeed", get_randomSeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useAutoRandomSeed", get_useAutoRandomSeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "emission", get_emission);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "shape", get_shape);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "velocityOverLifetime", get_velocityOverLifetime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "limitVelocityOverLifetime", get_limitVelocityOverLifetime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "inheritVelocity", get_inheritVelocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "forceOverLifetime", get_forceOverLifetime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "colorOverLifetime", get_colorOverLifetime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "colorBySpeed", get_colorBySpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sizeOverLifetime", get_sizeOverLifetime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sizeBySpeed", get_sizeBySpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotationOverLifetime", get_rotationOverLifetime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotationBySpeed", get_rotationBySpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "externalForces", get_externalForces);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "collision", get_collision);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "trigger", get_trigger);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "subEmitters", get_subEmitters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "textureSheetAnimation", get_textureSheetAnimation);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "startDelay", set_startDelay);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "loop", set_loop);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "playOnAwake", set_playOnAwake);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "time", set_time);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "playbackSpeed", set_playbackSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startSpeed", set_startSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startSize", set_startSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startColor", set_startColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startRotation", set_startRotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startRotation3D", set_startRotation3D);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startLifetime", set_startLifetime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gravityModifier", set_gravityModifier);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxParticles", set_maxParticles);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "simulationSpace", set_simulationSpace);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scalingMode", set_scalingMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "randomSeed", set_randomSeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useAutoRandomSeed", set_useAutoRandomSeed);
            
			Utils.EndObjectRegister(typeof(UnityEngine.ParticleSystem), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.ParticleSystem), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.ParticleSystem));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.ParticleSystem), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.ParticleSystem __cl_gen_ret = new UnityEngine.ParticleSystem();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int SetParticles(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.ParticleSystem.Particle[] particles = (UnityEngine.ParticleSystem.Particle[])translator.GetObject(L, 2, typeof(UnityEngine.ParticleSystem.Particle[]));
                    int size = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.SetParticles( particles, size );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int GetParticles(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.ParticleSystem.Particle[] particles = (UnityEngine.ParticleSystem.Particle[])translator.GetObject(L, 2, typeof(UnityEngine.ParticleSystem.Particle[]));
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetParticles( particles );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Simulate(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    float t = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    __cl_gen_to_be_invoked.Simulate( t );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    float t = (float)LuaAPI.lua_tonumber(L, 2);
                    bool withChildren = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.Simulate( t, withChildren );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    float t = (float)LuaAPI.lua_tonumber(L, 2);
                    bool withChildren = LuaAPI.lua_toboolean(L, 3);
                    bool restart = LuaAPI.lua_toboolean(L, 4);
                    
                    __cl_gen_to_be_invoked.Simulate( t, withChildren, restart );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    float t = (float)LuaAPI.lua_tonumber(L, 2);
                    bool withChildren = LuaAPI.lua_toboolean(L, 3);
                    bool restart = LuaAPI.lua_toboolean(L, 4);
                    bool fixedTimeStep = LuaAPI.lua_toboolean(L, 5);
                    
                    __cl_gen_to_be_invoked.Simulate( t, withChildren, restart, fixedTimeStep );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.Simulate!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Play(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.Play(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool withChildren = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.Play( withChildren );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.Play!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Stop(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.Stop(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool withChildren = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.Stop( withChildren );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.Stop!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Pause(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.Pause(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool withChildren = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.Pause( withChildren );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.Pause!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Clear(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool withChildren = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.Clear( withChildren );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.Clear!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int IsAlive(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1) 
                {
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsAlive(  );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool withChildren = LuaAPI.lua_toboolean(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsAlive( withChildren );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.IsAlive!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Emit(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int count = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.Emit( count );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.ParticleSystem.EmitParams>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.ParticleSystem.EmitParams emitParams;translator.Get(L, 2, out emitParams);
                    int count = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.Emit( emitParams, count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.Emit!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_startDelay(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.startDelay);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_isPlaying(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isPlaying);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_isStopped(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isStopped);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_isPaused(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isPaused);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_loop(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.loop);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_playOnAwake(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.playOnAwake);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_time(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.time);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_duration(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.duration);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_playbackSpeed(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.playbackSpeed);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_particleCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.particleCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_startSpeed(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.startSpeed);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_startSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.startSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_startColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, __cl_gen_to_be_invoked.startColor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_startRotation(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.startRotation);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_startRotation3D(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.startRotation3D);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_startLifetime(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.startLifetime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_gravityModifier(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.gravityModifier);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_maxParticles(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.maxParticles);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_simulationSpace(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.simulationSpace);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_scalingMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.scalingMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_randomSeed(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushuint(L, __cl_gen_to_be_invoked.randomSeed);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_useAutoRandomSeed(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.useAutoRandomSeed);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_emission(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.emission);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_shape(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.shape);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_velocityOverLifetime(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.velocityOverLifetime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_limitVelocityOverLifetime(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.limitVelocityOverLifetime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_inheritVelocity(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.inheritVelocity);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_forceOverLifetime(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.forceOverLifetime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_colorOverLifetime(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.colorOverLifetime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_colorBySpeed(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.colorBySpeed);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_sizeOverLifetime(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.sizeOverLifetime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_sizeBySpeed(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.sizeBySpeed);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_rotationOverLifetime(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.rotationOverLifetime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_rotationBySpeed(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.rotationBySpeed);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_externalForces(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.externalForces);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_collision(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.collision);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_trigger(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.trigger);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_subEmitters(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.subEmitters);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_textureSheetAnimation(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.textureSheetAnimation);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_startDelay(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.startDelay = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_loop(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.loop = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_playOnAwake(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.playOnAwake = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_time(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.time = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_playbackSpeed(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.playbackSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_startSpeed(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.startSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_startSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.startSize = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_startColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                UnityEngine.Color __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.startColor = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_startRotation(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.startRotation = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_startRotation3D(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.startRotation3D = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_startLifetime(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.startLifetime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_gravityModifier(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.gravityModifier = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_maxParticles(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.maxParticles = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_simulationSpace(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                UnityEngine.ParticleSystemSimulationSpace __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.simulationSpace = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_scalingMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                UnityEngine.ParticleSystemScalingMode __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.scalingMode = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_randomSeed(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.randomSeed = LuaAPI.xlua_touint(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_useAutoRandomSeed(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.useAutoRandomSeed = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
