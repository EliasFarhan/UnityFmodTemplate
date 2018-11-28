using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
	[FMODUnity.EventRef] [SerializeField] private string musicEvent;
	
	FMOD.Studio.EventInstance musicInstance;

	private float timer = 0.0f;
	// Use this for initialization
	void Start () 
	{
	//	FMODUnity.RuntimeManager.PlayOneShot(musicEvent);
		musicInstance = FMODUnity.RuntimeManager.CreateInstance(musicEvent);
		musicInstance.start();
	}
	
	// Update is called once per frame
	void Update ()
	{
		timer += Time.deltaTime;
		musicInstance.setParameterValue("MusicTransition", (timer / 5.0f) % 2.0f);
	}
}
