using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(CubeViewModel))]
public class CubeManager : MonoBehaviour
{
    private List<Color> colorList;

    private CubeViewModel cube;
    private GUIHandlers guiHandlers;

    private Vector3 cachedAngles;

    public void Initialize(GUIHandlers guiHandlersPassed)
    {
        this.cube = this.gameObject.GetComponent<CubeViewModel>();

        this.guiHandlers = guiHandlersPassed;
        this.guiHandlers.OnRotateX += OnRotateX;
        this.guiHandlers.OnRotateY += OnRotateY;
        this.guiHandlers.OnRotateZ += OnRotateZ;
        this.guiHandlers.OnScaleX += OnScaleX;
        this.guiHandlers.OnScaleY += OnScaleY;
        this.guiHandlers.OnScaleZ += OnScaleZ;

        cachedAngles = cube.transform.rotation.eulerAngles;


        colorList = new List<Color>();

        colorList.Add(Color.red);
        colorList.Add(Color.black);
        colorList.Add(Color.blue);
        colorList.Add(Color.cyan);
        colorList.Add(Color.green);
        colorList.Add(Color.magenta);
        colorList.Add(Color.yellow);
    }

    void OnCollisionEnter(Collision collidedObject)
    {
        if (collidedObject.gameObject.tag == "Sphere")
            this.gameObject.GetComponent<Renderer>().material.color = PickRandomColor();
    }

    Color PickRandomColor()
    {
        return colorList[Random.Range(0, colorList.Count)];
    }

    void OnRotateX(float val)
    {
        cube.transform.rotation = Quaternion.Euler(new Vector3(val, cachedAngles.y - 180, cachedAngles.z));
    }

    void OnRotateY(float val)
    {
        cube.transform.rotation = Quaternion.Euler(new Vector3(cube.transform.rotation.eulerAngles.x, val, cube.transform.rotation.eulerAngles.z));
        cachedAngles = cube.transform.rotation.eulerAngles;
    }

    void OnRotateZ(float val)
    {
        cube.transform.rotation = Quaternion.Euler(new Vector3(cube.transform.rotation.eulerAngles.x, cube.transform.rotation.eulerAngles.y, val));
        cachedAngles = cube.transform.rotation.eulerAngles;
    }

    void OnScaleX(float val)
    {
        cube.transform.localScale = new Vector3(val, cube.transform.localScale.y, cube.transform.localScale.z);
    }

    void OnScaleY(float val)
    {
        cube.transform.localScale = new Vector3(cube.transform.localScale.x, val, cube.transform.localScale.z);
    }

    void OnScaleZ(float val)
    {
        cube.transform.localScale = new Vector3(cube.transform.localScale.x, cube.transform.localScale.y, val);
    }
}
