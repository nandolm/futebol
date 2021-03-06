﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;

    //musicas
    public AudioClip[] clips;
    public AudioSource musicaBG;
    //sons
    public AudioClip[] clipsSons;
    public AudioSource sonsFX;



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    AudioClip GetRandom()
    {
        return clips[Random.Range(0, clips.Length)];
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!musicaBG.isPlaying)
        {
            musicaBG.clip = GetRandom();
            musicaBG.Play();
        }
    }

    public void SonsFxTocar(int index)
    {
        this.sonsFX.clip = clipsSons[index];
        this.sonsFX.Play();
    }
}
