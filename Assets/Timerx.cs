using UnityEngine;
using TMPro;

public class Timerx : MonoBehaviour
{
    bool hasCom = false;
    float cntdnw = 30.0f;
    public TextMeshProUGUI disvar;


    public float get_time()
    {
        return cntdnw;
    } 
    void Update()
    {
        if (cntdnw > 0)
        {
            cntdnw -= Time.deltaTime;
        }
        double b = System.Math.Round(cntdnw, 2);
        disvar.text = b.ToString();
        if (cntdnw < 0 && !hasCom)
        {
            Debug.Log("Completed");
            hasCom = true;
        }
    }
}
