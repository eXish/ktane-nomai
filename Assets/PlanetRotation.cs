using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using System.Linq;
using Newtonsoft.Json;

public class PlanetRotation : MonoBehaviour {

    public MeshRenderer[] planets;
    public float rangeMin;
    public float rangeMax;

    private Vector3[] rotations = new Vector3[5];

    // Use this for initialization
    void Start () {
        for (int i = 0; i < planets.Length; i++) {
            rotations[i] = new Vector3(Random.Range(rangeMin, rangeMax), Random.Range(rangeMin, rangeMax), Random.Range(rangeMin, rangeMax));
        }
    }
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < planets.Length; i++)
        {
            planets[i].transform.Rotate(rotations[i]);
        }
	}
}
