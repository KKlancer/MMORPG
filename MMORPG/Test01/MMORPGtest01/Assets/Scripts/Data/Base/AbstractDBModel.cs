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
using System.IO;

public abstract class AbstractDBModel<T,P> where T:class,new() where P:AbstractEntity
{
    protected List<P> m_list;
    protected Dictionary<int, P> m_dic;

    protected AbstractDBModel()
    {
        m_list = new List<P>();
        m_dic = new Dictionary<int, P>();
        LoadData();
    }
    #region ����
    private static T instance;
    public static T Instance
    {
        get
        {
            if(instance==null)
            {
                instance = new T();
            }
            return instance;
        }
    }
    #endregion
    #region ��Ҫ����ʵ�ֵ����Ի򷽷�
    protected abstract string FileName { get; }
    protected abstract P MakeEntity(GameDataTableParser parse);
    #endregion
    /// <summary>
    /// ��������
    /// </summary>
    protected void LoadData()
    {
        using (GameDataTableParser parse = new GameDataTableParser(string.Format(@"F:\self\MMORPG\Test01\MMORPGtest01\www\Data\{0}", FileName)))
        {
            while(!parse.Eof)
            {


                //����ʵ��
                P p = MakeEntity(parse);
                m_list.Add(p);
                m_dic[p.Id] = p;
                parse.Next();
            }
        }
    }
    /// <summary>
    /// ��ȡ����
    /// </summary>
    /// <returns></returns>
    public List<P> GetList()
    {
        if(m_list!=null)
        {
            return m_list;
        }
        return null;
    }
    /// <summary>
    /// ���ݱ�Ż�ȡʵ��
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public P Get(int id)
    {
        if(m_dic.ContainsKey(id))
        {
            return m_dic[id];
        }
        return null;
    }
}
