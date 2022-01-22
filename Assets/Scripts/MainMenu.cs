using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private float transitionTime = 1f;

    private Animator transitionAnimator;

    void Start()
    {
        transitionAnimator = GetComponentInChildren<Animator>();
    }

    public void PLAYERVSIA()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 2;
         StartCoroutine(SceneLoad(nextSceneIndex));
        
    }

    public void PLAYERVSPLAYER()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        StartCoroutine(SceneLoad(nextSceneIndex));

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
         
        
    }

    public IEnumerator SceneLoad(int sceneIndex)
    {
        transitionAnimator.SetTrigger("StartTrancition");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneIndex);

    }


}
