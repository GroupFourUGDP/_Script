using UnityEngine;

/// <summary>
/// 命令接口
/// </summary>
public interface ICommand
{
    /// <summary>
    /// 执行函数
    /// </summary>
    void Execute(GameObject obj);

    /// <summary>
    /// 重新执行命令
    /// </summary>
    void ReDo();

    /// <summary>
    /// 撤销命令
    /// </summary>
    void UnDo();
}