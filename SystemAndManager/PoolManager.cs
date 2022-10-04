

public class PoolManager : Singleton<PoolManager>
{
    public override void Awake()
    {
        base.Awake();
        DontDestroyOnLoad(this.gameObject);
    }
}
