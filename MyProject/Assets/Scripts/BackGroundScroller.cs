using UnityEngine;
using System.Collections;

public class BackGroundScroller : MonoBehaviour {
	
	public float scroll_speed = 1.0f; 
	private Material target_material;
	private float temp_offset;

	void Start () {
		target_material = GetComponent<Renderer>().material; 
	}

	void Update () {

		temp_offset += Time.deltaTime * scroll_speed;
		target_material.mainTextureOffset = new Vector2 (temp_offset, 0);
	}
}
