using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private Music music;
    [SerializeField] private CharacterController character;
    public void Change(string Level)
    {
        StartCoroutine(SceneChange(Level));
    }
    private IEnumerator SceneChange(string Level)
    {
        character.StopControl();
        music.Victory();
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(Level);
        yield return null;
    }
}
