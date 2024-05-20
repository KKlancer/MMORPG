//==========================
// - FileName: ProductDBModelExt.cs
// - Created: #AuthorName#
// - CreateTime: #CreateTime#
// - Email: #AuthorEmail#
// - Region: #Location#
// - Description:
//==========================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class ProductDBModel
{
    public void Test()
    {

    }
    public ProductDataEntity GetByName(string name)
    {
        foreach(ProductDataEntity entity in ProductDBModel.Instance.GetList())
        {
            if(entity.Name==name)
            {
                return entity;
            }
        }
        return null;
    }
}
