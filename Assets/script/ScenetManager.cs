using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenetManager : MonoBehaviour
{
    public void ChangeScene(string nameScene){
        SceneManager.LoadScene(nameScene);
        Time.timeScale=1;
    }
}
