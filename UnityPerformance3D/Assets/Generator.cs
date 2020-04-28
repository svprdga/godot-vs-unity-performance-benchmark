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
    private int m_FpsAccumulator = 0;
    private float m_FpsNextPeriod = 0;
    private int m_CurrentFps;

    void Update() {
        targetTime -= Time.deltaTime;

        // measure average frames per second
        m_FpsAccumulator++;
        if (Time.realtimeSinceStartup > m_FpsNextPeriod) {
            m_CurrentFps = (int) (m_FpsAccumulator / fpsMeasurePeriod);
            m_FpsAccumulator = 0;
            m_FpsNextPeriod += fpsMeasurePeriod;
        }

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

            text.text = "Cubes: " + cubes + "\nFPS: " + m_CurrentFps;

            targetTime = 0.1f;
        }

    }

}