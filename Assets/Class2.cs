using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Class2 : MonoBehaviour
{
	public string SceneToLoad;
	public void LoadGame()
	{
		SceneManager.LoadScene(SceneToLoad);
	}
}
