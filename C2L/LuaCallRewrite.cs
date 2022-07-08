using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Father
{
    public string name = "father";
    public void Talk()
    {
        Debug.Log(name);
    }
    public virtual void VF()
    {
        Debug.Log("Father virtual function");
    }
}
public  class  Child:Father
{
    public override void VF()
    {
        Debug.Log("Child virtual function");
    }
}


public class LuaCallRewrite : MonoBehaviour
{
    void Start()
    {
        xLuaEnv.Instance.Dostring("require('C2L/LuaCallRewrite')");
    }

    private void OnDestroy()
    {
        xLuaEnv.Instance.Free();
    }
}
