using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ChoiceElement", menuName = "ChoiceMenu/Element", order = 2)]
public class ChoiceElement : ScriptableObject
{
    public Choice NextChoice;
    public AnimationClip AnimationC;

    public void Picked()
    {
        Debug.Log("You have picked " + AnimationC.name);
    }
}
