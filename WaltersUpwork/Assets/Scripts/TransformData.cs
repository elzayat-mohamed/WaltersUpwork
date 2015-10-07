using UnityEngine;

public class TransformData
{
    public Vector3 Position { get; set; }
    public Quaternion Rotation { get; set; }
    public Vector3 Scale { get; set; }

    public TransformData()
    {
        this.Position = Vector3.zero;
        this.Rotation = Quaternion.identity;
        this.Scale = Vector3.one;
    }

    public TransformData(Transform transform)
    {
        this.Position = transform.position;
        this.Rotation = transform.rotation;
        this.Scale = transform.localScale;
    }

    public static void AssignTransform(Transform UnityTranform, TransformData OriginalTranform)
    {
        UnityTranform.position = OriginalTranform.Position;
        UnityTranform.rotation = OriginalTranform.Rotation;
        UnityTranform.localScale = OriginalTranform.Scale;
    }
}
