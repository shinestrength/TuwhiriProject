using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingCircle : MonoBehaviour
{

    public Transform loadingBar;
    [SerializeField] private float currentAmount;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (currentAmount < 100)
        {
            currentAmount += speed * Time.deltaTime;
        }
        loadingBar.GetComponent<Image>().fillAmount = currentAmount / 100;
    }

    //public int sceneID;
    //public Image loadingImg;
    ////public Text progressText;

    //void Start()
    //{
    //    StartCoroutine(AsyncLoad());
    //}

    //IEnumerator AsyncLoad()
    //{
    //    AsyncOperation operation = SceneManager.LoadSceneAsync(sceneID);
    //    while (!operation.isDone)
    //    {
    //        float progress = operation.progress / 0.9f;
    //        loadingImg.fillAmount = progress;
    //        //progressText.text = string.Format("{0:0}%", progress * 100);
    //        yield return null;
    //    }
    //}
}
