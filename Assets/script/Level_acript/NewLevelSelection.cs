using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewLevelSelection : MonoBehaviour
{
    private int level;
    public Button[] selectLevel;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        level = PlayerPrefs.GetInt("Lv", 1);
        for (int i = 0; i<selectLevel.Length; i++){
            if (i+1 > level){
                selectLevel[i].interactable=false;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void sceneChange(string nameScene){
        SceneManager.LoadScene(nameScene);
    }
    public void btnSFX(){
        Sound_Manager.instance.ButtonSFX();
    }
}
