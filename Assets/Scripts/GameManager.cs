using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance{get; private set;}
    // Start is called before the first frame update
    private bool isGamePaused;

    public event EventHandler OnGamePaused;
    public event EventHandler OnGameUnpaused;
    void Awake()
    {
        if(Instance != null){
            Destroy(gameObject);
        }
        else{
            Instance = this;
        }
    }
    void Start(){
        GameInput.Instance.OnPauseAction += GameInput_OnPauseAction;
    }

    private void GameInput_OnPauseAction(object sender, EventArgs e)
    {
        TogglePauseGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TogglePauseGame(){
        isGamePaused = !isGamePaused;
        if(isGamePaused){
            Time.timeScale = 0f;
            OnGamePaused?.Invoke(this,EventArgs.Empty);
        }
        else{
            Time.timeScale = 1f;
            OnGameUnpaused?.Invoke(this,EventArgs.Empty);
        }

    }
}
