using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class CardTemplate : ScriptableObject
{
    public string m_Id;
    public string m_Title;
     [TextArea]
    public string m_ExternalText;
     [TextArea]
    public string m_InternalText;
    public int m_Cost;
    public int m_Revenue;
    public int m_Research;
}
