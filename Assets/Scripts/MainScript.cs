using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class MainScript : MonoBehaviour
{
    public Objects objectScript;
    public Score scoreScript;
    public Audio audioScript;
    private bool correct = false;
    //parbauda vai jautajums jau ir atbildets. q == question
    private bool q1= false, q2= false, q3= false, q4= false, q5= false, q6= false, q7= false,
     q8= false, q9= false, q10= false;
    public bool button1Clicked = false;
    public bool button2Clicked = false;
    public bool button3Clicked = false;
    public bool button4Clicked = false;
    
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
        }else if(q10==true){
            if(objectScript.score>6){
                objectScript.panel.sprite = objectScript.winGame;
                objectScript.scoreBoard.SetActive(true);
                objectScript.scoreBoardText.text="Veiksmīga spēle";
                objectScript.iziet.gameObject.SetActive(true);
                objectScript.restart.gameObject.SetActive(true);
                audioScript.audioSource.Stop();
                audioScript.PlayWin();
            }else{
                objectScript.panel.sprite = objectScript.loseGame;
                objectScript.scoreBoard.SetActive(true);
                objectScript.scoreBoardText.text="Bēdīga spēle";
                objectScript.iziet.gameObject.SetActive(true);
                objectScript.restart.gameObject.SetActive(true);
                audioScript.audioSource.Stop();
                audioScript.PlayLose();

            }
        }
        //pec 10tas atbildes ielades scoreBoard
        
    }
    private void Questions(){
//pirmais jautajms 1. pareiz
        if(q1==false){
            if(button1Clicked==true){
                objectScript.score++;
                q1 = true;
               scoreScript.UpdateScore();
            }else{
                q1 = true;
            }
            objectScript.button1.image.sprite = objectScript.img2;
//otrais jautajums 2. pareiz
        }else if(q2==false){
            if(button2Clicked==true){
                objectScript.score++;
                q2=true;
                scoreScript.UpdateScore();
            }else{
               q2=true;
            }
            objectScript.button2.image.sprite=objectScript.img2;
//tresais jautajums 1. pareiz
        }else if(q3==false){
            if(button1Clicked==true){
                objectScript.score++;
                q3 = true;
                scoreScript.UpdateScore();
            }else{
                q3 = true;
            }
            objectScript.button1.image.sprite = objectScript.img2;
        }else if(q4==false){
             if(button3Clicked==true){
                objectScript.score++;
                q4 = true;
                scoreScript.UpdateScore();
            }else{
                q4 = true;
            }
            objectScript.button3.image.sprite =objectScript.img2;   
        }else if(q5==false){
            if(button3Clicked==true){
                objectScript.score++;
                q5 = true;
                scoreScript.UpdateScore();
            }else{
                q5 = true;
            }
            objectScript.button3.image.sprite = objectScript.img2; 
        }else if(q6==false){
            if(button3Clicked==true){
                objectScript.score++;
                q6 = true;
                scoreScript.UpdateScore();
            }else{
                q6 = true;
            }
            objectScript.button3.image.sprite = objectScript.img2; 
        }else if(q7==false){
            if(button2Clicked==true){
                objectScript.score++;
                q7 = true;
                scoreScript.UpdateScore();
            }else{
                q7 = true;
            }
            objectScript.button2.image.sprite = objectScript.img2; 
        }else if(q8==false){
            if(button2Clicked==true){
                objectScript.score++;
                q8 = true;
                scoreScript.UpdateScore();
            }else{
                q8 = true;
            }
            objectScript.button2.image.sprite = objectScript.img2; 
        }else if(q9==false){
            if(button4Clicked==true){
                objectScript.score++;
                q9 = true;
                scoreScript.UpdateScore();
            }else{
                q9 = true;
            }
            objectScript.button4.image.sprite = objectScript.img2; 
        }else if(q10==false){
            if(button1Clicked==true){
                objectScript.score++;
                q10 = true;
                scoreScript.UpdateScore();
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
    objectScript.questionText.text = "Kura ir pareizā do while sintakse?";
    objectScript.button1txt.text="do{}while(paziņojums)";
    objectScript.button2txt.text = "do{}while(nosacījums)";
    objectScript.button3txt.text = "while(paziņojums){}";
    objectScript.button4txt.text = "while(nosacījums){}";
    }
    //ielade treso jautajumu
    private void Q3Load(){
    objectScript.questionText.text = "Priekšlaicīgai iziešanai no do while izmanto?";
    objectScript.button1txt.text="break";
    objectScript.button2txt.text = "exit";
    objectScript.button3txt.text = "quit";
    objectScript.button4txt.text = "stop";
    }
    private void Q4Load(){
    objectScript.questionText.text = "Jaidoma q";
    objectScript.button1txt.text="s";
    objectScript.button2txt.text = "d";
    objectScript.button3txt.text = "f";
    objectScript.button4txt.text = "gg";
    }
    private void Q5Load(){
    objectScript.questionText.text = "Vai vienā do while var būt vēlviens do while?";
    objectScript.button1txt.text="Nē";
    objectScript.button2txt.text = "Ja nosacījums ir nepaties";
    objectScript.button3txt.text = "Jā";
    objectScript.button4txt.text = "Ja nosacījums ir paties";
    }
    private void Q6Load(){
    objectScript.questionText.text = "Cikls ar skaitītāju ir do while cikls?";
    objectScript.button1txt.text= "Jā";
    objectScript.button2txt.text = "Nē tas ir while loop";
    objectScript.button3txt.text = "Nē tas ir for loop";
    objectScript.button4txt.text = "Nē tāda nav";
    }
    private void Q7Load(){
    objectScript.questionText.text = "Kad tiek izpildīts nosacījums do while ciklā?";
    objectScript.button1txt.text="Pēc cikla";
    objectScript.button2txt.text = "Pēc paziņojuma";
    objectScript.button3txt.text = "Pirms paziņojuma";
    objectScript.button4txt.text = "Pirms cikla";
    }
    private void Q8Load(){
    objectScript.questionText.text = "Kurš ir pareizs do while cikls?";
    objectScript.button1txt.text="while(){x==true}";
    objectScript.button2txt.text = "do{}while(x==true)";
    objectScript.button3txt.text = "do{x==true}while()";
    objectScript.button4txt.text = "while(x==true){}";
    }
    private void Q9Load(){
    objectScript.questionText.text = "Pareizs do while cikla pielietojums?";
    objectScript.button1txt.text= "do(x!=3)while{}";
    objectScript.button2txt.text = "do()while{x!=3}";
    objectScript.button3txt.text = "do{x!=3}while()";
    objectScript.button4txt.text = "do{}while(x!=3)";
    }
    private void Q10Load(){
    objectScript.questionText.text = "jaizdoma q";
    objectScript.button1txt.text="ff";
    objectScript.button2txt.text = "aa";
    objectScript.button3txt.text = "3";
    objectScript.button4txt.text = "tt";
    }
}


