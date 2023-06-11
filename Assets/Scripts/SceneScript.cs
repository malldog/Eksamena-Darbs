using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneScript : MonoBehaviour {

	public void UzSakumu()
    {
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
    }
    public void Apturet()
    {
        Application.Quit();
    }
    public void UzMain()
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }
}
