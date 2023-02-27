using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "red") {
			Destroy(col.gameObject);
		}
		if(col.gameObject.tag == "yellow") {
			Debug.Log("y: "+col.gameObject.transform.position);
			col.gameObject.transform.position = new Vector3(col.gameObject.transform.position.x,col.gameObject.transform.position.y, col.gameObject.transform.position.z +2); 
//			col.gameObject.transform.position = new Vector3(col.gameObject.transform.x,col.gameObject.transform.position.y, col.gameObject.transform.position.z +2)
			int flag = Random.Range(0,2);
			if(flag < 1) {
				col.gameObject.transform.Rotate(0.0f, 25.0f*-1, 0.0f);
			}else {
				col.gameObject.transform.Rotate(0.0f, 25.0f, 0.0f);
			}

			if (col.gameObject.transform.rotation.y > 0.5f || col.gameObject.transform.rotation.y < -0.5f) {
				Destroy(col.gameObject);
			}
			Debug.Log("Yellow "+col.gameObject.transform.rotation.y);
			StartCoroutine(WaitForFunction());
//			Debug.Log("ysadsadasdas "+col.gameObject.transform.position);
		}
		if(col.gameObject.tag == "black") {
		
		}
	} 
	IEnumerator WaitForFunction()
	{
		yield return new WaitForSeconds(3);
		Debug.Log("Hello!");  
	}

}
