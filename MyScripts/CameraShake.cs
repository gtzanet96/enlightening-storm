using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

	public float power = 0.08f;
	public float duration = 3.0f;
	public Transform camera;
	public float slowDownAmount = 1.0f;
	public bool shouldShake = false;

	Vector3 startPosition;
	float initialDuration;

	private void Start(){
		camera = Camera.main.transform;
		startPosition = camera.localPosition;
		initialDuration = duration;
	}

	private void Update(){
		if (shouldShake) {
			if (duration > 0) {
				camera.localPosition = startPosition + Random.insideUnitSphere * power;
				duration -= Time.deltaTime * slowDownAmount;
			} else {
				shouldShake = false;
				duration = initialDuration;
				camera.localPosition = startPosition;
			}
		}
	}
}
