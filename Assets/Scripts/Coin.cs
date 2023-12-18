using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private Music source;
    [SerializeField] private CoinCount count;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        count.Increase();
        source.CoinPick();
        Destroy(gameObject);
    }
}
