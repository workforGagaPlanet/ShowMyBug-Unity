using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct TestStruct
{
    public string name;
    public string Output()
    {
        return name;
    }
}
public class LuaCallStruct : MonoBehaviour
{


    void Start()
    {
        xLuaEnv.Instance.Dostring("require('C2L/LuaCallStruct')");
    }

    private void OnDestroy()
    {
        xLuaEnv.Instance.Free();
    }


}
