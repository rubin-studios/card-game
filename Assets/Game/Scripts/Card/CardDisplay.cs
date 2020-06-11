using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardDisplay : MonoBehaviour
{

    public CardTemplate m_Card;

    public TextMeshPro m_Title;
    public TextMeshPro m_ExternalDescription;
    public TextMeshPro m_InternalDescription;
    public TextMeshPro m_Cost;
    public TextMeshPro m_Revenue;

    // Start is called before the first frame update
    void Start()
    {
        m_Title.text = m_Card.m_CardName;
        m_ExternalDescription.text = m_Card.m_CardDescriptionTop;
        m_InternalDescription.text = m_Card.m_CardDescriptionBottom;
        m_Cost.text = m_Card.m_CardCost.ToString();
        m_Revenue.text = m_Card.m_Revenue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}





