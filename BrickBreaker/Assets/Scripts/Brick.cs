using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int maxHits;
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
    }

    void SimulaleWin()
    {
        levelManager.LoadNextLevel();
    }
}
