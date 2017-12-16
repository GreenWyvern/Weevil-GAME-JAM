using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIEGOESBOOM : MonoBehaviour {

    private int scoooore = 0;
    public TextMesh kills;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        kills.text = "K1LLS: " + scoooore;
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        scoooore += 1;
    }
}
