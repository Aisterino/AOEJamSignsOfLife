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

    public void ChoiceButPressed(int choice)
    {
        if(Enumerable.Range(0, NumberOfChoices).Contains(choice))
        {
            Data.Elements[choice].Picked();

            Invoke("NewPhase", Data.Elements[choice].AnimationC.length);
            Data.Elements[choice].Animator.SetBool("Start", true);

            Data = Data.Elements[choice].NextChoice;
        }
    }

    public void NewPhase()
    {
        for(int i = 0; i < Data.Elements.Length; i++)
        {
            ChUIImages[i].sprite = Data.Elements[i].Icon;
        }
    }
}

