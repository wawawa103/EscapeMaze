using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public void ChanageGameScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    void Start()
    {
  
    }
    void Update()
    { }
}
