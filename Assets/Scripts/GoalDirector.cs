using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalDirector : MonoBehaviour {

    void Update() {

        if (Input.GetKey(KeyCode.T)) {

            SceneManager.LoadScene("Start");
        }
    }
}
