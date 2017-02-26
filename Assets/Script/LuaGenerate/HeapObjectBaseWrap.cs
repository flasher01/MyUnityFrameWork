﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class HeapObjectBaseWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(HeapObjectBase), typeof(System.Object));
		L.RegFunction("Create", Create);
		L.RegFunction("Release", Release);
		L.RegFunction("New", _CreateHeapObjectBase);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateHeapObjectBase(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				HeapObjectBase obj = new HeapObjectBase();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: HeapObjectBase.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Create(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			HeapObjectBase obj = (HeapObjectBase)ToLua.CheckObject(L, 1, typeof(HeapObjectBase));
			obj.Create();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Release(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			HeapObjectBase obj = (HeapObjectBase)ToLua.CheckObject(L, 1, typeof(HeapObjectBase));
			obj.Release();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

