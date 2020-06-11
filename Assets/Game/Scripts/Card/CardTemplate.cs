using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class CardTemplate : ScriptableObject
{

    public string m_CardName;
     [TextArea]
    public string m_CardDescriptionTop;
     [TextArea]
    public string m_CardDescriptionBottom;
    public int m_CardCost;
    public int m_Revenue;
}
