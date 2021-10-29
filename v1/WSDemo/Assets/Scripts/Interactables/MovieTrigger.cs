using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovieTrigger : MonoBehaviour
{
    public MovieScreen movie;
    private void OnTriggerEnter(Collider other)
    {
        if(movie.hasWatched)
            movie.PauseVideo();
    }
}
