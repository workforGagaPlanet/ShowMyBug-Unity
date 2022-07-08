using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGenericType
{
    public void Output<T>(T data)
    {
        Debug.Log("泛型方法:" + data.ToString());
    }
    public void Output(float data)
    {
        Output<float>(data);
    }
    public void Output(string data)
    {
        Output<string>(data);
    }
}

public class LuaCallGenericType : MonoBehaviour
{
    void Start()
    {
        //对于内置的泛型方法，如下，有非泛型的API
        //gameObject.AddComponent<BoxCollider>();
        //gameObject.AddComponent(typeof(BoxCollider));
        xLuaEnv.Instance.Dostring("require('C2L/LuaCallGenericType')");
    }

    private void OnDestroy()
    {
        xLuaEnv.Instance.Free();
    }
}
