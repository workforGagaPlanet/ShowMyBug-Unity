using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JP
{
    public static class TestStatic
    {
        public static int ID = 99;
        public static string Name
        {
            get;
            set;
        }
        public static string OutPut()
        {
            return "static";
        }
        public static void  Default(string str="abc")
        {
            Debug.Log(str);
        }
    }
}
public class LuaCallStatic : MonoBehaviour
{
    
    void Start()
    {
        xLuaEnv.Instance.Dostring("require('C2L/LuaCallStatic')");
    }
    private void OnDestroy()
    {
        xLuaEnv.Instance.Free();
    }


}
