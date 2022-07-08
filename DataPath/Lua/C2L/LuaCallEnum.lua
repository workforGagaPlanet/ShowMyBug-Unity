--CS.命名空间.枚举名.枚举值
print(CS.TestEnum.Lol)
print(CS.TestEnum.Dota)

--转换获得枚举值
--注意CastFrom前面有两个下划线
print(CS.TestEnum.__CastFrom(0))
print(CS.TestEnum.__CastFrom("Dota"))