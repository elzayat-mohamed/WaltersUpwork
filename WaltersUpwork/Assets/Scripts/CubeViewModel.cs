using UnityEngine;

public class CubeViewModel : Interactable
{

    private TransformData OriginalTranform;
    private Color color;

    void Awake()
    {
        this.color = GetComponent<Renderer>().sharedMaterial.color;
        this.OriginalTranform = new TransformData(this.transform);
    }

    public override void Play()
    {
    }

    public override void Reset()
    {
        this.GetComponent<Renderer>().sharedMaterial.color = this.color;
        TransformData.AssignTransform(this.transform, OriginalTranform);
    }
}