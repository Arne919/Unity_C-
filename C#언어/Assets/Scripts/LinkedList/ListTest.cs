using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Node node1 = new Node();
        node1.data = 1;

        Node node2 = new Node();
        node1.data = 2;

        Node node3 = new Node();
        node1.data = 3;

        Debug.Log(node1.data); //1

        node1.next = node2;
        Debug.Log(node1.next.data); //2

        node1.next.next = node3;
        Debug.Log(node1.next.next.data); //3
    }


}
