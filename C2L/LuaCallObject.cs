using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC
{
    public string name;
    public int HP
    {
        get;
        set;
    }
    public NPC()
    {

    }
    public NPC(string name)
    {
        this.name = name;
    }
    public string Output()
    {
        return name;
    }
}


public class LuaCallObject : MonoBehaviour
{
    
    void Start()
    {
       // GameObject gameObject = new GameObject("C#CreateGO");
        xLuaEnv.Instance.Dostring("require('C2L/LuaCallObject')");
    }

    private void OnDestroy()
    {
        xLuaEnv.Instance.Free();
    }
}
