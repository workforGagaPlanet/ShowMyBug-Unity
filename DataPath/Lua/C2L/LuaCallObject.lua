--Lua实例化一个类
--C# NPC obj=new NPC();

local obj=CS.NPC() --没有命名空间就不写命名空间
obj.HP=100
print(obj.HP)

--有参构造函数
local obj1=CS.NPC("admin")
print(obj1.name)

--注意！调用对象的方法用冒号:代替.
--表方法希望调用表成员变量（表：方法（））
--因为C#代码中有this.name，对应lua中的self
print(obj1:Output())

--lua实例化GameObject
CS.UnityEngine.GameObject("LuaCreateGO")