using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {
public Objects objectScript;
public MainScript mainScript;
    public float delay = 1f;
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    public AudioSource lastChoice, winGame, loseGame;
	void Start () {
		
	}
    private void Update(){

       
    }
    //doma jautajumu
    public void PlaySound1(){
        audioSource1.Play();
        audioSource2.Stop();
        audioSource3.Stop();
        winGame.Stop(); loseGame.Stop();
    }
    //nepareiza atbilde
    public void PlaySound2(){
        audioSource1.Stop();
        audioSource2.Play();
        audioSource3.Stop();
    }
    //pareiza atbilde
    public void PlaySound3(){
        audioSource1.Stop();
        audioSource2.Stop();
        audioSource3.Play();
        
    }
    
    public void PlayVictory(){
        winGame.Play();
        audioSource1.Stop();
        audioSource2.Stop();
        audioSource3.Stop();
    }
    public void PlayLose(){
        loseGame.Play();
        audioSource1.Stop();
        audioSource2.Stop();
        audioSource3.Stop();
    }
	
}
