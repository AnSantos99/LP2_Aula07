using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleMessages : MonoBehaviour
{

    private EventMaster em;

    // Start is called before the first frame update
    private void Awake()
    {
        em = GetComponent<EventMaster>();
    }

    private void OnEnable()
    {
        em.KeyPress += ShowConsoleMessage;
    }

    // Use this to remove event listeners
    private void OnDisable()
    {
        em.KeyPress -= ShowConsoleMessage;
    }

    private void ShowConsoleMessage(char c) 
    {
        Debug.Log(c.ToString());
    }
}
