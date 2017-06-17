
using System.Collections;
using UnityHttpReq;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
public class PluginController : MonoBehaviour {

  bool isRecording = true;
  public AudioSource audioSource;
  //temporary audio vector we write to every second while recording is enabled..
  List<float> tempRecording = new List<float>();

  //list of recorded clips...
  List<float[]> recordedClips = new List<float[]>();
    // NLP_Processing is the code that processes the response from wit.ai
  NLP_Processing processor;
  private bool recording = false;
  private bool enRec = true;
  private string speechfilename = "";
	// Use this for initialization
  private System.Timers.Timer speechTimer = new System.Timers.Timer();


	void Start () {
    //set up recording to last a max of 1 seconds and loop over and over
    //audioSource.Play();
    //resize our temporary vector every second
    Invoke("ResizeRecording", 1);
        processor = new NLP_Processing();
    //audioSource = GetComponent<AudioSource>();

	}

  void ResizeRecording()
  {
      if (isRecording)
      {
          //add the next second of recorded audio to temp vector
          int length = 44100;
          float[] clipData = new float[length];
          audioSource.clip.GetData(clipData, 0);
          tempRecording.AddRange(clipData);
          Invoke("ResizeRecording", 1);
      }
  }
  /*
	void FixedUpdate () {

    if (Input.GetKeyDown (KeyCode.R)) {
      if(enRec) SwitchRecord();
    }
    processor.ProcessSpokenFile();
  }*/

  	private void SwitchRecord(){

  		if (!recording)
  		{
  			recording = true;
  			string tempfile = "/home/amauey/.config/unity3d/DefaultCompany/SI28 projet/amaurytest.wav";

  			speechfilename = @tempfile;

  			speechTimer.Enabled = true;
  		}
  		else
  		{
  			recording = false;
  			speechTimer.Enabled = false;
  			enRec = false;

  			processor.ProcessSpokenFile();

  			enRec = true;
  		}
    }
      void Update()
        {
            //space key triggers recording to start...
            if (Input.GetKeyDown("r")) {
              SavWav.Save("amaurytest", audioSource.clip);
            }
            if(Input.GetKeyDown("s")) {
              print("debut");
              processor.ProcessSpokenFile();
            }
            if (Input.GetKeyDown("y")) {
              audioSource.clip = Microphone.Start("Built-in Microphone", false, 5, 44100);
            }
        }

        //chooose which clip to play based on number key..
        void SwitchClips(int index)
        {
            if (index < recordedClips.Count)
            {
                audioSource.Stop();
                int length = recordedClips[index].Length;
                audioSource.clip = AudioClip.Create("recorded samples", length, 1, 44100, false);
                audioSource.clip.SetData(recordedClips[index], 0);
                audioSource.loop = true;
                audioSource.Play();
            }
        }

}
