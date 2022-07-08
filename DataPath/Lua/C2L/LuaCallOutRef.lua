local r1=CS.TestOutRef.Func1();
print(r1)


--C# out返回的变量会赋值给lua的第二个接收返回值变量
local out2
local r2,out1=CS.TestOutRef.Func2("admin",out2) 
print(r2,out1,out2)

--C# ref返回的变量会赋值给lua的第二个接收返回值变量
local ref2
local r3,ref1=CS.TestOutRef.Func3("root",ref2)
print(r3,ref1,ref2)