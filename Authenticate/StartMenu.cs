﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Authenticate
{
    public class StartMenu : MonoBehaviour
    {
        public void LoadRegisterScene()
        {
            SceneManager.LoadScene("Register");
        }

        public void LoadLoginScene()
        {
            SceneManager.LoadScene("Login");
        }
    }
}
