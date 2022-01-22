using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
public class SceneLoadManager : MonoBehaviour
{
    [SerializeField] private float transitionTime = 1f;

    private Animator transitionAnimator;


    void Start()
    {
        transitionAnimator = GetComponentInChildren<Animator>();    
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            LoadNextScene();
        }   
    }

    public void LoadNextScene()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex +1;
       StartCoroutine( SceneLoad(nextSceneIndex));
    }
    public IEnumerator SceneLoad(int sceneIndex)
    {
        transitionAnimator.SetTrigger("StartTrancition");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneIndex);

    }

}
*/