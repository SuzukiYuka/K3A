using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour {

    public Text timeLabel;

    float time = 0.0f;

    void Update() {

        time += Time.deltaTime;
        timeLabel.text = time.ToString("F2");
    }
}
