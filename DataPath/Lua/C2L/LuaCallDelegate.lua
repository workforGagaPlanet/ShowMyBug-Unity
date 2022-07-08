--C#给委托赋值
--TestDelegate.Static=TestDelegate.StaticFunc
--TestDelegate.Static+=TestDelegate.StaticFunc
--TestDelegate.Static-=TestDelegate.StaticFunc
--TestDelegate.Static()

--------------------------------------------
--lua调用静态委托
CS.TestDelegate.Static=CS.TestDelegate.StaticFunc
--委托不为空才调用
if(CS.TestDelegate.Static~=nil)
	then
CS.TestDelegate.Static()
end
--静态委托之后不用一定要释放掉，不然会报错
CS.TestDelegate.Static=nil
------------------------------------------------
local func=function ()
	print("luaFunction")
end
--在lua中添加委托
CS.TestDelegate.Static=func
--委托+和-之前也要判空
if(CS.TestDelegate.Static~=nil)
	then
CS.TestDelegate.Static=CS.TestDelegate.Static+func
end
if(CS.TestDelegate.Static~=nil)
	then
CS.TestDelegate.Static=CS.TestDelegate.Static-func
end
if(CS.TestDelegate.Static~=nil)
	then
CS.TestDelegate.Static()
end
CS.TestDelegate.Static=nil
---------------------------------------------------
--lua调用动态委托
local obj1=CS.TestDelegate()
obj1.Dynamic=func
obj1.Dynamic()
--动态委托可以不释放
obj1.Dynamic=nil