﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadGF : MonoBehaviour
{
    public void SceneLoader(int SceneIndex)
    {
      SceneManager.LoadScene(SceneIndex);
    }
}