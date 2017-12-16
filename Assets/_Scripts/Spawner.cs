using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject enemy;

	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnOne());
        StartCoroutine(SpawnTwo());
        StartCoroutine(SpawnThree());
        StartCoroutine(SpawnFour());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator SpawnOne()
    {
        
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1.0f, 5.0f));
            Vector2 position = new Vector2(Random.Range(-13, 13), Random.Range(15, 15));

            Instantiate(enemy, position, this.transform.rotation);
        }
    }

    IEnumerator SpawnTwo()
    {

        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1.0f, 5.0f));
            Vector2 position = new Vector2(Random.Range(-13, 13), Random.Range(-15, -15));

            Instantiate(enemy, position, this.transform.rotation);
        }
    }

    IEnumerator SpawnThree()
    {

        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1.0f, 5.0f));
            Vector2 position = new Vector2(Random.Range(15, 15), Random.Range(-15, 15));

            Instantiate(enemy, position, this.transform.rotation);
        }
    }

    IEnumerator SpawnFour()
    {

        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1.0f, 5.0f));
            Vector2 position = new Vector2(Random.Range(-15, -15), Random.Range(-15, 15));

            Instantiate(enemy, position, this.transform.rotation);
        }
    }

}
