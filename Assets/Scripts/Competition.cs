using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Competition : MonoBehaviour
{
    public List<GameObject> competitor;
    public List<Text> competitorNameText, competitorPosZText;
    public List<float> posZ;
    void Start()
    {
        for (int i = competitor.Count - 1; i > -1; i--)
        {
            competitorNameText[i].text = competitor[i].name;
        }
    }
    void Update()
    {
        Competitor();
    }
    void Competitor()
    {
        for (int i = competitor.Count - 1; i > -1; i--)
        {
            posZ[i] = competitor[i].transform.position.z;
            competitorPosZText[i].text = "" + (int)posZ[i];
        }
        if (SwerveMove.instance.finish)
        {
            for (int i = 0; i < competitor.Count; i++)
            {
                competitorPosZText[i].gameObject.SetActive(false);
                competitorNameText[i].gameObject.SetActive(false);
            }
        }
    }
}
