using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor.UIElements;
using System;

public class LoadingScreen : MonoBehaviour
{
    public static LoadingScreen instance;

    [SerializeField]
    private GameObject progressBarHolder;

    [SerializeField]
    private Image progressBarFill;
    private float progressValue = 1.1f;
    public float progressMultiplier1 = 0.3f;
    public float progressMultiplier2 = 0.08f;

    public float loadLevelTime = 3f;

    private void Awake()
    {
        MakeSingleton();
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadNewLevel());
    }

    //private string LoadNewLevel()
    //{
    //    throw new NotImplementedException();
    //}

    void MakeSingleton()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void LoadLevel(string levelName)
    {
        progressBarHolder.SetActive(true);
        progressValue = 0f;

        //Time.timescale = 0f;

        SceneManager.LoadScene(levelName);
    }

    void ShowLoadingScreen()
    {
        if(progressValue < 1f)
        {
            progressValue += progressMultiplier1 * progressMultiplier2;
            progressBarFill.fillAmount = progressValue;

            // The progress bar has finished
            if(progressValue >= 1f)
            {
                progressValue = 1.1f;

                progressBarFill.fillAmount = 0f;
                progressBarHolder.SetActive(false);

                //Time.timeScale = 1f;
            }
        } // If the progress value is < 1
    }

    IEnumerator LoadNewLevel()
    {
        yield return new WaitForSeconds(loadLevelTime);

        LoadLevel("Whakamahere");
    }

} // Class
