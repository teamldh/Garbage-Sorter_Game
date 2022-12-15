using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragObject : MonoBehaviour
{
    //public GameObject test;
    Rigidbody2D rb;
    BoxCollider2D col;
    private SpriteRenderer sr;
    private bool isDrag;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
        rb.constraints = RigidbodyConstraints2D.None;
    }
    // Update is called once per frame
    void Update()
    {
        if(isDrag){
            Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(position);
        }
    }
    private void OnMouseDown() {
        if(Input.GetMouseButtonDown(0)){
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            sr.sortingOrder = 3;
            col.enabled = false;
            isDrag = true;
        }
    }
    public void OnMouseUp() {
        if(Input.GetMouseButtonUp(0)){
            sr.sortingOrder = 1;
            if(gameObject.name == "Botol(Clone)" || gameObject.name == "KantongPlastik(Clone)"){
                gameObject.tag = "Anorganik";
                rb.constraints = RigidbodyConstraints2D.None;
                Destroy(GetComponent<MoveLeft>());
            }
            else if(gameObject.name == "KulitPisang(Clone)" || gameObject.name == "Ranting(Clone)"){
                gameObject.tag = "Organik";
                rb.constraints = RigidbodyConstraints2D.None;
                Destroy(GetComponent<MoveLeft>());
            }
            else if(gameObject.name == "KalengSemprot(Clone)" || gameObject.name == "BotolKaca(Clone)"){
                gameObject.tag = "B3";
                rb.constraints = RigidbodyConstraints2D.None;
                Destroy(GetComponent<MoveLeft>());
            }
            else if(gameObject.name == "Majalah(Clone)" || gameObject.name == "BungkusMakanan(Clone)"){
                gameObject.tag = "Kertas";
                rb.constraints = RigidbodyConstraints2D.None;
                Destroy(GetComponent<MoveLeft>());
            }
            col.enabled = true;
            isDrag = false;
        }
        //  tesTag = GameObject.FindGameObjectsWithTag("tong");

        // if (Mathf.Abs(this.transform.localPosition.x - tesTag.x) < 0.8f && Mathf.Abs(this.transform.localPosition.y - tesTag.y) < 0.8f){
        //     this.transform.localPosition += -transform.up;
        // }
    }
}
