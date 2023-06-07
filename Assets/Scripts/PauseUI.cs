using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseUI : MyComponent
{
    // Start is called before the first frame update
    [SerializeField] private Button resumeButton;
    [SerializeField] private Button mainMenuButton;
    

    void Awake(){
        resumeButton.onClick.AddListener(()=>{
            GameManager.Instance.TogglePauseGame();
        }); 
        
        mainMenuButton.onClick.AddListener(()=>{
            app.sceneController.SetScene(SceneController.Scenes.MainMenu);
        }); 
        
    }
    void Start()
    {
        GameManager.Instance.OnGamePaused += GameManager_OnGamePaused;
        GameManager.Instance.OnGameUnpaused += GameManager_OnGameUnpaused;

        Hide();
    }

    private void GameManager_OnGameUnpaused(object sender, EventArgs e)
    {
        Hide();
    }

    private void GameManager_OnGamePaused(object sender, EventArgs e)
    {
        Show();
    }

    public void Show(){
        gameObject.SetActive(true);
    }

    public void Hide(){
        gameObject.SetActive(false);
    }
}
