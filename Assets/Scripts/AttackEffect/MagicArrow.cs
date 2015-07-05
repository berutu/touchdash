using UnityEngine;
using System.Collections;

public class MagicArrow : EffectBase {
	public  override void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Enemy" && gameObject.tag == "PlayerAttack") {
			other.gameObject.GetComponent<MonsterBase>().StartCoroutine("Damage");
			GetComponent<BoxCollider2D>().enabled = false;
			GetComponent<SpriteRenderer>().enabled = false;
			GetComponent<Animator>().SetBool("Start", false);
		}
	}
}
