using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//https://answers.unity.com/questions/1324119/unity-newbie-needs-scene-change-timer-unity-55-ple.html


public class LoadTimer : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = .5f;
    [SerializeField]
    private string sceneNameToLoad;
    private float timeElapsed;

    void Update()
    {
        timeElapsed += Time.deltaTime;

        if(timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
