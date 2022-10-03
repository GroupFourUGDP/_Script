public interface IFactory<T>
{
    /// <summary>
    /// 初始化工厂
    /// </summary>
    void Intilaze();
    /// <summary>
    /// 设置工厂的池子
    /// </summary>
    /// <param name="pools"></param>
    void SetPool(IPools<T> pools);
    
    /// <summary>
    /// 从工厂获得对象
    /// </summary>
    T GetObj();

    /// <summary>
    /// 不用的对象返还回来
    /// </summary>
    void ReturnObj(T obj);

    /// <summary>
    /// 创建对象
    /// </summary>
    /// <returns></returns>
    T CreatObj();

    /// <summary>
    /// 清空工厂内置对象池
    /// </summary>
    void ClearPool();
}
