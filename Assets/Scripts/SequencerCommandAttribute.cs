/* [REMOVE THIS LINE]
 * [REMOVE THIS LINE] To use this template, make a copy named SequencerCommand<YourCommand>, where
 * [REMOVE THIS LINE] "<YourCommand>" is the name of your sequencer command. Example: For a command
 * [REMOVE THIS LINE] named Foo, name the script SequencerCommandFoo.
 * [REMOVE THIS LINE]
 * [REMOVE THIS LINE] Then remove the lines that start with "[REMOVE THIS LINE]" and add your code
 * [REMOVE THIS LINE] where the comments indicate.
 * [REMOVE THIS LINE]

 
/**/

using UnityEngine;
using System.Collections;
using PixelCrushers.DialogueSystem;
using PlayMaker;

namespace PixelCrushers.DialogueSystem.SequencerCommands {

	public class SequencerCommandAttribute : SequencerCommand {

		public void Start() {
            // Add your initialization code here. You can use the GetParameter***() and GetSubject()
            // functions to get information from the command's parameters. You can also use the
            // Sequencer property to access the SequencerCamera, CameraAngle, Speaker, Listener,
            // and other properties on the sequencer. If IsAudioMuted() is true, the player has
            // muted audio.
            //
            // If your sequencer command only does something immediately and then finishes,
            // you can call Stop() here and remove the Update() method.
		    
            var fsm = Camera.main.gameObject.GetComponent< PlayMakerFSM > ();
		    var fieldName = GetParameter(0);
		    if (fsm.FsmVariables != null)
		    {
		        var attribute = fsm.FsmVariables.GetFsmInt(fieldName).Value;
		        attribute += int.Parse(GetParameter(1));
		        fsm.FsmVariables.FindFsmInt(fieldName).Value = attribute;
		    }

		    Stop();
            
		}
		
		
		
	}

}
 
