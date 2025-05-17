using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeToNext : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
