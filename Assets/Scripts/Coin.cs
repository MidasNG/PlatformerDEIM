using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private Music source;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        source.CoinPick();
        Destroy(gameObject);
    }
}
