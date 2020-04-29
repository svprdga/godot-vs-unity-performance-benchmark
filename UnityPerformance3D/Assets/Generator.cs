using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Generator : MonoBehaviour {

    public GameObject cube;
    public Text text;

    float targetTime = 0.1f;
    int cubes = 0;

    const float fpsMeasurePeriod = 0.5f;
    private int fpsAccumulate = 0;
    private float fpsNextPeriod = 0;
    private int currentFps;

    private string platform;

    void Awake() {
        if (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor) {
            platform = "Windows";
        } else if (Application.platform == RuntimePlatform.LinuxPlayer || Application.platform == RuntimePlatform.LinuxEditor) {
            platform = "Linux";
        } else if (Application.platform == RuntimePlatform.Android) {
            platform = "Android";
        } else {
            platform = "Unknown";
        }
    }

    void Update() {
        // FPS measure.
        fpsAccumulate++;
        if (Time.realtimeSinceStartup > fpsNextPeriod) {
            currentFps = (int) (fpsAccumulate / fpsMeasurePeriod);
            fpsAccumulate = 0;
            fpsNextPeriod += fpsMeasurePeriod;
        }

        targetTime -= Time.deltaTime;

        if (targetTime <= 0f) {

            float x = 0f;
            float z = 0f;

            if (Random.value >= 0.5f) {
                x = Random.value * 5;
                z = Random.value * 5;
            } else {
                x = Random.value * -5;
                z = Random.value * -5;
            }

            Vector3 vector = transform.position;
            vector.x += x;
            vector.z += z;

            Instantiate(cube, vector, Quaternion.identity);
            cubes++;

            text.text = "UNITY PERFORMANCE 3D: \n" +
                "Platform: " + platform + "\n" +
                "Cubes: " + cubes + "\n" +
                "FPS: " + currentFps;

            targetTime = 0.1f;
        }

    }

}