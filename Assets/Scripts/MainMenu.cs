using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PLAYERVSIA()
    {
        SceneManager.LoadScene("PLAYERVSIA");
    }

    public void PLAYERVSPLAYER()
    {
        SceneManager.LoadScene("PLAYERVSPLAYER");

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
