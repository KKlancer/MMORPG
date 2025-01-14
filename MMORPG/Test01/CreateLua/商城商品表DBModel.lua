require "Download/XLuaLogic/Data/Create/商城商品表Entity"

--数据访问
商城商品表DBModel = { }

local this = 商城商品表DBModel;

local 商城商品表Table = { }; --定义表格

function 商城商品表DBModel.New()
    return this;
end

function 商城商品表DBModel.Init()

    --这里从C#代码中获取一个数组

    local gameDataTable = CS.LuaHelper.Instance:GetData("商城商品表.data");
    --表格的前三行是表头 所以获取数据时候 要从 3 开始
    --print("行数"..gameDataTable.Row);
    --print("列数"..gameDataTable.Column);

    for i = 3, gameDataTable.Row - 1, 1 do
        商城商品表Table[#商城商品表Table+1] = 商城商品表Entity.New( tonumber(gameDataTable.Data[i][0]), gameDataTable.Data[i][1], tonumber(gameDataTable.Data[i][2]), gameDataTable.Data[i][3], gameDataTable.Data[i][4] );
    end

end

function 商城商品表DBModel.GetList()
    return 商城商品表Table;
end