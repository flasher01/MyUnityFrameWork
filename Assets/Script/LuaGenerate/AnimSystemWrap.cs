﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class AnimSystemWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(AnimSystem), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("GetInstance", GetInstance);
		L.RegFunction("InitAnimData", InitAnimData);
		L.RegFunction("UguiColor", UguiColor);
		L.RegFunction("UguiAlpha", UguiAlpha);
		L.RegFunction("UguiMove", UguiMove);
		L.RegFunction("UguiSizeDelta", UguiSizeDelta);
		L.RegFunction("ColorTo", ColorTo);
		L.RegFunction("AlphaTo", AlphaTo);
		L.RegFunction("Move", Move);
		L.RegFunction("Rotate", Rotate);
		L.RegFunction("Scale", Scale);
		L.RegFunction("CustomMethodToFloat", CustomMethodToFloat);
		L.RegFunction("CustomMethodToVector2", CustomMethodToVector2);
		L.RegFunction("CustomMethodToVector3", CustomMethodToVector3);
		L.RegFunction("BezierMove", BezierMove);
		L.RegFunction("Blink", Blink);
		L.RegFunction("ValueTo", ValueTo);
		L.RegFunction("StopAnim", StopAnim);
		L.RegFunction("FinishAnim", FinishAnim);
		L.RegFunction("ClearAllAnim", ClearAllAnim);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("animList", get_animList, set_animList);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInstance(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			AnimSystem o = AnimSystem.GetInstance();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InitAnimData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			AnimSystem.InitAnimData();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UguiColor(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 12);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.GameObject));
			System.Nullable<UnityEngine.Color> arg1 = (System.Nullable<UnityEngine.Color>)ToLua.CheckVarObject(L, 2, typeof(System.Nullable<UnityEngine.Color>));
			UnityEngine.Color arg2 = (UnityEngine.Color)ToLua.CheckObject(L, 3, typeof(UnityEngine.Color));
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
			float arg4 = (float)LuaDLL.luaL_checknumber(L, 5);
			InterpType arg5 = (InterpType)ToLua.CheckObject(L, 6, typeof(InterpType));
			bool arg6 = LuaDLL.luaL_checkboolean(L, 7);
			bool arg7 = LuaDLL.luaL_checkboolean(L, 8);
			RepeatType arg8 = (RepeatType)ToLua.CheckObject(L, 9, typeof(RepeatType));
			int arg9 = (int)LuaDLL.luaL_checknumber(L, 10);
			AnimCallBack arg10 = null;
			LuaTypes funcType11 = LuaDLL.lua_type(L, 11);

			if (funcType11 != LuaTypes.LUA_TFUNCTION)
			{
				 arg10 = (AnimCallBack)ToLua.CheckObject(L, 11, typeof(AnimCallBack));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 11);
				arg10 = DelegateFactory.CreateDelegate(typeof(AnimCallBack), func) as AnimCallBack;
			}

			object[] arg11 = ToLua.CheckObjectArray(L, 12);
			AnimData o = AnimSystem.UguiColor(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UguiAlpha(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 12);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.GameObject));
			System.Nullable<float> arg1 = (System.Nullable<float>)ToLua.CheckVarObject(L, 2, typeof(System.Nullable<float>));
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
			float arg4 = (float)LuaDLL.luaL_checknumber(L, 5);
			InterpType arg5 = (InterpType)ToLua.CheckObject(L, 6, typeof(InterpType));
			bool arg6 = LuaDLL.luaL_checkboolean(L, 7);
			bool arg7 = LuaDLL.luaL_checkboolean(L, 8);
			RepeatType arg8 = (RepeatType)ToLua.CheckObject(L, 9, typeof(RepeatType));
			int arg9 = (int)LuaDLL.luaL_checknumber(L, 10);
			AnimCallBack arg10 = null;
			LuaTypes funcType11 = LuaDLL.lua_type(L, 11);

			if (funcType11 != LuaTypes.LUA_TFUNCTION)
			{
				 arg10 = (AnimCallBack)ToLua.CheckObject(L, 11, typeof(AnimCallBack));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 11);
				arg10 = DelegateFactory.CreateDelegate(typeof(AnimCallBack), func) as AnimCallBack;
			}

			object[] arg11 = ToLua.CheckObjectArray(L, 12);
			AnimData o = AnimSystem.UguiAlpha(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UguiMove(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 11);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.GameObject));
			System.Nullable<UnityEngine.Vector3> arg1 = (System.Nullable<UnityEngine.Vector3>)ToLua.CheckVarObject(L, 2, typeof(System.Nullable<UnityEngine.Vector3>));
			UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)ToLua.CheckObject(L, 3, typeof(UnityEngine.Vector3));
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
			float arg4 = (float)LuaDLL.luaL_checknumber(L, 5);
			InterpType arg5 = (InterpType)ToLua.CheckObject(L, 6, typeof(InterpType));
			bool arg6 = LuaDLL.luaL_checkboolean(L, 7);
			RepeatType arg7 = (RepeatType)ToLua.CheckObject(L, 8, typeof(RepeatType));
			int arg8 = (int)LuaDLL.luaL_checknumber(L, 9);
			AnimCallBack arg9 = null;
			LuaTypes funcType10 = LuaDLL.lua_type(L, 10);

			if (funcType10 != LuaTypes.LUA_TFUNCTION)
			{
				 arg9 = (AnimCallBack)ToLua.CheckObject(L, 10, typeof(AnimCallBack));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 10);
				arg9 = DelegateFactory.CreateDelegate(typeof(AnimCallBack), func) as AnimCallBack;
			}

			object[] arg10 = ToLua.CheckObjectArray(L, 11);
			AnimData o = AnimSystem.UguiMove(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UguiSizeDelta(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 11);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.GameObject));
			System.Nullable<UnityEngine.Vector2> arg1 = (System.Nullable<UnityEngine.Vector2>)ToLua.CheckVarObject(L, 2, typeof(System.Nullable<UnityEngine.Vector2>));
			UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)ToLua.CheckObject(L, 3, typeof(UnityEngine.Vector2));
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
			float arg4 = (float)LuaDLL.luaL_checknumber(L, 5);
			InterpType arg5 = (InterpType)ToLua.CheckObject(L, 6, typeof(InterpType));
			bool arg6 = LuaDLL.luaL_checkboolean(L, 7);
			RepeatType arg7 = (RepeatType)ToLua.CheckObject(L, 8, typeof(RepeatType));
			int arg8 = (int)LuaDLL.luaL_checknumber(L, 9);
			AnimCallBack arg9 = null;
			LuaTypes funcType10 = LuaDLL.lua_type(L, 10);

			if (funcType10 != LuaTypes.LUA_TFUNCTION)
			{
				 arg9 = (AnimCallBack)ToLua.CheckObject(L, 10, typeof(AnimCallBack));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 10);
				arg9 = DelegateFactory.CreateDelegate(typeof(AnimCallBack), func) as AnimCallBack;
			}

			object[] arg10 = ToLua.CheckObjectArray(L, 11);
			AnimData o = AnimSystem.UguiSizeDelta(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ColorTo(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 12);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.GameObject));
			UnityEngine.Color arg1 = (UnityEngine.Color)ToLua.CheckObject(L, 2, typeof(UnityEngine.Color));
			UnityEngine.Color arg2 = (UnityEngine.Color)ToLua.CheckObject(L, 3, typeof(UnityEngine.Color));
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
			float arg4 = (float)LuaDLL.luaL_checknumber(L, 5);
			InterpType arg5 = (InterpType)ToLua.CheckObject(L, 6, typeof(InterpType));
			bool arg6 = LuaDLL.luaL_checkboolean(L, 7);
			bool arg7 = LuaDLL.luaL_checkboolean(L, 8);
			RepeatType arg8 = (RepeatType)ToLua.CheckObject(L, 9, typeof(RepeatType));
			int arg9 = (int)LuaDLL.luaL_checknumber(L, 10);
			AnimCallBack arg10 = null;
			LuaTypes funcType11 = LuaDLL.lua_type(L, 11);

			if (funcType11 != LuaTypes.LUA_TFUNCTION)
			{
				 arg10 = (AnimCallBack)ToLua.CheckObject(L, 11, typeof(AnimCallBack));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 11);
				arg10 = DelegateFactory.CreateDelegate(typeof(AnimCallBack), func) as AnimCallBack;
			}

			object[] arg11 = ToLua.CheckObjectArray(L, 12);
			AnimData o = AnimSystem.ColorTo(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AlphaTo(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 12);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.GameObject));
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
			float arg4 = (float)LuaDLL.luaL_checknumber(L, 5);
			InterpType arg5 = (InterpType)ToLua.CheckObject(L, 6, typeof(InterpType));
			bool arg6 = LuaDLL.luaL_checkboolean(L, 7);
			RepeatType arg7 = (RepeatType)ToLua.CheckObject(L, 8, typeof(RepeatType));
			int arg8 = (int)LuaDLL.luaL_checknumber(L, 9);
			bool arg9 = LuaDLL.luaL_checkboolean(L, 10);
			AnimCallBack arg10 = null;
			LuaTypes funcType11 = LuaDLL.lua_type(L, 11);

			if (funcType11 != LuaTypes.LUA_TFUNCTION)
			{
				 arg10 = (AnimCallBack)ToLua.CheckObject(L, 11, typeof(AnimCallBack));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 11);
				arg10 = DelegateFactory.CreateDelegate(typeof(AnimCallBack), func) as AnimCallBack;
			}

			object[] arg11 = ToLua.CheckObjectArray(L, 12);
			AnimData o = AnimSystem.AlphaTo(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Move(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 12);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.GameObject));
			System.Nullable<UnityEngine.Vector3> arg1 = (System.Nullable<UnityEngine.Vector3>)ToLua.CheckVarObject(L, 2, typeof(System.Nullable<UnityEngine.Vector3>));
			UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)ToLua.CheckObject(L, 3, typeof(UnityEngine.Vector3));
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
			float arg4 = (float)LuaDLL.luaL_checknumber(L, 5);
			bool arg5 = LuaDLL.luaL_checkboolean(L, 6);
			InterpType arg6 = (InterpType)ToLua.CheckObject(L, 7, typeof(InterpType));
			bool arg7 = LuaDLL.luaL_checkboolean(L, 8);
			RepeatType arg8 = (RepeatType)ToLua.CheckObject(L, 9, typeof(RepeatType));
			int arg9 = (int)LuaDLL.luaL_checknumber(L, 10);
			AnimCallBack arg10 = null;
			LuaTypes funcType11 = LuaDLL.lua_type(L, 11);

			if (funcType11 != LuaTypes.LUA_TFUNCTION)
			{
				 arg10 = (AnimCallBack)ToLua.CheckObject(L, 11, typeof(AnimCallBack));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 11);
				arg10 = DelegateFactory.CreateDelegate(typeof(AnimCallBack), func) as AnimCallBack;
			}

			object[] arg11 = ToLua.CheckObjectArray(L, 12);
			AnimData o = AnimSystem.Move(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Rotate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 12);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.GameObject));
			System.Nullable<UnityEngine.Vector3> arg1 = (System.Nullable<UnityEngine.Vector3>)ToLua.CheckVarObject(L, 2, typeof(System.Nullable<UnityEngine.Vector3>));
			UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)ToLua.CheckObject(L, 3, typeof(UnityEngine.Vector3));
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
			float arg4 = (float)LuaDLL.luaL_checknumber(L, 5);
			bool arg5 = LuaDLL.luaL_checkboolean(L, 6);
			InterpType arg6 = (InterpType)ToLua.CheckObject(L, 7, typeof(InterpType));
			bool arg7 = LuaDLL.luaL_checkboolean(L, 8);
			RepeatType arg8 = (RepeatType)ToLua.CheckObject(L, 9, typeof(RepeatType));
			int arg9 = (int)LuaDLL.luaL_checknumber(L, 10);
			AnimCallBack arg10 = null;
			LuaTypes funcType11 = LuaDLL.lua_type(L, 11);

			if (funcType11 != LuaTypes.LUA_TFUNCTION)
			{
				 arg10 = (AnimCallBack)ToLua.CheckObject(L, 11, typeof(AnimCallBack));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 11);
				arg10 = DelegateFactory.CreateDelegate(typeof(AnimCallBack), func) as AnimCallBack;
			}

			object[] arg11 = ToLua.CheckObjectArray(L, 12);
			AnimData o = AnimSystem.Rotate(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Scale(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 11);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.GameObject));
			System.Nullable<UnityEngine.Vector3> arg1 = (System.Nullable<UnityEngine.Vector3>)ToLua.CheckVarObject(L, 2, typeof(System.Nullable<UnityEngine.Vector3>));
			UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)ToLua.CheckObject(L, 3, typeof(UnityEngine.Vector3));
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
			InterpType arg4 = (InterpType)ToLua.CheckObject(L, 5, typeof(InterpType));
			bool arg5 = LuaDLL.luaL_checkboolean(L, 6);
			RepeatType arg6 = (RepeatType)ToLua.CheckObject(L, 7, typeof(RepeatType));
			int arg7 = (int)LuaDLL.luaL_checknumber(L, 8);
			float arg8 = (float)LuaDLL.luaL_checknumber(L, 9);
			AnimCallBack arg9 = null;
			LuaTypes funcType10 = LuaDLL.lua_type(L, 10);

			if (funcType10 != LuaTypes.LUA_TFUNCTION)
			{
				 arg9 = (AnimCallBack)ToLua.CheckObject(L, 10, typeof(AnimCallBack));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 10);
				arg9 = DelegateFactory.CreateDelegate(typeof(AnimCallBack), func) as AnimCallBack;
			}

			object[] arg10 = ToLua.CheckObjectArray(L, 11);
			AnimData o = AnimSystem.Scale(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CustomMethodToFloat(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 11);
			AnimCustomMethodFloat arg0 = null;
			LuaTypes funcType1 = LuaDLL.lua_type(L, 1);

			if (funcType1 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (AnimCustomMethodFloat)ToLua.CheckObject(L, 1, typeof(AnimCustomMethodFloat));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 1);
				arg0 = DelegateFactory.CreateDelegate(typeof(AnimCustomMethodFloat), func) as AnimCustomMethodFloat;
			}

			float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
			float arg4 = (float)LuaDLL.luaL_checknumber(L, 5);
			InterpType arg5 = (InterpType)ToLua.CheckObject(L, 6, typeof(InterpType));
			bool arg6 = LuaDLL.luaL_checkboolean(L, 7);
			RepeatType arg7 = (RepeatType)ToLua.CheckObject(L, 8, typeof(RepeatType));
			int arg8 = (int)LuaDLL.luaL_checknumber(L, 9);
			AnimCallBack arg9 = null;
			LuaTypes funcType10 = LuaDLL.lua_type(L, 10);

			if (funcType10 != LuaTypes.LUA_TFUNCTION)
			{
				 arg9 = (AnimCallBack)ToLua.CheckObject(L, 10, typeof(AnimCallBack));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 10);
				arg9 = DelegateFactory.CreateDelegate(typeof(AnimCallBack), func) as AnimCallBack;
			}

			object[] arg10 = ToLua.CheckObjectArray(L, 11);
			AnimData o = AnimSystem.CustomMethodToFloat(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CustomMethodToVector2(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 11);
			AnimCustomMethodVector2 arg0 = null;
			LuaTypes funcType1 = LuaDLL.lua_type(L, 1);

			if (funcType1 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (AnimCustomMethodVector2)ToLua.CheckObject(L, 1, typeof(AnimCustomMethodVector2));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 1);
				arg0 = DelegateFactory.CreateDelegate(typeof(AnimCustomMethodVector2), func) as AnimCustomMethodVector2;
			}

			UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)ToLua.CheckObject(L, 2, typeof(UnityEngine.Vector2));
			UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)ToLua.CheckObject(L, 3, typeof(UnityEngine.Vector2));
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
			float arg4 = (float)LuaDLL.luaL_checknumber(L, 5);
			InterpType arg5 = (InterpType)ToLua.CheckObject(L, 6, typeof(InterpType));
			bool arg6 = LuaDLL.luaL_checkboolean(L, 7);
			RepeatType arg7 = (RepeatType)ToLua.CheckObject(L, 8, typeof(RepeatType));
			int arg8 = (int)LuaDLL.luaL_checknumber(L, 9);
			AnimCallBack arg9 = null;
			LuaTypes funcType10 = LuaDLL.lua_type(L, 10);

			if (funcType10 != LuaTypes.LUA_TFUNCTION)
			{
				 arg9 = (AnimCallBack)ToLua.CheckObject(L, 10, typeof(AnimCallBack));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 10);
				arg9 = DelegateFactory.CreateDelegate(typeof(AnimCallBack), func) as AnimCallBack;
			}

			object[] arg10 = ToLua.CheckObjectArray(L, 11);
			AnimData o = AnimSystem.CustomMethodToVector2(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CustomMethodToVector3(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 11);
			AnimCustomMethodVector3 arg0 = null;
			LuaTypes funcType1 = LuaDLL.lua_type(L, 1);

			if (funcType1 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (AnimCustomMethodVector3)ToLua.CheckObject(L, 1, typeof(AnimCustomMethodVector3));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 1);
				arg0 = DelegateFactory.CreateDelegate(typeof(AnimCustomMethodVector3), func) as AnimCustomMethodVector3;
			}

			UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)ToLua.CheckObject(L, 2, typeof(UnityEngine.Vector3));
			UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)ToLua.CheckObject(L, 3, typeof(UnityEngine.Vector3));
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
			float arg4 = (float)LuaDLL.luaL_checknumber(L, 5);
			InterpType arg5 = (InterpType)ToLua.CheckObject(L, 6, typeof(InterpType));
			bool arg6 = LuaDLL.luaL_checkboolean(L, 7);
			RepeatType arg7 = (RepeatType)ToLua.CheckObject(L, 8, typeof(RepeatType));
			int arg8 = (int)LuaDLL.luaL_checknumber(L, 9);
			AnimCallBack arg9 = null;
			LuaTypes funcType10 = LuaDLL.lua_type(L, 10);

			if (funcType10 != LuaTypes.LUA_TFUNCTION)
			{
				 arg9 = (AnimCallBack)ToLua.CheckObject(L, 10, typeof(AnimCallBack));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 10);
				arg9 = DelegateFactory.CreateDelegate(typeof(AnimCallBack), func) as AnimCallBack;
			}

			object[] arg10 = ToLua.CheckObjectArray(L, 11);
			AnimData o = AnimSystem.CustomMethodToVector3(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BezierMove(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 10 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(float), typeof(InterpType), typeof(bool), typeof(PathType), typeof(float[]), typeof(AnimCallBack), typeof(object[])))
			{
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)ToLua.ToObject(L, 2);
				UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)ToLua.ToObject(L, 3);
				float arg3 = (float)LuaDLL.lua_tonumber(L, 4);
				InterpType arg4 = (InterpType)ToLua.ToObject(L, 5);
				bool arg5 = LuaDLL.lua_toboolean(L, 6);
				PathType arg6 = (PathType)ToLua.ToObject(L, 7);
				float[] arg7 = ToLua.CheckNumberArray<float>(L, 8);
				AnimCallBack arg8 = null;
				LuaTypes funcType9 = LuaDLL.lua_type(L, 9);

				if (funcType9 != LuaTypes.LUA_TFUNCTION)
				{
					 arg8 = (AnimCallBack)ToLua.ToObject(L, 9);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 9);
					arg8 = DelegateFactory.CreateDelegate(typeof(AnimCallBack), func) as AnimCallBack;
				}

				object[] arg9 = ToLua.CheckObjectArray(L, 10);
				AnimData o = AnimSystem.BezierMove(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 10 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(UnityEngine.Vector3), typeof(float), typeof(RepeatType), typeof(InterpType), typeof(bool), typeof(PathType), typeof(float[]), typeof(AnimCallBack), typeof(object[])))
			{
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)ToLua.ToObject(L, 2);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
				RepeatType arg3 = (RepeatType)ToLua.ToObject(L, 4);
				InterpType arg4 = (InterpType)ToLua.ToObject(L, 5);
				bool arg5 = LuaDLL.lua_toboolean(L, 6);
				PathType arg6 = (PathType)ToLua.ToObject(L, 7);
				float[] arg7 = ToLua.CheckNumberArray<float>(L, 8);
				AnimCallBack arg8 = null;
				LuaTypes funcType9 = LuaDLL.lua_type(L, 9);

				if (funcType9 != LuaTypes.LUA_TFUNCTION)
				{
					 arg8 = (AnimCallBack)ToLua.ToObject(L, 9);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 9);
					arg8 = DelegateFactory.CreateDelegate(typeof(AnimCallBack), func) as AnimCallBack;
				}

				object[] arg9 = ToLua.CheckObjectArray(L, 10);
				AnimData o = AnimSystem.BezierMove(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 10 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(UnityEngine.Vector3), typeof(float), typeof(InterpType), typeof(RepeatType), typeof(bool), typeof(PathType), typeof(UnityEngine.Vector3[]), typeof(AnimCallBack), typeof(object[])))
			{
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)ToLua.ToObject(L, 2);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
				InterpType arg3 = (InterpType)ToLua.ToObject(L, 4);
				RepeatType arg4 = (RepeatType)ToLua.ToObject(L, 5);
				bool arg5 = LuaDLL.lua_toboolean(L, 6);
				PathType arg6 = (PathType)ToLua.ToObject(L, 7);
				UnityEngine.Vector3[] arg7 = ToLua.CheckObjectArray<UnityEngine.Vector3>(L, 8);
				AnimCallBack arg8 = null;
				LuaTypes funcType9 = LuaDLL.lua_type(L, 9);

				if (funcType9 != LuaTypes.LUA_TFUNCTION)
				{
					 arg8 = (AnimCallBack)ToLua.ToObject(L, 9);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 9);
					arg8 = DelegateFactory.CreateDelegate(typeof(AnimCallBack), func) as AnimCallBack;
				}

				object[] arg9 = ToLua.CheckObjectArray(L, 10);
				AnimData o = AnimSystem.BezierMove(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 10 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(float), typeof(InterpType), typeof(bool), typeof(PathType), typeof(UnityEngine.Vector3[]), typeof(AnimCallBack), typeof(object[])))
			{
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)ToLua.ToObject(L, 2);
				UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)ToLua.ToObject(L, 3);
				float arg3 = (float)LuaDLL.lua_tonumber(L, 4);
				InterpType arg4 = (InterpType)ToLua.ToObject(L, 5);
				bool arg5 = LuaDLL.lua_toboolean(L, 6);
				PathType arg6 = (PathType)ToLua.ToObject(L, 7);
				UnityEngine.Vector3[] arg7 = ToLua.CheckObjectArray<UnityEngine.Vector3>(L, 8);
				AnimCallBack arg8 = null;
				LuaTypes funcType9 = LuaDLL.lua_type(L, 9);

				if (funcType9 != LuaTypes.LUA_TFUNCTION)
				{
					 arg8 = (AnimCallBack)ToLua.ToObject(L, 9);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 9);
					arg8 = DelegateFactory.CreateDelegate(typeof(AnimCallBack), func) as AnimCallBack;
				}

				object[] arg9 = ToLua.CheckObjectArray(L, 10);
				AnimData o = AnimSystem.BezierMove(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 11 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(float), typeof(RepeatType), typeof(InterpType), typeof(bool), typeof(PathType), typeof(float[]), typeof(AnimCallBack), typeof(object[])))
			{
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)ToLua.ToObject(L, 2);
				UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)ToLua.ToObject(L, 3);
				float arg3 = (float)LuaDLL.lua_tonumber(L, 4);
				RepeatType arg4 = (RepeatType)ToLua.ToObject(L, 5);
				InterpType arg5 = (InterpType)ToLua.ToObject(L, 6);
				bool arg6 = LuaDLL.lua_toboolean(L, 7);
				PathType arg7 = (PathType)ToLua.ToObject(L, 8);
				float[] arg8 = ToLua.CheckNumberArray<float>(L, 9);
				AnimCallBack arg9 = null;
				LuaTypes funcType10 = LuaDLL.lua_type(L, 10);

				if (funcType10 != LuaTypes.LUA_TFUNCTION)
				{
					 arg9 = (AnimCallBack)ToLua.ToObject(L, 10);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 10);
					arg9 = DelegateFactory.CreateDelegate(typeof(AnimCallBack), func) as AnimCallBack;
				}

				object[] arg10 = ToLua.CheckObjectArray(L, 11);
				AnimData o = AnimSystem.BezierMove(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 13 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(float), typeof(float), typeof(RepeatType), typeof(int), typeof(InterpType), typeof(bool), typeof(PathType), typeof(UnityEngine.Vector3[]), typeof(AnimCallBack), typeof(object[])))
			{
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)ToLua.ToObject(L, 2);
				UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)ToLua.ToObject(L, 3);
				float arg3 = (float)LuaDLL.lua_tonumber(L, 4);
				float arg4 = (float)LuaDLL.lua_tonumber(L, 5);
				RepeatType arg5 = (RepeatType)ToLua.ToObject(L, 6);
				int arg6 = (int)LuaDLL.lua_tonumber(L, 7);
				InterpType arg7 = (InterpType)ToLua.ToObject(L, 8);
				bool arg8 = LuaDLL.lua_toboolean(L, 9);
				PathType arg9 = (PathType)ToLua.ToObject(L, 10);
				UnityEngine.Vector3[] arg10 = ToLua.CheckObjectArray<UnityEngine.Vector3>(L, 11);
				AnimCallBack arg11 = null;
				LuaTypes funcType12 = LuaDLL.lua_type(L, 12);

				if (funcType12 != LuaTypes.LUA_TFUNCTION)
				{
					 arg11 = (AnimCallBack)ToLua.ToObject(L, 12);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 12);
					arg11 = DelegateFactory.CreateDelegate(typeof(AnimCallBack), func) as AnimCallBack;
				}

				object[] arg12 = ToLua.CheckObjectArray(L, 13);
				AnimData o = AnimSystem.BezierMove(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: AnimSystem.BezierMove");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Blink(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 9);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.GameObject));
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
			bool arg4 = LuaDLL.luaL_checkboolean(L, 5);
			RepeatType arg5 = (RepeatType)ToLua.CheckObject(L, 6, typeof(RepeatType));
			int arg6 = (int)LuaDLL.luaL_checknumber(L, 7);
			AnimCallBack arg7 = null;
			LuaTypes funcType8 = LuaDLL.lua_type(L, 8);

			if (funcType8 != LuaTypes.LUA_TFUNCTION)
			{
				 arg7 = (AnimCallBack)ToLua.CheckObject(L, 8, typeof(AnimCallBack));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 8);
				arg7 = DelegateFactory.CreateDelegate(typeof(AnimCallBack), func) as AnimCallBack;
			}

			object[] arg8 = ToLua.CheckObjectArray(L, 9);
			AnimData o = AnimSystem.Blink(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ValueTo(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			AnimSystem.AnimParamHash arg0 = (AnimSystem.AnimParamHash)ToLua.CheckObject(L, 1, typeof(AnimSystem.AnimParamHash));
			AnimData o = AnimSystem.ValueTo(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StopAnim(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(AnimData), typeof(bool)))
			{
				AnimData arg0 = (AnimData)ToLua.ToObject(L, 1);
				bool arg1 = LuaDLL.lua_toboolean(L, 2);
				AnimSystem.StopAnim(arg0, arg1);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(bool)))
			{
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				bool arg1 = LuaDLL.lua_toboolean(L, 2);
				AnimSystem.StopAnim(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: AnimSystem.StopAnim");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FinishAnim(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			AnimData arg0 = (AnimData)ToLua.CheckObject(L, 1, typeof(AnimData));
			AnimSystem.FinishAnim(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearAllAnim(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			bool arg0 = LuaDLL.luaL_checkboolean(L, 1);
			AnimSystem.ClearAllAnim(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_animList(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			AnimSystem obj = (AnimSystem)o;
			System.Collections.Generic.List<AnimData> ret = obj.animList;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index animList on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_animList(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			AnimSystem obj = (AnimSystem)o;
			System.Collections.Generic.List<AnimData> arg0 = (System.Collections.Generic.List<AnimData>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<AnimData>));
			obj.animList = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index animList on a nil value" : e.Message);
		}
	}
}

