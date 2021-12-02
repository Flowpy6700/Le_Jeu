using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    [SerializeField]
    private Image progressBar;
    private void Start()
    {
        StartCoroutine(LoadAsyncOperation());
    }

    IEnumerator LoadAsyncOperation()
    {
        AsyncOperation gameLevel = SceneManager.LoadSceneAsync(2);

        while(gameLevel.progress < 1)
        {
            progressBar.fillAmount = gameLevel.progress;
            yield return new WaitForEndOfFrame();
        }
    }
}
