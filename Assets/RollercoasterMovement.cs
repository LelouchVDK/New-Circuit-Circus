using UnityEngine;
using UnityEngine.Splines;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RollercoasterMovement : MonoBehaviour
{

    [SerializeField] SplineAnimate spline;


    void Start()
    {
        spline.Play();
        spline.MaxSpeed = ValueManagement.voltage;
    }
    
    void Update()
    {
        if (!spline.IsPlaying)
        {
            SceneManager.LoadScene("OpeningScene");
        
        }
    }
    
    

}
