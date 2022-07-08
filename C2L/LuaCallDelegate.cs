using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDelegate
{
    public delegate void DelegateLua();
    
    public static DelegateLua Static;

    public DelegateLua Dynamic;

    public static void StaticFunc()
    {
        Debug.Log("StaticFunc()");
    }

    
}

public class LuaCallDelegate : MonoBehaviour
{
    void Start()
    {
        xLuaEnv.Instance.Dostring("require('C2L/LuaCallDelegate')");
    }

    private void OnDestroy()
    {
        xLuaEnv.Instance.Free();
    }
}
