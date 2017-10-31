using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pathmaker : MonoBehaviour {

	public static int tileMax = 500;
	public static int totalTileCount;
	private int count;
	//public Transform floorPrefab;
	public Transform moon;
	public Transform star;
	public Transform sun;
	public Transform pathmakerSpherePrefab;
	public Text textBox;
	int rand;
	int shapeGen;
	public static bool canRestart = false;

	void Start(){
		rand = Random.Range (1, 4);
		rand = 1;
		Debug.Log (rand);
	}

	void Update () {
		switch (rand) {
		case 1:
			tileMax = Random.Range (450, 500);
			if (totalTileCount < tileMax && count < 50) {
				float temp = Random.Range (0f, 1f);
				if (temp < 0.25f) {
					transform.Rotate (new Vector3 (0, 90, 0));
				} else if (temp > 0.25f && temp < 0.5f) {
					transform.Rotate (new Vector3 (0, -90, 0));
				} else if (temp > 0.99f && temp < 1.0f) {
					Instantiate (pathmakerSpherePrefab, transform.position, Quaternion.Euler (0, 0, 0));
				}
				shapeGen = Random.Range (1, 4);
				if (shapeGen == 1) {
					Instantiate (moon, transform.position, Quaternion.Euler (0, 0, 0));
				} else if (shapeGen == 2) {
					Instantiate (star, transform.position, Quaternion.Euler (0, 0, 0));
				} else {
					Instantiate (sun, transform.position, Quaternion.Euler (0, 0, 0));
				}
				transform.position += transform.forward * 5f;
				count++;
				totalTileCount++;
			} else {
				Destroy (this);
			}
			break;
		case 2:
			tileMax = Random.Range (350, 450);
			if (totalTileCount < tileMax && count < 50) {
				float temp = Random.Range (0f, 1f);
				if (temp < 0.25f) {
					transform.Rotate (new Vector3 (0, 90, 0));
				} else if (temp > 0.25f && temp < 0.5f) {
					transform.Rotate (new Vector3 (0, -90, 0));
				} else if (temp > 0.90f && temp < 1.0f) {
					Instantiate (pathmakerSpherePrefab, transform.position, Quaternion.Euler (0, 0, 0));
				}
				shapeGen = Random.Range (1, 4);
				if (shapeGen == 1) {
					Instantiate (moon, transform.position, Quaternion.Euler (0, 0, 0));
				} else if (shapeGen == 2) {
					Instantiate (star, transform.position, Quaternion.Euler (0, 0, 0));
				} else {
					Instantiate (sun, transform.position, Quaternion.Euler (0, 0, 0));
				}
				transform.position += transform.forward * 5f;
				count++;
				totalTileCount++;
			} else {
				Destroy (this);
			}
			break;
		case 3:
			tileMax = Random.Range (350, 400);
			if (totalTileCount < tileMax && count < 50) {
				float temp = Random.Range (0f, 1f);
				if (temp < 0.3f) {
					transform.Rotate (new Vector3 (0, 90, 0));
				} else if (temp > 0.3f && temp < 0.6) {
					transform.Rotate (new Vector3 (0, -90, 0));
				} else if (temp > 0.97f && temp < 1.0f) {
					Instantiate (pathmakerSpherePrefab, transform.position, Quaternion.Euler (0, 0, 0));
				}
				int tileNum = Random.Range (2, 4);
				shapeGen = Random.Range (1, 4);
				for (int i = 0; i < tileNum; i++) {
					if (shapeGen == 1) {
						Instantiate (moon, transform.position, Quaternion.Euler (0, 0, 0));
					} else if (shapeGen == 2) {
						Instantiate (star, transform.position, Quaternion.Euler (0, 0, 0));
					} else {
						Instantiate (sun, transform.position, Quaternion.Euler (0, 0, 0));
					}
					transform.position += transform.forward * 5f;
					count ++;
					totalTileCount ++;
				}

			} else {
				Destroy (this);
			}
			break;
		default:
			Debug.Log ("YOU'VE FUCKED UP");
			break;
		}
		if (totalTileCount >= tileMax || count >= 50) {
			textBox.text = ("press [R] to restart");
			canRestart = true;
		}
	}

} // end of class scope