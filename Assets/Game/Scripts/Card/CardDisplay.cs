using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardDisplay : MonoBehaviour
{

    public CardTemplate m_CardData;

    public TextMeshPro m_Title;
    public TextMeshPro m_ExternalDescription;
    public TextMeshPro m_InternalDescription;
    public TextMeshPro m_Cost;
    public TextMeshPro m_Revenue;
    public TextMeshPro m_Research;

    // Start is called before the first frame update
    void Start()
    {
        m_Title.text = m_CardData.m_Title;
        m_ExternalDescription.text = m_CardData.m_ExternalText;
        m_InternalDescription.text = m_CardData.m_InternalText;
        m_Cost.text = m_CardData.m_Cost.ToString();
        m_Revenue.text = m_CardData.m_Revenue.ToString();
        m_Research.text = m_CardData.m_Research.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}





