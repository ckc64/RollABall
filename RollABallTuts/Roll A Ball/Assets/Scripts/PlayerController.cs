
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private int count;
    public float speed;

    public Text countText;
    public Text winText;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        winText.text = "";
        setCountText();
    }

    void FixedUpdate()
    {
        float moveHori = Input.GetAxis("Horizontal");
        float moveVerti = Input.GetAxis("Vertical");

        Vector3 moveMent = new Vector3(moveHori,0.0f,moveVerti);
        rb.AddForce(moveMent * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        //Destroy(other.gameObject);
         
        if (other.gameObject.CompareTag("PickUp")) {
            other.gameObject.SetActive(false);
            count += 1;
            setCountText();
        }
    }


    void setCountText() {
        countText.text = "Count : " + count.ToString();

        if (count == 13) {
            winText.text = "YOU WIN";
        }
    }
}
