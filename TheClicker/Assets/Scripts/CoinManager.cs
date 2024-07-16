using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager
{
    // 現在所持しているコイン数
    private int currentCoin = 0;

    /// <summary>
    /// コインを追加する
    /// </summary>
    public void AddCoin(int add)
    {
        currentCoin += add;
    }

    /// <summary>
    /// コインを取得する
    /// </summary>
    public int GetCoin() => currentCoin;
}
