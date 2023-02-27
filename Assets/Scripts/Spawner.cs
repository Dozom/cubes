using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] cubes;
	public Transform[] spawnPos;
	private float timer;
	public float beat = (60/145)*2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timer > beat){
			int cubeColor = Random.Range(0,3);
			GameObject cube = Instantiate(cubes[cubeColor], spawnPos[Random.Range(0,6)]);
			cube.transform.localPosition = Vector3.zero;
//			cube.transform.Rotate(transform.forward, 90 * Random.Range(0,4));
			if(cubeColor == 2) {
				timer -= beat*2;
			}else{
				timer -= beat;
			}
		}
		timer += Time.deltaTime;
	}
}
