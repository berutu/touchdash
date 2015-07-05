using UnityEngine;
using System.Collections;

public class EffectBase : MonoBehaviour {

	public void OnTriggerEnter2D(Collider2D other){
		Debug.Log("Attack");
		if (other.gameObject.tag == "Player" && gameObject.tag == "EnemyAttack") {
			other.gameObject.GetComponent<PlayerBase>().Damage();
		}
		if (other.gameObject.tag == "Enemy" && gameObject.tag == "PlayerAttack") {
			other.gameObject.GetComponent<MonsterBase>().Damage();
		}
	}

}
