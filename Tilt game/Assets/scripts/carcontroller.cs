using UnityEngine;
using UnityEngine.UI;

public class carcontroller : MonoBehaviour

{
    public float carSpeed = 10f;
    public float coinCt;
    private Rigidbody carRigibody;
    public float tilt;
    [SerializeField] Text scoreText;

    private void Start()
    {
        coinCt = 0;
        carRigibody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        tilt = Input.acceleration.x * 90;
        Vector3 movement = transform.forward * carSpeed * Time.deltaTime;
        carRigibody.MovePosition(carRigibody.position + movement);
        Quaternion targetRotation = Quaternion.Euler(0, tilt, 0);
        carRigibody.MoveRotation(Quaternion.Lerp(carRigibody.rotation, targetRotation, 1 * Time.fixedDeltaTime));
    }

}
