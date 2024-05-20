/// <summary>
/// 类名 : RoleEntity
/// 作者 : 北京-边涯
/// 说明 : 
/// 创建日期 : 2016-12-11 21:21:38
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Mmcoy.Framework.AbstractBase;

/// <summary>
/// 
/// </summary>
[Serializable]
public partial class RoleEntity : MFAbstractEntity
{
    #region 重写基类属性
    /// <summary>
    /// 主键
    /// </summary>
    public override int? PKValue
    {
        get
        {
            return this.Id;
        }
        set
        {
            this.Id = value;
        }
    }
    #endregion

    #region 实体属性

    /// <summary>
    /// 编号
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    public EnumEntityStatus Status { get; set; }

    /// <summary>
    ///所属帐号Id 
    /// </summary>
    public int AccountId { get; set; }

    /// <summary>
    ///职业编号 
    /// </summary>
    public int JobId { get; set; }

    /// <summary>
    ///昵称 
    /// </summary>
    public string NickName { get; set; }

    /// <summary>
    ///性别 
    /// </summary>
    public byte Sex { get; set; }

    /// <summary>
    ///等级 
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public int Money { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public int Gold { get; set; }

    /// <summary>
    ///经验 
    /// </summary>
    public int Exp { get; set; }

    /// <summary>
    ///最大HP 
    /// </summary>
    public int MaxHP { get; set; }

    /// <summary>
    ///最大MP 
    /// </summary>
    public int MaxMP { get; set; }

    /// <summary>
    ///当前HP 
    /// </summary>
    public int CurrHP { get; set; }

    /// <summary>
    ///当前MP 
    /// </summary>
    public int CurrMP { get; set; }

    /// <summary>
    ///攻击力 
    /// </summary>
    public int Attack { get; set; }

    /// <summary>
    ///防御 
    /// </summary>
    public int Defense { get; set; }

    /// <summary>
    ///命中 
    /// </summary>
    public int Hit { get; set; }

    /// <summary>
    ///闪避 
    /// </summary>
    public int Dodge { get; set; }

    /// <summary>
    ///暴击 
    /// </summary>
    public int Cri { get; set; }

    /// <summary>
    ///抗性 
    /// </summary>
    public int Res { get; set; }

    /// <summary>
    ///综合战斗力 
    /// </summary>
    public int Fighting { get; set; }

    /// <summary>
    ///最后进入的世界地图编号 
    /// </summary>
    public int LastPassGameLevelId { get; set; }

    /// <summary>
    ///最后进入的世界地图编号 
    /// </summary>
    public int LastInWorldMapId { get; set; }

    /// <summary>
    ///x_y_z_y轴旋转 
    /// </summary>
    public string LastInWorldMapPos { get; set; }

    /// <summary>
    ///创建时间 
    /// </summary>
    public DateTime CreateTime { get; set; }

    /// <summary>
    ///更新时间 
    /// </summary>
    public DateTime UpdateTime { get; set; }

    #endregion
}
