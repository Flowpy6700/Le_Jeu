using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class SceneUI : MonoBehaviour
{
    private void Awake()
    {
        transform.Find("mainMenuBtn").GetComponent<ButtonUI>().ClickFunc = () =>
        {
            Debug.Log("Click Main Menu");
            Loading.Load(LoadScreen.Scene.Game);
        };
    }
}
