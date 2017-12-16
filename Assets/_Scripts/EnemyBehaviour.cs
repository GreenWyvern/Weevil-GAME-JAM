using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {

	//Movement to target player
	public GameObject target;

	public float moveSpeed;
	public float rotationSpeed;
	//public float rotationSpeed;

	// Use this for initialization
	void Start () {
		
	}
	/*
	void OnCollisionEnter2D(CircleCollider2D other){
		if (other.gameObject.tag == "Earth") {
			Destroy (gameObject);
		}
	}*/
	// Update is called once per frame
	void Update () {

		transform.position = Vector2.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime);
		Vector3 moveDirection = target.transform.position - transform.position;;
		if (moveDirection != Vector3.zero) {
			float angle = Mathf.Atan2 (moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis(angle, new Vector2(0,1));
		}
	}
}
