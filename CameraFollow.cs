using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	private Transform target;
	private float trackSpeed = 10f;

	public void SetTarget(Transform t){
		target = t;
	}

	void LateUpdate(){
		if(target){
			float x = IncrementTowards(transform.position.x, target.position.x, trackSpeed);
			float y = IncrementTowards(transform.position.y, target.position.y+0.2f, trackSpeed);
			transform.position = new Vector3(x,y,transform.position.z);
		}
	}

	private float IncrementTowards( float n, float target, float a){
		if(n == target){
			return n;
		}else{
			float dir = Mathf.Sign (target - n);
			n += a * Time.deltaTime * dir;
			return (dir == Mathf.Sign (target-n))? n: target;
		}
	}
}
