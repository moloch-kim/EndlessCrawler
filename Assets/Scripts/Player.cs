using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [field: SerializeField] public PlayerSO Data {  get; private set; }

    [field:Header("Animations")]
    [field:SerializeField] public PlayerAnimationData AnimData { get; private set; }

    public Animator anim;


    private void Start()
    {
        AnimData.Initialize();
        anim = GetComponent<Animator>();
        //
    }


}
