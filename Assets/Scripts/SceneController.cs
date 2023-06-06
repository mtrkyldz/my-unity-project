using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MyComponent
{
    public enum Scenes{
        MainMenu,
        GameScene,
        LoadingScene,
    }
    public void SetScene(Scenes sceneName){
        if(GetCurrentScene()!=sceneName.ToString()){
            SceneManager.LoadScene(sceneName.ToString());        
            Debug.Log(sceneName.ToString() + " scene loaded");
        }

    }

    public string GetCurrentScene(){
        return SceneManager.GetActiveScene().name;
    }

    // Start is called before the first frame update
}
