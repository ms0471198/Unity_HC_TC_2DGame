using UnityEngine;      // 引用 Unity API

//類別 類別名稱
public class First : MonoBehaviour
{
    // 程式內容
    // 宣告變數 - 定義欄位 Field
    // 修飾詞 欄位類型  欄位名稱 結束
    // 私人 - 隱藏 private(預設)
    // 公開 - 顯示 public
    public int coin;                    // 整數
    public float speed;                 // 浮點數
    public string prop;                 // 字串
    public bool dead;                   //布林值
}

// 程式內容
[Header("目前分數")]
    public int score;
    [Header("最佳分數")]
    public int scoreHeight;
    [Header("水管群組")]
    public GameObject pipe;     // GameObject 可以存放場景上的物件或專案內的預製物
    [Header("結束畫面")]
    public GameObject goFinal;
    public Text textScore;
    public Text textHeight;

    /// <summary>
    /// 加分
    /// </summary>
    /// <param name="add">要添加的分數，預設為 1</param>
    public void AddScore(int add = 1)
    {
        print("加分!!!");
        score = score + add;
        textScore.text = score.ToString();

        SetHeightSeore();
    }

    /// <summary>
    /// 設定最佳分數。
    /// </summary>
    private void SetHeightScore()
    {
        if(score > scoreHeight)
        {
            PlayerPrefs.SetInt("最佳分數", seore);
        }
                
                }

    /// <summary>
    /// 遊戲結束
    /// </summary>
    public void GameOver()
    {
        goFinal.SetActive(true);
        CancelInvoke("SpawnPipe");  // 取消調用 ("方法名稱");
    }

   
    
    
    /// <summary>
    /// 生成水管的方法。
    /// </summary>
    private void SpawnPipe()
    {
        // 三維向量 = new 三維向量(x, y, z);
        //Vector3 p = new Vector3(6, Random.Range(-0.7f, 1.3f), 0);

        float r = Random.Range(-0.7f, 1.3f);
        Vector3 p = new Vector3(6, r, 0);

        // Quaternion.identity 零角度

        // 實例化 - 生成 (物件)
        Instantiate(pipe, p, Quaternion.identity);
    }

    private void Start()
    {
        //SpawnPipe();
        // 延遲調用("方法名稱"，延遲時間)
        // Invoke("SpawnPipe", 1.5f);
        // 延遲重複調用("方法名稱"，延遲時間，重複頻率);
        InvokeRepeating("SpawnPipe", 0, 1.8f);

        seoreHeight -PlayerPrefs.GetInt("最佳分數")
        textHright.text - PlayerPrefs.GetInt("最佳分數").ToString()；
    }

   }
{
      