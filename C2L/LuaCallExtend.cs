using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
public class TestExtend
{
    public void Output()
    {
        Debug.Log("类自身方法");
    }
}

//扩展方法和包含扩展方法的类必须是静态的
//扩展方法前必须加上特性
[LuaCallCSharp]
public static class MyExtend
{
    public static void Show(this TestExtend obj)
    {
        Debug.Log("类扩展的方法");
    }
}

public class LuaCallExtend : MonoBehaviour
{
    void Start()
    {
        xLuaEnv.Instance.Dostring("require('C2L/LuaCallExtend')");
    }

    private void OnDestroy()
    {
        xLuaEnv.Instance.Free();
    }
}
