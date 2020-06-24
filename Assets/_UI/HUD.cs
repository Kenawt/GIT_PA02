﻿﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public static HUD HUDManager;
    [SerializeField] private Image Image_Lives;
    [SerializeField] private Text Txt_Message;
 
    void Start()
    {
        HUDManager = this;
    }

    //Keep lives updated
    void Update()
    {
        Image_Lives.rectTransform.sizeDelta = new Vector2(GameManager.Lives * 50, 30);

        if(GameManager.Lives == 0)
        {
            Image_Lives.enabled = false;
            GameManager.CurrentState = GameManager.GameState.GameOver;
            Txt_Message.color = Color.red;
            Txt_Message.text = "GAME OVER! \n PRESS ENTER TO RESTART GAME.";
            Time.timeScale = 0;
        }
    }

    public void DismissMessage()
    {
        Txt_Message.text = "";
    }
}
