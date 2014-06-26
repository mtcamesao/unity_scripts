using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {


	public GameObject player;

	private CameraFollow cam;

	// Use this for initialization
	void Start () {
		
		cam = GetComponent<CameraFollow>();
		SpawnPlayer();
	}
	
	private void SpawnPlayer(){
		cam.SetTarget((Instantiate(player, new Vector3(2,0,0), Quaternion.identity) as GameObject).transform);
	}
}
