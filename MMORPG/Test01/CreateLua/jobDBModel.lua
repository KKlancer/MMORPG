require "Download/XLuaLogic/Data/Create/jobEntity"

--数据访问
jobDBModel = { }

local this = jobDBModel;

local jobTable = { }; --定义表格

function jobDBModel.New()
    return this;
end

function jobDBModel.Init()

    --这里从C#代码中获取一个数组

    local gameDataTable = CS.LuaHelper.Instance:GetData("job.data");
    --表格的前三行是表头 所以获取数据时候 要从 3 开始
    --print("行数"..gameDataTable.Row);
    --print("列数"..gameDataTable.Column);

    for i = 3, gameDataTable.Row - 1, 1 do
        jobTable[#jobTable+1] = jobEntity.New( tonumber(gameDataTable.Data[i][0]), gameDataTable.Data[i][1], gameDataTable.Data[i][2], gameDataTable.Data[i][3], gameDataTable.Data[i][4], gameDataTable.Data[i][5] );
    end

end

function jobDBModel.GetList()
    return jobTable;
end