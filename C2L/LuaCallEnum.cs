using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum TestEnum
{
    Lol,
    Dota,
}
public class LuaCallEnum : MonoBehaviour
{
    void Start()
    {
        xLuaEnv.Instance.Dostring("require('C2L/LuaCallEnum')");
    }

    private void OnDestroy()
    {
        xLuaEnv.Instance.Free();
    }


}
