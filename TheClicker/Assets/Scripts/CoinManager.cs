using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager
{
    // ���ݏ������Ă���R�C����
    private int currentCoin = 0;

    /// <summary>
    /// �R�C����ǉ�����
    /// </summary>
    public void AddCoin(int add)
    {
        currentCoin += add;
    }

    /// <summary>
    /// �R�C�����擾����
    /// </summary>
    public int GetCoin() => currentCoin;
}
