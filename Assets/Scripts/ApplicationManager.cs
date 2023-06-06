using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationManager : MonoBehaviour
{
    public static ApplicationManager Instance;
    public SceneController sceneController;
    public GameInput gameInput;
    // Start is called before the first frame update
    void Awake()
    {
        if(Instance!=null){
            Destroy(gameObject);
        }
        else{
            Instance=this;
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start(){
        gameInput.OnPauseAction += GameInput_OnPauseAction;
    }

    private void GameInput_OnPauseAction(object sender, EventArgs e)
    {
        PauseGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void PauseGame(){
        if(sceneController.GetCurrentScene()=="GameScene"){
            Time.timeScale = 1 - Time.timeScale;
        }
    }
}
