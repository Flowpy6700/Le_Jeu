using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneUI : MonoBehaviour
{
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(OnClick);
	}

	void OnClick()
	{
		Debug.Log("Clic on the button!");
		Loading.Load(Loading.Scene.Game);
	}
}
