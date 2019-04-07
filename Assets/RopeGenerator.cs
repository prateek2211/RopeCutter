using UnityEngine;

public class RopeGenerator : MonoBehaviour
{
    public int links;
    public GameObject link;
    public Rigidbody2D previousLink;
    public GameObject weight;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < links; i++)
        {
            GameObject currentLink = Instantiate(link, transform);
            currentLink.GetComponent<HingeJoint2D>().connectedBody = previousLink;
            previousLink = currentLink.GetComponent<Rigidbody2D>();
        }
        HingeJoint2D hinge = weight.AddComponent<HingeJoint2D>();
        hinge.autoConfigureConnectedAnchor = false;
        hinge.anchor = Vector2.zero;
        hinge.connectedAnchor = new Vector2(0.0f, -0.6f);
        hinge.connectedBody = previousLink;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
