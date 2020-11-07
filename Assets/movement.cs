using System.Collections;
using System.Collections.Generic;
using TMPro.SpriteAssetUtilities;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
    const int speed = 10;
    public GameObject fire;
    public GameObject monster;
    public GameObject audio_mons;
    public GameObject audio_trap;
    public static int coin = 0;
    bool died = false;
    AudioSource aud;
    public int round = 0;
    public static int totalCoin = 0;

    void RoundChange()
    {
        switch (round)
        {
            case 0:
                transform.position = new Vector3(-17, -28, 0);  //전성아
                monster.transform.position = new Vector3(51, -16, 0);
                break;
            case 1:
                transform.position = new Vector3(-150, 31, 0); //변양석
                monster.transform.position = new Vector3(-137, 31, 0);
                break;
            case 2:
                transform.position = new Vector3(-305, -18, 0); //박시현
                monster.transform.position = new Vector3(-255, 12, 0);
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        RoundChange();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.up *speed, Time.deltaTime * 1f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.left *speed, Time.deltaTime * 1f);
            fire.transform.eulerAngles = new Vector3(0, 180, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.down *speed, Time.deltaTime * 1f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.right *speed, Time.deltaTime * 1f);
            fire.transform.eulerAngles = Vector3.zero;
        }
        if (died == true) Time.timeScale = 0;
        if (Input.GetKey(KeyCode.R)) //Will be respawned based on round variable
        {
            RoundChange();
            died = false;
            Time.timeScale = 1.0f;
            
        }
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("충돌");
        if (coll.gameObject.tag == "monster")
        {
            Debug.Log("monster");
            aud = audio_mons.GetComponent<AudioSource>();
            aud.Play();
            died = true;
        }
        if (coll.gameObject.tag == "trap")
        {
            Debug.Log("trap");
            aud = audio_trap.GetComponent<AudioSource>();
            aud.Play();
            died = true;
        }
        if (coll.gameObject.tag == "coin")
        {
            Debug.Log("coin");
            coin++;
            Destroy(coll.gameObject, 0);
        }
        if (coll.gameObject.tag == "Finish")
        {
            Debug.Log("Finish");
            round++;
            RoundChange();
            totalCoinLeft();
        }
    }
    private void totalCoinLeft() //Calculate total number of coins
    {
        switch(round)
        {
            case 0:
                totalCoin = 0;
                break;
            case 1:
                totalCoin = 6;
                break;
            case 2:
                totalCoin = 4;
                break;

        }
    }
}
