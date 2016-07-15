using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	private TileMap tm;

	void Start() {
		tm = GameObject.Find("TileMap").GetComponent<TileMap>();
	}

	void OnMouseDown() {
		
		tm.PlaceFurniture(transform.position + new Vector3(0, 0, -20));
	}
}
