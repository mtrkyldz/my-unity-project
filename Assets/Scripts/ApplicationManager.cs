using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationManager : MonoBehaviour
{
    public static ApplicationManager Instance;
    public SceneController sceneController;
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

    // Update is called once per frame
    void Update()
    {
        
    }

}
