using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    private IEnumerator ChangementScene()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(1);
    }

    public void onClick ()
    {
        StartCoroutine(ChangementScene());
    }
}
