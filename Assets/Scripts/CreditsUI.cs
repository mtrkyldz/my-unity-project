using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsUI : MonoBehaviour
{
    public static CreditsUI Instance{get; private set;}

    [SerializeField] private Button backButton;

    private void Awake(){
        Instance = this;
        Hide();
    }
    private void Start(){
        backButton.onClick.AddListener(()=>{
            Hide();
        });
    }
    public void Show(){
        gameObject.SetActive(true);
    }
    
    public void Hide(){
        gameObject.SetActive(false);
    }
}
