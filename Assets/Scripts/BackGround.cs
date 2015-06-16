using UnityEngine;
using System.Collections;

public class BackGround : MonoBehaviour {

	public  float speed = 0.1f;
	private  float offset;
	void Update () {
		offset += Time.deltaTime * speed;
		renderer.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
	}
}
