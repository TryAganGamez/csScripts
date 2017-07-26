using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cakeController : MonoBehaviour {

	[SerializeField] GameObject rewardParticles;
	[SerializeField] cameraGroupController setCameraShot;
	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {

			playerMovement myPlayer = other.GetComponent<playerMovement> ();
			myPlayer.getReward ();
			myPlayer.incrementPointCount ();
			setCameraShot.arcShot ();
			Destroy (gameObject.transform.root.gameObject);
			Instantiate (rewardParticles, other.transform.position, Quaternion.identity);
		}

	}
}
