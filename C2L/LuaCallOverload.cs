using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestOverload
{
    public static void Test(int id)
    {
        Debug.Log("id:"+id);
    }
    public static void Test(string name)
    {
        Debug.Log("name" + name);
    }
    public static void Test(int id,string name)
    {
        Debug.Log("name&id" + id + name);
    }
}

public class LuaCallOverload : MonoBehaviour
{
    void Start()
    {
        xLuaEnv.Instance.Dostring("require('C2L/LuaCallOverload')");
    }

    private void OnDestroy()
    {
        xLuaEnv.Instance.Free();
    }
}
