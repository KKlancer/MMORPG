
//===================================================
//作    者：边涯  http://www.u3dol.com  QQ群：87481002
//创建时间：2024-05-17 09:46:21
//备    注：此代码为工具生成 请勿手工修改
//===================================================
using System.Collections;
using System.Collections.Generic;
using System;

/// <summary>
/// job数据管理
/// </summary>
public partial class jobDBModel : AbstractDBModel<jobDBModel, jobEntity>
{
    /// <summary>
    /// 文件名称
    /// </summary>
    protected override string FileName { get { return "job.data"; } }

    /// <summary>
    /// 创建实体
    /// </summary>
    /// <param name="parse"></param>
    /// <returns></returns>
    protected override jobEntity MakeEntity(GameDataTableParser parse)
    {
        jobEntity entity = new jobEntity();
        entity.Id = parse.GetFieldValue("Id").ToInt();
        entity.Name = parse.GetFieldValue("Name");
        entity.HeadPic = parse.GetFieldValue("HeadPic");
        entity.JobPic = parse.GetFieldValue("JobPic");
        entity.PrefabName = parse.GetFieldValue("PrefabName");
        entity.Desc = parse.GetFieldValue("Desc");
        return entity;
    }
}
