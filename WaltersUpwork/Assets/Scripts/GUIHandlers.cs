using System;
using UnityEngine;
using UnityEngine.UI;

public class GUIHandlers : MonoBehaviour
{

    public Button btnPlay;
    public Button btnReset;

    public Slider slRotateX;
    public Slider slRotateY;
    public Slider slRotateZ;
    public Slider slScaleX;
    public Slider slScaleY;
    public Slider slScaleZ;

    public event Action onPlayClick;
    public event Action onResetClick;

    public event Action<float> OnRotateX;
    public event Action<float> OnRotateY;
    public event Action<float> OnRotateZ;
    public event Action<float> OnScaleX;
    public event Action<float> OnScaleY;
    public event Action<float> OnScaleZ;

    public event Action<float> OnRotateXClick;

    void Awake()
    {

        btnPlay.onClick.AddListener(() => {
            if (onPlayClick != null)
                onPlayClick();
        });

        btnReset.onClick.AddListener(() => {
            if (onResetClick != null)
                onResetClick();
        });

        slRotateX.onValueChanged.AddListener(v => {
            if (OnRotateX != null)
                OnRotateX(v);
        });

        slRotateY.onValueChanged.AddListener(v => {
            if (OnRotateY != null)
                OnRotateY(v);
        });

        slRotateZ.onValueChanged.AddListener(v => {
            if (OnRotateZ != null)
                OnRotateZ(v);
        });

        slScaleX.onValueChanged.AddListener(v => {
            if (OnScaleX != null)
                OnScaleX(v);
        });

        slScaleY.onValueChanged.AddListener(v => {
            if (OnScaleY != null)
                OnScaleY(v);
        });

        slScaleZ.onValueChanged.AddListener(v => {
            if (OnScaleZ != null)
                OnScaleZ(v);
        });
    }

    public void ResetGUI()
    {
        slRotateX.value = 0;
        slRotateY.value = 0;
        slRotateZ.value = 0;
        slScaleX.value = 1;
        slScaleY.value = 1;
        slScaleZ.value = 1;
    }
}
