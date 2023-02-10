using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //[SerializeField] private GameObject playButton;
    [SerializeField] private Text stateText;
    [SerializeField] private List<GameObject> objectsToEnable;
    [SerializeField] private List<GameObject> objectsToDisable;

    private void Start()
    {
        // Subscribe to events
        GameManager.Instance.MatchFound += MatchFound;
        GameManager.Instance.UpdateState += UpdateState;

        // Disables all objects in the list
        foreach (GameObject o in objectsToDisable)
        {
            o.SetActive(true);
        }

        // Enables all objects in the list
        foreach (GameObject o in objectsToEnable)
        {
            o.SetActive(false);
        }
    }

    private void UpdateState(string newState)
    {
        stateText.text = newState;
    }

    private void MatchFound()
    {
        // Disables all objects in the list
        foreach (GameObject o in objectsToDisable)
        {
            o.SetActive(false);
        }

        // Enables all objects in the list
        foreach (GameObject o in objectsToEnable)
        {
            o.SetActive(true);
        }
    }

    private void OnDestroy()
    {
        // Unsubscribe from events
        GameManager.Instance.MatchFound -= MatchFound;
        GameManager.Instance.UpdateState -= UpdateState;
    }
}