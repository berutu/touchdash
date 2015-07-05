using UnityEngine;
using System.Collections;

public class Sorcerer : PlayerBase {

	// Use this for initialization
	void Start () {
		attackingSpeed = 0.35f;
		intervalTime = 3.0f;
		StartCoroutine ("Attack");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	#region implemented abstract members of PlayerBase
	public override IEnumerator Attack ()
	{
		yield return new WaitForSeconds (0.1f);
		while (true) {
			attackEffect.GetComponent<BoxCollider2D>().enabled = true;
			attackEffect.GetComponent<SpriteRenderer>().enabled = true;
			attackEffect.GetComponent<Animator>().SetBool("Start", true);
			yield return new WaitForSeconds (attackingSpeed);
			attackEffect.GetComponent<BoxCollider2D>().enabled = false;
			attackEffect.GetComponent<SpriteRenderer>().enabled = false;
			attackEffect.GetComponent<Animator>().SetBool("Start", false);
			yield return new WaitForSeconds (intervalTime);
		}
		yield return 0;
	}

	public override void Damage ()
	{
		throw new System.NotImplementedException ();
	}

	#endregion
}
