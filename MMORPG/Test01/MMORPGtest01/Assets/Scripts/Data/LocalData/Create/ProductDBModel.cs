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
public partial class ProductDBModel : AbstractDBModel<ProductDBModel, ProductDataEntity>
{
    protected override string FileName { get { return "Product.data"; } }

    protected override ProductDataEntity MakeEntity(GameDataTableParser parse)
    {
        ProductDataEntity entity = new ProductDataEntity();
        entity.Id = parse.GetFieldValue("Id").ToInt();
        entity.Name = parse.GetFieldValue("Name");
        entity.Price = parse.GetFieldValue("Price").ToFloat();
        entity.PicName = parse.GetFieldValue("PicName");
        entity.Desc = parse.GetFieldValue("Desc");
        return entity;
    }
}