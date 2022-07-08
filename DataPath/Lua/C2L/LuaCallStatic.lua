--print('LuaCallStatic')
-- Lua调用静态类
--规则“CS.命名空间.类名.成员名”
print(CS.JP.TestStatic.ID)

--给静态属性赋值
CS.JP.TestStatic.Name="admin"
print(CS.JP.TestStatic.Name)
print(CS.JP.TestStatic.ID)

--静态成员方法调用
print(CS.JP.TestStatic.OutPut())
--调用Default使用默认值
CS.JP.TestStatic.Default()
--使用lua的值
CS.JP.TestStatic.Default("def")