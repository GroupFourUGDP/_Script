
/// <summary>
/// 所有具有锁性质的场景道具接口
/// </summary>
public interface ILock
{
    /// <summary>
    /// 上锁
    /// </summary>
    void Lock();
    /// <summary>
    /// 解锁
    /// </summary>
    void UnLock();
}