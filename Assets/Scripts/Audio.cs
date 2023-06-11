using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {
public AudioClip sound1;
public Objects objectScript;
public MainScript mainScript;
    public AudioClip sound2;
    public AudioClip loseSound;
    public AudioClip winSound;
    public float delay = 1f;

    public AudioSource audioSource;
	void Start () {
		audioSource = GetComponent<AudioSource>();
        PlaySound1();
	}
    private void Update(){

        // if (mainScript.button1Clicked==true || mainScript.button2Clicked==true ||
        //  mainScript.button3Clicked==true || mainScript.button4Clicked==true){
        //     audioSource.Stop();
        //  }
        // }else{
        //     audioSource.clip = sound2;
        //     audioSource.Play();
        // }
    }
	private void PlaySound1(){
        audioSource.clip = sound1;
        audioSource.Play();
        Invoke("PlaySound2", delay);
    }
	private void PlaySound2(){
        audioSource.clip = sound2;
        audioSource.Play();
    }
    public void PlayLose(){
        audioSource.clip = loseSound;
        audioSource.Play();
    }
    public void PlayWin(){
        audioSource.clip = winSound;
        audioSource.Play();
    }
}
