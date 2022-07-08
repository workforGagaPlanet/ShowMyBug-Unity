using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void EventLua();

public class TestEvent
{
    public static event EventLua Static;

    public static void StaticFunc()
    {
        Debug.Log("static Func");
    }

    public static  void CallStatic()
    {
        if(Static !=null)
        {
            Static();
        }
    }
    public event EventLua Dynamic;

    public void CallDynamic()
    {//非静态可以调用非静态事件
        if(Dynamic !=null)
        {
            Dynamic();
        }
    }
}


public class LuaCallEvent : MonoBehaviour
{
    void Start()
    {
        xLuaEnv.Instance.Dostring("require('C2L/LuaCallGenericType')");
    }

    private void OnDestroy()
    {
        xLuaEnv.Instance.Free();
    }
}
