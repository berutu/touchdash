using UnityEngine;
using System.Collections;

public class MonsterGeneraotr : MonoBehaviour {

	public const float EDGE_LEFT = -3.0f;
	public const float EDGE_RIGHT = 3.0f;


	public GameObject Goblin;
	public GameObject GoblinRare;
	public GameObject Bee;
	public GameObject Fairy;

	GameObject enemy;

	public float generateInterval;

	// Use this for initialization
	void Start () {
		StartCoroutine("Generate");
		generateInterval = 5.0f;
	}

	private IEnumerator Generate(){
		while (true) {
			enemy = (GameObject)Instantiate (Goblin, new Vector3 (Random.Range (EDGE_LEFT, EDGE_RIGHT), 6f, 0f), Quaternion.identity);
			yield return new WaitForSeconds (generateInterval);
		}
	}
}
