using UnityEngine;
using System.Collections;

public class MonsterGeneraotr : MonoBehaviour {

	public const float EDGE_LEFT = -3.0f;
	public const float EDGE_RIGHT = 3.0f;


	public GameObject goblin;
	public GameObject goblinRare;
	public GameObject bee;
	public GameObject fairy;

	GameObject enemy;

	public float generateInterval;

	// Use this for initialization
	void Start () {
		StartCoroutine("Generate");
		generateInterval = 5.0f;
	}

	private IEnumerator Generate(){
		while (true) {
			enemy = (GameObject)Instantiate (DecideEnemy(), new Vector3 (Random.Range (EDGE_LEFT, EDGE_RIGHT), 6f, 0f), Quaternion.identity);
			yield return new WaitForSeconds (generateInterval);
		}
	}

	private GameObject DecideEnemy(){
		int rand = Random.Range (0, 100);
		return goblin;
	}
}
