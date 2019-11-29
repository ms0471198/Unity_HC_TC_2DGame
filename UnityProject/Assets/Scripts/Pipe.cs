// : 繼承 類別，可以享有繼承類別的成員
public class Pipe : Ground
{
    // 掛腳本的物件要有 Mesh Renderer
    // 在所有攝影機看不到時執行一次
    private void OnBecameInvisible()
    {
        // 刪除(此遊戲物件，延遲 2.5 秒);
        Destroy(gameObject, 5f);
    }

    // 在所有攝影機看到時執行一次
    private void OnBecameVisible()
    {
        
    }
}
