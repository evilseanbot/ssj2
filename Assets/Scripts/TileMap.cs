using UnityEngine;
using System.Collections;

public class TileMap : MonoBehaviour {

	public GameObject tile;
	public GameObject chair;
	public GameObject pot;
	private int selectedItem;

	public Sprite chairSprite;
	public Sprite potSprite;
	private SpriteRenderer currentItemSprite;

	private int[][] mapArray = new int[][]{
		new int[]{0,0,0,0,0,0,0,1,0,0,0,0,0,0,0},
		new int[]{0,0,0,0,0,0,1,0,1,0,0,0,0,0,0},
		new int[]{0,0,0,0,0,1,0,1,0,1,0,0,0,0,0},
		new int[]{0,0,0,0,1,0,1,0,1,0,1,0,0,0,0},
		new int[]{0,0,0,1,0,1,0,1,0,1,0,1,0,0,0},
		new int[]{0,0,1,0,1,0,1,0,1,0,1,0,1,0,0},
		new int[]{0,1,0,1,0,1,0,1,0,1,0,1,0,1,0},
		new int[]{1,0,1,0,1,0,1,0,1,0,1,0,1,0,1},
		new int[]{0,1,0,1,0,1,0,1,0,1,0,1,0,1,0},
		new int[]{1,0,1,0,1,0,1,0,1,0,1,0,1,0,1},
		new int[]{0,1,0,1,0,1,0,1,0,1,0,1,0,1,0},
		new int[]{0,0,1,0,1,0,1,0,1,0,1,0,1,0,0},
		new int[]{0,0,0,1,0,1,0,1,0,1,0,1,0,0,0},
		new int[]{0,0,0,0,1,0,1,0,1,0,1,0,0,0,0},
		new int[]{0,0,0,0,0,1,0,1,0,1,0,0,0,0,0}};


	// Use this for initialization
	void Start () {

		currentItemSprite = GameObject.Find("CurrentItemSprite").GetComponent<SpriteRenderer>();

		float tile_width = 0.9f;
		float tile_height = 0.5f;
		float starting_x = -6;
		float starting_y = -4;
		

		for (int x = 0; x < 15; x++) {
			for (int y = 0; y < 15; y++) {
				if (mapArray[y][x] == 1) {
					Instantiate(tile, new Vector3(starting_x + (x*(tile_width)), starting_y + (y * tile_height), 100 + y), Quaternion.identity);
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PlaceFurniture(Vector3 location) {
		if (selectedItem == 0) {
			Instantiate(chair, location + new Vector3(0, 1, 0), Quaternion.identity);
		} else if (selectedItem == 1) {			
			Instantiate(pot, location + new Vector3(0, 0.5f, 0), Quaternion.identity);
		}
	}

	public void SetSelectedItem(int number) {
		selectedItem = number;
		if (selectedItem == 0) {
			currentItemSprite.sprite = chairSprite;
		} else if (selectedItem == 1) {
			currentItemSprite.sprite = potSprite;
		} 
		
	}
}
