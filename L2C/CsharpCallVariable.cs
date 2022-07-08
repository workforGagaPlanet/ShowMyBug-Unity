using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class CsharpCallVariable : MonoBehaviour
{
    void Start()
    {
        //这种cs获取lua中变量的方式的缺点在于所有的变量都成了object类型
        object[] data= xLuaEnv.Instance.Dostring("return require('L2C/CsharpCallVariable')");
        //Debug.Log(data[0]);

        //LuaEnv提供了一个成员变量Global，它可以用于C#获取Lua的全局变量
        //Global的数据类型是C#实现的luaTable，luaTable是C#和lua中表对应的数据结构
        //xlua会将lua中的全局变量以table的方式全部存储在global中

        //luaTable是C#中的数据对象，用于和lua中的全局变量的table对应
        LuaTable g = xLuaEnv.Instance.Global;

        //从lua中将全局变量提取出来
        //参数：lua中全局变量的名称
        //类型：lua全局变量名称所对应的类型
        int num = g.Get<int>("num");
        float rate = g.Get<float>("rate");
        bool isWoman = g.Get<bool>("isWoman");
        string name = g.Get<string>("name");

        Debug.Log($"{num} {rate} {isWoman} {name}");
    }

    private void OnDestroy()
    {
        xLuaEnv.Instance.Free();
    }
}
