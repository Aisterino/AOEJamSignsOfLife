using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceTreeMB : MonoBehaviour
{
    public static int NumberOfChoices = 3;
    public Image[] ChUIImages = new Image[NumberOfChoices];
    public Choice Data;
    Animator animator;
    public GameObject[] ChButtons = new GameObject[NumberOfChoices]; 

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void ChoiceButPressed(int choice)
    {
        if(Enumerable.Range(0, NumberOfChoices).Contains(choice))
        {
            foreach(GameObject but in ChButtons)
            {
                but.SetActive(false);
            }
            //Data.Elements[choice].Picked();
            //Invoke("NewPhase", Data.Elements[choice].AnimationC.length);
            Debug.Log(choice);
            Debug.Log(Data.name);
            animator.SetTrigger(Data.Elements[choice].AnimationC.name);

            //Data = Data.Elements[choice].NextChoice;
        }
    }

    public void NewPhase()
    {
        for(int i = 0; i < Data.Elements.Length; i++)
        {
            ChUIImages[i].sprite = Data.nextChoiceIcons[i];
        }
    }
}

