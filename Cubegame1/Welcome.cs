﻿using UnityEngine;
using UnityEngine.SceneManagement;
public class Welcome : MonoBehaviour
{
  public void StartGame()
    {
        SceneManager.LoadScene(SceneManage.GetActiveScene().buildIndex + 1);
    }
} 
