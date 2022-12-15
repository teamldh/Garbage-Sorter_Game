using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    public GameObject skor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.name == "currentScore"){
            GetComponent<Text>().text = skor.GetComponent<score>().skor.ToString();
        }
    }
}
