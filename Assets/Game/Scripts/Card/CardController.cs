using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardController : MonoBehaviour
{

    public CardTemplate m_CardData;

    //Revenue can be changed after card instantiation
    private int currentRevenue;
    private int baseRevenue;

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

        RefreshRevenueColour();
    }

    public void RefreshRevenueColour()
    {
        if (currentRevenue < baseRevenue)
        {
            //If project is SETBACK, colour is red
            m_CurrentRevenue.color = Color.red;
        }
        else if (currentRevenue > baseRevenue)
        {
            //If project is BOOSTED, colour is green
            m_CurrentRevenue.color = Color.green;
        }
        else
        {
            // If project is at base revenue, colour is grey
            m_CurrentRevenue.color = new Color(0.15f,0.15f,0.15f,1);
        }
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





