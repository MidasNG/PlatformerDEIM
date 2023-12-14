using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private AudioSource coinPick;

    private void Start()
    {
        coinPick = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        coinPick.Play();
        Destroy(gameObject);
    }
}
