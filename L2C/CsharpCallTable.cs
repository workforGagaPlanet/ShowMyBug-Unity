using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;



public class CsharpCallTable : MonoBehaviour
{
    void Start()
    {
        xLuaEnv.Instance.Dostring("return require('L2C/CsharpCallTable')");
        UserTable();
    }
    public void UserTable()
    {
        LuaTable g = xLuaEnv.Instance.Global;

        LuaTable core = g.Get<LuaTable>("Core");
        //获取表中的字符串，和获取全局变量没有什么区别
        core.Set<string, string>("Name", "adminINCsharp");
        Debug.Log(core.Get<string>("Name"));
        //获取空类型方法，无返回值，也无太大区别
        Func1 func1 = core.Get<Func1>("func1");
        func1();

        //获取表中所有的整数，汇集成一个新的整数型集合
        //即使表中有杂七杂八类型的变量，都可以提取出来其中的整数
        //，不一定非要是纯整数变量的表
        List<int> list = g.Get<List<int>>("Core");
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log("List: " + list[i]);
        }
    }
    void OnDestroy()
    {
        xLuaEnv.Instance.Free();
    }
}
