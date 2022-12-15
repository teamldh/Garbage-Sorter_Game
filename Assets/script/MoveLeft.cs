using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public static MoveLeft instance;
    public float speed_Lvl_1;
    public float speed_Lvl_2;
    public float speed_Lvl_3;
    // Start is called before the first frame update
    void Start()
    {
        instance=this;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.levelIndex == 1){
            transform.position += -transform.right * speed_Lvl_1 * Time.deltaTime;
        }
        else if(GameManager.instance.levelIndex == 2){
            transform.position += -transform.right * speed_Lvl_2 * Time.deltaTime;
        }
        else{
            transform.position += -transform.right * speed_Lvl_3 * Time.deltaTime;
        }
    }
}
