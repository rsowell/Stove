using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehavior : MonoBehaviour {
	void OnCollisionEnter(Collision collision) {
	    GameObject stove = gameObject.transform.parent.gameObject;
	    Animator stoveAnimator = stove.GetComponent<Animator> ();
	    stoveAnimator.SetTrigger ("doorPressed");
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
