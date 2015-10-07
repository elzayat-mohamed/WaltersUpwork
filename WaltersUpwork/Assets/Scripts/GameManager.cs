using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public CubeManager cubeManager;
    public GUIHandlers guiHandlers;
    public List<Interactable> GameObjectStateList;

    void Awake()
    {
        this.cubeManager.Initialize(guiHandlers);
        this.guiHandlers.onPlayClick += onPlayClick;
        this.guiHandlers.onResetClick += onResetClick;
    }
    void onPlayClick()
    {
        foreach (var item in GameObjectStateList)
        {
            item.Play();
        }
    }
    void onResetClick()
    {
        foreach (var item in GameObjectStateList)
        {
            item.Reset();
        }
        guiHandlers.ResetGUI();
    }
}
