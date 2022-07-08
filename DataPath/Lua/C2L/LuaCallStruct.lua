--print("luacallStruct")

--结构体调用和对象调用保持一致
local obj=CS.TestStruct()
obj.name='admin'
print(obj.name)
print(obj:Output())