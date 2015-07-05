using UnityEngine;
using System.Collections;


public abstract class PlayerBase : MonoBehaviour {

	protected bool isAttack;
	protected float attackingSpeed;
	protected float intervalTime;
	public GameObject attackEffect;
		
	public abstract IEnumerator Attack();
	public abstract void Damage();

}
