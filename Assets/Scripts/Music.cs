using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private AudioSource source;
    [SerializeField] AudioClip victory, coin;
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void CoinPick()
    {
        source.PlayOneShot(coin);
    }
    
    public void Victory()
    {
        source.PlayOneShot(victory);
    }
}
