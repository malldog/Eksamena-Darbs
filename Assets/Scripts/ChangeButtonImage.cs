using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class ChangeButtonImage : MonoBehaviour
{
    public Objects objectScript;
    private bool correct = false;
    //parbauda vai jautajums jau ir atbildets. q == question
    private bool q1= false, q2= false, q3= false, q4= false, q5= false, q6= false, q7= false,
     q8= false, q9= false, q10= false;

    private bool button1Clicked = false;
    private bool button2Clicked = false;
    private bool button3Clicked = false;
    private bool button4Clicked = false;
    void Update()
    {
      
    }

    public void OnButton1Click(){
        button1Clicked = true;
        objectScript.button1.image.sprite = objectScript.img1;
        Questions();
        }

    public void OnButton2Click() {
        button2Clicked = true;
        objectScript.button2.image.sprite = objectScript.img1;
        Questions();
        }

    public void OnButton3Click(){
        button3Clicked = true;
        objectScript.button3.image.sprite = objectScript.img1;
        Questions();
        }

    public void OnButton4Click(){
        button4Clicked = true;
        objectScript.button4.image.sprite = objectScript.img1;
        Questions();
        }
    private IEnumerator LaiksKamerPogaAtslegta(){
        objectScript.button1.interactable = false;
        objectScript.button2.interactable = false;
        objectScript.button3.interactable = false;
        objectScript.button4.interactable = false;
        button1Clicked=false;
        button2Clicked=false;
        button3Clicked=false;
        button4Clicked=false;
        yield return new WaitForSeconds(3f);
        objectScript.button1.image.sprite = objectScript.img3;
        objectScript.button2.image.sprite = objectScript.img3;
        objectScript.button3.image.sprite = objectScript.img3;
        objectScript.button4.image.sprite = objectScript.img3;
        objectScript.button1.interactable = true;
        objectScript.button2.interactable = true;
        objectScript.button3.interactable = true;
        objectScript.button4.interactable = true;
    }
    //3 sekundes parada pareizo atbildi
    private IEnumerator ShowCorrectAnswers(){
        yield return new WaitForSeconds(3f);
        //ja pirmais jautajums ir un otrais nav
        if(q1==true && q2==false){
            Q2Load();
        //ja otrais jautajums ir un tresais nav
        }else if(q2==true && q3==false){
            Q3Load();
        //ja tresais jautajums...
        }else if(q3==true && q4==false){
            Q4Load();
        }else if(q4==true && q5==false){
            Q5Load();
        }else if(q5==true && q6==false){
            Q6Load();
        }else if(q6==true && q7==false){
            Q7Load();
        }else if(q7==true && q8==false){
            Q8Load();
        }else if(q8==true && q9==false){
            Q9Load();
        }else if(q9==true && q10==false){
            Q10Load();
        }
        //pec 10tas atbildes ielades score screen
        
    }
    private void Questions(){
//pirmais jautajms 1. pareiz
        if(q1==false){
            if(button1Clicked==true){
                objectScript.score++;
                q1 = true;
            }else{
                q1 = true;
            }
            objectScript.button1.image.sprite = objectScript.img2;
//otrais jautajums 2. pareiz
        }else if(q2==false){
            if(button2Clicked==true){
                objectScript.score++;
                q2=true;
            }else{
               q2=true;
            }
            objectScript.button2.image.sprite=objectScript.img2;
//tresais jautajums 1. pareiz
        }else if(q3==false){
            if(button1Clicked==true){
                objectScript.score++;
                q3 = true;
            }else{
                q3 = true;
            }
            objectScript.button1.image.sprite = objectScript.img2;
        }else if(q4==false){
             if(button3Clicked==true){
                objectScript.score++;
                q4 = true;
            }else{
                q4 = true;
            }
            objectScript.button3.image.sprite =objectScript.img2;   
        }else if(q5==false){
            if(button3Clicked==true){
                objectScript.score++;
                q5 = true;
            }else{
                q5 = true;
            }
            objectScript.button3.image.sprite = objectScript.img2; 
        }else if(q6==false){
            if(button3Clicked==true){
                objectScript.score++;
                q6 = true;
            }else{
                q6 = true;
            }
            objectScript.button3.image.sprite = objectScript.img2; 
        }else if(q7==false){
            if(button2Clicked==true){
                objectScript.score++;
                q7 = true;
            }else{
                q7 = true;
            }
            objectScript.button2.image.sprite = objectScript.img2; 
        }else if(q8==false){
            if(button2Clicked==true){
                objectScript.score++;
                q8 = true;
            }else{
                q8 = true;
            }
            objectScript.button2.image.sprite = objectScript.img2; 
        }else if(q9==false){
            if(button4Clicked==true){
                objectScript.score++;
                q9 = true;
            }else{
                q9 = true;
            }
            objectScript.button4.image.sprite = objectScript.img2; 
        }else if(q10==false){
            if(button1Clicked==true){
                objectScript.score++;
                q10 = true;
            }else{
                q10 = true;
            }
            objectScript.button1.image.sprite = objectScript.img2; 
        }
        StartCoroutine(LaiksKamerPogaAtslegta());
            StartCoroutine(ShowCorrectAnswers());
    }
    //ielade otro jautajumu
    private void Q2Load(){
    objectScript.questionText.text = "celebrant?";
    objectScript.button1txt.text="jatbildd";
    objectScript.button2txt.text = "bbbb";
    objectScript.button3txt.text = "ddd";
    objectScript.button4txt.text = "eee12331";
    }
    //ielade treso jautajumu
    private void Q3Load(){
    objectScript.questionText.text = "Pareizs termins ciklam ar pecnosacijumu?";
    objectScript.button1txt.text="ff";
    objectScript.button2txt.text = "aa";
    objectScript.button3txt.text = "3";
    objectScript.button4txt.text = "tt";
    }
    private void Q4Load(){
    objectScript.questionText.text = "Pareizs termins ciklam ar pecnosacijumu?";
    objectScript.button1txt.text="ff";
    objectScript.button2txt.text = "aa";
    objectScript.button3txt.text = "3";
    objectScript.button4txt.text = "tt";
    }
    private void Q5Load(){
    objectScript.questionText.text = "Pareizs termins ciklam ar pecnosacijumu?";
    objectScript.button1txt.text="ff";
    objectScript.button2txt.text = "aa";
    objectScript.button3txt.text = "3";
    objectScript.button4txt.text = "tt";
    }
    private void Q6Load(){
    objectScript.questionText.text = "Pareizs termins ciklam ar pecnosacijumu?";
    objectScript.button1txt.text="ff";
    objectScript.button2txt.text = "aa";
    objectScript.button3txt.text = "3";
    objectScript.button4txt.text = "tt";
    }
    private void Q7Load(){
    objectScript.questionText.text = "Pareizs termins ciklam ar pecnosacijumu?";
    objectScript.button1txt.text="ff";
    objectScript.button2txt.text = "aa";
    objectScript.button3txt.text = "3";
    objectScript.button4txt.text = "tt";
    }
    private void Q8Load(){
    objectScript.questionText.text = "Pareizs termins ciklam ar pecnosacijumu?";
    objectScript.button1txt.text="ff";
    objectScript.button2txt.text = "aa";
    objectScript.button3txt.text = "3";
    objectScript.button4txt.text = "tt";
    }
    private void Q9Load(){
    objectScript.questionText.text = "Pareizs termins ciklam ar pecnosacijumu?";
    objectScript.button1txt.text="ff";
    objectScript.button2txt.text = "aa";
    objectScript.button3txt.text = "3";
    objectScript.button4txt.text = "tt";
    }
    private void Q10Load(){
    objectScript.questionText.text = "Pareizs termins ciklam ar pecnosacijumu?";
    objectScript.button1txt.text="ff";
    objectScript.button2txt.text = "aa";
    objectScript.button3txt.text = "3";
    objectScript.button4txt.text = "tt";
    }
}


