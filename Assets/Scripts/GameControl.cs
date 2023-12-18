using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    [SerializeField] private SceneChanger sceneLoad;
    private bool pause = false;
    [SerializeField] Button menu, unpause;
    public void StartGame()
    {
        sceneLoad.StartGame();
    }
    public void Quit()
    {
        Application.Quit();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Pause")) Pause();

        if (pause)
        {
            Time.timeScale = 0; if (menu != null) menu.gameObject.SetActive(true); if (unpause != null) unpause.gameObject.SetActive(true);
        }
        else
        {
            Time.timeScale = 1; if (menu != null) menu.gameObject.SetActive(false); if (unpause != null) unpause.gameObject.SetActive(false);
        }
    }

    public void Pause()
    {
        pause = !pause;
    }
}
