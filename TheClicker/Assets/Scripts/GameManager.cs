using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // �������Ǘ�����}�l�[�W���[
    private CoinManager coinManager;

    void Start()
    {
        // ������
        coinManager = new CoinManager();
    }

    /// <summary>
    /// CoinManager���ɃR�C����ǉ�����
    /// </summary>
    public void AddCoin(int add)
    {
        coinManager.AddCoin(add);
    }
}
