--Lua添加事件
CS.TestEvent.Static("+",CS.TestEvent.StaticFunc)
CS.TestEvent.CallStatic();
CS.TestEvent.Static("-",CS.TestEvent.StaticFunc)


--添加动态成员变量
local func=function()
	print("luaFunc()")
end
local obj=CS.TestEvent()
obj:Dynamic("+",func)
obj:CallDynamic()
obj:Dynamic("-",func)
