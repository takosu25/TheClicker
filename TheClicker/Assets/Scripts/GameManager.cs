using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // お金を管理するマネージャー
    private CoinManager coinManager;

    void Start()
    {
        // 初期化
        coinManager = new CoinManager();
    }

    /// <summary>
    /// CoinManager内にコインを追加する
    /// </summary>
    public void AddCoin(int add)
    {
        coinManager.AddCoin(add);
    }
}
