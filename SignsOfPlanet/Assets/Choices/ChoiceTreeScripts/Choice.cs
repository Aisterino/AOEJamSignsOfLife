using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Choice", menuName = "ChoiceMenu/Choice", order = 1)]
public class Choice : ScriptableObject
{
    public ChoiceElement[] Elements = new ChoiceElement[ChoiceTreeMB.NumberOfChoices];
    public Sprite[] nextChoiceIcons = new Sprite[ChoiceTreeMB.NumberOfChoices];
}
