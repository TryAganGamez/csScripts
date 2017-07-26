using UnityEngine;
using System.Collections;

public class RaycastShoot : MonoBehaviour {
	public int gunDamage=1;
	public float fireRate= .25f;
	public float weaponRange=50f;
	public float hitForce=100f;
	public Transform gunEnd;
	private Camera fpsCam;
	private WaitForSeconds shotDuration=new WaitForSeconds(.07f);
	private AudioSource gunAudio;
	private LineRenderer laserLine;
	private float nextFire;


	// Use this for initialization
	void Start () {
		laserLine = GetComponent<LineRenderer>();
		gunAudio = GetComponent<AudioSource>();
		fpsCam = GetComponentInParent<Camera>();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			StartCoroutine (ShotEffect ());
			Vector3 rayOrgin = fpsCam.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 0));
			RaycastHit hit;
			laserLine.SetPosition (0, gunEnd.position);
			if (Physics.Raycast (rayOrgin, fpsCam.transform.forward, out hit, weaponRange)) {
				laserLine.SetPosition (1, hit.point);
			} else {
				laserLine.SetPosition (1, rayOrgin + (fpsCam.transform.forward * weaponRange));
			}
		}
}
private IEnumerator ShotEffect(){
			gunAudio.Play();
			laserLine.enabled=true;
		yield return shotDuration;
		laserLine.enabled = false;
}
}