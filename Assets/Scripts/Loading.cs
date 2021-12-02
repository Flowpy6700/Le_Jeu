using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class LoadScreen
{
    public enum Scene
    {
        Game,
    }
    public static void Load(Scene scene)
    {
        SceneManager.Loading(scene.ToString());
    }
}
