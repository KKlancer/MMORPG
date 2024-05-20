//==========================
// - FileName: AbstractDBModel.cs
// - Created: #AuthorName#
// - CreateTime: #CreateTime#
// - Email: #AuthorEmail#
// - Region: #Location#
// - Description:
//==========================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class ProductDataEntity : AbstractEntity
{
    /// <summary>
    /// 商品名称
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// 商品价格
    /// </summary>
    public float Price { get; set; }
    /// <summary>
    /// 图片名称
    /// </summary>
    public string PicName { get; set; }
    /// <summary>
    /// 描述
    /// </summary>
    public string Desc { get; set; }
}
