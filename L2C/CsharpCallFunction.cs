using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public delegate void Func1();
[CSharpCallLua]
public delegate void Func2(string name);
public delegate string Func3();
[CSharpCallLua]
public delegate void Func5(int name);

[CSharpCallLua]//如果unity仍然报错，可能需要更改工程设置-API
public delegate void Func4( out string name,out int id);

public class CsharpCallFunction : MonoBehaviour
{
    void Start()
    {
        xLuaEnv.Instance.Dostring("return require('L2C/CsharpCallFunction')");

        LuaTable g = xLuaEnv.Instance.Global;

        //lua的函数会导出为C#的委托类型
        Func1 func1= g.Get<Func1>("func1");
        func1();

        Func2 func2 = g.Get<Func2>("func2");
        func2("admin");

        Func5 func5 = g.Get<Func5>("func2");
        func5(555);

        Func3 func3 = g.Get<Func3>("func3");
        Debug.Log(func3());

        Func4 func4 = g.Get<Func4>("func4");

        string name;
        int id;
        func4(out name,out id);

        Debug.Log(name + "  " + id);
    }

    void OnDestroy()
    {
        xLuaEnv.Instance.Free();
    }
}
