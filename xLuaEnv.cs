using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;

public class xLuaEnv
{
    #region Singleton
    private static xLuaEnv _Instance = null;
    public static xLuaEnv Instance
    {
        get
        {
            if (_Instance == null)
            {//创造单例
                _Instance = new xLuaEnv();
            }
            return _Instance;
        }

    }
    #endregion

    #region LuaEnv
    private LuaEnv _Env;
    private xLuaEnv()
    {//创造单例的同时new了一个私有的LuaEnv
        _Env = new LuaEnv();
        _Env.AddLoader(_ProjectLoader);
    }

    private byte[] _ProjectLoader(ref string filepath)
    {
        string path = Application.dataPath;
        path = path.Substring(0, Application.dataPath.Length - 6) + "DataPath/Lua/" + filepath + ".lua";

        if (File.Exists(path))
        {
            return File.ReadAllBytes(path);
        }
        else
        {
            return null;
        }
    }
    #endregion

    #region Free LuaEnv
    public void Free()
    {//将单例中的LuaEnv销毁
        _Env.Dispose();
        //释放单例
        _Instance = null;
    }
    #endregion

    #region RunLua
    public object[] Dostring(string code)
    {
        return _Env.DoString(code);
    }
    //返回lua环境的全局变量
    public LuaTable Global
    {
        get { return _Env.Global; }
        
    }
    #endregion
}
