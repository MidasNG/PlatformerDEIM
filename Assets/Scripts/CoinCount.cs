using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCount : MonoBehaviour
{
    [SerializeField] private SceneChanger sceneChange;
    [SerializeField] private string levelName;
    [SerializeField] private TextMeshProUGUI counter;
    private int target, collected;

    private void Start()
    {
        target = transform.childCount; collected = 0;
        counter.text = collected.ToString() + " / " + target.ToString();
    }

    void Update()
    {
        if (transform.childCount == 0) sceneChange.Change(levelName);
    }

    public void Increase()
    {
        collected++;
        counter.text = collected.ToString() + " / " + target.ToString();
    }
}
