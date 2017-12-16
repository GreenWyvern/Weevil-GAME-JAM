using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UERFGOBOOM : MonoBehaviour {

    private int health = 3;
    public TextMesh healthtext;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        healthtext.text = "HEALTH: " + health;
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        health--;
        Destroy(other.gameObject);
        if(health == 0)
        {
            Destroy(this.gameObject);
            healthtext.text = "DED M8";
        }
    }
}
