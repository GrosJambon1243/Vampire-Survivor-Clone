﻿using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script.Ui_Bar
{
    public class ExitScript : MonoBehaviour
    {
        public void ExitButton()
        {
            SceneManager.LoadSceneAsync(0);
        }
    }
}