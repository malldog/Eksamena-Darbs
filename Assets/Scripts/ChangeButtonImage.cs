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
        
        // if (button1Clicked)
        // {
        //     Debug.Log("Button 1 clicked!");
        //     button1Clicked = false;
        // }

        // if (button2Clicked)
        // {
        //     Debug.Log("Button 2 clicked!");
        //     button2Clicked = false;
        // }

        // if (button3Clicked)
        // {
        //     Debug.Log("Button 3 clicked!");
        //     button3Clicked = false;
        // }

        // if (button4Clicked)
        // {
        //     Debug.Log("Button 4 clicked!");
        //     button4Clicked = false;
        // }
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
    private void Questions(){
        if(q1==false){
            if(button1Clicked==true){
                score++;
                button1.image.sprite = img2;
                q1 = true;
            }else{
                button1.image.sprite = img2;
                q1 = true;
            }
            StartCoroutine(LaiksKamerPogaAtslegta());
            Q2Load();

        }else if(q2==false){
            if(button2Clicked==true){
                score++;
                button2.image.sprite = img2;
                q2=true ;
            }else{
                button2.image.sprite = img2;
                q2=true;
            }
            StartCoroutine(LaiksKamerPogaAtslegta());
            

        }else if(q3==false){

        }
    }
    private void Q2Load(){
    questionText.text = "celebrant?";
    }
        




    // private void ChangeImage(Button button)
    // {
    //     clickedButton = button;

    //     clickedButton.image.sprite = img1;
    //     StartCoroutine(DelayedChangeImage(clickedButton));

    //     button1.interactable = false;
    //     button2.interactable = false;
    //     button3.interactable = false;
    //     button4.interactable = false;
    // }
    
    // private IEnumerator DelayedChangeImage(Button button)
    // {
    //     yield return new WaitForSeconds(3f);
        
    //     button.image.sprite = img2;

    //     button1.interactable = true;
    //     button2.interactable = true;
    //     button3.interactable = true;
    //     button4.interactable = true;
    // }
}


