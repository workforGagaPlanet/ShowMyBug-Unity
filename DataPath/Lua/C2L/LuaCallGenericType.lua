local obj =CS.TestGenericType()
obj:Output(99)
obj:Output("admin")

local go=CS.UnityEngine.GameObject("LuaCreateGO")
--xlua实现了typeof关键字，所以可以使用类型API替代Unity内置的泛型
go:AddComponent(typeof(CS.UnityEngine.BoxCollider))