using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {

	public Transform explode;

	// Use this for initialization
	void Start () {
		explode.GetComponent<ParticleSystem>().enableEmission = true;
	
	}
	void OnTriggerEnter2D(){
		explode.GetComponent<ParticleSystem> ().enableEmission = true;
		StartCoroutine (stopExplodes ());
	}
	
	IEnumerator stopExplodes(){
		yield return new WaitForSeconds (.4f);
		explode.GetComponent<ParticleSystem> ().enableEmission = false;
	}
}
