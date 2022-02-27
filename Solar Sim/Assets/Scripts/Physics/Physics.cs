using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour
{
    ////Mass of the current planet for gravitational calculations
    //[SerializeField]
    //public float planetMass = 1.0f;

    ////Orbit Directional Vector split into 2
    //[SerializeField]
    //[Range(-1, 1)]
    //private float verticalDirection = 0.0f;
    //[SerializeField]
    //[Range(-1, 1)]
    //private float horizontalDirection = 1.0f;

    //Speed to rotate the planet
    [SerializeField]
    private float rotationSpeed = 10.0f;

    ////Radius of the orbit
    //[SerializeField]
    //private float distanceFromPlanet = 10.0f;

    //[SerializeField]
    //private GameObject centralObject;

    //private float timeToOrbit = 10.0f;
    //private const float G = 0.000000000066f; //Gravitational Constant
    //private bool orbiting = false; //If the object is orbiting something
    //private float gravitationalForce = 0.0f; //Force of the central body on this object
    //private Vector3 orbitDirection; //Store orbital direction in a Vector3
    //private float centralMass; //Variable to store the central object's mass
    //private float orbitVelocity; //Variable to store the orbit velocity
    //private Vector3 centralLocation; //Variable to store the orbit's centre
    //private Vector3 currentLocation; //Variable to store the orbiting body's current location
    //private Vector3 gravitationalPull; //Variable storing direction of gravitational pull

    void Start()
    {
        //if (centralObject != null)
        //{
        //    if (centralObject.GetComponent<Physics>() != null)
        //    {
        //        if (verticalDirection > 0.0f || horizontalDirection > 0.0f)
        //        {
                    //orbiting = true;
                    //orbitDirection = new Vector3(horizontalDirection, verticalDirection, 0.0f).normalized;
                    //centralMass = centralObject.GetComponent<Physics>().planetMass;
                    //centralLocation = centralObject.transform.position;
                    ////work out the force required to maintain an orbit
                    //orbitVelocity = ((2 * Mathf.PI * (distanceFromPlanet * 2)) / timeToOrbit);
        //        }
        //    }
        //}
    }

    void Update()
    {
        //if (orbiting)
        //{
        //}
        this.transform.Rotate(0.0f, rotationSpeed * Time.deltaTime, 0.0f, Space.Self);
    }

    //Doesn't Work
    //public Vector3 UpdateOrbit()
    //{
    //    //First work out the force to apply to the directional vector
    //    gravitationalForce = G * ((centralMass * planetMass) / (distanceFromPlanet * distanceFromPlanet));

    //    //Multiply the orbit direction by the orbit velocity & get the planet's current location
    //    orbitDirection *= orbitVelocity;
    //    currentLocation = this.transform.position;

    //    //Work out direction vector to planet and multiply it by the gravitational force
    //    gravitationalPull = (centralLocation - currentLocation).normalized;
    //    gravitationalPull *= gravitationalForce;

    //    orbitDirection = (orbitDirection + gravitationalPull).normalized;
        
    //    return (orbitDirection);
    //}
}