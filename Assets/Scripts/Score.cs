using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
	public Objects objectScript;
	public void UpdateScore()
    {
        objectScript.scoreText.text="Punkti: " +objectScript.score.ToString();
        UpdateMoney();
    }
    public void UpdateMoney(){
        //ja punkti ir 1 un mazak par 2, moneyBoard bildi parmaina
        if(objectScript.score==1 && objectScript.score!=2){
        objectScript.moneyBoard.sprite = objectScript.score1;
        }
        //ja punkti ir 2 un mazak par 3, moneyBoard bildi parmaina
        if(objectScript.score==2 && objectScript.score!=3){
        objectScript.moneyBoard.sprite = objectScript.score2;
        }
        //ja punkti ir 3 un mazak par 4...
        if(objectScript.score==3 && objectScript.score!=4){
        objectScript.moneyBoard.sprite = objectScript.score3;
        }
        if(objectScript.score==4 && objectScript.score!=5){
        objectScript.moneyBoard.sprite = objectScript.score4;
        }
        if(objectScript.score==5 && objectScript.score!=6){
        objectScript.moneyBoard.sprite = objectScript.score5;
        }
        if(objectScript.score==6 && objectScript.score!=7){
        objectScript.moneyBoard.sprite = objectScript.score6;
        }
        if(objectScript.score==7 && objectScript.score!=8){
        objectScript.moneyBoard.sprite = objectScript.score7;
        }
        if(objectScript.score==8 && objectScript.score!=9){
        objectScript.moneyBoard.sprite = objectScript.score8;
        }
        if(objectScript.score==9 && objectScript.score!=10){
        objectScript.moneyBoard.sprite = objectScript.score9;
        }
        if(objectScript.score==10){
        objectScript.moneyBoard.sprite = objectScript.score10;
        }
        
    }
}
