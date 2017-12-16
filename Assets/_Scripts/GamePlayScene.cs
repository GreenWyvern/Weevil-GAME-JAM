using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Boundary {
    public float Top = 0.0f;
    public float Bottom = 0.0f;
    public float Left = 0.0f;
    public float Right = 0.0f;
}

public class GamePlayScene : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

    public void onNextButtonClicked() {
        SceneManager.LoadScene("End");
    }
}
