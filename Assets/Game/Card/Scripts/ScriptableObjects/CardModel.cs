using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class CardModel : ScriptableObject
{
    public string m_Id;
    public string m_Title;
     [TextArea]
    public string m_Text;
    public GameRow m_PreferredRow;
    public AdjTag m_ClassTag;
    public NounTag m_NounTag;
    public int m_Cost;
    public int m_Revenue;
    public int m_Research;
}
