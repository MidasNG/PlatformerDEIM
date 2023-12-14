using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCount : MonoBehaviour
{
    [SerializeField] private SceneChanger sceneChange;
    [SerializeField] private string levelName;
    void Update()
    {
        if (transform.childCount == 0) sceneChange.Change(levelName);
    }
}
