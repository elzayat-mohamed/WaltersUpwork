using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SphereViewModel : Interactable
{

    private Rigidbody rigidBody;
    private TransformData OriginalTranform;

    void Awake()
    {
        this.rigidBody = this.GetComponent<Rigidbody>();
        this.rigidBody.isKinematic = true;
        this.OriginalTranform = new TransformData(this.transform);
    }

    public override void Play()
    {
        this.rigidBody.isKinematic = false;
    }

    public override void Reset()
    {
        TransformData.AssignTransform(this.transform, OriginalTranform);
        this.rigidBody.isKinematic = true;
    }
}
