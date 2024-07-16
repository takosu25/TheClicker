using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Money : MonoBehaviour
{
    [SerializeField]
    private UnityEvent Click;

    public void OnClicked()
    {
        Click.Invoke();
    }
}
