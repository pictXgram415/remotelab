using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
public class desk : MonoBehaviour
{
    // Start is called before the first frame update
    public float mocX, mocY;
    public float expansion;
    public GameObject moc;

    private bool hidden;
    private GameObject studentSomeone;
    private void OnMouseUp()
    {
        Debug.Log("onclicked");
        if (hidden)
        {
            Debug.Log("can you watch me?");
            this.studentSomeone.layer = LayerMask.NameToLayer("Default");
            this.hidden = false;
        }
        else
        {
            Debug.Log("erase moc");
            this.studentSomeone.layer = LayerMask.NameToLayer("Hidden");
            this.hidden = true;
        }
    }
    void Start()
    {
        this.studentSomeone = Instantiate(moc) as GameObject;
        this.hidden = true;

        this.studentSomeone.layer = LayerMask.NameToLayer("Hidden");
        this.studentSomeone.transform.localScale = new Vector3(expansion, expansion, 0);
        this.studentSomeone.transform.position = new Vector3(mocX, mocY, 0);


    }

    // Update is called once per frame


}
