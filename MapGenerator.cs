using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

    public List<Vector2> points = new List<Vector2>();
    float x, y;
    int i = 0;

	void Start () {
        points.Add(new Vector2(0,0));  	
	}
	

	void Update () {
        if (i != 1000)
        {
            Vector2 actual =new Vector2(0,0);
            EdgeCollider2D edge = GetComponent<EdgeCollider2D>();
            actual = new Vector2(points[i].x + 0.09f,points[i].y + Random.Range(-10f,10f));
            points.Add(actual);
            edge.points = points.ToArray();
            i = i + 1;
        }
        
    }
}
