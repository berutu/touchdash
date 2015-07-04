using UnityEngine;
using System.Collections;


public abstract class PlayerBase : MonoBehaviour {
	
	protected float attackingSpeed;
	protected float intervalTime;
	public GameObject attackEffect;

	protected IEnumerator Attack ()
	{
		while (true) {
			attackEffect.SetActive (true);
			yield return new WaitForSeconds (attackingSpeed);
			attackEffect.SetActive (false);
			yield return new WaitForSeconds (intervalTime);
		}
	}

	public abstract void Damage();

}
