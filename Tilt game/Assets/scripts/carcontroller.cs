using UnityEngine;
using UnityEngine.UI;

public class carcontroller : MonoBehaviour

{

    public float carSpeed = 10f; // speed of the car
    public float coinCt;
    private Rigidbody carRigibody;
    public float tilt;
    [SerializeField] Text scoreText;

    void Start()
    {
        coinCt = 0;
        carRigibody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        tilt = Input.acceleration.x * 90;// move forwards constantly
        tilt += 180;
        Vector3 movement = transform.forward * carSpeed * Time.deltaTime;
        carRigibody.MovePosition(carRigibody.position + movement);
        Quaternion targetRotation = Quaternion.Euler(0, tilt, 0);  //rotation speed
        carRigibody.MoveRotation(Quaternion.Lerp(carRigibody.rotation, targetRotation, 1 * Time.fixedDeltaTime));
    }

}
