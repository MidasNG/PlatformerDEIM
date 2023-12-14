using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void Change(string Level)
    {
        StartCoroutine(SceneChange(Level));
    }
    private IEnumerator SceneChange(string Level)
    {
        SceneManager.LoadScene(Level);
        yield return null;
    }
}
