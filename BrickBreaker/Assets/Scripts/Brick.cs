using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    
    private int timesHit;
    public Sprite[] hitsSprites;

    private LevelManager levelManager;

	// Use this for initialization
	void Start () {
        timesHit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		

	}


    void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        int maxHits = hitsSprites.Length + 1;
        if(timesHit >= maxHits)
        {
            Destroy(gameObject);
        }
        else
        {
            LoadSprites();
        }
        
    }

    void LoadSprites()
    {
        int spriteIndex = timesHit - 1;
        this.GetComponent<SpriteRenderer>().sprite = hitsSprites[spriteIndex];
    }

    void SimulaleWin()
    {
        levelManager.LoadNextLevel();
    }
}
