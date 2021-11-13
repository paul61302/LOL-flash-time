using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer2 : MonoBehaviour
{
    public Text TOPtextTime;
    public Text JGtextTime;
    public Text MIDtextTime;
    public Text ADtextTime;
    public Text SUPtextTime;
    public float TOPflashtime = 0f;
    public float JGflashtime = 0f;
    public float MIDflashtime = 0f;
    public float ADflashtime = 0f;
    public float SUPflashtime = 0f;

    public void TOPCountTime()
    {
        if (TOPflashtime != 0) 
        {
            TOPflashtime -= Time.deltaTime;

            TOPflashtime = Mathf.Clamp(TOPflashtime, 0, 500);

            // 更新倒數時間介面 ToString("f小數點位數")
            TOPtextTime.text = TOPflashtime.ToString("f0");
        }
        if(TOPflashtime == 0)
        { 
            return;
        }
    }

    public void JGCountTime()
    {
        if (JGflashtime != 0)
        {
            JGflashtime -= Time.deltaTime;

            JGflashtime = Mathf.Clamp(JGflashtime, 0, 500);

            // 更新倒數時間介面 ToString("f小數點位數")
            JGtextTime.text = JGflashtime.ToString("f0");
        }
        if (JGflashtime == 0)
        {
            return;
        }
    }

    public void MIDCountTime()
    {
        if (MIDflashtime != 0)
        {
            MIDflashtime -= Time.deltaTime;

            MIDflashtime = Mathf.Clamp(MIDflashtime, 0, 500);

            // 更新倒數時間介面 ToString("f小數點位數")
            MIDtextTime.text = MIDflashtime.ToString("f0");
        }
        if (MIDflashtime == 0)
        {
            return;
        }
    }

    public void ADCountTime()
    {
        if (ADflashtime != 0)
        {
            ADflashtime -= Time.deltaTime;

            ADflashtime = Mathf.Clamp(ADflashtime, 0, 500);

            // 更新倒數時間介面 ToString("f小數點位數")
            ADtextTime.text = ADflashtime.ToString("f0");
        }
        if (ADflashtime == 0)
        {
            return;
        }
    }
    
    public void SUPCountTime()
    {
        if (SUPflashtime != 0)
        {
            SUPflashtime -= Time.deltaTime;

            SUPflashtime = Mathf.Clamp(SUPflashtime, 0, 500);

            // 更新倒數時間介面 ToString("f小數點位數")
            SUPtextTime.text = SUPflashtime.ToString("f0");
        }
        if (SUPflashtime == 0)
        {
            return;
        }
    }

    public void TOPtime300()
    {
        TOPflashtime = 300f;        
    }

    public void JGtime300()
    {        
        JGflashtime = 300f;       
    }
    public void MIDtime300()
    {        
        MIDflashtime = 300f;        
    }
    public void ADtime300()
    {
        ADflashtime = 300f;
    }
    public void SUPtime300()
    {        
        SUPflashtime = 300f;
    }

    private void Start()
    {
        TOPflashtime = 0f;
        JGflashtime = 0f;
        MIDflashtime = 0f;
        ADflashtime = 0f;
        SUPflashtime = 0f;
    }

    private void Update()
    {
        TOPCountTime();
        JGCountTime();
        MIDCountTime();
        ADCountTime();
        SUPCountTime();
    }

}
