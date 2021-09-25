using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ChoiceElement", menuName = "ChoiceMenu/Element", order = 2)]
public class ChoiceElement : ScriptableObject
{
    public string Name;
    public Sprite Icon;
    public Choice NextChoice;
    public AnimationClip AnimationC;
    public Animator Animator;

    public void Picked()
    {
        Debug.Log("You have picked " + Name);
    }
}
