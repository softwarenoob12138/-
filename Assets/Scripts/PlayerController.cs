using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text countText;

    private int count = 0;

    private Rigidbody rb;

    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("游戏开始了");

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal");

        var y = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(x, 0, y) * moveSpeed);
    }

        private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);

        count++;

        countText.text = "Count: " + count.ToString();

    }
}



