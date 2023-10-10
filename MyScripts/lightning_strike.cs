using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lightning_strike : MonoBehaviour
{
	public ParticleSystem lightning;
    public AudioSource audioSource;
    private bool thunderstruck = false;
    [SerializeField]
    private float delayBeforeLoading = 2f;
    private float TimeElapsed;
    public static bool thunder_shake;
    public CameraShake cameraShake;

    void Start()
    {
        thunder_shake = false;
    }

    void Update()
    {
        if (thunderstruck == true)
        {
            TimeElapsed += Time.deltaTime;
            if (TimeElapsed > delayBeforeLoading)
            {
                cameraShake.shouldShake = true;
                audioSource.Play();
                //disables the update function so that once the audio is played, it stops running again and the audio only plays one
                this.enabled = false;
            }
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (thunderstruck == false)
            {
                lightning.Play();
                thunderstruck = true;
            }
        }
    }
}
