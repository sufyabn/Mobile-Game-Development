using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class carcontroller : MonoBehaviour

{

    public float carSpeed = 10f; // speed of the car
    public int canCt;
    private Rigidbody carRigibody;
    public float tilt;
    [SerializeField] TMP_Text scoreText;

    void Start()
    {
        canCt = 0;
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


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "can")
        {
            canCt++;
            scoreText.text = canCt.ToString();
            Destroy(other.gameObject);
        }
    }


}
