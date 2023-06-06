using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
//    [SerializeField] private PlayerAnimator player;
    Animator playerAnimator;
    [SerializeField] private Player player;
    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        playerAnimator.SetBool("IsMoving", player.IsMoving());
        playerAnimator.SetBool("IsJumping", player.IsJumping());
        playerAnimator.SetBool("IsRunning", player.IsRunning());
    }

}
