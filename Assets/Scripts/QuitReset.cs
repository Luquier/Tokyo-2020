using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class QuitReset : MonoBehaviour {

	AudioSource bgmSound;
	public AudioClip bgmClip;

	// Use this for initialization
	void Start () {

		bgmSound = GetComponent<AudioSource>();
		bgmSound.Play();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.CapsLock))
			Application.Quit();

		if (Input.GetKey(KeyCode.Backspace))
			SceneManager.LoadScene(0);
	}
}
