using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUI : MyComponent
{
    // Start is called before the first frame update

    [SerializeField] private Button startButton;
    [SerializeField] private Button creditsButton;

    void Awake()
    {
        startButton.onClick.AddListener(()=>{
            app.sceneController.SetScene(SceneController.Scenes.GameScene);
        });
        creditsButton.onClick.AddListener(()=>{
            CreditsUI.Instance.Show();
        });

        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
