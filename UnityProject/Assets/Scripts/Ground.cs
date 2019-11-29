using UnityEngine;

public class Ground : MonoBehaviour
{
    // 靜態 此類別共用
    // 隱藏
    // [Header("速度"), Range(0.1f, 100f)]
    public static float speed = 3f;

    public Transform ground;

    private void Update()
    {
        Move();
    }

    /// <summary>
    /// 地板的移動方法。
    /// </summary>
    private void Move()
    {
        // Time.deltaTime 一個影格的時間 (根據電腦效能不同)
        ground.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
