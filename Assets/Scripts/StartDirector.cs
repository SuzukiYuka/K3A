﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartDirector : MonoBehaviour {

    void Update() {

        if (Input.GetKey(KeyCode.Space)) {

            SceneManager.LoadScene("Main");
        }
    }
}
