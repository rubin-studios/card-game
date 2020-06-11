using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardDisplay : MonoBehaviour
{

    public CardTemplate m_CardData;

    //Revenue can be changed after card instantiation
    public int currentRevenue;
    public int baseRevenue;

    public TextMeshPro m_Title;
    public TextMeshPro m_ExternalDescription;
    public TextMeshPro m_InternalDescription;
    public TextMeshPro m_Cost;
    public TextMeshPro m_CurrentRevenue;
    public TextMeshPro m_Research;

    // Start is called before the first frame update
    void Start()
    {
        baseRevenue = m_CardData.m_Revenue;
        currentRevenue = baseRevenue;

        RefreshCardText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RefreshCardText()
    {
        m_Title.text = m_CardData.m_Title;
        m_ExternalDescription.text = m_CardData.m_ExternalText;
        m_InternalDescription.text = m_CardData.m_InternalText;
        m_Cost.text = m_CardData.m_Cost.ToString();
        m_CurrentRevenue.text = currentRevenue.ToString();
        m_Research.text = m_CardData.m_Research.ToString();
    }

    public int GetResearch()
    {
        return m_CardData.m_Research;
    }
    public int GetBaseRevenue()
    {
        return baseRevenue;
    }

    public int GetCurrentRevenue()
    {
        return currentRevenue;
    }


    public void SetBaseRevenue(int value)
    {
        baseRevenue = value;
        RefreshCardText();
    }

    public void SetCurrentRevenue(int value)
    {
        currentRevenue = value;
        RefreshCardText();
    }
}





