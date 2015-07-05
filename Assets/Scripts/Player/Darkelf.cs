using UnityEngine;
using System.Collections;

public class Darkelf : PlayerBase {

	// Use this for initialization
	void Start () {
		attackingSpeed = 3.0f;
		intervalTime = 3.0f;
		StartCoroutine("Attack");
	}

	#region implemented abstract members of PlayerBase
	public override IEnumerator Attack ()
	{
		yield return new WaitForSeconds (0.1f);
		while (true) {
			attackEffect.GetComponent<BoxCollider2D>().enabled = true;
			attackEffect.GetComponent<SpriteRenderer>().enabled = true;
			attackEffect.GetComponent<Animator>().SetBool("Start", true);
			iTween.MoveTo(attackEffect, new Vector3(attackEffect.transform.position.x, attackEffect.transform.position.y + 5f, attackEffect.transform.position.z), attackingSpeed - 0.1f);
			yield return new WaitForSeconds (attackingSpeed);
			attackEffect.GetComponent<BoxCollider2D>().enabled = false;
			attackEffect.GetComponent<SpriteRenderer>().enabled = false;
			attackEffect.GetComponent<Animator>().SetBool("Start", false);
			attackEffect.transform.localPosition = new Vector3(0.17f, 0.4f, 0f);
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
