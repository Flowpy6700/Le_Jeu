using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loading
{
    public enum Scene
    {
        Game,
        Loading,
    }

    private static Action onLoaderCallBack;

    public static void Load(Scene scene)
    {
        //action pour charger la scene
        onLoaderCallBack = () =>
        {
            SceneManager.LoadScene(scene.ToString());
        };

        //charger la scene
        SceneManager.s(Scene.Loading.ToString());
    }

    public static void LoaderCallBack()
    {
        //apres l update chargement de la nouvelle scene
        if(onLoaderCallBack != null)
        {
            onLoaderCallBack();
            onLoaderCallBack = null;
        }

    }
}
