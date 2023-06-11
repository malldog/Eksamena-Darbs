using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class ChangeButtonImage : MonoBehaviour
{
    public Text questionText;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Text button1txt;
    public Text button2txt;
    public Text button3txt;
    public Text button4txt;
    public Sprite img1;
    public Sprite img2;
    public Sprite img3;
    private float score;
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

    public void OnButton1Click()
    {
        button1Clicked = true;
        button1.image.sprite = img1;
        Questions();
        // StartCoroutine(LaiksKamerPogaAtslegta());
    }

    public void OnButton2Click()
    {
        button2Clicked = true;
        button2.image.sprite = img1;
        Questions();
        // StartCoroutine(LaiksKamerPogaAtslegta());
    }

    public void OnButton3Click()
    {
        button3Clicked = true;
        button3.image.sprite = img1;
        Questions();
        // StartCoroutine(LaiksKamerPogaAtslegta());
    }

    public void OnButton4Click()
    {
        button4Clicked = true;
        button4.image.sprite = img1;
        Questions();
        // StartCoroutine(LaiksKamerPogaAtslegta());
        
    }
    private IEnumerator LaiksKamerPogaAtslegta(){
        button1.interactable = false;
        button2.interactable = false;
        button3.interactable = false;
        button4.interactable = false;
        button1Clicked=false;
        button2Clicked=false;
        button3Clicked=false;
        button4Clicked=false;
        yield return new WaitForSeconds(3f);
        button1.image.sprite = img3;
        button2.image.sprite = img3;
        button3.image.sprite = img3;
        button4.image.sprite = img3;
        button1.interactable = true;
        button2.interactable = true;
        button3.interactable = true;
        button4.interactable = true;
    }
    //3 sekundes parada pareizo atbildi
    private IEnumerator ShowCorrectAnswers(){
        yield return new WaitForSeconds(3f);
        if(q1==true && q2==false){
        Q2Load();
        }else if(q2==true && q3==false){
        Q3Load();
        }
        
    }
    private void Questions(){
//pirmais jautajms
        if(q1==false){
            if(button1Clicked==true){
                score++;
                
                q1 = true;
            }else{
                
                q1 = true;
            }
            button1.image.sprite = img2;
//otrais jautajums
        }else if(q2==false){
            if(button2Clicked==true){
                score++;
                
                q2=true;
            }else{
               
                q2=true;
            }
            button2.image.sprite=img2;
//tresais jautajums
        }else if(q3==false){

        }else if(q4==false){

        }else if(q5==false){

        }
        StartCoroutine(LaiksKamerPogaAtslegta());
            StartCoroutine(ShowCorrectAnswers());
    }
    //ielade otro jautajumu
    private void Q2Load(){
    questionText.text = "celebrant?";
    button1txt.text="jatbildd";
    button2txt.text = "bbbb";
    button3txt.text = "ddd";
    button4txt.text = "eee12331";
    }
    //ielade treso jautajumu
    private void Q3Load(){
        questionText.text = "Pareizs termins ciklam ar pecnosacijumu?";
    button1txt.text="ff";
    button2txt.text = "aa";
    button3txt.text = "3";
    button4txt.text = "tt";
    }
}


