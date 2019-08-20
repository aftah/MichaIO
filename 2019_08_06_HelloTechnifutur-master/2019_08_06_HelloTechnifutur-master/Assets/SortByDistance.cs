using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SortByDistance : MonoBehaviour
{
    public Transform m_target;
    public Transform [] m_pointList;


    void Update()
    {
       List<Transform> t = m_pointList.OrderBy(k => Vector3.Distance(m_target.position, k.position)).ToList() ;

        for (int i = 0; i < t.Count; i++)
        {
            t[i].localScale =Vector3.one* (i * 0.5f);
        }

    }
}
