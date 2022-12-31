using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Arrow;
    void Start()
    {

        InvokeRepeating("ArrowShot", 0, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            SceneManager.LoadScene("GameScene");

    }
    void ArrowShot()
    {
        Instantiate(Arrow, new Vector3(Random.Range(-3, 3), 10, 0), Quaternion.identity);
    }
}