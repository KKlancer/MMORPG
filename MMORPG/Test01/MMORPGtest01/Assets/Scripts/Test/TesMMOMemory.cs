//==========================
// - FileName: TesMMOMemory.cs
// - Created: #AuthorName#
// - CreateTime: #CreateTime#
// - Email: #AuthorEmail#
// - Region: #Location#
// - Description:
//==========================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesMMOMemory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ProductDataEntity entity = ProductDBModel.Instance.Get(5);
        ProductDataEntity entity1 = ProductDBModel.Instance.GetByName("ÉÌÆ·Ãû³Æ1");

        jobEntity jobEntity = jobDBModel.Instance.Get(4);
        Debug.Log("name=" + entity.Name);
        Debug.Log("name=" + entity1.Name);
        Debug.Log("jobname=" + jobEntity.Desc);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
