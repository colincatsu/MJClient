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
    public class UnityEngineRendererWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Renderer), L, translator, 0, 3, 24, 19);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPropertyBlock", SetPropertyBlock);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPropertyBlock", GetPropertyBlock);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetClosestReflectionProbes", GetClosestReflectionProbes);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "isPartOfStaticBatch", get_isPartOfStaticBatch);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "worldToLocalMatrix", get_worldToLocalMatrix);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localToWorldMatrix", get_localToWorldMatrix);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enabled", get_enabled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "shadowCastingMode", get_shadowCastingMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "receiveShadows", get_receiveShadows);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "material", get_material);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sharedMaterial", get_sharedMaterial);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "materials", get_materials);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sharedMaterials", get_sharedMaterials);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bounds", get_bounds);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lightmapIndex", get_lightmapIndex);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "realtimeLightmapIndex", get_realtimeLightmapIndex);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lightmapScaleOffset", get_lightmapScaleOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "motionVectors", get_motionVectors);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "realtimeLightmapScaleOffset", get_realtimeLightmapScaleOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isVisible", get_isVisible);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lightProbeUsage", get_lightProbeUsage);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lightProbeProxyVolumeOverride", get_lightProbeProxyVolumeOverride);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "probeAnchor", get_probeAnchor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "reflectionProbeUsage", get_reflectionProbeUsage);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sortingLayerName", get_sortingLayerName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sortingLayerID", get_sortingLayerID);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sortingOrder", get_sortingOrder);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "enabled", set_enabled);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "shadowCastingMode", set_shadowCastingMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "receiveShadows", set_receiveShadows);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "material", set_material);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sharedMaterial", set_sharedMaterial);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "materials", set_materials);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sharedMaterials", set_sharedMaterials);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lightmapIndex", set_lightmapIndex);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "realtimeLightmapIndex", set_realtimeLightmapIndex);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lightmapScaleOffset", set_lightmapScaleOffset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "motionVectors", set_motionVectors);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "realtimeLightmapScaleOffset", set_realtimeLightmapScaleOffset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lightProbeUsage", set_lightProbeUsage);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lightProbeProxyVolumeOverride", set_lightProbeProxyVolumeOverride);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "probeAnchor", set_probeAnchor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "reflectionProbeUsage", set_reflectionProbeUsage);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sortingLayerName", set_sortingLayerName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sortingLayerID", set_sortingLayerID);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sortingOrder", set_sortingOrder);
            
			Utils.EndObjectRegister(typeof(UnityEngine.Renderer), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Renderer), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Renderer));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.Renderer), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Renderer __cl_gen_ret = new UnityEngine.Renderer();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Renderer constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int SetPropertyBlock(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 2, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    __cl_gen_to_be_invoked.SetPropertyBlock( properties );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int GetPropertyBlock(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.MaterialPropertyBlock dest = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 2, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    __cl_gen_to_be_invoked.GetPropertyBlock( dest );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int GetClosestReflectionProbes(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo> result = (System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo>));
                    
                    __cl_gen_to_be_invoked.GetClosestReflectionProbes( result );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_isPartOfStaticBatch(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isPartOfStaticBatch);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_worldToLocalMatrix(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.worldToLocalMatrix);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_localToWorldMatrix(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.localToWorldMatrix);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_enabled(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.enabled);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_shadowCastingMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.shadowCastingMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_receiveShadows(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.receiveShadows);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_material(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.material);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_sharedMaterial(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.sharedMaterial);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_materials(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.materials);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_sharedMaterials(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.sharedMaterials);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_bounds(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineBounds(L, __cl_gen_to_be_invoked.bounds);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_lightmapIndex(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.lightmapIndex);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_realtimeLightmapIndex(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.realtimeLightmapIndex);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_lightmapScaleOffset(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector4(L, __cl_gen_to_be_invoked.lightmapScaleOffset);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_motionVectors(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.motionVectors);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_realtimeLightmapScaleOffset(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector4(L, __cl_gen_to_be_invoked.realtimeLightmapScaleOffset);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_isVisible(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isVisible);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_lightProbeUsage(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.lightProbeUsage);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_lightProbeProxyVolumeOverride(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.lightProbeProxyVolumeOverride);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_probeAnchor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.probeAnchor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_reflectionProbeUsage(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.reflectionProbeUsage);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_sortingLayerName(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.sortingLayerName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_sortingLayerID(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.sortingLayerID);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_sortingOrder(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.sortingOrder);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_enabled(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.enabled = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_shadowCastingMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                UnityEngine.Rendering.ShadowCastingMode __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.shadowCastingMode = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_receiveShadows(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.receiveShadows = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_material(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.material = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_sharedMaterial(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.sharedMaterial = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_materials(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.materials = (UnityEngine.Material[])translator.GetObject(L, 2, typeof(UnityEngine.Material[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_sharedMaterials(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.sharedMaterials = (UnityEngine.Material[])translator.GetObject(L, 2, typeof(UnityEngine.Material[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_lightmapIndex(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.lightmapIndex = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_realtimeLightmapIndex(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.realtimeLightmapIndex = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_lightmapScaleOffset(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector4 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.lightmapScaleOffset = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_motionVectors(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.motionVectors = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_realtimeLightmapScaleOffset(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector4 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.realtimeLightmapScaleOffset = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_lightProbeUsage(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                UnityEngine.Rendering.LightProbeUsage __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.lightProbeUsage = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_lightProbeProxyVolumeOverride(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.lightProbeProxyVolumeOverride = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_probeAnchor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.probeAnchor = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_reflectionProbeUsage(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                UnityEngine.Rendering.ReflectionProbeUsage __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.reflectionProbeUsage = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_sortingLayerName(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.sortingLayerName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_sortingLayerID(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.sortingLayerID = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_sortingOrder(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Renderer __cl_gen_to_be_invoked = (UnityEngine.Renderer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.sortingOrder = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
