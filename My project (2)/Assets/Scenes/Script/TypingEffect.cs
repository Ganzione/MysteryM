using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypingEffect : MonoBehaviour
{
    public Text tx;
    public List<string> list_m_text;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing());
    }

    // Update is called once per frame
    IEnumerator _typing()
    {
        for(int listCount = 0; listCount < list_m_text.Count; listCount++)
        {
            for (int i = 0; i <= list_m_text[listCount].Length; i++)
            {
                tx.text = list_m_text[listCount].Substring(0, i);
                yield return new WaitForSeconds(0.1f);
            }
            yield return new WaitForSeconds(1.0f);
        } 
    }
}
