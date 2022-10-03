public interface IPools<T>
{
    /// <summary>
    /// 从对象池捞一个对象出来
    /// </summary>
    T GetObj();


    /// <summary>
    /// 返还对象到池子去
    /// </summary>
    /// <param name="obj"></param>
    void ReturnObj(T obj);

    /// <summary>
    /// 判断池子是不是空的
    /// </summary>
    /// <returns>是或否</returns>
    bool isEmpty();

    /// <summary>
    /// 清空池子
    /// </summary>
    void ClearPool();
}
