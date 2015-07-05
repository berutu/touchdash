using UnityEngine;
using System.Collections;


public abstract class PlayerBase : MonoBehaviour {

	protected bool isAttack;
	protected float attackingSpeed;
	protected float intervalTime;
	public GameObject attackEffect;
		
	public virtual IEnumerator Attack(){
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
	}
	public abstract void Damage();

}
