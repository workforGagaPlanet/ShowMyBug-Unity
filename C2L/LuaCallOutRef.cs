using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestOutRef
{
    public static string Func1()
    {
        return "Func1";
    }
    public static string Func2(string str1,out string str2)
    {
        str2 = "Func2 out";
        return "Func2";
    }
    public static string Func3(string str1, ref string str2)
    {
        str2 = "Func3 ref";
        return "Func3";
    }
}


public class LuaCallOutRef : MonoBehaviour
{
    void Start()
    {
        xLuaEnv.Instance.Dostring("require('C2L/LuaCallOutRef')");
    }

    private void OnDestroy()
    {
        xLuaEnv.Instance.Free();
    }
}
