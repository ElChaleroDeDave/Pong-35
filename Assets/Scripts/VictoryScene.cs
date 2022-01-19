using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class VictoryScene : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadMainMenu",3);
    }

    void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
