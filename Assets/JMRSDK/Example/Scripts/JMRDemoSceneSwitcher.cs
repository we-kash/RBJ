﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JMRDemoSceneSwitcher : MonoBehaviour
{
    public void OnClick(int index)
    {
        SceneManager.LoadScene(index);
    }
}
