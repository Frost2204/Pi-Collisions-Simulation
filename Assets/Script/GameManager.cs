using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public SmallBoxController smallBox;
    public HeavyBoxController heavyBox;
    public TextMeshProUGUI collisionText;
    public Button replayButton;
    public TMP_Dropdown massDropdown;

    public Transform smallBoxStartPos;
    public Transform heavyBoxStartPos;

    private int collisionCount = 0;
    public float hBoxV = 1f;

    void Start()
    {
        replayButton.interactable = false;
        massDropdown.onValueChanged.AddListener(delegate { ChangeMass(); });
        ResetGame();
    }

    void FixedUpdate() // ✅ Using FixedUpdate for physics accuracy
    {
        if (smallBox.transform.position.x >= heavyBox.transform.position.x - 0.5f)
        {
            smallBox.transform.position = new Vector3(heavyBox.transform.position.x - 0.5f, smallBox.transform.position.y, 0);
            smallBox.SetVelocity(0);
            RegisterCollision();
        }

        if (Mathf.Abs(smallBox.GetVelocity()) < 0.01f && Mathf.Abs(heavyBox.GetVelocity()) < 0.01f)
        {
            replayButton.interactable = true;
        }
    }

    public void RegisterCollision()
    {
        collisionCount++;
        collisionText.text = "Collisions: " + collisionCount;
        Debug.Log($"Collision Detected! Total Collisions: {collisionCount}");
    }

    public void ChangeMass()
    {
        float newMass = 1f;
        switch (massDropdown.value)
        {
            case 0: newMass = 1f; break;
            case 1: newMass = 100f; break;
            case 2: newMass = 10000f; break;
            case 3: newMass = 1000000f; break;
        }

        heavyBox.SetMass(newMass);
        ResetGame();
    }

    public void ResetGame()
    {
        if (smallBoxStartPos != null)
            smallBox.transform.position = smallBoxStartPos.position;
        else
            Debug.LogError("SmallBoxStartPos is not assigned!");

        if (heavyBoxStartPos != null)
            heavyBox.transform.position = heavyBoxStartPos.position;
        else
            Debug.LogError("HeavyBoxStartPos is not assigned!");

        smallBox.SetVelocity(0);
        heavyBox.SetVelocity(-hBoxV);

        if (heavyBox.GetMass() > 1000)
        {
            heavyBox.SetVelocity(-hBoxV);
        }

        collisionCount = 0;
        collisionText.text = "Collisions: 0";
        replayButton.interactable = false;

        Debug.Log($"Game Reset! Heavy Box Mass: {heavyBox.GetMass()}, Velocity: {heavyBox.GetVelocity()}");
    }
}
