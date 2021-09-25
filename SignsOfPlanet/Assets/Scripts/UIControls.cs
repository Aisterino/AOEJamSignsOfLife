using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControls : MonoBehaviour
{
    Animator animator;
    bool PointerEntered = false;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void PointerEnter()
    {
        if(!PointerEntered)
            animator.SetBool("PointerEnter", true);
        PointerEntered = true;
    }

    public void PointerExit()
    {
        if (PointerEntered)
        {
            animator.SetBool("PointerEnter", false);
            PointerEntered = false;
        }
    }
}
